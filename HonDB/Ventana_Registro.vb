Public Class Ventana_Registro
    Private Sub Ventana_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        llenarTabla(Datos, "Select usuario.idusuario as Código, usuario.nombre as Nombre, usuario.apellido as Apellido, 
        usuario.identificacion as Identificación, libro.titulo as Libros, ubicacion.nacionalidad as Nacionalidad, prestamo.estado as Estado, prestamo.fechaprestamo as Prestamo,
        prestamo.fechadevolucion as Devolución, prestamo.cantidad as Cantidad, bibliotecario.nombre as Nombre_B, 
        bibliotecario.apellido as Apellido_B
        From ((((usuario Inner Join ubicacion)Inner Join libro)Inner Join prestamo)Inner Join bibliotecario) Group by usuario.idusuario", "usuario")

    End Sub

    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click
        Ventana_Nuevo_Registro.Show()
    End Sub

    Private Sub TBBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBBusqueda.TextChanged
        llenarTabla(Datos, "Select usuario.idusuario as Código, usuario.nombre as Nombre, usuario.apellido as Apellido, 
        usuario.identificacion as Identificación, libro.titulo as Libros, ubicacion.nacionalidad as Nacionalidad, prestamo.estado as Estado, prestamo.fechaprestamo as Prestamo,
        prestamo.fechadevolucion as Devolución, prestamo.cantidad as Cantidad, bibliotecario.nombre as Nombre_B, 
        bibliotecario.apellido as Apellido_B
        From ((((usuario Inner Join ubicacion)Inner Join libro)Inner Join prestamo)Inner Join bibliotecario) Group by usuario.idusuario Having usuario.nombre like '" & TBBusqueda.Text & "%'", "usuario")
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub
End Class