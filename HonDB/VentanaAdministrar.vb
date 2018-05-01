Imports HonDB.ConexionBD
Imports MySql.Data.MySqlClient

Public Class VentanaAdministrar

    Dim indexSelected As Integer
    Dim idActual As Integer
    Dim edicion = False
    Dim cadenaBusquedaUsuario As String
    Dim buscarPorNombre, buscarPorCodigo, buscarPorCedula As Boolean


    Private Sub VentanaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized


        LlenarTabla(tablaLibros, tablaLibroQuery, "libro")
        LlenarTabla(tablaUsuarios, tablaUsuarioCons, "usuario")
        'PopulateCombobox(SearchWayCb, "usuario", "sexo")
        'SearchWayCb.Items.Add("Código")
        SearchWayCb.Items.Add("Cédula")
        SearchWayCb.Items.Add("Nombre")
        SearchWayCb.SelectedItem = "Nombre"
        buscarPorNombre = True
    End Sub

    Private Sub RetornoIconA_Click(sender As Object, e As EventArgs) Handles RetornoIconA.Click
        Me.Close()
    End Sub



    Private Sub BTCrearVA_Click(sender As Object, e As EventArgs) Handles BTCrearVA.Click
        PanelDatosUsuario.Visible = True
        PopulateCombobox(cbUbicacion, "ubicacion", "ciudad")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelDatosUsuario.Visible = False
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        cbUbicacion.Items.Clear()
        rdMasculino.Select()
        edicion = False
        idActual = 0
        botonEditar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim sex As String
        Dim ubicacion As String
        Dim subQuery As String
        Dim query As String
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            If edicion = False Then

                If verificarRE("SELECT * FROM usuario where identificacion = '" & txtCedula.Text & "'", "cédula") <> True Then

                    If rbFemenino.Checked = True Then
                        sex = "Femenino"

                    Else
                        sex = "Masculino"
                    End If

                    subQuery = "(SELECT idubicacion FROM ubicacion WHERE ciudad = '" & cbUbicacion.SelectedItem & "')"

                    query = "Insert into usuario (nombre, apellido, identificacion, sexo, idubicacion)
                    VALUES ('" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtCedula.Text & "',
                    '" & sex & "'," & subQuery & ")"

                    SaveData(query)

                End If

            Else
                If rbFemenino.Checked = True Then
                    sex = "Femenino"

                Else
                    sex = "Masculino"
                End If

                subQuery = "(SELECT idubicacion FROM ubicacion WHERE ciudad = '" & cbUbicacion.SelectedItem & "')"
                query = "Update usuario Set nombre = '" & txtNombre.Text & "', apellido = '" & txtApellido.Text & "', 
                identificacion = '" & txtCedula.Text & "', sexo = '" & sex & "',idubicacion = " & subQuery & " Where idusuario = " & indexSelected
                SaveData(query)
            End If
        End If


    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = False
        End If
    End Sub

    Private Sub tablaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaUsuarios.CellClick
        Dim value As Object = tablaUsuarios.CurrentRow.Cells(0).Value

        'MsgBox(CType(value, Integer))
        indexSelected = CType(value, Integer)
        'campoBuscar.Text = indexSelected
    End Sub

    Private Sub botonEditar_Click(sender As Object, e As EventArgs) Handles botonEditar.Click
        Try

            AbrirConexion()
            Dim query As String
            idActual = indexSelected
            query = "SELECT u.idusuario, u.nombre, u.apellido, u.identificacion, u.sexo, c.Ciudad
            FROM usuario u INNER JOIN ubicacion c ON u.idubicacion = c.idubicacion WHERE u.idusuario = " & indexSelected
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtNombre.Text = reader.GetString("nombre")
            txtApellido.Text = reader.GetString("apellido")
            txtCedula.Text = reader.GetString("identificacion")
            If reader.GetString("sexo") = "Femenino" Then
                rbFemenino.Select()
            Else
                rdMasculino.Select()
            End If
            Dim city As String
            city = reader.GetString("Ciudad")
            PopulateCombobox(cbUbicacion, "ubicacion", "Ciudad")
            cbUbicacion.SelectedItem = city
            PanelDatosUsuario.Visible = True
            edicion = True
            botonEditar.Enabled = False
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTActualizar_Click(sender As Object, e As EventArgs) Handles BTActualizar.Click

        LlenarTabla(tablaUsuarios, tablaUsuarioCons, "usuario")
    End Sub

    Private Sub botonEliminar_Click(sender As Object, e As EventArgs) Handles botonEliminar.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM usuario WHERE idusuario = " & indexSelected)
        End If
    End Sub

    Private Sub SearchWayCb_SelectedValueChanged(sender As Object, e As EventArgs) Handles SearchWayCb.SelectedValueChanged
        If SearchWayCb.SelectedItem = "Nombre" Then
            buscarPorNombre = True
            buscarPorCedula = False
            'buscarPorCodigo = False
        ElseIf SearchWayCb.SelectedItem = "Cédula" Then
            buscarPorCedula = True
            'buscarPorCodigo = False
            buscarPorNombre = False
        Else
            'buscarPorCodigo = True
            buscarPorNombre = False
            buscarPorCedula = False
        End If
    End Sub

    Private Sub campoBuscar_TextChanged(sender As Object, e As EventArgs) Handles campoBuscar.TextChanged
        If buscarPorNombre = True Then
            campoUsuario = busquedaNombre & " where u.nombre like '" & campoBuscar.Text & "%'"
            LlenarTabla(tablaUsuarios, campoUsuario, "usuario")

        ElseIf buscarPorCedula = True Then
            campoUsuario = busquedaNombre & " where u.identificacion like '" & campoBuscar.Text & "%'"
            LlenarTabla(tablaUsuarios, campoUsuario, "usuario")
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------
    '/////////////////////////// LIBROS //////////////////

    Private Sub tablaLibros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaLibros.CellClick
        Dim value As Object = tablaUsuarios.CurrentRow.Cells(0).Value

        indexSelected = CType(value, Integer)
    End Sub


End Class