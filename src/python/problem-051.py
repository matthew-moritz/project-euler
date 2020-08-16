"""
Problem 51
Prime digit replacements

By replacing the 1st digit of the 2-digit number *3, it turns out that six of the nine possible values: 13, 23, 43, 53, 73, and 83, are all prime.

By replacing the 3rd and 4th digits of 56**3 with the same digit, this 5-digit number is the first example 
having seven primes among the ten generated numbers, yielding the family: 

  56003, 56113, 56333, 56443, 56663, 56773, and 56993.
  
Consequently 56003, being the first member of this family, is the smallest prime with this property.

Find the smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit, is part of an eight prime value family.
"""


def generate_primes():
    # Code by David Eppstein, UC Irvine, 28 Feb 2002
    # http://code.activestate.com/recipes/117119/
    D = {}
    q = 2

    while True:
        if q not in D:
            yield q
            D[q * q] = [q]
        else:
            for p in D[q]:
                D.setdefault(p + q, []).append(p)
            del D[q]
        q += 1


def get_combinations(input, digit):
    first = input.find(digit)
    return [input] if first == -1 else [input[0:first] + chr + suffix for chr in [digit, '*'] for suffix in get_combinations(input[first + 1:], digit)]


def prime_digit_replacement(size):
    expressions = dict()
    prime_generator = generate_primes()

    while True:
        prime = str(next(prime_generator))
        combinations = [combination for digit in '0123456789' for combination in get_combinations(prime, digit) if combination != prime]

        for key in combinations:
            expressions.setdefault(key, []).append(prime)
            if len(expressions[key]) == size:
                return expressions[key][0]


print(prime_digit_replacement(8))
