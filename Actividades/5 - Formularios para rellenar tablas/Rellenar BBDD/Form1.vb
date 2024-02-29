Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInsertAlumno.CheckedChanged
        If RbtInsertAlumno.Checked Then
            RbtInsertAlumno.Font = New Font(RbtInsertAlumno.Font, FontStyle.Bold)
        Else
            RbtInsertAlumno.Font = New Font(RbtInsertAlumno.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub RbtInsertProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInsertProfesor.CheckedChanged
        If RbtInsertProfesor.Checked Then
            RbtInsertProfesor.Font = New Font(RbtInsertProfesor.Font, FontStyle.Bold)
        Else
            RbtInsertProfesor.Font = New Font(RbtInsertProfesor.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub RbtNewQuery_CheckedChanged(sender As Object, e As EventArgs) Handles RbtNewQuery.CheckedChanged
        If RbtNewQuery.Checked Then
            RbtNewQuery.Font = New Font(RbtNewQuery.Font, FontStyle.Bold)
            RbtNewQuery.ForeColor = Color.Red
        Else
            RbtNewQuery.Font = New Font(RbtNewQuery.Font, FontStyle.Regular)
            RbtNewQuery.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RbtInsertAlumno.Checked Then
            Dim newAlumno As New Form2()
            newAlumno.Show()
            Me.Close()
        ElseIf RbtInsertProfesor.Checked Then
            Dim newProfesor As New Form3()
            newProfesor.Show()
            Me.Close()
        ElseIf RbtNewQuery.Checked Then
            Dim texto As String = "Algunas querys pueden dañar la base de datos." & vbCrLf & "¿Seguro que desea continuar?"
            Dim titulo As String = "ADVERTENCIA"
            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then
                Dim newQuery As New Form4()
                newQuery.Show()
                Me.Close()
            End If

        Else
            MsgBox("Debe seleccionar alguna opción", vbExclamation, "¡ATENCIÓN!")
        End If
    End Sub
End Class
