using System;
using System.Collections.Generic;
using System.Linq;

public class DeimalTriangle
{
    public int solution(List<List<int>> triangle)
    {
        int answer = 0;

        // 초기화
        //List<List<int>> dp = new List<List<int>>();
        //for(int i =0; i<= triangle.Count;i++)
        //{
        //    dp.Add(Enumerable.Repeat(0, i+1).ToList());
        //}



        for (int i = triangle.Count - 2; i >= 0; i--)
        {
            int maxWidth = triangle[i].Count;

            for (int x = 0; x < maxWidth; x++)
            {
                int left = triangle[i + 1][x];
                int right = triangle[i + 1][x + 1];

                int max = Math.Max(left + triangle[i][x], right + triangle[i][x]);
                triangle[i][x] = max;
            }
        }

        answer = triangle[0][0];
        return answer;
    }
}