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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 23)
        Button1.TabIndex = 0
        Button1.Text = "Importar títulos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(235, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 23)
        Button2.TabIndex = 1
        Button2.Text = "Importar tipo"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(459, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 23)
        Button3.TabIndex = 2
        Button3.Text = "Importar descripción"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 21)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(181, 94)
        ListBox1.TabIndex = 6
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(235, 21)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(181, 94)
        ListBox2.TabIndex = 7
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(459, 21)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(181, 94)
        ListBox3.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 167)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox

End Class
