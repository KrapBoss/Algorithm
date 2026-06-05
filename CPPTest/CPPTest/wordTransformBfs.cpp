#include <string>
#include <vector>
#include <queue>

using namespace std;

vector<int> dist;
queue<int> m_queue;

static bool check(string& a, string& b) 
{
    int diff = 0;
    for (int i = 0; i < a.size(); i++)
    {
        if (a[i] != b[i]) diff++;

        if (diff > 1) return false;
    }
    return true;
}

/// <summary>
/// bfs는 현재 값에서 이동 가능한 위치로 제일 먼저 자리를 선점하기 때문에
/// 항상 최소한의 값만 가지고 이동할 수 있다.
/// 그렇기에 bfs로 탐색 시 최소값에 대한 비교는 필요없이, 현재 이동한 위치에서의 값만 지정하면 된다.
/// </summary>
/// <param name="begin"></param>
/// <param name="target"></param>
/// <param name="words"></param>
/// <returns></returns>
static int bfs(string& begin, string& target, vector<string>& words)
{
    for (int i = 0; i < words.size(); i++) 
    {
        if (check(begin, words[i])) {
            m_queue.push(i);
            dist[i] = 1;
        }
    }

    int count = 0;

    while (m_queue.size() > 0)
    {
        int index = m_queue.front();
        m_queue.pop();

        if (words[index] == target)
        {   // 정답 체크
            count = dist[index];
            break;
        }

        for (int i = 0; i < words.size(); i++)
        {   // 각 거리 기록
            if (dist[i] < 0 && check(words[index], words[i]))
            {
                m_queue.push(i);
                dist[i] = dist[index] + 1;
            }
        }
    }

    return count;
}

int solution(string begin, string target, vector<string> words)
{
    int answer = 0;
    dist = vector<int>(words.size(), -1);

    return bfs(begin, target, words);
}