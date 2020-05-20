(*
  Problem 15
  Lattice paths

  Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
  
  How many such routes are there through a 20×20 grid?
*)
let factorial x =
  let rec tailRecursiveFactorial x f =
    if x <= (bigint(1)) then
      f()
    else
      tailRecursiveFactorial (x - (bigint(1))) (fun () -> x * f())
  
  tailRecursiveFactorial x (fun () -> (bigint(1)))

let pascalRow n =
  let numerator = factorial n

  [(bigint(0))..n]
  |> List.map (fun x -> numerator / ((factorial x) * (factorial (n - x))))

let row = pascalRow (bigint(40))
row.[row.Length/2]