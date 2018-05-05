Imports MySql.Data.MySqlClient
Public Class ConexionBD

    Public Shared conexion As MySqlConnection
    Public Shared cmd As MySqlCommandBuilder
    Public Shared adaptador As MySqlDataAdapter
    Public Shared reader As MySqlDataReader
    Public Shared command As MySqlCommand
    Public Shared consulta As String
    Public Shared datos As DataSet

    Public Shared Sub AbrirConexion()

        Try

            conexion = New MySqlConnection
            'conexion.ConnectionString = "server = localhost; user id = root; Password = leo12345 database = biblioteca"
            conexion.ConnectionString = "server = localhost; user id = root; Password = 12345678; database = hondbprueba3"
            'conexion.ConnectionString = "server = localhost; user id = root; Password = Hydr0g3n2Oxyg3n1; database = hondb"
            conexion.Open()

        Catch ex As Exception
            EMsg.Show("Se ha encontrado un error al establecer la conexión con la Base de Datos. Por favor contacte al administrador para resolver este error", ex)
        End Try

    End Sub

End Class