(*
  Problem 15
  Lattice paths

  Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
  
  How many such routes are there through a 20×20 grid?
*)

let rec takeStep x y =
  if x = 0L && y = 0L then
    1L
  else
    let horizontal = if x = 0L then 0L else (takeStep (x - 1L) y)
    let vertical = if y = 0L then 0L else (takeStep x (y - 1L))
    horizontal + vertical

// This takes 22 minutes to run. This can be optimized.
takeStep 20L 20L