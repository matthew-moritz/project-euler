"""
Problem 686
Powers of Two

2^7 = 128 is the first power of two whose leading digits are "12".
The next power of two whose leading digits are "12" is 2^80.

Define p(L, n) to be the nth-smallest value of j such that the base 10 representation of 2^j begins with the digits of L.
So p(12, 1) = 7 and p(12, 2) = 80.

You are also given that p(123, 45) = 12710.

Find p(123, 678910)
"""


def generate(L):
    strL = str(L)
    length = len(strL)

    i = 0
    j = 1

    while True:
        j = int(str(2 * j)[:15])
        i += 1
        if str(j)[:length] == strL:
            yield i


def p(L, n):
    value = 0
    generator = generate(L)

    count = 0
    while count < n:
        value = next(generator)
        print('c', count, '   v', value)
        count += 1

    return value


# ! This is a very inefficient way of solving this.
print(
    p(123, 678910))
