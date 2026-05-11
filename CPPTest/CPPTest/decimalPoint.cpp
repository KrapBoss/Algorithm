#include <string>
#include <vector>
#include <set>
#include <cmath>

using namespace std;

vector<char> c_numbers;
set<int> set_numbers;   // 소수 숫자들
vector<bool> visited;   // 방문 확인
vector<char> c_register;    // 방문된 숫자 하나씩 기록


/// <summary>
/// 소수를 판단합니다.
/// 수의 약수를 판단하여 나눠떨어지지 않는다면 소수입니다.
/// </summary>
/// <param name="value"></param>
/// <returns></returns>
static bool isPrime(int value) {
    if (value == 1) return false;
    if (value == 0) return false;

    // 제곱의 약수로 판단하기 위한 것
    int sqr = sqrt(value);

    for (int i = 2; i <= sqr; i++) {
        if (value % i == 0) return false;
    }
    return true;
}

/// <summary>
/// 
/// </summary>
/// <param name="count">현재 선택해야되는 개수</param>
/// <param name="index">현재 선택된 개수</param>
/// <returns></returns>
static void de(int count, int index) {

    //선택된 개수가 최대 선택치와 같은 경우 중지.
    if (index == count)
    {
        // 모든 문자열을 합칩니다.
        string str(c_register.begin(), c_register.end());

        // int 로 변환합니다.
        int v = stoi(str);

        // 제곱임을 판단합니다.
        if (isPrime(v))set_numbers.insert(v);
        /*if (set_numbers.find(v) != set_numbers.end()) {
        }*/

        return;
    }

    for (int i = 0; i < c_numbers.size(); i++) {

        if (visited[i]) continue;   // 이미 앞에서 조합 중인 경우 다음 번호로 넘어갑니다.

        // 첫번째 값을 무조건 추가합니다. 
        c_register.push_back(c_numbers[i]);
        visited[i] = true;

        // 뒤에 있는 값들을 모든 조합으로 조합.
        de(count, index + 1);

        // 이전 기록 제거.
        c_register.pop_back();
        visited[i] = false;
    }
}


int solution(string numbers) {
    int answer = 0;

    // 모든 문자 단위로 배열에 추가합니다.
    for (char& c : numbers) {
        c_numbers.push_back(c);
        visited.push_back(false);
    }

    // 각 횟수에 따른 조합을 시작합니다. 1 ~ n 개의 조합
    for (int i = 0; i < c_numbers.size(); i++) {
        de(i+1, 0);
    }

    return set_numbers.size();
}