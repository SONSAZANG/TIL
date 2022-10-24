using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            int count = 1;

            while (true)
            {
                Console.Write("0~99 사이 어떤 숫자일까요(단, 0은 나가기)");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("== 종료 ==");
                    break;
                }
                else if (a < num)
                {
                    Console.WriteLine("입력한 수는 작아요");
                    count++;
                }
                else if (a > num)
                {
                    Console.WriteLine("입력한 수는 커요");
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("=== 정답 입니다 ===");
            Console.WriteLine("총 {0}번 시도", count);
        }
    }
}
