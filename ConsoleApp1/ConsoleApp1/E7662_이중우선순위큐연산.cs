//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;

//namespace consoleapp1
//{
//    internal class E7662_이중우선순위큐연산
//    {
//        static void Main(string[] args)
//        {
//            string[] input(StreamReader s) => s.ReadLine().Split();

//            using (StreamReader st = new StreamReader(Console.OpenStandardInput()))
//            {
//                StringBuilder sb = new StringBuilder();

//                int a = int.Parse(input(st)[0]);

//                SortedList<int, int> SL = new SortedList<int, int>();

//                //테스트 케이스
//                for (int i = 0; i < a; i++)
//                {
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
//                            if (SL.Count < 1) continue;

//                            int key = (number < 0) ? SL.Keys[0] : SL.Keys[SL.Count - 1];

//                            --SL[key];
//                            if (SL[key] < 1) SL.Remove(key);
//                        }
//                    }

//                    //최솟값과 최댓값을 출력합니다.
//                    if (SL.Count < 1)
//                    {
//                        sb.AppendLine("Empty");
//                    }
//                    else
//                    {
//                        sb.AppendLine($"{SL.Keys[SL.Count - 1]} {SL.Keys[0]}");
//                    }
//                }

//                Console.WriteLine(sb);
//            }
//        }
//    }
//}
