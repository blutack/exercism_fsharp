module Accumulate

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec loop l acc  =
       match l with
       | head :: tail -> loop tail (func(head) :: acc)
       | [] -> acc
      
    loop input List.empty |> List.rev