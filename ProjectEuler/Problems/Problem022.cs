using System;
using System.IO;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Using names.txt, a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
    /// Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
    /// 
    /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
    /// So, COLIN would obtain a score of 938 × 53 = 49714.
    /// 
    /// What is the total of all the name scores in the file?
    /// </summary>
    internal class Problem022 : ProblemBase
    {
        public Problem022() : base(22, "Names scores") { }

        public override string Solve()
        {
            var fileContent = File.ReadAllText("Resources/p022_names.txt");
            fileContent = fileContent.Replace("\"", string.Empty);

            var names = fileContent.Split(',');
            Array.Sort(names);

            var sum = 0;
            for(var i = 0; i < names.Length; i++)
            {
                var numericValue = 0;
                foreach (var ch in names[i])
                    numericValue += ch - 'A' + 1;

                sum += numericValue * (i + 1);
            }

            return $"{sum}";
        }
    }
}
