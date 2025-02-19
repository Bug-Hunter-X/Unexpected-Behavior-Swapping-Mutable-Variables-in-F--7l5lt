let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Prints 20 20 as expected

let mutable a = 10
let mutable b = 20

let swap2 (x:int byref) (y:int byref) = 
    let temp = x
    x <- y
    y <- temp

swap2 &a &b
printf "%d %d" a b //Prints 20 10 as expected

//The problem happens when we try to swap more than 2 variables.

let mutable a = 10
let mutable b = 20
let mutable c = 30

let swap3 (x:int byref) (y:int byref) (z:int byref) = 
    let temp = x
    x <- y
    y <- z
    z <- temp

swap3 &a &b &c
printf "%d %d %d" a b c //Prints 20 30 10 as expected

let mutable a = 10
let mutable b = 20
let mutable c = 30
let mutable d = 40

let swap4 (x:int byref) (y:int byref) (z:int byref) (w:int byref) = 
    let temp = x
    x <- y
    y <- z
    z <- w
    w <- temp

swap4 &a &b &c &d
printf "%d %d %d %d" a b c d //Prints 20 30 40 10 as expected

//But when using tuples, the issue becomes apparent:

let swapTuple (x,y) = (y,x)

let a,b = 10,20
let a',b' = swapTuple (a,b)
printf "%d %d" a' b' //Prints 20 10

let a,b,c = 10,20,30
let a',b',c' = swapTuple (a,b,c) //Error: This line will cause a compile-time error because swapTuple is not defined for tuples of size 3
printf "%d %d %d" a' b' c'