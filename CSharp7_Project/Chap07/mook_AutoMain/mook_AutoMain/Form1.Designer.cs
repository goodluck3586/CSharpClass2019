namespace mook_AutoMain
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
            this.components = new System.ComponentModel.Container();
            this.lbldisUpdate = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.lbldisVer = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbldisUpdate
            // 
            this.lbldisUpdate.AutoSize = true;
            this.lbldisUpdate.Location = new System.Drawing.Point(96, 59);
            this.lbldisUpdate.Name = "lbldisUpdate";
            this.lbldisUpdate.Size = new System.Drawing.Size(57, 12);
            this.lbldisUpdate.TabIndex = 11;
            this.lbldisUpdate.Text = "시간 출력";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(12, 59);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(81, 12);
            this.lblUpdate.TabIndex = 10;
            this.lblUpdate.Text = "최근 엑세스 : ";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(13, 25);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(41, 12);
            this.lblVer.TabIndex = 8;
            this.lblVer.Text = "버전 : ";
            // 
            // lbldisVer
            // 
            this.lbldisVer.AutoSize = true;
            this.lbldisVer.Location = new System.Drawing.Point(60, 25);
            this.lbldisVer.Name = "lbldisVer";
            this.lbldisVer.Size = new System.Drawing.Size(88, 12);
            this.lbldisVer.TabIndex = 9;
            this.lbldisVer.Text = "mook\'s 1.0 ver";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "1초",
            "10초",
            "1분"});
            this.cbTime.Location = new System.Drawing.Point(200, 79);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(82, 20);
            this.cbTime.TabIndex = 12;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 111);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.lbldisUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lbldisVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자동 업데이트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldisUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lbldisVer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox cbTime;
    }
}