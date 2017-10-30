module GradeSchool

let empty: Map<int, string list> =
    Map.empty<int, string list>

let grade (number: int) (school: Map<int, string list>): string list =
    defaultArg (Map.tryFind number school) List.empty<string> |> List.sort

let roster (school: Map<int, string list>): (int * string list) list =
    Map.toSeq school
    |> Seq.map fst |> Seq.toList |> List.sort
    |> List.map (fun gradeNumber -> (gradeNumber, grade gradeNumber school))

let add (student: string) (gradeNumber: int) (school: Map<int, string list>): Map<int, string list> =
    Map.add gradeNumber (student :: grade gradeNumber school) school