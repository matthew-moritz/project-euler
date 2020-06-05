(*
  Problem 3
  Largest prime factor

  The prime factors of 13195 are 5, 7, 13 and 29.

  What is the largest prime factor of the number 600851475143?
*)

// Finds the factors of a number.
let findFactors n =
    let upperBound = int64 (sqrt(double (n)))
    [ 2L .. upperBound ] |> Seq.filter (fun x -> n % x = 0L)

// Determines if a number is prime.
let isPrime n =
    n
    |> findFactors
    |> Seq.isEmpty

// Finds the largest prime factor of a number.
let findMaxPrimeFactor n =
    n
    |> findFactors
    |> Seq.filter isPrime
    |> Seq.max

findMaxPrimeFactor (600851475143L)
