/*  The sum of the squares of the first ten natural numbers is,
        12 + 22 + ... + 102 = 385
    The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)2 = 552 = 3025
    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.

    Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

using System;
using System.Diagnostics;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < Reps; i++)
            {
                program.DoProblem();
            }
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));
            Console.ReadLine();
        }

        private void DoProblem()
        {

        }
    }
}
