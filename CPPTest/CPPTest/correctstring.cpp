#include<string>
#include <iostream>
#include <vector>

using namespace std;

/// <summary>
/// 요점
/// 1. ( 뒤에는 반드시 )가 온다는 가정
/// 2. (가 오면 저장, )가 오면 꺼내기
/// 3. 모든 순환 종료 시 데이터 잔여해 있다면, 문제 있는 것
/// </summary>
/// <param name="s"></param>
/// <returns></returns>
bool solution(string s)
{
    bool answer = true;
    vector<char> stack;

    for (char& c : s) {
        if (c == '(') {
            stack.push_back(c);
        }
        else  if(c == ')'){

            if (stack.size() == 0) {
                answer = false;
                break;
            }

            stack.pop_back();
        }
    }
    if (stack.size() > 0) answer = false;

    return answer;
}