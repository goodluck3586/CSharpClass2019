namespace mook_FileMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(48, 9);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(365, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(419, 7);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(12, 64);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(611, 280);
            this.lbLog.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(550, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "로그 저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(472, 9);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 48);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "모니터 ON";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 12);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 12);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "경로";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(10, 39);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(29, 12);
            this.lblExtension.TabIndex = 7;
            this.lblExtension.Text = "타입";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(48, 36);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(84, 21);
            this.txtExtension.TabIndex = 6;
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(151, 39);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(57, 12);
            this.lblMonitor.TabIndex = 8;
            this.lblMonitor.Text = "하위 감시";
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cbMonitor.Location = new System.Drawing.Point(215, 37);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(121, 20);
            this.cbMonitor.TabIndex = 9;
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "로그 파일(*.log)|*.log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 356);
            this.Controls.Add(this.cbMonitor);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 모니터";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}

