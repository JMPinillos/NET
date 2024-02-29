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
        BtnSend = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DtpBirthday = New DateTimePicker()
        TxtName = New TextBox()
        TxtLastName = New TextBox()
        Label4 = New Label()
        CbxGender = New ComboBox()
        Button1 = New Button()
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
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(156, 153)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Volver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 190)
        Controls.Add(Button1)
        Controls.Add(CbxGender)
        Controls.Add(Label4)
        Controls.Add(TxtLastName)
        Controls.Add(TxtName)
        Controls.Add(DtpBirthday)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnSend)
        Name = "Form3"
        Text = "Nuevo profesor"
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
    Friend WithEvents Button1 As Button
End Class
