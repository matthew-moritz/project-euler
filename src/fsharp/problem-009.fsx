(*
  Problem 9
  Special Pythagorean triplet

  A Pythagorean triplet is a set of three natural numbers, a is less than b is less than c, for which,

    a^2 + b^2 = c^2

  For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

  There exists exactly one Pythagorean triplet for which a + b + c = 1000.
  Find the product abc.
*)
let isTriplet (numbers: int list) =
    match List.sort (numbers) with
    | [ a; b; c ] -> a * a + b * b = c * c
    | _ -> false

let getTriplets =
    seq {
        for a = 1 to 1000 do
            for b = 1 to 1000 do
                for c = 1 to 1000 do
                    if a + b + c = 1000 then yield [ a; b; c ]
    }

getTriplets
|> Seq.filter isTriplet
|> Seq.head
|> Seq.fold ((*)) 1
