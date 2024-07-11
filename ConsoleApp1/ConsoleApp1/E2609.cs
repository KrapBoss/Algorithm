using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class E1259 //최대 공약수와 최소 공배수
    {
        static void Main(string[] args)
        {
            int GCD(int a, int b)
            {
                if (b == 0) return a;
                else return GCD(b, a % b);
            }

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input[0] < input[1]) input.Reverse();
            int g = GCD(input[0], input[1]);
            int l = input[0]* input[1] / g;

            Console.WriteLine($"{g} {l}");

            int G(int a, int b) => b == 0 ? a : G(b, a % b);
        }
    }
}
