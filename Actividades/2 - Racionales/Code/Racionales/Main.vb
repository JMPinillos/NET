Imports System

Module Main
    Sub Main(args As String())
        
        ' Se solicita al usuario que introduzca los números
        Console.WriteLine("Introduzca el numerador y denominador para construir el racional.")
        
        ' Se declaran las variables
        Dim numerador As Integer = PedirNumero("Numerador: ")
        Dim denominador As Integer = PedirNumero("Denominador: ")
        
        ' Controlamos que el denominador sea diferente de 0
        ControlarDenominador(denominador)

        ' Creamos nuestro número racional instanciando a la clase "Racional"
        Dim racional As New Racional(numerador, denominador)
        
        ' Mostramos nuestro número racional
        MostrarRacional(racional)
        
        ' Se pregunta al usuario si desea modificar su racional
        Console.WriteLine("Introduzca nuevos valores para modificar el racional.")
        numerador = PedirNumero("Nuevo numerador: ")
        denominador = PedirNumero("Nuevo denominador: ")
        
        ControlarDenominador(denominador)
        racional.Modificar(numerador, denominador)
        
        MostrarRacional(racional)
        
    End Sub
    
    ' Función auxiliar para pedir un número al usuario
    Function PedirNumero(mensaje As String) As Integer
        Console.Write(mensaje)
        Return Convert.ToInt32(Console.ReadLine())
    End Function
    
    ' Función auxiliar para controlar que el denominador no sea 0
    Function ControlarDenominador(denominador As Integer)
        If (denominador = 0) Then
            Throw New Exception("El denominador no puede ser 0.")
        End If
    End Function
    
    ' Función auxiliar para mostrar el racional
    Function MostrarRacional(racional As Racional)
        ' Mostramos nuestro nuevo número racional llamando a la función "Leer"
        Console.WriteLine("Su nuevo número racional es: " & racional.Leer())
        Console.WriteLine("Presiona cualquier tecla para continuar...")
        Console.ReadKey(True)
    End Function
    
End Module