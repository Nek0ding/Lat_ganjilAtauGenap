<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        input_angka = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        hasil = New Label()
        SuspendLayout()
        ' 
        ' input_angka
        ' 
        input_angka.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        input_angka.Location = New Point(297, 141)
        input_angka.Name = "input_angka"
        input_angka.Size = New Size(194, 45)
        input_angka.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(335, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "Hasil"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(707, 38)
        Label1.TabIndex = 2
        Label1.Text = "PROGRAM MENENTUKAN ANGKA GENAP ATAU GANJIL"
        ' 
        ' hasil
        ' 
        hasil.AutoSize = True
        hasil.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hasil.Location = New Point(45, 336)
        hasil.Name = "hasil"
        hasil.Size = New Size(0, 38)
        hasil.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(hasil)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(input_angka)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents input_angka As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents hasil As Label

End Class
