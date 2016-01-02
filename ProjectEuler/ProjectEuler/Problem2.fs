namespace Problem2

module Problem2 =
    let mutable x = 1
    let mutable y = 2
    let mutable n = 0
    let mutable sum = 0

    let getNextFibonacci() =
        n <- x + y
        x <- y
        y <- n     

    let doTheThing() = 
        while x < 4000000 do
            getNextFibonacci() 
            if(n % 2 = 0)
                then sum <- sum + n

    doTheThing()
    System.Console.WriteLine(sum)