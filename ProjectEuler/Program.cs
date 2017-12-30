using System;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Program
    {
        private const string QUIT = "q";
        private const string LIST = "list";

        static void Main(string[] args)
        {
            var datasource = new Datasource();

            var isQuit = false;
            var input = string.Empty;

            DisplayWelcomeMessage();

            while (!isQuit)
            {
                DisplayInputPrompt();
                input = Console.ReadLine();

                switch (input)
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

        private static void TrySolve(string input, Datasource datasource)
        {
            if (!int.TryParse(input, out var number))
            {
                Console.WriteLine("  Invalid input. Try again.");
                return;
            }

            var problem = datasource.GetProblem(number);
            if (problem == null)
            {
                Console.WriteLine($"  Problem {number} has not been solved.");
                return;
            }

            Console.WriteLine($"  {problem.Solve()}");
        }

        private static void DisplayWelcomeMessage()
        {
            var builder = new StringBuilder();

            builder.AppendLine("----------------------");
            builder.AppendLine(" Project Euler");
            builder.AppendLine(" ");
            builder.AppendLine(" Type \"list\" to display a list of solved problems.");
            builder.AppendLine(" Type \"q\" to quit.");
            builder.AppendLine("----------------------");

            Console.Write(builder.ToString());
        }

        private static void DisplayInputPrompt()
        {
            Console.Write("# ");
        }

        private static void DisplayAllSolvedProblems(IDatasource datasource)
        {
            Console.WriteLine("Solved Problems:");

            var problems = datasource.GetProblems();

            if (problems.Count() != 0)
                foreach (var problem in datasource.GetProblems())
                    Console.WriteLine($"  {problem.Number}\t{problem.Title}");
            else
                Console.WriteLine("  There are no solved problems.");            

            Console.WriteLine();
        }
    }
}
