namespace mook_Zip
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
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.tpZip = new System.Windows.Forms.TabPage();
            this.ProgressBarZip = new System.Windows.Forms.ProgressBar();
            this.btnZip = new System.Windows.Forms.Button();
            this.txtZipPwd = new System.Windows.Forms.TextBox();
            this.lblZipPwd = new System.Windows.Forms.Label();
            this.txtZipName = new System.Windows.Forms.TextBox();
            this.lblZipName = new System.Windows.Forms.Label();
            this.lvZipFile = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZipPath = new System.Windows.Forms.Button();
            this.txtZipPath = new System.Windows.Forms.TextBox();
            this.lblZipPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.tpUnZip = new System.Windows.Forms.TabPage();
            this.ProgressBarUnZip = new System.Windows.Forms.ProgressBar();
            this.btnUnZip = new System.Windows.Forms.Button();
            this.txtUnZipPwd = new System.Windows.Forms.TextBox();
            this.lblUnZipPwd = new System.Windows.Forms.Label();
            this.lvUnZipFile = new System.Windows.Forms.ListView();
            this.chUnZipFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnZipFolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnZipSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUnZipPath = new System.Windows.Forms.Button();
            this.txtUnZipPath = new System.Windows.Forms.TextBox();
            this.lblUnZipPath = new System.Windows.Forms.Label();
            this.btnUnPath = new System.Windows.Forms.Button();
            this.txtUnPath = new System.Windows.Forms.TextBox();
            this.lblUnPath = new System.Windows.Forms.Label();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.TabMenu.SuspendLayout();
            this.tpZip.SuspendLayout();
            this.tpUnZip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.tpZip);
            this.TabMenu.Controls.Add(this.tpUnZip);
            this.TabMenu.Location = new System.Drawing.Point(12, 11);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(410, 288);
            this.TabMenu.TabIndex = 1;
            // 
            // tpZip
            // 
            this.tpZip.Controls.Add(this.ProgressBarZip);
            this.tpZip.Controls.Add(this.btnZip);
            this.tpZip.Controls.Add(this.txtZipPwd);
            this.tpZip.Controls.Add(this.lblZipPwd);
            this.tpZip.Controls.Add(this.txtZipName);
            this.tpZip.Controls.Add(this.lblZipName);
            this.tpZip.Controls.Add(this.lvZipFile);
            this.tpZip.Controls.Add(this.btnZipPath);
            this.tpZip.Controls.Add(this.txtZipPath);
            this.tpZip.Controls.Add(this.lblZipPath);
            this.tpZip.Controls.Add(this.btnPath);
            this.tpZip.Controls.Add(this.txtPath);
            this.tpZip.Controls.Add(this.lblPath);
            this.tpZip.Location = new System.Drawing.Point(4, 22);
            this.tpZip.Name = "tpZip";
            this.tpZip.Padding = new System.Windows.Forms.Padding(3);
            this.tpZip.Size = new System.Drawing.Size(402, 262);
            this.tpZip.TabIndex = 0;
            this.tpZip.Text = "압축하기";
            this.tpZip.UseVisualStyleBackColor = true;
            // 
            // ProgressBarZip
            // 
            this.ProgressBarZip.Location = new System.Drawing.Point(23, 147);
            this.ProgressBarZip.Name = "ProgressBarZip";
            this.ProgressBarZip.Size = new System.Drawing.Size(334, 23);
            this.ProgressBarZip.TabIndex = 13;
            this.ProgressBarZip.Visible = false;
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(315, 232);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 12;
            this.btnZip.Text = "압축하기";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // txtZipPwd
            // 
            this.txtZipPwd.Location = new System.Drawing.Point(223, 232);
            this.txtZipPwd.Name = "txtZipPwd";
            this.txtZipPwd.PasswordChar = '*';
            this.txtZipPwd.Size = new System.Drawing.Size(86, 21);
            this.txtZipPwd.TabIndex = 11;
            // 
            // lblZipPwd
            // 
            this.lblZipPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZipPwd.Location = new System.Drawing.Point(155, 233);
            this.lblZipPwd.Name = "lblZipPwd";
            this.lblZipPwd.Size = new System.Drawing.Size(60, 20);
            this.lblZipPwd.TabIndex = 9;
            this.lblZipPwd.Text = "비밀번호";
            this.lblZipPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtZipName
            // 
            this.txtZipName.Location = new System.Drawing.Point(63, 232);
            this.txtZipName.Name = "txtZipName";
            this.txtZipName.Size = new System.Drawing.Size(86, 21);
            this.txtZipName.TabIndex = 8;
            // 
            // lblZipName
            // 
            this.lblZipName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZipName.Location = new System.Drawing.Point(10, 233);
            this.lblZipName.Name = "lblZipName";
            this.lblZipName.Size = new System.Drawing.Size(47, 20);
            this.lblZipName.TabIndex = 7;
            this.lblZipName.Text = "압축명";
            this.lblZipName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvZipFile
            // 
            this.lvZipFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chFolderName,
            this.chSize});
            this.lvZipFile.GridLines = true;
            this.lvZipFile.Location = new System.Drawing.Point(10, 69);
            this.lvZipFile.Name = "lvZipFile";
            this.lvZipFile.Size = new System.Drawing.Size(380, 157);
            this.lvZipFile.TabIndex = 6;
            this.lvZipFile.UseCompatibleStateImageBehavior = false;
            this.lvZipFile.View = System.Windows.Forms.View.Details;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일명";
            this.chFileName.Width = 160;
            // 
            // chFolderName
            // 
            this.chFolderName.Text = "폴더명";
            this.chFolderName.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSize.Width = 80;
            // 
            // btnZipPath
            // 
            this.btnZipPath.Location = new System.Drawing.Point(315, 40);
            this.btnZipPath.Name = "btnZipPath";
            this.btnZipPath.Size = new System.Drawing.Size(75, 23);
            this.btnZipPath.TabIndex = 5;
            this.btnZipPath.Text = "폴더선택B";
            this.btnZipPath.UseVisualStyleBackColor = true;
            this.btnZipPath.Click += new System.EventHandler(this.btnZipPath_Click);
            // 
            // txtZipPath
            // 
            this.txtZipPath.Location = new System.Drawing.Point(76, 42);
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.ReadOnly = true;
            this.txtZipPath.Size = new System.Drawing.Size(233, 21);
            this.txtZipPath.TabIndex = 4;
            // 
            // lblZipPath
            // 
            this.lblZipPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZipPath.Location = new System.Drawing.Point(10, 42);
            this.lblZipPath.Name = "lblZipPath";
            this.lblZipPath.Size = new System.Drawing.Size(60, 20);
            this.lblZipPath.TabIndex = 3;
            this.lblZipPath.Text = "압축경로";
            this.lblZipPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(315, 11);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "폴더선택A";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(76, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(233, 21);
            this.txtPath.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Location = new System.Drawing.Point(10, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(60, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "대상경로";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpUnZip
            // 
            this.tpUnZip.Controls.Add(this.ProgressBarUnZip);
            this.tpUnZip.Controls.Add(this.btnUnZip);
            this.tpUnZip.Controls.Add(this.txtUnZipPwd);
            this.tpUnZip.Controls.Add(this.lblUnZipPwd);
            this.tpUnZip.Controls.Add(this.lvUnZipFile);
            this.tpUnZip.Controls.Add(this.btnUnZipPath);
            this.tpUnZip.Controls.Add(this.txtUnZipPath);
            this.tpUnZip.Controls.Add(this.lblUnZipPath);
            this.tpUnZip.Controls.Add(this.btnUnPath);
            this.tpUnZip.Controls.Add(this.txtUnPath);
            this.tpUnZip.Controls.Add(this.lblUnPath);
            this.tpUnZip.Location = new System.Drawing.Point(4, 22);
            this.tpUnZip.Name = "tpUnZip";
            this.tpUnZip.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnZip.Size = new System.Drawing.Size(402, 262);
            this.tpUnZip.TabIndex = 1;
            this.tpUnZip.Text = "압축풀기";
            this.tpUnZip.UseVisualStyleBackColor = true;
            // 
            // ProgressBarUnZip
            // 
            this.ProgressBarUnZip.Location = new System.Drawing.Point(24, 145);
            this.ProgressBarUnZip.Name = "ProgressBarUnZip";
            this.ProgressBarUnZip.Size = new System.Drawing.Size(336, 23);
            this.ProgressBarUnZip.TabIndex = 26;
            this.ProgressBarUnZip.Visible = false;
            // 
            // btnUnZip
            // 
            this.btnUnZip.Location = new System.Drawing.Point(316, 230);
            this.btnUnZip.Name = "btnUnZip";
            this.btnUnZip.Size = new System.Drawing.Size(75, 23);
            this.btnUnZip.TabIndex = 25;
            this.btnUnZip.Text = "압축풀기";
            this.btnUnZip.UseVisualStyleBackColor = true;
            this.btnUnZip.Click += new System.EventHandler(this.btnUnZip_Click);
            // 
            // txtUnZipPwd
            // 
            this.txtUnZipPwd.Location = new System.Drawing.Point(77, 232);
            this.txtUnZipPwd.Name = "txtUnZipPwd";
            this.txtUnZipPwd.PasswordChar = '*';
            this.txtUnZipPwd.Size = new System.Drawing.Size(86, 21);
            this.txtUnZipPwd.TabIndex = 24;
            // 
            // lblUnZipPwd
            // 
            this.lblUnZipPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnZipPwd.Location = new System.Drawing.Point(9, 233);
            this.lblUnZipPwd.Name = "lblUnZipPwd";
            this.lblUnZipPwd.Size = new System.Drawing.Size(60, 20);
            this.lblUnZipPwd.TabIndex = 23;
            this.lblUnZipPwd.Text = "비밀번호";
            this.lblUnZipPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvUnZipFile
            // 
            this.lvUnZipFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUnZipFileName,
            this.chUnZipFolderName,
            this.chUnZipSize});
            this.lvUnZipFile.GridLines = true;
            this.lvUnZipFile.Location = new System.Drawing.Point(11, 67);
            this.lvUnZipFile.Name = "lvUnZipFile";
            this.lvUnZipFile.Size = new System.Drawing.Size(380, 157);
            this.lvUnZipFile.TabIndex = 20;
            this.lvUnZipFile.UseCompatibleStateImageBehavior = false;
            this.lvUnZipFile.View = System.Windows.Forms.View.Details;
            // 
            // chUnZipFileName
            // 
            this.chUnZipFileName.Text = "파일명";
            this.chUnZipFileName.Width = 160;
            // 
            // chUnZipFolderName
            // 
            this.chUnZipFolderName.Text = "폴더명";
            this.chUnZipFolderName.Width = 100;
            // 
            // chUnZipSize
            // 
            this.chUnZipSize.Text = "크기";
            this.chUnZipSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chUnZipSize.Width = 80;
            // 
            // btnUnZipPath
            // 
            this.btnUnZipPath.Location = new System.Drawing.Point(316, 38);
            this.btnUnZipPath.Name = "btnUnZipPath";
            this.btnUnZipPath.Size = new System.Drawing.Size(75, 23);
            this.btnUnZipPath.TabIndex = 19;
            this.btnUnZipPath.Text = "폴더선택";
            this.btnUnZipPath.UseVisualStyleBackColor = true;
            this.btnUnZipPath.Click += new System.EventHandler(this.btnUnZipPath_Click);
            // 
            // txtUnZipPath
            // 
            this.txtUnZipPath.Location = new System.Drawing.Point(77, 40);
            this.txtUnZipPath.Name = "txtUnZipPath";
            this.txtUnZipPath.ReadOnly = true;
            this.txtUnZipPath.Size = new System.Drawing.Size(233, 21);
            this.txtUnZipPath.TabIndex = 18;
            // 
            // lblUnZipPath
            // 
            this.lblUnZipPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnZipPath.Location = new System.Drawing.Point(11, 40);
            this.lblUnZipPath.Name = "lblUnZipPath";
            this.lblUnZipPath.Size = new System.Drawing.Size(60, 20);
            this.lblUnZipPath.TabIndex = 17;
            this.lblUnZipPath.Text = "풀기경로";
            this.lblUnZipPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUnPath
            // 
            this.btnUnPath.Location = new System.Drawing.Point(316, 9);
            this.btnUnPath.Name = "btnUnPath";
            this.btnUnPath.Size = new System.Drawing.Size(75, 23);
            this.btnUnPath.TabIndex = 16;
            this.btnUnPath.Text = "파일선택";
            this.btnUnPath.UseVisualStyleBackColor = true;
            this.btnUnPath.Click += new System.EventHandler(this.btnUnPath_Click);
            // 
            // txtUnPath
            // 
            this.txtUnPath.Location = new System.Drawing.Point(77, 11);
            this.txtUnPath.Name = "txtUnPath";
            this.txtUnPath.ReadOnly = true;
            this.txtUnPath.Size = new System.Drawing.Size(233, 21);
            this.txtUnPath.TabIndex = 15;
            // 
            // lblUnPath
            // 
            this.lblUnPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnPath.Location = new System.Drawing.Point(11, 11);
            this.lblUnPath.Name = "lblUnPath";
            this.lblUnPath.Size = new System.Drawing.Size(60, 20);
            this.lblUnPath.TabIndex = 14;
            this.lblUnPath.Text = "대상경로";
            this.lblUnPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "ZIP(*.zip)|*.zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.TabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "응용 압축 프로그램";
            this.TabMenu.ResumeLayout(false);
            this.tpZip.ResumeLayout(false);
            this.tpZip.PerformLayout();
            this.tpUnZip.ResumeLayout(false);
            this.tpUnZip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabMenu;
        internal System.Windows.Forms.TabPage tpZip;
        internal System.Windows.Forms.ProgressBar ProgressBarZip;
        internal System.Windows.Forms.Button btnZip;
        internal System.Windows.Forms.TextBox txtZipPwd;
        internal System.Windows.Forms.Label lblZipPwd;
        internal System.Windows.Forms.TextBox txtZipName;
        internal System.Windows.Forms.Label lblZipName;
        internal System.Windows.Forms.ListView lvZipFile;
        internal System.Windows.Forms.ColumnHeader chFileName;
        internal System.Windows.Forms.ColumnHeader chFolderName;
        internal System.Windows.Forms.ColumnHeader chSize;
        internal System.Windows.Forms.Button btnZipPath;
        internal System.Windows.Forms.TextBox txtZipPath;
        internal System.Windows.Forms.Label lblZipPath;
        internal System.Windows.Forms.Button btnPath;
        internal System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.Label lblPath;
        internal System.Windows.Forms.TabPage tpUnZip;
        internal System.Windows.Forms.ProgressBar ProgressBarUnZip;
        internal System.Windows.Forms.Button btnUnZip;
        internal System.Windows.Forms.TextBox txtUnZipPwd;
        internal System.Windows.Forms.Label lblUnZipPwd;
        internal System.Windows.Forms.ListView lvUnZipFile;
        internal System.Windows.Forms.ColumnHeader chUnZipFileName;
        internal System.Windows.Forms.ColumnHeader chUnZipFolderName;
        internal System.Windows.Forms.ColumnHeader chUnZipSize;
        internal System.Windows.Forms.Button btnUnZipPath;
        internal System.Windows.Forms.TextBox txtUnZipPath;
        internal System.Windows.Forms.Label lblUnZipPath;
        internal System.Windows.Forms.Button btnUnPath;
        internal System.Windows.Forms.TextBox txtUnPath;
        internal System.Windows.Forms.Label lblUnPath;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

