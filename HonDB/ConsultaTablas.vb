﻿Imports HonDB.VentanaAdministrar

Module ConsultaTablas

    Public campoUsuario As String
    Public tablaUsuarioCons = "SELECT u.idusuario as Código, u.nombre as Nombre, u.apellido as Apellido, u.identificacion as Cédula,
        u.sexo as Sexo, p.pais as País, p.ciudad as Ciudad FROM usuario u INNER JOIN ubicacion p ON
        u.idubicacion = p.idubicacion ORDER BY u.idusuario ASC"

    Public busquedaNombre = "SELECT u.idusuario as Código, u.nombre as Nombre, u.apellido as Apellido, u.identificacion as Cédula,
        u.sexo as Sexo, p.pais as País, p.ciudad as Ciudad FROM usuario u INNER JOIN ubicacion p ON
        u.idubicacion = p.idubicacion"

    Public busquedaCodigo = "SELECT u.idusuario as Código, u.nombre as Nombre, u.apellido as Apellido, u.identificacion as Cédula,
        u.sexo as Sexo, p.pais as País, p.ciudad as Ciudad FROM usuario u INNER JOIN ubicacion p ON
        u.idubicacion = p.idubicacion Where u.idusuario = " & campoUsuario & " ORDER BY u.idusuario ASC"

    Public busquedaCedula = "SELECT u.idusuario as Código, u.nombre as Nombre, u.apellido as Apellido, u.identificacion as Cédula,
        u.sexo as Sexo, p.pais as País, p.ciudad as Ciudad FROM usuario u INNER JOIN ubicacion p ON
        u.idubicacion = p.idubicacion Where u.identificacion like '" & campoUsuario & "%' ORDER BY u.idusuario ASC"

    Public tablaLibroQuery = "SELECT l.idlibro as Código, l.isbn as ISBN, l.depositolegal as DepositoLegal, l.titulo as Titulo,
    DATE_FORMAT(l.fechapublicacion, '%d/%m/%Y') as FechaPublicacion, l.edicion as Edicion, l.descripcion as Descripcion,
    l.paginas as Paginas, l.numejemplares as Ejemplares, u.ciudad as Ciudad, u.pais as Pais, s.estado
    as Estado, t.nombre as TipoDocumento, g.nombre as CategoriaGeneral, e.nombre as CategoriaEspecial
    FROM libro l INNER JOIN ubicacion u ON l.idubicacion = u.idubicacion INNER JOIN estado s ON l.idestado
     = s.idestado INNER JOIN tipodocumento t ON l.idtipodocumento = t.idtipodocumento INNER JOIN categoriageneral
    g  ON l.codigogeneral = g.codigogeneral INNER JOIN categoriaespecial e ON l.codigoespecial = e.codigoespecial"

    Public queryAutorTabla = "SELECT a.idautor as Código, a.nombre as Nombre, a.apellido as Apellido, a.sexo as Sexo,
    u.ciudad, u.pais FROM autor a INNER JOIN ubicacion u ON a.idubicacion = u.idubicacion"

    Public queryBiblioTabla = "SELECT idbibliotecario as Código, nombre as Nombre, apellido as Apellido, usuario as Usuario
    FROM bibliotecario"

    Public queryUbicacionesTabla = "SELECT idubicacion as Código, ciudad as Ciudad, pais as País, nacionalidad as Nacionalidad
    FROM ubicacion"

    Public queryTablaCG = "SELECT codigogeneral as CódigoGeneral, nombre as Nombre FROM categoriageneral"
End Module
