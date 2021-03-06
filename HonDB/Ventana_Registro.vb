﻿Imports MySql.Data.MySqlClient
Public Class Ventana_Registro

    Dim idp As Int32
    Shared ids As New List(Of Int32)


    Public Shared Sub AddId(ByVal idl As Int32)

        ids.Add(idl)
        Ventana_Registro.CantP.Text = ids.Count.ToString

    End Sub

    Private Sub Ventana_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        CBEstado.DisplayMember = "Préstamo Vigente"

        LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, u.sexo AS Sexo, ubicacion.pais AS País,
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
        RectangleBusqueda.Enabled = False
        RectangleNS.Enabled = False
        RectangleShape1.Enabled = False
        RectangleShape8.Enabled = False
        RectangleShape2.Enabled = False
        RectangleShape5.Enabled = False
        RectangleShape3.Enabled = False
        RectangleShape6.Enabled = False

    End Sub

    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click

        Dim CrearUsuario As String
        Dim CrearPrestamo As String
        ConexionBD.AbrirConexion()
        CrearUsuario = "INSERT INTO usuario (nombre,apellido,identificacion,sexo,idubicacion) 
        VALUES ('" & NUsuario.Text & "','" & AUsuario.Text & "','" & IDUsuario.Text & "','" & Sexo.SelectedItem & "', (SELECT idubicacion FROM ubicacion WHERE ciudad = '" & Ciudad.SelectedItem & "'))"
        SaveData(CrearUsuario)
        CrearPrestamo = "INSERT INTO prestamo (idusuario, idbibliotecario, fechaprestamo, fechadevolucion, cantidad, estado)
        VALUES ((SELECT idusuario FROM usuario WHERE identificacion = '" & IDUsuario.Text & "'), (SELECT idbibliotecario FROM bibliotecario WHERE nombre = '" & CBBN.SelectedItem & "')
        , STR_TO_DATE('" & FP.Value.Date.ToString("dd/MM/yyyy") & "', '%d/%m/%Y') , STR_TO_DATE('" & FD.Value.Date & "', '%d/%m/%Y') ,'" & CantP.Text & "','" & CBEstado.Items.Item(0) & "')"
        SaveData(CrearPrestamo)
        MsgBox("Préstamo creado exitosamente")
        GetData("SELECT p.idprestamo FROM prestamo p ORDER BY p.idprestamo DESC LIMIT 1;", idp)
        idPrestamo.Text = idp.ToString
        Dim CrearDetallePrestamo As String
        For Each i As Int32 In ids
            CrearDetallePrestamo = "INSERT INTO detalleprestamo(idlibro,idprestamo) VALUES ('" & i & "','" & idPrestamo.Text & "')"
            SaveData(CrearDetallePrestamo)
        Next

    End Sub


    Private Sub BTEditar_Click(sender As Object, e As EventArgs) Handles BTEditar.Click
        Dim EditarUsuario As String
        EditarUsuario = "Update usuario Set nombre = '" & NUsuario.Text & "', apellido = '" & AUsuario.Text & "', 
        identificacion = '" & IDUsuario.Text & "', sexo = '" & Sexo.SelectedItem & "' Where idusuario = " & ID.Text
        SaveData(EditarUsuario)
        Dim EditarPrestamo As String
        EditarPrestamo = "Update prestamo Set fechaprestamo =  STR_TO_DATE('" & FP.Value.Date.ToString("dd/MM/yyyy") & "', '%d/%m/%Y') , fechadevolucion = STR_TO_DATE('" & FD.Value.Date & "', '%d/%m/%Y'), cantidad = '" & CantP.Text & "' Where idprestamo = '" & idPrestamo.Text & "';"
        SaveData(EditarPrestamo)
    End Sub

    Private Sub BTEliminar_Click(sender As Object, e As EventArgs) Handles BTEliminar.Click
        Dim EliminarPrestamo As String
        Dim EliminarDetalleP As String
        Dim Decision = MessageBox.Show("¿Desea eliminar este préstamo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Decision = DialogResult.Yes Then
            EliminarDetalleP = "DELETE FROM detalleprestamo WHERE idprestamo = " & idPrestamo.Text
            SaveData(EliminarDetalleP)
            EliminarPrestamo = "DELETE FROM prestamo WHERE idprestamo = " & idPrestamo.Text
            SaveData(EliminarPrestamo)
        End If
    End Sub

    Private Sub BTActualizar_Click(sender As Object, e As EventArgs) Handles BTActualizar.Click
        LlenarTabla(DatosGrid, "SELECT p.idprestamo AS '#', u.idusuario AS 'Codigo de usuario', u.nombre AS Nombre,
        u.apellido AS Apellido, u.identificacion AS Identificacion, u.sexo AS Sexo, ubicacion.pais AS País,
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
        u.apellido AS Apellido, u.identificacion AS Identificacion, u.sexo AS Sexo, ubicacion.pais AS País,
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
        u.apellido AS Apellido, u.identificacion AS Identificacion, u.sexo AS Sexo, ubicacion.pais AS País,
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
            idPrestamo.Text = DatosGrid.Item(0, S).Value()
            ID.Text = DatosGrid.Item(1, S).Value()
            NUsuario.Text = DatosGrid.Item(2, S).Value()
            AUsuario.Text = DatosGrid.Item(3, S).Value()
            IDUsuario.Text = DatosGrid.Item(4, S).Value()
            Sexo.Text = DatosGrid.Item(5, S).Value()
            Pais.Text = DatosGrid.Item(6, S).Value()
            Ciudad.Text = DatosGrid.Item(7, S).Value()
            Nacionalidad.Text = DatosGrid.Item(8, S).Value()
            LBPrestamos.Text = DatosGrid.Item(9, S).Value()
            FP.Text = DatosGrid.Item(10, S).Value()
            FD.Text = DatosGrid.Item(11, S).Value()
            CantP.Text = DatosGrid.Item(12, S).Value()
            CBEstado.Text = DatosGrid.Item(13, S).Value()
            CBBN.SelectedItem = DatosGrid.Item(14, S).Value()
        End If
    End Sub

    Private Sub CBEdit_CheckedChanged(sender As Object, e As EventArgs) Handles CBEdit.CheckedChanged

        If CBEdit.Checked = True Then
            Lupa.Visible = False
        Else
            Lupa.Visible = True
        End If

        If CBEdit.Checked = True Then
            BTEliminar.Enabled = True
        Else
            BTEliminar.Enabled = False
        End If

        If CBEdit.Checked = True Then
            BTCrear.Enabled = False
        Else
            BTCrear.Enabled = True
        End If

        If CBEdit.Checked = True Then
            CBEstado.Enabled = True
        Else
            CBEstado.Enabled = False
        End If

        If CBEdit.Checked = True Then
            CantP.Enabled = True
        Else
            CantP.Enabled = False
        End If

        If CBEdit.Checked = True Then
            Dim S As Integer
            S = DatosGrid.CurrentRow.Index
            idPrestamo.Text = DatosGrid.Item(0, S).Value()
            ID.Text = DatosGrid.Item(1, S).Value()
            NUsuario.Text = DatosGrid.Item(2, S).Value()
            AUsuario.Text = DatosGrid.Item(3, S).Value()
            IDUsuario.Text = DatosGrid.Item(4, S).Value()
            Sexo.Text = DatosGrid.Item(5, S).Value()
            Pais.Text = DatosGrid.Item(6, S).Value()
            Ciudad.Text = DatosGrid.Item(7, S).Value()
            Nacionalidad.Text = DatosGrid.Item(8, S).Value()
            LBPrestamos.Text = DatosGrid.Item(9, S).Value()
            FP.Text = DatosGrid.Item(10, S).Value()
            FD.Text = DatosGrid.Item(11, S).Value()
            CantP.Text = DatosGrid.Item(12, S).Value()
            CBEstado.Text = DatosGrid.Item(13, S).Value()
            CBBN.SelectedItem = DatosGrid.Item(14, S).Value()
        ElseIf CBEdit.Checked = False Then
            NUsuario.Clear()
            AUsuario.Clear()
            IDUsuario.Clear()
            Sexo.ResetText()
            Pais.ResetText()
            Ciudad.ResetText()
            CantP.Clear()
            Nacionalidad.ResetText()
            ID.Clear()
            LBPrestamos.Clear()
            CBEstado.ResetText()
            CBBN.ResetText()
            FP.ResetText()
            FD.ResetText()
        End If
    End Sub

    Private Sub NUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Pais_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nacionalidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CantP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Lupa_Click(sender As Object, e As EventArgs) Handles Lupa.Click
        Busqueda.Show()
    End Sub

    Private Sub BTGuardar_Click(sender As Object, e As EventArgs) Handles BTGuardar.Click
        NUsuario.Clear()
        AUsuario.Clear()
        IDUsuario.Clear()
        Pais.ResetText()
        Ciudad.ResetText()
        CantP.Clear()
        Nacionalidad.ResetText()
        ID.Clear()
        LBPrestamos.Clear()
        CBEstado.ResetText()
        CBBN.ResetText()
        FP.ResetText()
        FD.ResetText()
        Me.Close()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        NUsuario.Clear()
        AUsuario.Clear()
        IDUsuario.Clear()
        Pais.ResetText()
        Ciudad.ResetText()
        CantP.Clear()
        Nacionalidad.ResetText()
        ID.Clear()
        LBPrestamos.Clear()
        CBEstado.ResetText()
        CBBN.ResetText()
        FP.ResetText()
        FD.ResetText()
        ids.Clear()
    End Sub
End Class