
namespace ProjectEuler.Problems
{
    internal class Problem001 : ProblemBase
    {
        private const int MAX_VALUE = 1000;

        /// <summary>
        /// Multiples of 3 and 5
        /// 
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        ///
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public Problem001() : base(1, "Multiples of 3 and 5") { }

        /// <inheritdoc />
        public override string Solve()
        {
            var sum = 0;
            for (var i = 0; i < MAX_VALUE; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            return $"{sum}";
        }
    }
}
