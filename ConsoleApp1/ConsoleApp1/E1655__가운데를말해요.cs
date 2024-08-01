//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class E1655__가운데를말해요
//    {
//        static void Main(string[] args)
//        {
//            int N(StreamReader r) => int.Parse(r.ReadLine());
            
//            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//            {
//                int iter = N(reader);
//                List<int> list = new List<int>();
//                StringBuilder sb = new StringBuilder();
//                for (int i = 0; i < iter; i++)
//                {
//                    int n = N(reader);

//                    int left = 0;
//                    int right = list.Count;

//                    while(left < right)
//                    {
//                        int mid = (left + right) / 2;

//                        if (n>list[mid])
//                        {
//                            left =mid+1;
//                        }
//                        else
//                        {
//                            right = mid;
//                        }
//                    }

//                    list.Insert(left, n);

//                    sb.Append(list[(list.Count - 1) / 2]);
//                    sb.AppendLine();
//                }

//                using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
//                    sw.WriteLine(sb);
//            }
//        }
//    }
//}