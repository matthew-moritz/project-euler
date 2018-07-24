
namespace ProjectEuler.Problems
{
    internal class Problem002 : IProblem
    {
        private const int MAX_VALUE = 4000000;

        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 2;

        /// <summary>
        /// The title of the problem.
        /// </summary>
        public string Title => "Even Fibonacci numbers";

        /// <summary>
        /// Solves the problem.
        /// </summary>
        public string Solve()
        {
            var first = 1;
            var second = 2;

            var sum = 0;
            while (second <= MAX_VALUE)
            {
                if (first % 2 == 0)
                    sum += first;
                if (second % 2 == 0)
                    sum += second;

                first = first + second;
                second = first + second;
            }

            return $"{sum}";
        }
    }
}