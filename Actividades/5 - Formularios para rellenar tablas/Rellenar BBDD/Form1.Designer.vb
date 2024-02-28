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
        RbtInsertAlumno = New RadioButton()
        RbtInsertProfesor = New RadioButton()
        RbtNewQuery = New RadioButton()
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
        ' RbtInsertAlumno
        ' 
        RbtInsertAlumno.AutoSize = True
        RbtInsertAlumno.Cursor = Cursors.Hand
        RbtInsertAlumno.Location = New Point(28, 50)
        RbtInsertAlumno.Name = "RbtInsertAlumno"
        RbtInsertAlumno.Size = New Size(104, 19)
        RbtInsertAlumno.TabIndex = 5
        RbtInsertAlumno.Text = "Nuevo alumno"
        RbtInsertAlumno.UseVisualStyleBackColor = True
        ' 
        ' RbtInsertProfesor
        ' 
        RbtInsertProfesor.AutoSize = True
        RbtInsertProfesor.Cursor = Cursors.Hand
        RbtInsertProfesor.Location = New Point(28, 75)
        RbtInsertProfesor.Name = "RbtInsertProfesor"
        RbtInsertProfesor.Size = New Size(107, 19)
        RbtInsertProfesor.TabIndex = 6
        RbtInsertProfesor.Text = "Nuevo profesor"
        RbtInsertProfesor.UseVisualStyleBackColor = True
        ' 
        ' RbtNewQuery
        ' 
        RbtNewQuery.AutoSize = True
        RbtNewQuery.Cursor = Cursors.Hand
        RbtNewQuery.Location = New Point(28, 100)
        RbtNewQuery.Name = "RbtNewQuery"
        RbtNewQuery.Size = New Size(162, 19)
        RbtNewQuery.TabIndex = 7
        RbtNewQuery.Text = "Realizar consulta en BBDD"
        RbtNewQuery.UseVisualStyleBackColor = True
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
        Controls.Add(RbtNewQuery)
        Controls.Add(RbtInsertProfesor)
        Controls.Add(RbtInsertAlumno)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Formulario BBDD"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RbtInsertAlumno As RadioButton
    Friend WithEvents RbtInsertProfesor As RadioButton
    Friend WithEvents RbtNewQuery As RadioButton
    Friend WithEvents BtnAceptar As Button

End Class
