Imports MySql.Data.MySqlClient
Imports HonDB.ConexionBD
Imports System.Security.Cryptography
Imports System.IO

Public Class Login

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label2.Parent = PictureBox1
        'If Not ConexionInternet() Then
        '    MsgBox("No se ha establecido la conexión a internet", MsgBoxStyle.Critical)
        '    Me.Close()
        'End If

        llenarLista(LBUser, "bibliotecario", "usuario")
        'llenarLista(LBPass, "bibliotecario", "password")

        LBPass.Items.Add(Encriptar(LBUser.Items.Item(0)))
        LBPass.Items.Add(Encriptar(LBUser.Items.Item(1)))
        LBPass.Items.Add(Encriptar(LBUser.Items.Item(2)))
        LBPass.Items.Add(Encriptar(LBUser.Items.Item(3)))
        LBPass.Items.Add(Encriptar(LBUser.Items.Item(4)))

        For Each s As String In LBPass.Items
            SaveData("Insert into bibliotecario ")
        Next

    End Sub

    Private Sub UsernameText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameText.KeyPress

        If e.KeyChar = ChrW(Keys.Tab) Then
            PassText.Text = ""
            PassText.Select()
        End If

    End Sub

    Private Sub BotonIngresar_Click(sender As Object, e As EventArgs) Handles BotonIngresar.Click

        Try

            HonDBPrin.Show()
            HonDBPrin.Focus()



            ' Me.Close()

        Catch ex As Exception
            EMsg.Show("Conexión fallida con la Base de Datos", ex)
        End Try

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
