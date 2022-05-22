using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Anagram(s);

                Console.WriteLine(result);
            }


        }

/*
3
asdfjoieufoa
fdhlvosfpafhalll
mvdalvkiopaufl
*/

        private static int Anagram(string s)
        {
            if (s.Length % 2 != 0)
            {
                return -1;
            }
            else
            {
                int counter = 0;
                int step = s.Length / 2;
                string left = s.Substring(0, step);
                string right = s.Substring(step, step);
                Dictionary<char, int> charList = new Dictionary<char, int>();
                for (int i = 0; i < right.Length; i++)
                {
                    if (!charList.ContainsKey(right[i]))
                    {
                        charList.Add(right[i],1);
                    }
                    else
                    {
                        charList[right[i]]++;
                    }
                }

                for (int i = 0; i < left.Length; i++)
                {
                    if (charList.ContainsKey(left[i]))
                    {
                        charList[left[i]]--;
                        if (charList[left[i]] < 0)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        counter++;
                    }
                }

                return counter;
            }
            
        }
    }
}
