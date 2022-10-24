using System;

namespace _067_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total = 0;
            float average;

            Start();
            Input(ref kor, ref eng, ref mat);
            total = TotalSum(kor, mat, eng);
            Average(total, out average);

            Console.WriteLine("Total: {0} Average: {1}", total, average);
        }

        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        static void Input(ref int kor, ref int eng, ref int mat)
        {
            Console.Write("국어 성적 입력(정수)? ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("수학 성적 입력(정수)? ");
            mat = int.Parse(Console.ReadLine());
            Console.Write("영어 성적 입력(정수)? ");
            eng = int.Parse(Console.ReadLine());

            Console.WriteLine("kor: {0} mat: {1} eng: {2}", kor, mat, eng);
        }

        static int TotalSum(int kor, int mat, int eng)
        {
            return kor + mat + eng;
        }

        static void Average(int total, out float average)
        {
            average = total / 3;
        }
    }
}
