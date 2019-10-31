namespace mook_DynamicCrawler
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
            this.btnCrawling = new System.Windows.Forms.Button();
            this.lvUrlList = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup = new System.Windows.Forms.Panel();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.cbLoadTime = new System.Windows.Forms.ComboBox();
            this.lblLoad = new System.Windows.Forms.Label();
            this.plGroup.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrawling
            // 
            this.btnCrawling.Location = new System.Drawing.Point(620, 316);
            this.btnCrawling.Name = "btnCrawling";
            this.btnCrawling.Size = new System.Drawing.Size(75, 23);
            this.btnCrawling.TabIndex = 3;
            this.btnCrawling.Text = "크롤링";
            this.btnCrawling.UseVisualStyleBackColor = true;
            this.btnCrawling.Click += new System.EventHandler(this.btnCrawling_Click);
            // 
            // lvUrlList
            // 
            this.lvUrlList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chUrl,
            this.chDatetime,
            this.chLoad,
            this.chHash});
            this.lvUrlList.FullRowSelect = true;
            this.lvUrlList.GridLines = true;
            this.lvUrlList.Location = new System.Drawing.Point(12, 12);
            this.lvUrlList.Name = "lvUrlList";
            this.lvUrlList.Size = new System.Drawing.Size(683, 289);
            this.lvUrlList.TabIndex = 2;
            this.lvUrlList.UseCompatibleStateImageBehavior = false;
            this.lvUrlList.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "No";
            // 
            // chUrl
            // 
            this.chUrl.Text = "URL";
            this.chUrl.Width = 220;
            // 
            // chDatetime
            // 
            this.chDatetime.Text = "접속시간";
            this.chDatetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDatetime.Width = 120;
            // 
            // chLoad
            // 
            this.chLoad.Text = "로딩타임(초)";
            this.chLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLoad.Width = 90;
            // 
            // chHash
            // 
            this.chHash.Text = "Hash";
            this.chHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHash.Width = 155;
            // 
            // plGroup
            // 
            this.plGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGroup.Controls.Add(this.ssBar);
            this.plGroup.Controls.Add(this.wbBrowser);
            this.plGroup.Location = new System.Drawing.Point(12, 12);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(460, 327);
            this.plGroup.TabIndex = 4;
            this.plGroup.Visible = false;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUrl});
            this.ssBar.Location = new System.Drawing.Point(0, 303);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(458, 22);
            this.ssBar.TabIndex = 1;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslblUrl
            // 
            this.tsslblUrl.Name = "tsslblUrl";
            this.tsslblUrl.Size = new System.Drawing.Size(39, 17);
            this.tsslblUrl.Text = "URL : ";
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.wbBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(458, 301);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // cbLoadTime
            // 
            this.cbLoadTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoadTime.FormattingEnabled = true;
            this.cbLoadTime.Items.AddRange(new object[] {
            "2초",
            "3초",
            "5초",
            "7초"});
            this.cbLoadTime.Location = new System.Drawing.Point(549, 316);
            this.cbLoadTime.Name = "cbLoadTime";
            this.cbLoadTime.Size = new System.Drawing.Size(66, 20);
            this.cbLoadTime.TabIndex = 5;
            this.cbLoadTime.SelectedIndexChanged += new System.EventHandler(this.cbLoadTime_SelectedIndexChanged);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(479, 320);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(65, 12);
            this.lblLoad.TabIndex = 6;
            this.lblLoad.Text = "최소로딩 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 367);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.cbLoadTime);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.btnCrawling);
            this.Controls.Add(this.lvUrlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "동적 크롤러";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrawling;
        private System.Windows.Forms.ListView lvUrlList;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chUrl;
        private System.Windows.Forms.ColumnHeader chDatetime;
        private System.Windows.Forms.ColumnHeader chLoad;
        private System.Windows.Forms.ColumnHeader chHash;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUrl;
        private System.Windows.Forms.ComboBox cbLoadTime;
        private System.Windows.Forms.Label lblLoad;
    }
}

