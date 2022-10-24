using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            //int max_num = 0;
            //int min_num = 0;
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                int a = int.Parse(Console.ReadLine());
                if (maxNum < a)
                {
                    maxNum = a;
                }
                if (minNum > a)
                {
                    minNum = a;
                }
            }
            Console.WriteLine("최댓값: {0} 최소값: {1}", maxNum, minNum);
        }
    }
}
