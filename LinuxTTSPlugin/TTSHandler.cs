using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace LinuxTTSPlugin
{
    class TTSHandler
    {
        public string Command { get; set; }
        public string CommandArguments { get; set; }

        public Exception LastException { get; private set; }

        private Process process;

        public TTSHandler()
        {
            this.Open(); // to use a process we have to start it first!!
        }

        public bool Open()
        {
            if (process == null)
            {
                try
                {
                    process = new Process
                    {
                        StartInfo = {
                            FileName = Command,
                            CreateNoWindow = true,
                            UseShellExecute = false,
                            Arguments = CommandArguments,
                            RedirectStandardInput = true
                        }
                    };
                    process.Exited += new EventHandler(delegate (object o, EventArgs e) { process = null; });
                    process.Start();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    this.LastException = ex;
                    process = null;
                }
            }
            return false;
        }

        public void Play(string text)
        {
            try
            {
                if (process == null)
                {
                    Open();
                }
                process.StandardInput.Write(text.ToLower());
                process.StandardInput.WriteLine();
                process.StandardInput.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.LastException = ex;
            }
        }

        public void PlaySingle(string text)
        {
            try
            {
                Process tempProcess = new Process
                {
                    StartInfo = {
                        FileName = Command,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        Arguments = CommandArguments + " \"" + Regex.Replace(Regex.Replace(text, @"(\\*)"+"\"", @"$1$1\"+"\""), @"(\\+)$", @"$1$1") + "\""
                    }
                };
                tempProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.LastException = ex;
            }
        }

        public bool Close()
        {
            try
            {
                if (process != null)
                {
                    process.Kill();
                    process = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                process = null;
                Console.WriteLine(ex.ToString());
                this.LastException = ex;
            }
            return false;
        }

        public void Restart()
        {
            Close();
            Open();
        }
    }
}
