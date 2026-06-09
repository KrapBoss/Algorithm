using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DoublePriorityQueue
    {
        public int[] solution(string[] operations)
        {
            int[] answer = new int[] { };

            // 항상 logN의 정렬을 보장하기 위한 방식
            // 0을 넣으면, 같은 데이터라 판단해서 데이터를 제거해버림, 그렇기 때문에 0일 경우 Id 값을 비교
            SortedSet<(int v, int id)> sts = new SortedSet<(int v, int id)>(Comparer<(int v, int id)>.Create((x, y) =>
            {
                int mp = x.v.CompareTo(y.v);

                return mp == 0 ? x.id.CompareTo(y.id) : mp;
            }));

            SortedSet<int> ss = new SortedSet<int>(Comparer<int>.Create((x, y) => { return x.CompareTo(y); }));

            int count = 0;

            foreach (string operation in operations)
            {
                string[] split = operation.Split(' ');
                string command = split[0];
                int _value = int.Parse(split[1]);

                if (command.Equals("D"))
                {
                    if (sts.Count == 0) continue;

                    switch (_value)
                    {
                        case 1:
                            sts.Remove(sts.Max);
                            break;
                        case -1:
                            sts.Remove(sts.Min);
                            break;
                    }
                }
                else
                    if (command.Equals("I"))
                    {
                        sts.Add((_value, count++));
                    }
            }

            if (sts.Count == 0) answer = new int[] { 0, 0 };
            else { answer = new int[] { sts.Max.v, sts.Min.v }; }

            return answer;
        }
    }
}
