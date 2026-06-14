using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public struct DotData
    {
        public int dot;
        public int dist;
    }

    public void Dfs(List<List<DotData>> island, int dot, bool[] visitor, int target, int visited,int dist, ref int min)
    {
        if (visitor[dot]) return;

        visitor[dot] = true;

        if (visited == target)
        {
            min = min > dist ? dist : min;
            visitor[dot] = false;
            return;
        }

        for (int i = 0; i < island[dot].Count; i++)
        {
            Dfs(island, island[dot][i].dot,visitor,target,visited+1, dist+ island[dot][i].dist, ref min);
        }

        visitor[dot] = false;
    }

    public int solution(int n, int[,] costs)
    {
        int answer = 0;

        List<List<DotData>> island = Enumerable.Repeat(new List<DotData>(),n).ToList();

        bool[] visitor = new bool[n];

        for(int i = 0; i < costs.Length; i++)
        {
            island[costs[i, 0]].Add(new DotData(){dot = costs[i, 1],dist = costs[i, 2]});
            island[costs[i, 1]].Add(new DotData() { dot = costs[i, 0], dist = costs[i, 2] });
        }

        answer = int.MaxValue;
        Dfs(island, 0, visitor, n, 0, 0, ref answer);

        return answer;
    }
}