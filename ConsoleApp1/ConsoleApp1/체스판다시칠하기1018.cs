using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using System.Linq;

namespace consoleapp1
{
    internal class 체스판다시칠하기1018
    {
        static void Main(string[] args)
        {
            string[] input(StreamReader s) => s.ReadLine().Split();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                int[] arr = Array.ConvertAll(input(sr), int.Parse);

                //int[] W = { 87,66 };
                int[] B = { 66,87 };

                int[][] map = new int[arr[0]][];
                for(int i =0; i < arr[0]; i++)
                {
                    map[i] = input(sr)[0].Select(num => (int)num).ToArray();
                
                }

                int[,] BW = new int[arr[0], arr[1]];
                //int[,] WB = new int[arr[0], arr[1]];

                //B - W  순서를 고려하여 현재 위치의 값이 바르다면 0 틀리다면 1을 저장
                for (int i =0; i< arr[0]; i++)
                {
                    for(int j = 0; j < arr[1]; j++)
                    {
                        BW[i,j] = map[i][j] != B[(i+j) % 2] ? 1 : 0;
                        //WB[i,j] = map[i][j] != W[i+j % 2] ? 1 : 0;
                    }
                }

                //Row와 Colume값의 판단을 위해 최대값을 지정합니다.
                int x = arr[0] - 8 + 1;
                int y= arr[1] - 8 + 1;

                int min = 65;

                //8x8 배열에 대해 최소값을 판단합니다.
                for( int i = 0; i < x; i++)
                {
                    for(int j = 0;j < y; j++)
                    {
                        //[i+8 , j+8] 번째의 배열까지의 값들을 모두 더한다.
                        int sum = Enumerable.Range(i,8)
                            .SelectMany(row => Enumerable.Range(j, 8)
                                                       .Select(col => BW[row,col]))
                            .Sum();

                        //가장 작은 수정치를 판단
                        min = Math.Min(min, Math.Min(sum, 64 - sum));
                    }
                }

                Console.Write(min);
            }
        }
    }
}
