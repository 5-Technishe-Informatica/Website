Public Class Form1
    Dim int_random_getal As Integer
    Dim strAntwoord As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        strAntwoord = InputBox("getal van 1 t.e.m. 20")

        If (strAntwoord = int_random_getal) Then
            MsgBox("Juist geraden")
        End If
        If Not (strAntwoord = int_random_getal) Then
            MsgBox("Fout geraden!")
        End If
        If (strAntwoord < int_random_getal) Then
            ListBox1.Items.Add(strAntwoord & " is kleiner")
        End If
        If (strAntwoord > int_random_getal) Then
            ListBox1.Items.Add(strAntwoord & " is groter")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        int_random_getal = Rnd() * 20
    End Sub
End Class
