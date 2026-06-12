using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 조이스틱을 이동하여 알파벳 이름을 변경하는 최소한의 횟수를 구하는 로직
/// 좌 우 이동 후 다시 좌 우 로 이동 가능하며, 가장 작은 변경값을 구하는 것이 목표.
/// 그렇기에 모든 가능한 횟수에 대해 dfs로 판단을 진행.
/// 탐욕법과 dfs 를 결합
/// </summary>
public class JoyStick
{
    const char A = 'A';
    const char Z = 'Z';

    public void DFS(ref string name, bool[] visitor, int index, int count, int visited, int size, ref int MinValue)
    {
        int up = name[index] - A;
        int down = (Z - A) - up + 1;

        int min = Math.Min(up, down);
        count += min;

        if (size == visited)
        {
            if (MinValue > count) MinValue = count;
            return;
        }

        //우측
        bool flag = false;
        int start = 1;
        int idx = 0;
        while (true)
        {
            idx = (index + start) % visitor.Length;
            if (!visitor[idx] && name[idx] != A)
            {
                flag = true;
                break;
            }
            start++;
        }

        if (flag)
        {
            visitor[idx] = true;
            DFS(ref name, visitor, idx, count + start, visited + 1, size, ref MinValue);
            visitor[idx] = false;
        }


        //좌측
        flag = false;
        start = 1;
        idx = 0;
        while (true)
        {
            idx = ((index - start) + visitor.Length) % visitor.Length;
            if (!visitor[idx] && name[idx] != A)
            {
                flag = true;
                break;
            }
            start++;
        }

        if (flag)
        {
            visitor[idx] = true;
            DFS(ref name, visitor, idx, count + start, visited + 1, size, ref MinValue);
            visitor[idx] = false;
        }
    }

    public int solution(string name)
    {
        int answer = int.MaxValue;
        bool[] visitor = new bool[name.Length];
        int length = name.Length;
        int size = name.Count(x => x != A);

        visitor[0] = true;
        int init = (name[0] != A) ? 1 : 0;
        DFS(ref name, visitor, 0, 0, init, size, ref answer);

        return answer;
    }
}