using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 형식 매개변수 제약시키기 */
/* 교재 384p 예제 */
namespace GenericConstraint1
{
    #region 값 형식, 참조 형식 제한
    class StructArray<T> where T : struct  // T는 값형식만 올 수 있다.
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class  // T는 참조형식만 올 수 있다.
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    #endregion

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base  // U에는 Base의 파생 클래스만 올 수 있음.
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 값 형식, 참조 형식 제한
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(1);
            b.Array[1] = new StructArray<double>(2);
            #endregion

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();

            BaseArray<Derived> d = new BaseArray<Derived>(2);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(2);
            e.CopyArray<Derived>(d.Array);
        }

       static T CreateInstance<T>() where T : new()  // T는 기본 생성자를 가져야함.
        {
            return new T();
        }
    }
}
