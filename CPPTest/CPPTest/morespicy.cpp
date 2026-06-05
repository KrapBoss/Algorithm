#include <string>
#include <vector>
#include <queue>
#include <map>
#include <set>

using namespace std;

int solution(vector<int> scoville, int K)
{
    priority_queue<int,vector<int>, greater<int>> q(scoville.begin(),scoville.end());
    queue<int> qs;
    map<int,string, greater<int>> m{ {10,"str"}};
    set<int, greater<int>> s{ 10,20 };

    auto at = s.find(10);
    if (at == s.end()) {}// °á°ú

    auto att = m.find(10);
    if (att != m.end()) att->first;

    auto resul = m.insert({ 10,"Sstt" });
    if (resul.second == false) {

    }

    int count = 0;
    while (q.size()>1)
    {
        if (q.top() >= K) break;

        int a = q.top(); q.pop();
        int b = q.top(); q.pop();

        q.push(a + b * 2);

        count++;
    }

    if (q.top() < K) count = -1;

    return count;
}