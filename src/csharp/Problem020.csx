/*
 * n! means n × (n − 1) × ... × 3 × 2 × 1
 * 
 * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
 * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
 * 
 * Find the sum of the digits in the number 100!
 */
#r "System.Numerics"

using System.Numerics;

var i = new BigInteger(100);

var factorial = Factorial(i).ToString();

var sum = factorial
    .Select(x => char.GetNumericValue(x))
    .Sum();

Console.WriteLine(sum);

private BigInteger Factorial(BigInteger i)
{
    if (i == 1)
        return 1;

    return i * Factorial(i - 1);
}