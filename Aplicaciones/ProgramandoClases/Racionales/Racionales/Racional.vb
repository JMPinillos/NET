Public Class Racional
    
    Public Property numerador As Integer
    Public Property denominador As Integer
    
    ' CONSTRUCTOR DEL RACIONAL
    Public Sub New(n As Integer, d As Integer)
        numerador = n
        denominador = d
    End sub
    
    ' CONSTRUCTOR QUE MODIFICA EL RACIONAL
    Public Sub Modificar(n As Integer, d As Integer)
        numerador = n
        denominador = d
    End sub
    
    ' FUNCIÓN PARA LEER EL RACIONAL
    Public Function Leer() As String
        Return $"{numerador}/{denominador}"
    End Function
    
End Class