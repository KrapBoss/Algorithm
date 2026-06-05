#include <string>
#include <vector>
#include <cmath>

using namespace std;

/*
*
6 * 4 = 24
이때, 갈색이 테두리에 위치하면서 18개가 되어야 된다.
그럼 가운데의 노란색의 개수가 실제 입력값과 일치하는지 조건을 검색
가운데의 노란색 구역의 크기는 x-2 * y-2 일 때, 이 조건을 만족하는 범위를 구하는 것이 중요.

*/
vector<int> solution(int brown, int yellow) {
    vector<int> answer;

    int mx = brown;/*max(brown, yellow);*/
    int root = ceil(sqrt(brown + yellow));
    floor(root);
    round(root);
    ceil(root);
    int result = brown + yellow;

    for (int x = root; x <= mx; x++) {

        // x 값에 따른 y 값을 구합니다.
        int y = result / x;

        if (y * x != result) continue;

        if (((x - 2) * (y - 2)) == yellow)
        {
            answer.push_back(x);
            answer.push_back(y);
            break;
        }

    }

    return answer;
}