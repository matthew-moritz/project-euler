using ProjectEuler.Problems;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class DataSource : IDataSource
    {
        IEnumerable<IProblem> _problems;

        public DataSource()
        {
            _problems = new List<IProblem>
            {
                new Problem001(),
                new Problem002(),
                new Problem003(),
                new Problem004(),
                new Problem005(),
                new Problem006(),
                new Problem007(),
                new Problem008(),
                new Problem009(),
                new Problem010(),
                new Problem011()
            };
        }

        public IProblem GetProblem(int number)
        {
            return _problems.FirstOrDefault(x => x.Number == number);
        }

        public IEnumerable<IProblem> GetProblems()
        {
            return _problems;
        }
    }
}
