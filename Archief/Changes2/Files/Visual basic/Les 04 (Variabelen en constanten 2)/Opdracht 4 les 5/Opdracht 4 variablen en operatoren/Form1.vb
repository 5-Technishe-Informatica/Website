Public Class Form1
    Public Name As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim favorite As String
        favorite = TextBox2.Text
        Label4.Text = vbCrLf & "Mijn favorite serie is " & favorite
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Name = TextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim broerszussen As String
        broerszussen = TextBox3.Text
        Label4.Text += vbCrLf & "Ik heb " & broerszussen
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const Geboortejaar As Integer = 2004
        Label4.Text += vbCrLf & "Ik ben " & Name & " en ik ben geboren in " & Geboortejaar
    End Sub
End Class
