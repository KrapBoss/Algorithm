using System;
using System.Linq;

namespace ConsoleApp1
{
    /*
    internal class E2577_ADD // 숫자의 개수
    {
        static void Main(string[] args)
        {
            int multiple =1;
            for (int i = 0; i < 3; i++) multiple *= int.Parse(Console.ReadLine());
            var count = multiple.ToString().GroupBy(x => x).ToDictionary(x =>x.Key ,x=> x.Count());
            var allDigits = Enumerable.Range(0, 10).Select(d => d.ToString()[0]);
            var result = allDigits
                .Select(d => new { Digit = d, Count = count.ContainsKey(d) ? count[d] : 0 })
                .OrderBy(x => x.Digit);

            foreach (var item in result) { Console.WriteLine(item.Count); }

            /* 아주 기발한 방법
            int a() => int.Parse(Console.ReadLine()); 
            var b = $"{a() * a() * a()}"; 
            var c = new int[10]; 
            int d = b.Length;
            while (d-- > 0) c[b[d] - 48]++; 
            Console.Write(string.Join("\n", c));
            
        }
    }
*/
}
