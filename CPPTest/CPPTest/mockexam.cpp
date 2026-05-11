#include <string>
#include <vector>
#include <algorithm>

using namespace std;

// 최대 점수를 맞은 
vector<int> solution(vector<int> answers) {
    vector<int> answer;

    vector<int> one{ 1,2,3,4,5 };
    vector<int> two{ 2,1,2,3,2,4,2,5 };
    vector<int> three{ 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
    vector<int> people{ 0,0,0 };

    // 하나씩 기록
    int collect = 0;
    for (int i = 0; i < answers.size(); i++) {
        collect = answers[i];
        people[0] += one[i % one.size()] == collect ? 1 : 0;
        people[1] += two[i % two.size()] == collect ? 1 : 0;
        people[2] += three[i % three.size()] == collect ? 1 : 0;
    }

    // 최대값을 구한다.
    int maxV = *max_element(people.begin(), people.end());

    //최대값과 일치하는 값의 인덱스를 추가합니다.
    for (int i = 0; i < people.size(); i++) {
        if (people[i] == maxV)answer.push_back(i + 1);
    }

    return answer;
}