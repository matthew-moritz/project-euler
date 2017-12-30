using System.Collections.Generic;

namespace ProjectEuler
{
    internal interface IDatasource
    {
        IEnumerable<IProblem> GetProblems();
        IProblem GetProblem(int number);
    }
}
