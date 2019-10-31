namespace mook_FileCM
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgrbar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvSrc = new System.Windows.Forms.ListView();
            this.chFileSrc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSrc = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lvDest = new System.Windows.Forms.ListView();
            this.chFileDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.ssBar.SuspendLayout();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 8);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ReadOnly = true;
            this.txtSrc.Size = new System.Drawing.Size(404, 21);
            this.txtSrc.TabIndex = 0;
            this.txtSrc.TabStop = false;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(12, 35);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(404, 21);
            this.txtDest.TabIndex = 1;
            this.txtDest.TabStop = false;
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(422, 6);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.Text = "대상 경로";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(422, 33);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "결과 경로";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl,
            this.tspgrbar,
            this.tsslblStatus});
            this.ssBar.Location = new System.Drawing.Point(0, 385);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(937, 22);
            this.ssBar.TabIndex = 4;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslbl
            // 
            this.tsslbl.Name = "tsslbl";
            this.tsslbl.Size = new System.Drawing.Size(94, 17);
            this.tsslbl.Text = "전체 진행사항 : ";
            // 
            // tspgrbar
            // 
            this.tspgrbar.Name = "tspgrbar";
            this.tspgrbar.Size = new System.Drawing.Size(200, 16);
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(32, 17);
            this.tsslblStatus.Text = " 0 %";
            // 
            // lvSrc
            // 
            this.lvSrc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileSrc});
            this.lvSrc.GridLines = true;
            this.lvSrc.Location = new System.Drawing.Point(12, 97);
            this.lvSrc.Name = "lvSrc";
            this.lvSrc.Size = new System.Drawing.Size(443, 273);
            this.lvSrc.TabIndex = 5;
            this.lvSrc.UseCompatibleStateImageBehavior = false;
            this.lvSrc.View = System.Windows.Forms.View.Details;
            // 
            // chFileSrc
            // 
            this.chFileSrc.Text = "파일";
            this.chFileSrc.Width = 400;
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(12, 71);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(29, 12);
            this.lblSrc.TabIndex = 6;
            this.lblSrc.Text = "대상";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(482, 71);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(29, 12);
            this.lblDest.TabIndex = 8;
            this.lblDest.Text = "결과";
            // 
            // lvDest
            // 
            this.lvDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileDest});
            this.lvDest.GridLines = true;
            this.lvDest.Location = new System.Drawing.Point(482, 97);
            this.lvDest.Name = "lvDest";
            this.lvDest.Size = new System.Drawing.Size(443, 273);
            this.lvDest.TabIndex = 7;
            this.lvDest.UseCompatibleStateImageBehavior = false;
            this.lvDest.View = System.Windows.Forms.View.Details;
            // 
            // chFileDest
            // 
            this.chFileDest.Text = "파일";
            this.chFileDest.Width = 400;
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.rbMove);
            this.gbBox.Controls.Add(this.rbCopy);
            this.gbBox.Location = new System.Drawing.Point(517, 8);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(236, 48);
            this.gbBox.TabIndex = 9;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "선택";
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(131, 21);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(71, 16);
            this.rbMove.TabIndex = 1;
            this.rbMove.Text = "파일이동";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Checked = true;
            this.rbCopy.Location = new System.Drawing.Point(26, 21);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(71, 16);
            this.rbCopy.TabIndex = 0;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "파일복사";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(827, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 44);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "실행";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lvDest);
            this.Controls.Add(this.lblSrc);
            this.Controls.Add(this.lvSrc);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 복사/이동";
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl;
        private System.Windows.Forms.ToolStripProgressBar tspgrbar;
        private System.Windows.Forms.ListView lvSrc;
        private System.Windows.Forms.ColumnHeader chFileSrc;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.ListView lvDest;
        private System.Windows.Forms.ColumnHeader chFileDest;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
    }
}