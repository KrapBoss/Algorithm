//using System;
//using System.Linq;

//namespace ConsoleApp1
//{
//    internal class E10026_적록색약
//    {
//        static void Main(string[] args)
//        {
//            //4방향 정의
//            int[] dx = new int[] { -1, 1, 0, 0 };
//            int[] dy = new int[] { 0, 0, -1, 1 };

//            //같은 색상 탐색을 위한 재귀함수
//            void BPS(char[][] a, bool[,] c, int x, int y)
//            {
//                if (c[x, y]) return;

//                c[x, y] = true;

//                int len = a[0].Length;
//                for(int i = 0; i < 4; i++)
//                {
//                    int X = x + dx[i];
//                    int Y = y + dy[i];

//                    if (X < 0 || Y < 0 || X >= len || Y >= len) continue;

//                    if (a[x][y] == a[X][Y])
//                    {
//                        BPS(a, c, X, Y);
//                    }
//                }
//            }

//            string input() =>Console.ReadLine();

//            int n = int.Parse(input());

//            char[][] arr = new char[n][];
//            bool[,] check = new bool[n,n];

//            //D => 적록 | S => 정상 시야
//            int D = 0, S = 0;

//            for(int i =0;i < n; i++)
//            {
//                arr[i] = input().Select(x=> x).ToArray();
//            }

//            for(int i = 0;i < n;i++)
//            {
//                for(int j = 0;j < n; j++)
//                {
//                    if (!check[i, j])
//                    {
//                        S++;
//                        BPS(arr,check,i,j);
//                    }
//                }
//            }

//            //G 를 R 로 변환 후 재탐색
//            check = new bool[n, n];
//            arr = arr.Select(x=> x.Select(y => y.Equals('G') ? 'R' : y).ToArray()).ToArray();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    if (!check[i, j])
//                    {
//                        D++;
//                        BPS(arr, check, i, j);
//                    }
//                }
//            }

//            Console.WriteLine($"{S} {D}");
//        }
//    }
//}