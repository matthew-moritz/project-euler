/*
 * The following iterative sequence is defined for the set of positive integers:
 *
 *     n → n/2 (n is even)
 *     n → 3n + 1 (n is odd)
 * 
 * Using the rule above and starting with 13, we generate the following sequence:
 * 
 * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
 * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
 * 
 * Which starting number, under one million, produces the longest chain?
 * 
 * NOTE: Once the chain starts the terms are allowed to go above one million.
 */
private IDictionary<long, long> _chains = new Dictionary<long, long>();
const int MAX_VALUE = 1000000;
var maxKey = 0L;
var maxValue = 0L;

for (var i = 1; i < MAX_VALUE; i++)
{
    var value = GetChain(i);

    if (maxValue < value)
    {
        maxKey = i;
        maxValue = value;
    }
}

Console.WriteLine(maxKey);

private long GetChain(long i)
{
    var chainKey = i;
    var chainLength = 1;

    while (chainKey != 1)
    {
        chainKey = chainKey % 2 == 0 ? chainKey / 2 : (3 * chainKey) + 1;

        if (_chains.ContainsKey(chainKey))
        {
            _chains.Add(i, chainLength);
            return chainLength + 1 + _chains[chainKey];
        }

        chainLength++;
    }

    _chains.Add(i, chainLength);
    return chainLength;
}