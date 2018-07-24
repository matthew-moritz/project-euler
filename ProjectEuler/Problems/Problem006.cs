using System;

namespace ProjectEuler.Problems
{
    internal class Problem006 : IProblem
    {
        private const int MAX_VALUE = 100;

        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 6;

        /// <summary>
        /// The title of the problem.
        /// </summary>
        public string Title => "Sum square difference";

        /// <summary>
        /// Solves the problem.
        /// </summary>
        public string Solve()
        {
            var sum = 0;
            var sumOfSquares = 0;

            for(var i=1; i <= MAX_VALUE; i++)
            {
                sum += i;
                sumOfSquares += (i * i);
            }

            var squareOfSums = sum * sum;

            var result = Math.Abs(squareOfSums - sumOfSquares);
            return $"{result}";
        }
    }
}