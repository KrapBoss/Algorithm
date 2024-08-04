using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class E7662_이중우선순위큐연산
    {
        static void Main(string[] args)
        {
            string[] input(StreamReader s)=> s.ReadLine().Split();
            
            using(StreamReader st = new StreamReader(Console.OpenStandardInput())) {
                int a = int.Parse(input(st)[0]);

                List<int> list = new List<int>();
                for (int i = 0; i < a; i++)
                {
                    int b = int.Parse(input(st)[0]);
                    for (int j = 0; j < b; j++)
                    {
                        string[] inp = input(st);
                        int number = int.Parse(inp[1]);
                        if (inp[0].Equals("I"))
                        {
                            int index = list.BinarySearch(number);
                            if (index < 0) list.Insert(~index, number);
                            else list.Insert(index, number);
                        }
                        else
                        {
                            if (list.Count == 0) continue;
                            if (number < 0) list.RemoveAt(0);
                            else list.RemoveAt(list.Count - 1);
                        }
                    }
                }
            
                using(StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                {
                    if (list.Count > 0)
                    {
                        sw.WriteLine($"{list[list.Count - 1]} {list[0]}");
                    }
                    else
                    {
                        sw.WriteLine("Empty");
                    }
                }
            }
        }
    }
}
