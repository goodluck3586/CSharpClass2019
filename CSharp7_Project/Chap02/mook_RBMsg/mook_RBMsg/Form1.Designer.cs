namespace mook_RBMsg
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
            this.gbOption1 = new System.Windows.Forms.GroupBox();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.gbOption2 = new System.Windows.Forms.GroupBox();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbOption1.SuspendLayout();
            this.gbOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption1
            // 
            this.gbOption1.Controls.Add(this.rbYesNo);
            this.gbOption1.Controls.Add(this.rbOkCancel);
            this.gbOption1.Controls.Add(this.rbOk);
            this.gbOption1.Location = new System.Drawing.Point(12, 12);
            this.gbOption1.Name = "gbOption1";
            this.gbOption1.Size = new System.Drawing.Size(200, 100);
            this.gbOption1.TabIndex = 0;
            this.gbOption1.TabStop = false;
            this.gbOption1.Text = "Type";
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(15, 64);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(61, 16);
            this.rbYesNo.TabIndex = 4;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Location = new System.Drawing.Point(15, 42);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(78, 16);
            this.rbOkCancel.TabIndex = 3;
            this.rbOkCancel.Text = "OkCancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Checked = true;
            this.rbOk.Location = new System.Drawing.Point(15, 20);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(38, 16);
            this.rbOk.TabIndex = 2;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "Ok";
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // gbOption2
            // 
            this.gbOption2.Controls.Add(this.rbQuestion);
            this.gbOption2.Controls.Add(this.rbInformation);
            this.gbOption2.Controls.Add(this.rbError);
            this.gbOption2.Location = new System.Drawing.Point(234, 12);
            this.gbOption2.Name = "gbOption2";
            this.gbOption2.Size = new System.Drawing.Size(200, 100);
            this.gbOption2.TabIndex = 1;
            this.gbOption2.TabStop = false;
            this.gbOption2.Text = "Icon";
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(17, 64);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(73, 16);
            this.rbQuestion.TabIndex = 6;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(17, 42);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(85, 16);
            this.rbInformation.TabIndex = 5;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Checked = true;
            this.rbError.Location = new System.Drawing.Point(17, 20);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(50, 16);
            this.rbError.TabIndex = 4;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(357, 118);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 156);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbOption2);
            this.Controls.Add(this.gbOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메시지 박스 보기";
            this.gbOption1.ResumeLayout(false);
            this.gbOption1.PerformLayout();
            this.gbOption2.ResumeLayout(false);
            this.gbOption2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption1;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.GroupBox gbOption2;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.Button btnShow;
    }
}
