namespace mook_FileExcelSave
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
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.gbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 48);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "파일";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Controls.Add(this.rbExcel);
            this.gbSave.Controls.Add(this.rbTxt);
            this.gbSave.Location = new System.Drawing.Point(93, 11);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(373, 49);
            this.gbSave.TabIndex = 2;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "파일 저장";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(140, 20);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(63, 16);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.Text = "EXCEL";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Checked = true;
            this.rbTxt.Location = new System.Drawing.Point(62, 20);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(47, 16);
            this.rbTxt.TabIndex = 0;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = "TXT";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDate,
            this.chType,
            this.chSize,
            this.chPath});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(12, 66);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(745, 212);
            this.lvFile.TabIndex = 3;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 150;
            // 
            // chDate
            // 
            this.chDate.Text = "수정한 날짜";
            this.chDate.Width = 100;
            // 
            // chType
            // 
            this.chType.Text = "유형";
            this.chType.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.Width = 100;
            // 
            // chPath
            // 
            this.chPath.Text = "경로";
            this.chPath.Width = 250;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "모든 파일(*.*)|*.*";
            this.ofdFile.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 290);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbSave);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 정보 저장하기";
            this.gbSave.ResumeLayout(false);
            this.gbSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.ColumnHeader chPath;
    }
}

