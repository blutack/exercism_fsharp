module Allergies

open System

type Allergen =
| Eggs = 0
| Peanuts = 1
| Shellfish = 2
| Strawberries = 3
| Tomatoes = 4
| Chocolate = 5
| Pollen = 6
| Cats = 7

let allAllergens : Allergen list = 
    unbox (Enum.GetValues(typeof<Allergen>)) |> Seq.toList

let allergicTo codedAllergies (allergen: Allergen) =
    codedAllergies &&& (1 <<< int allergen) > 0

let list codedAllergies = 
    allAllergens |> List.filter (allergicTo codedAllergies) 