using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace ConsoleApp1
{
    /*
    internal class _10989 // 수 정렬하기 3
    {
        static void Main(string[] args)
        {
            //3. 1만개의 숫자를 세아리기
            int iter = int.Parse(ReadLine());
            int[] nums = new int[10000];
            for(int i = 0; i < iter; i++)
            {
                nums[int.Parse(ReadLine())-1]++;
            }

            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums[i]; j++)
                    {
                        writer.WriteLine(i + 1);
                    }
                }
            }

            /* 1. 자체 솔트 정렬
            int iter = int.Parse(ReadLine());
            List<int> list = new List<int>();

            for(int i = 0; i < iter; i++)
            {
                list.Add(int.Parse(ReadLine()));
            }

            list.Sort();

            foreach(int i in list)
            {
                WriteLine(i);
            }
            */

            /* 2. 분할 정렬 알고리즘
            for (int i = 0; i< iter; i++)
            {
                int num = int.Parse(ReadLine());

                int left = 0;
                int right = list.Count;

                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid] < num)
                        left = mid + 1;
                    else
                        right = mid;
                }

                list.Insert(left,num);
            }

            foreach (var item in list)
            {
                WriteLine(item);
            }
            
        }
    }
    */
}