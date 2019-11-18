using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 메모리 상에서 구현되는 DataTable 연습 */
namespace WinFormDB05_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 단계: 테이블과 컬럼 만들기
            DataTable dataTable = new DataTable("dataTable");  // 메모리 상의 데이터 테이블
            DataColumn col;

            col = new DataColumn("name", typeof(string));
            col.MaxLength = 10;
            col.AllowDBNull = false;
            dataTable.Columns.Add(col);

            col = new DataColumn("age", typeof(int));
            dataTable.Columns.Add(col);

            col = new DataColumn("male", typeof(bool));
            dataTable.Columns.Add(col);

            // 2 단계: 행 만들기, 데이터 입력
            DataRow row = dataTable.NewRow();
            row["name"] = "아이유";
            row["age"] = 26;
            row["male"] = false;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["name"] = "조승우";
            row["age"] = 39;
            row["male"] = true;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["name"] = "장만월";
            row["age"] = 1000;
            row["male"] = false;
            dataTable.Rows.Add(row);

            // 3단계: 모든 데이터 출력
            foreach (DataRow selectedRow in dataTable.Rows)  
            {
                string gender;
                if(selectedRow["male"].ToString() == "True")
                    gender = "남자";
                else
                    gender = "여자";

                Console.WriteLine($"Name: {selectedRow["name"]}, " +
                    $"Age: {selectedRow["age"]}, " +
                    $"Gender: {gender}");
            }
        }
    }
}
