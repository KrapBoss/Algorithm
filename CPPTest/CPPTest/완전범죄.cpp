#include <string>
#include <vector>
#include <algorithm> // min 함수 사용

using namespace std;

int maxA;
int maxB;
int minA;

// 💡 [최적화 핵심] 중복 계산을 막기 위한 캐시 테이블 (DP)
// dp[index][a_weight][b_weight] 상태를 저장합니다.
// 제한 조건에 따라 크기를 조절해야 합니다. (여기서는 예시로 임의 지정)
int dp[125][125][125];

void static dfs(vector<vector<int>>& info, int currA, int currB, int currIndex)
{
    // ✂️ [가지치기 1] 현재 누적된 currA가 이미 기존에 발견한 최소 minA보다 크거나 같다면
    // 더 이상 탐색할 필요가 없으므로 즉시 종료합니다.
    if (currA >= minA) return;

    if (currIndex == info.size())
    {
        if (currA < minA) minA = currA;
        return;
    }

    // ✂️ [가지치기 2: 메모이제이션] 이미 동일한 상태로 방문한 적이 있다면 종료
    // 현재 상태에서 도달할 수 있는 탐색을 이미 해봤으므로 중복 연산을 차단합니다.
    if (dp[currIndex][currA][currB] != -1) return;
    dp[currIndex][currA][currB] = 1; // 방문 마킹

    int weightA = info[currIndex][0];
    int weightB = info[currIndex][1];

    // 조건 미달 시 탐색 제외 (작성하신 안전장치 유지)
    if (weightA + currA < maxA)
    {
        dfs(info, weightA + currA, currB, currIndex + 1);
    }

    if (weightB + currB < maxB)
    {
        dfs(info, currA, currB + weightB, currIndex + 1);
    }
}

int solution(vector<vector<int>> info, int n, int m)
{
    maxA = n;
    maxB = m;
    minA = 121; // 초기화

    // 💡 전역 변수나 정적 배열을 사용할 때 프로그래머스 채점 서버에서 
    // 이전 테스트케이스의 데이터가 남아 오답이 나는 것을 방지하기 위해 반드시 매번 초기화해야 합니다.
    for (int i = 0; i < 125; ++i)
        for (int j = 0; j < 125; ++j)
            for (int k = 0; k < 125; ++k)
                dp[i][j][k] = -1;

    dfs(info, 0, 0, 0);

    if (minA == 121) minA = -1;

    return minA;
}