#include <string>
#include <vector>
#include <deque>
#include <unordered_map>
#include <algorithm>

using namespace std;

// 큐에 넣고, 뺄때 특정 위치 값이 실행되는 순서를 알고 싶다.
// 원하는 인덱스의 실행 순서를 알고 싶다.

int solution(vector<int> priorities, int location) {

    int progress = 0;
    int index = location;

    deque<int> prior;
    for (int p : priorities) {
        prior.push_back(p);
    }

    while (prior.size() > 0) {

        //최고 우선 순위를 가져옵니다.
        int maxN = *max_element(prior.begin(), prior.end());
        // 진행 순서를 증가.
        progress++;

        while (true) {
            int current = prior.front();
            prior.pop_front();

            //현재 위치 앞으로 이동
            index--;

            if (current == maxN)
            {
                //현재 선택된 인덱스 상태인 경우
                if (index == -1) return progress;

                break;
            }
            else {
                // 사용된 프로세스가 아닌 경우 맨 뒤에 추가
                prior.push_back(current);

                if (index < 0) index = prior.size()-1;
            }
        }
    }
}