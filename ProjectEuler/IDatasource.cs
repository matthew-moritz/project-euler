using System.Collections.Generic;

namespace ProjectEuler
{
    internal interface IDataSource
    {
        IProblem GetProblem(int number);

        IEnumerable<IProblem> GetProblems();
    }
}
