Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Busqueda
    Dim codigo As Integer

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelarBusqueda.Click
        Me.Close()

    End Sub

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

    Private Sub BotonBuscarLibro_Click(sender As Object, e As EventArgs) Handles BotonLimpiarBusquedaLibro.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,(SELECT concat_ws(' ',a.nombre,concat(' ', a.apellido)) FROM 
        autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
        WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
        YEAR(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
        l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
        FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
        g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
        JOIN detallelibro d ON l.idlibro = d.idlibro;", "libro")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox(ComboBox1, "autor", "nombre")
        PopulateCombobox(ComboBox2, "categoriageneral", "nombre")
        PopulateCombobox(ComboBox3, "libro", "titulo")
        PopulateCombobox(ComboBox4, "tipodocumento", "nombre")

        LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,(SELECT concat_ws(' ',a.nombre,concat(' ', a.apellido)) FROM 
        autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
        WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
        YEAR(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
        l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
        FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
        g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
        JOIN detallelibro d ON l.idlibro = d.idlibro;", "libro")
    End Sub

    'Consulta'

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,(SELECT concat_ws(' ',a.nombre,concat(' ', a.apellido)) FROM 
        autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
        WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
        YEAR(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
        l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
        FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
        g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
        JOIN detallelibro d ON l.idlibro = d.idlibro GROUP BY l.idlibro HAVING l.titulo LIKE '" & TextBox1.Text & "%';", "libro")

    End Sub

    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim S As Integer
        S = DataGridView1.CurrentRow.Index
        TBI.Text = DataGridView1.Item(4, S).Value()
    End Sub

    Private Sub BotonAgregarBusqueda_Click(sender As Object, e As EventArgs) Handles BotonAgregarBusqueda.Click

        Ventana_Registro.LBPrestamos.Text = TBI.Text

    End Sub
End Class