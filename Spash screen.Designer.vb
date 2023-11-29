<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spash_screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(325, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 38)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME!!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(188, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(443, 38)
        Label2.TabIndex = 1
        Label2.Text = "LIBRARY MANAGMENT SYSTEM"
        ' 
        ' Timer1
        ' 
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(41, 385)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 2
        ' 
        ' Spash_screen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Spash_screen"
        Text = "Spash_screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
