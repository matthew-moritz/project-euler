using System;

namespace ProjectEuler.Problems
{
    internal class Problem003 : IProblem
    {
        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 3;

        /// <summary>
        /// The title.
        /// </summary>
        public string Title => "Largest prime factor";

        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        ///
        /// What is the largest prime factor of the number 600851475143?
        /// </summary>
        public string Solve()
        {
            const long n = 600851475143L;
            int i = (int)Math.Sqrt(n);

            while (i > 0)
            {
                if (n % i == 0 && IsPrime(i))
                    return $"{i}";

                i--;
            }
            return null;
        }

        /// <summary>
        /// Returns true if the number is prime, false otherwise.
        /// </summary>
        private bool IsPrime(long n)
        {
            if (n == 2 || n == 3) return true;

            if (n % 2 == 0) return false;

            int sqrt = (int)Math.Sqrt(n) + 1;
            for (int i = 3; i < sqrt; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
