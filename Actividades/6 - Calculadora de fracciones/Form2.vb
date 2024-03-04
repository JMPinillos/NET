Imports MySqlConnector
Public Class Form2


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim form1 As New Form1
        form1.Show()
        Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxbDen1.AcceptsTabChanged
        Dim den1 As Double = Convert.ToDouble(TxbDen1.Text)
        If (den1 = 0) Then
            MsgBox("El denominador no puede ser 0", vbExclamation, Title:="¡Atención!")
        End If
    End Sub

    Private Sub TxbDen2_Leave(sender As Object, e As EventArgs) Handles TxbDen2.Leave

        If TxbDen2.Text = "" Then
        ElseIf Not IsNumeric(TxbDen2.Text) Then
            MsgBox("Debe ingresar un número", vbExclamation, Title:="¡Atención!")
            TxbDen2.Text = ""
            TxbDen2.Focus()
        Else
            Dim den2 As Double = Convert.ToDouble(TxbDen2.Text)

            If (den2 = 0) Then
                MsgBox("El denominador no puede ser 0", vbExclamation, Title:="¡Atención!")
                TxbDen2.Text = ""
                TxbDen2.Focus()
            End If
        End If

    End Sub

    Private Sub TxbDen2_TextChanged_1(sender As Object, e As EventArgs) Handles TxbDen2.TextChanged

    End Sub
End Class