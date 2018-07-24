
namespace ProjectEuler
{
    /// <summary>
    /// A problem.
    /// </summary>
    internal interface IProblem
    {
        /// <summary>
        /// The problem number.
        /// </summary>
        int Number { get; }

        /// <summary>
        /// The title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The solution to the problem.
        /// </summary>
        string Solve();
    }
}
