using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    internal class _2751_수정렬하기2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort();

            StringBuilder sb = new StringBuilder(string.Join("\n", list));
            
            Console.WriteLine(sb);

            /*안됨
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                int left = 0;
                int right = list.Count;
                
                while(left < right)
                {
                    int mid = (left + right) / 2;

                    if (list[mid] < num)
                    {
                        left = mid+1;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                list.Insert(left, num);
            }

            StringBuilder sb = new StringBuilder(); 
            
            foreach (int i in list)
            {
                sb.Append(i);
                sb.AppendLine();
            }

            Console.WriteLine(sb);
            */
        }
    }
}