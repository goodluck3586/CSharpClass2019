using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace mook_CarInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string StrSQL = "Data Source=localhost;Database=mook;User Id=root;Password=p12345!@;SslMode=none;port=3306;CharSet=utf8;"; //데이터베이스 연결 문자열
        private string Data_Num; // 선택된 lvList 컨트롤 행의 값 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            lvList_MySqlClient_View();
        }

        private void lvList_MySqlClient_View()
        {
            this.lvList.Items.Clear();
            var Conn = new MySqlConnection(StrSQL);
            Conn.Open();

            var Comm = new MySqlCommand("Select * From carinfo", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["id"].ToString(),
                    myRead["c_name"].ToString(), myRead["c_year"].ToString(),
                    myRead["c_price"].ToString(), myRead["c_door"].ToString() };
                var lvt = new ListViewItem(strArray);
                this.lvList.Items.Add(lvt);
            }
            myRead.Close();
            Conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtYear.Text != ""
                && this.txtPrice.Text != "" && this.txtDoor.Text != "")
            {
                var Conn = new MySqlConnection(StrSQL);
                Conn.Open();
                string Sql = "insert into carinfo(c_name, c_year, c_price, c_door) values('";
                Sql += this.txtName.Text + "'," + this.txtYear.Text + ",'" +
                    this.txtPrice.Text + "'," + Convert.ToInt32(this.txtDoor.Text) + ")";
                var Comm = new MySqlCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_MySqlClient_View();
                    Control_Clear();
                }
                else
                {
                    MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Control_Clear()
        {
            this.txtName.Clear();
            this.txtYear.Clear();
            this.txtPrice.Clear();
            this.txtDoor.Clear();
        }

        private void lvList_Click(object sender, EventArgs e)
        {
            if (this.lvList.SelectedItems.Count > 0)
            {
                this.txtName.Text = this.lvList.SelectedItems[0].SubItems[1].Text;
                this.txtYear.Text = this.lvList.SelectedItems[0].SubItems[2].Text;
                this.txtPrice.Text = this.lvList.SelectedItems[0].SubItems[3].Text;
                this.txtDoor.Text = this.lvList.SelectedItems[0].SubItems[4].Text;
                Data_Num = this.lvList.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtYear.Text != "" &&
                this.txtPrice.Text != "" && this.txtDoor.Text != "")
            {
                try
                {
                    var Conn = new MySqlConnection(StrSQL);
                    Conn.Open();

                    var MySqlAdapter = new MySqlDataAdapter("select * from carinfo", Conn);

                    var ds = new DataSet();
                    MySqlAdapter.Fill(ds, "dsTable");
                    var dt = ds.Tables["dsTable"].Select("id =" + Convert.ToInt32(this.Data_Num),
                        null, DataViewRowState.CurrentRows);

                    DataRow drTemp;
                    drTemp = dt[0];
                    drTemp["c_name"] = this.txtName.Text;
                    drTemp["c_year"] = this.txtYear.Text;
                    drTemp["c_price"] = this.txtPrice.Text;
                    drTemp["c_door"] = this.txtDoor.Text;

                    var cmdBuild = new MySqlCommandBuilder(MySqlAdapter);
                    MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
                    MySqlAdapter.Update(ds, "dsTable");
                    cmdBuild.Dispose();

                    MessageBox.Show("정상적으로 데이터가 수정되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_MySqlClient_View();
                    Control_Clear();
                }
                catch
                {
                    MessageBox.Show("정상적으로 데이터가 수정되지 않았습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvList.Items.Clear();
            var Conn = new MySqlConnection(StrSQL);
            Conn.Open();

            var Comm = new MySqlCommand("Select * From carinfo where c_name = '" + this.txtName.Text + "' or c_year = '" 
                + this.txtYear.Text + "' or c_price = '" + this.txtPrice.Text + "' or c_door = " 
                + Convert.ToInt32((this.txtDoor.Text == "") ? 0 : Convert.ToInt32(this.txtDoor.Text)) + "", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["id"].ToString(),
                    myRead["c_name"].ToString(), myRead["c_year"].ToString(),
                    myRead["c_price"].ToString(), myRead["c_door"].ToString() };
                var lvt = new ListViewItem(strArray);
                this.lvList.Items.Add(lvt);
            }
            myRead.Close();
            Conn.Close();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvList.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("데이터를 삭제할까요?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    var Conn = new MySqlConnection(StrSQL);
                    Conn.Open();
                    string Sql = "delete from carinfo where id = " + Convert.ToInt32(this.lvList.SelectedItems[0].SubItems[0].Text) + "";
                    var Comm = new MySqlCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("데이터가 정상적으로 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("데이터를 삭제하지 못하였습니다..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Control_Clear();
                    lvList_MySqlClient_View();
                }
            }
            else
                MessageBox.Show("삭제할 행을 선택하세요.", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}