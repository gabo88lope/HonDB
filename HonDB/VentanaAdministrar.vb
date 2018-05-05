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
        LlenarTabla(tablaAutores, queryAutorTabla, "autor")
        LlenarTabla(tablaBibliotecario, queryBiblioTabla, "bibliotecario")
        llenarLista(listaTipoDoc, "tipodocumento", "nombre")
        llenarLista(listaEditoriales, "editorial", "nombre")
        LlenarTabla(tablaUbicaciones, queryUbicacionesTabla, "ubicacion")
        LlenarTabla(tablaCG, queryTablaCG, "categoriageneral")
        AjustarAnchoColumna(tablaCG, 180, 2)
        LlenarTabla(tablaCE, queryTablaCE, "categoriaespecial")
        AjustarAnchoColumna(tablaCE, 150, 3)
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
        Dim subQuery As String
        Dim query As String
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            If edicion = False Then

                If VerificarRE("SELECT * FROM usuario where identificacion = '" & txtCedula.Text & "'", "cédula") <> True Then

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
        Try
            indexSelected = CType(value, Integer)
        Catch ex As Exception

        End Try
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
        Try
            Dim value As Object = tablaLibros.CurrentRow.Cells(0).Value

            indexSelected = CType(value, Integer)
        Catch ex As Exception
            indexSelected = -1
        End Try
    End Sub

    Private Sub btCrearLibro_Click(sender As Object, e As EventArgs) Handles btCrearLibro.Click
        PanelDatosLibros.Visible = True
        btEditarLibro.Enabled = False
        btEliminarLibro.Enabled = False
        PopulateCombobox(cbCiudadL, "Ubicacion", "Ciudad")
        PopulateCombobox(CBCatG, "categoriageneral", "nombre")
        PopulateCombobox(CBCatE, "categoriaespecial", "nombre")
        PopulateCombobox(CBTipoDoc, "tipodocumento", "nombre")
        PopulateCombobox(cbEditarialLibro, "editorial", "nombre")
        PopulateCombobox(cbAutorLibro, "autor", "nombre")
    End Sub

    Private Sub btActualizarTL_Click(sender As Object, e As EventArgs) Handles btActualizarTL.Click
        LlenarTabla(tablaLibros, tablaLibroQuery, "libro")
    End Sub

    Private Sub txtBuscarLibro_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarLibro.TextChanged
        Dim query = tablaLibroQuery & " Where l.titulo like '" & txtBuscarLibro.Text & "%'"
        LlenarTabla(tablaLibros, query, "libro")
    End Sub

    Private Sub btCancelarL_Click(sender As Object, e As EventArgs) Handles btCancelarL.Click
        PanelDatosLibros.Visible = False
        btEditarLibro.Enabled = True
        btEliminarLibro.Enabled = True
        txtTituloL.Text = ""
        txtEdicion.Text = ""
        txtISBN.Text = ""
        txtDescrip.Text = ""
        txtDL.Text = ""
        paginasCant.Value = 1
        ejemplaresCont.Value = 1
        cbAutorLibro.Items.Clear()
        cbEditarialLibro.Items.Clear()
        cbCiudadL.Items.Clear()
        CBCatG.Items.Clear()
        CBCatE.Items.Clear()
        CBTipoDoc.Items.Clear()
        edicion = False
    End Sub

    Private Sub btEliminarLibro_Click(sender As Object, e As EventArgs) Handles btEliminarLibro.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM libro WHERE idlibro = " & indexSelected)
        End If
    End Sub

    Private Sub btEditarLibro_Click(sender As Object, e As EventArgs) Handles btEditarLibro.Click
        PanelDatosLibros.Visible = True
        btEditarLibro.Enabled = False
        btEliminarLibro.Enabled = False
        PopulateCombobox(cbCiudadL, "Ubicacion", "Ciudad")
        PopulateCombobox(CBCatG, "categoriageneral", "nombre")
        PopulateCombobox(CBCatE, "categoriaespecial", "nombre")
        PopulateCombobox(CBTipoDoc, "tipodocumento", "nombre")
        PopulateCombobox(cbEditarialLibro, "editorial", "nombre")
        PopulateCombobox(cbAutorLibro, "autor", "nombre")

        Try
            AbrirConexion()
            Dim query As String
            idActual = indexSelected
            query = tablaLibroQuery & " WHERE l.idlibro = " & idActual
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtTituloL.Text = reader.GetString("Titulo")
            txtEdicion.Text = reader.GetString("Edicion")
            txtISBN.Text = reader.GetString("ISBN")
            txtDescrip.Text = reader.GetString("Descripcion")
            txtDL.Text = reader.GetString("DepositoLegal")
            Dim varUbi = reader.GetString("Ciudad")
            Dim varCE = reader.GetString("CategoriaEspecial")
            Dim varCG = reader.GetString("CategoriaGeneral")
            Dim varTD = reader.GetString("TipoDocumento")
            Dim varAu = reader.GetString("Autor")
            Dim varEd = reader.GetString("Editorial")
            'Dim eje = reader.GetInt32("Ejemplares")


            cbCiudadL.SelectedItem = varUbi
            CBCatG.SelectedItem = varCG
            CBCatE.SelectedItem = varCE
            CBTipoDoc.SelectedItem = varTD
            cbAutorLibro.SelectedItem = varAu
            cbEditarialLibro.SelectedItem = varEd
            'ejemplaresCont.Value = eje

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '-------------------------------------------------------------------------------------
    ' Autores

    Private Sub btNuevoAutor_Click(sender As Object, e As EventArgs) Handles btNuevoAutor.Click

        PanelDatosAutor.Visible = True
        btEditarAutor.Enabled = False
        btEliminarAutor.Enabled = False
        PopulateCombobox(cbCiudadAutor, "ubicacion", "Ciudad")
    End Sub

    Private Sub btEliminarAutor_Click(sender As Object, e As EventArgs) Handles btEliminarAutor.Click
        If indexSelected > -1 Then
            Dim opc = MessageBox.Show("¿Desea eliminar este registro? - Se eliminarán los registros con este autor", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If opc = DialogResult.Yes Then
                SaveData("DELETE FROM autor WHERE idautor = " & indexSelected)
            End If
        End If
    End Sub

    Private Sub txtBuscarAutor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarAutor.TextChanged
        Dim query = queryAutorTabla & " Where a.nombre like '" & txtBuscarAutor.Text & "%'"
        LlenarTabla(tablaAutores, query, "autor")
    End Sub

    Private Sub btEditarAutor_Click(sender As Object, e As EventArgs) Handles btEditarAutor.Click

        If indexSelected > -1 Then
            PanelDatosAutor.Visible = True
            btEditarAutor.Enabled = False
            btEliminarAutor.Enabled = False
            idActual = indexSelected
            edicion = True
            Try
                AbrirConexion()
                Dim query As String
                idActual = indexSelected
                query = queryAutorTabla & " WHERE a.idautor = " & indexSelected
                command = New MySqlCommand(query, conexion)
                reader = command.ExecuteReader
                reader.Read()

                txtNombreAutor.Text = reader.GetString("nombre")
                txtApellidoAutor.Text = reader.GetString("apellido")

                If reader.GetString("Sexo") = "Femenino" Then
                    rbFemAutor.Select()
                Else
                    rbMasAutor.Select()
                End If

                Dim var = reader.GetString("ciudad")
                PopulateCombobox(cbCiudadAutor, "ubicacion", "Ciudad")
                cbCiudadAutor.SelectedItem = var

                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub tablaAutores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutores.CellClick
        Try
            Dim value As Object = tablaAutores.CurrentRow.Cells(0).Value

            indexSelected = CType(value, Integer)
        Catch ex As Exception
            indexSelected = -1
        End Try
    End Sub

    Private Sub btCancelarAutor_Click(sender As Object, e As EventArgs) Handles btCancelarAutor.Click
        PanelDatosAutor.Visible = False
        btEditarAutor.Enabled = True
        btEliminarAutor.Enabled = True
        txtNombreAutor.Text = False
        txtApellidoAutor.Text = False
        cbCiudadAutor.Items.Clear()
        edicion = False
    End Sub

    Private Sub btActualizarAutor_Click(sender As Object, e As EventArgs) Handles btActualizarAutor.Click
        LlenarTabla(tablaAutores, queryAutorTabla, "autor")
    End Sub

    Private Sub btGuardarAutor_Click(sender As Object, e As EventArgs) Handles btGuardarAutor.Click
        Dim sex As String
        Dim ubicacion As String
        Dim subQuery As String

        Dim query As String

        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            If edicion = True Then
                If rbFemAutor.Checked = True Then
                    sex = "Femenino"

                Else
                    sex = "Masculino"
                End If

                subQuery = "(SELECT idubicacion FROM ubicacion WHERE ciudad = '" & cbCiudadAutor.SelectedItem & "')"
                query = "Update autor Set nombre = '" & txtNombreAutor.Text & "', apellido = '" & txtApellidoAutor.Text & "', 
                sexo = '" & sex & "', idubicacion = " & subQuery & " Where idautor = " & idActual
                SaveData(query)

            Else
                If rbFemAutor.Checked = True Then
                    sex = "Femenino"

                Else
                    sex = "Masculino"
                End If
                subQuery = "(SELECT idubicacion FROM ubicacion WHERE ciudad = '" & cbCiudadAutor.SelectedItem & "')"
                query = "INSERT INTO autor (nombre, apellido,sexo, idubicacion) values('" & txtNombreAutor.Text & "','" & txtApellidoAutor.Text & "','" & sex & "' ," & subQuery & ")"
                SaveData(query)
            End If

        End If
    End Sub

    '----------------------------------------------------------------------------------------
    '   Bibliotecarios

    Private Sub btCrearBiblio_Click(sender As Object, e As EventArgs) Handles btCrearBiblio.Click
        PanelDatosBiblio.Visible = True
        btEditarBiblio.Enabled = False
        btEliminarBiblio.Enabled = False
    End Sub

    Private Sub btCancelarBiblio_Click(sender As Object, e As EventArgs) Handles btCancelarBiblio.Click
        PanelDatosBiblio.Visible = False
        btEditarBiblio.Enabled = True
        btEliminarBiblio.Enabled = True
        edicion = False
    End Sub


    Private Sub btEliminarBiblio_Click(sender As Object, e As EventArgs) Handles btEliminarBiblio.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM bibliotecario WHERE idbibliotecario = " & indexSelected)
        End If
    End Sub

    Private Sub btActulBiblio_Click(sender As Object, e As EventArgs) Handles btActulBiblio.Click
        LlenarTabla(tablaBibliotecario, queryBiblioTabla, "bibliotecario")
    End Sub


    Private Sub btEditarBiblio_Click(sender As Object, e As EventArgs) Handles btEditarBiblio.Click
        PanelDatosBiblio.Visible = True
        btEditarBiblio.Enabled = False
        btEliminarBiblio.Enabled = False
        idActual = indexSelected
        edicion = True

        Try
            AbrirConexion()
            Dim query As String
            idActual = indexSelected
            query = queryBiblioTabla & " WHERE idbibliotecario = " & indexSelected
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtNombreBiblio.Text = reader.GetString("nombre")
            txtApellidoBiblio.Text = reader.GetString("apellido")
            txtUsuario.Text = reader.GetString("usuario")
            txtClave.Text = reader.GetString("contraseña")

            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tablaBibliotecario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaBibliotecario.CellClick
        Dim value As Object = tablaBibliotecario.CurrentRow.Cells(0).Value

        Try
            indexSelected = CType(value, Integer)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btGuardarBiblio_Click(sender As Object, e As EventArgs) Handles btGuardarBiblio.Click
        Dim query As String
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            If edicion = True Then
                query = "UPDATE bibliotecario SET nombre = '" & txtNombreBiblio.Text & "', apellido = '" & txtApellidoBiblio.Text & "',
                usuario = '" & txtUsuario.Text & "', contraseña = '" & txtClave.Text & "' WHERE idbibliotecario = " & idActual
                SaveData(query)

            Else
                query = "INSERT INTO bibliotecario (nombre, apellido, usuario, contraseña) values ('" & txtNombreBiblio.Text & "',
                '" & txtApellidoBiblio.Text & "','" & txtUsuario.Text & "','" & txtClave.Text & "')"
                SaveData(query)
            End If
        End If
    End Sub


    Private Sub TextBuscarBiblio_TextChanged(sender As Object, e As EventArgs) Handles TextBuscarBiblio.TextChanged
        Dim query As String
        query = queryBiblioTabla & " Where nombre like '" & TextBuscarBiblio.Text & "%'"
        LlenarTabla(tablaBibliotecario, query, "bibliotecario")
    End Sub


    '-------------------------------------------------------------------------------------
    '  Tipo documentos

    Private Sub btNuevoTD_Click(sender As Object, e As EventArgs) Handles btNuevoTD.Click
        PanelTD.Visible = True
        btEliminarTD.Enabled = False
        btEditarTD.Enabled = False

    End Sub


    Private Sub btEditarTD_Click(sender As Object, e As EventArgs) Handles btEditarTD.Click
        PanelTD.Visible = True
        btEliminarTD.Enabled = False
        btEditarTD.Enabled = False
        edicion = True

        If listaTipoDoc.SelectedItem <> Nothing Then
            Try
                AbrirConexion()
                Dim query = "SELECT * FROM tipodocumento WHERE nombre = '" & listaTipoDoc.SelectedItem & "'"
                command = New MySqlCommand(query, conexion)
                reader = command.ExecuteReader
                reader.Read()
                idActual = reader.GetInt32("idtipodocumento")
                txtTipoDoc.Text = listaTipoDoc.SelectedItem
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btActualizarTD_Click(sender As Object, e As EventArgs) Handles btActualizarTD.Click
        listaTipoDoc.Items.Clear()
        llenarLista(listaTipoDoc, "tipodocumento", "nombre")
    End Sub


    Private Sub btEliminarTD_Click(sender As Object, e As EventArgs) Handles btEliminarTD.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM tipodocumento WHERE nombre = '" & listaTipoDoc.SelectedItem & "'")
        End If
    End Sub


    Private Sub guardarTD_Click(sender As Object, e As EventArgs) Handles guardarTD.Click
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verificarRE("SELECT * FROM tipodocumento where nombre = '" & txtTipoDoc.Text & "'", "Tipo documento") <> True Then
            If edicion <> True Then
                Dim query = "INSERT INTO tipodocumento (nombre) values ('" & txtTipoDoc.Text & "')"
                SaveData(query)
            Else
                Dim query = "Update tipodocumento SET nombre = '" & txtTipoDoc.Text & "'"
                SaveData(query)
            End If
        End If
    End Sub


    Private Sub cancelarTD_Click(sender As Object, e As EventArgs) Handles cancelarTD.Click
        PanelTD.Visible = False
        btEliminarTD.Enabled = True
        btEditarTD.Enabled = True
        edicion = False
        txtTipoDoc.Text = ""
    End Sub

    '----------------------------------------------------------------------
    ' Editoriales
    Private Sub nuevoEditorial_Click(sender As Object, e As EventArgs) Handles nuevoEditorial.Click
        PanelDatosEdit.Visible = True
        editarEditorial.Enabled = False
        eliminarEditorial.Enabled = False
        PopulateCombobox(CBCiudadEd, "ubicacion", "ciudad")
    End Sub


    Private Sub cancelarEditorial_Click(sender As Object, e As EventArgs) Handles cancelarEditorial.Click
        PanelDatosEdit.Visible = False
        editarEditorial.Enabled = True
        eliminarEditorial.Enabled = True
        CBCiudadEd.Items.Clear()
        edicion = False
    End Sub


    Private Sub eliminarEditorial_Click(sender As Object, e As EventArgs) Handles eliminarEditorial.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM editorial WHERE nombre = '" & listaEditoriales.SelectedItem & "'")
        End If
    End Sub

    Private Sub actualizarEditorial_Click(sender As Object, e As EventArgs) Handles actualizarEditorial.Click
        listaEditoriales.Items.Clear()
        llenarLista(listaEditoriales, "editorial", "nombre")
    End Sub



    Private Sub editarEditorial_Click(sender As Object, e As EventArgs) Handles editarEditorial.Click
        edicion = True
        PanelDatosEdit.Visible = True
        editarEditorial.Enabled = False
        eliminarEditorial.Enabled = False
        Dim var As String

        Try
            AbrirConexion()
            Dim query = "SELECT * FROM editorial WHERE nombre = '" & listaEditoriales.SelectedItem & "'"
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()
            idActual = reader.GetInt32("ideditorial")

            txtEditorial.Text = listaEditoriales.SelectedItem
            Dim idUb = reader.GetInt32("idubicacion")
            conexion.Close()
            query = "SELECT * From ubicacion WHERE idubicacion = " & idUb & ""
            AbrirConexion()
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()
            var = reader.GetString("Ciudad")
            PopulateCombobox(CBCiudadEd, "ubicacion", "ciudad")
            CBCiudadEd.SelectedItem = var
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub guardarEditorial_Click(sender As Object, e As EventArgs) Handles guardarEditorial.Click
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If verificarRE("SELECT * FROM editorial where nombre = '" & txtEditorial.Text & "'", "editorial") <> True Then
            If edicion <> True Then

                Dim subQ = "(SELECT idubicacion from ubicacion Where ciudad = '" & CBCiudadEd.SelectedItem & "')"
                Dim query = "INSERT INTO editorial (nombre, idubicacion) values ('" & txtEditorial.Text & "'," & subQ & ")"
                SaveData(query)
            Else
                Dim subQ = "(SELECT idubicacion from ubicacion Where ciudad = '" & CBCiudadEd.SelectedItem & "')"
                Dim query = "Update editorial SET nombre = '" & txtEditorial.Text & "', idubicacion = " & subQ & "
                WHERE ideditorial = " & idActual
                SaveData(query)
            End If

        End If
    End Sub

    '----------------------------------------------------------------------------
    ' Ubicaciones

    Private Sub btCrearUbi_Click(sender As Object, e As EventArgs) Handles btCrearUbi.Click
        PanelDatosUbi.Visible = True
        btEditarUbi.Enabled = False
        btEliminarUbi.Enabled = False
    End Sub

    Private Sub btCancelarUbi_Click(sender As Object, e As EventArgs) Handles btCancelarUbi.Click
        PanelDatosUbi.Visible = False
        btEditarUbi.Enabled = True
        btEliminarUbi.Enabled = True
        edicion = False
        txtNacionalidad.Text = ""
        txtPais.Text = ""
        txtCiudad.Text = ""
    End Sub


    Private Sub btEditarUbi_Click(sender As Object, e As EventArgs) Handles btEditarUbi.Click
        PanelDatosUbi.Visible = True
        btEditarUbi.Enabled = False
        btEliminarUbi.Enabled = False
        edicion = True
        idActual = indexSelected

        Try
            AbrirConexion()
            Dim query = "SELECT * FROM ubicacion WHERE idubicacion = " & idActual
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtCiudad.Text = reader.GetString("Ciudad")
            txtPais.Text = reader.GetString("pais")
            txtNacionalidad.Text = reader.GetString("nacionalidad")
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub tablaUbicaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaUbicaciones.CellClick


        Try
            Dim value As Object = tablaUbicaciones.CurrentRow.Cells(0).Value
            indexSelected = CType(value, Integer)
        Catch ex As Exception
            indexSelected = -1
        End Try
    End Sub

    Private Sub btActualizarUbi_Click(sender As Object, e As EventArgs) Handles btActualizarUbi.Click
        LlenarTabla(tablaUbicaciones, queryUbicacionesTabla, "ubicacion")
    End Sub

    Private Sub btEliminarUbi_Click(sender As Object, e As EventArgs) Handles btEliminarUbi.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM ubicacion WHERE idubicacion = " & indexSelected)
        End If
    End Sub


    Private Sub btGuardarUbi_Click(sender As Object, e As EventArgs) Handles btGuardarUbi.Click
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            If edicion = True Then
                Dim query = "UPDATE ubicacion SET ciudad = '" & txtCiudad.Text & "', pais = '" & txtPais.Text & "', nacionalidad = 
                '" & txtNacionalidad.Text & "' WHERE idubicacion = " & idActual
                SaveData(query)

            Else
                Dim query = "INSERT INTO ubicacion (ciudad, pais , nacionalidad) values ('" & txtCiudad.Text & "','" & txtPais.Text & "',
                '" & txtNacionalidad.Text & "')"
                SaveData(query)
            End If
        End If
    End Sub


    '----------------------------------------------------------------------------
    ' Categoría General
    Private Sub txtCodigoG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoG.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btCrearCG_Click(sender As Object, e As EventArgs) Handles btCrearCG.Click
        PanelDatosCG.Visible = True
        btEditarCG.Enabled = False
        btEliminarCG.Enabled = False
    End Sub


    Private Sub btCancelarCG_Click(sender As Object, e As EventArgs) Handles btCancelarCG.Click
        PanelDatosCG.Visible = False
        btEditarCG.Enabled = True
        btEliminarCG.Enabled = True
        edicion = False
        txtCodigoG.Text = ""
        txtNombreCG.Text = ""
    End Sub


    Private Sub btEliminarCG_Click(sender As Object, e As EventArgs) Handles btEliminarCG.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM categoria WHERE codigogeneral = " & idActual)
        End If
    End Sub

    Private Sub btActualizarCG_Click(sender As Object, e As EventArgs) Handles btActualizarCG.Click
        LlenarTabla(tablaCG, queryTablaCG, "categoriageneral")
    End Sub


    Private Sub btEditarCG_Click(sender As Object, e As EventArgs) Handles btEditarCG.Click
        PanelDatosCG.Visible = True
        btEditarCG.Enabled = False
        btEliminarCG.Enabled = False
        edicion = True
        idActual = indexSelected
        Try
            AbrirConexion()
            Dim query = "SELECT * FROM categoriageneral WHERE codigogeneral = " & idActual
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtNombreCG.Text = reader.GetString("nombre")
            txtCodigoG.Text = reader.GetInt32("codigogeneral")

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tablaCG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaCG.CellClick


        Try
            Dim value As Object = tablaCG.CurrentRow.Cells(0).Value
            indexSelected = CType(value, Integer)

        Catch ex As Exception
            indexSelected = -1
        End Try
    End Sub

    Private Sub btGuardarCG_Click(sender As Object, e As EventArgs) Handles btGuardarCG.Click
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim query As String
        If opc = DialogResult.Yes Then
            If edicion = True Then
                query = "UPDATE categoriageneral SET codigogeneral = " & txtCodigoG.Text & ", nombre = '" & txtNombreCG.Text & "' WHERE
                codigogeneral = " & idActual
                SaveData(query)

            Else
                query = "INSERT INTO categoriageneral (codigogeneral, nombre) VALUES (" & txtCodigoG.Text & ", '" & txtNombreCG.Text & "')"
                SaveData(query)
            End If
        End If
    End Sub


    '-------------------------------------------------------------------------------------------
    ' Categoria Especial

    Private Sub btCrearCE_Click(sender As Object, e As EventArgs) Handles btCrearCE.Click
        PanelDatosCE.Visible = True
        btEditarCE.Enabled = False
        btEliminarCE.Enabled = False
        btCrearCE.Enabled = False
        PopulateCombobox(cbCatEs, "categoriageneral", "nombre")
    End Sub


    Private Sub tablaCE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaCE.CellClick


        Try
            Dim value As Object = tablaCE.CurrentRow.Cells(0).Value
            indexSelected = CType(value, Integer)
        Catch ex As Exception
            indexSelected = -1
        End Try
    End Sub


    Private Sub btActualizarCE_Click(sender As Object, e As EventArgs) Handles btActualizarCE.Click
        LlenarTabla(tablaCE, queryTablaCE, "categoriaespecial")
    End Sub

    Private Sub btCancelarCE_Click(sender As Object, e As EventArgs) Handles btCancelarCE.Click
        PanelDatosCE.Visible = False
        btEditarCE.Enabled = True
        btEliminarCE.Enabled = True
        btCrearCE.Enabled = True
        edicion = False
        txtNombreCE.Text = ""
        txtCodigoCE.Text = ""
        cbCatEs.Items.Clear()
    End Sub


    Private Sub btEliminarCE_Click(sender As Object, e As EventArgs) Handles btEliminarCE.Click
        Dim opc = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opc = DialogResult.Yes Then
            SaveData("DELETE FROM categoriaespecial WHERE codigoespecial = " & idActual)
        End If
    End Sub



    Private Sub btEditarCE_Click(sender As Object, e As EventArgs) Handles btEditarCE.Click
        PanelDatosCE.Visible = True
        btEditarCE.Enabled = False
        btEliminarCE.Enabled = False
        edicion = True
        idActual = indexSelected
        Try
            AbrirConexion()
            Dim query = queryTablaCE & " Where codigoespecial = " & idActual
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            reader.Read()

            txtNombreCE.Text = reader.GetString("Nombre")
            txtCodigoCE.Text = reader.GetInt32("CodigoEspecial")
            Dim var = reader.GetString("CategoriaGeneral")

            PopulateCombobox(cbCatEs, "categoriageneral", "nombre")
            cbCatEs.SelectedItem = var
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btGuardarCE_Click(sender As Object, e As EventArgs) Handles btGuardarCE.Click
        Dim opc = MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim query As String
        Dim SubQuery As String
        If opc = DialogResult.Yes Then
            If edicion = True Then
                SubQuery = "(SELECT codigogeneral FROM categoriageneral WHERE nombre  = '" & cbCatEs.SelectedItem & "')"
                query = "UPDATE categoriaespecial SET codigoespecial = " & txtCodigoCE.Text & ", nombre = '" & txtNombreCE.Text & "', codigogeneral =
                " & SubQuery & " WHERE codigoespecial = " & idActual
                SaveData(query)

            Else
                SubQuery = "(SELECT codigogeneral FROM categoriageneral WHERE nombre  = '" & cbCatEs.SelectedItem & "')"
                query = "INSERT INTO categoriaespecial (codigoespecial, nombre, codigogeneral) VALUES (" & txtCodigoCE.Text & ", '" & txtNombreCE.Text & "', " & SubQuery & ")"
                SaveData(query)
            End If
        End If
    End Sub


End Class