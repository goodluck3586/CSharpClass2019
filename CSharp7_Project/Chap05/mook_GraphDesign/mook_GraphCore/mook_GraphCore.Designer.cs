namespace mook_GraphCore
{
    partial class mook_GraphCore
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.plChart = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // plChart
            // 
            this.plChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plChart.Location = new System.Drawing.Point(0, 0);
            this.plChart.Name = "plChart";
            this.plChart.Size = new System.Drawing.Size(192, 91);
            this.plChart.TabIndex = 2;
            this.plChart.Paint += new System.Windows.Forms.PaintEventHandler(this.plChart_Paint);
            // 
            // mook_GraphCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plChart);
            this.Name = "mook_GraphCore";
            this.Size = new System.Drawing.Size(192, 91);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plChart;
    }
}