using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    /// 
    /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// 
    /// Find the sum of the digits in the number 100!
    /// </summary>
    internal class Problem020 : ProblemBase
    {
        public Problem020() : base(20, "Factorial digit sum") { }

        public override string Solve()
        {
            var i = new BigInteger(100);

            var factorial = Factorial(i).ToString();

            return $"{factorial.Select(x => char.GetNumericValue(x)).Sum()}";
        }

        private BigInteger Factorial(BigInteger i)
        {
            if (i == 1)
                return 1;

            return i * Factorial(i - 1);
        }
    }
}
