using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    internal class Problem016 : ProblemBase
    {
        public Problem016() : base(16, "Power digit sum") { }

        public override string Solve()
        {
            return $"{BigInteger.Pow(new BigInteger(2), 1000).ToString().Select(x => char.GetNumericValue(x)).Sum()}";
        }
    }
}
