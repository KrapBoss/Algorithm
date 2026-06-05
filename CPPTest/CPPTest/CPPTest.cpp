#include <vector>
# include<string>
#include<sstream>
#include<iostream>
#include<iomanip>

using namespace std;

int solution(string reward_log, string target_item) {
    int total_count = 0;

    // 여기에 코드를 작성하세요.
    // Hint 1: 쉼표(,)를 기준으로 문자열을 분리하기 위해 stringstream과 getline을 활용하세요.
    // Hint 2: 쪼개진 각 토큰에서 콜론(:)의 위치를 find()로 찾고 substr()로 이름과 개수를 분리하세요.
    // Hint 3: 분리된 이름이 target_item과 같다면 개수 문자열을 stoi()로 변환하여 total_count에 누적하세요.

    stringstream ss(reward_log);
    string output;
    while (getline(ss, output, ','))
    {
        auto fw = output.find(':');
        if (fw != string::npos)
        {
            string f = output.substr(0, fw);

            string e = output.substr(fw + 1);

            int trans = stoi(e);

            stringstream st;
            st << fixed << setprecision(2) << trans;
            st.str();
        }
    }

    return total_count;
}

// 아래 메인 함수는 본인 PC 환경에서 테스트해보기 위한 용도입니다.
int main() {
    string log = "potion:5,gold:100,potion:10,sword:1";
    string target = "potion";

    int ans = solution(log, target);
    cout << "[Test Result] Total Count: " << ans << " (Expected: 15)" << endl;

    return 0;
}