Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRestar.Click
        Dim form2 As New Resta()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        Dim form2 As New Division()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        Dim form2 As New Suma()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        Dim form2 As New Multiplicacion()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub BtnElevar_Click(sender As Object, e As EventArgs) Handles BtnElevar.Click
        Dim form2 As New Potencia()
        form2.Show()
        Me.Close()
    End Sub
End Class
