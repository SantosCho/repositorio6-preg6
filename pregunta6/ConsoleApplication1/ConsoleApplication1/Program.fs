// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
let suma a b= a + b
let resta a b= a - b
let multiplica a b =a*b
let division a b = a/b
[<EntryPoint>]
let main argv = 

    Console.WriteLine("Introdusca 2 numero para la SUMA")
    let num1=Console.ReadLine()
    let num2=Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3=suma valor1 valor2
    Console.WriteLine("La SUMA de los Numeros es:  " + valor3.ToString())
    Console.WriteLine("")
    Console.WriteLine("Introdusca 2 numero para la RESTA")
    let num1=Console.ReadLine()
    let num2=Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3=resta valor1 valor2
    Console.WriteLine("La RESTA de los Numeros es:  " + valor3.ToString())
    Console.WriteLine("")
    Console.WriteLine("Introdusca 2 numero para la MULTIPLICACION")
    let num1=Console.ReadLine()
    let num2=Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3=multiplica valor1 valor2
    Console.WriteLine("La MULTIPLICACION de los Numeros es:  " + valor3.ToString())
    Console.WriteLine("")
    Console.WriteLine("Introdusca 2 numero para la DIVISION")
    let num1=Console.ReadLine()
    let num2=Console.ReadLine()
    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)
    let valor3=division valor1 valor2
    Console.WriteLine("La DIVISION de los Numeros es:  " + valor3.ToString())
    printfn "%A" argv
    let tecla=Console.ReadKey()
    0 // return an integer exit code
