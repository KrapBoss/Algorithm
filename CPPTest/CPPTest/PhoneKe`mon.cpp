#include <vector>
#include <unordered_set>
#include <algorithm>

using namespace std;

int solution(vector<int> nums)
{
    int answer = 0;

    unordered_set<int> _map(nums.begin(), nums.end());

    int half = nums.size() / 2;
    answer = min(half, (int)_map.size());

    return answer;
}

// unordered_set 은 정렬되지 않은 유니크한 값을 저장