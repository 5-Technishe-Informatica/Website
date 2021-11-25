<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.voornaam = New System.Windows.Forms.TextBox()
        Me.naam = New System.Windows.Forms.TextBox()
        Me.leeftijd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.takstvak = New System.Windows.Forms.TextBox()
        Me.Knop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'voornaam
        '
        Me.voornaam.Location = New System.Drawing.Point(221, 87)
        Me.voornaam.Name = "voornaam"
        Me.voornaam.Size = New System.Drawing.Size(100, 22)
        Me.voornaam.TabIndex = 0
        '
        'naam
        '
        Me.naam.Location = New System.Drawing.Point(221, 115)
        Me.naam.Name = "naam"
        Me.naam.Size = New System.Drawing.Size(100, 22)
        Me.naam.TabIndex = 1
        '
        'leeftijd
        '
        Me.leeftijd.Location = New System.Drawing.Point(221, 143)
        Me.leeftijd.Name = "leeftijd"
        Me.leeftijd.Size = New System.Drawing.Size(100, 22)
        Me.leeftijd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Voornaam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Naam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Leeftijd"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(163, 199)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(71, 17)
        Me.label.TabIndex = 6
        Me.label.Text = "Dit ben ik:"
        '
        'takstvak
        '
        Me.takstvak.AcceptsReturn = True
        Me.takstvak.AcceptsTab = True
        Me.takstvak.Location = New System.Drawing.Point(166, 232)
        Me.takstvak.Multiline = True
        Me.takstvak.Name = "takstvak"
        Me.takstvak.ReadOnly = True
        Me.takstvak.Size = New System.Drawing.Size(270, 136)
        Me.takstvak.TabIndex = 7
        '
        'Knop
        '
        Me.Knop.Location = New System.Drawing.Point(221, 395)
        Me.Knop.Name = "Knop"
        Me.Knop.Size = New System.Drawing.Size(75, 23)
        Me.Knop.TabIndex = 8
        Me.Knop.Text = "Stel me voor!"
        Me.Knop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Knop)
        Me.Controls.Add(Me.takstvak)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.leeftijd)
        Me.Controls.Add(Me.naam)
        Me.Controls.Add(Me.voornaam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents voornaam As TextBox
    Friend WithEvents naam As TextBox
    Friend WithEvents leeftijd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents takstvak As TextBox
    Friend WithEvents Knop As Button
End Class
