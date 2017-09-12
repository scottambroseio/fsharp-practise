let input = [1;2;3;4;5]

let printArray arr =
  let rec printArrayInner _arr = 
    match _arr with
    | [] -> arr
    | head :: tail ->
      printfn "%A" head
      printArrayInner tail
  printArrayInner arr

let doubleList list = List.map (fun x -> x * 2) list

input
  |> printArray
  |> doubleList
  |> printArray
  |> (doubleList >> doubleList)
  |> printArray
