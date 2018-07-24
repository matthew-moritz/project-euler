using System;

namespace ProjectEuler.Problems
{
    internal class Problem006 : ProblemBase
    {
        private const int MAX_VALUE = 100;

        public Problem006() : base(6, "Sum square difference") { }

        /// <inheritdoc />
        public override string Solve()
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