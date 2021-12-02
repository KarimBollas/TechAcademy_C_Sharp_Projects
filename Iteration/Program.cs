using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Iteration");
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i=0; i<testScores.Length; i++)
            {
                if (testScores[i]>85)
                {
                    Console.WriteLine("Passing test score: "+ testScores[i]);
                }                
            }

            string[] names = {"David", "Carlos", "Engels", "Mayra" };

            for (int j=0; j< names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            */

            List<int> testScores = new List<int>();
            List<int> passingScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: "+ score);
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);

            List<string> names = new List<string>() { "David", "Carlos", "Engels", "Mayra" };

            foreach (string name in names)
            {                
                Console.WriteLine(name);
            }






        }
    }
}
