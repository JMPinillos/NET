Public Class Triangulo
    Inherits Formas
    
    Public Overrides Function perimetro(lado) As Object
        return 3 * lado
    End Function

    Public Overrides Function area(lado) As Object
        return (lado * Math.Sqrt(lado^2-(lado/2)^2))/2
    End Function
    
End Class