namespace mook_FileWipe
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
            this.btnWipe = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.cbWipe = new System.Windows.Forms.ComboBox();
            this.lblWipe = new System.Windows.Forms.Label();
            this.pgbBar = new System.Windows.Forms.ProgressBar();
            this.lblPgb = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(369, 10);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(53, 49);
            this.btnWipe.TabIndex = 13;
            this.btnWipe.Text = "삭제";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(337, 10);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(26, 23);
            this.btnPath.TabIndex = 11;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(52, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(279, 21);
            this.txtPath.TabIndex = 10;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 12);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "파일 : ";
            // 
            // cbWipe
            // 
            this.cbWipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWipe.FormattingEnabled = true;
            this.cbWipe.Items.AddRange(new object[] {
            "British HMG IS5 (Base Line)",
            "British HMG IS5 (Enhanced)"});
            this.cbWipe.Location = new System.Drawing.Point(52, 39);
            this.cbWipe.Name = "cbWipe";
            this.cbWipe.Size = new System.Drawing.Size(311, 20);
            this.cbWipe.TabIndex = 8;
            // 
            // lblWipe
            // 
            this.lblWipe.AutoSize = true;
            this.lblWipe.Location = new System.Drawing.Point(9, 42);
            this.lblWipe.Name = "lblWipe";
            this.lblWipe.Size = new System.Drawing.Size(41, 12);
            this.lblWipe.TabIndex = 7;
            this.lblWipe.Text = "선택 : ";
            // 
            // pgbBar
            // 
            this.pgbBar.Location = new System.Drawing.Point(52, 76);
            this.pgbBar.Name = "pgbBar";
            this.pgbBar.Size = new System.Drawing.Size(371, 15);
            this.pgbBar.TabIndex = 14;
            // 
            // lblPgb
            // 
            this.lblPgb.AutoSize = true;
            this.lblPgb.BackColor = System.Drawing.Color.Transparent;
            this.lblPgb.Location = new System.Drawing.Point(13, 78);
            this.lblPgb.Name = "lblPgb";
            this.lblPgb.Size = new System.Drawing.Size(21, 12);
            this.lblPgb.TabIndex = 15;
            this.lblPgb.Text = "0%";
            this.lblPgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "모든 파일 (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 106);
            this.Controls.Add(this.lblPgb);
            this.Controls.Add(this.pgbBar);
            this.Controls.Add(this.btnWipe);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cbWipe);
            this.Controls.Add(this.lblWipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 지우기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cbWipe;
        private System.Windows.Forms.Label lblWipe;
        private System.Windows.Forms.ProgressBar pgbBar;
        private System.Windows.Forms.Label lblPgb;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

