Public Class Form1
    Public Datum As Date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.MouseHover
        TextBox1.BackColor = Color.Green
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.MouseHover
        TextBox1.BackColor = Color.Blue
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.MouseHover
        TextBox1.BackColor = Color.Red
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.MouseHover
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ForeColor = Color.Yellow
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Datum = DateTimePicker1.Text
        TextBox1.Text = Datum
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        End
    End Sub
End Class
