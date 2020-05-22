/* <summary>
 * The prime factors of 13195 are 5, 7, 13 and 29.
 *
 * What is the largest prime factor of the number 600851475143?
 */
const long VALUE = 600851475143;

var i = (int)Math.Sqrt(VALUE);
while (i > 0)
{
    if (VALUE % i == 0 && i.IsPrime())
    {  
        Console.WriteLine(i);
        return;
    }    
    i--;
}

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