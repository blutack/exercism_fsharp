module TwoFer

let getResponse (input: string option): string = 
    let response = Option.defaultValue "you" input
    sprintf "One for %s, one for me." response