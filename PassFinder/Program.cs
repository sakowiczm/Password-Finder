using System;
using System.Collections.Generic;
using System.Linq;

namespace PassFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Version1();
            var result2 = Version2();

            Console.WriteLine("Version 1: " + string.Join(", ", result1));
            Console.WriteLine("Version 2: " + string.Join(", ", result2));
            
        }

        public static IEnumerable<string> Version1()
        {
            // first number
            foreach (int a in Enumerable.Range(1, 9))
            {
                foreach (int b in Enumerable.Range(a + 1, 9 - a))
                {
                    int mab = a * b;

                    foreach (int c in Enumerable.Range(b + 1, 9 - b))
                    {
                        int d = mab - c;

                        if (d > c && d < 10)
                            yield return string.Format("{0}{1}{2}{3}", a, b, c, d);
                    }
                }
            }
        }

        public static IEnumerable<string> Version2()
        {
            var range = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            // first number
            foreach (int a in range)
            {
                foreach (int b in range.Where(r => r > a))
                {
                    int mab = a * b;

                    foreach (int c in range.Where(r => r > b))
                    {
                        int d = mab - c;

                        if (d > c && d < 10)
                            yield return string.Format("{0}{1}{2}{3}", a, b, c, d);
                    }
                }
            }
        }

    }
}
