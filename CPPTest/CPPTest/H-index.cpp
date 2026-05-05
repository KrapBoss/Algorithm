#include <string>
#include <vector>
#include <algorithm>

using namespace std;

/// <summary>
/// 문제의 핵심은 h번 읽었을 때, h번 이상 읽은 논문이 h개 이상인지를 판단하는 것이다.
/// 그렇기 때문에, 내림차순 정렬을 통해 큰수부터 나오게 한 다음 h번을 인덱스로 사용하여, h번 읽었을 때 현재 배열[인덱스] 값이 h횟수를 초과하는지만 비교하면 되는거였음.
/// </summary>
/// <param name="citations"></param>
/// <returns></returns>

int solution(vector<int> citations) {

    int answer = 0;

    sort(citations.rbegin(), citations.rend());

    int h = 0;
    int store = 0;

    for (int i = 0; i < citations.size(); i++)
    {
        if ((i + 1) <= citations[i]) {
            h = i + 1;
        }
        else {
            break;
        }
    }

    return h;
}