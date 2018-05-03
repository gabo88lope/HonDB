Public Class FReportes
    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub CBTipoReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReportes.SelectedIndexChanged
        Select Case CBTipoReportes.SelectedIndex
            Case 0
                DGVReporte.DataSource = Nothing
                DGVReporte.Rows.Clear()
            Case 1
                LlenarTabla(DGVReporte, "SELECT idprestamo As 'Numero de Prestamo', usuario.nombre As Nombre, usuario.apellido 
                AS Apellido,bibliotecario.nombre As 'Nombre Bibliotecario', cantidad As Cantidad, fechaprestamo 
                AS 'Fecha de Prestamo',fechadevolucion As 'Fecha de Devolucion', estado as 'Estado de prestamo' 
                from usuario 
                INNER JOIN prestamo ON prestamo.idusuario = usuario.idusuario 
                INNER JOIN bibliotecario ON bibliotecario.idbibliotecario = prestamo.idbibliotecario 
                Where prestamo.estado = 'Prestamo Vencido';", "prestamo")
            Case 2
                LlenarTabla(DGVReporte, "SELECT idprestamo As 'Numero de Prestamo', usuario.nombre As Nombre, usuario.apellido 
                AS Apellido,bibliotecario.nombre As 'Nombre Bibliotecario', cantidad As Cantidad, fechaprestamo 
                AS 'Fecha de Prestamo',fechadevolucion As 'Fecha de Devolucion', estado as 'Estado de prestamo' 
                from usuario 
                INNER JOIN prestamo ON prestamo.idusuario = usuario.idusuario 
                INNER JOIN bibliotecario ON bibliotecario.idbibliotecario = prestamo.idbibliotecario 
                Where prestamo.estado = 'Prestamo Finalizado';", "prestamo")
            Case 3

            Case 4

            Case Else

        End Select
    End Sub

    Private Sub FReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBTipoReportes.DataSource = GetCBItems()
        CBTipoReportes.DisplayMember = "Elija una opción"
    End Sub

    Function GetCBItems() As List(Of String)

        Dim cbitems = New List(Of String) From {
            "Elija una opción",
            "Préstamos vencidos",
            "Préstamos finalizados",
            "Libros más prestados",
            "Libros dañados"
        }

        Return cbitems

    End Function
End Class