Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Busqueda
    Dim constr As String = "Server=localhost;user id=root;Password=12345678;database = hondb"
    Dim con As New MySqlConnection(constr)

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            ComboBox1.Visible = True
        Else
            ComboBox1.Visible = False
        End If

        If CheckBox1.Checked = True Then
            ComboBox2.Visible = True
        Else
            ComboBox2.Visible = False
        End If

        If CheckBox1.Checked = True Then
            ComboBox3.Visible = True
        Else
            ComboBox3.Visible = False
        End If

        If CheckBox1.Checked = True Then
            ComboBox4.Visible = True
        Else
            ComboBox4.Visible = False
        End If

        If CheckBox1.Checked = True Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If

        If CheckBox1.Checked = True Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If

        If CheckBox1.Checked = True Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If

        If CheckBox1.Checked = True Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If


        If CheckBox1.Checked = True Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True

        Else
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BotonBuscarLibro_Click(sender As Object, e As EventArgs) Handles BotonBuscarLibro.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LlenarTabla(DataGridView1, "SELECT * FROM usuario where sexo = '" & ComboBox1.SelectedItem & "'", "usuario")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox(ComboBox1, "autor", "nombre")
        PopulateCombobox(ComboBox2, "libro", "fechapublicaion")
        PopulateCombobox(ComboBox3, "libro", "titulo")
        PopulateCombobox(ComboBox4, "tipodocumento", "nombre")

        LlenarTabla(DataGridView1, "SELECT * FROM usuario", "usuario")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LlenarTabla(DataGridView1, "SELECT * FROM usuario where nombre like'" & TextBox1.Text & "%'", "usuario")
    End Sub

    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class