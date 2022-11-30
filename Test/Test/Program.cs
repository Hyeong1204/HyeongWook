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
            int a = solution(885733, 3);

            int solution(int n, int k)
            {
                int answer = 0;
                List<long> numList = new List<long>();
                string[] number = Convert(n,k).Split('0');

                for (int i = 0; i < number.Length; i++)
                {
                    long.TryParse(number[i], out long c);
                    if(c != 1)
                    {
                        if (c != 0)
                        {
                            numList.Add(c);
                        }
                    }
                }

                for (int i = 0; i < numList.Count; i++)
                {
                    if (SoSu(numList[i]))
                    {
                        answer++;
                    }
                }
                return answer;
            }

            string Convert(long n, long k, string str = "")
            {
                long j = n / k;                  // j에 몫저장

                str = (n % k).ToString() + str; // str에 나머지를 더함

                if(j >= k)                      // 더 나눌것이 있다면
                {
                    return Convert(j, k, str);  // 한번더
                }
                else
                {
                    return str = j.ToString() + str;    // 없다면 몫 + 지금까지 모은 str
                }
            }

            bool SoSu(long num)
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)            // 소수 판별
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

