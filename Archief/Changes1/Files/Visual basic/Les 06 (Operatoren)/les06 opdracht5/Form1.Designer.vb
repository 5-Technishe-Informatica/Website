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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Berekenen = New System.Windows.Forms.Button()
        Me.Optellen = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rest = New System.Windows.Forms.Label()
        Me.Gelijk = New System.Windows.Forms.Label()
        Me.OplossingOptellen = New System.Windows.Forms.Label()
        Me.OplossenDelenNiet = New System.Windows.Forms.Label()
        Me.OplossenDelen = New System.Windows.Forms.Label()
        Me.RestNaDelen = New System.Windows.Forms.Label()
        Me.WaardeGelijk = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(311, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Berekenen
        '
        Me.Berekenen.Location = New System.Drawing.Point(565, 80)
        Me.Berekenen.Name = "Berekenen"
        Me.Berekenen.Size = New System.Drawing.Size(75, 23)
        Me.Berekenen.TabIndex = 2
        Me.Berekenen.Text = "Bereken"
        Me.Berekenen.UseVisualStyleBackColor = True
        '
        'Optellen
        '
        Me.Optellen.AutoSize = True
        Me.Optellen.BackColor = System.Drawing.Color.Brown
        Me.Optellen.Location = New System.Drawing.Point(89, 154)
        Me.Optellen.Name = "Optellen"
        Me.Optellen.Size = New System.Drawing.Size(88, 13)
        Me.Optellen.TabIndex = 3
        Me.Optellen.Text = "getallen opgeteld"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "niet geheel gedeeld"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "geheel gedeeld"
        '
        'Rest
        '
        Me.Rest.AutoSize = True
        Me.Rest.Location = New System.Drawing.Point(89, 292)
        Me.Rest.Name = "Rest"
        Me.Rest.Size = New System.Drawing.Size(68, 13)
        Me.Rest.TabIndex = 6
        Me.Rest.Text = "rest na delen"
        '
        'Gelijk
        '
        Me.Gelijk.AutoSize = True
        Me.Gelijk.Location = New System.Drawing.Point(89, 337)
        Me.Gelijk.Name = "Gelijk"
        Me.Gelijk.Size = New System.Drawing.Size(110, 13)
        Me.Gelijk.TabIndex = 7
        Me.Gelijk.Text = "De waarden zijn gelijk"
        '
        'OplossingOptellen
        '
        Me.OplossingOptellen.AutoSize = True
        Me.OplossingOptellen.Location = New System.Drawing.Point(372, 154)
        Me.OplossingOptellen.Name = "OplossingOptellen"
        Me.OplossingOptellen.Size = New System.Drawing.Size(0, 13)
        Me.OplossingOptellen.TabIndex = 8
        '
        'OplossenDelenNiet
        '
        Me.OplossenDelenNiet.AutoSize = True
        Me.OplossenDelenNiet.Location = New System.Drawing.Point(372, 208)
        Me.OplossenDelenNiet.Name = "OplossenDelenNiet"
        Me.OplossenDelenNiet.Size = New System.Drawing.Size(0, 13)
        Me.OplossenDelenNiet.TabIndex = 9
        '
        'OplossenDelen
        '
        Me.OplossenDelen.AutoSize = True
        Me.OplossenDelen.Location = New System.Drawing.Point(372, 249)
        Me.OplossenDelen.Name = "OplossenDelen"
        Me.OplossenDelen.Size = New System.Drawing.Size(10, 13)
        Me.OplossenDelen.TabIndex = 10
        Me.OplossenDelen.Text = "."
        '
        'RestNaDelen
        '
        Me.RestNaDelen.AutoSize = True
        Me.RestNaDelen.Location = New System.Drawing.Point(372, 292)
        Me.RestNaDelen.Name = "RestNaDelen"
        Me.RestNaDelen.Size = New System.Drawing.Size(10, 13)
        Me.RestNaDelen.TabIndex = 11
        Me.RestNaDelen.Text = "."
        '
        'WaardeGelijk
        '
        Me.WaardeGelijk.AutoSize = True
        Me.WaardeGelijk.Location = New System.Drawing.Point(372, 337)
        Me.WaardeGelijk.Name = "WaardeGelijk"
        Me.WaardeGelijk.Size = New System.Drawing.Size(10, 13)
        Me.WaardeGelijk.TabIndex = 12
        Me.WaardeGelijk.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WaardeGelijk)
        Me.Controls.Add(Me.RestNaDelen)
        Me.Controls.Add(Me.OplossenDelen)
        Me.Controls.Add(Me.OplossenDelenNiet)
        Me.Controls.Add(Me.OplossingOptellen)
        Me.Controls.Add(Me.Gelijk)
        Me.Controls.Add(Me.Rest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Optellen)
        Me.Controls.Add(Me.Berekenen)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Berekenen As Button
    Friend WithEvents Optellen As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Rest As Label
    Friend WithEvents Gelijk As Label
    Friend WithEvents OplossingOptellen As Label
    Friend WithEvents OplossenDelenNiet As Label
    Friend WithEvents OplossenDelen As Label
    Friend WithEvents RestNaDelen As Label
    Friend WithEvents WaardeGelijk As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
