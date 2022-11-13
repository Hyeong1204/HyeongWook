using System;
using System.Net;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            int[,] b = { {3, 5 }, { 4, 1 }, { 2, 4 }, { 5, 10 } };

            int a = solution(b);

            int solution(int[,] dots)
            {
                int answer = 0;

                if (((double)dots[1, 1] - dots[0, 1]) / ((double)dots[1, 0] - dots[0, 0]) == ((double)dots[3, 1] - dots[2, 1]) / ((double)dots[3, 0] - dots[2, 0]))
                {
                    return 1;
                }
                if (((double)dots[2, 1] - dots[0, 1]) / ((double)dots[2, 0] - dots[0, 0]) == ((double)dots[3, 1] - dots[1, 1]) / ((double)dots[3, 0] - dots[1, 0]))
                {
                    return 1;
                }

                return answer;
            }
        }
    }
}

