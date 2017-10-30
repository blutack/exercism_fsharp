module BeerSong

let verse (n: int) = 
    match n with
    | 0 -> "No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.\n"
    | 1 -> "1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.\n"
    | 2 -> "2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.\n"
    | _ -> sprintf "%i bottles of beer on the wall, %i bottles of beer.
Take one down and pass it around, %i bottles of beer on the wall.\n" n n (n - 1)

let verses (start: int) (stop: int): string =
    [ stop..start ] |> List.map verse |> List.rev |> String.concat "\n"

let sing: string =
    verses 99 0