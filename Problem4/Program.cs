/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System;
using System.Diagnostics;

namespace Problem4
{
    class Program
    {
        private const int Reps = 10;

        private int _num1;
        private int _num2;

        private int _largePali;
        private int _large1;
        private int _large2;

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
            _largePali = 0;
            _large1 = 0;
            _large2 = 0;

            _num1 = 100;
            while (_num1 <= 999)
            {
                int multiple = _num1 * _num2;
                if (IsPalindrome(multiple) && multiple > _largePali)
                {
                    _largePali = multiple;
                    _large1 = _num1;
                    _large2 = _num2;
                }

                _num2 = 100;
                while (_num2 <= 999)
                {
                    multiple = _num1 * _num2;
                    if (IsPalindrome(multiple) && multiple > _largePali)
                    {
                        _largePali = multiple;
                        _large1 = _num1;
                        _large2 = _num2;
                    }

                    _num2++;
                }

                _num1++;
            }

            Console.WriteLine(string.Format("Large Pali: {0}", _largePali));
            Console.WriteLine(string.Format("Large 1: {0}", _large1));
            Console.WriteLine(string.Format("Large 2: {0}", _large2));
        }

        private void DoProblem2()
        {
            _largePali = 0;
            _large1 = 0;
            _large2 = 0;

            // Same numbers
            _num1 = 100;
            while (_num1 <= 999)
            {
                int multiple = _num1 * _num1;
                if (IsPalindrome(multiple) && multiple > _largePali)
                {
                    _largePali = multiple;
                    _large1 = _num1;
                    _large2 = _num1;
                }

                _num1++;
            }

            // _num1 always even
            _num1 = 100;
            while (_num1 <= 999)
            {
                int multiple = _num1 * _num2;
                if (IsPalindrome(multiple) && multiple > _largePali)
                {
                    _largePali = multiple;
                    _large1 = _num1;
                    _large2 = _num2;
                }

                // _num2 always odd
                _num2 = 101;
                while (_num2 <= 999)
                {
                    multiple = _num1 * _num2;
                    if (IsPalindrome(multiple) && multiple > _largePali)
                    {
                        _largePali = multiple;
                        _large1 = _num1;
                        _large2 = _num2;
                    }

                    _num2 += 2;
                }
                _num2 = 101;

                _num1 += 2;
            }

            Console.WriteLine(string.Format("Large Pali: {0}", _largePali));
            Console.WriteLine(string.Format("Large 1: {0}", _large1));
            Console.WriteLine(string.Format("Large 2: {0}", _large2));
        }

        private bool IsPalindrome(int number)
        {
            int temp = number;
            int reverse = 0;
            int mod = 0;

            while (temp > 0)
            {
                mod = temp % 10;
                reverse = (reverse * 10) + mod;
                temp = temp / 10;
            }

            if (number == reverse)
            {
                return true;
            }

            return false;
        }
    }
}
