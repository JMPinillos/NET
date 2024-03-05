<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnDiv = New Button()
        BtnVolver = New Button()
        Label2 = New Label()
        Label1 = New Label()
        TxbDen2 = New TextBox()
        Label3 = New Label()
        TxbNum2 = New TextBox()
        TxbNum1 = New TextBox()
        Label4 = New Label()
        TxbDen1 = New TextBox()
        TxbNumResult = New TextBox()
        Label5 = New Label()
        TxbDenResult = New TextBox()
        Label6 = New Label()
        LblSimbol = New Label()
        BtnMulti = New Button()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' BtnDiv
        ' 
        BtnDiv.Cursor = Cursors.Hand
        BtnDiv.Location = New Point(178, 117)
        BtnDiv.Name = "BtnDiv"
        BtnDiv.Size = New Size(75, 23)
        BtnDiv.TabIndex = 6
        BtnDiv.Text = "Dividir"
        BtnDiv.UseVisualStyleBackColor = True
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Cursor = Cursors.Hand
        BtnVolver.Location = New Point(12, 117)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(75, 23)
        BtnVolver.TabIndex = 9
        BtnVolver.TabStop = False
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fracción 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 1
        Label1.Text = "Fracción 1"
        ' 
        ' TxbDen2
        ' 
        TxbDen2.Location = New Point(102, 73)
        TxbDen2.MaxLength = 9
        TxbDen2.Name = "TxbDen2"
        TxbDen2.Size = New Size(61, 23)
        TxbDen2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(102, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 12
        Label3.Text = "___________"
        ' 
        ' TxbNum2
        ' 
        TxbNum2.Location = New Point(102, 44)
        TxbNum2.MaxLength = 9
        TxbNum2.Name = "TxbNum2"
        TxbNum2.Size = New Size(61, 23)
        TxbNum2.TabIndex = 3
        ' 
        ' TxbNum1
        ' 
        TxbNum1.Location = New Point(12, 44)
        TxbNum1.MaxLength = 9
        TxbNum1.Name = "TxbNum1"
        TxbNum1.Size = New Size(61, 23)
        TxbNum1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 16
        Label4.Text = "___________"
        ' 
        ' TxbDen1
        ' 
        TxbDen1.Location = New Point(12, 73)
        TxbDen1.MaxLength = 9
        TxbDen1.Name = "TxbDen1"
        TxbDen1.Size = New Size(61, 23)
        TxbDen1.TabIndex = 2
        ' 
        ' TxbNumResult
        ' 
        TxbNumResult.Location = New Point(192, 44)
        TxbNumResult.Name = "TxbNumResult"
        TxbNumResult.ReadOnly = True
        TxbNumResult.Size = New Size(61, 23)
        TxbNumResult.TabIndex = 21
        TxbNumResult.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(192, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 20
        Label5.Text = "___________"
        ' 
        ' TxbDenResult
        ' 
        TxbDenResult.Location = New Point(192, 73)
        TxbDenResult.Name = "TxbDenResult"
        TxbDenResult.ReadOnly = True
        TxbDenResult.Size = New Size(61, 23)
        TxbDenResult.TabIndex = 19
        TxbDenResult.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(192, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 18
        Label6.Text = "Resultado"
        ' 
        ' LblSimbol
        ' 
        LblSimbol.AutoSize = True
        LblSimbol.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSimbol.Location = New Point(80, 62)
        LblSimbol.Name = "LblSimbol"
        LblSimbol.Size = New Size(14, 15)
        LblSimbol.TabIndex = 22
        LblSimbol.Text = "S"
        LblSimbol.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnMulti
        ' 
        BtnMulti.Cursor = Cursors.Hand
        BtnMulti.Location = New Point(95, 117)
        BtnMulti.Name = "BtnMulti"
        BtnMulti.Size = New Size(75, 23)
        BtnMulti.TabIndex = 5
        BtnMulti.Text = "Multiplicar"
        BtnMulti.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(170, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(14, 15)
        Label8.TabIndex = 24
        Label8.Text = "="
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(267, 163)
        Controls.Add(Label8)
        Controls.Add(BtnMulti)
        Controls.Add(LblSimbol)
        Controls.Add(TxbNumResult)
        Controls.Add(Label5)
        Controls.Add(TxbDenResult)
        Controls.Add(Label6)
        Controls.Add(TxbNum1)
        Controls.Add(Label4)
        Controls.Add(TxbDen1)
        Controls.Add(TxbNum2)
        Controls.Add(Label3)
        Controls.Add(TxbDen2)
        Controls.Add(BtnVolver)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnDiv)
        Name = "Form3"
        Text = "Producto y división"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnDiv As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbDen2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNum2 As TextBox
    Friend WithEvents TxbNum1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbDen1 As TextBox
    Friend WithEvents TxbNumResult As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbDenResult As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblSimbol As Label
    Friend WithEvents BtnMulti As Button
    Friend WithEvents Label8 As Label
End Class
