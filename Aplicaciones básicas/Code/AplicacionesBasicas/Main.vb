Imports System

Module Main
    Sub Main(args As String())
        ' Declarar variables
        Dim cuadrado As New Cuadrado
        Dim circulo As New Circulo
        Dim triangulo As New Triangulo
        Dim hexagono As New Hexagono
        Dim lado As Double

        ' ************************** CUADRADO **************************
        ' Solicitar al usuario que ingrese el lado del cuadrado
        Console.Write("Ingrese la longitud de un lado del cuadrado: ")
        
        ' A la valible ladoCuadrado se le asigna  el valor de entrada del usuario
        ' transformandolo a Double, porque la entrada del usuario es tratada
        ' como texto por defecto
        lado = Convert.ToDouble(Console.ReadLine())
        
        ' Mostrar los resultados
        Console.WriteLine("El perímetro del cuadrado es: " & cuadrado.perimetro(lado))
        Console.WriteLine("El área del cuadrado es: " & cuadrado.area(lado))
        
        ' Esperar a que el usuario presione una tecla antes de continuar
        Console.WriteLine("Presione cualquier tecla para continuar..." & vbCrLf)
        Console.ReadKey(True)
        
        ' ************************** CÍRCULO **************************
        Console.Write("Ingrese la longitud del diametro del circulo: ")
        lado = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("El perímetro del círculo es: " & circulo.perimetro(lado))
        Console.WriteLine("El área del círculo es: " & circulo.area(lado))
        
        Console.WriteLine("Presione cualquier tecla para continuar..." & vbCrLf)
        Console.ReadKey(True)
        
        ' ************************** TRIANGULO **************************
        
        Console.Write("Ingrese la longitud de un lado del triángulo equilatero: ")
        lado = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("El perímetro del triángulo es: " & triangulo.perimetro(lado))
        Console.WriteLine("El área del triángulo es: " & triangulo.area(lado))
        
        Console.WriteLine("Presione cualquier tecla para continuar..." & vbCrLf)
        Console.ReadKey(True)
        
        ' ************************** HEXÁGONO **************************
        
        Console.Write("Ingrese la longitud de un lado del hexágono: ")
        lado = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("El perímetro del hexágono es: " & hexagono.perimetro(lado))
        Console.WriteLine("El área del hexágono es: " & hexagono.area(lado))
        
    End Sub
End Module