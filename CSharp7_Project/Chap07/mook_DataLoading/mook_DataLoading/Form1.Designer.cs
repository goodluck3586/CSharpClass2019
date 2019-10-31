namespace mook_DataLoading
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
            this.lvList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chcc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chID,
            this.chURL,
            this.chIP,
            this.chcc,
            this.chDate});
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(12, 12);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(675, 198);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 70;
            // 
            // chURL
            // 
            this.chURL.Text = "URL";
            this.chURL.Width = 230;
            // 
            // chIP
            // 
            this.chIP.Text = "IP";
            this.chIP.Width = 120;
            // 
            // chcc
            // 
            this.chcc.Text = "CC";
            // 
            // chDate
            // 
            this.chDate.Text = "날짜";
            this.chDate.Width = 120;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(56, 226);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(540, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 229);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(28, 12);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(612, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chNo
            // 
            this.chNo.Text = "No";
            this.chNo.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 261);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "데이터 로딩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chURL;
        private System.Windows.Forms.ColumnHeader chIP;
        private System.Windows.Forms.ColumnHeader chcc;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader chNo;
    }
}

