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

namespace WinFormDB07_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataSet;
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);
            adapter = new MySqlDataAdapter();  // DataSet과 DB 연결(명령 수행)
            dataSet = new DataSet();           // 메모리상의 가상 DataTable 관리
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            string sql = "SELECT * FROM city WHERE CountryCode = @CountryCode";

            adapter.SelectCommand = new MySqlCommand(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@CountryCode", textBox3.Text);

            try
            {
                conn.Open();
                // select 결과를 dataSet에 "city"라는 이름의 테이블로 만들어라.
                if (adapter.Fill(dataSet, "city") > 0)  // 검색된 데이터의 행숫자 반환
                    dataGridView1.DataSource = dataSet.Tables["city"];
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            } 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";

            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@name", textBox2.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@district", textBox4.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@population", textBox5.Text);

            try
            {
                conn.Open();
                adapter.InsertCommand.ExecuteNonQuery();  // DB에 반영

                dataSet.Clear();
                adapter.Fill(dataSet, "city");
                dataGridView1.DataSource = dataSet.Tables["city"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
