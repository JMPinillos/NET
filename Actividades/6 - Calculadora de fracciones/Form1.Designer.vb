<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        RbtSumDif = New RadioButton()
        RbtDivProd = New RadioButton()
        RbtArray = New RadioButton()
        BtnAceptar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(28, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 19)
        Label1.TabIndex = 4
        Label1.Text = "Elija una de las siguientes opciones"
        ' 
        ' RbtSumDif
        ' 
        RbtSumDif.AutoSize = True
        RbtSumDif.Cursor = Cursors.Hand
        RbtSumDif.Location = New Point(28, 50)
        RbtSumDif.Name = "RbtSumDif"
        RbtSumDif.Size = New Size(119, 19)
        RbtSumDif.TabIndex = 5
        RbtSumDif.Text = "Suma y diferencia"
        RbtSumDif.UseVisualStyleBackColor = True
        ' 
        ' RbtDivProd
        ' 
        RbtDivProd.AutoSize = True
        RbtDivProd.Cursor = Cursors.Hand
        RbtDivProd.Location = New Point(28, 75)
        RbtDivProd.Name = "RbtDivProd"
        RbtDivProd.Size = New Size(128, 19)
        RbtDivProd.TabIndex = 6
        RbtDivProd.Text = "División y producto"
        RbtDivProd.UseVisualStyleBackColor = True
        ' 
        ' RbtArray
        ' 
        RbtArray.AutoSize = True
        RbtArray.Cursor = Cursors.Hand
        RbtArray.Location = New Point(28, 100)
        RbtArray.Name = "RbtArray"
        RbtArray.Size = New Size(155, 19)
        RbtArray.TabIndex = 7
        RbtArray.Text = "Crear array de fracciones"
        RbtArray.UseVisualStyleBackColor = True
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.Cursor = Cursors.Hand
        BtnAceptar.Location = New Point(194, 138)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(75, 23)
        BtnAceptar.TabIndex = 8
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 175)
        Controls.Add(BtnAceptar)
        Controls.Add(RbtArray)
        Controls.Add(RbtDivProd)
        Controls.Add(RbtSumDif)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Calculadora de fracciones"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RbtSumDif As RadioButton
    Friend WithEvents RbtDivProd As RadioButton
    Friend WithEvents RbtArray As RadioButton
    Friend WithEvents BtnAceptar As Button

End Class
