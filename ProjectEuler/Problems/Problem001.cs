
namespace ProjectEuler.Problems
{
    internal class Problem001 : ProblemBase
    {
        private const int MAX_VALUE = 1000;

        /// <summary>
        /// 
        /// </summary>
        protected Problem001() : base(1, "Multiples of 3 and 5") { }

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
