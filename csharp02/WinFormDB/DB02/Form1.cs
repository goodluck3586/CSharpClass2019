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

namespace DB02
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
            conn = new MySqlConnection("server=127.0.0.1;port=3306;database=world;uid=root;pwd=1111");

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
            string queryStr = $"select * from city where id='{textBox1.Text}'";
            MySqlCommand command = new MySqlCommand(queryStr, conn);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader.GetString("Name");
                textBox3.Text = reader.GetString("CountryCode");
                textBox4.Text = reader.GetString("District");
                textBox5.Text = reader.GetString("Population");
            }
            reader.Close();
        }
    }
}
