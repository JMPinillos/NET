Imports System

Module Main
    Sub Main(args As String())
        
        Dim numerador As Integer
        Dim denominador As Integer
        
        Console.WriteLine("Introduzca un numerador: ")
        numerador = Convert.ToInt32(Console.ReadLine())
        
        Console.WriteLine("Introduzca un denominador: ")
        denominador = Convert.ToInt32(Console.ReadLine())
        
        If denominador = 0 Then
            Throw New Exception("El denominador no puede ser 0.")
        End If

        Dim racional As New Racional(numerador, denominador)
        
        Console.WriteLine($"Su número racional es: {Racional.Leer()}" )
    End Sub
End Module
