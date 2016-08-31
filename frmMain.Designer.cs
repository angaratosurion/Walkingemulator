namespace Walkingemulator
{
    partial class frmMain
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgenPath = new System.Windows.Forms.TextBox();
            this.btnBrowseGnPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGpxFilePath = new System.Windows.Forms.TextBox();
            this.btnGPXBrowse = new System.Windows.Forms.Button();
            this.openFileDialogGPX = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogGEn = new System.Windows.Forms.OpenFileDialog();
            this.chbxUseGenMotion = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPauseTime = new System.Windows.Forms.NumericUpDown();
            this.chkReplaceDotsWithCommas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(512, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emulator Port Number";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(150, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GenyMotion Path";
            // 
            // txtgenPath
            // 
            this.txtgenPath.Location = new System.Drawing.Point(150, 49);
            this.txtgenPath.Name = "txtgenPath";
            this.txtgenPath.Size = new System.Drawing.Size(305, 20);
            this.txtgenPath.TabIndex = 4;
            // 
            // btnBrowseGnPath
            // 
            this.btnBrowseGnPath.Location = new System.Drawing.Point(482, 45);
            this.btnBrowseGnPath.Name = "btnBrowseGnPath";
            this.btnBrowseGnPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGnPath.TabIndex = 5;
            this.btnBrowseGnPath.Text = "Browse";
            this.btnBrowseGnPath.UseVisualStyleBackColor = true;
            this.btnBrowseGnPath.Click += new System.EventHandler(this.btnBrowseGnPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "GPX File";
            // 
            // txtGpxFilePath
            // 
            this.txtGpxFilePath.Location = new System.Drawing.Point(150, 89);
            this.txtGpxFilePath.Name = "txtGpxFilePath";
            this.txtGpxFilePath.Size = new System.Drawing.Size(305, 20);
            this.txtGpxFilePath.TabIndex = 7;
            // 
            // btnGPXBrowse
            // 
            this.btnGPXBrowse.Location = new System.Drawing.Point(482, 85);
            this.btnGPXBrowse.Name = "btnGPXBrowse";
            this.btnGPXBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnGPXBrowse.TabIndex = 8;
            this.btnGPXBrowse.Text = "Browse";
            this.btnGPXBrowse.UseVisualStyleBackColor = true;
            this.btnGPXBrowse.Click += new System.EventHandler(this.btnGPXBrowse_Click);
            // 
            // openFileDialogGPX
            // 
            this.openFileDialogGPX.Filter = "GPX Files(*.gpx)|*.gpx";
            // 
            // chbxUseGenMotion
            // 
            this.chbxUseGenMotion.AutoSize = true;
            this.chbxUseGenMotion.Location = new System.Drawing.Point(5, 125);
            this.chbxUseGenMotion.Name = "chbxUseGenMotion";
            this.chbxUseGenMotion.Size = new System.Drawing.Size(104, 17);
            this.chbxUseGenMotion.TabIndex = 9;
            this.chbxUseGenMotion.Text = "Use Genymotion";
            this.chbxUseGenMotion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pause For";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seconds";
            // 
            // nudPauseTime
            // 
            this.nudPauseTime.Location = new System.Drawing.Point(112, 158);
            this.nudPauseTime.Name = "nudPauseTime";
            this.nudPauseTime.Size = new System.Drawing.Size(120, 20);
            this.nudPauseTime.TabIndex = 13;
            // 
            // chkReplaceDotsWithCommas
            // 
            this.chkReplaceDotsWithCommas.AutoSize = true;
            this.chkReplaceDotsWithCommas.Location = new System.Drawing.Point(150, 125);
            this.chkReplaceDotsWithCommas.Name = "chkReplaceDotsWithCommas";
            this.chkReplaceDotsWithCommas.Size = new System.Drawing.Size(159, 17);
            this.chkReplaceDotsWithCommas.TabIndex = 14;
            this.chkReplaceDotsWithCommas.Text = "Replace Dots With Commas";
            this.chkReplaceDotsWithCommas.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 261);
            this.Controls.Add(this.chkReplaceDotsWithCommas);
            this.Controls.Add(this.nudPauseTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbxUseGenMotion);
            this.Controls.Add(this.btnGPXBrowse);
            this.Controls.Add(this.txtGpxFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseGnPath);
            this.Controls.Add(this.txtgenPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgenPath;
        private System.Windows.Forms.Button btnBrowseGnPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGpxFilePath;
        private System.Windows.Forms.Button btnGPXBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialogGPX;
        private System.Windows.Forms.OpenFileDialog openFileDialogGEn;
        private System.Windows.Forms.CheckBox chbxUseGenMotion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPauseTime;
        private System.Windows.Forms.CheckBox chkReplaceDotsWithCommas;
    }
}

