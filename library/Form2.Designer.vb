<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ISBN_list = New ListBox()
        Title_list = New ListBox()
        Author_list = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ISBN_list
        ' 
        ISBN_list.Font = New Font("Segoe UI", 12F)
        ISBN_list.FormattingEnabled = True
        ISBN_list.ItemHeight = 28
        ISBN_list.Location = New Point(45, 111)
        ISBN_list.Name = "ISBN_list"
        ISBN_list.Size = New Size(174, 284)
        ISBN_list.TabIndex = 0
        ' 
        ' Title_list
        ' 
        Title_list.Font = New Font("Segoe UI", 12F)
        Title_list.FormattingEnabled = True
        Title_list.ItemHeight = 28
        Title_list.Location = New Point(312, 111)
        Title_list.Name = "Title_list"
        Title_list.Size = New Size(174, 284)
        Title_list.TabIndex = 1
        ' 
        ' Author_list
        ' 
        Author_list.Font = New Font("Segoe UI", 12F)
        Author_list.FormattingEnabled = True
        Author_list.ItemHeight = 28
        Author_list.Location = New Point(576, 111)
        Author_list.Name = "Author_list"
        Author_list.Size = New Size(174, 284)
        Author_list.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(45, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 32)
        Label1.TabIndex = 3
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(312, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 32)
        Label2.TabIndex = 4
        Label2.Text = "Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(576, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 28)
        Label3.TabIndex = 5
        Label3.Text = "Author"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Font = New Font("Georgia Pro Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(177, 434)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 61)
        Button1.TabIndex = 6
        Button1.Text = "Voir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Georgia Pro Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(440, 434)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 61)
        Button2.TabIndex = 7
        Button2.Text = "Masquer"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(890, 533)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Author_list)
        Controls.Add(Title_list)
        Controls.Add(ISBN_list)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ISBN_list As ListBox
    Friend WithEvents Title_list As ListBox
    Friend WithEvents Author_list As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
