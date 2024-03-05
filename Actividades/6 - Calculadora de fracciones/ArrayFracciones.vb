Friend Class ArrayFracciones
    Public Sub New(numeroFracciones As Integer)

        ' Agrega las fracciones al array.
        Dim fracciones(numeroFracciones - 1) As Fraccion ' Instancia a la clase Fraccion

        ' Declara un array de fracciones con el tamaño especificado.
        For i As Integer = 0 To numeroFracciones - 1
            Dim numerador As String
            Dim denominador As String
            Dim numeradorValido As Integer
            Dim denominadorValido As Integer

            ' Solicita el numerador y verifica si es un valor numérico válido.
            Do
                numerador = InputBox($"Ingresa el numerador para la fracción {i + 1}:", "Numerador", "1")
                If String.IsNullOrEmpty(numerador) Then
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub ' Sale del Sub si se cancela la operación
                ElseIf Not Integer.TryParse(numerador, numeradorValido) Then
                    MessageBox.Show("Debe ingresar un número válido para el numerador.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop Until Integer.TryParse(numerador, numeradorValido)

            ' Solicita el denominador y verifica si es un valor numérico válido.
            Do
                denominador = InputBox($"Ingresa el denominador para la fracción {i + 1}:", "Denominador", "1")
                If String.IsNullOrEmpty(denominador) Then
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub ' Sale del Sub si se cancela la operación
                ElseIf Not Integer.TryParse(denominador, denominadorValido) Or denominadorValido = 0 Then
                    MessageBox.Show("Debe ingresar un número válido y diferente de cero para el denominador.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop Until Integer.TryParse(denominador, denominadorValido) And denominadorValido <> 0

            ' Simplificar el resultado
            Dim divisor As Integer = MCD(numeradorValido, denominadorValido)
            numeradorValido /= divisor
            denominadorValido /= divisor

            ' Una vez validados, se crean las fracciones con los valores numéricos.
            fracciones(i) = New Fraccion(numeradorValido, denominadorValido)
        Next

        ' Muestra las fracciones ingresadas
        Dim fraccionesStr As String = String.Join(Environment.NewLine, fracciones.Select(Function(f) $"{f.Numerador}/{f.Denominador}"))
        MessageBox.Show($"Fracciones ingresadas:{Environment.NewLine}{fraccionesStr}")
    End Sub

    Private Function MCD(a As Integer, b As Integer) As Integer
        ' Repetir mientras los dos números sean diferentes
        While b <> 0
            Dim temp As Integer = b
            b = a Mod b
            a = temp
        End While
        Return a
    End Function

End Class

Public Class Fraccion
    Public Numerador As Integer
    Public Denominador As Integer

    Public Sub New(n As Integer, d As Integer)
        Numerador = n
        Denominador = d
    End Sub
End Class



