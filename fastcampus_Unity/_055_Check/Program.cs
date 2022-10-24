using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int quizNum = 5;
            Random rnd = new Random();
            int count = 0;

            for (int i = 1; i <= quizNum; i++)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 {1}문제)", i, quizNum);
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int c = int.Parse(Console.ReadLine());
                if (c == (a + b))
                {
                    Console.WriteLine("== 정답 ==");
                    count++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", a + b);
                }
            }
            Console.WriteLine("=====================");
            Console.WriteLine("총 맞춘 문제 수는: {0}개", count);
        }
    }
}
