using System;
using System.Linq;

namespace ConsoleApp1
{
    /*
    internal class E2920 // 음계
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int flag = a[0] - a[1];
            for(int i =1; i < a.Length-1; i++) {
                if ((a[i]- a[i+1]) != flag) {
                    flag = (a[i] - a[i]);
                    break;
                }
            }
            Console.WriteLine(flag == -1 ? "ascending" : flag == 1 ? "descending" : "mixed");

            var s=Console.ReadLine();Console.Write(s=="1 2 3 4 5 6 7 8"?"ascending":s=="8 7 6 5 4 3 2 1"?"descending":"mixed");
        }
    }
    */
}
