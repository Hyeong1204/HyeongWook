using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            int[,] b = { { 80, 70 }, { 70, 80 }, { 30, 50 }, { 90, 100 }, { 100, 90 }, { 100, 100 }, { 10, 30 } };
            int[] a = solution(b);

            int[] solution(int[,] score)
            {
                int[] sum = new int[score.Length>>1];
                int[] rank= new int[score.Length>>1];
                int count = 1;
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = score[i, 0] + score[i, 1];
                }

                for (int i = 0; i < rank.Length; i++)
                {
                    for (int j = 0; j < rank.Length; j++)
                    {
                        if(i != j)
                        {
                            if (sum[i] < sum[j])
                            {
                                count++;
                            }
                        }
                    }
                    rank[i] = count;
                    count = 1;
                }

                return rank;
            }
        }
    }
}

