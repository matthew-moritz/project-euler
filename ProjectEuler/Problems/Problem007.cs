using ProjectEuler.PeMath;
using System;

namespace ProjectEuler.Problems
{
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
