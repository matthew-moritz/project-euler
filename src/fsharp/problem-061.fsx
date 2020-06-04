(*
  Triangle, square, pentagonal, hexagonal, heptagonal, and octagonal numbers are all figurate (polygonal) numbers and are generated by the following formulae:

    Triangle    P3,n = n(n+1)/2   1, 3, 6, 10, 15, ...
    Square      P4,n = n^2        1, 4, 9, 16, 25, ...
    Pentagonal  P5,n = n(3n−1)/2  1, 5, 12, 22, 35, ...
    Hexagonal   P6,n = n(2n−1)    1, 6, 15, 28, 45, ...
    Heptagonal  P7,n = n(5n−3)/2  1, 7, 18, 34, 55, ...
    Octagonal   P8,n = n(3n−2)    1, 8, 21, 40, 65, ...

  The ordered set of three 4-digit numbers: 8128, 2882, 8281, has three interesting properties.

  1. The set is cyclic, in that the last two digits of each number is the first two digits of the next number (including the last number with the first).
  2. Each polygonal type: triangle (P3, 127 = 8128), square (P4, 91 = 8281), and pentagonal (P5, 44 = 2882), is represented by a different number in the set.
  3. This is the only set of 4-digit numbers with this property.

  Find the sum of the only ordered set of six cyclic 4-digit numbers for which each polygonal type: triangle, square, pentagonal, hexagonal, heptagonal, and octagonal, is represented by a different number in the set.
*)
let p3 n = n * (n + 1) / 2
let p4 n = n * n
let p5 n = n * ((3 * n) - 1) / 2
let p6 n = n * ((2 * n) - 1)
let p7 n = n * ((5 * n) - 3) / 2
let p8 n = n * ((3 * n) - 2)

// Determines if the last two digits of the first argument match the first two digits of the second argument.
let isCyclic x y = x % 100 = y / 100

// Generates the permutations.
let rec createPermutations =
    function
    | [] -> [ List.empty ]
    | x :: xs -> List.collect (insertions x) (createPermutations xs)

and insertions x =
    function
    | [] -> [ [ x ] ]
    | (y :: ys) as xs ->
        (x :: xs)
        :: (List.map (fun x -> y :: x) (insertions x ys))

// Generates the 4-digit values from the given function.
let createSequence func =
    1
    |> Seq.unfold (fun x -> if (func x < 10000) then Some(func x, x + 1) else None)
    |> Seq.filter (fun x -> x >= 1000)
    |> List.ofSeq

// Builds a list of entities by applying a sequence to it.
let buildCyclicalFigurates elements sequence =
    elements
    |> List.collect (fun element ->
        sequence
        |> Seq.choose (fun p -> if isCyclic (List.head element) p then Some(p :: element) else None)
        |> List.ofSeq)

// Applies a sequence to a list of elements.
let rec applySequences elements sequences =
    match sequences with
    | [] -> elements
    | sequence :: xs -> applySequences (buildCyclicalFigurates elements sequence) xs

// Create the initial sequence from p3.
let initialSequence =
    (createSequence p3)
    |> Seq.map (fun x -> [ x ])
    |> List.ofSeq

// Generate the permutations. This only generates permutations that start with p3.
let permutations =
    [ p4; p5; p6; p7; p8 ]
    |> List.map createSequence
    |> createPermutations

permutations
|> List.map (fun permutation ->
    applySequences initialSequence permutation
    |> List.map List.rev
    |> List.filter (fun x -> isCyclic (List.last x) (List.head x))
    |> List.collect (fun x -> x |> List.fold (fun acc y -> y::acc) []))
|> List.filter (List.isEmpty >> not)
|> List.collect (fun x -> x |> List.fold (fun acc y -> y::acc) [])
|> List.sum