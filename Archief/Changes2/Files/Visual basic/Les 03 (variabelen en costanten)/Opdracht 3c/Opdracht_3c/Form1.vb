Public Class Form1
    Dim Naam As String
    Dim Leeftijd As String
    Dim Geboortedatum As Date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Naam = TextBox1.Text
        TextBox1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Leeftijd = TextBox2.Text
        TextBox2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Geboortedatum = DateTimePicker1.Text
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = "Ik ben " & Naam & " en ik ben " & Leeftijd & " jaar" & vbCrLf _
        & "oud. Ik ben jarig op: " & Geboortedatum
    End Sub
End Class