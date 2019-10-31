namespace mook_DefaultCompression
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
            this.btnPath = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnDeComp = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.lvList = new System.Windows.Forms.ListView();
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 185);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "대상";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(466, 185);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(75, 23);
            this.btnComp.TabIndex = 1;
            this.btnComp.Text = "압축";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // btnDeComp
            // 
            this.btnDeComp.Location = new System.Drawing.Point(547, 185);
            this.btnDeComp.Name = "btnDeComp";
            this.btnDeComp.Size = new System.Drawing.Size(75, 23);
            this.btnDeComp.TabIndex = 2;
            this.btnDeComp.Text = "해제";
            this.btnDeComp.UseVisualStyleBackColor = true;
            this.btnDeComp.Click += new System.EventHandler(this.btnDeComp_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "모든 파일(*.*)|*.*";
            this.ofdFile.Multiselect = true;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPath,
            this.chSize});
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(12, 12);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(610, 167);
            this.lvList.TabIndex = 3;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // chPath
            // 
            this.chPath.Text = "경로";
            this.chPath.Width = 490;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.Width = 80;
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "ZIP 파일(*.zip)|*.zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 220);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.btnDeComp);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "기본 압축";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnDeComp;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
    }
}

