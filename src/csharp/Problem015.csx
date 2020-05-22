/*
 * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
 * there are exactly 6 routes to the bottom right corner.
 *
 * How many such routes are there through a 20×20 grid?
 */
#r "System.Numerics"

using System.Numerics;

private IDictionary<BigInteger, BigInteger> _factorials = new Dictionary<BigInteger, BigInteger>();

// This can be figured out by finding the middle value in the (n * 2) row of Pascal's Triangle.
var n = new BigInteger(20);
var row = GeneratePascalsRow(n * 2);

Console.WriteLine(row[row.Length/2]);

private BigInteger[] GeneratePascalsRow(BigInteger i)
{
    // Values can be calculated using:
    //  n! / (0! * n!)
    //  n! / (1! * (n - 1)!)
    //  n! / (2! * (n - 2)!)
    //  ...
    //  n! / (n! * (n - n)!)
    var j = new BigInteger(0);

    var numerator = GetFactorial(i);
    var values = new List<BigInteger>();
    while (j <= i)
    {
        values.Add(numerator / (GetFactorial(j) * GetFactorial(i - j)));
        j++;
    }

    return values.ToArray();
}

private BigInteger GetFactorial(BigInteger i)
{
    if (_factorials.ContainsKey(i))
        return _factorials[i];

    var result = i == 0 ? 1 : i * GetFactorial(i - 1);
    _factorials.Add(i, result);

    return result;
}