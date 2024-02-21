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
        If (numerador Mod denominador = 0) Then
            Return $"{numerador}/{denominador}, pero ademas es el número entero {numerador/denominador}"
        End If
        Return $"{numerador}/{denominador}"
    End Function
    
End Class