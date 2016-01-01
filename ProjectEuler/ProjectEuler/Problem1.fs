let mutable sum = 0

let sumFunctions() =
    for i in 1 .. 999 do
        if i%3 = 0 || i%5 = 0 then
            sum <- sum + i

sumFunctions()
System.Console.WriteLine(sum)