using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB03_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");

            try
            {
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    labelConnectionState.Text = "DB 연결 성공";
                    labelConnectionState.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 데이터 검색
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "select * from city where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.Add("@id", MySqlDbType.Int32);
            //cmd.Parameters["@id"].Value = textBox1.Text;
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // select 결과가 있으면 true, 실행하면 다음 행을 가리킴.
                {
                    textBox1.Text = reader.GetString("id");  // 해당 이름의 컬럼 데이터 가져오기
                    textBox2.Text = reader.GetString("name");
                    textBox3.Text = reader.GetString("CountryCode");
                    textBox4.Text = reader.GetString("district");
                    textBox5.Text = reader.GetString("population");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // 데이터 삽입
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "insert into city (name, countrycode, district, population) " +
                "values(@name, @countrycode, @district, @population)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar);
            cmd.Parameters.Add("@countrycode", MySqlDbType.VarChar, 3);
            cmd.Parameters.Add("@district", MySqlDbType.VarChar);
            cmd.Parameters.Add("@population", MySqlDbType.Int32);
            cmd.Parameters["@name"].Value = textBox2.Text;
            cmd.Parameters["@countrycode"].Value = textBox3.Text;
            cmd.Parameters["@district"].Value = textBox4.Text;
            cmd.Parameters["@population"].Value = textBox5.Text;

            try
            {
                // Insert문을 실행한 결과 영향을 받은 행 수 반환
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowdData("Data Inserted");
                    TextBoxClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* 삽입 성공한 레코드 메시지박스로 출력 */
        void ShowdData(string caption)
        {
            string sql = "select * from city where name=@name and countrycode=@countrycode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBox3.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                string row = "";
                if (reader.Read())  // select 결과가 있으면 true, 실행하면 다음 행을 가리킴.
                {
                    row += $"id = {reader.GetString("id")}\n";
                    row += $"name = {reader.GetString("name")}\n";
                    row += $"countrycode = {reader.GetString("countrycode")}\n";
                    row += $"district = {reader.GetString("district")}\n";
                    row += $"population = {reader.GetString("population")}\n";

                    MessageBox.Show(row, caption);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // 데이터 수정
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update city set " +
                "name=@name, countrycode=@countrycode, district=@district, population=@population " +
                "where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar);
            cmd.Parameters.Add("@countrycode", MySqlDbType.VarChar, 3);
            cmd.Parameters.Add("@district", MySqlDbType.VarChar);
            cmd.Parameters.Add("@population", MySqlDbType.Int32);
            cmd.Parameters["@id"].Value = textBox1.Text;
            cmd.Parameters["@name"].Value = textBox2.Text;
            cmd.Parameters["@countrycode"].Value = textBox3.Text;
            cmd.Parameters["@district"].Value = textBox4.Text;
            cmd.Parameters["@population"].Value = textBox5.Text;

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowdData("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from city where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Deleted");
                    TextBoxClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }
    }
}
