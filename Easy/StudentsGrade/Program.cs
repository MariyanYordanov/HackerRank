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
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

        }

        private static List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                int currentGrade = grades[i];
                int newValueGrade = 0;
                if (currentGrade < 38)
                {
                    newValueGrade = currentGrade;
                    newGrades.Add(newValueGrade);
                    continue;
                }

                int j = 1;
                int nextGrade = grades[i] + j;
                while (nextGrade % 5 != 0)
                {
                    j++;
                    nextGrade = grades[i] + j;
                }
                                
                if (nextGrade - currentGrade < 3)
                {
                    newValueGrade = nextGrade;
                    newGrades.Add(newValueGrade);
                }
                else
                {
                    newValueGrade = currentGrade;
                    newGrades.Add(newValueGrade);
                }
            }

            return newGrades;
        }
    }
}
