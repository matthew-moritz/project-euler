using ProjectEuler.PeMath;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    /// Find the sum of all the primes below two million.
    /// </summary>
    internal class Problem010 : ProblemBase
    {
        public Problem010() : base(10, "Summation of primes") { }

        /// <inheritdoc />
        public override string Solve()
        {
            var sieve = PrimeUtils.SieveOfEratostehenes(2000000);

            var sum = sieve.Select(x => new BigInteger(x)).Aggregate((current, i) => current + i);
            return $"{sum}";
        }
    }
}
