/* <summary>
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 *
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */
const int MAX_VALUE = 20;

var factors = ReduceFactors(MAX_VALUE);

int i = MAX_VALUE;
var result = 0;

while (result == 0)
{
    var isFactor = true;
    for (int j = 0; j < factors.Length; j++)
    {
        if (i % factors[j] == 0)
            continue;

        isFactor = false;
        break;
    }

    if (isFactor)
        result = i;

    i += MAX_VALUE;
}

Console.WriteLine(result);
        

// Reduces the list of factors from 1 to maxValue, removing any unnecessary factors.
private int[] ReduceFactors(int maxValue)
{
    var reduce = new bool[maxValue];
    for (var i = 0; i < maxValue; i++)
        reduce[i] = true;

    for (var i = maxValue; i > 0; i--)
        for (var j = i - 1; j > 0; j--)
            if (i % j == 0)
                reduce[j - 1] = false;

    var factors = new List<int>();
    for (var i = 0; i < reduce.Length; i++)
        if (reduce[i])
            factors.Add(i + 1);

    return factors.ToArray();
}