/*
 * Special Pythagorean triplet
 *
 * A Pythagorean triplet is a set of three natural numbers, a is less than b is less than c, for which,
 * 
 *     a^2 + b^2 = c^2
 * 
 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
 * 
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */
var max = (int)Math.Sqrt(1000);

// Generate pythagorean triplets where a, b, c are < sqrt(1000)
var triplets = new List<(int A, int B, int C)>();
for (var a = 1; a < max; a++)
    for (var b = 1; b < max; b++)
        for (var c = 1; c < max; c++)
            if (a < b && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                triplets.Add((a, b, c));

// Find a, b, c such that the sum is a multiple of 1000
var (A, B, C) = triplets.FirstOrDefault(x => 1000 % (x.A + x.B + x.C) == 0);

// Find ka, kb, kc such that the sum equals 1000.
var k = 1000 / (A + B + C);

Console.WriteLine((k * A) * (k * B) * (k * C));
