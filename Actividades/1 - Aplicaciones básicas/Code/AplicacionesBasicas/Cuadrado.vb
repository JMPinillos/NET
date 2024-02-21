Public Class Cuadrado
    Inherits Formas
    
    Public Overrides Function perimetro(lado) As Object
        return 4 * lado
    End Function

    Public Overrides Function area(lado) As Object
        return lado * lado
    End Function
    
End Class