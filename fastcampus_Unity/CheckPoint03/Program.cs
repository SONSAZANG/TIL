using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// CheckPoint03 - 배열을 활용하기
/// </summary>
namespace CheckPoint03
{
    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }

        static void UpdateGO(int[] _arrIndexX, int [,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexMapX = i + 1;
                int indexY = _arrIndexX[i];
                int temp = _map[indexMapX, indexY]; // temp = 3;
                _map[indexMapX, indexY + 1] = temp;
                _map[indexMapX, indexY] = 0;

                _arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGo(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }

            int rndIndex = _rnd.Next(0, 5); // 0 ~ 4
            int indexY = _arrIndexX[rndIndex]++;

            int temp = _map[rndIndex + 1, indexY]; // temp = 3;
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            return isFinish;
        }
        static void Main(string[] args)
        {

            Random rnd = new Random();

            //              0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                // 0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21
                  {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // 0
                  {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, // 1
                  {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, // 2
                  {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, // 3
                  {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, // 4
                  {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, // 5
                  {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} // 6 
            };

            int[] arrIndexX = {0, 0, 0, 0, 0};
            bool isFinish = false;

            while(true)
            {
                UpdateGO(arrIndexX, map);

                isFinish = UpdateRandomGo(arrIndexX, map, rnd);

                UpdateView(tile, map);
                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과: => 1등: {0}", (i + 1));
                            break;
                        }
                    }

                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputStr = Console.ReadLine();

                    if(inputStr == "0")
                    {
                        for (int i = 0; i < arrIndexX.Length; i++)
                        {
                            map[i + 1, arrIndexX[i]] = 0;
                            arrIndexX[i] = 0;
                            map[i + 1, 20] = 2;
                            map[i + 1, 0] = i + 3;
                        }

                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }

                ClearView();
            }



        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
    }
}

