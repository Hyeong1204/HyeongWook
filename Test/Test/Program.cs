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
            
            a = solution(2000);

            int[] solution(int money)
            {
                int[] answer = new int[2];      // 배열 생성
                   
                answer[0] = money / 5500;       // 몇 잔
                answer[1] = money % 5500;       // 거스름 돈

                return answer;
            }
        }
    }
}
