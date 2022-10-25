using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        // 생성자는 클래스 이름과 동일하다.
        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }

        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;

            Console.WriteLine(" Call Constructor "); 
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }

        // 소멸자는 매개변수 선언이 불가능하다.
        ~AA()
        {
            Console.WriteLine(" Call Destructor ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA ab = new AA(15, 15.4f);
        }
    }
}