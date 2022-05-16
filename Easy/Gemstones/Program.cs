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
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> arr = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string arrItem = Console.ReadLine();
                arr.Add(arrItem);
            }

            int result = Gemstones(arr);

            Console.WriteLine(result);

        }

        /*3
abcdde
baccd
eeabg*/

        private static int Gemstones(List<string> arr)
        {
            int counterGemstones = 0;
            for (int i = 97; i <= 122; i++)
            {
                int counterMinerals = arr.Count;
                for (int j = 0; j < arr.Count; j++)
                {
                    string currentRock = arr[j];
                    for (int r = 0; r < currentRock.Length; r++)
                    {
                        if (currentRock[r] == i)
                        {
                            counterMinerals--;
                            if (counterMinerals == 0)
                            {
                                counterGemstones++;
                            }

                            break;
                        }
                        
                    }
                }
            }

            return counterGemstones;
        }
    }
}
