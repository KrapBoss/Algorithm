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



/// <summary>
/// 아주 좋은 방식
/// 최적의 방식은 queue 를 통한 트럭의 이동이다.
/// 이때, 길이 자체는 queue를 통해 지속적으로 push, pop을 하여 이동하며
/// 무게만 판단하여 사용하면, 길이에 대한 부분은 queue를 통해 사용됨으로 따로 조건이 필요하지 않다.
/// </summary>
/// <param name="bridge_length"></param>
/// <param name="weight"></param>
/// <param name="truck_weights"></param>
/// <returns></returns>
int solution(int bridge_length, int weight, vector<int> truck_weights) {
    queue<int> bridge;  // 다리 상태
    int time = 0;
    int current_weight = 0;
    int i = 0;

    // 다리 초기화 (0으로 채움)
    for (int j = 0; j < bridge_length; j++) {
        bridge.push(0);
    }

    while (!bridge.empty()) {
        time++;

        // 1. 한 칸 전진 (맨 앞 제거)
        current_weight -= bridge.front();
        bridge.pop();

        // 2. 다음 트럭이 들어갈 수 있는지 확인
        if (i < truck_weights.size()) {
            if (current_weight + truck_weights[i] <= weight) {
                bridge.push(truck_weights[i]);
                current_weight += truck_weights[i];
                i++;
            }
            else {
                bridge.push(0); // 자리만 이동
            }
        }
    }

    return time;
}