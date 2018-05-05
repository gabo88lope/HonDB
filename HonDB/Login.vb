Imports MySql.Data.MySqlClient

Public Class Login

    Dim conexion As MySqlConnection

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label2.Parent = PictureBox1
        'if not conexioninternet() then
        '    msgbox("no se ha establecido la conexión a internet", msgboxstyle.critical)
        '    me.close()
        'end if

    End Sub

    Private Sub UsernameText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameText.KeyPress

        If e.KeyChar = ChrW(Keys.Tab) Then
            PassText.Text = ""
            PassText.Select()
        End If

    End Sub

    Private Sub BotonIngresar_Click(sender As Object, e As EventArgs) Handles BotonIngresar.Click

        Dim query As String
        query = "SELECT * From Bibliotecario where usuario = '" & UsernameText.Text & "' and contraseña = '" & PassText.Text & "'"
        If VerificarLogin(query) Then

            Try
                HonDBPrin.Show()
                HonDBPrin.Focus()
                Me.Close()
            Catch ex As Exception
                MsgBox("Conexíon fallida")
            End Try

        Else
            MessageBox.Show("Verifique el usuario o clave", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub PassText_Click(sender As Object, e As EventArgs) Handles PassText.Click

        If PassText.Text.Equals("Contraseña") Then
            PassText.ResetText()
        End If

        If UsernameText.Text Is Nothing Or UsernameText.Text.Equals("") Then
            UsernameText.Text = "Username"
        End If

    End Sub

    Private Sub UsernameText_Click(sender As Object, e As EventArgs) Handles UsernameText.Click

        If UsernameText.Text.Equals("Username") Then
            UsernameText.ResetText()
        End If

        If PassText.Text Is Nothing Or PassText.Text.Equals("") Then
            PassText.Text = "Contraseña"
        End If

    End Sub

    Private Sub Validar_Contraseña()

        Dim encriptado As Byte() = Nothing
        Encriptacion.Encriptacion(PassText.Text, encriptado, True)

    End Sub

    Private Sub PassText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PassText.KeyPress

        If e.KeyChar = ChrW(Keys.Tab) Then
            BotonIngresar.Select()
        End If

    End Sub

    Private Sub Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            BotonIngresar.PerformClick()
        End If

    End Sub

End Class
