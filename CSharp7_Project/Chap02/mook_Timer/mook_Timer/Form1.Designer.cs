namespace mook_Timer
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 10);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 0;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(81, 65);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(65, 21);
            this.txtCountDown.TabIndex = 1;
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(133, 10);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "카운트다운";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 128);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "타이머";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer Timer;
    }
}
