using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Data_object
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object b = 3.12312412093012309120f;
            object c = 3.1230120310230123012301230d;
            object d = 'H';
            object e = 'i';
            object f = "World!";
            object g = false;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("{0}{1} {2}", d, e, f);
            Console.WriteLine("g: {0}", g);
        }
    }
}
