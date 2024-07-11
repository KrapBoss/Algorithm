using System;
using System.Linq;

namespace ConsoleApp1
{
    /*
    internal class E1259 //팰린드롬수
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str.Equals("0")) break;
                int index = (str.Length+1) / 2;
                string f = str.Substring(0, index);
                string b = string.Join("",str.Substring(str.Length / 2, index).Reverse());
                Console.WriteLine($"{(f.Equals(b)? "yes":"no")}");

                for (string s; (s = Console.ReadLine()) != "0";) 
                    Console.WriteLine(s == string.Concat(s.Reverse()) ? "yes" : "no");
            }
        }
    }
    */
}
