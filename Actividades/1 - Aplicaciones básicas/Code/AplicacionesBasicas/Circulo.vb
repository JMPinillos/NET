Public Class Circulo
    Inherits Formas
    
    Const pi As Double = Math.PI
    
    Public Overrides Function perimetro(lado As Object) As Object
        return 2 * pi * (lado/2)
    End Function

    Public Overrides Function area(lado As Object) As Object
        return pi * ((lado/2)^2)
    End Function
    
End Class