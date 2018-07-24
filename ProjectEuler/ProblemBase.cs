
namespace ProjectEuler
{
    internal abstract class ProblemBase : IProblem
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProblemBase" />.
        /// </summary>
        /// <param name="number">The problem number.</param>
        /// <param name="title"></param>
        protected ProblemBase(int number, string title)
        {
            Number = number;
            Title = title;
        }

        /// <inheritdoc />
        public int Number { get; }
        
        /// <inheritdoc />
        public string Title { get; }

        /// <inheritdoc />
        public abstract string Solve();
    }
}
