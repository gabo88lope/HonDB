Imports HonDB.ExportarExcel

Public Class FReportes
    Private Sub RetornoIcon_Click(sender As Object, e As EventArgs) Handles RetornoIcon.Click
        Me.Close()
    End Sub

    Private Sub CBTipoReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReportes.SelectedIndexChanged
        Select Case CBTipoReportes.SelectedIndex
            Case 0
                DGVReporte.DataSource = Nothing
                DGVReporte.Rows.Clear()
            Case 1
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                LlenarTabla(DGVReporte, "SELECT 
                                            p.idprestamo AS 'Codigo de prestamo',
                                            u.idusuario AS 'Codigo de usuario',
                                            u.nombre AS Nombre,
                                            u.apellido AS Apellido,
                                            u.identificacion AS Identificacion,
                                            ubicacion.pais AS País,
                                            ubicacion.ciudad AS Ciudad,
                                            ubicacion.nacionalidad AS Nacionalidad,
                                            p.fechaprestamo AS 'Fecha de prestamo',
                                            p.fechadevolucion AS 'Fecha de devolucion',
                                            p.cantidad AS Cantidad,
                                            p.estado AS Estado,
                                            b.nombre AS 'Nombre bibliotecario',
                                            b.apellido AS 'Apellido bibliotecario',
                                            GROUP_CONCAT(DISTINCT l.titulo
                                                SEPARATOR ', ') AS 'Libros prestados'
                                        FROM
                                            Prestamo p
                                                INNER JOIN
                                            detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
                                                INNER JOIN
                                            libro l ON (dp.idlibro = l.idlibro)
                                                INNER JOIN
                                            usuario u ON (p.idusuario = u.idusuario)
                                                INNER JOIN
                                            ubicacion ON u.idubicacion = ubicacion.idubicacion
                                                INNER JOIN
                                            bibliotecario b ON p.idbibliotecario = b.idbibliotecario
                                        GROUP BY p.idprestamo;", "prestamo")
            Case 2
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                LlenarTabla(DGVReporte, "SELECT 
                                            idprestamo AS 'Numero de Prestamo',
                                            usuario.nombre AS Nombre,
                                            usuario.apellido AS Apellido,
                                            bibliotecario.nombre AS 'Nombre Bibliotecario',
                                            cantidad AS Cantidad,
                                            fechaprestamo AS 'Fecha de Prestamo',
                                            fechadevolucion AS 'Fecha de Devolucion',
                                            estado AS 'Estado de prestamo'
                                        FROM
                                            usuario
                                                INNER JOIN
                                            prestamo ON prestamo.idusuario = usuario.idusuario
                                                INNER JOIN
                                            bibliotecario ON bibliotecario.idbibliotecario = prestamo.idbibliotecario
                                        WHERE
                                            prestamo.estado = 'Prestamo Vencido'
                                        GROUP BY fechaprestamo
                                        ORDER BY fechaprestamo DESC;", "prestamo")
            Case 3
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                LlenarTabla(DGVReporte, "SELECT 
                                            idprestamo AS 'Numero de Prestamo',
                                            usuario.nombre AS Nombre,
                                            usuario.apellido AS Apellido,
                                            bibliotecario.nombre AS 'Nombre Bibliotecario',
                                            cantidad AS Cantidad,
                                            fechaprestamo AS 'Fecha de Prestamo',
                                            fechadevolucion AS 'Fecha de Devolucion',
                                            estado AS 'Estado de prestamo'
                                        FROM
                                            usuario
                                                INNER JOIN
                                            prestamo ON prestamo.idusuario = usuario.idusuario
                                                INNER JOIN
                                            bibliotecario ON bibliotecario.idbibliotecario = prestamo.idbibliotecario
                                        WHERE
                                            prestamo.estado = 'Prestamo Vigente'
                                        GROUP BY fechaprestamo
                                        ORDER BY fechaprestamo ASC;", "prestamo")
            Case 4
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                LlenarTabla(DGVReporte, "SELECT 
                                            idprestamo AS 'Numero de Prestamo',
                                            usuario.nombre AS Nombre,
                                            usuario.apellido AS Apellido,
                                            bibliotecario.nombre AS 'Nombre Bibliotecario',
                                            cantidad AS Cantidad,
                                            fechaprestamo AS 'Fecha de Prestamo',
                                            fechadevolucion AS 'Fecha de Devolucion',
                                            estado AS 'Estado de prestamo'
                                        FROM
                                            usuario
                                                INNER JOIN
                                            prestamo ON prestamo.idusuario = usuario.idusuario
                                                INNER JOIN
                                            bibliotecario ON bibliotecario.idbibliotecario = prestamo.idbibliotecario
                                        WHERE
                                            prestamo.estado = 'Prestamo Finalizado'
                                        GROUP BY fechaprestamo
                                        ORDER BY fechaprestamo DESC;", "prestamo")
            Case 5
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                LlenarTabla(DGVReporte, "SELECT 
                                            l.idlibro AS 'Codigo de libro',
                                            l.titulo As 'Titulo del libro',
	                                        l.isbn AS ISBN,
                                            l.edicion AS Edicion,
                                            YEAR(l.fechapublicacion) AS 'Fecha de publicacion',
	                                        l.paginas AS Paginas,
                                            GROUP_CONCAT(DISTINCT e.nombre SEPARATOR ', ') AS Editorial,
                                            COUNT(*) As 'Numero de veces prestado'
                                        FROM
                                            libro l
                                                INNER JOIN
                                            detalleprestamo dp ON (l.idlibro = dp.idlibro)
		                                        INNER JOIN
	                                        detallelibro dl ON (l.idlibro = dl.idlibro)
		                                        INNER JOIN
	                                        editorial e ON (dl.ideditorial = e.ideditorial)
                                        GROUP BY dp.idlibro
                                        ORDER BY COUNT(*) DESC
                                            LIMIT    10;", "libro")
            Case 6
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                LlenarTabla(DGVReporte, "SELECT 
                                            p.idprestamo AS 'Codigo de prestamo',
                                            u.idusuario AS 'Codigo de usuario',
                                            u.nombre AS Nombre,
                                            u.apellido AS Apellido,
                                            p.fechaprestamo AS 'Fecha de prestamo',
                                            p.fechadevolucion AS 'Fecha de devolucion',
                                            p.cantidad AS Cantidad,
                                            GROUP_CONCAT(DISTINCT l.titulo
                                                SEPARATOR ', ') AS 'Libros prestados'
                                        FROM
                                            Prestamo p
                                                INNER JOIN
                                            detalleprestamo dp ON (p.idprestamo = dp.idprestamo)
                                                INNER JOIN
                                            libro l ON (dp.idlibro = l.idlibro)
                                                INNER JOIN
                                            usuario u ON (p.idusuario = u.idusuario)
                                                INNER JOIN
                                            bibliotecario b ON p.idbibliotecario = b.idbibliotecario
                                        WHERE
                                            p.fechaprestamo = curdate()
                                        GROUP BY p.idprestamo", "prestamo")
            Case 7
                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                LlenarTabla(DGVReporte, "SELECT 
                                            l.idlibro AS 'Codigo de libro',
                                            l.isbn AS ISBN,
                                            l.depositolegal AS 'Deposito legal',
                                            l.titulo AS 'Titulo del Libro',
                                            l.edicion AS Edicion,
                                            YEAR(l.fechapublicacion) AS 'Fecha de publicacion',
                                            l.paginas AS Paginas,
                                            l.numejemplares AS 'Numero de ejemplares',
                                            CONCAT_WS(', ', u.ciudad, u.pais) AS 'Lugar de publicacion',
                                            GROUP_CONCAT(DISTINCT e.nombre SEPARATOR ', ') AS Editorial,
                                            td.nombre AS 'Tipo de material',
                                            CONCAT(LPAD(codigogeneral, 3, '0'),
                                                    ' - ',
                                                    LPAD(codigoespecial, 3, '0')) AS 'Clasificacion de libro'
                                        FROM
                                            libro l
                                                INNER JOIN
                                            ubicacion u ON (l.idubicacion = u.idubicacion)
                                                INNER JOIN
                                            tipodocumento td ON (l.idtipodocumento = td.idtipodocumento)
		                                        INNER JOIN
	                                        detallelibro dl ON (l.idlibro = dl.idlibro)
		                                        INNER JOIN
	                                        editorial e ON (dl.ideditorial = e.ideditorial)
                                        GROUP BY l.idlibro", "libro")
            Case Else

        End Select
    End Sub

    Private Sub FReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBTipoReportes.DataSource = GetCBItems()
        CBTipoReportes.DisplayMember = "Elija una opción"
    End Sub

    Function GetCBItems() As List(Of String)

        Dim cbitems = New List(Of String) From {
            "Elija una opción",
            "Historial de préstamos",
            "Préstamos vencidos",
            "Préstamos pendientes",
            "Préstamos finalizados",
            "Libros más prestados",
            "Libros prestados hoy",
            "Colección completa"
        }

        Return cbitems

    End Function

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click
        EExcel(DGVReporte)
    End Sub
End Class