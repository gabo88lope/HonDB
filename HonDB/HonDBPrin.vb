Public Class HonDBPrin

    Private Sub HonPrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each b As Object In FLPButtons.Controls
            b.FlatStyle = Windows.Forms.FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.FlatAppearance.MouseDownBackColor = Color.Transparent
            b.BackColor = Color.Transparent
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSSLTiempo.Text = FormatDateTime(Now, DateFormat.GeneralDate)
    End Sub

    Private Sub BBusqueda_Click(sender As Object, e As EventArgs) Handles BBusqueda.Click

    End Sub

    Private Sub BReporte_Click(sender As Object, e As EventArgs) Handles BReporte.Click

    End Sub

    Private Sub BAdministrar_Click(sender As Object, e As EventArgs) Handles BAdministrar.Click

    End Sub

    Private Sub BRegistro_Click_1(sender As Object, e As EventArgs) Handles BRegistro.Click
        Ventana_Registro.Show()
        Ventana_Registro.Focus()
    End Sub

End Class
