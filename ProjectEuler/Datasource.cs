using ProjectEuler.Problems;
using System.Collections.Generic;

namespace ProjectEuler
{
    internal class DataSource : IDataSource
    {
        public IEnumerable<IProblem> LoadProblems()
        {
            var problems = new List<IProblem>
            {
                new Problem001(),
                new Problem002(),
                new Problem003(),
                new Problem004(),
                new Problem005(),
                new Problem006(),
                new Problem007(),
                new Problem008(),
                new Problem009()
            };

            return problems;
        }
    }
}
