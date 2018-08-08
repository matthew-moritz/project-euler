using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.PeMath
{
    internal static class PrimeUtils
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

        /// <summary>
        /// Determines a collection of prime numbers less that the specified value n.
        /// </summary>
        public static IEnumerable<int> SieveOfEratostehenes(int n)
        {
            var values = new bool[n];
            Array.Fill(values, true);

            var max = (int)Math.Sqrt(n);

            values[0] = false;
            values[1] = false;
            for (var i = 2; i <= max; i++)
            {
                if (!values[i])
                    continue;

                for (var j = (int)Math.Pow(i, 2); j < n; j += i)
                    values[j] = false;
            }

            return values.Select((x, index) => new { x, index }).Where(y => y.x).Select(x => x.index);
        }
    }
}
