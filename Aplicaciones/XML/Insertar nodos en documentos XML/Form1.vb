Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Xml
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Establece el título del formulario
        Me.Text = "Load XML"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim codigo As String = TextBox1.Text
        Dim nombre As String = TextBox2.Text
        Dim apellido As String = TextBox3.Text

        ' Verifica si los campos están vacíos
        If (codigo = "" Or nombre = "" Or apellido = "") Then
            MsgBox("Por favor, ingrese todos los datos")
        Else

            ListBox1.Items.Clear()

            ' Crea un nuevo documento XML
            Dim xd As XmlDocument = New XmlDocument()
            xd.Load("authors.xml")

            ' Crea un nuevo autor
            Dim newAuthor As XmlElement = xd.CreateElement("author")
            ' Establece el atributo del autor
            newAuthor.SetAttribute("code", codigo)

            ' Crea el nombre del autor
            Dim fn As XmlElement = xd.CreateElement("fname")
            ' Establece el nombre del autor
            fn.InnerText = nombre
            ' Agrega el nombre del autor al autor
            newAuthor.AppendChild(fn)

            ' Crea el apellido del autor
            Dim ln As XmlElement = xd.CreateElement("Iname")
            ln.InnerText = apellido
            newAuthor.AppendChild(ln)

            ' Crea un nuevo autor 
            xd.DocumentElement.AppendChild(newAuthor)

            ' Crea un nuevo archivo XML
            Dim tr As XmlTextWriter = New XmlTextWriter("authors.xml", Nothing)
            ' Establece el formato del documento
            tr.Formatting = Formatting.Indented
            ' Escribe el contenido en el archivo
            xd.WriteContentTo(tr)
            ' Cierra el archivo
            tr.Close()

            ' Carga el archivo XML
            Dim nl As XmlNodeList = xd.GetElementsByTagName("fname")
            For Each node As XmlNode In nl
                ListBox1.Items.Add(node.InnerText)
            Next node

        End If
    End Sub
End Class