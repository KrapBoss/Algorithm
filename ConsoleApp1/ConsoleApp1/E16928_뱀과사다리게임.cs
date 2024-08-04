//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp1
//{
//    internal class E16928_뱀과사다리게임
//    {
        
//        static void Main(string[] args)
//        {
//            int[] input() => Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

//            //맵의 사다리와 뱀의 값을 저장하기 위함
//            int[] location = new int[101];
            
//            //입력값을 받아옵니다.
//            int[] iter = input();
//            for(int i=0;i<iter[0] + iter[1]; i++)
//            {
//                int[] _tmp = input();
//                location[_tmp[0]] = _tmp[1];
//            }

//            //현재 탐색된 주사위 값의 저장값
//            int[] save = new int[101];

//            //<현재 위치, 주사위 횟수> 를 저장함으로서, 현재의 위치값에 따른 주사위 횟수를 저장한다.
//            Queue<Tuple<int,int>> spot = new Queue<Tuple<int, int>>();
//            spot.Enqueue(new Tuple<int, int> (1,-1));
//            while (spot.Count > 0)
//            {
//                var s = spot.Dequeue();

//                //현재 주사위 값이 저장된 배열과의 비교와 0이 아닌 값을 판단한다.
//                if (save[s.Item1] <= s.Item2 && (save[s.Item1] != 0)) continue;

//                //현재 위치에 주사위 값을 지정한다.
//                save[s.Item1] = s.Item2 +1;

//                //맵에서 현재의 사다리 또는 뱀일 경우 자리를 이동시킵니다.
//                int floor = s.Item1;
//                if (location[s.Item1] != 0) floor = location[s.Item1];

//                //주사위 6눈의 값만큼 이동시킵니다.
//                for (int i = 0; i < 6; i++)
//                {
//                    int next = floor + 1 + i;
//                    if (next > 100) break;

//                    spot.Enqueue(new Tuple<int, int>(next , save[s.Item1]));
//                }
//            }

//            //마지막 위치에 도달한 값을 출력한다
//            Console.WriteLine(save[100]);
//        }
//    }
//}