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
        BtnSumar = New Button()
        BtnRestar = New Button()
        BtnMultiplicar = New Button()
        BtnDividir = New Button()
        BtnElevar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnSumar
        ' 
        BtnSumar.BackColor = Color.RoyalBlue
        BtnSumar.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnSumar.ForeColor = Color.White
        BtnSumar.Location = New Point(22, 94)
        BtnSumar.Name = "BtnSumar"
        BtnSumar.Size = New Size(102, 29)
        BtnSumar.TabIndex = 0
        BtnSumar.Text = "Sumar"
        BtnSumar.UseVisualStyleBackColor = False
        ' 
        ' BtnRestar
        ' 
        BtnRestar.BackColor = Color.RoyalBlue
        BtnRestar.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnRestar.ForeColor = Color.White
        BtnRestar.Location = New Point(130, 94)
        BtnRestar.Name = "BtnRestar"
        BtnRestar.Size = New Size(102, 29)
        BtnRestar.TabIndex = 1
        BtnRestar.Text = "Restar"
        BtnRestar.UseVisualStyleBackColor = False
        ' 
        ' BtnMultiplicar
        ' 
        BtnMultiplicar.BackColor = Color.RoyalBlue
        BtnMultiplicar.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnMultiplicar.ForeColor = Color.White
        BtnMultiplicar.Location = New Point(181, 129)
        BtnMultiplicar.Name = "BtnMultiplicar"
        BtnMultiplicar.Size = New Size(102, 29)
        BtnMultiplicar.TabIndex = 2
        BtnMultiplicar.Text = "Multiplicar"
        BtnMultiplicar.UseVisualStyleBackColor = False
        ' 
        ' BtnDividir
        ' 
        BtnDividir.BackColor = Color.RoyalBlue
        BtnDividir.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnDividir.ForeColor = Color.White
        BtnDividir.Location = New Point(238, 94)
        BtnDividir.Name = "BtnDividir"
        BtnDividir.Size = New Size(102, 29)
        BtnDividir.TabIndex = 3
        BtnDividir.Text = "Dividir"
        BtnDividir.UseVisualStyleBackColor = False
        ' 
        ' BtnElevar
        ' 
        BtnElevar.BackColor = Color.RoyalBlue
        BtnElevar.Font = New Font("Calibri", 10F, FontStyle.Bold)
        BtnElevar.ForeColor = Color.White
        BtnElevar.Location = New Point(73, 129)
        BtnElevar.Name = "BtnElevar"
        BtnElevar.Size = New Size(102, 29)
        BtnElevar.TabIndex = 4
        BtnElevar.Text = "Elevar"
        BtnElevar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(121, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 5
        Label1.Text = "¿Que desea realizar?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 450)
        Controls.Add(Label1)
        Controls.Add(BtnElevar)
        Controls.Add(BtnDividir)
        Controls.Add(BtnMultiplicar)
        Controls.Add(BtnRestar)
        Controls.Add(BtnSumar)
        Name = "Form1"
        Text = "Calculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSumar As Button
    Friend WithEvents BtnRestar As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnDividir As Button
    Friend WithEvents BtnElevar As Button
    Friend WithEvents Label1 As Label

End Class
