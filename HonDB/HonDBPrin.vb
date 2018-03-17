Public Class HonPrin
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub HonPrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TSSLTiempo.Text = System.DateTime.Now.ToString

        HonDBSec.Show()
        HonDBSec.Focus()

    End Sub
End Class
