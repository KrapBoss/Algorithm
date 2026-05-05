#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int solution(vector<vector<string>> clothes) {
    unordered_map<string, int> _map;

    for (auto arr : clothes) {
        _map[arr[1]]++;
    }

    //모든 경우에 수에서, 각 파츠를 입지 않는 경우 +1 를 한 모든 경우를 구하고
    // 하나의 옷도 입지 않은 예외를 제거
    int range = 1;
    for (auto arr : _map) {
        range *= arr.second + 1;
    }

        
    return range-1;
}