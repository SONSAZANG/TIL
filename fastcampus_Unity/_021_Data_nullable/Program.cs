using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Data_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);

            Console.WriteLine("isFlag: {0}", isFlag);
            Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);

            if (isFlag.HasValue) // 값을 참조하려면 반드시 null인지 체크..
            {
                Console.WriteLine("isFlag HasValue: {0}", isFlag.Value);
            }
        }
    }
}
