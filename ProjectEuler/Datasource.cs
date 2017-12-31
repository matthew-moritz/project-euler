using ProjectEuler.Problems;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// A datasource for problems.
    /// </summary>
    internal class Datasource : IDatasource
    {
        IEnumerable<IProblem> _problems;

        /// <summary>
        /// Creates a new instance of <see cref="Datasource" />.
        /// </summary>
        public Datasource()
        {
            _problems = new List<IProblem>
            {
                new Problem001(),
                new Problem002(),
                new Problem003(),
                new Problem004()
            };
        }

        /// <summary>
        /// Gets the problem of the specified number.
        /// </summary>
        public IProblem GetProblem(int number)
        {
            return _problems.FirstOrDefault(x => x.Number == number);
        }

        /// <summary>
        /// Gets all problems.
        /// </summary>
        public IEnumerable<IProblem> GetProblems()
        {
            return _problems;
        }
    }
}
