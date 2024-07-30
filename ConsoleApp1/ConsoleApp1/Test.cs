//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp1
//{
//    class Pet
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    internal class Test // 웰컴 키트 
//    {
//        static void Main(string[] args)
//        {
//            string[] fruits = { "grape", "passionfruit", "banana", "mango",
//                      "orange", "raspberry", "apple", "blueberry" };

//            //이미 정렬된 시퀀스를 다시 문자열의 사전 순으로 정렬합니다.
//            IEnumerable<string> query =
//                fruits.OrderBy(fruit => fruit.Length).ThenByDescending(fruit => fruit);

//            foreach (string fruit in query)
//            {
//                Console.WriteLine(fruit);
//            }

//        }
//    }

//    // This code produces the following output:
//    //
//    // {Owner=Higa, Pet=Scruffy}
//    // {Owner=Higa, Pet=Sam}
//    // {Owner=Ashkenazi, Pet=Sugar}
//    // {Owner=Price, Pet=Scratches}
//}
