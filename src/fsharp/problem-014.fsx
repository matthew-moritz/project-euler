(*
  Problem 14
  Longest Collatz sequence
  
  The following iterative sequence is defined for the set of positive integers:

    n → n/2 (n is even)
    n → 3n + 1 (n is odd)

  Using the rule above and starting with 13, we generate the following sequence:

    13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
  
  It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

  Which starting number, under one million, produces the longest chain?

  NOTE: Once the chain starts the terms are allowed to go above one million.
*)
let collatzLength n =
  n
  |> Seq.unfold (fun x ->
      if (x = 1L) then
        None
      else
        let result = if x % 2L = 0L then x / 2L else (3L * x) + 1L        
        Some(result, result))
  |> Seq.length
  |> (+) 1

[1L..999999L] |> Seq.maxBy collatzLength
