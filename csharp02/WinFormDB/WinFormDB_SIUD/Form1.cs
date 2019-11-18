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

namespace WinFormDB_SIUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;  // DB 연결 객체
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");

            try
            {
                conn.Open();  // DB 열기

                // DB 연결 상태 표시
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
            string sql = "select * from city where id=@id";  // 1. 쿼리 스트링 준비
            MySqlCommand cmd = new MySqlCommand(sql, conn);  // 2. 쿼리 실행 객체 준비
            cmd.Parameters.Add("@id", MySqlDbType.Int32);   // 3. 쿼리 스티링의 매개변수 설정
            cmd.Parameters["@id"].Value = int.Parse(textBoxId.Text);  // 4. 쿼리 스트링의 매개변수갑 저장

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();  // 5. 쿼리 실행 및 결과 저장

                if (reader.Read())  // 가져온 행이 있으면 true을 반환
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

        // 데이터 삽입
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.Add("@name", MySqlDbType.VarChar);
            //cmd.Parameters["@name"].Value = textBoxName.Text;
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            cmd.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            cmd.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            try
            {
                cmd.ExecuteNonQuery();
                ShowRowData("Data Inserted");
                TextBoxesClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 조작 성공한 데이터를 메시지박스에 표시함.
        private void ShowRowData(string captionMsg)
        {
            string sql = "select * from city where name=@name and countrycode=@countrycode";  
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

                    MessageBox.Show(selectData, captionMsg);
                }
                reader.Close();
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
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            cmd.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            cmd.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            try
            {
                cmd.ExecuteNonQuery();
                ShowRowData("Data Updated");
                TextBoxesClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM city where id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                TextBoxesClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxesClear()
        {
            textBoxId.Clear();
            textBoxName.Text = "";
            textBoxCountryCode.Clear();
            textBoxDistrict.Clear();
            textBoxPopulation.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxesClear();
        }
    }
}
