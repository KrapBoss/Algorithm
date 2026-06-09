using System;
using System.Collections.Generic;
using System.Linq;

public class Graph
{
    public int solution(int n, int[,] edge)
    {
        int startV = 1;

        Queue<int> schedule = new Queue<int>();

        List<List<int>> _edge = Enumerable.Range(0, n + 1).Select(_ => new List<int>()).ToList();

        // 모든 점에서의 노드값을 저장합니다.
        for (int i = 0; i < edge.GetLength(0); i++)
        {
            int sv = edge[i, 0];
            int ev = edge[i, 1];
            _edge[sv].Add(ev);
            _edge[ev].Add(sv);
        }

        schedule.Enqueue(startV);

        // 모든 거리 값 초기화
        int[] dist = Enumerable.Repeat(-1, n + 1).ToArray();
        dist[startV] = 0;

        //여기서는 모든 노드를 방문 할 때, 최적의 노드라 가정한다면, BFS 방식으로 노드를 접근해서 카운트를 세아립니다.
        while (schedule.Count > 0)
        {
            int currVertex = schedule.Dequeue();

            for (int i = 0; i < _edge[currVertex].Count; i++)
            {
                if (dist[_edge[currVertex][i]] == -1)
                {
                    dist[_edge[currVertex][i]] = dist[currVertex] + 1;
                    schedule.Enqueue(_edge[currVertex][i]);
                }
            }
        }

        int max = dist.Max();

        return dist.Count(x => x == max);
    }
}