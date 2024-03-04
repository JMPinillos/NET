

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RbtSumDif.CheckedChanged
        If RbtSumDif.Checked Then
            RbtSumDif.Font = New Font(RbtSumDif.Font, FontStyle.Bold)
        Else
            RbtSumDif.Font = New Font(RbtSumDif.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub RbtInsertProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles RbtDivProd.CheckedChanged
        If RbtDivProd.Checked Then
            RbtDivProd.Font = New Font(RbtDivProd.Font, FontStyle.Bold)
        Else
            RbtDivProd.Font = New Font(RbtDivProd.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub RbtNewQuery_CheckedChanged(sender As Object, e As EventArgs) Handles RbtArray.CheckedChanged
        If RbtArray.Checked Then
            RbtArray.Font = New Font(RbtArray.Font, FontStyle.Bold)
            RbtArray.ForeColor = Color.Red
        Else
            RbtArray.Font = New Font(RbtArray.Font, FontStyle.Regular)
            RbtArray.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RbtSumDif.Checked Then
            Dim form2 As New Form2()
            form2.Show()
            Me.Close()
        ElseIf RbtDivProd.Checked Then
            ' Dim form3 As New Form3()
            'form3.Show()
            'Me.Close()
        ElseIf RbtArray.Checked Then
            'Dim form4 As New Form4()
            'form4.Show()
            'Me.Close()
        Else
            MsgBox("Debe seleccionar alguna opción", vbExclamation, "¡ATENCIÓN!")
        End If
    End Sub
End Class
