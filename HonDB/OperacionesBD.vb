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
            consulta = "SELECT * FROM " & table & " Order by " & column & " asc"
            command = New MySqlCommand(consulta, conexion)
            reader = command.ExecuteReader

            While reader.Read
                Dim aNombre = reader.GetString(column)
                cb.Items.Add(aNombre)
            End While

            'conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("Ha ocurrido un problema")

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
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub SaveData(ByVal query As String)

        Try
            AbrirConexion()
            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader
            MessageBox.Show("Datos guardados correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al guardar, verique el ingreso correcto de campos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function verificarRE(ByVal query As String, ByVal parametro As String) As Boolean
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

End Module
