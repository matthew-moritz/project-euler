using System;

namespace ProjectEuler.PeMath
{
    public static class Prime
    {
        /// <summary>
        /// Determines if a value is a prime number.
        /// </summary>
        public static bool IsPrime(this int n)
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

        /// <summary>
        /// Determines if a value is a prime number.
        /// </summary>
        public static bool IsPrime(this long n)
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
