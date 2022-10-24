using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_Operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            float c = 123.45f, d = 3.1456f;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);

            Console.WriteLine("\n정수의 계산");
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine("c + d = {0}", c + d);
            Console.WriteLine("c - d = {0}", c - d);
            Console.WriteLine("c * d = {0}", c * d);
            Console.WriteLine("c / d = {0}", c / d);
            Console.WriteLine("c % d = {0}", c % d);
        }
    }
}
