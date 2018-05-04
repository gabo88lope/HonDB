Public Class EMsg

    Public Shared Shadows Function Show(ByVal m As String, ex As Exception) As DialogResult
        Dim dlg As New EMsg()

        dlg.TBError.Text = m
        dlg.TBEx.Text = ex.Message & Environment.NewLine & Environment.NewLine & "******** Stack de la Excepcion ******** " & Environment.NewLine & ex.StackTrace

        Dim res = dlg.ShowDialog

        dlg.Dispose()

        Return res
    End Function

    Private Sub EMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBMensaje.Text = "Excepcion no controlada en la aplicación. Haga clic en Ver detalles para ver información detallada acerca del error, o haga clic en Aceptar para cerrar este mensaje"
    End Sub

    Private Sub BDetalles_Click(sender As Object, e As EventArgs) Handles BDetalles.Click
        If TBEx.Visible Then
            TBEx.Visible = False
        ElseIf Not TBEx.Visible Then
            TBEx.Visible = True
        End If
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Close()
    End Sub
End Class