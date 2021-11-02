
using System;
using System.Windows.Forms;

namespace LinuxTTSPlugin
{
    public partial class LinuxTTSPlugin : UserControl
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
            this.opnTTS = new System.Windows.Forms.OpenFileDialog();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTTSBinary = new System.Windows.Forms.Label();
            this.lblArguments = new System.Windows.Forms.Label();
            this.lblPipe = new System.Windows.Forms.Label();
            this.txtTTSBinaryPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblUseSocket = new System.Windows.Forms.Label();
            this.chkUsePipe = new System.Windows.Forms.CheckBox();
            this.chkUseSocket = new System.Windows.Forms.CheckBox();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.tabs.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // opnTTS
            // 
            this.opnTTS.FileName = "Select TTS Binary";
            this.opnTTS.FileOk += new System.ComponentModel.CancelEventHandler(this.OpnTTS_FileOk);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tpSettings);
            this.tabs.Controls.Add(this.tpLog);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(680, 380);
            this.tabs.TabIndex = 1;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tableLayoutPanel1);
            this.tpSettings.Location = new System.Drawing.Point(0, 20);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(680, 360);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblTTSBinary, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblArguments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPipe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTTSBinaryPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectBinary, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtArguments, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkUsePipe, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkUseSocket, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUseSocket, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHost, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPort, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 360);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTTSBinary
            // 
            this.lblTTSBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTTSBinary.AutoSize = true;
            this.lblTTSBinary.Location = new System.Drawing.Point(3, 50);
            this.lblTTSBinary.Name = "lblTTSBinary";
            this.lblTTSBinary.Size = new System.Drawing.Size(70, 25);
            this.lblTTSBinary.TabIndex = 8;
            this.lblTTSBinary.Text = "TTS Binary";
            this.lblTTSBinary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArguments
            // 
            this.lblArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(3, 0);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(70, 25);
            this.lblArguments.TabIndex = 0;
            this.lblArguments.Text = "Arguments";
            this.lblArguments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPipe
            // 
            this.lblPipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPipe.AutoSize = true;
            this.lblPipe.Location = new System.Drawing.Point(3, 25);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(70, 25);
            this.lblPipe.TabIndex = 5;
            this.lblPipe.Text = "Use Pipe";
            this.lblPipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPipe
            // 
            this.lblUseSocket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUseSocket.AutoSize = true;
            this.lblUseSocket.Location = new System.Drawing.Point(3, 25);
            this.lblUseSocket.Name = "lblPipe";
            this.lblUseSocket.Size = new System.Drawing.Size(70, 25);
            this.lblUseSocket.TabIndex = 5;
            this.lblUseSocket.Text = "Use Socket";
            this.lblUseSocket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTTSBinaryPath
            // 
            this.txtTTSBinaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTSBinaryPath.Location = new System.Drawing.Point(75, 50);
            this.txtTTSBinaryPath.Name = "txtTTSBinaryPath";
            this.txtTTSBinaryPath.ReadOnly = true;
            this.txtTTSBinaryPath.Size = new System.Drawing.Size(440, 20);
            this.txtTTSBinaryPath.TabIndex = 7;
            this.txtTTSBinaryPath.Text = "Z:\\usr\\bin\\espeak";
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(75, 50);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(440, 20);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(75, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(440, 20);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "5555";
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectBinary.Location = new System.Drawing.Point(525, 60);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(150, 20);
            this.btnSelectBinary.TabIndex = 10;
            this.btnSelectBinary.Text = "Select TTS Binary";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.BtnSelectBinary_Click);
            // 
            // txtArguments
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtArguments, 2);
            this.txtArguments.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArguments.Location = new System.Drawing.Point(75, 3);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(600, 20);
            this.txtArguments.TabIndex = 11;
            this.txtArguments.Text = "-a 15 -g 0 -p 50 -s 175";
            this.txtArguments.Leave += new System.EventHandler(this.TxtArguments_Leave);
            // 
            // chkUsePipe
            // 
            this.chkUsePipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePipe.AutoSize = true;
            this.chkUsePipe.Location = new System.Drawing.Point(75, 30);
            this.chkUsePipe.Name = "chkUsePipe";
            this.chkUsePipe.Size = new System.Drawing.Size(20, 20);
            this.chkUsePipe.TabIndex = 12;
            this.chkUsePipe.UseVisualStyleBackColor = true;
            this.chkUsePipe.CheckedChanged += new System.EventHandler(this.ChkUsePipe_CheckedChanged);
            // 
            // chkUseSocket
            // 
            this.chkUseSocket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUseSocket.AutoSize = true;
            this.chkUseSocket.Location = new System.Drawing.Point(75, 30);
            this.chkUseSocket.Name = "chkUseSock";
            this.chkUseSocket.Size = new System.Drawing.Size(20, 20);
            this.chkUseSocket.TabIndex = 13;
            this.chkUseSocket.UseVisualStyleBackColor = true;
            this.chkUseSocket.CheckedChanged += new System.EventHandler(this.ChkUseSocket_CheckChanged);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.lstLogs);
            this.tpLog.Location = new System.Drawing.Point(5, 5);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(680, 360);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "Logs";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // lstLogs
            // 
            this.lstLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(3, 3);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(680, 360);
            this.lstLogs.TabIndex = 0;
            // 
            // LinuxTTSPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "LinuxTTSPlugin";
            this.Size = new System.Drawing.Size(680, 360);
            this.tabs.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion
        private TabControl tabs;
        private TabPage tpSettings;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTTSBinary;
        private Label lblArguments;
        private Label lblPipe;
        private Label lblUseSocket;
        private TextBox txtTTSBinaryPath;
        private TextBox txtHost;
        private TextBox txtPort;
        private Button btnSelectBinary;
        private TextBox txtArguments;
        private CheckBox chkUsePipe;
        private CheckBox chkUseSocket;
        private TabPage tpLog;
        private ListBox lstLogs;
        private OpenFileDialog opnTTS;

        private void BtnSelectBinary_Click(object sender, EventArgs e)
        {
            opnTTS.ShowDialog();
        }

        private void OpnTTS_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtTTSBinaryPath.Text = opnTTS.FileName;
            ttsHandler.Command = opnTTS.FileName;
            if (chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            }
        }

        private void ChkUseSocket_CheckChanged(object sender, EventArgs eventArgs)
        {
            if (chkUsePipe.Checked && chkUseSocket.Checked)
            {
                ttsHandler.Close();
                ttsHandler.Command = txtHost.Text;
                ttsHandler.CommandArguments = txtPort.Text;
            }
            else if (chkUsePipe.Checked && !chkUseSocket.Checked)
            {
                ttsHandler.Command = txtTTSBinaryPath.Text;
                ttsHandler.CommandArguments = txtArguments.Text;
                ttsHandler.Open();
            }
            else
            {
                ttsHandler.Command = txtTTSBinaryPath.Text;
                ttsHandler.CommandArguments = txtArguments.Text;
            }
        }

        private void ChkUsePipe_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkUseSocket.Checked && chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            } else if(chkUseSocket.Checked) {
                ttsHandler.Close();
                ttsHandler.Command = txtHost.Text;
                ttsHandler.CommandArguments = txtPort.Text;
            }
            else
            {
                ttsHandler.Close();
            }
        }

        private void TxtArguments_Leave(object sender, EventArgs e)
        {
            ttsHandler.CommandArguments = txtArguments.Text;
            if (chkUsePipe.Checked)
            {
                ttsHandler.CommandArguments += " --stdin";
                ttsHandler.Restart();
            }
        }
    }
}
