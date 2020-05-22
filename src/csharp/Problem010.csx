/*
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 *
 * Find the sum of all the primes below two million.
 */
#r "System.Collections"
#r "System.Linq"
#r "System.Numerics"

using System.Collections.Generic;
using System.Linq;
using System.Numerics;

var sieve = SieveOfEratostehenes(2000000);

var sum = sieve.Select(x => new BigInteger(x)).Aggregate((current, i) => current + i);
Console.WriteLine(sum);

// Determines a collection of prime numbers less that the specified value n.
private static IEnumerable<int> SieveOfEratostehenes(int n)
{
  var values = new bool[n];
  Array.Fill(values, true);

  var max = (int)Math.Sqrt(n);

  values[0] = false;
  values[1] = false;
  for (var i = 2; i <= max; i++)
  {
    if (!values[i])
      continue;

    for (var j = (int)Math.Pow(i, 2); j < n; j += i)
      values[j] = false;
  }

  return values.Select((x, index) => new { x, index }).Where(y => y.x).Select(x => x.index);
}