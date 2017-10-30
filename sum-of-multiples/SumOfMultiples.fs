module SumOfMultiples

let multipleOfList (numbers: int list) (number: int): bool =
    numbers |> Seq.exists (fun x -> number % x = 0)

let sumOfMultiples (numbers: int list) (upperBound: int): int = 
    seq {0 .. upperBound - 1} 
    |> Seq.filter (fun x -> multipleOfList numbers x)
    |> Seq.sum