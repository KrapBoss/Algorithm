#include <string>
#include <vector>

using namespace std;

vector<bool> visited;
int countN = 0;

/// <summary>
/// 독자적인 네트워크의 총 개수를 측정하는 방식
/// </summary>
/// <param name="computers"></param>
/// <param name="start"></param>
static void dfs(vector<vector<int>>& computers, int start)
{
    visited[start] = true;

    for (int i = 0; i < computers.size(); i++) 
    {
        if (computers[i][start] == 1) 
        {
            for (int x = 0; x < computers[i].size();  x++) 
            {
                if (visited[x] || computers[i][x] == 0) continue;

                dfs(computers, x);
            }
        }
    }
}

int solution(int n, vector<vector<int>> computers) 
{
    visited = vector<bool>(n, false);

    for (int i = 0; i < n; i++) 
    {
        if (visited[i]) continue;
        dfs(computers, i);
        countN++;
    }

    return countN;
}