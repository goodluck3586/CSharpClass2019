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
                new Profile(){Name="정우성",  Height=186},
                new Profile(){Name="김태희",  Height=163},
                new Profile(){Name="고현정",  Height=172},
                new Profile(){Name="이문세",  Height=178},
                new Profile(){Name="하동훈",  Height=171}
            };

            #region 단순 추출
            // 2. 쿼리 만들기(이름만 추출)
            var profileList1 = from profile in arrProfile
                               select profile.Name;

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList1)
                Console.WriteLine($"Name : {item}");
            Console.WriteLine();
            #endregion

            #region 키 175 미만 데이터만 오름차순 정렬하여 추출
            // 2. 쿼리 만들기
            var profileList2 = from profile in arrProfile
                               where profile.Height < 175
                               orderby profile.Height
                               select profile;

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList2)
                Console.WriteLine($"Name : {item.Name}, Height: {item.Height}");
            Console.WriteLine();
            #endregion

            #region 무명 객체 사용(키를 cm에다 inch 데이터 추가)
            // 2. 쿼리 만들기
            var profileList3 = from profile in arrProfile
                               where profile.Height < 175
                               orderby profile.Height
                               select new { Name = profile.Name, centiHight = profile.Height, inchHeighr = profile.Height * 0.393 };

            // 3. 쿼리 실행(출력)
            foreach (var item in profileList3)
                Console.WriteLine($"Name : {item.Name}, centiHeight: {item.centiHight}, inchHeight: {item.inchHeighr}");
            Console.WriteLine();
            #endregion
        }
    }
}
