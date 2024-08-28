//using System;
//using System.Collections.Generic;
//using System.Configuration;

//namespace ConsoleApp1
//{
//    internal class 나이순정렬10814
//    {
//        static void Main(string[] args)
//        {
//            string input()=> Console.ReadLine();

//            int iter = int.Parse(input());

//            SortedDictionary<int, List<string>> dic = new SortedDictionary<int, List<string>>();

//            for(int i = 0; i < iter; i++)
//            {
//                string[] str = input().Split();

//                int age = int.Parse(str[0]);
//                string name = str[1];

//                if (dic.ContainsKey(age))
//                {
//                    dic[age].Add(name);
//                }
//                else
//                {
//                    dic[age] = new List<string>
//                    {
//                        name
//                    };
//                }
//            }

//            foreach(var d in dic)
//            {
//                foreach(string name in d.Value)
//                {
//                    Console.WriteLine($"{d.Key} {name}");
//                }
//            }
//        }
//    }
//}