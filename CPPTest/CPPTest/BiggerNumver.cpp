#include <string>
#include <vector>
#include <algorithm>

using namespace std;

string solution(vector<int> numbers) {
    string answer = "";

    vector<string> str_arr;
    for (int item : numbers) {
        str_arr.push_back(to_string(item));
    }

    // 수를 이용하여 정렬을 조합하면, 문제가 생김. 그렇기에 수 조합이 아닌 문자열 자체의 아스키 코드 크기 비교를 통해
    // 조합을 진행하는 것이 바람직해 보임
    // 2 + 33 vs 2+4  중 24 값이 문자열 상 더 크기 때문에 해당 수를 가장 앞에 사용하는 것
    sort(str_arr.begin(), str_arr.end(),
        [](const string& a, const string& b) {
            //if (a == "0") return false;
            //if (b == "0") return true;

            return a + b > b + a;
        });

    //여기서 모든 문자열 합칩니다.
    for (int i = 0; i < str_arr.size(); i++)
    {
        answer += str_arr[i];
    }
    // 수가 없을 경우 0 만 표기
    if (answer[0] == '0') return "0";

    return answer;
}