// Learn more about F# at http://fsharp.org

open System
module calculadora =
    let suma x y=x+y
    let resta x y = x-y
    let multi x y=
        let mutable s=0
        for i in 1..y do
            s<- s+x
        s
        
    let divide x y=x/y

module calculadora2=
    let valor1=100
    let suma3 x y z= (calculadora.suma x y)+z
    

[<EntryPoint>]
let main argv =
    Console.WriteLine("Introduzca valores")
    let a = Convert.ToInt32(Console.ReadLine())
    let b = Convert.ToInt32(Console.ReadLine())
    let c= a+b
    let d= a-b
    let e=a*b
    let f=a/b

    Console.WriteLine("La suma es igual a: "+c.ToString())
    let c =calculadora.suma a b

    Console.WriteLine("La resta es igual a: "+d.ToString())




    Console.WriteLine("La multiplicacion es igual a: "+(calculadora.multi a b).ToString())

    Console.WriteLine("La divición es igual a: "+(calculadora.divide a b).ToString())

    let tecla=Console.ReadKey()
    
    
    //printfn "Hello World from F#!"
    0 // return an integer exit code
