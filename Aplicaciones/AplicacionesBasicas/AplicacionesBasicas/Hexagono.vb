Public Class Hexagono
    Inherits Formas
    
    Public Overrides Function perimetro(lado) As Object
        return 6 * lado
    End Function

    Public Overrides Function area(lado) As Object
        return (perimetro(lado) * Math.Sqrt(lado^2-(lado/2)^2)) / 2
    End Function
    
End Class