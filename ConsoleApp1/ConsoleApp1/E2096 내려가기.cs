//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;
//using System.Linq;

//namespace consoleapp1
//{
//    internal class E1916_내려가기
//    {
//        static void Main(string[] args)
//        {
//            string[] input(StreamReader s) => s.ReadLine().Split();

//            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//            {
//                int iter = int.Parse(input(sr)[0]);

//                //저장
//                int[] Max = new int[3];
//                int[] Min = new int[3];

//                Max  = Array.ConvertAll(input(sr), int.Parse);
//                Min = Max;

//                for (int i = 1; i < iter; i++)
//                {
//                    int[] arr = Array.ConvertAll(input(sr), int.Parse);

//                    int[] MAXA = new int[2] { Max[0], Max[1] };
//                    int[] MAXC = new int[2] { Max[1], Max[2] };

//                    Max = new int[] { arr[0] + MAXA.Max(), arr[1]+ Max.Max(), arr[2]+ MAXC.Max()};


//                    int[] MINA = new int[2] { Min[0], Min[1] };
//                    int[] MINC = new int[2] { Min[1], Min[2] };

//                    Min = new int[] { arr[0] + MINA.Min(), arr[1]+Min.Min(), arr[2]+ MINC.Min()};
//                }

//                Console.WriteLine($"{Max.Max()} {Min.Min()}");
//            }
//        }
//    }
//}
