Imports MySql.Data.MySqlClient
Public Class ConexionBD

    Public Shared conexion As MySqlConnection
    Public Shared cmd As MySqlCommandBuilder
    Public Shared comando As MySqlCommand
    Public Shared adaptador As MySqlDataAdapter
    Public Shared reader As MySqlDataReader
    Public Shared command As MySqlCommand
    Public Shared consulta As String
    Public Shared datos As DataSet

    Public Shared Sub AbrirConexion()

        Try
            conexion = New MySqlConnection("server = localhost; user id = root; Password = 12345678; database = hondb")
            conexion.Open()
        Catch ex As Exception
            EMsg.Show("Se ha encontrado un error al establecer la conexión con la Base de Datos. Por favor contacte al administrador para resolver este error", ex)
        End Try

    End Sub

End Class