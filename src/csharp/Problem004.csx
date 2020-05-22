/* <summary>
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit 
 * numbers is 9009 = 91 × 99.
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
const int MIN_VALUE = 99;
const int MAX_VALUE = 999;

var largest = 0;

for (var i = MAX_VALUE; i > MIN_VALUE; i--)
{
    for (var j = MAX_VALUE; j > MIN_VALUE; j--)
    {
        var n = i * j;
        if (n > largest && $"{n}".IsPalindrome())
            largest = n;
    }
}

Console.WriteLine(largest);

// Determines whether the specified string is a palindrome.
private static bool IsPalindrome(this string s)
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