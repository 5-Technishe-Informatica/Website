Public Class Form1
    Private Sub Knop_Click(sender As Object, e As EventArgs) Handles Knop.Click
        Dim tekst1 As String
        Dim tekst2 As String
        Dim tekst3 As String
        tekst1 = voornaam.Text
        tekst2 = naam.Text
        tekst3 = leeftijd.Text
        takstvak.Text = "ik ben " & tekst1 & " " & tekst2 & vbCrLf & "ik ben " & tekst3 & " jong"
    End Sub
End Class