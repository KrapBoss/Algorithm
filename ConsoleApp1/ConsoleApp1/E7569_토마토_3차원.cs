//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class E7569_토마토_3차원
//    { // 토마토
//        static void Main(string[] args)
//        {
//            string input() => Console.ReadLine();

//            int[] MNH = input().Split().Select(int.Parse).ToArray();

//            int m = MNH[0];

//            List<int> list = new List<int>();

//            //토마토의 값을 받아옵니다.
//            for (int i = 0; i < MNH[1] * MNH[2]; i++)
//            {
//                list.AddRange(input().Split().Select(int.Parse));
//            }

//            //익은 토마토의 인덱스 저장
//            Queue<int> sel = new Queue<int>(); 
//            if (list.Contains(0))
//            {
//                for (int i = 0; i < list.Count; i++)
//                {
//                    if (list[i] == 1) sel.Enqueue(i);
//                }
//            }
                
//            int days = 0;
//            int floor = MNH[0] * MNH[1];

//            while (sel.Count > 0)
//            {
//                //완성이 된 다음 한번 더 수행이 될 수 있다.
//                if(!list.Contains(0)) { break; }

//                //저장된 익은 토마토 위치 값만큼 반복한다.
//                int count = sel.Count;
//                for (int iter = 0; iter < count; iter++)
//                {
//                    int id = sel.Dequeue();

//                    //각 상하 좌우 위 아래 인덱스 값을 계산한다. -1은 예외 값이다.
//                    int left = (id % m) == 0 ? -1 : (id -1);
//                    int right = (((id + 1) % (m)) == 0) ? -1 : (id + 1);

//                    int up = id % floor - m < 0 ? -1 : id - m;
//                    int down = (id + m) % floor < m ? -1 : id + m;


//                    int under = (id - floor) < 0 ? -1 : id - floor;
//                    int over = (id + floor) > (list.Count - 1) ? -1 : (id + floor);

//                    //지정된 인덱스 값을 기준으로 익은 토마토의 주변으로 전파
//                    int[] arr = new int[6] { left, right, up, down, under, over };
//                    for (int j = 0; j < arr.Length; j++)
//                    {
//                        if (arr[j] != -1)
//                        {
//                            //이미 익은 경우 또는 없는 경우는 제외한다.
//                            if (list[arr[j]] == 1 || list[arr[j]] == -1) continue;

//                            list[arr[j]] = 1;
//                            sel.Enqueue(arr[j]);
//                        }
//                    }
//                }
//                days++;
//            }

//            if (list.Contains(0)) Console.WriteLine(-1);
//            else Console.WriteLine(days);



//            //bool error = false, end = false;
//            //while (!end && !error)
//            //{
//            //    int[] check = list.ToArray();

//            //    if (!list.Contains(0))
//            //    {
//            //        if (list.Contains(1))
//            //        {
//            //            end = true;
//            //            continue;
//            //        }
//            //    }
//            //    else days++;

//            //    for (int i = 0; i < list.Count; i++)
//            //    {
//            //        if (check[i] == -1) continue;

//            //        int left = (i % MNH[0]) == 0 ? -1 : check[(i - 1)];
//            //        int right = (((i + 1) % (MNH[0])) == 0) ? -1 : check[(i + 1)];


//            //        int up = i % floor - MNH[0] < 0 ? -1 : check[i - MNH[0]];
//            //        int down = (i + MNH[0]) % floor < MNH[0] ? -1 : check[(i + MNH[0])];


//            //        int under = (i - floor) < 0 ? -1 : check[(i - floor)];
//            //        int over = (i + floor) > (check.Length - 1) ? -1 : check[(i + floor)];

//            //        if ((left + right + up + down + over + under) == -6)
//            //        {
//            //            error = true;
//            //            break;
//            //        }

//            //        if (left == 1 || right == 1 || up == 1 || down == 1 || over == 1 || under == 1)
//            //        {
//            //            list[i] = 1;
//            //        }
//            //    }
//            //}
//            //if (error) Console.WriteLine(-1);
//            //else Console.WriteLine(days);
//        }
//    }
//}


////for (int i = 1; i <= list.Count; i++)
////{
////    Console.Write($"{list[i - 1]} ");
////    if (i % MNH[0] == 0) Console.WriteLine();
////}
////Console.WriteLine();