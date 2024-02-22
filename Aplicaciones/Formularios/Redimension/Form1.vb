Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Width = 640
            Height = 480
        ElseIf RadioButton2.Checked Then
            Width = 800
            Height = 600
        ElseIf RadioButton3.Checked Then
            Width = 1024
            Height = 768
        End If
    End Sub
End Class
