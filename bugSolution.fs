let x = 10
let y = 20

let swap x y =
    let mutable xCopy = x
    let mutable yCopy = y
    let temp = xCopy
    xCopy <- yCopy
    yCopy <- temp
    (xCopy, yCopy)

let (x', y') = swap x y
printf "%d %d %d %d" x y x' y' //This will print 10 20 20 10 as expected