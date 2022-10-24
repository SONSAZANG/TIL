using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Data_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = num;
            Console.WriteLine("num: {0}, dNum: {1}", num, dNum);

            
            // 큰데이터형을 작은 데이터형으로 변경시 주의!! 오류 가능
            double dNum2 = 12345678123;
            int num2 = (int)dNum2;
            Console.WriteLine("dNum2: {0}, num2: {1}", dNum2, num2);
        }
    }
}
