(*
  Problem 5
  Smallest multiple
  
  2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
  
  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)
let isDivisible (n, numbers) = numbers |> Seq.forall (fun x -> n % x = 0)

let numbers = [| 1 .. 20 |]
let max = Array.max (numbers)

Seq.unfold (fun x -> Some(x, x + max)) max
|> Seq.filter (fun x -> isDivisible (x, numbers))
|> Seq.head
