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
            int[] a;
            int[] b = { 1, 2, 100, -99, 1, 2, 3 };
            a = solution(b);

            int[] solution(int[] numbers)
            {
                int[] answer = new int[numbers.Length];         // 입력 배열 크기만큼 생성

                for (int i = 0; i < numbers.Length; i++)
                {
                    answer[i] = numbers[i] *= 2;
                }

                return answer;
            }
        }
    }
}
