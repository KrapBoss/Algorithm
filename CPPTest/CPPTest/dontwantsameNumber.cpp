#include <string>
#include <vector>

using namespace std;

/// <summary>
/// 기능 완성
/// 남은 기간 저장
/// 남은 기간을 비교해서 앞 기간이 뒷 기간보다 남은 기간이 크면 합산
/// </summary>
/// <param name="progresses"></param>
/// <param name="speeds"></param>
/// <returns></returns>

vector<int> solution(vector<int> progresses, vector<int> speeds) {
    vector<int> answer;
    vector<int> date;

    for (int i = 0; i < progresses.size(); i++) {
        //남은 작업 기간 저장
        int remainWork = (100 - progresses[i]);
        int resul = (remainWork / speeds[i]) + ((remainWork % speeds[i]) != 0 ? 1 : 0);
        date.push_back(resul);
    }

    int remain = date[0];
    int index = 0;
    for (int d : date) {
        //남은 작업 기간의 연속성으로 한번에 배포 가능한 개수를 저장
        if (d > remain) {
            index++;
            remain = d;
        }

        if (answer.size() <= index) answer.push_back(0);
        answer[index]++;
    }

    return answer;
}