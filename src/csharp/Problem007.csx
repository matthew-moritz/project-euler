/*
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 *
 * What is the 10 001st prime number?
 */
const int MAX_VALUE = 10001;

var count = 0;
var number = 1;

while(count < MAX_VALUE)
{
    number++;
    if (number.IsPrime())
        count++;
}

Console.WriteLine(number);

// Determines if a value is a prime number.
private static bool IsPrime(this int n)
{
    if (n == 2 || n == 3)
        return true;

    if (n % 2 == 0)
        return false;

    int sqrt = (int)Math.Sqrt(n) + 1;
    for (var i = 3; i < sqrt; i += 2)
        if (n % i == 0)
            return false;

    return true;
}