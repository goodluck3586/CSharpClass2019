using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjectSample
{
    public partial class Form2 : Form
    {
        private string id;
        private string name;
        private string countrycode;
        private string district;
        private string population;
        private int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.id = v1;
            this.name = v2;
            this.countrycode = v3;
            this.district = v4;
            this.population = v5;
        }

        Form1 mainForm;
        private void Form2_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtName.Text = name;
            txtCountryCode.Text = countrycode;
            txtDistrict.Text = district;
            txtPopulation.Text = population;

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtName.Text,
                txtCountryCode.Text,
                txtDistrict.Text,
                txtPopulation.Text };
            mainForm.InsertRow(rowDatas);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                txtId.Text,
                txtName.Text,
                txtCountryCode.Text,
                txtDistrict.Text,
                txtPopulation.Text };
            mainForm.UpdateRow(rowDatas);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteRow(id);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtCountryCode.Clear();
            txtDistrict.Clear();
            txtPopulation.Clear();
        }
    }
}
