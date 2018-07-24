using System;

namespace ProjectEuler.Problems
{
    internal class Problem004 : IProblem
    {       
        private const int MIN_VALUE = 99;
        private const int MAX_VALUE = 999;

        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 4;

        /// <summary>
        /// The title of the problem.
        /// </summary>
        public string Title => "Largest palindrome product";

        /// <summary>
        /// Solves the problem.
        /// </summary>
        public string Solve()
        {
            var largest = 0;

            for (var i = MAX_VALUE; i > MIN_VALUE; i--)
                for(var j = MAX_VALUE; j > MIN_VALUE; j--)
                {
                    var n = i * j;
                    if (n > largest && IsPalindrome($"{n}"))
                        largest = n;
                }

            return $"{largest}";
        }

        private bool IsPalindrome(string s)
        {
            if (s == string.Empty)
                return false;

            var start = 0;
            var end = s.Length - 1;

            var chars = s.ToCharArray();
            while(start < end)
            {
                if (chars[start] != chars[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
