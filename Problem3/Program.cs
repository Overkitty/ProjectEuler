/* The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143? */

using System;
using System.Diagnostics;

namespace Problem3
{
    class Program
    {
        private const long Max = 600851475143;
        private const int Reps = 1;

        private long largest;

        static void Main(string[] args)
        {
            var program = new Program();

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < Reps; i++)
            {
                program.DoProblem2();
            }
            stopWatch.Stop();

            Console.WriteLine(string.Format("Largest: {0}", program.largest));
            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));
            Console.ReadLine(); 
        }

        private void DoProblem()
        {
            RecursiveFactor(Max);
        }

        private void RecursiveFactor(long number)
        {
            // Find smallest prime factor
            for (long i = 2; i < Max; i++)
            {
                if(number % i == 0)
                {
                    long result = number / i;
                    if(IsPrime(result))
                    {
                        // If bigger than largest, set it to largest
                        if(result > largest)
                        {
                            largest = result;
                        }                      
                    }
                    else
                    {
                        // Recurse
                        RecursiveFactor(result);
                    }

                }
            }
        }

        private void DoProblem2()
        {
            RecursiveFactor2(Max);
        }

        private void RecursiveFactor2(long number)
        {
            long square = (long) Math.Sqrt(number);

            for (long i = square; i > 1; i--)
            {
                if (number % i == 0)
                {
                    if (IsPrime(i))
                    {
                        if (i > largest)
                        {
                            largest = i;
                            return;
                        }
                    }
                }
            }
        }

        private bool IsPrime(long result)
        {
            for (long i = 3; i < result; i += 2)
            {
                if (result % i == 0)
                    return false;
            }

            return true;
        }
    }
}
