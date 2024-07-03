using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
    internal class E2798 // 브루트포스 - 블랙잭
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int max = num[1];
            int iter = num[0];
            int result = 0;
            int length = numbers.Length;


            for (int i = 0; i < length - 2; i++)
            {
                for(int j = i+1; j < length - 1; j++)
                {
                    for (int k = j+1; k < length; k++)
                    {
                        int tmp = numbers[i] + numbers[k] + numbers[j];
                        if(tmp <= max && tmp > result) result = tmp;
                    }
                }
            }

            Console.WriteLine(result);
        }

    }*/
}
