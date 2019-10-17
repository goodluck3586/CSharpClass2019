using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 488p 예제 */
namespace LINQ02
{
    // 데이터 저장 클래스
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=163},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하동훈", Height=171}
            };

            #region 단순 추출
            // 2. 쿼리 만들기(키 순서대로 이름만 추출하는 쿼리)
            var profileList1 = from profile in arrProfile
                               orderby profile.Height
                               select profile.Name;

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList1)
                Console.WriteLine(item);
            Console.WriteLine();
            #endregion

            #region 키 175미만인 사람만 오름차순으로 정렬
            // 2. 쿼리 만들기(키 순서대로 이름만 추출하는 쿼리)
            var profileList2 = from profile in arrProfile
                               where profile.Height < 175
                               orderby profile.Height
                               select profile;

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList2)
                Console.WriteLine($"Name : {item.Name}, Height: {item.Height}");
            Console.WriteLine();
            #endregion

            #region 무명형식 사용(inchHeight 추가)
            // 2. 쿼리 만들기(키 순서대로 이름만 추출하는 쿼리)
            var profileList3 = from profile in arrProfile
                               where profile.Height < 180
                               orderby profile.Height
                               select new { Name = profile.Name, 
                                   centiHeight = profile.Height, 
                                   inchHeight = profile.Height * 0.393 };

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList3)
                Console.WriteLine($"Name : {item.Name}, " +
                    $"centiHeight: {item.centiHeight}, " +
                    $"inchHeight: {item.inchHeight:F1}");
            Console.WriteLine();
            #endregion

        }
    }
}
