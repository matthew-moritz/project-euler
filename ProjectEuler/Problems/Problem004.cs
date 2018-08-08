using ProjectEuler.PeMath;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit 
    /// numbers is 9009 = 91 × 99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    internal class Problem004 : ProblemBase
    {       
        public Problem004() : base(4, "Largest palindrome product") { }

        /// <inheritdoc />
        public override string Solve()
        {
            const int MIN_VALUE = 99;
            const int MAX_VALUE = 999;

            var largest = 0;

            for (var i = MAX_VALUE; i > MIN_VALUE; i--)
                for(var j = MAX_VALUE; j > MIN_VALUE; j--)
                {
                    var n = i * j;
                    if (n > largest && StringUtils.IsPalindrome($"{n}"))
                        largest = n;
                }

            return $"{largest}";
        }
    }
}
