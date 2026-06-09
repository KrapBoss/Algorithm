using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// N의 숫자를 총 8회 이하 사용하여 number 가 나오는 경우의 수를 구하는 것
/// 이때, 경우의 수가 가장 적을 수를 구하는 것이며,
/// 각 사용 횟수에 따른 모든 수에 대한 조합을 구한 이후 값을 더하여 사용하는 것이 목표.
/// 한개씩 숫자 사용에 대한 값의 결과를 누적하여 이전 누적된 결과값을 통해 N 번 째 사용되는 값의 조합된 값을 구하는 것.
/// </summary>
public class View_N
{
    public int solution(int N, int number)
    {
        int answer = -1;

        List<HashSet<int>> table = new List<HashSet<int>>();

        for (int i = 0; i < 8; i++)
        {
            table.Add(new HashSet<int>());
            table[i].Add(int.Parse(new string(N.ToString()[0], (i + 1))));
        }

        for (int i = 0; i < 8; i++)
        {
            int start = -1;

            for (int x = 0; x <= i - 1; x++)
            {
                foreach (var front in table[x])
                {
                    foreach (var back in table[i - x - 1])
                    {
                        //각 자릿수 조합
                        table[i].Add(front + back);
                        table[i].Add(front - back);
                        table[i].Add(back - front);
                        table[i].Add(front * back);
                        if (back != 0) table[i].Add(front / back);
                        if (front != 0) table[i].Add(back / front);
                    }
                }
            }
            // 뒤 위치.
            for (int x = i - 1; x >= (i / 2); x--)
            {
                start++;

                // 앞에서 부터 배열 시작
                foreach (var front in table[start])
                {
                    // 뒤 배열
                    foreach (var back in table[x])
                    {
                        //각 자릿수 조합
                        table[i].Add(front + back);
                        table[i].Add(front - back);
                        table[i].Add(back - front);
                        table[i].Add(front * back);
                        if (back != 0) table[i].Add(front / back);
                        if (front != 0) table[i].Add(back / front);
                    }
                }
            }

            //Console.Write($" {i} == > ");
            //foreach (var item in table[i])
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            if (table[i].Contains(number))
            {
                answer = i + 1;
                break;
            }
        }

        return answer;
    }
}