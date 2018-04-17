Imports MySql.Data.MySqlClient

Module Conexion

    Public Function conexionInternet() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com.ni")
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub populateCombobox(ByRef cb As ComboBox, ByVal table As String, ByVal column As String)
        Dim conexion As MySqlConnection
        Dim READER As MySqlDataReader
        Dim command As MySqlCommand
        Dim consulta As String

        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = "server = localhost; user id = root; Password = Hydr0g3n2Oxyg3n1; database = hondb"
            conexion.Open()
            consulta = "SELECT * FROM " & table
            command = New MySqlCommand(consulta, conexion)
            READER = command.ExecuteReader

            While READER.Read
                Dim aNombre = READER.GetString(column)
                cb.Items.Add(aNombre)
            End While

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenarTabla(ByRef dgv As DataGridView, ByVal query As String, ByVal tableName As String)
        Dim conexion As MySqlConnection
        Dim datos As DataSet
        Dim adaptador As MySqlDataAdapter

        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = "server = localhost; user id = root; Password = Hydr0g3n2Oxyg3n1; database = hondb"
            conexion.Open()
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
