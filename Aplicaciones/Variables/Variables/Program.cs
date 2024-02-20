// See https://aka.ms/new-console-template for more information


Sub Main()
' Declarar variable para el lado del cuadrado
    Dim lado As Double

' Solicitar al usuario que ingrese el lado del cuadrado
Console.Write("Ingrese la longitud del lado del cuadrado: ")
lado = Convert.ToDouble(Console.ReadLine())

' Calcular el perímetro y el área
Dim perimetro As Double = 4 * lado
Dim area As Double = lado * lado

' Mostrar los resultados
Console.WriteLine("El perímetro del cuadrado es: " & perimetro)
Console.WriteLine("El área del cuadrado es: " & area)

' Esperar a que el usuario presione una tecla antes de cerrar
Console.WriteLine("Presione cualquier tecla para salir...")
Console.ReadKey()
End Sub

End Module