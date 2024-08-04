using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class E16928_뱀과사다리게임
    {
        
        static void Main(string[] args)
        {
            int[] input() => Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

            int[] location = new int[101];

            int[] iter = input();
            for(int i=0;i<iter[0] + iter[1]; i++)
            {
                int[] _tmp = input();
                location[_tmp[0]] = _tmp[1];
            }

            int[] save = new int[101];

            Queue<Tuple<int,int>> spot = new Queue<Tuple<int, int>>();
            spot.Enqueue(new Tuple<int, int> (1,-1));
            while (spot.Count > 0)
            {
                var s = spot.Dequeue();

                if (save[s.Item1] <= s.Item2 && (save[s.Item1] != 0)) continue;

                save[s.Item1] = s.Item2 +1;

                int floor = s.Item1;
                if (location[s.Item1] != 0) floor = location[s.Item1];

                for (int i = 0; i < 6; i++)
                {
                    int next = floor + 1 + i;
                    if (next > 100) break;

                    spot.Enqueue(new Tuple<int, int>(next , save[s.Item1]));
                }
            }

            Console.WriteLine(save[100]);
        }
    }
}