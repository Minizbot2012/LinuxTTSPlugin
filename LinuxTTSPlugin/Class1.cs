
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Advanced_Combat_Tracker;

namespace LinuxTTSPlugin
{
    public class Plugin : UserControl, IActPluginV1
    {
        #region Designer Created Code (Avoid editing)
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.labelVolume = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.pitch = new System.Windows.Forms.NumericUpDown();
            this.gap = new System.Windows.Forms.NumericUpDown();
            this.labelGap = new System.Windows.Forms.Label();
            this.labelTTS = new System.Windows.Forms.Label();
            this.TTSBinPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.opnTTS = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gap)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.speed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVolume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.volume, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSpeed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPitch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pitch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gap, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelGap, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTTS, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TTSBinPath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectBinary, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // speed
            // 
            this.speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.speed.Location = new System.Drawing.Point(69, 29);
            this.speed.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.speed.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(120, 20);
            this.speed.TabIndex = 3;
            this.speed.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.speed.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(3, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(60, 26);
            this.labelVolume.TabIndex = 0;
            this.labelVolume.Text = "Volume";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.volume.Location = new System.Drawing.Point(69, 3);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(120, 20);
            this.volume.TabIndex = 1;
            this.volume.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.volume.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(3, 26);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(60, 26);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPitch
            // 
            this.labelPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPitch.AutoSize = true;
            this.labelPitch.Location = new System.Drawing.Point(3, 52);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(60, 26);
            this.labelPitch.TabIndex = 4;
            this.labelPitch.Text = "Pitch";
            this.labelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pitch
            // 
            this.pitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pitch.Location = new System.Drawing.Point(69, 55);
            this.pitch.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(120, 20);
            this.pitch.TabIndex = 6;
            this.pitch.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.pitch.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // gap
            // 
            this.gap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gap.Location = new System.Drawing.Point(69, 81);
            this.gap.Name = "gap";
            this.gap.Size = new System.Drawing.Size(120, 20);
            this.gap.TabIndex = 7;
            this.gap.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // labelGap
            // 
            this.labelGap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGap.AutoSize = true;
            this.labelGap.Location = new System.Drawing.Point(3, 78);
            this.labelGap.Name = "labelGap";
            this.labelGap.Size = new System.Drawing.Size(60, 26);
            this.labelGap.TabIndex = 5;
            this.labelGap.Text = "Gap";
            this.labelGap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTTS
            // 
            this.labelTTS.AutoSize = true;
            this.labelTTS.Location = new System.Drawing.Point(3, 104);
            this.labelTTS.Name = "labelTTS";
            this.labelTTS.Size = new System.Drawing.Size(60, 13);
            this.labelTTS.TabIndex = 8;
            this.labelTTS.Text = "TTS Binary";
            this.labelTTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TTSBinPath
            // 
            this.TTSBinPath.Location = new System.Drawing.Point(69, 107);
            this.TTSBinPath.Name = "TTSBinPath";
            this.TTSBinPath.ReadOnly = true;
            this.TTSBinPath.Size = new System.Drawing.Size(406, 20);
            this.TTSBinPath.TabIndex = 9;
            this.TTSBinPath.Text = "Z:\\usr\\bin\\espeak";
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.Location = new System.Drawing.Point(481, 107);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(114, 23);
            this.btnSelectBinary.TabIndex = 10;
            this.btnSelectBinary.Text = "Select TTS Binary";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.btnSelectBinary_Click);
            // 
            // opnTTS
            // 
            this.opnTTS.FileName = "Select TTS Binary";
            this.opnTTS.FileOk += new System.ComponentModel.CancelEventHandler(this.opnTTS_FileOk);
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Plugin";
            this.Size = new System.Drawing.Size(686, 384);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #endregion

        private FormActMain.PlayTtsDelegate oldTTSMethod;

        Process ttsProc = null;

        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\TermTTS.config.xml");
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown speed;
        private NumericUpDown volume;
        private NumericUpDown pitch;
        private NumericUpDown gap;
        private Label labelVolume;
        private Label labelTTS;
        private Label labelSpeed;
        private Label labelPitch;
        private Label labelGap;
        private TextBox TTSBinPath;
        private Button btnSelectBinary;
        private OpenFileDialog opnTTS;
        SettingsSerializer xmlSettings;

        public Plugin()
        {
            InitializeComponent();
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();

            oldTTSMethod = ActGlobals.oFormActMain.PlayTtsMethod;
            lblStatus.Text = "Plugin Started";
            initTtsProc();
            ActGlobals.oFormActMain.PlayTtsMethod = new FormActMain.PlayTtsDelegate(PlayTTS);
            

        }
        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.PlayTtsMethod = oldTTSMethod;
            closeTtsProc();

            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }

        void PlayTTS_Single(string text)
        {
            ttsProc = new Process
            {
                StartInfo = {
                    FileName = TTSBinPath.Text,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    Arguments = "-a " + volume.Value +
                        " -g " + gap.Value +
                        " -p " + pitch.Value +
                        " -s " + speed.Value +
                        " \"" + Regex.Replace(Regex.Replace(text, @"(\\*)"+"\"", @"$1$1\"+"\""), @"(\\+)$", @"$1$1") + "\"",
                    RedirectStandardInput = true
                }
            };
            ttsProc.Exited += new EventHandler(delegate (object o, EventArgs e) { ttsProc = null; });
            ttsProc.Start();
        }

        void PlayTTS(string text)
        {
            if (ttsProc == null)
            {
                initTtsProc();
            }
            ttsProc.StandardInput.Write(text.ToLower());
            ttsProc.StandardInput.WriteLine();
            ttsProc.StandardInput.Flush();
        }

        void initTtsProc()
        {
            if (ttsProc == null)
            {
                try
                {
                    ttsProc = new Process
                    {
                        StartInfo = {
                            FileName = TTSBinPath.Text,
                            CreateNoWindow = true,
                            UseShellExecute = false,
                            Arguments = "-a " + volume.Value +
                                " -g " + gap.Value +
                                " -p " + pitch.Value +
                                " -s " + speed.Value,
                            RedirectStandardInput = true
                        }
                    };
                    ttsProc.Exited += new EventHandler(delegate (object o, EventArgs e) { ttsProc = null; });
                    ttsProc.Start();
                    lblStatus.Text = "TTS Program Engaged";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "TTS Program Startup Failed";
                    ttsProc = null;
                }
            }
        }

        void closeTtsProc()
        {
            if (ttsProc != null)
            {
                ttsProc.Kill();
                ttsProc = null;
            }
        }



        void LoadSettings()
        {
            // Add any controls you want to save the state of
            xmlSettings.AddControlSetting(volume.Name, volume);
            xmlSettings.AddControlSetting(speed.Name, speed);
            xmlSettings.AddControlSetting(pitch.Name, pitch);
            xmlSettings.AddControlSetting(gap.Name, gap);
            xmlSettings.AddControlSetting(TTSBinPath.Name, TTSBinPath);

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
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                }
                xReader.Close();
            }
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


        private void btnSelectBinary_Click(object sender, EventArgs e)
        {
            opnTTS.ShowDialog();
        }

        private void opnTTS_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TTSBinPath.Text = opnTTS.FileName;
            closeTtsProc();
            initTtsProc();
        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            // whenever we change this save it and open a new TTS process //
            SaveSettings();
            closeTtsProc();
            initTtsProc();
        }
    }
}
