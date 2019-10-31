namespace mook_NetFileSender
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
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tspgrBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(347, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbFileList
            // 
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.ItemHeight = 12;
            this.lbFileList.Location = new System.Drawing.Point(12, 43);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.Size = new System.Drawing.Size(410, 208);
            this.lbFileList.TabIndex = 2;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspgrBar,
            this.tsslblMsg});
            this.ssBar.Location = new System.Drawing.Point(0, 265);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(434, 22);
            this.ssBar.TabIndex = 3;
            this.ssBar.Text = "statusStrip1";
            // 
            // tspgrBar
            // 
            this.tspgrBar.Name = "tspgrBar";
            this.tspgrBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsslblMsg
            // 
            this.tsslblMsg.Name = "tsslblMsg";
            this.tsslblMsg.Size = new System.Drawing.Size(42, 17);
            this.tsslblMsg.Text = "결과 : ";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(186, 12);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(155, 21);
            this.txtIp.TabIndex = 4;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(164, 15);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(16, 12);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lbFileList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 보내기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripProgressBar tspgrBar;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.ToolStripStatusLabel tsslblMsg;
    }
}

