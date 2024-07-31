//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class E5430    { // AC
//        static void Main(string[] args)
//        {
//            int iter = int.Parse(Console.ReadLine());

//            while (iter > 0)
//            {
//                iter--;

//                //정배열 플래그
//                bool ASC = true;
//                //에러 플래그
//                bool error = false;

//                //명령을 저장하기 위함
//                string mandate= Console.ReadLine(); Console.ReadLine();

//                string str = Console.ReadLine();

//                List<int> numbers;
//                //숫자가 []와 같이 비어있는 예외 처리
//                if (str.Length <3) numbers = new List<int>();
//                //배열에서 숫자를 추출하기 위함
//                else numbers = str.Substring(1, str.Length - 2).Split(',').Select(int.Parse).ToList();
                
//                foreach(char  c in mandate) {
//                    if ( c.Equals('R'))
//                    {
//                        ASC = !ASC;
//                    }
//                    else
//                    {
//                        //비어있는 배열에서 제거 시 ERROR을 출력
//                        if (numbers.Count < 1)
//                        {
//                            error = true;
//                            break;
//                        }

//                        //플래그에 따라 배열의 앞과 뒤를 제거함
//                        if (ASC) numbers.RemoveAt(0);
//                        else numbers.RemoveAt(numbers.Count-1);
//                    }
//                }

//                //스트링 배열 생성 시간을 줄이기 위함
//                StringBuilder stringBuilder = new StringBuilder();
//                if (error)
//                {
//                    stringBuilder.Append("error");
//                }
//                else
//                {
//                    stringBuilder.Append('[');

//                    if (!ASC) { numbers.Reverse(); }

//                    stringBuilder.Append(string.Join(",", numbers));
//                    stringBuilder.Append(']');
//                }

//                Console.WriteLine(stringBuilder);
//            }
//        }
//    }
    
//}
