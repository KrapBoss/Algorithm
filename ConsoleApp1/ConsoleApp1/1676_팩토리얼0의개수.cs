using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApp1
{
    
    internal class _1676_팩토리얼0의개수
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine()), cnt = 0;

            for (int i = 5; i <= n; i *= 5) cnt += n / i;

            Write(cnt);
        }
    }
}