using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace mook_EduMgr
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int EudNum { get; set; }

        private string Constr = "server=localhost;uid=mook;pwd=p12345!@;database=mook"; //SQL 연결문자열

        private void btnModify_Click(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();
            var strSQL = "update t_userinfo set birth = '" + this.txtBirth.Text + "', email = '" + this.txtEmail.Text + "', phone = '" + this.txtPhone.Text + "' where edunum = " + EudNum + "";
            var myCom = new SqlCommand(strSQL, Conn);
            int i = myCom.ExecuteNonQuery();
            Conn.Close();
            if (i == 1) DialogResult = DialogResult.OK;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select name, edunum, birth, email, phone from t_userinfo where edunum = " + EudNum + "", Conn);
            var myRead = Comm.ExecuteReader();
            if (myRead.Read())
            {
                this.txtName.Text = myRead[0].ToString();
                this.txtEduNum.Text = myRead[1].ToString();
                this.txtBirth.Text = myRead[2].ToString();
                this.txtEmail.Text = myRead[3].ToString();
                this.txtPhone.Text = myRead[4].ToString();
            }
            myRead.Close();
            Conn.Close();
        }
    }
}
