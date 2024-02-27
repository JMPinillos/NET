Imports System.Xml
Public Class Form1
    Public Property WebBrowser1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.
        Me.Text = "Load XML"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xws = New XmlWriterSettings
        xws.Indent = True
        xws.NewLineOnAttributes = True
        Dim xw = XmlWriter.Create("authors.xml", xws)

        xw.WriteStartDocument()
        xw.WriteStartElement("Authors")
        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "1")
        xw.WriteElementString("fname", "Carlos")
        xw.WriteElementString("lname", "López")
        xw.WriteEndElement()
        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "2")
        xw.WriteElementString("fname", "Juan")
        xw.WriteElementString("lname", "Pérez")
        xw.WriteEndElement()
        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "3")
        xw.WriteElementString("fname", "Isabel")
        xw.WriteElementString("lname", "Gómez")
        xw.WriteEndElement()
        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "4")
        xw.WriteElementString("fname", "Ana")
        xw.WriteElementString("lname", "Álvarez")
        xw.WriteEndElement()
        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "5")
        xw.WriteElementString("fname", "Sergio")
        xw.WriteElementString("lname", "Valdecasas")
        xw.WriteEndElement()
        xw.WriteEndElement()
        xw.WriteEndDocument()
        xw.Flush()
        xw.Close()

        MsgBox("Archivo authors.xml creado")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dataSet As New DataSet
        dataSet.ReadXml("authors.xml")
        DataGridView1.DataSource = dataSet.Tables(0)

        Dim dataTable As New DataTable
        dataTable = dataSet.Tables(0)

        ' validar si la tabla tiene datos
        If Not IsNothing(dataTable) Then

            ' validar si la tabla tiene filas
            If dataTable.Rows.Count > 0 Then

                ' asignar la tabla al datagridview
                DataGridView1.DataSource = dataTable

            End If
        End If
    End Sub
End Class
