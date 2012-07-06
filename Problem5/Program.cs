/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System;
using System.Diagnostics;

namespace Problem5
{
    class Program
    {
        private const int Reps = 10000;
        private const int MaxDivisible = 20;

        static void Main(string[] args)
        {
            var program = new Program();

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < Reps; i++)
            {
                program.DoProblem2();
            }
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));
            Console.ReadLine();
        }

        private void DoProblem()
        {
            bool isDivisibleByAll = true;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                for (int div = 1; div <= MaxDivisible; div++)
                {
                    if (i % div != 0)
                    {
                        isDivisibleByAll = false;
                    }
                }

                if (isDivisibleByAll)
                {
                    Console.WriteLine(string.Format("DoProblem: {0}", i));
                    return;
                }

                isDivisibleByAll = true;
            }
        }

        // Super fast
        private void DoProblem2()
        {
            int smallest = 2;

            for (int cur = 2; cur <= MaxDivisible; cur++)
            {
                if (smallest % cur != 0)
                {
                    int multi = 2;
                    int temp = smallest;
                    while (temp % cur != 0)
                    {
                        temp = smallest * multi;
                        multi++;
                    }

                    smallest = temp;
                }
            }

            //Console.WriteLine(string.Format("DoProblem2: {0}", smallest));
        }
    }
}
