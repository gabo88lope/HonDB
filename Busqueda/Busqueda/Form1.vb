Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class Ventana_Busqueda

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
        llenarTabla(DataGridView1, "SELECT * FROM usuario where sexo = '" & ComboBox1.SelectedItem & "'", "usuario")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCombobox(ComboBox1, "autor", "nombre")
        populateCombobox(ComboBox2, "libro", "fechapublicaion")
        populateCombobox(ComboBox3, "libro", "titulo")
        populateCombobox(ComboBox4, "tipodocumento", "nombre")

        llenarTabla(DataGridView1, "SELECT * FROM usuario", "usuario")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        llenarTabla(DataGridView1, "SELECT * FROM usuario where nombre like'" & TextBox1.Text & "%'", "usuario")
    End Sub
End Class
