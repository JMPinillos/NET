Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mysqlCon As String = "server=127.0.0.1;userid=root;password=;database=prueba"
        Dim conexion As New MySqlConnection(mysqlCon)

        Try
            conexion.Open()

            Dim codigo As Integer
            Dim descripcion As String = TextBox1.Text
            Dim precio As String = TextBox2.Text

            ' Query para obtener el total de registros
            Dim query1 As String = "SELECT COUNT(*) FROM articulos"

            ' Crear el comando para ejecutar el query de conteo
            Dim comando As New MySqlCommand(query1, conexion)

            ' Usar ExecuteScalar para obtener el total de registros y sumarle 1
            codigo = Convert.ToInt32(comando.ExecuteScalar()) + 1

            ' Query para insertar el nuevo artículo
            Dim query2 As String = "ALTER TABLE articulos AUTO_INCREMENT = " & codigo
            comando.CommandText = query2
            comando.ExecuteNonQuery()

            ' Query para insertar el nuevo artículo
            Dim query3 As String = "insert into articulos(descripcion, precio) values('" & descripcion & "', '" & precio & "')"
            comando.CommandText = query3
            comando.ExecuteNonQuery()

            TextBox1.Text = ""
            TextBox2.Text = ""

            MessageBox.Show("Datos guardados correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
