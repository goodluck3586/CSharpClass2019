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

namespace WinFormDB04_SUID
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
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "select * from city where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString("id");
                    textBox2.Text = reader.GetString("name");
                    textBox3.Text = reader.GetString("countrycode");
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";
            ExecuteQuery(sql, "Data Inserted");
        }

        private void ExecuteQuery(string sql, string caption)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBox3.Text);
            cmd.Parameters.AddWithValue("@district", textBox4.Text);
            cmd.Parameters.AddWithValue("@population", textBox5.Text);

            try
            {
                cmd.ExecuteNonQuery();
                ShowData(caption);
                //MessageBox.Show("Data Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 처리된 데이터를 MessageBox로 띄움.
        private void ShowData(string caption)
        {
            string sql = "select * from city where name=@name and countrycode=@countrycode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBox3.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                string msg = "";
                if (reader.Read())
                {
                    msg += $"ID : {reader.GetString("id")}\n";
                    msg += $"Name : {reader.GetString("name")}\n";
                    msg += $"CountryCode : {reader.GetString("countrycode")}\n";
                    msg += $"District : {reader.GetString("district")}\n";
                    msg += $"Population : {reader.GetString("population")}\n";
                }
                reader.Close();
                MessageBox.Show(msg, caption);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, " +
                "population=@population WHERE id=@id";
            ExecuteQuery(sql, "Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM city WHERE id=@id";
            ExecuteQuery(sql, "Data Deleted");
        }
    }
}
