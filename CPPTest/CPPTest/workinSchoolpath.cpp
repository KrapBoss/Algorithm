#include <string>
#include <vector>

using namespace std;

/// <summary>
/// 규칙 : 현재 위치에서 좌, 하 위치로만 이동 가능하며,
/// 목적까지 모든 이동 가능한 경우의 수를 구하는 것이 목표
/// 이때, 중간에 이동할 수 없는 부분이 있으며, 해당 부분을 건너뛰고 이동이 필요.
/// </summary>
/// <param name="m"></param>
/// <param name="n"></param>
/// <param name="puddles"></param>
/// <returns></returns>
int solution(int m, int n, vector<vector<int>> puddles) {
    int answer = 0;

    vector<vector<int>> arr(n,vector<int>(m,0));
    
    for (int i = 0; i < puddles.size(); i++) 
    {
        arr[puddles[i][1]-1][puddles[i][0]-1] = -1;
    }
    arr[0][0] = 1;

    for (int y = 0; y < n; y++)
    {
        for (int x = 0; x < m; x++)
        {
            if (y == 0 && x == 0) continue;
            if (arr[y][x] == -1) continue;

            int left = 0;
            int top = 0;

            if ((x - 1) >= 0 && arr[y][x - 1] != -1)
            {
                left = arr[y][x - 1];
            }

            if ((y - 1) >= 0 && arr[y-1][x] != -1)
            {
                top = arr[y-1][x];
            }

            arr[y][x] = (left + top) % 1000000007;
        }
    }

    answer = arr[n - 1][m - 1];

   return answer;
}