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

namespace WinFormDB04_SIUD
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM city WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.Add("@id", MySqlDbType.Int32);
            //cmd.Parameters["@id"].Value = textBoxId.Text;
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxId.Text = reader.GetString("id");
                    textBoxName.Text = reader.GetString("name");
                    textBoxCountryCode.Text = reader.GetString("countrycode");
                    textBoxDistrict.Text = reader.GetString("district");
                    textBoxPopulation.Text = reader.GetString("population");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ShowRowData(string captionMsg)
        {
            string sql = "select * from city where name = @name and countrycode = @countrycode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();  // 5. 쿼리 실행 및 결과 저장

                string selectData = "";
                if (reader.Read())  // 가져온 행이 있으면 true을 반환
                {
                    selectData += $"ID = {reader.GetString("id")}\n";
                    selectData += $"Name = {reader.GetString("name")}\n";
                    selectData += $"CountryCode = {reader.GetString("countrycode")}\n";
                    selectData += $"District = {reader.GetString("district")}\n";
                    selectData += $"Population = {reader.GetString("population")}\n";     
                }
                MessageBox.Show(selectData, captionMsg);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteQuery(string sql, string caption)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            cmd.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            cmd.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            try
            {
                cmd.ExecuteNonQuery();
                ShowRowData(caption);
                TextBoxClear();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        void TextBoxClear()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxCountryCode.Clear();
            textBoxDistrict.Clear();
            textBoxPopulation.Text = "";
        }
    }
}
