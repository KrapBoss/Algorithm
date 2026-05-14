#include <string>
#include <vector>
#include <cmath>
#include <unordered_map>
#include <algorithm>

using namespace std;
/// <summary>
/// 본인의 자릿수까지의 수를 가중치에 더해야 실제 변경이 이루어지는 가중치가 나온다.
/// 예를 들어 aaaa 에서 aaae 로 넘어가기 위해서는
/// 현재 aaaa의 4번째 자릿수는 1이며, 뒤에 5개의 알파벳이 변경이 가능하다.
/// 그때, a는 본인과 함꼐, 1+5 = 6 의 변경이 이루어져야, 실제 자릿수 변경이 가능하다.
/// 다르게 생각하면, 마지막 자리에서 다음 자릿수로 넘어갈 때 U 값에서 +1 을 한 값. 즉, 6이 더해져야 다음 값으로 증가하는 것이다.
/// </summary>
/// <param name="word"></param>
/// <returns></returns>

int solution(string word) {
    int answer = 0;
    vector<char> words(word.begin(), word.end());
    vector<int> weight;
    unordered_map<char, int> dic = {
    {'A', 0},
    {'E', 1},
    {'I', 2},
    {'O', 3},
    {'U', 4}
    };

    int v = 0;
    for (int i = 0; i < 5; i++) {
        v = v * 5 + 1;
        weight.push_back(v);
    }
    reverse(weight.begin(), weight.end());

    for (int i =0;i<words.size() ;i++)
    {
        answer += 1 + dic[words[i]] * weight[i];
    }

    return answer;
}


// ### 재귀 관점

#include <string>
#include <vector>

using namespace std;

// 전역 변수를 사용하여 탐색 상태를 공유합니다.
int cnt = 0;
int answer = 0;
string vowels = "AEIOU";

void dfs(string current, string target) {
    // 1. 현재 만든 단어가 목표 단어와 일치하는지 확인
    if (current == target) {
        answer = cnt;
        return;
    }

    // 2. 단어의 최대 길이는 5이므로, 5글자에 도달하면 더 이상 가지를 뻗지 않음
    if (current.length() >= 5) return;

    // 3. 'A', 'E', 'I', 'O', 'U'를 순서대로 하나씩 붙여보며 재귀 호출
    for (int i = 0; i < 5; i++) {
        // 단어를 하나 생성할 때마다 사전의 순번이 1씩 증가합니다.
        cnt++;
        dfs(current + vowels[i], target);

        // 목표 단어를 찾았다면 더 이상의 탐색(백트래킹)을 중단합니다.
        if (answer != 0) return;
    }
}

int solution(string word) {
    // 초기화 (여러 번 호출될 경우를 대비)
    cnt = 0;
    answer = 0;

    // 빈 문자열부터 탐색 시작
    dfs("", word);

    return answer;
}