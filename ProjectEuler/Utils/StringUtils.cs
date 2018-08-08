
namespace ProjectEuler.PeMath
{
    internal static class StringUtils
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == string.Empty)
                return false;

            var start = 0;
            var end = s.Length - 1;

            var chars = s.ToCharArray();
            while (start < end)
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
