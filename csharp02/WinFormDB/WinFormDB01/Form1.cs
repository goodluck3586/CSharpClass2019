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

namespace WinFormDB01
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
            try
            {
                string connectionStr = "server=localhost;port=3306;username=root;password=1111";
                conn = new MySqlConnection(connectionStr);

                conn.Open();
                ShowConnectionState();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                ShowConnectionState();
            }
        }

        private void ShowConnectionState()
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                ShowConnectionState();
            }
        }
    }
}
