using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB06_DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 1 단계: 테이블과 컬럼 세팅
            dataTable = new DataTable("dataTable");
            DataColumn col;

            col = new DataColumn("Name", typeof(string));
            col.MaxLength = 10;
            col.AllowDBNull = false;
            dataTable.Columns.Add(col);

            col = new DataColumn("Age", typeof(int));
            dataTable.Columns.Add(col);

            col = new DataColumn("Male", typeof(bool));
            dataTable.Columns.Add(col);
            #endregion

            #region 2 단계: 행(row) 생성 및 추가
            DataRow row;
            row = dataTable.NewRow();
            row["Name"] = "아이유";
            row["Age"] = 26;
            row["Male"] = false;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Name"] = "조승우";
            row["Age"] = 39;
            row["Male"] = true;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Name"] = "장만월";
            row["Age"] = 1000;
            row["Male"] = false;
            dataTable.Rows.Add(row);
            #endregion

            dataGridView1.DataSource = dataTable;
        }

        // 새로운 행(row) 추가
        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            row["Name"] = textBoxName.Text;
            row["Age"] = textBoxAge.Text;
            if (rbMale.Checked)
                row["Male"] = true;
            else
                row["Male"] = false;
            dataTable.Rows.Add(row);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            int selectedRowIndex = rows[0].Index;  // 선택된 첫 줄의 index만 가져옴.
            DataRow row = dataTable.Rows[selectedRowIndex];  // 참조 가져오기
            row["Name"] = textBoxName.Text;
            row["Age"] = textBoxAge.Text;
            if (rbMale.Checked)
                row["Male"] = true;
            else
                row["Male"] = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            int selectedRowIndex = rows[0].Index;  // 선택된 첫 줄의 index만 가져옴.
            DataRow row = dataTable.Rows[selectedRowIndex];  // 참조 가져오기
            row.Delete();
        }
    }
}
