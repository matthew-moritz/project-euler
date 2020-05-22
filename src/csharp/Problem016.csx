/*
 * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
 *
 * What is the sum of the digits of the number 2^1000?
 */
#r "System.Numerics"

using System.Numerics;

var sum = BigInteger.Pow(new BigInteger(2), 1000).ToString().Select(x => char.GetNumericValue(x)).Sum();
Console.WriteLine(sum);
