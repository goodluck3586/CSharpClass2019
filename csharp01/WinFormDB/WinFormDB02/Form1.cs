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

namespace WinFormDB02
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
            // 1. 데이터베이스 연결 설정
            string connectionString = "server=localhost;port=3306;database=world;username=root;password=1111";
            conn = new MySqlConnection(connectionString);

            try
            {
                // 2. 데이터베이스 열기
                conn.Open();
                ShowDBConnectionState();

                // 3. SELECT 쿼리를 실행할 객체 준비
                string queryString = "SELECT distinct continent FROM country";
                MySqlCommand command = new MySqlCommand(queryString, conn);

                // 4. 쿼리 실행 및 결과 가져오기
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  // 가져올 레코드(행)이 있으면 true
                {
                    comboBox1.Items.Add(reader.GetString("continent"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ShowDBConnectionState()
        {
            if (conn.State == ConnectionState.Open)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString = $"SELECT * FROM country WHERE continent='{comboBox1.SelectedItem}'";
            MySqlCommand command = new MySqlCommand(queryString, conn);
            MySqlDataReader reader = command.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString("name"));
            }
            reader.Close();
        }
    }
}
