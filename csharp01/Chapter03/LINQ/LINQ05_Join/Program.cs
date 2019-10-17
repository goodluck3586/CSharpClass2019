using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* join : 각 데이터 원본에서 특정 필드의 값을 비교하여 일치하는 데이터끼리 연결 */
/* 499p 예제 */
namespace LINQ05_Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성",  Height=186},
                new Profile(){Name="김태희",  Height=163},
                new Profile(){Name="고현정",  Height=172},
                new Profile(){Name="이문세",  Height=178},
                new Profile(){Name="하동훈",  Height=171}
            };

            Product[] arrProduct =
            {
                new Product(){Title="비트", Star="정우성"},
                new Product(){Title="프렌치카페", Star="김태희"},
                new Product(){Title="아이리스", Star="김태희"},
                new Product(){Title="모래시계", Star="고현정"},
                new Product(){Title="솔로예찬", Star="이문세"}
            };

            #region 내부 조인
            // 2. 쿼리 만들기(이름으로 조인, Name, Title, Height로 이루어진 무명 객체를 요소로 갖는 쿼리)
            var profileList = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star
                              select new { Name = profile.Name, Title = product.Title, Height = profile.Height };

            // 3. 쿼리 실행(출력)
            Console.WriteLine("------ 내부 조인 결과 ------");
            foreach (var item in profileList)
                Console.WriteLine($"{item.Name}, {item.Title}, {item.Height}");
            Console.WriteLine();
            #endregion

            #region 외부 조인
            // 2. 쿼리 만들기(이름으로 조인, Name, Title, Height로 이루어진 무명 객체를 요소로 갖는 쿼리)
            var profileList2 = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star into ps
                              from product in ps.DefaultIfEmpty(new Product() { Title="그런거 없음"})
                              select new { Name = profile.Name, Title = product.Title, Height = profile.Height };

            // 3. 쿼리 실행(출력)
            Console.WriteLine("------ 외부 조인 결과 ------");
            foreach (var item in profileList2)
                Console.WriteLine($"{item.Name}, {item.Title}, {item.Height}");
            Console.WriteLine();
            #endregion

        }
    }
}
