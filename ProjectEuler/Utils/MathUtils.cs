using System;
using System.Collections.Generic;

namespace ProjectEuler.Utils
{
    internal static class MathUtils
    {
        public static IEnumerable<int> GetFactors(int n )
        {
            var factors = new List<int>();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);

                    if (n / i != i)
                        factors.Add(n / i);
                }
            }

            factors.Sort();

            return factors;
        }
    }
}
