module RobotSimulator

type Bearing = 
| North
| East
| South
| West

type Coordinate = int * int

type Direction = 
| Left = -1
| Right = 1

type Robot = { bearing: Bearing; coordinate: Coordinate }

let directionOrder = [North; East; South; West]

let createRobot bearing coordinate = 
    { bearing = bearing; coordinate = coordinate; }

let turn robot direction =
    let idx = List.findIndex ((=) robot.bearing) directionOrder
    let bearing = match idx + int direction with
                  | -1 -> West
                  | 4 -> North
                  | i -> directionOrder.[i]
    createRobot bearing robot.coordinate

let turnLeft robot =
    turn robot Direction.Left

let turnRight robot = 
    turn robot Direction.Right

let advance robot =
    let c = robot.coordinate
    let newCoordinates =
        match robot.bearing with
        | North -> (fst c, snd c + 1)
        | East -> (fst c + 1, snd c)
        | South -> (fst c, snd c - 1)
        | West -> (fst c - 1, snd c)
    createRobot robot.bearing newCoordinates

let rec action (c: char list) robot = 
    match c with
    | 'A'::tail -> advance robot |> action tail
    | 'L'::tail -> turnLeft robot |> action tail
    | 'R'::tail -> turnRight robot |> action tail
    | _::_ -> failwith "Invalid instruction"
    | [] -> robot

let simulate robot instructions = 
    action [for c in instructions -> c] robot