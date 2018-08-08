using ProjectEuler.PeMath;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    ///
    /// What is the 10 001st prime number?
    /// </summary>
    internal class Problem007 : ProblemBase
    {
        public Problem007() : base(7, "10001st prime") { }
       
        /// <inheritdoc />
        public override string Solve()
        {
            const int MAX_VALUE = 10001;

            var count = 0;
            var number = 1;

            while(count < MAX_VALUE)
            {
                number++;
                if (number.IsPrime())
                    count++;
            }

            return $"{number}";
        }
    }
}
