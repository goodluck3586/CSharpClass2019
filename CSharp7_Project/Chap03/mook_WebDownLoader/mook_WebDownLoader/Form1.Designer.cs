namespace mook_WebDownLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pgbDownload = new System.Windows.Forms.ProgressBar();
            this.btnDown = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.webClient = new System.Net.WebClient();
            this.btnFolder = new System.Windows.Forms.Button();
            this.fbdFile = new System.Windows.Forms.FolderBrowserDialog();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pgbDownload
            // 
            this.pgbDownload.Location = new System.Drawing.Point(19, 45);
            this.pgbDownload.Name = "pgbDownload";
            this.pgbDownload.Size = new System.Drawing.Size(519, 23);
            this.pgbDownload.TabIndex = 7;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(332, 13);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(62, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "다운로드";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(61, 15);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(263, 21);
            this.txtUrl.TabIndex = 5;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(17, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 12);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "주소";
            // 
            // webClient
            // 
            //this.webClient.AllowReadStreamBuffering = false;
            //this.webClient.AllowWriteStreamBuffering = false;
            this.webClient.BaseAddress = "";
            this.webClient.CachePolicy = null;
            this.webClient.Credentials = null;
            this.webClient.Encoding = ((System.Text.Encoding)(resources.GetObject("webClient.Encoding")));
            this.webClient.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("webClient.Headers")));
            this.webClient.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("webClient.QueryString")));
            this.webClient.UseDefaultCredentials = false;
            this.webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.webClient_DownloadFileCompleted);
            this.webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(this.webClient_DownloadProgressChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(401, 13);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(67, 23);
            this.btnFolder.TabIndex = 8;
            this.btnFolder.Text = "폴 더";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Location = new System.Drawing.Point(474, 18);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(64, 16);
            this.cbOpen.TabIndex = 9;
            this.cbOpen.Text = "창 열기";
            this.cbOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 79);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.pgbDownload);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "웹 다운로드";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbDownload;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Net.WebClient webClient;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdFile;
        private System.Windows.Forms.CheckBox cbOpen;
    }
}

