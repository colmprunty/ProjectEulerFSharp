namespace Problem1

module Problem1 =
    let problem1 = 
        [1..999]
        |> Seq.filter(fun x -> x % 3 = 0 || x % 5 = 0)
        |> Seq.fold(+) 0

    printfn "Problem 1 = %d" problem1


// this doesn't work
//let problem1b =
//    [0..3..999] @ [0..5..999]
//    |> Seq.fold(+) 0
//
//printfn "Problem 1 = %d" problem1b