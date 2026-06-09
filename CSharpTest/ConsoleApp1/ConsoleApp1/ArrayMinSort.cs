using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace goorm
{
    class ProArrayMinSortgram
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            int count = int.Parse(input);
            input = Console.ReadLine();
            int[] split = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] sortedArr = split.ToArray();


            Console.ReadLine();

            Array.Sort(sortedArr);

            bool[] visit = Enumerable.Repeat(false, count).ToArray();

            for (int i = 0; i < count; i++)
            {
                if (sortedArr[i] != split[i])
                {
                    visit[i] = true;
                }
            }

            int flag = 0;

            int start = 0, end = 0;
            int visitCount = visit.Count(x => x);

            bool exit = false;
            for (int i = 0; i < count; i++)
            {
                if (exit) break;
                switch (flag)
                {
                    case 0:

                        if (visit[i])
                        {
                            start = i;

                            flag = visitCount == 2 ? 1 : 2;
                        }

                        break;

                    case 1:// swap
                    case 2:// reverse
                        if (visit[i])
                        {
                            end = i;
                        }
                        break;
                }
            }

            // Console.WriteLine(start + " " + end);

            switch (flag)
            {
                case 1:// swap

                    int temp = split[start];
                    split[start] = split[end];
                    split[end] = temp;

                    break;
                case 2: // reverse

                    Array.Reverse(split, start, end - start + 1);

                    break;
            }

            bool collect = true;
            for (int i = 0; i < count; i++)
            {
                if (sortedArr[i] != split[i])
                {
                    collect = false;
                    break;
                }
            }

            if (!collect) Console.WriteLine("no");
            else
            {
                switch (flag)
                {

                    case 0:// nomal
                        Console.WriteLine("yes");
                        break;
                    case 1:// swap
                        Console.WriteLine("yes");
                        Console.WriteLine($"swap {start + 1} {end + 1}");
                        break;
                    case 2: // reverse
                        Console.WriteLine("yes");
                        Console.WriteLine($"reverse {start + 1} {end + 1}");
                        break;
                }
            }

            // for(int i =0 ; i< count ; i ++)

            // 	{
            // 		Console.WriteLine(split[i] + " " + visit[i]);
            // 	}
        }
    }
}