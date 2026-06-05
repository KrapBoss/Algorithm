using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GettingITem
{

    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY)
    {
        int size = 102;

        // 이걸 하는 이유는 같은 위치의 좌표상 공백이 하나도 없는 경우 서로 이동할 수 없는 경로임에도 이동하는 문제로 인해 이러한 방식을 취합니다.
        int multiple = 2;

        itemX *= multiple;
        itemY *= multiple;
        characterX *= multiple;
        characterY *= multiple;


        bool[,] map = new bool[size, size];
        bool[,] visitor = new bool[size, size];
        var directions = new (int x, int y)[]
                        {
                            (-1, 0),
                            (1, 0),
                            (0, -1),
                            (0, 1)
                        };

        // 전체 이동 가능 처리
        for (int i = 0; i < rectangle.GetLength(0); i++)
        {
            int leftX = rectangle[i, 0] * multiple;
            int leftY = rectangle[i, 1] * multiple;
            int rightX = rectangle[i, 2] * multiple;
            int rightY = rectangle[i, 3] * multiple;

            for (int x = leftX; x <= rightX; x++)
            {
                for (int y = leftY; y <= rightY; y++)
                {
                    map[y, x] = true;
                }
            }
        }

        // 내부 마스킹 처리
        for (int i = 0; i < rectangle.GetLength(0); i++)
        {
            int leftX = rectangle[i, 0] * multiple;
            int leftY = rectangle[i, 1] * multiple;
            int rightX = rectangle[i, 2] * multiple;
            int rightY = rectangle[i, 3] * multiple;

            for (int x = leftX + 1; x <= rightX - 1; x++)
            {
                for (int y = leftY + 1; y <= rightY - 1; y++)
                {
                    map[y, x] = false;
                }
            }
        }

        // 이동 경로 저장
        Queue<(int currX, int currY, int dist)> move = new Queue<(int currX, int currY, int dist)>();
        List<int> goalDist = new List<int>();
        move.Enqueue((characterX, characterY, 0));

        while (move.Count > 0)
        {
            var position = move.Dequeue();

            // 목적지 도달 시 저장
            if (position.currX == itemX && position.currY == itemY)
            {
                goalDist.Add(position.dist);
                continue;
            }

            // 4방향 이동 시작
            foreach (var item in directions)
            {
                if (map[position.currY + item.y, position.currX + item.x] && !visitor[position.currY + item.y, position.currX + item.x])
                {
                    move.Enqueue((position.currX + item.x, position.currY + item.y, position.dist + 1));
                    visitor[position.currY + item.y, position.currX + item.x] = true;
                }
            }
        }

        int min = goalDist.Min();
        return min / multiple;
    }
}