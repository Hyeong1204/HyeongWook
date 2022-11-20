using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] age)
        {
            string b = ".... . .-.. .-.. ---";

            string a = solution(b);

            string solution(string letter)
            {
                string answer = "";
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                    "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                    "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

                string[] morses = letter.Split(' ');

                Dictionary<string,char> map = new Dictionary<string, char>();
                for (int i = 0; i < morse.Length; i++)
                {
                    map.Add(morse[i], Convert.ToChar(97+i));
                }

                for (int i = 0; i < morses.Length; i++)
                {
                    foreach (var item in map)
                    {
                        if (morses[i] == item.Key)
                        {
                            answer += item.Value;
                        }
                    }
                }

                return answer;
            }
        }
    }
}

