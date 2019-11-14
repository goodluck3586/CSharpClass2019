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

namespace WinFormDB01_MySqlCommand
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
            // 1. DB 연결 설정
            string connectionString = "server=localhost;port=3306;database=world;username=root;password=1111";
            conn = new MySqlConnection(connectionString);

            try
            {
                // 2. DB 열기
                conn.Open();

                if(conn.State == ConnectionState.Open)
                {
                    label1.Text = "Connected";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Not Connected";
                    label1.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 3. SELECT 쿼리 실행
            string queryString = "select distinct continent from country";
            MySqlCommand command = new MySqlCommand(queryString, conn);

            // 4. 쿼리 결과 가져오기
            MySqlDataReader reader = command.ExecuteReader();

            // 5. 데이터 활용
            while (reader.Read())  // 가져올 레코드가 있으면 true
            {
                comboBox1.Items.Add(reader.GetString("continent"));  // 콤보박스에 대륙이름 추가
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();  // 나라 이름을 표시하는 콤보박스 컬렉션 비우기

            string queryStr = $"select * from country where continent='{comboBox1.SelectedItem}'";
            MySqlCommand command = new MySqlCommand(queryStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString("Name"));
            }
            reader.Close();
        }
    }
}
