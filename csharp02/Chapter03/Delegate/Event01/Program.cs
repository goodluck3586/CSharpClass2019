using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 449p 예제 */
namespace Event01
{
    delegate void EventHandler(string msg);  // 델리게이트 선언

    class MyNotifier
    {
        // 이벤트를 위한 인스턴스 선언
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                string str = String.Format("{0} : 짝", number);
                SomethingHappened(str);  // 이벤트 핸들러 실행
            }  
        }
    }

    class Program
    {
        // 이벤트 핸들러(이벤트가 발생하면 실행되는 메소드)
        static void MyHandler(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();  // 이벤트를 가진 클래스의 객체 생성
            notifier.SomethingHappened += MyHandler;  // 이벤트 핸들러 등록

            for (int i = 0; i < 30; i++)
                notifier.DoSomething(i);
        }
    }
}
