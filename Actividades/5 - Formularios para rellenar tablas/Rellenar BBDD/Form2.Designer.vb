<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        BtnSend = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DtpBirthday = New DateTimePicker()
        TxtName = New TextBox()
        TxtLastName = New TextBox()
        Label4 = New Label()
        CbxGender = New ComboBox()
        BtnVolver = New Button()
        SuspendLayout()
        ' 
        ' BtnSend
        ' 
        BtnSend.Cursor = Cursors.Hand
        BtnSend.Location = New Point(237, 153)
        BtnSend.Name = "BtnSend"
        BtnSend.Size = New Size(75, 23)
        BtnSend.TabIndex = 0
        BtnSend.Text = "Crear"
        BtnSend.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 2
        Label2.Text = "Apellidos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 15)
        Label3.TabIndex = 3
        Label3.Text = "Fecha de nacimiento"
        ' 
        ' DtpBirthday
        ' 
        DtpBirthday.CustomFormat = "dd-MM-yyyy"
        DtpBirthday.Format = DateTimePickerFormat.Custom
        DtpBirthday.Location = New Point(158, 81)
        DtpBirthday.Name = "DtpBirthday"
        DtpBirthday.Size = New Size(154, 23)
        DtpBirthday.TabIndex = 4
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(158, 23)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(154, 23)
        TxtName.TabIndex = 5
        ' 
        ' TxtLastName
        ' 
        TxtLastName.Location = New Point(158, 52)
        TxtLastName.Name = "TxtLastName"
        TxtLastName.Size = New Size(154, 23)
        TxtLastName.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(102, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 7
        Label4.Text = "Género"
        ' 
        ' CbxGender
        ' 
        CbxGender.FormattingEnabled = True
        CbxGender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        CbxGender.Location = New Point(158, 110)
        CbxGender.Name = "CbxGender"
        CbxGender.Size = New Size(154, 23)
        CbxGender.TabIndex = 8
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Cursor = Cursors.Hand
        BtnVolver.Location = New Point(156, 153)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(75, 23)
        BtnVolver.TabIndex = 9
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 190)
        Controls.Add(BtnVolver)
        Controls.Add(CbxGender)
        Controls.Add(Label4)
        Controls.Add(TxtLastName)
        Controls.Add(TxtName)
        Controls.Add(DtpBirthday)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnSend)
        Name = "Form2"
        Text = "Nuevo alumno"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpBirthday As DateTimePicker
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbxGender As ComboBox
    Friend WithEvents BtnVolver As Button
End Class
