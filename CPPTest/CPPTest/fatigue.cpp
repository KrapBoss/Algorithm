#include <string>
#include <vector>

using namespace std;

int fatigue = 0;
int visitCount = 0;
int maxVisitCount = 0;

static void Check(vector<vector<int>>& dungeons, vector<bool>& visit)
{
    for (int i = 0; i < dungeons.size(); i++)
    {
        if (maxVisitCount >= dungeons.size()) break;

        // 앞에서 방문 중
        if (visit[i]) continue;

        // 피로도가 부족함
        if (dungeons[i][0] > fatigue) continue;

        //방문과 피로도 소모 적용
        visit[i] = true;
        fatigue -= dungeons[i][1];
        visitCount++;

        if (maxVisitCount < visitCount) maxVisitCount = visitCount;

        Check(dungeons, visit);

        // 방문 완료 및 피로도 회복
        visit[i] = false;
        fatigue += dungeons[i][1];
        visitCount--;
    }
}

/// <summary>
/// 
/// </summary>
/// <param name="k">피로도</param>
/// <param name="dungeons">던전별 최소 피로도와 소모 피로도</param>
/// <returns></returns>
int solution(int k, vector<vector<int>> dungeons) {
    int answer = -1;
    vector<bool> visit(dungeons.size(), false);

    //피로도 적용
    fatigue = k;
    // 탐색 시작
    Check(dungeons, visit);

    return maxVisitCount;
}
