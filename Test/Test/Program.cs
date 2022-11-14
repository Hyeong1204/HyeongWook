using System;
using System.Net;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            int[] b = { 10, 15, 9, 5, 23, 1 };

            int a = solution(b, 3);

            int solution(int[] array, int n)
            {
                int answer = 0;
                int count = 9999;
                
                //Array.Sort(array);

                for (int i = 0; i < array.Length; i++)
                {
                    if (count > Math.Abs(array[i] - n))
                    {
                        count = Math.Abs(array[i] - n);
                        answer = array[i];
                    }
                }

                return answer;
            }
        }
    }
}

