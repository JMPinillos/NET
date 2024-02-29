Imports MySqlConnector
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        If TxtName.Text = "" Or TxtLastName.Text = "" Or DtpBirthday.Value.ToString = "" Or CbxGender.Text = "" Then
            MsgBox("Debe rellenar todos los campos", vbExclamation, Title:="¡Atención!")
        Else
            Dim nombre As String = TxtName.Text
            Dim apellido As String = TxtLastName.Text
            Dim birthDate As Date = DtpBirthday.Value.ToString("yyyy-MM-dd")
            Dim genero As Integer

            If CbxGender.Text.Equals("Masculino") Or CbxGender.Text.Equals("Femenino") Then
                If CbxGender.Text = "Masculino" Then
                    genero = 1
                Else
                    genero = 2
                End If

                Dim mysqlCon As String = "server=127.0.0.1;userid=root;password=;database=academia"
                Dim conexion As New MySqlConnection(mysqlCon)

                Try
                    conexion.Open()

                    ' CREAMOS LA CONSULTA PARA INSERTAR LOS DATOS EN LA BASE DE DATOS
                    Dim query1 As String = "INSERT INTO alumnos (nombre, apellidos, fecha_nacimiento, id_genero) VALUES (@nombre, @apellidos, @fecha_nacimiento, @id_genero)"
                    Dim comando As New MySqlCommand(query1, conexion)

                    ' AÑADIMOS LOS PARÁMETROS Y ASI EVITAMOS SQL INJECTION
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@apellidos", apellido)
                    comando.Parameters.AddWithValue("@fecha_nacimiento", birthDate)
                    comando.Parameters.AddWithValue("@id_genero", genero)

                    ' EJECUTAMOS LA CONSULTA
                    comando.CommandText = query1
                    comando.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Close()
                End Try

                ' MOSTRAMOS UN MENSAJE DE QUE SE HA CREADO EL ALUMNO
                Dim mensaje As String = "Nombre: " & nombre & vbCrLf & "Apellido: " & apellido & vbCrLf & "Fecha de nacimiento: " & birthDate & vbCrLf & "Género: " & CbxGender.Text
                MsgBox(mensaje, vbInformation, Title:="Nuevo alumno creado")
                Dim form1 As New Form1
                form1.Show()
                Close()
            Else
                MsgBox("El género solo puede ser Masculino o Femenino", vbExclamation, Title:="¡Atención!")
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim form1 As New Form1
        form1.Show()
        Close()
    End Sub
End Class