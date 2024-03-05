Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSimbol.Text = ""
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim form1 As New Form1
        form1.Show()
        Close()
    End Sub

    Private Sub TxbNum1_Leave(sender As Object, e As EventArgs) Handles TxbNum1.Leave
        If Not IsNumeric(TxbNum1.Text) Then
            MsgBox("Debe ingresar un número", vbExclamation, Title:="¡Atención!")
            TxbNum1.Text = ""
            TxbNum1.Focus()
        End If
    End Sub

    Private Sub TxbNum2_Leave(sender As Object, e As EventArgs) Handles TxbNum2.Leave
        If Not IsNumeric(TxbNum2.Text) Then
            MsgBox("Debe ingresar un número", vbExclamation, Title:="¡Atención!")
            TxbNum2.Text = ""
            TxbNum2.Focus()
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TxbDen1.Leave
        If TxbDen1.Text = "" Then
        ElseIf Not IsNumeric(TxbDen1.Text) Then
            MsgBox("Debe ingresar un número", vbExclamation, Title:="¡Atención!")
            TxbDen1.Text = ""
            TxbDen1.Focus()
        ElseIf (Convert.ToInt32(TxbDen1.Text) = 0) Then
            MsgBox("El denominador no puede ser 0", vbExclamation, Title:="¡Atención!")
            TxbDen1.Text = ""
            TxbDen1.Focus()
        End If
    End Sub

    Private Sub TxbDen2_Leave(sender As Object, e As EventArgs) Handles TxbDen2.Leave

        If TxbDen2.Text = "" Then
        ElseIf Not IsNumeric(TxbDen2.Text) Then
            MsgBox("Debe ingresar un número", vbExclamation, Title:="¡Atención!")
            TxbDen2.Text = ""
            TxbDen2.Focus()
        ElseIf (Convert.ToInt32(TxbDen2.Text) = 0) Then
            MsgBox("El denominador no puede ser 0", vbExclamation, Title:="¡Atención!")
            TxbDen2.Text = ""
            TxbDen2.Focus()
        End If
    End Sub

    Private Sub TxbDen2_TextChanged_1(sender As Object, e As EventArgs) Handles TxbDen2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMulti.Click
        If TxbDen1.Text = "" Or TxbDen2.Text = "" Or TxbNum1.Text = "" Or TxbNum2.Text = "" Then
            MsgBox("Debe rellenar todos los campos", vbExclamation, Title:="¡Atención!")
        Else
            ' Mostrar el símbolo de la operación
            LblSimbol.Text = "x"

            Dim num1 As Integer = Convert.ToInt32(TxbNum1.Text)
            Dim den1 As Integer = Convert.ToInt32(TxbDen1.Text)
            Dim num2 As Integer = Convert.ToInt32(TxbNum2.Text)
            Dim den2 As Integer = Convert.ToInt32(TxbDen2.Text)

            ' Calcular el numerador y el denominador del resultado
            Dim numResult As Integer = num1 * num2
            Dim denResult As Integer = den1 * den2

            ' Simplificar el resultado
            Dim divisor As Integer = MCD(numResult, denResult)
            numResult /= divisor
            denResult /= divisor

            ' Mostrar el resultado simplificado
            TxbNumResult.Text = numResult.ToString()
            TxbDenResult.Text = denResult.ToString()
        End If
    End Sub

    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        If TxbDen1.Text = "" Or TxbDen2.Text = "" Or TxbNum1.Text = "" Or TxbNum2.Text = "" Then
            MsgBox("Debe rellenar todos los campos", vbExclamation, Title:="¡Atención!")
        Else
            ' Mostrar el símbolo de la operación
            LblSimbol.Text = "/"

            Dim num1 As Integer = Convert.ToInt32(TxbNum1.Text)
            Dim den1 As Integer = Convert.ToInt32(TxbDen1.Text)
            Dim num2 As Integer = Convert.ToInt32(TxbNum2.Text)
            Dim den2 As Integer = Convert.ToInt32(TxbDen2.Text)

            ' Calcular el numerador y el denominador del resultado
            Dim numResult As Integer = num1 * den2
            Dim denResult As Integer = den1 * num2

            ' Simplificar el resultado
            Dim divisor As Integer = MCD(numResult, denResult)
            numResult /= divisor
            denResult /= divisor

            ' Mostrar el resultado simplificado
            TxbNumResult.Text = numResult.ToString()
            TxbDenResult.Text = denResult.ToString()
        End If
    End Sub

    ' Calcular el máximo común divisor de dos números
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