using System;
using System.Linq;

namespace ConsoleApp1
{
    /*
    internal class E10250 // ACM 호텔
    {
        static void Main(string[] args)
        {
            int TestData = int.Parse(Console.ReadLine());

            for (int i = 0; i < TestData; i++)
            {
                int[] data = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
                int roomX = ((data[2] + data[0]) % data[0]) == 0 ? data[0] : ((data[2] + data[0]) % data[0]);
                int roomY = (int)Math.Ceiling(data[2]  / (float)data[0]);
                Console.WriteLine("{0:#}{1:0#}",roomX,roomY);
            }
        }
    }*/
}
