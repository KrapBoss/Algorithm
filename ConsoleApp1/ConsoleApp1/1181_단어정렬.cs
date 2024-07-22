using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace ConsoleApp1
{
    /*
    internal class _1181 //  단어 정렬
    {
        static void Main(string[] args)
        {
            int iter = int.Parse(ReadLine());
            List<string> list = new List<string>();
            list.Distinct().OrderBy(x => x.Length).ThenBy(x =>x);
            for(int i = 0; i < iter; i++)
            {
                string str = ReadLine();

                if (list.Contains(str)) continue;

                int left = 0;
                int right = list.Count;

                //left값을 기준으로 위치값 찾기
                //여기서 left는 [0]이 아닌 경우 [left-1] 보다 length가 큰 경우다.
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid].Length < str.Length)
                        left = mid + 1; // 여기서 left는 무조건적으로 left-1보다 크다는 것을 알 수 있음.
                    else
                        right = mid;
                }

                //같은 길이일 경우의 정렬
                while (true)
                {
                    //배열의 최대치일 경우
                    if (left >= list.Count) break;

                    //현재 다음배열보다 길이가 작은 경우
                    if (list[left].Length != str.Length) break;

                    //다음 배열보다 사전적으로 큰 경우 위치 이동
                    if (list[left].CompareTo(str) < 0) left++;
                    else break;
                }

                //삽입.
                //left 위치에 str이 들어가고 기존 배열은 한칸씩 밀린다.
                list.Insert(left, str);
            }

            foreach (var item in list)
            {
                WriteLine(item);
            }
        }
    }*/
}