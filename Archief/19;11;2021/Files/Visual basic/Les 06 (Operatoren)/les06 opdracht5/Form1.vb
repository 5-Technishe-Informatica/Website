Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Berekenen.Click
        Dim optellen As Integer = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label1.Text = optellen
        Dim NietGeheelDelen As Integer = Val(TextBox1.Text) / Val(TextBox2.Text)
        Label4.Text = NietGeheelDelen
        Dim GeheelDelen As Integer = Val(TextBox1.Text) \ Val(TextBox2.Text)
        OplossenDelen.Text = GeheelDelen
        Dim RestDelen As Integer = Val(TextBox1.Text) Mod Val(TextBox2.Text)
        RestNaDelen.Text = RestDelen
        Dim gelijk As Boolean = Val(TextBox1.Text) = Val(TextBox2.Text)
        WaardeGelijk.Text = gelijk

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Rest.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub OplossingOptellen_Click(sender As Object, e As EventArgs) Handles OplossingOptellen.Click

    End Sub

    Private Sub OplossenDelenNiet_Click(sender As Object, e As EventArgs) Handles OplossenDelenNiet.Click

    End Sub

    Private Sub OplossenDelen_Click(sender As Object, e As EventArgs) Handles OplossenDelen.Click

    End Sub

    Private Sub RestNaDelen_Click(sender As Object, e As EventArgs) Handles RestNaDelen.Click

    End Sub

    Private Sub WaardeGelijk_Click(sender As Object, e As EventArgs) Handles WaardeGelijk.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
