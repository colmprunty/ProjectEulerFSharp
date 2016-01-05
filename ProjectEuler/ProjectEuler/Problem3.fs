namespace Problem3

module Problem3 =
    let rec doSomething theLargeNumber x theList = 
        if x = theLargeNumber then
            x::theList
        elif theLargeNumber % x = 0L then
            doSomething (theLargeNumber/x) x (x::theList)
        else
            doSomething theLargeNumber (x+1L) theList

    let factorise n = doSomething n 2L [] // method, endpoint, startpoint, empty list
    let factors = factorise 600851475143L

    // doSomething theLargeNumber firstFactor listOfFactors