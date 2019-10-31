namespace mook_StaticCrawler
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
            this.lvUrlList = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrawling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUrlList
            // 
            this.lvUrlList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chUrl,
            this.chDatetime,
            this.chLoad,
            this.chResult});
            this.lvUrlList.FullRowSelect = true;
            this.lvUrlList.GridLines = true;
            this.lvUrlList.Location = new System.Drawing.Point(12, 12);
            this.lvUrlList.Name = "lvUrlList";
            this.lvUrlList.Size = new System.Drawing.Size(610, 289);
            this.lvUrlList.TabIndex = 0;
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
            // chResult
            // 
            this.chResult.Text = "결과";
            this.chResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chResult.Width = 80;
            // 
            // btnCrawling
            // 
            this.btnCrawling.Location = new System.Drawing.Point(548, 317);
            this.btnCrawling.Name = "btnCrawling";
            this.btnCrawling.Size = new System.Drawing.Size(75, 23);
            this.btnCrawling.TabIndex = 1;
            this.btnCrawling.Text = "크롤링";
            this.btnCrawling.UseVisualStyleBackColor = true;
            this.btnCrawling.Click += new System.EventHandler(this.btnCrawling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.btnCrawling);
            this.Controls.Add(this.lvUrlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "정적 크롤러";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvUrlList;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chUrl;
        private System.Windows.Forms.ColumnHeader chDatetime;
        private System.Windows.Forms.ColumnHeader chLoad;
        private System.Windows.Forms.ColumnHeader chResult;
        private System.Windows.Forms.Button btnCrawling;
    }
}

