module KindergartenGarden

// TODO: define the Plant type
type Plant =
    | Grass = 'G'
    | Clover = 'C'
    | Radishes = 'R'
    | Violets = 'V'

let students = [
    "Alice", 
    "Bob",
    "Charlie",
    "David",
    "Eve",
    "Fred",
    "Ginny",
    "Harriet",
    "Ileana",
    "Joseph",
    "Kincaid",
    "Larry",
]

let plants (diagram: string) (student: string) =
    let rows = diagram.Split '\n'
    let idx = List.findIndex ((=) student)

    let plantForChar (c: char): Plant = enum c

    Array.map (fun (row: string) -> plantForChar (row.[idx * 2])) rows