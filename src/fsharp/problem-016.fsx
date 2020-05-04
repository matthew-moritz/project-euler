(*
  2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

  What is the sum of the digits of the number 2^1000?
*)

2.0 ** 1000.0
|> bigint
|> string
|> Seq.map (fun x -> int x - int '0')
|> Seq.sum