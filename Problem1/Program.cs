using System;
using System.Diagnostics;

namespace Problem1
{
    class Program
    {
        private const int Max = 100000000;

        private long _total;

        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            var program = new Program();
            program.DoProblem();
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));

            stopWatch.Reset();
            stopWatch.Start();
            program.DoProblem2();
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem2: {0} ms", stopWatch.ElapsedMilliseconds));

            Console.ReadLine();
        }

        private void DoProblem()
        {
            _total = 0;

            for (int i = 1; i < Max; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    _total += i;
                }
            }

            Console.WriteLine(string.Format("Total: {0}", _total));
        }

        private void DoProblem2()
        {
            _total = 0;

            _total = SumDivisibleBy(3) + SumDivisibleBy(5) - SumDivisibleBy(15);

            Console.WriteLine(string.Format("Total: {0}", _total));
        }

        private long SumDivisibleBy(long n)
        {
            long p = Max/n;
            return n*(p*(p + 1))/2;
        }
    }
}
