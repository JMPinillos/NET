Public Class Suma
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim num1 As Double = Convert.ToDouble(TextBox1.Text)
        Dim num2 As Double = Convert.ToDouble(TextBox2.Text)
        Dim resultado As Double = num1 + num2
        TextBox3.Text = resultado.ToString()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim texto As String = "¿Seguro que desea salir?"
        Dim estilo As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        Dim titulo As String = "Salir"
        Dim respuesta As MsgBoxResult

        respuesta = MsgBox(texto, estilo, titulo)

        If respuesta = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Suma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class