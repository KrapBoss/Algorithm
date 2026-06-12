using System;
using System.Text;

/// <summary>
/// 큰수 만들기
/// 탐욕법을 통해 남아 선택할 수 있는 number.Length - k 의 자릿수에서
/// 가장 큰 수를 선택하여 저장하는 방식.
/// 그렇기에, 현재 선택한 개수, 그에 따른 선택 가능한 배열의 범위를 지정 하여 O(s * length) 번을 돌게 된다.
/// </summary>
public class MakeABiggerNumber
{
    public string solution(string number, int k)
    {
        int seletCount = number.Length - k;

        StringBuilder sb = new StringBuilder();

        int currIndex = -1;

        for (int select = 0; select < seletCount; select++)
        {   // 선택한 개수
            currIndex += 1;
            char s = number[currIndex];

            for (int x = currIndex; x <= (number.Length - seletCount + select); x++)
            {   // 선택 가능한 배열의 자릿수
                if (s < number[x])
                {
                    s = number[x];
                    currIndex = x;
                }

            }
            sb.Append(s);
        }

        return sb.ToString();
    }
}