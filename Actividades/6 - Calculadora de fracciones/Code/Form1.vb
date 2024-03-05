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
        Else
            RbtArray.Font = New Font(RbtArray.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RbtSumDif.Checked Then
            Dim form2 As New Form2()
            form2.Show()
            Me.Close()
        ElseIf RbtDivProd.Checked Then
            Dim form3 As New Form3()
            form3.Show()
            Me.Close()
        ElseIf RbtArray.Checked Then

            ' Declaramos las variables a utilizar
            Dim input As String
            Dim numeroFracciones As Integer
            Dim esNumeroValido As Boolean = False

            Do
                ' Preguntamos al usuario cuantas fracciones desea ingresar
                input = InputBox("¿Cuantas fracciones desea ingresar?", "Número de fracciones", "1")

                ' Si el usuario cancela la operación o no introduce ningun valor, salimos del bucle
                If String.IsNullOrEmpty(input) Then
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub ' Sale del Sub si se cancela la operación
                End If

                ' Verificamos que la entrada sea un número entero mayor que 0
                If Integer.TryParse(input, numeroFracciones) AndAlso numeroFracciones > 0 Then
                    esNumeroValido = True ' Si la entrada es válida, sale del bucle
                    Dim formFracciones As New ArrayFracciones(numeroFracciones)
                Else
                    MessageBox.Show("Por favor, ingrese un número entero mayor que 0.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Loop Until esNumeroValido

        End If
    End Sub

    Private Sub ArrayFracciones(numeroFracciones)

    End Sub
End Class