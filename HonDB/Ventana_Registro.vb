Imports MySql.Data.MySqlClient
Public Class Ventana_Registro
    Private Sub Ventana_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LlenarTabla(DatosGrid, "Select usuario.idusuario as Código, usuario.nombre as Nombre, usuario.apellido as Apellido,
        usuario.identificacion as Identificación, ubicacion.pais as País, ubicacion.ciudad as Ciudad, 
        ubicacion.nacionalidad as Nacionalidad, libro.titulo as Libros,
        prestamo.estado as Estado, prestamo.fechaprestamo as Prestamo,
        prestamo.fechadevolucion as Devolución, prestamo.cantidad as Cantidad, bibliotecario.nombre as Nombre_B,
        bibliotecario.apellido as Apellido_B
        From Usuario
        Inner Join ubicacion ON usuario.idubicacion=ubicacion.idubicacion
        Inner Join libro ON libro.idubicacion=ubicacion.idubicacion
        Inner Join prestamo ON prestamo.idusuario=usuario.idusuario 
        Inner Join bibliotecario ON prestamo.idbibliotecario = bibliotecario.idbibliotecario
        Group by usuario.idusuario", "usuario")
        PopulateCombobox(CBEstado, "prestamo", "estado")
    End Sub

    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click
        Dim CrearUsuario As String
        Dim CrearUbicacion As String
        ConexionBD.AbrirConexion()
        CrearUbicacion = "INSERT INTO ubicacion(pais,ciudad,nacionalidad) 
        VALUES ('" & Pais.Text & "','" & Ciudad.Text & "','" & Nacionalidad.Text & "')"
        SaveData(CrearUbicacion)
        CrearUsuario = "INSERT INTO usuario (nombre,apellido,identificacion,idubicacion) 
        VALUES ('" & NUsuario.Text & "','" & AUsuario.Text & "','" & IDUsuario.Text & "', (SELECT idubicacion FROM ubicacion WHERE ciudad = '" & Ciudad.Text & "'))"
        SaveData(CrearUsuario)
        MsgBox("Préstamo creado exitosamente")
        NUsuario.Clear()
        AUsuario.Clear()
        IDUsuario.Clear()
        Pais.Clear()
        Ciudad.Clear()
        Nacionalidad.Clear()
    End Sub

    Private Sub TBBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBBusqueda.TextChanged
        LlenarTabla(DatosGrid, "Select usuario.idusuario as Código, usuario.nombre as Nombre, usuario.apellido as Apellido,
        usuario.identificacion as Identificación, ubicacion.pais as País, ubicacion.ciudad as Ciudad, 
        ubicacion.nacionalidad as Nacionalidad, libro.titulo as Libros,
        prestamo.estado as Estado, prestamo.fechaprestamo as Prestamo,
        prestamo.fechadevolucion as Devolución, prestamo.cantidad as Cantidad, bibliotecario.nombre as Nombre_B,
        bibliotecario.apellido as Apellido_B
        From Usuario
        Inner Join ubicacion ON usuario.idubicacion=ubicacion.idubicacion
        Inner Join libro ON libro.idubicacion=ubicacion.idubicacion
        Inner Join prestamo ON prestamo.idusuario=usuario.idusuario 
        Inner Join bibliotecario ON prestamo.idbibliotecario = bibliotecario.idbibliotecario
        Group by usuario.idusuario Having usuario.nombre like '" & TBBusqueda.Text & "%'", "usuario")
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosGrid.CellContentClick
        DatosGrid.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub BTActualizar_Click(sender As Object, e As EventArgs) Handles BTActualizar.Click
        LlenarTabla(DatosGrid, "Select usuario.idusuario as Código, usuario.nombre as Nombre, usuario.apellido as Apellido,
        usuario.identificacion as Identificación, ubicacion.pais as País, ubicacion.ciudad as Ciudad, 
        ubicacion.nacionalidad as Nacionalidad, libro.titulo as Libros,
        prestamo.estado as Estado, prestamo.fechaprestamo as Prestamo,
        prestamo.fechadevolucion as Devolución, prestamo.cantidad as Cantidad, bibliotecario.nombre as Nombre_B,
        bibliotecario.apellido as Apellido_B
        From Usuario
        Inner Join ubicacion ON usuario.idubicacion=ubicacion.idubicacion
        Inner Join libro ON libro.idubicacion=ubicacion.idubicacion
        Inner Join prestamo ON prestamo.idusuario=usuario.idusuario 
        Inner Join bibliotecario ON prestamo.idbibliotecario = bibliotecario.idbibliotecario
        Group by usuario.idusuario", "usuario")
    End Sub


End Class