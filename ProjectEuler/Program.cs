using System;

namespace ProjectEuler
{
    public class Program
    {
        public const string QUIT = "QUIT";

        static void Main(string[] args)
        {
            var datasource = new DataSource();

            DisplayIntro();
            DisplayProblems(datasource);

            var isQuit = false;
            do
            {
                isQuit = false;
                DisplayPrompt();

                try
                {
                    var problem = GetSelectedProblem(datasource);
                    ShowSolution(problem.Solve());
                }
                catch (Exception e)
                {
                    isQuit = e.Message == QUIT;
                }

            } while (!isQuit);
        }

        private static void DisplayIntro()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("      Project Euler!      ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter a problem number to view the solution, or type \"QUIT\" to exit.");
            Console.WriteLine();
        }

        /// <summary>
        /// Displays the collection of problems.
        /// </summary>
        private static void DisplayProblems(IDataSource datasource)
        {
            foreach (var problem in datasource.GetProblems())
                Console.WriteLine($"{problem.Number}\t{problem.Title}");
            Console.WriteLine();
        }

        /// <summary>
        /// Displays the prompt.
        /// </summary>
        private static void DisplayPrompt()
        {
            Console.Write("Select a problem: ");
        }

        /// <summary>
        /// Parses the input and fetches the problem.
        /// </summary>
        private static IProblem GetSelectedProblem(IDataSource datasource)
        {
            var input = Console.ReadLine();

            if(int.TryParse(input, out var number))
                return datasource.GetProblem(int.Parse(input));

            throw new Exception(input.ToUpper());
        }

        /// <summary>
        /// Displays the solution.
        /// </summary>
        private static void ShowSolution(string solution)
        {
            Console.WriteLine(solution);
        }
    }
}
