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
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=world;uid=root;pwd=1111");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM city", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM city WHERE countrycode=@countrycode";
            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "city") > 0)  // 검색된 데이터의 행 수 반환
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
            #region InsertCommand를 이용한 처리
            //string sql = "INSERT INTO city (name, countrycode, district, population) " +
            //    "VALUES(@name, @countrycode, @district, @population)";
            //dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            //dataAdapter.InsertCommand.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            //try
            //{
            //    conn.Open();

            //    if (dataAdapter.InsertCommand.ExecuteNonQuery() > 0)  // 검색된 데이터의 행 수 반환
            //    {
            //        dataSet.Clear();
            //        dataAdapter.Fill(dataSet, "city");
            //        dataGridView1.DataSource = dataSet.Tables["city"];
            //    }
            //    else
            //        MessageBox.Show("검색된 데이터가 없습니다.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

            #region Update()를 이용한 처리
            string sql = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";
            dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            // 메모리상에 새로운 행(row) 생성
            DataRow newRow = dataSet.Tables["city"].NewRow();
            newRow["name"] = textBoxName.Text;
            newRow["countrycode"] = textBoxCountryCode.Text;
            newRow["district"] = textBoxDistrict.Text;
            newRow["population"] = textBoxPopulation.Text;
            dataSet.Tables["city"].Rows.Add(newRow);

            try
            {
                if (dataAdapter.Update(dataSet, "city") > 0)  // 메모리상에 수정된 내용을 실제 DB에 업데이트
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "city");
                    dataGridView1.DataSource = dataSet.Tables["city"];
                }
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
            #endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, " +
            //    "population=@population WHERE countrycode=@countrycode";
            string sql = "UPDATE city SET district=@district WHERE countrycode=@countrycode";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", textBoxId.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", textBoxCountryCode.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", textBoxDistrict.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", textBoxPopulation.Text);

            try
            {
                conn.Open();

                if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)  // 검색된 데이터의 행 수 반환
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "city");
                    dataGridView1.DataSource = dataSet.Tables["city"];
                }
                else
                    MessageBox.Show("수정된 데이터가 없습니다.");
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
