using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            string[] b = { "We", "are", "the", "world!" };

            int[] a = solution(b);

            int[] solution(string[] strlist)
            {
                int[] answer = new int[strlist.Length];

                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = strlist[i].Length;
                }

                return answer;
            }
        }
    }
}
