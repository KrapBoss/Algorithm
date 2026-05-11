#include <string>
#include <vector>

using namespace std;

/// <summary>
/// 두개의 배열을 가장 작은 사이즈로 만드는 방법으로 만들 수 있는 방식을 생각해내는것
/// 두 배열의 위치가 서로 바뀌는 경우도 생각할 수 있음
/// </summary>
/// <param name="sizes"></param>
/// <returns></returns>
int solution(vector<vector<int>> sizes) {
    int answer = 0;

    int w = 0, h = 0;

    for (int i = 0; i < sizes.size(); i++) {
        int wi = 0;
        int hi = 1;

        // 가장 큰 사이즈의 크기를 항상 좌측에 위치시킨다.
        // 우측 배열은 항상 작은 사이즈이기 때문에 최적의 크기를 구할 수 있다.
        if (sizes[i][0] < sizes[i][1]) {
            wi = 1; hi = 0;
        }

        if (sizes[i][wi] > w) w = sizes[i][wi];
        if (sizes[i][hi] > h) h = sizes[i][hi];
    }

    return w * h;
}