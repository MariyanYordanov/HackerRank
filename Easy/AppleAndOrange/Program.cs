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
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }


/*
7 11
5 15
3 2
-2 2 1
5 -6
*/



        private static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            List<int> falenApples = apples.Select(x => x += a).ToList();
            List<int> falenOrange = oranges.Select(o => o += b).ToList();
            int appleOnTheRoof = 0;
            int orangeOnTheRoof = 0;
            foreach (var apple in falenApples)
            {
                if (apple >= s && apple <= t)
                {
                    appleOnTheRoof++;
                }
            }

            foreach (var orange in falenOrange)
            {
                if (orange >= s && orange <= t)
                {
                    orangeOnTheRoof++;
                }
            }

            Console.WriteLine(appleOnTheRoof);
            Console.WriteLine(orangeOnTheRoof);
        }

    }
}
