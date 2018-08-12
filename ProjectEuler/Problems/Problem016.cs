using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    ///
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    internal class Problem016 : ProblemBase
    {
        public Problem016() : base(16, "Power digit sum") { }

        public override string Solve()
        {
            return $"{BigInteger.Pow(new BigInteger(2), 1000).ToString().Select(x => char.GetNumericValue(x)).Sum()}";
        }
    }
}
