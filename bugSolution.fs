let rec swapTupleN tuple = 
    match tuple with
    | (a, b) -> (b, a)
    | (a, b, c) -> (c, a, b) // add more patterns for different tuple lengths as needed
    | (a, b, c, d) -> (d, a, b, c)
    | (a, b, c, d, e) -> (e, a, b, c, d)
    | _ -> failwith "Tuple size not supported" 

// Example usage:

let a, b = 10, 20
let a', b' = swapTupleN (a, b)
printfn "%d %d" a' b'

let a, b, c = 10, 20, 30
let a', b', c' = swapTupleN (a, b, c)
printfn "%d %d %d" a' b' c'

let a, b, c, d = 10, 20, 30, 40
let a', b', c', d' = swapTupleN (a, b, c, d)
printfn "%d %d %d %d" a' b' c' d' 

let a, b, c, d, e = 10, 20, 30, 40, 50
let a', b', c', d', e' = swapTupleN (a, b, c, d, e)
printfn "%d %d %d %d %d" a' b' c' d' e' 