using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 499p 예제 */
namespace LINQ05_Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
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
                new Profile(){Name="정우성", Height=186, Gender="남성"},
                new Profile(){Name="김태희", Height=163, Gender="여성"},
                new Profile(){Name="고현정", Height=172, Gender="여성"},
                new Profile(){Name="이문세", Height=178, Gender="남성"},
                new Profile(){Name="하동훈", Height=171, Gender="남성"}
            };

            Product[] arrProduct =
            {
                new Product(){Title="비트", Star="정우성"},
                new Product(){Title="프렌치카페", Star="김태희"},
                new Product(){Title="아이리스", Star="김태희"},
                new Product(){Title="모래시계", Star="고현정"},
                new Product(){Title="솔로예찬", Star="이문세"},
                new Product(){Title="호텔 델루나", Star="아이유"}
            };

            #region 내부 조인
            // 2. 쿼리 만들기(이름으로 내부 조인, (Name, Height, Title)을 요소로 가진 컬렉션 반환
            var profileList1 = from profile in arrProfile
                               join product in arrProduct on profile.Name equals product.Star
                               select new { Name = profile.Name, Height = profile.Height, Title = product.Title };

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList1)
                Console.WriteLine($"{item.Name}, {item.Height}, {item.Title}");
            Console.WriteLine();
            #endregion

            #region 외부 조인
            // 2. 쿼리 만들기(이름으로 외부 조인, (Name, Height, Title)을 요소로 가진 컬렉션 반환
            var profileList2 = from product in arrProduct
                               join profile in arrProfile on product.Star equals profile.Name into ps
                               from profile in ps.DefaultIfEmpty(new Profile() { Name="아이유", Height=777})
                               select new { Name = profile.Name, Height = profile.Height, Title = product.Title };

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList2)
                Console.WriteLine($"{item.Name}, {item.Height}, {item.Title}");
            Console.WriteLine();
            #endregion
        }
    }
}
