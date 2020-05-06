(*
  Problem 17
  Number letter counts

  If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
  If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
  
  NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*)
let getThousandWord thousands =
  let word =
    match thousands with
    | 1 -> Some("one")
    | _ -> None

  match word with
  | Some(x) -> Some(x + "thousand")
  | None -> None

let getHundredWord hundreds =
  let word = 
    match hundreds with
    | 1 -> Some("one")
    | 2 -> Some("two")
    | 3 -> Some("three")
    | 4 -> Some("four")
    | 5 -> Some("five")
    | 6 -> Some("six")
    | 7 -> Some("seven")
    | 8 -> Some("eight")
    | 9 -> Some("nine")
    | _ -> None

  match word with
  | Some(x) -> Some(x + "hundred")
  | None -> None

let getTenWord tens ones =
  match tens with
    | 1 ->
      match ones with
      | 0 -> Some("ten")
      | 1 -> Some("eleven")
      | 2 -> Some("twelve")
      | 3 -> Some("thirteen")
      | 4 -> Some("fourteen")
      | 5 -> Some("fifteen")
      | 6 -> Some("sixteen")
      | 7 -> Some("seventeen")
      | 8 -> Some("eighteen")
      | 9 -> Some("nineteen")
    | 2 -> Some("twenty")
    | 3 -> Some("thirty")
    | 4 -> Some("forty")
    | 5 -> Some("fifty")
    | 6 -> Some("sixty")
    | 7 -> Some("seventy")
    | 8 -> Some("eighty")
    | 9 -> Some("ninety")
    | _ -> None

let getOneWord tens ones =
  match tens with
  | 1 -> None
  | _ ->
    match ones with
    | 1 -> Some("one")
    | 2 -> Some("two")
    | 3 -> Some("three")
    | 4 -> Some("four")
    | 5 -> Some("five")
    | 6 -> Some("six")
    | 7 -> Some("seven")
    | 8 -> Some("eight")
    | 9 -> Some("nine")
    | _ -> None

let getWord wordOption =
  match wordOption with
  | Some(x) -> x
  | None -> ""

let numberToWord number =
  let thousands = getThousandWord ((number % 10000) / 1000)
  let hundreds = getHundredWord ((number % 1000) / 100)
  let tens = getTenWord ((number % 100) / 10) (number % 10)
  let ones = getOneWord ((number % 100) / 10) (number % 10)

  getWord thousands + 
  getWord hundreds + 
  (if hundreds.IsSome && (tens.IsSome || ones.IsSome) then "and" else "") + 
  getWord tens + getWord ones

[1..1000]
|> List.map numberToWord
|> List.map (fun x -> String.length x)
|> List.sum
