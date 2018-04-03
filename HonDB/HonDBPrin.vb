Public Class HonDBPrin

    Private Sub HonPrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSSLTiempo.Text = System.DateTime.Now.ToString


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

End Class
