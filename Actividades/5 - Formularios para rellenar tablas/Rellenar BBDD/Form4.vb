Imports MySqlConnector
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form4
    Private Sub SendQuery_Click(sender As Object, e As EventArgs) Handles SendQuery.Click

        Dim mysqlCon As String = "server=127.0.0.1;userid=root;password=;database=academia"
        Dim conexion As New MySqlConnection(mysqlCon)

        Try
            conexion.Open()

            ' CREAMOS LA CONSULTA PARA INSERTAR LOS DATOS EN LA BASE DE DATOS
            Dim query1 As String = TextBoxQuery.Text

            Dim comando As New MySqlCommand(query1, conexion)
            Dim adaptador As New MySqlDataAdapter(query1, conexion)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt

            ' EJECUTAMOS LA CONSULTA
            comando.CommandText = query1
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim Form1 As New Form1
        Form1.Show()
        Me.Hide()
    End Sub
End Class
