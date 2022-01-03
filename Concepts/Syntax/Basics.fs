namespace Psych.Concepts.Syntax

open System

module Basics =

    printfn "A string: %s. An int: %i. A float: %f. A bool: %b" "hello." 42 3.14 true 
    printfn "A tuple %A or object %O" (1, 2, 3) DateTime.Now
    printfn "A precise float %M" 1.2345675565465M
    printfn "%*s" 10 "padding 10 from left"

    let func_one x = x + 1
    let func_two y = y - 1
    let one_two = func_one >> func_two
    let two_one = func_one << func_two

    // Casting
    let number = 7
    printfn "Type: %A" (number.GetType())
    printfn "float %f" (float number)
    printfn "int %i" (int number)

    // Strings
    let ignoreBackslash = @"\ \f\\\fdsf"
    let ignoreQuoteNBackslash = """ \ "" """
    let length = String.length ignoreBackslash
    let length' = ignoreQuoteNBackslash.Length

    let somestr = "somestring"
    let char = somestr.[1]
    let range = somestr.[1..4]

    /// pass in a string
    let collectedStr = String.collect (fun char -> sprintf "%c, " char)
    let charExists = String.exists(fun char -> Char.IsUpper char)
    let all = String.forall(fun char -> Char.IsLetter char)
    /// Generate from 0 to 14 as string
    let init = String.init 14 (fun i -> i.ToString())
    let iter = String.iter(fun char -> printf "%c" char)

    // Loop
    let mutable input = ""
    while not (true) do
        input <- Console.ReadLine()

    for i = 1 to 10 do
        printf "%i" i

    for i = 10 downto 1 do
        printf "%i" i

    for i in [1..10] do
        printf "%i" i

    // preferred way
    [1..10] |> List.iter(printfn "%i")
    let sum = List.reduce (+)

    // Conditionals

    if true then
        printf ""
    elif false then
        printf ""
    else
        printf ""

    let evaluatedString =
        match number with
        | number when number > 8 -> "eight"
        | number when number < 5 -> "five"
        | _ -> number.ToString()

    // List
    let list = [1;2;3;4]
    let list' = 5::6::7::[]
    let list'' = ['a'..'z']
    let list''' = [for a in 1..5 do yield (a * a)]
    let list'''' = [for a in 1..20 do if a % 2 = 0 then yield a]
    let list''''' = [for a in 1..3 do yield! [a..a+2]]

    let isEmpty = list'''.IsEmpty
    let index2 = list'''.Item(2)
    let head = list'''.Head
    let tail = list'''.Tail

    let list'''''' = list''' |> List.filter(fun x -> x % 2 = 0)
    let sorted = List.sort list'''

    // Enums
    type Emotion =
    | joy = 0
    | fear = 1
    | anger = 2

    // Options
    let divide x y =
        match y with
        | 0 -> None
        | _ -> Some (x/y)

    if (divide 1 2).IsNone then
        printf "cant divide by 0"
    else
        printf("ok")

    // Tuple
    let funct (w, x, y, z): float =
        w + x + y + z

    printfn "%f" (funct (1.0, 3.0, 5.0, 3.0))

    // Records
    type Customer =
        { Name: string; balance: float }

    let doug = { Name = "doug"; balance = 3.14 }

    // Sequence
    let seq1 = seq { 1..100 }
    let seq2 = seq { 0..2..100 }
    let descendingSeq = seq { 50..1 }
    let seqList = Seq.toList seq1

    let isPrime n = 
        let rec check i =
            i > n / 2 || (n % i <> 0 && check(i + 1))
        check n

    let primeSeq = seq { for a in 1..500 do if isPrime a then yield a }

    // Maps
    let myMap =
        Map.empty
           .Add("key1", 4)
           .Add("Key2", 6)

    let mapLen = myMap.Count
    let tryKey1 = myMap.TryFind "key1"
    let containKey1 = myMap.ContainsKey "key1"
    let key1val = myMap.["key1"]
    let newMap = Map.remove "key1" myMap

    // Generics
    let add<'T> x y =
        x + y

    let answer = add<float> 1.0 2.0

    // Exceptions
    let trye =
        try
            4 / 0
        with
        | :? System.DivideByZeroException -> 6

    let tryex =
        try
            if 0 = 0 then raise(DivideByZeroException("Cannot divide by 0"))
            else
                printf "Ok"
        with
        | :? System.DivideByZeroException as ex -> printf "not ok"

    // Struct
    type Rectangle = struct
        val Length: float
        val Width: float

        new (width, length) =
            { Length = length; Width = width}
    end

    let rect = new Rectangle(1.0, 3.0)

    type House = class
        val Name: string
        val Location: string
        val Color: string

        new (name, location, color) =
            { Name = name; Location = location; Color = color }

        member this.Run =
            printfn "this %s" this.Name
    end

    type CoolHouse(name, location, color) = 
        inherit House(name, location, color)

        member this.Cool =
            printfn "this cooling down"


    module Say =
        
        let hello name =
            printfn "Hello %s" name


    module Samples =
        
        let sampleArray = [|1; 2; 3; 4; 5|]
        let sampleList = [1; 2; 3; 4; 5]
        let sampleSequence =
            seq {
                yield! [5..10]
            }

        let mutable variable = 123
        variable <- 246

        let newlineSeperatedList = [
            "this"
            "is"
            "a"
            "string"
            "list"
        ]

        let private isOdd x = x % 2 <> 0
        let squareOfOdds xs =
            xs
            |> Seq.filter isOdd
            |> Seq.map (fun x -> x * 2)

        let refUses = ref 10
        refUses := 50
        printfn "%i" ! refUses

        let rec last list =
            match list with
            | [x] -> x
            | _::tail -> last tail
            | _ -> failwith "Empty list"

        let options list = 
            match List.tryLast list with
            | Some x -> x
            | None -> 0
