module Bob

let containsCharacter(str: string) = str |> Seq.exists(fun c -> System.Char.IsLetter(c))

let response (input: string): string = 
    match input.Trim() with
    | l when containsCharacter(l) && l.ToUpper() = l -> "Whoa, chill out!"
    | l when l.EndsWith("?") -> "Sure."
    | l when l = "" -> "Fine. Be that way!"
    | _ -> "Whatever."