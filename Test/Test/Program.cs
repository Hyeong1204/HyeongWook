using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            string[] b = { "programmer02", "1145"};
            string[,] c = { { "programmer02", "111111" }, { "programmer00", "134" }, { "programmer01", "1145" } };

            string a = solution(b, c);

            string solution(string[] id_pw, string[,] db)
            {
                string answer = "fail";
                for (int j = 0; j < db.Length >> 1; j++)
                {
                    if (id_pw[0] == db[j, 0])
                    {
                        answer = "wrong pw";
                        if (id_pw[1] == db[j, 1])
                        {
                            answer = "login";
                        }
                    }
                }
                

                return answer;
            }
        }
    }
}

