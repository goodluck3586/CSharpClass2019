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
            // 1. DB 연결 설정
            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");

            try
            {
                // 2. DB 열기
                conn.Open();

                // 3. SELECT 쿼리 실행
                string query = "SELECT distinct continent FROM country";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // 4. 쿼리 결과 가져오기
                MySqlDataReader reader = cmd.ExecuteReader();

                // 5. 가져온 데이터 활용
                while (reader.Read())  // 다음 레코드가 있으면 true 반환
                {
                    comboBox1.Items.Add(reader.GetString("Continent"));  // 컬럼 이름으로 데이터 가져오기
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT name FROM country WHERE continent='{comboBox1.SelectedItem}'";
                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataReader reader = com.ExecuteReader();

                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString("name"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
