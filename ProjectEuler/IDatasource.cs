using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal interface IDataSource
    {
        IEnumerable<IProblem> LoadProblems();
    }
}
