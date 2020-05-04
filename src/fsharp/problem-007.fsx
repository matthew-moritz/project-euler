(*
  Problem 7
  10001st prime
  
  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

  What is the 10 001st prime number?
*)
let findFactors n =
    let upperBound = int(sqrt(double (n)))
    [ 2 .. upperBound ] |> Seq.filter (fun x -> n % x = 0)

let isPrime n = n |> findFactors |> Seq.isEmpty

Seq.unfold (fun x -> Some(x, x + 1)) 2
|> Seq.filter isPrime
|> Seq.item(10000)
