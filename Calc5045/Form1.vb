Public Class Form1
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Res.Text = Val(A.Text) + Val(B.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Res.Text = Val(A.Text) - Val(B.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Res.Text = Val(A.Text) * Val(B.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Res.Text = Val(A.Text) / Val(B.Text)
    End Sub
End Class
