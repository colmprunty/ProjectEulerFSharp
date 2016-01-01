namespace Problem2

module Problem2 =
    let mutable x = 1
    let mutable y = 2    

    let getNextFibbonaci() =
        let n = x + y
        x <- y
        y <- n
        System.Console.WriteLine(y)

    let doTheThing() = 
        while x < 4000000
            do getNextFibbonaci()

    doTheThing()