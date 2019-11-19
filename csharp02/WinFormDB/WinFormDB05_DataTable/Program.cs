using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDB05_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 단계: 테이블과 컬럼 세팅
            DataTable dataTable = new DataTable("dataTable");
            DataColumn col;

            col = new DataColumn("Name", typeof(string));
            col.MaxLength = 10;
            col.AllowDBNull = false;
            dataTable.Columns.Add(col);

            col = new DataColumn("Age", typeof(int));
            dataTable.Columns.Add(col);

            col = new DataColumn("Male", typeof(bool));
            dataTable.Columns.Add(col);

            // 2 단계: 행(row) 생성 및 추가
            DataRow row;
            row = dataTable.NewRow();
            row["Name"] = "아이유";
            row["Age"] = 26;
            row["Male"] = false;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Name"] = "조승우";
            row["Age"] = 39;
            row["Male"] = true;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["Name"] = "장만월";
            row["Age"] = 1000;
            row["Male"] = false;
            dataTable.Rows.Add(row);

            // 3 단계: 모든 행 출력
            foreach (DataRow r in dataTable.Rows)
            {
                string gender = "";
                if (r["Male"].ToString() == "True")
                    gender = "남성";
                else
                    gender = "여성";

                Console.WriteLine($"Name: {r["Name"]}, Age: {r["Age"]}, Gender: {gender}");
            }
        }
    }
}
