using System;
using System.Collections.Generic;

public class SchoolPath
{
    public int solution(int m, int n, List<List<int>> puddles)
    {
        // 1번 인덱스부터 직관적으로 쓰기 위해 (n + 1) x (m + 1) 크기로 할당합니다.
        // n은 세로(행), m은 가로(열)를 의미합니다.
        int[,] dp = new int[n + 1, m + 1];

        // 물에 잠긴 지역은 -1로 표시합니다.
        for (int i = 0; i < puddles.Count; i++)
        {
            // 문제에서 puddles[i][0]은 가로(m), puddles[i][1]은 세로(n) 좌표입니다.
            int puddleX = puddles[i][0];
            int puddleY = puddles[i][1];
            dp[puddleY, puddleX] = -1;
        }

        // 시작 지점의 경로 수는 1입니다.
        dp[1, 1] = 1;

        // 모든 경우의 수는 출발선에서 내려오는 순을 차례대로 구하면 된다.
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                // 시작 지점이거나 물에 잠긴 지역은 건너뜁니다.
                if ((i == 1 && j == 1) || dp[i, j] == -1)
                {
                    continue;
                }

                int topPaths = 0;
                int leftPaths = 0;

                // 위쪽 칸에서 오는 경로 (물에 잠긴 칸이 아닐 때만)
                if (i - 1 >= 1 && dp[i - 1, j] != -1)
                {
                    topPaths = dp[i - 1, j];
                }

                // 왼쪽 칸에서 오는 경로 (물에 잠긴 칸이 아닐 때만)
                if (j - 1 >= 1 && dp[i, j - 1] != -1)
                {
                    leftPaths = dp[i, j - 1];
                }

                // 오버플로우 방지를 위해 매 연산마다 나머지 연산을 수행합니다.
                dp[i, j] = (topPaths + leftPaths) % 1000000007;
            }
        }

        return dp[n, m];
    }
}