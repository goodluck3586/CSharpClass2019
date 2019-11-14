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

namespace WinFormDB02_DataReader
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

                // 3. SELECT 쿼리 객체 준비
                string queryString = "SELECT distinct continent FROM country";
                MySqlCommand command = new MySqlCommand(queryString, conn);

                // 4. 쿼리 실행 및 데이터 가져오기
                MySqlDataReader reader = command.ExecuteReader();

                // 5. 데이터 활용
                while (reader.Read()) // 가져올 레코드가 있으면 true 없으면 false
                {
                    comboBox1.Items.Add(reader.GetString("continent"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
