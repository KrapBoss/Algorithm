#include <string>
#include <vector>
#include <queue>
#include <algorithm>
#include <numeric>

using namespace std;

int solution(int bridge_length, int weight, vector<int> truck_weights) {
    int answer = 0;
    vector<pair<int, int>> onBridgeTruck;
    queue<int> truck;
    for (int t : truck_weights) truck.push(t);

    int sec = 0;                        // 진행 시간
    int currntWeight = 0;               // 남은 무게
    int remainSpace = bridge_length;    // 남은 공각
    do {
        sec++;

        int peek = 0;
        if (!truck.empty()) peek = truck.front();
            
        // 대기 중인 차가 있을 때만 진행합니다.
        if ((currntWeight + peek) <= weight && remainSpace > 0 && peek != 0) {

            onBridgeTruck.push_back({ peek,bridge_length});
            truck.pop();

            remainSpace--;
            currntWeight += peek;
        }

        bool flag = false;

        //저장된 다리위 트럭 정보의 카운트 다운 제거
        for (auto &item : onBridgeTruck) {
            if (item.first != 0) {
                // 지나가는 대기 시간 감소
                item.second -= 1;

                if (item.second == 0) {
                    remainSpace++;
                    currntWeight -= item.first;
                    flag = true;
                }
            }
        }

        if (flag) 
        {   // 빠져나온 트럭이 있다면, 첫번째 트럭이 확실하니 
            onBridgeTruck.erase(onBridgeTruck.begin());
        }

    } while (!onBridgeTruck.empty() || !truck.empty());

    // 마지막 빠져 나온 시간 +1 을 해야 다리위에서 빠져 나온 시간이 측정 됩니다.
    return sec+1;
}