using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            int[] b = { -3,-1,0,2 };
            int[] c = {1,2,3,4};
            int a = solution(c, b);

            int solution(int[] d, int[] f)
            {
                int answer = 0;

                for (int i = 0; i < d.Length; i++)
                {

                    answer += d[i] * f[i];

                }

                return answer;
            }
        }
    }
}

