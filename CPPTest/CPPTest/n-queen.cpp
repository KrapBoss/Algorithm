#include <string>
#include <vector>
#include <cmath>

using namespace std;

int result = 0;

static void backTracking(int& target, int count, vector<int>& arr)
{
    if (target == count)
    {
        result++;
        return;
    }

    for (int y = 0; y < target; y++)
    {   // 현재 체스를 둘 위치의 y값을 탐색

        bool able = true;

        for (int x = 0; x < count; x++)
        {   // 이전 x 위치에 있는 체스들을 탐색

            if (y == arr[x]    // 같은 선상에 있는 것을 판단하기 위함
                || 
                (count - x) == abs(y - arr[x])) // 현재 두려는 것의 대각으로 문제가 되는 부분을 찾기 위한 것이다.
            {
                able = false;   // 만약 현재 두려는 y 위치에 걸리는 부분이 있다면, 반드시 중지
                break;
            }
        }

        if (able) 
        {
            arr[count] = y;
            backTracking(target, count + 1, arr);
            arr[count] = -1;
        }
    }
}

int solution(int n) 
{
    int answer = 0;

    vector<int> arr(n, -1);

    backTracking(n, 0, arr);

    return result;
}