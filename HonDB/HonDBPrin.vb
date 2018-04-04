Public Class HonDBPrin

    Private Sub HonPrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSSLTiempo.Text = System.DateTime.Now.ToString


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventana_Registro.Show()

    End Sub
End Class
