#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<vector<int>> answer(2);

// 노드 데이터로 정보를 저장합니다.
struct Node {
public:
    int Number;
    int x, y;
    Node* left  = nullptr;
    Node* right = nullptr;
};

// 항상 y값은 크다는 보장이 되어 있기 때문에, x 값을 기준으로 삽입합니다.
static void InsertNode(Node* p, Node* chill)
{
    if (p->x > chill->x)
    {
        if (p->left == nullptr) p->left = chill;
        else {
            InsertNode(p->left, chill);
        }
    }
    else
    if (p->x < chill->x)
    {
        if (p->right == nullptr) p->right = chill;
        else {
            InsertNode(p->right, chill);
        }
    }
}

// 탐색
static void dfs(Node* root)
{
    // 전위 탐색
    answer[0].push_back(root->Number);

    if (root->left != nullptr) dfs(root->left);

    if (root->right != nullptr) dfs(root->right);

    // 후위 탐색
    answer[1].push_back(root->Number);
}

bool sortMethod(Node& a, Node& b)
{
    if (a.y > b.y) return true;
    if (a.y < b.y) return false;

    return a.x < b.x;
}

vector<vector<int>> solution(vector<vector<int>> nodeinfo) 
{
    vector<Node> nodes;

    // 노드 삽입
    for (int i = 0; i < nodeinfo.size(); i++) {
        nodes.push_back({ i + 1, nodeinfo[i][0],nodeinfo[i][1] });
    }

    // 정렬을 통한 y 축 선순위 배치와 x을 작은 순서대로 정렬.
    sort(nodes.begin(), nodes.end(), sortMethod);

    // root 를 기준으로 하나씩 배치
    // logn;
    for (int i = 1; i < nodes.size(); i++) {
        InsertNode(&nodes[0], &nodes[i]);
    }

    // logn
    dfs(&nodes[0]);

    return answer;
}