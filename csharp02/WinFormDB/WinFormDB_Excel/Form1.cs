using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormDB_Excel
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

        // 파일 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            // dataGridView에 데이터가 있는지 체크
            if(dataGridView1.RowCount == 0)
            {
                MessageBox.Show("저장할 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 라디오 버튼 선택에 따라 txt/excel로 저장
            if (rbTxt.Checked)
            {
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveTxtFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveExcelFile(saveFileDialog1.FileName);
                }
            }
        }

        private void SaveExcelFile(string filePath)
        {
            // 1. 엑셀 사용에 필요한 객체 준비
            Excel.Application eApp;     // 엑셀 프로그램
            Excel.Workbook eWorkbook;   // 엑셀 워크북(시트 여러개 포함)
            Excel.Worksheet eWorkSheet; // 엑셀 워크시트

            eApp = new Excel.Application();
            eWorkbook = eApp.Workbooks.Add();       // 엑셀 프로그램 객체에 포함시킴.
            eWorkSheet = eWorkbook.Sheets[1];       // 엑셀 워크시트는 index가 1부터 시작됨.

            // 2. 엑셀에 저장할 데이터를 2차원 스트링 배열로 준비
            int colCount = dataSet.Tables["city"].Columns.Count;
            int rowCount = dataSet.Tables["city"].Rows.Count +1 ;
            string[,] dataArr = new string[rowCount, colCount];     // 검색 결과를 저장할 배열

            // 2-1 Column 이름 저장
            for (int i = 0; i < dataSet.Tables["city"].Columns.Count; i++)
            {
                dataArr[0, i] = dataSet.Tables["city"].Columns[i].ColumnName;   // 찻 헹에 컬럼이름들 저장
            }

            // 2-2 Row 데이터 저장
            for (int i = 0; i < dataSet.Tables["city"].Rows.Count; i++)
            {
                for (int j = 0; j < dataSet.Tables["city"].Columns.Count; j++)
                {
                    dataArr[i + 1, j] = dataSet.Tables["city"].Rows[i].ItemArray[j].ToString();
                }
            }

            // 3. 준비된 스트링 배열을 엑셀파일로 저장
            string endCell = Convert.ToChar(65 + dataSet.Tables["city"].Columns.Count - 1).ToString() + rowCount.ToString();
            eWorkSheet.get_Range($"A1:{endCell}").Value = dataArr;    // 배열의 데이터를 엑셀 시트에 기록

            eWorkbook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing,
                Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
        }

        void SaveTxtFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Columns 이름들을 저장(한줄)
                foreach (DataColumn col in dataSet.Tables["city"].Columns)
                {
                    sw.Write($"{col.ColumnName}\t");
                }
                sw.WriteLine();

                // Rows 데이터들을 저장
                foreach (DataRow row in dataSet.Tables["city"].Rows)
                {
                    string rowString = "";
                    foreach (var item in row.ItemArray)
                    {
                        rowString += $"{item}\t";   // 각 열의 데이터를 스트링 변수에 저장
                    }
                    sw.WriteLine(rowString);
                }
            }
        }
    }
}
