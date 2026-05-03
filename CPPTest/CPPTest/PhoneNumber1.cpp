#include <string>
#include <vector>
#include <unordered_set>
#include <algorithm>

using namespace std;


// prefix 접두어 문제는 특정 번호가 다른 번호의 앞에 포함되는지 확인이 필요.
// 정렬을 오름차순으로 하게 되면, ["119", "97674223", "1195524421"] 을 정렬 했을 때 119,  1195524421, 97674223 순으로 정렬된다.
// 그렇기에 앞에 있는 수를 뒤에 있는 수로 비교하면된다. 그럼 정렬 시간 nLogn의 복잡도로 정렬하여 N번의 반복만 하면 된다.

// 시간 초과 발생
//  n2 의 복잡도 발생 개선 필요.
bool solution(vector<string> phone_book) {
    bool answer = true;

    //내림차순으로 변경
    sort(phone_book.rbegin(), phone_book.rend());

    //97674223, 1195524421, 119 배열을 비교 
    for (int i = 0; i < phone_book.size()- 1; i++) {
        if (phone_book[i].compare(0, phone_book[i + 1].size(), phone_book[i + 1]) == 0) {
            return true;
        }
    }

    return false;
}


// 시간 초과 발생
//  n2 의 복잡도 발생 개선 필요.
bool solution(vector<string> phone_book) {
    bool answer = true;

    for (int i = 0; i < phone_book.size(); i++) {

        for (int j = i + 1; j < phone_book.size(); j++) {

            string* temp = &phone_book.at(i);
            string* compare = &phone_book.at(j);

            if ((*temp).size() < (*compare).size()) {
                temp = &phone_book.at(j);
                compare = &phone_book.at(i);
            }

            if (temp->compare(0, (*compare).size(), *compare) == 0) {
                answer = false;
                break;
            }
        }

        if (answer == false) break;
    }

    return answer;
}