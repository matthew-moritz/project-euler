using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    internal class Problem004 : IProblem
    {
        /// <summary>
        /// The problem number.
        /// </summary>
        public int Number => 4;

        /// <summary>
        /// The title.
        /// </summary>
        public string Title => "Largest palindrome product";

        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        ///
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public string Solve()
        {
            const int MIN = 100;
            const int MAX = 999;

            int product, largestPalindrome = 0;
            for (int i = MAX; i >= MIN; i--)
            {
                for (int j = MAX; j >= MIN; j--)
                {
                    product = i * j;
                    if (IsPalindromic(product) && product > largestPalindrome)
                        largestPalindrome = product;
                }
            }
            return $"{largestPalindrome}";
        }

        /// <summary>
        /// Determines whether a number is a palindrome.
        /// </summary>
        private bool IsPalindromic(int product)
        {
            var productString = $"{product}";

            int start = 0;
            int end = productString.Length - 1;

            while (start < end)
            {
                if (productString[start] != productString[end])
                    return false;

                start += 1;
                end -= 1;
            }

            return true;
        }
    }
}
