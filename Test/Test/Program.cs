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
            string b = "1 1 1 1 1 Z Z Z Z 1";
            int a = solution(b);

            int solution(string s)
            {
                int answer = 0;
                int Num = 0;
                List<int> templist = new List<int>();
                int count = 0;
                string[] word = s.Split(' ');

                for (int i = 0; i < word.Length; i++)
                {
                    if(i == 0 && word[0] == "Z")
                    {
                        continue;
                    }
                    if(i != 0 && word[i] == "Z" && word[i - 1] == "Z")
                    {
                        count++;

                        if(answer == 0)
                        {
                            continue;
                        }

                        answer -= templist[templist.Count - count - 1];

                        continue;
                    }
                    if (int.TryParse(word[i], out Num))
                    {
                        answer += Num;
                        templist.Add(Num);
                        count = 0;
                    }
                    else
                    {
                        answer = answer - templist.Last();
                    }
                }

                return answer;
            }
        }
    }
}

