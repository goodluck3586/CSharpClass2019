namespace mook_HumanList
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
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup = new System.Windows.Forms.Panel();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName,
            this.chAge,
            this.chPhone,
            this.chJob});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(12, 12);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(501, 178);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.Click += new System.EventHandler(this.lvList_Click);
            // 
            // chId
            // 
            this.chId.Text = "구분";
            this.chId.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 80;
            // 
            // chAge
            // 
            this.chAge.Text = "나이";
            // 
            // chPhone
            // 
            this.chPhone.Text = "전화번호";
            this.chPhone.Width = 150;
            // 
            // chJob
            // 
            this.chJob.Text = "직업";
            this.chJob.Width = 120;
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.White;
            this.plGroup.Controls.Add(this.btnDel);
            this.plGroup.Controls.Add(this.btnModify);
            this.plGroup.Controls.Add(this.btnSave);
            this.plGroup.Controls.Add(this.txtJob);
            this.plGroup.Controls.Add(this.lblJob);
            this.plGroup.Controls.Add(this.txtPhone);
            this.plGroup.Controls.Add(this.lblPhone);
            this.plGroup.Controls.Add(this.txtAge);
            this.plGroup.Controls.Add(this.lblAge);
            this.plGroup.Controls.Add(this.txtName);
            this.plGroup.Controls.Add(this.lblName);
            this.plGroup.Location = new System.Drawing.Point(12, 196);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(501, 100);
            this.plGroup.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(220, 57);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 21);
            this.txtJob.TabIndex = 16;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(173, 60);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(29, 12);
            this.lblJob.TabIndex = 15;
            this.lblJob.Text = "직업";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(220, 20);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(163, 23);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "전화번호";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(52, 57);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 12;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "나이";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "이름";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 60);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(412, 18);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(412, 55);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 308);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.lvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "인명부";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chJob;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

