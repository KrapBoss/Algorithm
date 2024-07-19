using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    /*
    internal class E2775 // 부녀회장이 될테야
    {
        //rooms[$"00{i:D2}"] = i;
        static void Main(string[] args)
        {
            int iter = int.Parse(Console.ReadLine());

            int[,] rooms = new int[15,14];
            for (int i = 0; i < 14; i++) { rooms[0, i] = i+1; }
            
            for (int i = 1;i < 15; i++)//1층부터 14층까지
            {
                for (int j = 0; j < 14; j++)//1호부터 14호까지
                {
                    if (j == 0) rooms[i, j] = rooms[i - 1, 0];
                    else rooms[i, j] = rooms[i - 1, j] + rooms[i, j - 1];
                }
            }

            for (int i = 0;i < iter; i++) { 
                int floor = int.Parse(Console.ReadLine());
                int room = int.Parse(Console.ReadLine()) -1;
                Console.WriteLine(rooms[floor, room]);
            }
        }
    }
    */
}