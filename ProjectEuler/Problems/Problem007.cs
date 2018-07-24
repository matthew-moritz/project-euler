using System;

namespace ProjectEuler.Problems
{
    internal class Problem007 : IProblem
    {
        private const int MAX_VALUE = 10001;

        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 7;

        /// <summary>
        /// THe title of the problem.
        /// </summary>
        public string Title => "10001st prime";

        /// <summary>
        /// Sovles the problem.
        /// </summary>
        public string Solve()
        {
            var count = 0;
            var number = 1;

            while(count < MAX_VALUE)
            {
                number++;
                if (IsPrime(number))
                    count++;
            }

            return $"{number}";
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
