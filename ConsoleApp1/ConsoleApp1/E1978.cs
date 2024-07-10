using System;
using System.Linq;

namespace ConsoleApp1
{
    /*
    internal class E1978 // 소수 찾기
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum =0; 

            foreach (int i in b)
            {
                bool flag = i == 1 ? true: false;
                for(int j = 2; j< i; j++)
                {
                    if(i%j ==0) { flag = true; break; }
                }
                if (!flag) sum++;
            }

            Console.WriteLine(sum);
        }
        
    }*/
}
