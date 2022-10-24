using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: " + num++);
            Console.WriteLine("num: " + num);
            Console.WriteLine("num: " + ++num);

            Console.WriteLine("\nnum: " + num--);
            Console.WriteLine("num: " + num);
            Console.WriteLine("num: " + --num);
        }
    }
}
