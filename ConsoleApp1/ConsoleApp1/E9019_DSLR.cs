//using System.Collections.Generic;
//using System;
//using System.Linq;
//using System.IO;
//using System.Text;

//namespace ConsoleApp1
//{
//    struct info{
//        public int num;
//        public string mandate;
//    }
//    internal class TEST
//    {
//        static void Main(string[] args)
//        {
//            StringBuilder sb = new StringBuilder();
//            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//            {
//                int iter = int.Parse(sr.ReadLine());
//                for (int i = 0; i < iter; i++)
//                {
//                    int[] v = sr.ReadLine().Split().Select(int.Parse).ToArray();

//                    Queue<info> q = new Queue<info>();
//                    q.Enqueue(new info { num = v[0], mandate = "" });
//                    bool[] register = new bool[10000];

//                    while (true)
//                    {
//                        var a = q.Dequeue();
//                        if (a.num == v[1])
//                        {
//                            sb.AppendLine(a.mandate);
//                            break;
//                        }

//                        //D
//                        int D = a.num * 2 % 10000;
//                        if (!register[D])
//                        {
//                            register[D] = true;
//                            q.Enqueue(new info { num = D, mandate = $"{a.mandate}D" });
//                        }
//                        //S
//                        int S = (a.num - 1 + 10000) % 10000;
//                        if (!register[S])
//                        {
//                            register[S] = true;
//                            q.Enqueue(new info { num = S, mandate = $"{a.mandate}S" });
//                        }
//                        //L
//                        int L = a.num % 1000 * 10 + a.num / 1000;
//                        if (!register[L])
//                        {
//                            register[L] = true;
//                            q.Enqueue(new info { num = L, mandate = $"{a.mandate}L" });
//                        }
//                        //R
//                        int R = a.num / 10 + a.num % 10 * 1000;
//                        if (!register[R])
//                        {
//                            register[R] = true;
//                            q.Enqueue(new info { num = R, mandate = $"{a.mandate}R" });
//                        }
//                    }
//                }
//            }
//            Console.WriteLine(sb);
//        }
//    }
//}