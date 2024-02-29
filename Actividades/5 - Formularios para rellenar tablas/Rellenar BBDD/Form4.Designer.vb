<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        DataGridView1 = New DataGridView()
        TextBoxQuery = New TextBox()
        Label1 = New Label()
        SendQuery = New Button()
        BtnVolver = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 98)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 316)
        DataGridView1.TabIndex = 2
        ' 
        ' TextBoxQuery
        ' 
        TextBoxQuery.Location = New Point(12, 27)
        TextBoxQuery.Name = "TextBoxQuery"
        TextBoxQuery.Size = New Size(776, 23)
        TextBoxQuery.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 4
        Label1.Text = "Inserte aquí su consulta"
        ' 
        ' SendQuery
        ' 
        SendQuery.Cursor = Cursors.Hand
        SendQuery.ForeColor = Color.Black
        SendQuery.Location = New Point(713, 56)
        SendQuery.Name = "SendQuery"
        SendQuery.Size = New Size(75, 23)
        SendQuery.TabIndex = 5
        SendQuery.Text = "Enviar"
        SendQuery.UseVisualStyleBackColor = True
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Cursor = Cursors.Hand
        BtnVolver.ForeColor = Color.Black
        BtnVolver.Location = New Point(713, 425)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(75, 23)
        BtnVolver.TabIndex = 6
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 460)
        Controls.Add(BtnVolver)
        Controls.Add(SendQuery)
        Controls.Add(Label1)
        Controls.Add(TextBoxQuery)
        Controls.Add(DataGridView1)
        Name = "Form4"
        Text = "Query console"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxQuery As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SendQuery As Button
    Friend WithEvents BtnVolver As Button

End Class
