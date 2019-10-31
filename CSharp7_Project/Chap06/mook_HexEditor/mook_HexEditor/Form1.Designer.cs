namespace mook_HexEditor
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
            this.btnFile = new System.Windows.Forms.Button();
            this.pgbView = new System.Windows.Forms.ProgressBar();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.HexView = new System.Windows.Forms.RichTextBox();
            this.stbView = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(0, 1);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(82, 25);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // pgbView
            // 
            this.pgbView.Location = new System.Drawing.Point(81, 2);
            this.pgbView.Name = "pgbView";
            this.pgbView.Size = new System.Drawing.Size(742, 23);
            this.pgbView.TabIndex = 1;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            // 
            // HexView
            // 
            this.HexView.Font = new System.Drawing.Font("Courier New", 9F);
            this.HexView.ForeColor = System.Drawing.Color.Black;
            this.HexView.Location = new System.Drawing.Point(0, 31);
            this.HexView.Name = "HexView";
            this.HexView.Size = new System.Drawing.Size(823, 402);
            this.HexView.TabIndex = 2;
            this.HexView.Text = "";
            // 
            // stbView
            // 
            this.stbView.Location = new System.Drawing.Point(0, 439);
            this.stbView.Name = "stbView";
            this.stbView.Size = new System.Drawing.Size(824, 22);
            this.stbView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.stbView);
            this.Controls.Add(this.HexView);
            this.Controls.Add(this.pgbView);
            this.Controls.Add(this.btnFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 헥사 뷰어";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ProgressBar pgbView;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.RichTextBox HexView;
        private System.Windows.Forms.StatusBar stbView;
    }
}

