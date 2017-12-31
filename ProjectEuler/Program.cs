using System;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Program
    {
        private const string QUIT = "quit";
        private const string LIST = "list";

        /// <summary>
        /// The main method of the application.
        /// </summary>
        static void Main(string[] args)
        {
            var datasource = new Datasource();

            var isQuit = false;
            var input = string.Empty;

            DisplayWelcomeMessage();

            while (!isQuit)
            {
                // Wait for user input.
                input = DisplayInputPrompt();

                switch (input.ToLower())
                {
                    case LIST:
                        DisplayAllSolvedProblems(datasource);
                        break;
                    case QUIT:
                        isQuit = true;
                        break;
                    default:
                        TrySolve(input, datasource);
                        break;
                }
            };
        }

        /// <summary>
        /// Attempts to fetch the problem and solve it.
        /// </summary>
        private static void TrySolve(string input, Datasource datasource)
        {
            // Get the problem number.
            if(!int.TryParse(input, out var number))
            {
                Console.WriteLine("  Invalid input. Try again.");
                return;
            }

            // Get the problem.
            var problem = datasource.GetProblem(number);
            if (problem == null)
            {
                Console.WriteLine($"  Problem {number} has not been solved.");
                return;
            }

            // Output the solution to the problem.
            Console.WriteLine($"  {problem.Solve()}");
        }

        /// <summary>
        /// Displays the initial message when the application is started.
        /// </summary>
        private static void DisplayWelcomeMessage()
        {
            var builder = new StringBuilder();

            builder.AppendLine("----------------------");
            builder.AppendLine(" Project Euler");
            builder.AppendLine(" ");
            builder.AppendLine(" Type \"list\" to display a list of solved problems.");
            builder.AppendLine(" Type \"quit\" to quit.");
            builder.AppendLine("----------------------");

            Console.Write(builder.ToString());
        }

        /// <summary>
        /// Displays the input prompt to the user and waits for input.
        /// </summary>
        private static string DisplayInputPrompt()
        {
            Console.Write("# ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Displays a list of all solved problems.
        /// </summary>
        private static void DisplayAllSolvedProblems(IDatasource datasource)
        {
            Console.WriteLine("  Solved Problems:");

            var problems = datasource.GetProblems();

            if (problems.Count() != 0)
                foreach (var problem in datasource.GetProblems())
                    Console.WriteLine($"    {problem.Number}\t{problem.Title}");
            else
                Console.WriteLine("    There are no solved problems.");            

            Console.WriteLine();
        }
    }
}
