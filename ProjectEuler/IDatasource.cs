using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    /// The interface for a datasource. This will contain the collection of problems.
    /// </summary>
    internal interface IDatasource
    {
        /// <summary>
        /// Gets the problem of the specified number.
        /// </summary>
        IProblem GetProblem(int number);

        /// <summary>
        /// Gets all problems.
        /// </summary>
        IEnumerable<IProblem> GetProblems();
    }
}
