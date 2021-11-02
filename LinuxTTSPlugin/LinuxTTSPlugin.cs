using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Advanced_Combat_Tracker;

namespace LinuxTTSPlugin
{
    public partial class LinuxTTSPlugin : IActPluginV1
    {
        private FormActMain.PlayTtsDelegate oldTTSMethod;
        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        readonly string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\LinuxTTSPlugin.config.xml");
        SettingsSerializer xmlSettings;
        private TTSHandler ttsHandler;
        public LinuxTTSPlugin()
        {
            InitializeComponent();
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            ttsHandler = new TTSHandler(lstLogs);
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();
            ttsHandler.Command = txtTTSBinaryPath.Text;
            ttsHandler.CommandArguments = txtArguments.Text;
            oldTTSMethod = ActGlobals.oFormActMain.PlayTtsMethod;
            lblStatus.Text = "Plugin Started";

            if (chkUsePipe.Checked)
            {
                ttsHandler.Open();
            }

            ActGlobals.oFormActMain.PlayTtsMethod = new FormActMain.PlayTtsDelegate(PlayTTS);
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.PlayTtsMethod = oldTTSMethod;

            if (chkUsePipe.Checked)
            {
                if (!ttsHandler.Close())
                {
                    Console.WriteLine(ttsHandler.LastException.ToString());
                    Console.WriteLine("Exception trying to close TTS Process:" + Environment.NewLine + Environment.NewLine + ttsHandler.LastException.ToString());
                }
            }
            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }

        void PlayTTS(string text)
        {
            if (chkUsePipe.Checked)
            {
                ttsHandler.Play(text);
            }
            else
            {
                ttsHandler.PlaySingle(text);
            }
        }

        void LoadSettings()
        {
            // Add any controls you want to save the state of
            xmlSettings.AddControlSetting(txtArguments.Name, txtArguments);
            xmlSettings.AddControlSetting(chkUsePipe.Name, chkUsePipe);
            xmlSettings.AddControlSetting(txtTTSBinaryPath.Name, txtTTSBinaryPath);
            xmlSettings.AddControlSetting(chkUseSocket.Name, chkUseSocket);
            xmlSettings.AddControlSetting(txtHost.Name, txtHost);
            xmlSettings.AddControlSetting(txtPort.Name, txtPort);
            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);

                try
                {
                    while (xReader.Read())
                    {
                        if (xReader.NodeType == XmlNodeType.Element)
                        {
                            if (xReader.LocalName == "SettingsSerializer")
                            {
                                xmlSettings.ImportFromXml(xReader);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lstLogs.Items.Add("Error loading settings: " + ex.Message);
                }
                xReader.Close();
            }

            ttsHandler.CommandArguments = txtArguments.Text;
            ttsHandler.Command = txtTTSBinaryPath.Text;
        }

        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteStartElement("SettingsSerializer");    // <Config><SettingsSerializer>
            xmlSettings.ExportToXml(xWriter);   // Fill the SettingsSerializer XML
            xWriter.WriteEndElement();  // </SettingsSerializer>
            xWriter.WriteEndElement();  // </Config>
            xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
            xWriter.Flush();    // Flush the file buffer to disk
            xWriter.Close();
        }
    }
}
