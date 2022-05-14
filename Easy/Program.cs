using System;
using System.Text;

namespace HackerRankEasyLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            
            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = TheLoveLetterMystery(s);

                Console.WriteLine(result);
            }

        }
        /* 4
abc
abcba
abcd
cba*/
        private static int TheLoveLetterMystery(string s)
        {
            int counter = 0;
            
            for (int i = 0; i < s.Length / 2; i++)
            {
                char currentLetter = s[i];
                char nextLetter = s[i + 1];
                char lastLetter = s[s.Length - 1 - i];
                char preLastChar = s[s.Length - 2 - i];
                if (currentLetter < lastLetter)
                {
                    while (currentLetter < lastLetter)
                    {
                        lastLetter--;
                        counter++;
                    }

                }
                else if (currentLetter > lastLetter)
                {
                    while (currentLetter > lastLetter)
                    {
                        currentLetter--;
                        counter++;
                    }

                }
                
            }

            return counter;
        }
    }
}
