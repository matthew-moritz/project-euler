using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    ///
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    /// </summary>
    internal class Problem017 : ProblemBase
    {
        public Problem017() : base(17, "Number letter counts") { }

        public override string Solve()
        {
            var words = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {15, "fifteen" },
                {16, "sixteen" },
                {17, "seventeen" },
                {18, "eighteen" },
                {19, "nineteen" },
                {20, "twenty" },
                {30, "thirty" },
                {40, "forty" },
                {50, "fifty" },
                {60, "sixty" },
                {70, "seventy" },
                {80, "eighty" },
                {90, "ninety" },
            };

            var sum = 0;
            for (var i = 1; i <= 1000; i++)
            {
                var word = string.Empty;

                if (i == 1000)
                    word = "onethousand";
                else
                {
                    var hundreds = ((i % 1000) / 100);
                    var tens = ((i % 100) / 10);
                    var ones = i % 10;

                    if (hundreds != 0 && words.TryGetValue(hundreds, out var result))
                        word += result + "hundred";

                    if (!string.IsNullOrWhiteSpace(word) && (tens != 0 || ones != 0))
                        word += "and";

                    if (words.TryGetValue((tens * 10) + ones, out result))
                        word += result;
                    else
                    {
                        if (tens != 0 && words.TryGetValue(tens * 10, out result))
                            word += result;
                        if (ones != 0 && words.TryGetValue(ones, out result))
                            word += result;
                    }
                }

                sum += word.Trim().Length;
            }

            return $"{sum}";
        }
    }
}