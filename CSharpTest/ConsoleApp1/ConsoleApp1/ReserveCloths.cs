using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 체육복 빌려주기 1레벨 문제
/// 말장난과 생각해야 되는 함정의 수가 있음
/// 제공자의 배열이 정렬이 안된 경우, 제공자가 도난 당한 경우
/// </summary>
public class ReserveCloths
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;

        bool[] save = Enumerable.Repeat(true, n).ToArray();
        foreach (int ls in lost)
        {
            save[ls - 1] = false;
        }

        List<int> Reserver = new List<int>();


        // 순서가 뒤바뀔 경우 최적의 경우를 찾지 못하기에 정렬
        Array.Sort(reserve);

        // 빌려준 사람이 도난을 당했을 경우 제공자로서의 역할을 하지 못함.
        for (int i = 0; i < reserve.Length; i++)
        {
            if (!save[reserve[i] - 1])
            {
                save[reserve[i] - 1] = true;
            }
            else
            {
                Reserver.Add(reserve[i]);
            }
        }

        // 제공자들 중 앞에 있는 애들부터 찾아서 제공을 먼저 해주도록 수정
        for (int i = 0; i < Reserver.Count; i++)
        {
            int st = Reserver[i] - 1;

            if (!save[st])
            {
                save[st] = true;
            }
            else if (st - 1 >= 0 && !save[st - 1])
            {
                save[st - 1] = true;
            }
            else if (st + 1 < n && !save[st + 1])
            {
                save[st + 1] = true;
            }
        }

        answer = save.Count(x => x);

        return answer;
    }
}