using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    internal class Program
    {


        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요? ");
            ID[index] = int.Parse(Console.ReadLine());
        }

        static void InputKor(int[] Kor, int index)
        {
            Console.Write("국어 점수를 입력하세요? ");
            Kor[index] = int.Parse(Console.ReadLine());
        }

        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요? ");
            math[index] = int.Parse(Console.ReadLine());
        }

        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요? ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)
        {

        }

        static int CheckID(int id, int max, int[] ID)
        {
            return 3;
        }

        static void Main(string[] args)
        {
            int max = 3;

            int[] ID = new int[max];
            int[] Kor = new int[max];
            int[] math = new int[max];
            int[] eng = new int[max];

            for (int i = 0; i < max; i++)
            {
                InputID(ID, i);
                InputKor(Kor, i);
                InputMath(math, i);
                InputEng(eng, i);
            }

            Console.Clear();

            while (true)
            {
                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine("학생 ID: " + ID[i]);
                }
                Console.Write("학생 아이디를 입력하세요? (0)나가기");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                for (int i = 0; i < max; i++)
                {
                    if (ID[i] == a)
                    {
                        Console.WriteLine("국어 점수: " + Kor[i]);
                        Console.WriteLine("수학 점수: " + math[i]);
                        Console.WriteLine("영어 점수: " + eng[i]);
                        Console.WriteLine("총점: " + (Kor[i] + math[i] + eng[i]));
                        Console.WriteLine("평균: " + (Kor[i] + math[i] + eng[i]) / 3);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                        continue;
                    }
                }

            }
        }
    }
}
}
