printfn "Hello Foo"
printfn "Hello %s" "Bar"
printfn "Hello %i" 42

let square num = num * num
let squared = List.map square [2;3;4;5]

printfn "%A" squared

let updatedSquared = square 1 :: squared

printfn "%A" updatedSquared
