#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(vector<int> array, vector<vector<int>> commands) {
    vector<int> answer;
    vector<vector<int>> numbers;

    // 배열 주소 복사는 해당 인덱스 주소부터 종료하길 원하는 인덱스의 +1 주소값을 넣으면 원하는 범위로 추출 가능합니다.
    // [2, 5, 3] => 자르고 뽑을 번호
    //[1, 5, 2, 6, 3, 7, 4]를 2번째부터 5번째까지 자른 후 정렬합니다. [2, 3, 5, 6]의 세 번째 숫자는 5입니다.
    for (auto item : commands) {
        numbers.push_back(vector<int>(&array[item[0]], &array[item[1]]+1));
        sort(numbers.back().begin(), numbers.back().end());
        answer.push_back(numbers.back()[item[2]-1]);
    };

    return answer;
    //return numbers[0];
}