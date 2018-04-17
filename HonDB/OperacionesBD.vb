Imports MySql.Data.MySqlClient
Imports HonDB.ConexionBD

Module OperacionesBD

    Public Function ConexionInternet() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com.ni")
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub PopulateCombobox(ByRef cb As ComboBox, ByVal table As String, ByVal column As String)

        Try
            AbrirConexion()
            consulta = "SELECT * FROM " & table
            command = New MySqlCommand(consulta, conexion)
            reader = command.ExecuteReader

            While reader.Read
                Dim aNombre = reader.GetString(column)
                cb.Items.Add(aNombre)
            End While

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
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
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
