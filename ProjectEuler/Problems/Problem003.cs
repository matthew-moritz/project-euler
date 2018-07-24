﻿using System;

namespace ProjectEuler.Problems
{
    internal class Problem003 : IProblem
    {
        private const long VALUE = 600851475143;
        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 3;

        /// <summary>
        /// The title of the problem.
        /// </summary>
        public string Title => "Largest prime factor";

        /// <summary>
        /// Solves the problem.
        /// </summary>
        public string Solve()
        {
            var i = (int)Math.Sqrt(VALUE);

            while (i > 0)
            {
                if (VALUE % i == 0 && IsPrime(i))
                    return $"{i}";
                i--;
            }

            return string.Empty;
        }

        /// <summary>
        /// Determines if a value is a prime number.
        /// </summary>
        private bool IsPrime(long n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(n) + 1;
            for (var i = 3; i < sqrt; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
