using ProjectEuler.PeMath;
using System;

namespace ProjectEuler.Problems
{
    internal class Problem003 : ProblemBase
    {
        private const long VALUE = 600851475143;

        public Problem003() : base(3, "Largest prime factor") { }

        /// <inheritdoc />
        public override string Solve()
        {
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
