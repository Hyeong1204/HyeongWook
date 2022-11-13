using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            int b = 3;
            string c = "abcdef123";
            string[] a = solution(c, b);

            string[] solution(string my_str, int n)
            {
                int ea = c.Length % n == 0 ? c.Length / n : c.Length / n + 1;

                string[] answer = new string[ea];

                for (int i = 0; i < answer.Length; i++)
                {
                    if(answer.Length - 1 == i)
                    {
                        answer[i] = my_str.Substring(i * n, my_str.Length - i * n);
                        break;
                    }

                    answer[i] = my_str.Substring(i * n, n);
                }

                return answer;
            }
        }
    }
}
