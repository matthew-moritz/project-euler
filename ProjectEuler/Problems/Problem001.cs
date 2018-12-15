using System.Linq;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Multiples of 3 and 5
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    /// The sum of these multiples is 23.
    ///
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    internal class Problem001 : ProblemBase
    {
        public Problem001() : base(1, "Multiples of 3 and 5") { }

        /// <inheritdoc />
        public override string Solve()
        {
            return $"{Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum()}";
        }
    }
}

/*
 * F# implementation.
 * module ProjectEuler =
 *
 *   let problem1 = [1..999] |> List.filter(fun x -> x % 3 = 0 || x % 5 = 0) |> List.sum 
 */
