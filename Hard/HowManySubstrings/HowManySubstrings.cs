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

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            string s = Console.ReadLine();

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = Function(s, queries);

            Console.WriteLine(String.Join("\n", result));

        }

        /*5 5
aabaa
1 1
1 4
1 1
1 4
0 2*/

        public static List<int> Function(string s, List<List<int>> queries)
        {
            List<int> query = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                int start = queries[i][0];
                int end = queries[i][1];
                int len = end - start + 1;
                StringBuilder sb = new StringBuilder(s, start, len, 1);
                HashSet<string> substrings = new HashSet<string>();
                for (int l = 1; l <= sb.Length; l++)
                {
                    for (int x = 0; x < sb.Length - (l - 1); x++)
                    {
                        StringBuilder sub = new StringBuilder(sb.ToString(), x, l, 1);
                        if (!substrings.Contains(sub.ToString()))
                        {
                            substrings.Add(sub.ToString());
                        }
                    }
                }

                query.Add(substrings.Count);
                //string currentSub = s.Substring(start,end - start + 1);

                //HashSet<string> substrings = new HashSet<string>();

                //for (int l = 1; l <= currentSub.Length; l++)
                //{
                //    for (int x = 0; x < currentSub.Length - (l - 1); x++)
                //    {
                //        string sub = currentSub.Substring(x, l);
                //        if (!substrings.Contains(sub))
                //        {
                //            substrings.Add(sub);
                //        }
                //    }
                //}

                //query.Add(substrings.Count);
            }
            query.Aggregate((a, b) => a * b);
            return query;
        }

        
    }
}
