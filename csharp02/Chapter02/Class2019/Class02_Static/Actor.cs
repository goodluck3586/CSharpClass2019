using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_Static
{
    class Actor
    {
        // 인스턴스 필드
        public string name;
        public int countOfInstance;

        // 정적 필드
        static public int staticCountOfInstance;

        // 인스턴스 메소드
        public void SetName(string name)
        {
            this.name = name;
        }

        // 정적 메소드
        public static int GetCountOfInstance()
        {
            return staticCountOfInstance;
        }

        public Actor(string name)
        {
            this.name = name;
            countOfInstance++;
            staticCountOfInstance++;
            Console.WriteLine($"{name} 객체 생성");
        }
    }
}
