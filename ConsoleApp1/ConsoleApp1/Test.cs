//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;
//using System.Linq;

//namespace ConsoleApp1
//{
//    internal class TEST
//    {
//        static void Main(string[] args)
//        {
//            string[] input(StreamReader s) => s.ReadLine().Split();

//            using (StreamReader st = new StreamReader(Console.OpenStandardInput()))
//            {
//                StringBuilder sb = new StringBuilder();

//                int a = int.Parse(input(st)[0]);

//                // 테스트 케이스
//                for (int i = 0; i < a; i++)
//                {
//                    SortedDictionary<int, int> SL = new SortedDictionary<int, int>(); // 각 테스트 케이스마다 초기화

//                    // 명령 입력 횟수만큼 반복
//                    int b = int.Parse(input(st)[0]);
//                    for (int j = 0; j < b; j++)
//                    {
//                        string[] inp = input(st);
//                        int number = int.Parse(inp[1]);
//                        if (inp[0].Equals("I"))
//                        {
//                            if (SL.ContainsKey(number)) SL[number]++;
//                            else SL.Add(number, 1);
//                        }
//                        else
//                        {
//                            if (SL.Count == 0) continue;

//                            int key = number < 0 ? SL.First().Key : SL.Last().Key;

//                            if (--SL[key] == 0) SL.Remove(key);
//                        }
//                    }
//                    if (SL.Count > 0)
//                    {
//                        sb.AppendLine($"{SL.Last().Key} {SL.First().Key}");
//                    }
//                    else
//                    {
//                        sb.AppendLine("EMPTY");
//                    }
//                }
//                Console.WriteLine(sb);
//            }
//        }
//    }
//}