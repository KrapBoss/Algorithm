#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>
#include <sstream>
#include <cmath>

using namespace std;


static void Check(vector<vector<int>>& wires, vector<int>& lines, vector<bool>& visited, int visit, int& blockIndex)
{
    // 방문 등록
    visited[visit-1] = true;
    lines.push_back(visit);

    for (int i = 0; i < wires.size(); i++)
    {
        if (blockIndex == i) continue;

        //양방향 노드이기에 양방향을 체크한다.
        // 연결된 송전탑으로 이동
        if (wires[i][0] == visit && !visited[wires[i][1]- 1])
        {
            Check(wires, lines, visited, wires[i][1], blockIndex);
        }

        // 연결된 송전탑으로 이동
        if (wires[i][1] == visit && !visited[wires[i][0]- 1])
        {
            Check(wires, lines, visited, wires[i][0], blockIndex);
        }
    }
}


/// <summary>
/// 1. 하나씩 다 끊어 보는것
/// 2. 우선 연결해서, 추적한 다음 
/// </summary>
/// <param name="n"></param>
/// <param name="wires"></param>
/// <returns></returns>
int solution(int n, vector<vector<int>> wires) {
    int answer = 101;
    
    for (int i = 0; i < wires.size(); i++)
    {
        vector<bool> visited(n, false);
        vector<int> lines;  // 서로 연결된 송전탑

        // 연결을 끊는 부분
        int blockIndex = i;
        // 방문 노드(임의)
        int visit = n/2;

        //한쪽 노드에서 시작한 DFS 탐색
        Check(wires, lines, visited, visit, blockIndex);

        // 두 노드의 차이값 저장
        int _answer = n - 2 * lines.size();
        _answer = abs(_answer);

        if (_answer < answer) answer = _answer;
    }


    double d = 3.1548;
    float f = 3.1548;

    stringstream ssss;
    ssss << fixed << setprecision(2) << d;
    ssss.str();

    return answer;
}



#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

// 연결된 송전탑의 개수를 세는 DFS 함수
int dfs(int curr, int blockA, int blockB, vector<bool>& visited, const vector<vector<int>>& adj) {
    visited[curr] = true;
    int count = 1;

    for (int next : adj[curr]) {    // 모든 정점 v를 돈다.
        // 끊기로 한 전선(blockA - blockB)인 경우 통과
        if ((curr == blockA && next == blockB) || (curr == blockB && next == blockA)) continue;

        if (!visited[next]) {
            count += dfs(next, blockA, blockB, visited, adj);
        }
    }
    return count;
}

int solution(int n, vector<vector<int>> wires) {
    int answer = n; // 최대 차이는 n을 넘을 수 없음
    vector<vector<int>> adj(n + 1);

    // 1. 인접 리스트 생성 (양방향 그래프)
    for (const auto& wire : wires) {
        adj[wire[0]].push_back(wire[1]);
        adj[wire[1]].push_back(wire[0]);
    }

    // 2. 모든 전선을 하나씩 끊어보며 완전 탐색
    for (const auto& wire : wires) { // e번 돈다.
        vector<bool> visited(n + 1, false);

        // 끊겨진 전선의 한쪽 끝점(wire[0])에서 시작하여 연결된 개수를 셉니다.
        // 끊어야 할 정보(wire[0], wire[1])를 DFS에 전달합니다.
        int count = dfs(wire[0], wire[0], wire[1], visited, adj);

        // 3. 두 전력망의 차이 계산: |count - (n - count)| = |2 * count - n|
        int diff = abs(2 * count - n);
        answer = min(answer, diff);

        // 최솟값이 0이면 더 이상 탐색할 필요가 없습니다. (최적화)
        if (answer == 0) break;
    }

    //그럼 e*v 아니냐고

    return answer;
}
