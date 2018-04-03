Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Parent = PictureBox1

    End Sub

    Private Sub UsernameText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameText.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            passText.Text = ""
            passText.Select()
        End If

    End Sub

    Private Sub BotonIngresar_Click(sender As Object, e As EventArgs) Handles BotonIngresar.Click
        HonDBPrin.Show()
        HonDBPrin.Focus()
        Me.Close()
    End Sub
End Class
