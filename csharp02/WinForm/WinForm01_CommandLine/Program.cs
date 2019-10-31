using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm01_CommandLine
{
    public class Form1 : Form
    {
        public Button button1;
        public Form1()
        {
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
