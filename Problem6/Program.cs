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
        private const int Reps = 100000000;
        private const int MaxNatural = 100;

        static void Main(string[] args)
        {
            var program = new Program();

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < Reps; i++)
            {
                //program.DoProblem();
                program.DoProblem3();
            }
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));
            Console.ReadLine();
        }

        private void DoProblem()
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            for (int i = 0; i <= MaxNatural; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            squareOfSums *= squareOfSums;

            //Console.WriteLine(string.Format("sumOfSquares: {0}", sumOfSquares));
            //Console.WriteLine(string.Format("squareOfSums: {0}", squareOfSums));
            //Console.WriteLine(string.Format("Result: {0}", squareOfSums - sumOfSquares));
        }

        //My answer in Toulon (France)
        //I think that we can answer for all number n :
        //I call S1 the sum 1+2+3+...+n
        //I call S2 the sum 1²+2²+3²+....+n²
        //We have to calculate (S1)²-S2.
        //But S1 = n(n+1)/2 and S2= n(n+1)(2n+1)/6 so 
        //(S1)²-S2=n²(n+1)²/4-n(n+1)(2n+1)/6 = (n-1)n(n+1)(3n+2)/12
        //For all n, the result is (n-1)n(n+1)(3n+2)/12.
        //For n=100, the result is 99x100x101x302/12 =25164150
        private void DoProblem2()
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            sumOfSquares = (MaxNatural * (MaxNatural + 1) * ((2 * MaxNatural) + 1)) / 6;

            squareOfSums = (MaxNatural * (MaxNatural + 1)) / 2;
            squareOfSums *= squareOfSums;

            //Console.WriteLine(string.Format("sumOfSquares: {0}", sumOfSquares));
            //Console.WriteLine(string.Format("squareOfSums: {0}", squareOfSums));
            //Console.WriteLine(string.Format("Result: {0}", squareOfSums - sumOfSquares));
        }

        private void DoProblem3()
        {
            int total = ((MaxNatural - 1) * MaxNatural * (MaxNatural + 1) * ((3 * MaxNatural) + 2)) / 12;

            //Console.WriteLine(string.Format("sumOfSquares: {0}", sumOfSquares));
            //Console.WriteLine(string.Format("squareOfSums: {0}", squareOfSums));
            //Console.WriteLine(string.Format("Result: {0}", total));
        }
    }
}
