using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var personList = GetPersonList();

            // listview에 추가
            foreach (var person in personList)
            {
                var row = new string[] { person.Id.ToString(), person.Name, person.MajorWork };
                var newListViewItem = new ListViewItem(row);
                newListViewItem.Tag = person;  // 삽입된 데이터가 Person 객체임을 표시.
                listView1.Items.Add(newListViewItem);
            }
        }

        // 초기에 삽입되는 Person 객체 반환
        private List<Person> GetPersonList()
        {
            var list = new List<Person>();
            list.Add(new Person() { Id = Person.id, Name = "아이유", MajorWork = "나의 아저씨" });
            list.Add(new Person() { Id = Person.id, Name = "조승우", MajorWork = "비밀의 숲" });
            list.Add(new Person() { Id = Person.id, Name = "권상우", MajorWork = "말죽거리 잔혹사" });

            return list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputText())
            {
                Person person = new Person() { Id = Person.id, Name = textBox1.Text, MajorWork = textBox2.Text };
                var row = new string[] { person.Id.ToString(), person.Name, person.MajorWork };
                var newListViewItem = new ListViewItem(row);
                newListViewItem.Tag = person;  // 삽입된 데이터가 Person 객체임을 표시.
                listView1.Items.Add(newListViewItem);

                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private bool CheckInputText()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                return true;
            else
            {
                MessageBox.Show("내용을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Person selectedItem = listView1.SelectedItems[0].Tag as Person;
            if (selectedItem != null)
                MessageBox.Show(selectedItem.ToString());
        }
    }
}
