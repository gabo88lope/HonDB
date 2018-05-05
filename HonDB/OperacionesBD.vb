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
            consulta = "SELECT * FROM " & table
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
            MsgBox("Datos guardados exitosamente!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            EMsg.Show("Ha ocurrido un error al guardar", ex)
        Finally
            command = Nothing
            conexion.Close()
        End Try
    End Sub

    Public Sub GetData(ByVal query As String, ByRef result As Object)

        AbrirConexion()
        command = New MySqlCommand(query, conexion)
        result = command.ExecuteScalar()

    End Sub

End Module
