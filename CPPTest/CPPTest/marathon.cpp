#include <iostream>
#include<vector>
#include <string>
#include <map>
#include <unordered_map>

using namespace std;


string solution(vector<string> participant, vector<string> completion) {
    string answer = "";

    unordered_map<string, int> table;

    for (string p : participant) {
        table[p] += 1;
    }

    for (string c : completion) {
        table[c] -= 1;
    }

    for (auto& c : table) {
        if (c.second > 0) {
            answer = c.first;
            break;
        }
    }

    return answer;
}