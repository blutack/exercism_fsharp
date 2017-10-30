module QueenAttack

let create (position: int * int) = 
    let inRange = fun x -> 0 <= x && x < 8
    inRange (fst position) && inRange (snd position)

let canAttack (queen1: int * int) (queen2: int * int) =
    let sharedRow = fst queen1 = fst queen2
    let sharedColumn = snd queen1 = snd queen2
    let diag = abs(fst queen1 - fst queen2) = abs(snd queen1 - snd queen2)
    sharedRow || sharedColumn || diag