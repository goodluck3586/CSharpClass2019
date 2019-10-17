using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* group by into 로 데이터 분류하기 (494p 예제) */
namespace LINQ04_GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성",  Height=186, Gender="남성" },
                new Profile(){Name="김태희",  Height=163, Gender="여성" }, 
                new Profile(){Name="고현정",  Height=172, Gender="여성" },
                new Profile(){Name="이문세",  Height=178, Gender="남성" },
                new Profile(){Name="하동훈",  Height=171, Gender="남성" }
            };

            #region 성별로 그룹 나눔
            // 2. 쿼리 만들기
            var profileList1 = from profile in arrProfile
                               group profile by profile.Gender;

            // 3. 쿼리 실행(출력)
            PrintLinqList<string>(profileList1);
            #endregion

            #region 키(175)로 분류
            // 2. 쿼리 만들기(키 175이상과 미만으로 그룹을 분류함) 
            var profileList2 = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175;

            // 3. 쿼리 실행
            PrintLinqList<bool>(profileList2);
            #endregion

            #region 키(175)로 분류(멤버가 3명 이상인 그룹만 필터링)
            // 2. 쿼리 만들기(키 175이상과 미만으로 그룹을 분류함) 
            var profileList3 = from profile in arrProfile
                               orderby profile.Height
                               group profile by profile.Height < 175 into g
                               where g.Count() >= 3
                               select g;

            // 3. 쿼리 실행
            PrintLinqList<bool>(profileList3);
            #endregion

            #region 키(175)로 분류, inchHeight 추가
            // 2. 쿼리 만들기(키 175이상과 미만으로 그룹을 분류함) 
            var profileList4 = from profile in arrProfile
                               orderby profile.Height
                               group new { Name = profile.Name,
                                   centiHeight = profile.Height,
                                   inchHeight = profile.Height * 0.393 } by profile.Height < 175;

            // 3. 쿼리 실행
            foreach (var Group in profileList4)
            {
                Console.WriteLine($"175 미만인가요? {Group.Key}");
                foreach (var item in Group)
                    Console.WriteLine($"{item.Name}, {item.centiHeight}, {item.inchHeight:F1}");
                Console.WriteLine();
            }
            #endregion
        }


        private static void PrintLinqList<T>(IEnumerable<IGrouping<T, Profile>> profileList)
        {
            foreach (var Group in profileList)
            {
                Console.WriteLine($"그룹 이름: {Group.Key}");  // Group.Key => 남성/여성
                foreach (var item in Group)
                    Console.WriteLine($"{item.Name}, {item.Height}, {item.Gender}");
                Console.WriteLine();
            }
        }
    }
}
