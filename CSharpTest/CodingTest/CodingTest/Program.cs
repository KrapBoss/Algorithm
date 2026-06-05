using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[,] jobs)
    {
        int cumulatV = 0;
        int workLength = jobs.GetLength(0);
        int addAllWork = 0;

        // 1. 요청 시간순 정렬
        List<(int x, int y)> job = new List<(int x, int y)>();
        for (int i = 0; i < workLength; i++)
        {
            job.Add((jobs[i, 0], jobs[i, 1]));
        }
        job.Sort((a, b) => a.x.CompareTo(b.x));

        // 2. PriorityQueue 대신 일반 List를 대기열로 사용
        List<(int x, int y)> waitingQueue = new List<(int x, int y)>();

        int jobIndex = 0;
        int completed = 0;

        while (completed < workLength)
        {
            // 현재 시간까지 들어온 작업을 대기열에 다 집어넣음
            while (jobIndex < workLength && job[jobIndex].x <= cumulatV)
            {
                waitingQueue.Add(job[jobIndex]);
                jobIndex++;
            }

            if (waitingQueue.Count > 0)
            {
                // 대기열 중에서 '소요 시간(y)'이 가장 작은 놈을 선형 탐색으로 찾음
                // 데이터가 아주 많지 않다면 이 방식이 가장 안전하고 빠릅니다.
                var item = waitingQueue.OrderBy(w => w.y).First();
                waitingQueue.Remove(item); // 큐에서 탈출

                int workReturn = cumulatV + item.y;
                addAllWork += workReturn - item.x;
                cumulatV = workReturn;
                completed++;
            }
            else
            {
                // 대기열이 비었다면 다음 작업 요청 시간으로 점프
                cumulatV = job[jobIndex].x;
            }
        }

        return addAllWork / workLength;
    }
}