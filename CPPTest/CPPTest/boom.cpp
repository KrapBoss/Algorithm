#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

// 좌표를 편하게 관리하기 위한 구조체
struct Point {
    int x, y;
};

int solution(int n, vector<vector<int>> grid) {
    int max_time = 0;

    // BFS를 위한 큐 선언 (좌표 정보가 들어감)
    queue<Point> q;

    // 각 칸까지 폭발이 도달한 시간을 기록할 배열 (-1로 초기화)
    // -1은 아직 폭발이 도달하지 않은 미방문 상태를 뜻합니다.
    vector<vector<int>> time_map(n, vector<int>(n, -1));

    // 1. [준비 단계] 맵 전체를 순회하며 최초 폭발지(2)를 찾아 큐에 전부 집어넣으세요.
    // 최초 폭발지의 time_map 값은 0(0초)이 되어야 합니다.
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            if (grid[i][j] == 2) {
                q.push(Point{ i, j });
                time_map[i][j] = 1;
            }
        }
    }

    // 상하좌우 방향 벡터 선언
    const int dy[4] = { -1, 1, 0, 0 };
    const int dx[4] = { 0, 0, -1, 1 };

    // 2. [탐색 단계] 큐가 빌 때까지 BFS를 돌리세요.
    while (!q.empty()) {
        Point curr = q.front();
        q.pop();

        for (int i = 0; i < 4; i++) 
        {
            int x = curr.x + dx[i];
            int y = curr.y + dy[i];

            if (x < 0 || x >= n) continue;
            if (y < 0 || y >= n) continue;
            if (grid[x][y] == 1) continue;

            time_map[x][y] = time_map[curr.x][curr.y] + 1;
            grid[x][y] = 1;
            q.push({ x,y });
        }
    }

    for (int i = 0; i < n;i++) {
        for (int j = 0; j < n; j++ ) {
            if (grid[i][j] == 0) {
                return -1;
            }

            if (time_map[i][j] > max_time) max_time = time_map[i][j];
        }
    }
    // 3. [검증 단계] 모든 탐색이 끝난 후, 맵에 폭발이 도달하지 못한 평지가 남아있는지 검사하세요.
    // grid[i][j] == 0 인데 time_map[i][j] == -1 인 곳이 단 하나라도 있다면 -1을 반환해야 합니다.
    // 안전하게 다 터졌다면 time_map에 기록된 시간 중 가장 큰 최댓값(max_time)을 찾아 반환하세요.

    return max_time;
}

int main() {
    int n = 3;
    vector<vector<int>> grid = {
        {2, 0, 1},
        {0, 1, 0},
        {1, 0, 2}
    };

    int result = solution(n, grid);
    cout << "[Test Result] Total Time: " << result << " (Expected: 2)" << endl;

    return 0;
}