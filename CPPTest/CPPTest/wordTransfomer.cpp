#include <string>
#include <vector>

using namespace std;

vector<bool> visited;
int regist = 99;

static bool check(string& a, string& b)
{
    int diff = 0;
    for (int i = 0; i < a.size(); i++)
    {
        diff += a[i] == b[i] ? 0 : 1;

        if (diff > 1) return false;
    }
    return true;
}

static void dfs(string begin, string& target, vector<string>& words, int count)
{
    if (begin == target)
    {
        if (regist > count) regist = count;
        return;
    }

    for (int i = 0; i< words.size() ; i++)
    {
        if (visited[i]) continue;

        if (check(begin, words[i]))
        {
            visited[i] = true;
            dfs(words[i], target, words, count+1);
            visited[i] = false;
        }
    }
}


int solution(string begin, string target, vector<string> words)
{
    int answer = 0;

    visited = vector<bool>(words.size(), false);

    dfs(begin, target, words, 0);

    if (regist == 99) regist = 0;
    return regist;
}