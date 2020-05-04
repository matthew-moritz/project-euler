(*
  Problem 10
  The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

  Find the sum of all the primes below two million.
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

seq { for n in 2L..2000000L do if (isPrime n) then yield n }
|> Seq.sum