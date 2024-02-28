Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        If TxtName.Text = "" Or TxtLastName.Text = "" Or DtpBirthday.Value.ToString = "" Or CbxGender.Text = "" Then
            MsgBox("Debe rellenar todos los campos")
        Else
            Dim nombre = TxtName.Text
            Dim apellido = TxtLastName.Text
            Dim birthDate = DtpBirthday.Value.ToString("yyyy-MM-dd")
            Dim genero As Integer

            If CbxGender.Text.Equals("Masculino") Or CbxGender.Text.Equals("Femenino") Then
                If CbxGender.Text = "Masculino" Then
                    genero = 1
                Else
                    genero = 2
                End If
                ' AQUI METEMOS LA QUERY Y LA CONEXION A LA BASE DE DATOS
                MsgBox("NUEVO ALUMNO CREADO" & vbCrLf & vbCrLf & "Nombre: " & nombre & vbCrLf & "Apellido: " & apellido & vbCrLf & "Fecha de nacimiento: " & birthDate & vbCrLf & "Género: " & CbxGender.Text)
                Dim form1 As New Form1
                form1.Show()
                Close()
            Else
                MsgBox("El género solo puede ser Masculino o Femenino")
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1
        form1.Show()
        Close()
    End Sub
End Class