#include <string>
#include <vector>
#include <stack>

using namespace std;


/// <summary>
/// stack 기반 인덱스로 점수 측정하는 느낌이다.
/// stack 에는 현재 배열의 인덱스 값만 저장하고, 현재 들어가 있는 stack top 인덱스 값과 현재 인덱스의 값을 비교해서
/// 만약 현재 인덱스가 더 작은 값일 경우, stack의 몇 번의 인덱스는 지나쳐왔는지 기록하는 방식이다.
/// 하나하나 모든 수를 비교하면 비교 비용이 너무 커지기 때문에, 이러한 방식으로 사용하면 O(n) 으로 완성 가능

/*
* /// 모노토닉 스택이란?
“스택 안의 값들이 항상 단조롭게 증가하거나 감소하도록 유지하는 스택”** 이야.

Monotonic Increasing Stack(단조 증가 스택)
→ 스택 안 값이 아래 → 위로 갈수록 커짐
예 : [1, 3, 5, 8]
Monotonic Decreasing Stack(단조 감소 스택)
→ 스택 안 값이 아래 → 위로 갈수록 작아짐
예 : [8, 5, 3, 1]
*/
/// </summary>
/// <param name="prices"></param>
/// <returns></returns>

vector<int> solution(vector<int> prices) {
    vector<int> answer(prices.size(),0);
    stack<int> s_index;


    for (int i = 0; i < prices.size(); i++) {
        int c_price = prices[i];

        while (!s_index.empty() && prices[s_index.top()] > c_price) {

            int top = s_index.top();
            s_index.pop();

            answer[top] = i - top;
        }
        
        s_index.push(i);
    }

    while (!s_index.empty()) {

        int top = s_index.top();
        s_index.pop();

        answer[top] = prices.size() -1 - top;
    }

    return answer;
}