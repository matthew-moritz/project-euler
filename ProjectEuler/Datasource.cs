using ProjectEuler.Problems;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class Datasource : IDatasource
    {
        IEnumerable<IProblem> _problems;

        public Datasource()
        {
            _problems = Load();
        }

        public IProblem GetProblem(int number)
        {
            return _problems.FirstOrDefault(x => x.Number == number);
        }

        public IEnumerable<IProblem> GetProblems()
        {
            return _problems;
        }
        
        private IEnumerable<IProblem> Load()
        {
            var problems = new List<IProblem>
            {
                new Problem001()
            };

            return problems;
        }
    }
}
