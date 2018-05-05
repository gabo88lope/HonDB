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
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If


        If CheckBox1.Checked = True Then
            ComboBox1.Enabled = True

        Else
            ComboBox1.Enabled = False

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

        If TextBox1.Text = "Nombre del Autor" Then

            'LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,(SELECT concat_ws(' ',a.nombre,concat(' ', a.apellido)) FROM 
            'autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
            'WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
            'Year(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
            'l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
            'From libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
            'g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
            'Join detallelibro d ON l.idlibro = d.idlibro GROUP BY a.idautor HAVING a.nombre like '" & TextBox1.Text & "%';", "autor")

            LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,a.nombre As Nombre, a.apellido As Apellido FROM 
            autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
            WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
            YEAR(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
            l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
            FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
            g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
            JOIN detallelibro d ON l.idlibro = d.idlibro GROUP BY g.nombre HAVING g.categoriageneral like '" & TextBox1.Text & "%';", "categoriageneral")

        ElseIf TextBox1.Text = "Categoria " Then
            LlenarTabla(DataGridView1, "SELECT l.idlibro as Código, l.isbn as ISBN,(SELECT concat_ws(' ',a.nombre,concat(' ', a.apellido)) FROM 
            autor a INNER JOIN detallelibro d ON a.idautor = d.idautor
            WHERE d.idlibro = l.idlibro) as Autor, l.depositolegal as DepositoLegal, l.titulo as Titulo,
            YEAR(l.fechapublicacion) as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
            l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
            FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion  INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
            g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial INNER
            JOIN detallelibro d ON l.idlibro = d.idlibro GROUP BY g.nombre HAVING g.categoriageneral like '" & TextBox1.Text & "%';", "categoriageneral")
        End If

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