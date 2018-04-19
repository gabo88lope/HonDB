Imports MySql.Data.MySqlClient

Public Class ConexionBD

    Public Shared conexion As MySqlConnection
    Public Shared comando As MySqlCommand
    Public Shared adaptador As MySqlDataAdapter
    Public Shared reader As MySqlDataReader
    Public Shared command As MySqlCommand
    Public Shared consulta As String
    Public Shared datos As DataSet

    Public Shared Sub AbrirConexion()

        Try
            conexion = New MySqlConnection("server = localhost; user id = root; Password = 123; database = hondb")
        Catch ex As Exception
            Err.Description.ToString()
        End Try

    End Sub

End Class