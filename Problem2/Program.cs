using System;
using System.Diagnostics;

namespace Problem2
{
    class Program
    {
        private const long Max = 4000000;
        private const int Reps = 1000000;

        private long _total;
        private int _step;

        static void Main(string[] args)
        {
            var program = new Program();

            Stopwatch stopWatch = Stopwatch.StartNew();
            for (int i = 0; i < Reps; i++ )
            {
                // program.DoProblem();
                program.DoProblem2();
            }
            stopWatch.Stop();

            Console.WriteLine(string.Format("DoProblem: {0} ms", stopWatch.ElapsedMilliseconds));
            Console.ReadLine();
        }

        private void DoProblem()
        {
            long small = 1;
            long big = 2;

            _total = 0;
            while (big < Max)
            {
                if(big % 2 == 0)
                {
                    _total += big;
                }

                long temp = small + big;
                small = big;
                big = temp;
            }

            // Console.WriteLine(string.Format("Total: {0}", _total));
        }

        private void DoProblem2()
        {
            long small = 1;
            long big = 2;

            _total = 0;
            _step = 3;
            while (big < Max)
            {
                if (_step == 3)
                {
                    _total += big;
                    _step = 0;
                }

                _step++;

                long temp = small + big;
                small = big;
                big = temp;
            }

            // Console.WriteLine(string.Format("Total2: {0}", _total));
        }
    }
}
