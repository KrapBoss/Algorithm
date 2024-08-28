//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;
//using System.Linq;

//namespace consoleapp1
//{
//    internal class 좌표정렬하기11650
//    {
//        static void Main(string[] args)
//        {
//            string[] input(StreamReader s) => s.ReadLine().Split();

//            List<(int x, int y)> list = new List<(int x, int y)>();
//            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//            {

//                int iter = int.Parse(input(sr)[0]);

//                while (iter > 0)
//                {
//                    iter--;
//                    int[] arr = Array.ConvertAll(input(sr),int.Parse);
//                    list.Add((arr[0], arr[1]));
//                }

//                list = list.OrderBy(x => x.x).ThenBy(x => x.y).ToList();
//            }

//            StringBuilder sb = new StringBuilder();

//            foreach(var a in list)
//            {
//                sb.AppendLine($"{a.x} {a.y}");
//            }
//            Console.WriteLine(sb);
//        }
//    }
//}
