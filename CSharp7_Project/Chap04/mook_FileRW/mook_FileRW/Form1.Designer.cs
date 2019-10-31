namespace mook_FileRW
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.txtRView = new System.Windows.Forms.TextBox();
            this.btnRLRead = new System.Windows.Forms.Button();
            this.btnRARead = new System.Windows.Forms.Button();
            this.btnRPath = new System.Windows.Forms.Button();
            this.txtRPath = new System.Windows.Forms.TextBox();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.txtWView = new System.Windows.Forms.TextBox();
            this.btnWLSave = new System.Windows.Forms.Button();
            this.btnWASave = new System.Windows.Forms.Button();
            this.btnWPath = new System.Windows.Forms.Button();
            this.txtWPath = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRead);
            this.tabControl1.Controls.Add(this.tpWrite);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtRView);
            this.tpRead.Controls.Add(this.btnRLRead);
            this.tpRead.Controls.Add(this.btnRARead);
            this.tpRead.Controls.Add(this.btnRPath);
            this.tpRead.Controls.Add(this.txtRPath);
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(525, 287);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // txtRView
            // 
            this.txtRView.Location = new System.Drawing.Point(16, 94);
            this.txtRView.Multiline = true;
            this.txtRView.Name = "txtRView";
            this.txtRView.ReadOnly = true;
            this.txtRView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRView.Size = new System.Drawing.Size(488, 169);
            this.txtRView.TabIndex = 4;
            // 
            // btnRLRead
            // 
            this.btnRLRead.Location = new System.Drawing.Point(97, 55);
            this.btnRLRead.Name = "btnRLRead";
            this.btnRLRead.Size = new System.Drawing.Size(75, 23);
            this.btnRLRead.TabIndex = 3;
            this.btnRLRead.Text = "라인읽기";
            this.btnRLRead.UseVisualStyleBackColor = true;
            this.btnRLRead.Click += new System.EventHandler(this.btnRLRead_Click);
            // 
            // btnRARead
            // 
            this.btnRARead.Location = new System.Drawing.Point(16, 55);
            this.btnRARead.Name = "btnRARead";
            this.btnRARead.Size = new System.Drawing.Size(75, 23);
            this.btnRARead.TabIndex = 2;
            this.btnRARead.Text = "전체읽기";
            this.btnRARead.UseVisualStyleBackColor = true;
            this.btnRARead.Click += new System.EventHandler(this.btnRARead_Click);
            // 
            // btnRPath
            // 
            this.btnRPath.Location = new System.Drawing.Point(429, 19);
            this.btnRPath.Name = "btnRPath";
            this.btnRPath.Size = new System.Drawing.Size(75, 23);
            this.btnRPath.TabIndex = 1;
            this.btnRPath.Text = "파일";
            this.btnRPath.UseVisualStyleBackColor = true;
            this.btnRPath.Click += new System.EventHandler(this.btnRPath_Click);
            // 
            // txtRPath
            // 
            this.txtRPath.Location = new System.Drawing.Point(16, 19);
            this.txtRPath.Name = "txtRPath";
            this.txtRPath.ReadOnly = true;
            this.txtRPath.Size = new System.Drawing.Size(407, 21);
            this.txtRPath.TabIndex = 0;
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.txtWView);
            this.tpWrite.Controls.Add(this.btnWLSave);
            this.tpWrite.Controls.Add(this.btnWASave);
            this.tpWrite.Controls.Add(this.btnWPath);
            this.tpWrite.Controls.Add(this.txtWPath);
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(525, 287);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // txtWView
            // 
            this.txtWView.Location = new System.Drawing.Point(18, 96);
            this.txtWView.Multiline = true;
            this.txtWView.Name = "txtWView";
            this.txtWView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWView.Size = new System.Drawing.Size(488, 169);
            this.txtWView.TabIndex = 9;
            // 
            // btnWLSave
            // 
            this.btnWLSave.Location = new System.Drawing.Point(99, 57);
            this.btnWLSave.Name = "btnWLSave";
            this.btnWLSave.Size = new System.Drawing.Size(75, 23);
            this.btnWLSave.TabIndex = 8;
            this.btnWLSave.Text = "라인저장";
            this.btnWLSave.UseVisualStyleBackColor = true;
            this.btnWLSave.Click += new System.EventHandler(this.btnWLSave_Click);
            // 
            // btnWASave
            // 
            this.btnWASave.Location = new System.Drawing.Point(18, 57);
            this.btnWASave.Name = "btnWASave";
            this.btnWASave.Size = new System.Drawing.Size(75, 23);
            this.btnWASave.TabIndex = 7;
            this.btnWASave.Text = "전체저장";
            this.btnWASave.UseVisualStyleBackColor = true;
            this.btnWASave.Click += new System.EventHandler(this.btnWASave_Click);
            // 
            // btnWPath
            // 
            this.btnWPath.Location = new System.Drawing.Point(431, 21);
            this.btnWPath.Name = "btnWPath";
            this.btnWPath.Size = new System.Drawing.Size(75, 23);
            this.btnWPath.TabIndex = 6;
            this.btnWPath.Text = "파일";
            this.btnWPath.UseVisualStyleBackColor = true;
            this.btnWPath.Click += new System.EventHandler(this.btnWPath_Click);
            // 
            // txtWPath
            // 
            this.txtWPath.Location = new System.Drawing.Point(18, 21);
            this.txtWPath.Name = "txtWPath";
            this.txtWPath.ReadOnly = true;
            this.txtWPath.Size = new System.Drawing.Size(407, 21);
            this.txtWPath.TabIndex = 5;
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 337);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 읽기/쓰기";
            this.tabControl1.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TextBox txtRView;
        private System.Windows.Forms.Button btnRLRead;
        private System.Windows.Forms.Button btnRARead;
        private System.Windows.Forms.Button btnRPath;
        private System.Windows.Forms.TextBox txtRPath;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.TextBox txtWView;
        private System.Windows.Forms.Button btnWLSave;
        private System.Windows.Forms.Button btnWASave;
        private System.Windows.Forms.Button btnWPath;
        private System.Windows.Forms.TextBox txtWPath;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}
