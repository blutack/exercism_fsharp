module Clock

type Clock = int

let minutesInHour = 60
let hoursToMinutes hours = hours * minutesInHour
let minutesInDay = hoursToMinutes 24

let rec clampToDay secs: Clock = 
    match secs with
    | s when s < 0 -> minutesInDay + s |> clampToDay
    | s when s >= minutesInDay -> s - minutesInDay |> clampToDay
    | s -> s

let create hours minutes = 
    hoursToMinutes hours + minutes |> clampToDay

let add minutes clock = 
    clock + minutes |> clampToDay

let subtract minutes clock =
    clock - minutes |> clampToDay

let display (clock: Clock) =
    System.String.Format("{0:00}:{1:00}", (clock / minutesInHour), (clock % minutesInHour))