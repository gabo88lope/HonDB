Imports MySql.Data.MySqlClient
Imports HonDB.ConexionBD

Module OperacionesBD

    Public Function ConexionInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com.ni")
        Catch ex As Exception
            Return Nothing
            EMsg.Show("No hay conexión a internet", ex)
        End Try

    End Function

    Public Sub PopulateCombobox(ByRef cb As ComboBox, ByVal table As String, ByVal column As String)

        'prueba para cambiar de rama
        Try
            AbrirConexion()
            consulta = "SELECT * FROM " & table & " Order by " & column & " asc"
            command = New MySqlCommand(consulta, conexion)
            reader = command.ExecuteReader
            While reader.Read
                Dim aNombre = reader.GetString(column)
                cb.Items.Add(aNombre)
            End While
        Catch ex As Exception
            EMsg.Show("No se ha podido llenar el control. Contacte a su administrador", ex)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub LlenarTabla(ByRef dgv As DataGridView, ByVal query As String, ByVal tableName As String)

        Try
            AbrirConexion()
            adaptador = New MySqlDataAdapter(query, conexion)
            datos = New DataSet
            adaptador.Fill(datos, tableName)
            dgv.DataSource = datos
            dgv.DataMember = tableName
        Catch ex As Exception
            EMsg.Show("No se ha podido llenar la tabla. Contacte a su administrador", ex)
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Sub SaveData(ByVal query As String)

        Try
            AbrirConexion()
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            MessageBox.Show("Datos guardados correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            EMsg.Show("Ha ocurrido un error al guardar", ex)
        Finally
            command = Nothing
            conexion.Close()
        End Try
    End Sub

    Public Function VerificarRE(ByVal query As String, ByVal parametro As String) As Boolean
        AbrirConexion()
        comando = New MySqlCommand(query, conexion)
        reader = comando.ExecuteReader
        Dim cont As Integer

        While reader.Read
            cont = cont + 1
        End While

        If cont <> 0 Then
            MsgBox("Ya existe un campo " & parametro & " con este valor")
            Return True

        Else
            Return False
        End If
    End Function

    Public Sub llenarLista(ByRef lista As ListBox, ByVal tabla As String, ByVal columna As String)
        Try
            AbrirConexion()
            consulta = "SELECT * FROM " & tabla & " Order by " & columna & " asc"
            command = New MySqlCommand(consulta, conexion)
            reader = command.ExecuteReader

            While reader.Read
                Dim aNombre = reader.GetString(columna)
                lista.Items.Add(aNombre)
            End While

            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub GetData(ByVal query As String, ByRef result As Object)

        AbrirConexion()
        command = New MySqlCommand(query, conexion)
        result = command.ExecuteScalar()

    End Sub

End Module
