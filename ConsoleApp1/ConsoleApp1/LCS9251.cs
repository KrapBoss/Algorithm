//using System.Collections.Generic;
//using System.IO;
//using System;
//using System.Text;
//using System.Linq;

//namespace consoleapp1
//{
//    internal class LCS9251
//    {
//        //다이나믹 프로그래밍
//        //연속성을 판단하기 위해 이전 값에 +1을 취함
//        static void Main(string[] args)
//        {
//            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
//            {
//                string str1= sr.ReadLine();
//                string str2 = sr.ReadLine();

//                int[,] array = new int[str1.Length+1, str2.Length+1];
                
//                for(int i = 1; i <= str1.Length; i++)
//                {
//                    for(int j = 1; j<= str2.Length; j++)
//                    {
//                        if (str1[i-1] == str2[j-1])
//                        {
//                            array[i, j] = array[i - 1, j - 1] + 1;
//                        }
//                        else
//                        {
//                            array[i, j] = Math.Max(array[i - 1, j], array[i, j - 1]);
//                        }
//                    }
//                }

//                //마지막 수는 제일 큰 수 밖에 될 수 없음.
//                Console.WriteLine(array[str1.Length, str2.Length]);
//            }
//        }
//    }
//}
