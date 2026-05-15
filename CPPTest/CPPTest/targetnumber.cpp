#include <string>
#include <vector>

using namespace std;

static int Check(vector<int>& numbers, int currNumber, int currIndex, int targetNumber) 
{
    if (currIndex == numbers.size()) {
       if (currNumber == targetNumber) return 1;
       return 0;
    }

    int count = 0;

    count += Check(numbers, currNumber + numbers[currIndex], currIndex + 1, targetNumber);
    count += Check(numbers, currNumber - numbers[currIndex], currIndex + 1, targetNumber);

    return count;
}

int solution(vector<int> numbers, int target) {
    int answer = 0;

    answer = Check(numbers, 0, 0, target);

    return answer;
}
