namespace mook_FileView
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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.lvFile = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtnHidden = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "경로 : ";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(69, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(551, 21);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(637, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chFileName,
            this.chFileTime,
            this.chFileSize});
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(14, 80);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(869, 319);
            this.lvFile.TabIndex = 3;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "경로";
            this.chFilePath.Width = 400;
            // 
            // chFileName
            // 
            this.chFileName.Text = "이름";
            this.chFileName.Width = 120;
            // 
            // chFileTime
            // 
            this.chFileTime.Text = "수정한 날짜";
            this.chFileTime.Width = 150;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "크기";
            this.chFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chFileSize.Width = 150;
            // 
            // rbtnHidden
            // 
            this.rbtnHidden.AutoSize = true;
            this.rbtnHidden.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHidden.ForeColor = System.Drawing.Color.Black;
            this.rbtnHidden.Location = new System.Drawing.Point(98, 48);
            this.rbtnHidden.Name = "rbtnHidden";
            this.rbtnHidden.Size = new System.Drawing.Size(72, 17);
            this.rbtnHidden.TabIndex = 10;
            this.rbtnHidden.Text = "숨김 파일";
            this.rbtnHidden.UseVisualStyleBackColor = true;
            this.rbtnHidden.CheckedChanged += new System.EventHandler(this.rbtnHidden_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAll.ForeColor = System.Drawing.Color.Black;
            this.rbtnAll.Location = new System.Drawing.Point(16, 48);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(72, 17);
            this.rbtnAll.TabIndex = 9;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "전체 파일";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblResult});
            this.ssBar.Location = new System.Drawing.Point(0, 412);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(895, 22);
            this.ssBar.TabIndex = 11;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslblResult
            // 
            this.tsslblResult.Name = "tsslblResult";
            this.tsslblResult.Size = new System.Drawing.Size(130, 17);
            this.tsslblResult.Text = "폴더 : 0 개, 파일 : 0 개";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 434);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.rbtnHidden);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.RadioButton rbtnHidden;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ColumnHeader chFileTime;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblResult;
    }
}