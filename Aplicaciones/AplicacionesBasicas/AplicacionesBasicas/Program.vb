Imports System

Module Program
    Sub Main(args As String())
        ' Declarar variable para el lado del cuadrado
        Dim ladoCuadrado As Double
        Dim ladoTriangulo As Double
        Dim ladoCirculo As Double
        Dim ladoHexagono As Double

        ' ************************** CUADRADO **************************
        ' Solicitar al usuario que ingrese el lado del cuadrado
        Console.Write("Ingrese la longitud del lado del cuadrado: ")
        
        ' A la valible ladoCuadrado se le asigna  el valor de entrada del usuario
        ' transformandolo a Double, porque la entrada del usuario es tratada
        ' como texto por defecto
        ladoCuadrado = Convert.ToDouble(Console.ReadLine())
        
        ' Calcular el perímetro y el área del cuadrado
        Dim perimetro As Double = 4 * ladoCuadrado
        Dim area As Double = ladoCuadrado * ladoCuadrado
        
        ' Mostrar los resultados
        Console.WriteLine("El perímetro del cuadrado es: " & perimetro)
        Console.WriteLine("El área del cuadrado es: " & area)

        ' Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...")
        
        ' ************************** TRIANGULO **************************

        Console.Write("Ingrese la longitud del lado del triangulo: ")
        ladoTriangulo = Convert.ToDouble(Console.ReadLine())
        Dim
        Dim perimetro As Double = 3 * ladoTriangulo
        Dim area As Double = ladoTriangulo * ladoCuadrado

        ' ************************** CIRCULO **************************
        Console.Write("Ingrese la longitud del lado del circulo: ")
        ladoCirculo = Convert.ToDouble(Console.ReadLine())
        
        Dim perimetro As Double = 4 * ladoCuadrado
        Dim area As Double = ladoCuadrado * ladoCuadrado

        ' ************************** HEXAGONO **************************
        Console.Write("Ingrese la longitud del lado del hexagono: ")
        ladoHexagono = Convert.ToDouble(Console.ReadLine())
        
        Dim perimetro As Double = 4 * ladoCuadrado
        Dim area As Double = ladoCuadrado * ladoCuadrado
        

        

        ' Mostrar los resultados
        Console.WriteLine("El perímetro del cuadrado es: " & perimetro)
        Console.WriteLine("El área del cuadrado es: " & area)

        ' Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para salir...")

    End Sub
End Module
