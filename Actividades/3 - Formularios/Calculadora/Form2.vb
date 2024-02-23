Public Class Resta
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs)
        Dim num1 = Convert.ToDouble(TextBox1.Text)
        Dim num2 = Convert.ToDouble(TextBox2.Text)
        Dim resultado = num1 + num2
        TextBox3.Text = resultado.ToString
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)
        Dim form1 As New Selector
        form1.Show()
        Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Dim texto = "¿Seguro que desea salir?"
        Dim estilo = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo
        Dim titulo = "Salir"
        Dim respuesta = MsgBox(texto, estilo, titulo)

        If respuesta = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Suma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' Suma
        ' 
        ClientSize = New Size(284, 261)
        Name = "Suma"
        Text = "Suma"
        ResumeLayout(False)

    End Sub
End Class