<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        BtnCalcular = New Button()
        Label1 = New Label()
        TextBox3 = New TextBox()
        BtnSalir = New Button()
        BtnVolver = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(31, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(81, 23)
        TextBox1.TabIndex = 0
        TextBox1.Tag = ""
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(137, 30)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(81, 23)
        TextBox2.TabIndex = 1
        TextBox2.Tag = ""
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.BackColor = Color.RoyalBlue
        BtnCalcular.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnCalcular.ForeColor = Color.White
        BtnCalcular.Location = New Point(71, 72)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(102, 29)
        BtnCalcular.TabIndex = 2
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(13, 14)
        Label1.TabIndex = 3
        Label1.Text = "+"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(31, 120)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(187, 23)
        TextBox3.TabIndex = 4
        TextBox3.Tag = ""
        TextBox3.TextAlign = HorizontalAlignment.Right
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.Red
        BtnSalir.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnSalir.ForeColor = Color.White
        BtnSalir.Location = New Point(137, 166)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(81, 29)
        BtnSalir.TabIndex = 5
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' BtnVolver
        ' 
        BtnVolver.BackColor = Color.Green
        BtnVolver.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnVolver.ForeColor = Color.White
        BtnVolver.Location = New Point(31, 166)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(81, 29)
        BtnVolver.TabIndex = 6
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' Suma
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(246, 216)
        Controls.Add(BtnVolver)
        Controls.Add(BtnSalir)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(BtnCalcular)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Suma"
        Text = "Suma"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnVolver As Button
End Class
