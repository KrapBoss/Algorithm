#include <string>
#include <vector>
#include <unordered_map>
#include <algorithm>

using namespace std;


struct Music {
public:
    string name;
    int count;
    int index;
};

// 1. 속한 장르가 많이 재생된 순
// 2. 장르내 노래 재생횟수
// 3. 장르 내 재생횟수가 같으면 고유 번호 순으로 수록

vector<int> solution(vector<string> genres, vector<int> plays) {

    unordered_map<string, int> _map;
    vector<Music> _arr;

    for (int i = 0; i < genres.size(); i++) {
        _map[genres[i]] += plays[i];
        Music m;
        m.name = genres[i];
        m.count = plays[i];
        m.index = i;
        _arr.push_back(m);
    }

    // 커스텀 정렬 실행
    sort(_arr.begin(), _arr.end(), [&_map](const Music& m1, const Music& m2)
        {
            //서로 다른 장로 많이 재생된 순서
            if (_map[m1.name] > _map[m2.name]) return true;
            else if (_map[m1.name] < _map[m2.name]) return false;

            // 장르 내 많이 재생된 순서
            if (m1.count != m2.count) return (m1.count > m2.count);

            // 장르 내 고유 번호가 빠른 순
            return (m1.index < m2.index);
        }
    );

    vector<int> sortedIndex;
    string name = "";
    int cnt;
    const int maxCnt = 2;

    for (Music& m : _arr) {

        //다른 이름일 경우 초기화
        if (name != m.name)
        {
            name = m.name;
            cnt = 0;
        }

        // 횟수 2회 제한
        if (cnt >= maxCnt) continue;

        // 2회까지만 기록
        cnt++;
        sortedIndex.push_back(m.index);
    }

    return sortedIndex;
}
