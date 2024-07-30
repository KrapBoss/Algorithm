//using System;
//using System.Linq;

//namespace ConsoleApp1
//{
    
//    internal class E2577_ADD // 숫자의 개수
//    {
//        static void Main(string[] args)
//        {
//            int multiple = 1456841569;
//            //for (int i = 0; i < 3; i++) multiple *= int.Parse(Console.ReadLine());

//            //각 숫자의 개수를 세아리는 구문
//            //숫자 문자열 별로 그룹화하고, 각 엘리먼트를 값으로 지정한다.
//            //각 키 값에는 엘리먼트들이 존재한다.
//            var count = multiple.ToString().GroupBy(x => x).ToDictionary(x => x.Key, (x) => x.Count());

//            //각 0~9까지의 수를 오름차순으로 정렬하는 구문
//            var allDigits = Enumerable.Range(0, 10).Select(d => d.ToString()[0]);
//            var result = allDigits
//                .Select(d => new { Digit = d, Count = count.ContainsKey(d) ? count[d] : 0 })
//                .OrderBy(x => x.Digit);

//            foreach (var item in result) { Console.WriteLine($"{item.Digit} : {item.Count}"); }

//            //// 아주 기발한 방법
//            //int a() => int.Parse(Console.ReadLine()); 
//            //var b = $"{a() * a() * a()}"; 
//            //var c = new int[10]; 
//            //int d = b.Length;
//            //while (d-- > 0) c[b[d] - 48]++; 
//            //Console.Write(string.Join("\n", c));
            
//        }
//    }

//}
