//using System;

//namespace ConsoleApp1
//{
//    internal class 평범한배낭12865
//    {
//        static void Main(string[] args)
//        {
//            string[] str = Console.ReadLine().Split();
//            int n = int.Parse(str[0]);//최대 개수
//            int w = int.Parse(str[1]);//최대 무게

//            // 무게와 개수만큼의 수를 가진다.
//            int[,] info = new int[n + 1, w + 1];

//            //각 순번의 무게와 가치를 더한다.
//            int[] weight = new int[n];
//            int[] value = new int[n];

//            //값들을 받아온다.
//            for (int i = 0; i < n; i++)
//            {
//                str = Console.ReadLine().Split();
//                weight[i] = int.Parse(str[0]);
//                value[i] = int.Parse(str[1]);
//            }

//            for (int i = 1; i < n + 1; i++)
//            {
//                for (int j = 0; j < w + 1; j++)
//                {

//                    //현재 무게를 판단하여 무게를 저장한다.
//                    if (weight[i - 1] <= j)
//                    {
//                        //최대로 큰 가치를 대입한다.
//                        info[i, j] = Math.Max(info[i - 1, j], value[i - 1] + info[i - 1, j - weight[i - 1]]);
//                    }
//                    else
//                    {
//                        //무게가 초과된다면 이전에 큰 가치를 가져온다.
//                        info[i, j] = info[i - 1, j];
//                    }
//                }
//            }

//            Console.WriteLine(info[n, w]);
//        }
//    }
//}
