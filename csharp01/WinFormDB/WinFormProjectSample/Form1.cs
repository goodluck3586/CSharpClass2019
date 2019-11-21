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

namespace WinFormProjectSample
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=world;uid=root;pwd=1111";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM city", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];

            SetSearchComboBox();
        }

        #region ComboBox 세팅
        // **** 검색 조건 ComboBox에 CountryCode 목록 세팅 ****
        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct countryCode FROM city";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // CountryCode 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbCountryCode.Items.Add(reader.GetString("countryCode"));
                }
                reader.Close();

                // District 목록 표시
                sql = "SELECT distinct district FROM city";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbDistrict.Items.Add(reader.GetString("district"));
                }
                reader.Close();
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

        // 검색조건에서 특정 CountryCode를 선택하면 해당 국가의 District를 채움.
        private void cbCountryCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct district FROM city WHERE countrycode=@countrycode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@countrycode", cbCountryCode.Text);

            cbDistrict.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // District 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbDistrict.Items.Add(reader.GetString("district"));
                }
                reader.Close();
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
        #endregion

        // **** SELECT 버튼 클릭 ****
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[5];
            conditions[0] = (textBoxID.Text != "") ? "id=@id" : null;
            conditions[1] = (textBoxName.Text != "") ? "name=@name" : null;
            conditions[2] = (cbCountryCode.Text != "") ? "countrycode=@countrycode" : null;
            conditions[3] = (cbDistrict.Text != "") ? "district=@district" : null;
            string condition_population;
            if (textBoxMin.Text != "" && textBoxMax.Text != "")
            {
                condition_population = "population>=@min and population<=@max";
            }
            else if (textBoxMin.Text != "" || textBoxMax.Text != "")
            {
                if (textBoxMin.Text != "")
                    condition_population = "population>=@min";
                else
                    condition_population = "population <= @max";
            }
            else
            {
                condition_population = null;
            }
            conditions[4] = condition_population;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM city WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM city";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", textBoxID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", textBoxName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@countryCode", cbCountryCode.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@district", cbDistrict.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@min", textBoxMin.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@max", textBoxMax.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "city") > 0)
                    dataGridView1.DataSource = dataSet.Tables["city"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
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

        // **** DataGridView에서 행을 선택하면 새창을 띄움 ****
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            // 새로운 폼에 선택된 row의 정보를 담아서 생성
            Form2 Dig = new Form2(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString()
                );

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // **** Insert SQL 실행 ****
        public void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO city (name, countrycode, district, population) " +
                "VALUES(@name, @countrycode, @district, @population)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@countrycode", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@district", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@population", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@name"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@countrycode"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@district"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@population"].Value = rowDatas[3];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "city");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["city"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기
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

        // **** Delete SQL 실행 ****
        internal void DeleteRow(string id)
        {
            string sql = "DELETE FROM city WHERE id=@id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "city");
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

        // **** Update SQL 실행 ****
        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE city SET name=@name, countrycode=@countrycode, district=@district, population=@population WHERE id=@id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@id", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@countrycode", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@district", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@population", rowDatas[4]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "city");
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

        // **** Insert 버튼 클릭(새창 띄우기) ****
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }



        // 검색 조건 초기화 함수
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            cbCountryCode.Text = "";
            cbDistrict.Text = "";
            textBoxMin.Clear();
            textBoxMax.Clear();
        }
    }
}
