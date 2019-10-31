namespace mook_CarInfo
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
            this.components = new System.ComponentModel.Container();
            this.lvList = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModify = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDoor = new System.Windows.Forms.Label();
            this.txtDoor = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chName,
            this.chYear,
            this.chPrice,
            this.chDoor});
            this.lvList.ContextMenuStrip = this.cmsMenu;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(12, 12);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(360, 130);
            this.lvList.TabIndex = 19;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.Click += new System.EventHandler(this.lvList_Click);
            // 
            // chNum
            // 
            this.chNum.Text = "번 호";
            this.chNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNum.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "이 름";
            this.chName.Width = 70;
            // 
            // chYear
            // 
            this.chYear.Text = "년 식";
            this.chYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chPrice
            // 
            this.chPrice.Text = "가 격";
            this.chPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrice.Width = 90;
            // 
            // chDoor
            // 
            this.chDoor.Text = "도 어";
            this.chDoor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(297, 177);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 32;
            this.btnModify.Text = "수 정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(14, 180);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 12);
            this.lblYear.TabIndex = 31;
            this.lblYear.Text = "년 식";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(66, 177);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 21);
            this.txtYear.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 12);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "이 름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(14, 234);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(33, 12);
            this.lblDoor.TabIndex = 36;
            this.lblDoor.Text = "도 어";
            // 
            // txtDoor
            // 
            this.txtDoor.Location = new System.Drawing.Point(66, 231);
            this.txtDoor.Name = "txtDoor";
            this.txtDoor.Size = new System.Drawing.Size(100, 21);
            this.txtDoor.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(14, 207);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 12);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "가 격";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(66, 204);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "검  색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.txtDoor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "차계부";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chDoor;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.TextBox txtDoor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}
