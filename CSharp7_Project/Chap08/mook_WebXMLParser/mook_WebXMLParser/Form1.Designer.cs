namespace mook_WebXMLParser
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
            this.lvXml = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblNews = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvXml
            // 
            this.lvXml.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvXml.GridLines = true;
            this.lvXml.Location = new System.Drawing.Point(12, 13);
            this.lvXml.Name = "lvXml";
            this.lvXml.Size = new System.Drawing.Size(218, 249);
            this.lvXml.TabIndex = 6;
            this.lvXml.UseCompatibleStateImageBehavior = false;
            this.lvXml.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이  름";
            this.chName.Width = 181;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "검  색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblNews});
            this.ssBar.Location = new System.Drawing.Point(0, 275);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(329, 22);
            this.ssBar.TabIndex = 8;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslblNews
            // 
            this.tsslblNews.ForeColor = System.Drawing.Color.Blue;
            this.tsslblNews.Name = "tsslblNews";
            this.tsslblNews.Size = new System.Drawing.Size(71, 17);
            this.tsslblNews.Tag = "";
            this.tsslblNews.Text = "기상청 날씨";
            this.tsslblNews.Click += new System.EventHandler(this.tsslblNews_Click);
            this.tsslblNews.MouseEnter += new System.EventHandler(this.tsslblNews_MouseEnter);
            this.tsslblNews.MouseLeave += new System.EventHandler(this.tsslblNews_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 297);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lvXml);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XML 파서";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvXml;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblNews;
    }
}

