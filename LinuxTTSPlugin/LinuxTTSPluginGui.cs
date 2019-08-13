
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblArguments = new System.Windows.Forms.Label();
            this.lblPipe = new System.Windows.Forms.Label();
            this.txtTTSBinaryPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.lblTTSBinary = new System.Windows.Forms.Label();
            this.chkUsePipe = new System.Windows.Forms.CheckBox();
            this.opnTTS = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.lblArguments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPipe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTTSBinaryPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectBinary, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtArguments, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTTSBinary, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkUsePipe, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblArguments
            // 
            this.lblArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(3, 0);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(69, 26);
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
            this.lblPipe.Location = new System.Drawing.Point(3, 26);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(69, 26);
            this.lblPipe.TabIndex = 5;
            this.lblPipe.Text = "Use Pipe";
            this.lblPipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTTSBinaryPath
            // 
            this.txtTTSBinaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTSBinaryPath.Location = new System.Drawing.Point(78, 55);
            this.txtTTSBinaryPath.Name = "txtTTSBinaryPath";
            this.txtTTSBinaryPath.ReadOnly = true;
            this.txtTTSBinaryPath.Size = new System.Drawing.Size(449, 20);
            this.txtTTSBinaryPath.TabIndex = 9;
            this.txtTTSBinaryPath.Text = "Z:\\usr\\bin\\espeak";
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectBinary.Location = new System.Drawing.Point(533, 55);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(144, 20);
            this.btnSelectBinary.TabIndex = 10;
            this.btnSelectBinary.Text = "Select TTS Binary";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.btnSelectBinary_Click);
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtArguments, 2);
            this.txtArguments.Location = new System.Drawing.Point(78, 3);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(599, 20);
            this.txtArguments.TabIndex = 11;
            this.txtArguments.Text = "-a 15 -g 0 -p 50 -s 175";
            this.txtArguments.Leave += new System.EventHandler(this.txtArguments_Leave);
            // 
            // lblTTSBinary
            // 
            this.lblTTSBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTTSBinary.AutoSize = true;
            this.lblTTSBinary.Location = new System.Drawing.Point(3, 52);
            this.lblTTSBinary.Name = "lblTTSBinary";
            this.lblTTSBinary.Size = new System.Drawing.Size(69, 26);
            this.lblTTSBinary.TabIndex = 8;
            this.lblTTSBinary.Text = "TTS Binary";
            this.lblTTSBinary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUsePipe
            // 
            this.chkUsePipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePipe.AutoSize = true;
            this.chkUsePipe.Checked = true;
            this.chkUsePipe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsePipe.Location = new System.Drawing.Point(78, 29);
            this.chkUsePipe.Name = "chkUsePipe";
            this.chkUsePipe.Size = new System.Drawing.Size(15, 20);
            this.chkUsePipe.TabIndex = 12;
            this.chkUsePipe.UseVisualStyleBackColor = true;
            this.chkUsePipe.CheckedChanged += new System.EventHandler(this.chkUsePipe_CheckedChanged);
            // 
            // opnTTS
            // 
            this.opnTTS.FileName = "Select TTS Binary";
            this.opnTTS.FileOk += new System.ComponentModel.CancelEventHandler(this.opnTTS_FileOk);
            // 
            // LinuxTTSPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LinuxTTSPlugin";
            this.Size = new System.Drawing.Size(686, 384);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #endregion
        
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox chkUsePipe;
        private Label lblArguments;
        private Label lblTTSBinary;
        private Label lblPipe;
        private TextBox txtTTSBinaryPath;
        private Button btnSelectBinary;
        private TextBox txtArguments;
        private OpenFileDialog opnTTS;
        
        private void btnSelectBinary_Click(object sender, EventArgs e)
        {
            opnTTS.ShowDialog();
        }

        private void opnTTS_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtTTSBinaryPath.Text = opnTTS.FileName;
            ttsHandler.Command = opnTTS.FileName;
            if(chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            }
        }

        private void chkUsePipe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            } else
            {
                ttsHandler.Close();
            }
        }

        private void txtArguments_Leave(object sender, EventArgs e)
        {
            ttsHandler.CommandArguments = txtArguments.Text;
            if (chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            }
        }
    }
}
