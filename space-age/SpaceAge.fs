module SpaceAge

// TODO: define the Planet type
type Planet = 
| Earth
| Mercury 
| Venus

let Orbit (planet: Planet) = 
    match planet with
    | Earth -> decimal

let spaceAge (planet: Planet) (seconds: decimal): decimal = 
    seconds * Orbit planet