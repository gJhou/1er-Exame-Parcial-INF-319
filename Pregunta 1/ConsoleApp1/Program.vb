Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("Introduzca tres numeros")
        a = Convert.ToInt32(Console.ReadLine())

        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())


        Dim auxa As Integer
        auxa = a

        Dim i As Integer
        i = 3
        Dim m As Integer
        m = 0

        Console.WriteLine("ordenados ascendentemente")

contar:
        m = m + 1


        If a > b And a > c Then
            Console.WriteLine(a)
            a = 0
        End If

        If b > a And b > c Then
            Console.WriteLine(b)
            b = 0
        End If
        If c > b And c > a Then
            Console.WriteLine(c)
            c = 0
        End If

        If m < i Then GoTo contar : 

        Console.ReadKey()
    End Sub
End Module
