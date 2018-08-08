using ProjectEuler.PeMath;
using System;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    /// What is the largest prime factor of the number 600851475143?
    /// </summary>
    internal class Problem003 : ProblemBase
    {
        public Problem003() : base(3, "Largest prime factor") { }

        /// <inheritdoc />
        public override string Solve()
        {
            const long VALUE = 600851475143;

            var i = (int)Math.Sqrt(VALUE);
            while (i > 0)
            {
                if (VALUE % i == 0 && i.IsPrime())
                    return $"{i}";
                i--;
            }

            return string.Empty;
        }
    }
}
