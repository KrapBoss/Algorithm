using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class E2231 // 브루트포스 - 분해합
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < number; i++)
            {
                int tmp = i + SumDigits(i);
                if (tmp == number)
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine(result);
        }

        static int SumDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;  // 현재 숫자의 일의 자리를 더함
                n /= 10;        // 한 자리씩 줄임
            }
            return sum;
        }
    }
}
