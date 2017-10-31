module Raindrops

type Sound = int * string

let sounds: Sound list = [
    (3, "Pling");
    (5, "Plang");
    (7, "Plong")
] 

let convert (number: int): string =
    let factorOfSound = 
        fun sound -> 
            if number % fst sound = 0 
            then Some(snd sound) else None

    let noises = sounds |> List.choose(factorOfSound)

    match noises with
    | [] -> string(number)
    | l -> String.concat "" l