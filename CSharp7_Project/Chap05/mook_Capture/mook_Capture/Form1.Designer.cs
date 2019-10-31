namespace mook_Capture
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
            this.stsMenu = new System.Windows.Forms.StatusStrip();
            this.tsslText = new System.Windows.Forms.ToolStripStatusLabel();
            this.picbScreen = new System.Windows.Forms.PictureBox();
            this.stsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // stsMenu
            // 
            this.stsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslText});
            this.stsMenu.Location = new System.Drawing.Point(0, 339);
            this.stsMenu.Name = "stsMenu";
            this.stsMenu.Size = new System.Drawing.Size(784, 22);
            this.stsMenu.TabIndex = 3;
            this.stsMenu.Text = "StatusStrip1";
            // 
            // tsslText
            // 
            this.tsslText.Name = "tsslText";
            this.tsslText.Size = new System.Drawing.Size(255, 17);
            this.tsslText.Text = "전체 화면캡처 : c, 화면지우기 : e, 캡처저장 : s";
            // 
            // picbScreen
            // 
            this.picbScreen.BackColor = System.Drawing.Color.Silver;
            this.picbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbScreen.Location = new System.Drawing.Point(0, 0);
            this.picbScreen.Name = "picbScreen";
            this.picbScreen.Size = new System.Drawing.Size(784, 361);
            this.picbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbScreen.TabIndex = 2;
            this.picbScreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.stsMenu);
            this.Controls.Add(this.picbScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "화면 캡처";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.stsMenu.ResumeLayout(false);
            this.stsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip stsMenu;
        internal System.Windows.Forms.ToolStripStatusLabel tsslText;
        internal System.Windows.Forms.PictureBox picbScreen;
    }
}
