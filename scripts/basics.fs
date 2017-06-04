printfn "Hello Foo"
printfn "Hello %s" "Bar"
printfn "Hello %i" 42

let square num = num * num
let squared = List.map square [1;2;3;4;5]

printfn "%A" squared
