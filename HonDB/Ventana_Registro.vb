Imports MySql.Data.MySqlClient
Public Class Ventana_Registro
    Private Sub Ventana_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, ubicacion.pais AS País,
        ubicacion.ciudad AS Ciudad, ubicacion.nacionalidad AS Nacionalidad,
        GROUP_CONCAT(DISTINCT l.titulo SEPARATOR ', ') AS 'Libros prestados', 
        p.fechaprestamo AS 'Fecha de prestamo', p.fechadevolucion AS 'Fecha de devolucion',
        p.cantidad AS Cantidad, p.estado AS Estado, b.nombre AS 'Nombre bibliotecario', b.apellido AS 'Apellido bibliotecario'
        FROM Prestamo p
        INNER JOIN detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
        INNER JOIN libro l ON (dp.idlibro = l.idlibro)
        INNER JOIN usuario u ON (p.idusuario = u.idusuario)
        INNER JOIN ubicacion ON u.idubicacion = ubicacion.idubicacion
        INNER JOIN bibliotecario b ON p.idbibliotecario = b.idbibliotecario
        GROUP BY p.idprestamo;", "prestamo")
        PopulateCombobox(CBBN, "bibliotecario", "nombre")
        PopulateCombobox(CBBA, "bibliotecario", "apellido")
    End Sub

    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click
        If CBEdit.Checked = True Then
            BTCrear.Enabled = False
        End If
        Dim CrearUsuario As String
        Dim CrearUbicacion As String
        Dim CrearPrestamo As String
        Dim CrearDetallePrestamo As String
        ConexionBD.AbrirConexion()
        CrearUbicacion = "INSERT INTO ubicacion(pais,ciudad,nacionalidad)
        VALUES ('" & Pais.Text & "','" & Ciudad.Text & "','" & Nacionalidad.Text & "')"
        SaveData(CrearUbicacion)
        CrearUsuario = "INSERT INTO usuario (nombre,apellido,identificacion,idubicacion) 
        VALUES ('" & NUsuario.Text & "','" & AUsuario.Text & "','" & IDUsuario.Text & "', (SELECT idubicacion FROM ubicacion WHERE ciudad = '" & Ciudad.Text & "'))"
        SaveData(CrearUsuario)
        CrearPrestamo = "INSERT INTO prestamo (idusuario, idbibliotecario, fechaprestamo, fechadevolucion, cantidad, estado)
        VALUES ((SELECT idusuario FROM usuario WHERE identificacion = '" & IDUsuario.Text & "'), (SELECT idbibliotecario FROM bibliotecario WHERE nombre = '" & CBBN.SelectedItem & "')
        ,'" & FP.Value.Date & "','" & FD.Value.Date & "','" & CantP.Text & "','" & CBEstado.SelectedItem & "')"
        MsgBox(CrearPrestamo)
        SaveData(CrearPrestamo)
        CrearDetallePrestamo = "INSERT INTO detalleprestamo(idlibro,idprestamo)
        VALUES ((SELECT idlibro FROM libro WHERE titulo = '" & LBPrestamos.Text & "') , (SELECT idusuario FROM prestamo WHERE identificacion = '" & IDUsuario.Text & "'))"
        SaveData(CrearDetallePrestamo)
        MsgBox("Préstamo creado exitosamente")
        NUsuario.Clear()
        AUsuario.Clear()
        IDUsuario.Clear()
        Pais.Clear()
        Ciudad.Clear()
        Nacionalidad.Clear()
        ID.Clear()
        LBPrestamos.Clear()
        CBEstado.ResetText()
        CBBN.ResetText()
        CBBA.ResetText()
        FP.ResetText()
        FD.ResetText()
    End Sub

    Private Sub BTEditar_Click(sender As Object, e As EventArgs) Handles BTEditar.Click
        Dim EditarUsuario As String
        EditarUsuario = "Update usuario Set nombre = '" & NUsuario.Text & "', apellido = '" & AUsuario.Text & "', 
        identificacion = '" & IDUsuario.Text & "' Where idusuario = " & ID.Text
        MsgBox(EditarUsuario)
        SaveData(EditarUsuario)
        Dim EditarPrestamo As String
        EditarPrestamo = "Update prestamo Set fechaprestamo = '" & FP.Value & "', fechadevolucion = '" & FD.Value & "', 
        cantidad = '" & CantP.Text & "' Where idusuario = " & ID.Text
        SaveData(EditarPrestamo)
    End Sub

    Private Sub BTEliminar_Click(sender As Object, e As EventArgs) Handles BTEliminar.Click
        Dim EliminarPrestamo As String
        Dim EliminarDetalleP As String
        EliminarDetalleP = "DELETE FROM detalleprestamo WHERE idprestamo = '"
        SaveData(EliminarDetalleP)
        EliminarPrestamo = "DELETE FROM prestamo WHERE idprestamo = '"
        SaveData(EliminarPrestamo)
    End Sub

    Private Sub BTActualizar_Click(sender As Object, e As EventArgs) Handles BTActualizar.Click
        LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, ubicacion.pais AS País,
        ubicacion.ciudad AS Ciudad, ubicacion.nacionalidad AS Nacionalidad,
        GROUP_CONCAT(DISTINCT l.titulo SEPARATOR ', ') AS 'Libros prestados', 
        p.fechaprestamo AS 'Fecha de prestamo', p.fechadevolucion AS 'Fecha de devolucion',
        p.cantidad AS Cantidad, p.estado AS Estado, b.nombre AS 'Nombre bibliotecario', b.apellido AS 'Apellido bibliotecario'
        FROM Prestamo p
        INNER JOIN detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
        INNER JOIN libro l ON (dp.idlibro = l.idlibro)
        INNER JOIN usuario u ON (p.idusuario = u.idusuario)
        INNER JOIN ubicacion ON u.idubicacion = ubicacion.idubicacion
        INNER JOIN bibliotecario b ON p.idbibliotecario = b.idbibliotecario
        GROUP BY p.idprestamo;", "prestamo")
    End Sub

    Private Sub TBBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBBusqueda.TextChanged
        If CBFiltro.Text = "Nombre" Then
            LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, ubicacion.pais AS País,
        ubicacion.ciudad AS Ciudad, ubicacion.nacionalidad AS Nacionalidad,
        GROUP_CONCAT(DISTINCT l.titulo SEPARATOR ', ') AS 'Libros prestados', 
        p.fechaprestamo AS 'Fecha de prestamo', p.fechadevolucion AS 'Fecha de devolucion',
        p.cantidad AS Cantidad, p.estado AS Estado, b.nombre AS 'Nombre bibliotecario', b.apellido AS 'Apellido bibliotecario'
        FROM Prestamo p
        INNER JOIN detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
        INNER JOIN libro l ON (dp.idlibro = l.idlibro)
        INNER JOIN usuario u ON (p.idusuario = u.idusuario)
        INNER JOIN ubicacion ON u.idubicacion = ubicacion.idubicacion
        INNER JOIN bibliotecario b ON p.idbibliotecario = b.idbibliotecario
        Group by u.idusuario Having u.nombre like '" & TBBusqueda.Text & "%'", "usuario")

        ElseIf CBFiltro.Text = "Identificación" Then
            LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, ubicacion.pais AS País,
        ubicacion.ciudad AS Ciudad, ubicacion.nacionalidad AS Nacionalidad,
        GROUP_CONCAT(DISTINCT l.titulo SEPARATOR ', ') AS 'Libros prestados', 
        p.fechaprestamo AS 'Fecha de prestamo', p.fechadevolucion AS 'Fecha de devolucion',
        p.cantidad AS Cantidad, p.estado AS Estado, b.nombre AS 'Nombre bibliotecario', b.apellido AS 'Apellido bibliotecario'
        FROM Prestamo p
        INNER JOIN detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
        INNER JOIN libro l ON (dp.idlibro = l.idlibro)
        INNER JOIN usuario u ON (p.idusuario = u.idusuario)
        INNER JOIN ubicacion ON u.idubicacion = ubicacion.idubicacion
        INNER JOIN bibliotecario b ON p.idbibliotecario = b.idbibliotecario
        Group by u.idusuario Having u.identificacion like '" & TBBusqueda.Text & "%'", "usuario")
        End If
    End Sub

    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosGrid.CellContentClick
        If CBEdit.Checked = True Then
            Dim S As Integer
            S = DatosGrid.CurrentRow.Index
            ID.Text = DatosGrid.Item(1, S).Value()
            NUsuario.Text = DatosGrid.Item(2, S).Value()
            AUsuario.Text = DatosGrid.Item(3, S).Value()
            IDUsuario.Text = DatosGrid.Item(4, S).Value()
            Pais.Text = DatosGrid.Item(5, S).Value()
            Ciudad.Text = DatosGrid.Item(6, S).Value()
            Nacionalidad.Text = DatosGrid.Item(7, S).Value()
            LBPrestamos.Text = DatosGrid.Item(8, S).Value()
            FP.Text = DatosGrid.Item(9, S).Value()
            FD.Text = DatosGrid.Item(10, S).Value()
            CantP.Text = DatosGrid.Item(11, S).Value()
            CBEstado.Text = DatosGrid.Item(12, S).Value()
            CBBN.SelectedItem = DatosGrid.Item(13, S).Value()
            CBBA.SelectedItem = DatosGrid.Item(14, S).Value()
        End If
    End Sub

    Private Sub CBEdit_CheckedChanged(sender As Object, e As EventArgs) Handles CBEdit.CheckedChanged
        If CBEdit.Checked = True Then
            Dim S As Integer
            S = DatosGrid.CurrentRow.Index
            ID.Text = DatosGrid.Item(1, S).Value()
            NUsuario.Text = DatosGrid.Item(2, S).Value()
            AUsuario.Text = DatosGrid.Item(3, S).Value()
            IDUsuario.Text = DatosGrid.Item(4, S).Value()
            Pais.Text = DatosGrid.Item(5, S).Value()
            Ciudad.Text = DatosGrid.Item(6, S).Value()
            Nacionalidad.Text = DatosGrid.Item(7, S).Value()
            LBPrestamos.Text = DatosGrid.Item(8, S).Value()
            FP.Text = DatosGrid.Item(9, S).Value()
            FD.Text = DatosGrid.Item(10, S).Value()
            CantP.Text = DatosGrid.Item(11, S).Value()
            CBEstado.Text = DatosGrid.Item(12, S).Value()
            CBBN.SelectedItem = DatosGrid.Item(13, S).Value()
            CBBA.SelectedItem = DatosGrid.Item(14, S).Value()
        ElseIf CBEdit.Checked = False Then
            NUsuario.Clear()
            AUsuario.Clear()
            IDUsuario.Clear()
            Pais.Clear()
            Ciudad.Clear()
            CantP.Clear()
            Nacionalidad.Clear()
            ID.Clear()
            LBPrestamos.Clear()
            CBEstado.ResetText()
            CBBN.ResetText()
            CBBA.ResetText()
            FP.ResetText()
            FD.ResetText()
        End If
    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub
End Class