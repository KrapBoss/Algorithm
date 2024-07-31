using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class E7576_토마토_2차원
    { // 토마토
        static void Main(string[] args)
        {
            string input() => Console.ReadLine();

            int[] MN = input().Split().Select(int.Parse).ToArray();

            int m = MN[0];

            List<int> list = new List<int>();

            //토마토 박스 값 추가
            for (int i = 0; i < MN[1]; i++)
            {
                list.AddRange(input().Split().Select(int.Parse));
            }

            //익은 토마토의 인덱트 저장
            Queue<int> sel = new Queue<int>(); 
            if (list.Contains(0))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 1) sel.Enqueue(i);
                }
            }
                
            int days = 0;

            while (sel.Count > 0)
            {
                if(!list.Contains(0)) { break; }

                int count = sel.Count;
                for (int iter = 0; iter < count; iter++)
                {
                    int id = sel.Dequeue();

                    //각 4방면의 인덱스를 구합니다.
                    int left = (id % m) == 0 ? -1 : (id -1);
                    int right = (((id + 1) % (m)) == 0) ? -1 : (id + 1);

                    int up = id - m < 0 ? -1 : id - m;
                    int down = (id + m) >= list.Count ? -1 : id + m;

                    //각 4방면 인덱스에 익은 토마토를 전파합니다.
                    int[] arr = new int[4] { left, right, up, down };
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] != -1)
                        {
                            if (list[arr[j]] == 1 || list[arr[j]] == -1) continue;

                            list[arr[j]] = 1;
                            sel.Enqueue(arr[j]);
                        }
                    }
                }
                days++;
            }

            if (list.Contains(0)) Console.WriteLine(-1);
            else Console.WriteLine(days);
        }
    }
}