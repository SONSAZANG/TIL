using System;

namespace _063_Func_out
{
    class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b;

            InitNum(out a);
            Console.WriteLine("a : " + a);

            b = 0;
            InitRefNum(ref b); // ref는 초기화 하지 않고 사용 불가!
            Console.WriteLine("b : " + b);
        }
    }
}
