using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            string a;

            a = solution("dfjardstddetckdaccccdegk", 4);

            string solution(string cipher, int code)
            {
                {
                    // slice 조각수, n 인원수
                    string answer = "";
                    for (int i = 1; i < cipher.Length / code + 1; i++)
                    {
                        answer += cipher.Substring(i * code - 1, 1);
                    }

                    return answer;
                }
            }
        }
    }
}
