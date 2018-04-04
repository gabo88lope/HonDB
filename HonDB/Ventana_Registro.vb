Public Class Ventana_Registro
    Private Sub Ventana_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub
End Class