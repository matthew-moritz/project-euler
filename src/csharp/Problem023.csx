﻿/*
 * A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.
 * For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
 *
 * A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
 *
 * As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.
 * By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
 * However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as 
 * the sum of two abundant numbers is less than this limit.
 *
 * Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
 */
var max = 28123;
var abundants = new HashSet<int>();

// Create a set of abundant numbers.
for(var i = 1; i < max; i++)
    if(IsAbundant(i))
        abundants.Add(i);

var sum = 0;
for(var i=1; i < max; i++)
    if (HasAbundantSum(i, abundants))
        sum += i;

Console.WriteLine(sum);

private bool IsAbundant(int n) => GetProperDivisors(n).Sum() > n;

private IEnumerable<int> GetProperDivisors(int n)
{
    var divisors = new List<int>();

    for (int i = 1; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            divisors.Add(i);

            if (n / i != i && n / i != n)
                divisors.Add(n / i);
        }
    }

    divisors.Sort();
    return divisors;
}

private bool HasAbundantSum(int i, HashSet<int> abundants)
{
    throw new NotImplementedException();
}
