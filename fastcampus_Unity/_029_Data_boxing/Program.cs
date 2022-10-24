using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Data_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing과 unboxing 은 최적화에 안좋음 무거움.

            int i = 123;
            object o = i;  // boxing
            int j = (int)o; // unboxing
            i = 456;

            Console.WriteLine("i: {0}, o: {1}, j: {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));

        }
    }
}
