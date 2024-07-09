using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class E4153 // 직각삼각형
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bundle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine($"{order.Select(x => (x + bundle[0] - 1) / bundle[0]).Sum()}\n{sum / bundle[1]}{sum % bundle[1]}");
        }
    }
}
