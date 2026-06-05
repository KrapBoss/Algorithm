#include<vector>
#include<queue>
#include<algorithm>
using namespace std;

/// <summary>
/// 맵에 주어지고 0은 막힌 곳 1은 뚫린 곳
/// 가장 짧은 거리로 이동할 수 있는 경우의 수를 출력해라.
/// </summary>
/// <param name="maps"></param>
/// <returns></returns>
int solution(vector<vector<int> > maps)
{
    vector<vector<int>> mapDist(maps.size(), vector<int>(maps[0].size(), -1));
    queue<pair<int, int>> positions;

    vector<pair<int, int>> PM = {
        make_pair(1,0),
        make_pair(0,1),
        make_pair(-1,0),
        make_pair(0,-1),
    };
    
    positions.push(make_pair(0, 0));
    mapDist[0][0] = 1;

    int maxX = maps[0].size() - 1;
    int maxY = maps.size() - 1;

    while (positions.size() > 0)
    {
        auto position = (positions.front());
        positions.pop();

        int x = position.first;
        int y = position.second;

        for (auto p : PM) 
        {
            int nextX = x + p.first;
            int nextY = y + p.second;

            // 예외 처리
            if (nextX < 0 || nextX > maxX) continue;
            if (nextY < 0 || nextY > maxY) continue;

            // bfs 로 이동한 곳을 기록합니다.
            // 기록될 때 미리 해당 위치까지 이동한 거리를 저장합니다.
            if (mapDist[nextY][nextX] < 0 && maps[nextY][nextX] == 1)
            {
                mapDist[nextY][nextX] = mapDist[y][x] + 1;
                positions.push(make_pair(nextX, nextY));
            }
        }
    }

    return mapDist[maxY][maxX];
}