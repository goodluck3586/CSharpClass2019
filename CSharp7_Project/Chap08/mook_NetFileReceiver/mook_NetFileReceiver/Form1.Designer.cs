namespace mook_NetFileReceiver
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
            this.lbFileList = new System.Windows.Forms.ListBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFileList
            // 
            this.lbFileList.FormattingEnabled = true;
            this.lbFileList.ItemHeight = 12;
            this.lbFileList.Location = new System.Drawing.Point(12, 47);
            this.lbFileList.Name = "lbFileList";
            this.lbFileList.Size = new System.Drawing.Size(456, 220);
            this.lbFileList.TabIndex = 0;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(393, 12);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.Text = "받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblConn});
            this.ssBar.Location = new System.Drawing.Point(0, 284);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(480, 22);
            this.ssBar.TabIndex = 4;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslblConn
            // 
            this.tsslblConn.Name = "tsslblConn";
            this.tsslblConn.Size = new System.Drawing.Size(42, 17);
            this.tsslblConn.Text = "상태 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lbFileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 받기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFileList;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblConn;
    }
}

