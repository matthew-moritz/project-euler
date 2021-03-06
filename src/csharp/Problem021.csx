﻿/*
 * Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
 * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
 * 
 * For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
 * The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
 * 
 * Evaluate the sum of all the amicable numbers under 10000.
 */
var lookup = new Dictionary<int, int>();
for (var i = 1; i < 10000; i++)
{
    var factors = GetFactors(i);

    var divisorSum = 0;
    foreach (var factor in factors)
        if (factor != i)
            divisorSum += factor;

    lookup.Add(i, divisorSum);
}

var sum = 0;
for (var i = 1; i < 10000; i++)
    if (lookup.TryGetValue(lookup[i], out var value) && i != lookup[i] && i == value)
        sum += i;

Console.WriteLine(sum);

private static IEnumerable<int> GetFactors(int n)
{
    var factors = new List<int>();
    for (int i = 1; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            factors.Add(i);

            if (n / i != i)
                factors.Add(n / i);
        }
    }

    factors.Sort();
    return factors;
}