namespace mook_AutoAdmin
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
            this.lblFileDate = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFileDate
            // 
            this.lblFileDate.AutoSize = true;
            this.lblFileDate.Location = new System.Drawing.Point(17, 152);
            this.lblFileDate.Name = "lblFileDate";
            this.lblFileDate.Size = new System.Drawing.Size(53, 12);
            this.lblFileDate.TabIndex = 28;
            this.lblFileDate.Text = "수정일 : ";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(17, 188);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(278, 23);
            this.btnUpload.TabIndex = 23;
            this.btnUpload.Text = "업 로 드";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(239, 16);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(58, 23);
            this.btnFile.TabIndex = 22;
            this.btnFile.Text = "첨 부";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(65, 18);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(168, 21);
            this.txtFile.TabIndex = 21;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(17, 21);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(41, 12);
            this.lblFile.TabIndex = 20;
            this.lblFile.Text = "파 일 :";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "mook_AutoUpMain.exe";
            this.ofdFile.Filter = "실행 파일(*.exe)|*.exe";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(17, 102);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(53, 12);
            this.lblFileSize.TabIndex = 26;
            this.lblFileSize.Text = "사이즈 : ";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(17, 60);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(53, 12);
            this.lblFileName.TabIndex = 24;
            this.lblFileName.Text = "파일명 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 226);
            this.Controls.Add(this.lblFileDate);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "자동 업데이트 관리자";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFileDate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileName;
    }
}
