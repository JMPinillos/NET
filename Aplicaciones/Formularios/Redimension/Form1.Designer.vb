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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.FlatAppearance.BorderColor = Color.Black
        RadioButton1.FlatAppearance.CheckedBackColor = Color.Black
        RadioButton1.Location = New Point(30, 37)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 19)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "640 * 480"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.FlatAppearance.BorderColor = Color.Black
        RadioButton2.FlatAppearance.CheckedBackColor = Color.Black
        RadioButton2.Location = New Point(30, 74)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "800 * 600"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.FlatAppearance.BorderColor = Color.Black
        RadioButton3.FlatAppearance.CheckedBackColor = Color.Black
        RadioButton3.Location = New Point(30, 113)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(78, 19)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "1024 * 768"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(30, 158)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.No
        Button1.Size = New Size(78, 23)
        Button1.TabIndex = 6
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 322)
        Controls.Add(Button1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button1 As Button

End Class
