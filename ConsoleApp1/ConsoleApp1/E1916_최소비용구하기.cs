//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;

//namespace consoleapp1
//{
//    internal class E1916_최소비용구하기
//    {
//        const int INF = 0x3f3f3f3f;
//        static void Main(string[] args)
//        {
//            string[] input(StreamReader s) => s.ReadLine().Split();

//            using(StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//            {
//                int city = int.Parse(input(sr)[0]);
//                int bus = int.Parse(input(sr)[0]);

//                int[,] cost = new int[city, city];

//                bool[] visit = new bool[city];
//                int[] minCost = new int[city];

//                //배열 초기화
//                for(int i = 0; i < city; i++)
//                {
//                    for(int j = 0; j < city; j++)
//                    {
//                        if (i != j) cost[i, j] = INF;
//                    }
//                }

//                //비용 받기
//                for (int i = 0;i< bus; i++)
//                {
//                    int[] temp = Array.ConvertAll(input(sr), int.Parse);
//                    if (temp[0] == temp[1]) continue;
//                    if(cost[temp[0] - 1, temp[1] - 1] > temp[2])
//                        cost[temp[0] - 1, temp[1] - 1] = temp[2];
//                }

//                //현재 위치에서 목표점 지정
//                int[] goal = Array.ConvertAll(input(sr), int.Parse);
//                goal[0] -= 1; goal[1] -= 1;
//                for(int i= 0;i< city; i++) { minCost[i] = cost[goal[0],i]; }
//                visit[goal[0]] = true;

//                //작은 가중치 탐색
//                for(int i = 0; i< city; i++)
//                {
//                    //최솟값 찾기
//                    int minIndex = GetMinIndex(visit, minCost);

//                    //탐색 가능한 경우가 없는 경우 제거
//                    if (minIndex < 0) break;
//                    visit[minIndex] = true;
//                    for(int j = 0 ; j < city; j++)
//                    {
//                        if ((minCost[j] > minCost[minIndex] + cost[minIndex, j]) && !visit[j])
//                        {
//                            minCost[j] = minCost[minIndex] + cost[minIndex, j];
//                        }
//                    }
//                }

//                Console.WriteLine(minCost[goal[1]]);
//            }
//        }

//        //현재 미방문 노드중 가장 작은 노드를 불러옵니다.
//        static int GetMinIndex(bool[] visit, int[] minCost)
//        {
//            int index = -1;
//            int min = INF;
//            for(int i =0; i<visit.Length; i++)
//            {
//                if (!visit[i] && (minCost[i] < min))
//                {
//                    min = minCost[i];
//                    index = i;
//                }
//            }
//            return index;
//        }
//    }
//}
