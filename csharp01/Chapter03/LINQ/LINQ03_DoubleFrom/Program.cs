using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 491p 예제(중첩된 from문 사용) */
namespace LINQ03_DoubleFrom
{
    class Class
    {
        public string Name { get; set; }
        public  int[] Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스
            Class[] arrClass =
            {
                new Class(){Name="연두반", Score=new int[]{99,80,70,24}},
                new Class(){Name="분홍방", Score=new int[]{60,45,87,82}},
                new Class(){Name="파랑반", Score=new int[]{92,30,85,94}},
                new Class(){Name="노랑반", Score=new int[]{90,88,0,17}}
            };

            // 2. 쿼리 만들기(클래스 이름과 60점 미만 점수만 추출한 무명 객체 생성, 오름차순 정렬)
            var classes = from c in arrClass  // c : new Class(){Name="연두반", Score=new int[]{99,80,70,24}}
                          from score in c.Score
                          where score < 60
                          orderby score
                          select new { Name = c.Name, Lowest = score };

            // 3. 쿼리 실행(출력)
            foreach (var item in classes)
            {
                Console.WriteLine($"낙제 : {item.Name}({item.Lowest})");
            }
        }
    }
}
