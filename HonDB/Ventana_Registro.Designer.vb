﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Registro))
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleNS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleBusqueda = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DatosGrid = New System.Windows.Forms.DataGridView()
        Me.LbCrear = New System.Windows.Forms.Label()
        Me.LbEditar = New System.Windows.Forms.Label()
        Me.LbGuardar = New System.Windows.Forms.Label()
        Me.LbActualizar = New System.Windows.Forms.Label()
        Me.LbEliminar = New System.Windows.Forms.Label()
        Me.TBBusqueda = New System.Windows.Forms.TextBox()
        Me.NUsuario = New System.Windows.Forms.TextBox()
        Me.LbNS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDUsuario = New System.Windows.Forms.TextBox()
        Me.LBPrestamos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FD = New System.Windows.Forms.DateTimePicker()
        Me.FP = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CantP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBNac = New System.Windows.Forms.Label()
        Me.CBBN = New System.Windows.Forms.ComboBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.CBEdit = New System.Windows.Forms.CheckBox()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.idPrestamo = New System.Windows.Forms.TextBox()
        Me.Lupa = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTEliminar = New System.Windows.Forms.PictureBox()
        Me.BTActualizar = New System.Windows.Forms.PictureBox()
        Me.BTGuardar = New System.Windows.Forms.PictureBox()
        Me.BTEditar = New System.Windows.Forms.PictureBox()
        Me.BTCrear = New System.Windows.Forms.PictureBox()
        Me.BookLogo = New System.Windows.Forms.PictureBox()
        Me.RetornoIcon = New System.Windows.Forms.PictureBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Ciudad = New System.Windows.Forms.ComboBox()
        Me.Pais = New System.Windows.Forms.ComboBox()
        Me.Nacionalidad = New System.Windows.Forms.ComboBox()
        Me.Sexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DatosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTCrear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetornoIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.LabelLogo.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogo.ForeColor = System.Drawing.Color.White
        Me.LabelLogo.Location = New System.Drawing.Point(591, 8)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(173, 60)
        Me.LabelLogo.TabIndex = 2
        Me.LabelLogo.Text = "HonDB"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape8, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape3, Me.RectangleNS, Me.RectangleBusqueda, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 729)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 10
        Me.RectangleShape8.Enabled = False
        Me.RectangleShape8.Location = New System.Drawing.Point(758, 493)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(226, 37)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 10
        Me.RectangleShape6.Location = New System.Drawing.Point(1005, 428)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(320, 37)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 10
        Me.RectangleShape5.Location = New System.Drawing.Point(751, 267)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(278, 37)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 10
        Me.RectangleShape3.Location = New System.Drawing.Point(1046, 188)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(278, 37)
        '
        'RectangleNS
        '
        Me.RectangleNS.BackColor = System.Drawing.SystemColors.Control
        Me.RectangleNS.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleNS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleNS.BorderWidth = 2
        Me.RectangleNS.CornerRadius = 10
        Me.RectangleNS.Location = New System.Drawing.Point(751, 188)
        Me.RectangleNS.Name = "RectangleNS"
        Me.RectangleNS.Size = New System.Drawing.Size(278, 37)
        '
        'RectangleBusqueda
        '
        Me.RectangleBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RectangleBusqueda.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleBusqueda.BorderColor = System.Drawing.Color.Gray
        Me.RectangleBusqueda.CornerRadius = 15
        Me.RectangleBusqueda.Location = New System.Drawing.Point(52, 92)
        Me.RectangleBusqueda.Name = "RectangleBusqueda"
        Me.RectangleBusqueda.Size = New System.Drawing.Size(307, 50)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RectangleShape2.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(70, 70)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1366, 70)
        '
        'DatosGrid
        '
        Me.DatosGrid.AllowUserToAddRows = False
        Me.DatosGrid.BackgroundColor = System.Drawing.Color.White
        Me.DatosGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatosGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatosGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.DatosGrid.Location = New System.Drawing.Point(54, 164)
        Me.DatosGrid.Name = "DatosGrid"
        Me.DatosGrid.ReadOnly = True
        Me.DatosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatosGrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DatosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosGrid.Size = New System.Drawing.Size(676, 545)
        Me.DatosGrid.TabIndex = 5
        '
        'LbCrear
        '
        Me.LbCrear.AutoSize = True
        Me.LbCrear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCrear.Location = New System.Drawing.Point(837, 690)
        Me.LbCrear.Name = "LbCrear"
        Me.LbCrear.Size = New System.Drawing.Size(50, 21)
        Me.LbCrear.TabIndex = 11
        Me.LbCrear.Text = "Crear"
        '
        'LbEditar
        '
        Me.LbEditar.AutoSize = True
        Me.LbEditar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEditar.Location = New System.Drawing.Point(922, 688)
        Me.LbEditar.Name = "LbEditar"
        Me.LbEditar.Size = New System.Drawing.Size(55, 21)
        Me.LbEditar.TabIndex = 12
        Me.LbEditar.Text = "Editar"
        '
        'LbGuardar
        '
        Me.LbGuardar.AutoSize = True
        Me.LbGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGuardar.Location = New System.Drawing.Point(999, 690)
        Me.LbGuardar.Name = "LbGuardar"
        Me.LbGuardar.Size = New System.Drawing.Size(71, 21)
        Me.LbGuardar.TabIndex = 13
        Me.LbGuardar.Text = "Guardar"
        '
        'LbActualizar
        '
        Me.LbActualizar.AutoSize = True
        Me.LbActualizar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbActualizar.Location = New System.Drawing.Point(1090, 690)
        Me.LbActualizar.Name = "LbActualizar"
        Me.LbActualizar.Size = New System.Drawing.Size(87, 21)
        Me.LbActualizar.TabIndex = 14
        Me.LbActualizar.Text = "Actualizar"
        '
        'LbEliminar
        '
        Me.LbEliminar.AutoSize = True
        Me.LbEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEliminar.Location = New System.Drawing.Point(1193, 690)
        Me.LbEliminar.Name = "LbEliminar"
        Me.LbEliminar.Size = New System.Drawing.Size(74, 21)
        Me.LbEliminar.TabIndex = 15
        Me.LbEliminar.Text = "Eliminar"
        '
        'TBBusqueda
        '
        Me.TBBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TBBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBBusqueda.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBusqueda.ForeColor = System.Drawing.Color.Gray
        Me.TBBusqueda.Location = New System.Drawing.Point(102, 105)
        Me.TBBusqueda.Multiline = True
        Me.TBBusqueda.Name = "TBBusqueda"
        Me.TBBusqueda.Size = New System.Drawing.Size(243, 33)
        Me.TBBusqueda.TabIndex = 16
        '
        'NUsuario
        '
        Me.NUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.NUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.NUsuario.Location = New System.Drawing.Point(762, 196)
        Me.NUsuario.Name = "NUsuario"
        Me.NUsuario.Size = New System.Drawing.Size(254, 22)
        Me.NUsuario.TabIndex = 19
        '
        'LbNS
        '
        Me.LbNS.AutoSize = True
        Me.LbNS.BackColor = System.Drawing.Color.Transparent
        Me.LbNS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNS.ForeColor = System.Drawing.Color.DimGray
        Me.LbNS.Location = New System.Drawing.Point(766, 164)
        Me.LbNS.Name = "LbNS"
        Me.LbNS.Size = New System.Drawing.Size(159, 21)
        Me.LbNS.TabIndex = 20
        Me.LbNS.Text = "Nombre de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(1056, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Apellido de Usuario"
        '
        'AUsuario
        '
        Me.AUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.AUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.AUsuario.Location = New System.Drawing.Point(1057, 196)
        Me.AUsuario.Name = "AUsuario"
        Me.AUsuario.Size = New System.Drawing.Size(254, 22)
        Me.AUsuario.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(766, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "País"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(766, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Identificación"
        '
        'IDUsuario
        '
        Me.IDUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.IDUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.IDUsuario.Location = New System.Drawing.Point(762, 276)
        Me.IDUsuario.Name = "IDUsuario"
        Me.IDUsuario.Size = New System.Drawing.Size(254, 22)
        Me.IDUsuario.TabIndex = 26
        '
        'LBPrestamos
        '
        Me.LBPrestamos.BackColor = System.Drawing.SystemColors.Control
        Me.LBPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBPrestamos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrestamos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.LBPrestamos.Location = New System.Drawing.Point(1017, 436)
        Me.LBPrestamos.Name = "LBPrestamos"
        Me.LBPrestamos.Size = New System.Drawing.Size(262, 22)
        Me.LBPrestamos.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(1013, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Libros de Préstamo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(766, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cantidad"
        '
        'CBEstado
        '
        Me.CBEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBEstado.Enabled = False
        Me.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.IntegralHeight = False
        Me.CBEstado.Items.AddRange(New Object() {"Préstamo Vigente", "Préstamo Vencido", "Préstamo Finalizado"})
        Me.CBEstado.Location = New System.Drawing.Point(762, 574)
        Me.CBEstado.Margin = New System.Windows.Forms.Padding(6)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(223, 29)
        Me.CBEstado.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(758, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Estado de Préstamo"
        '
        'FD
        '
        Me.FD.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FD.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.FD.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FD.CustomFormat = ""
        Me.FD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FD.Location = New System.Drawing.Point(1196, 502)
        Me.FD.Name = "FD"
        Me.FD.Size = New System.Drawing.Size(130, 29)
        Me.FD.TabIndex = 35
        '
        'FP
        '
        Me.FP.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FP.CustomFormat = ""
        Me.FP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.FP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FP.Location = New System.Drawing.Point(1046, 502)
        Me.FP.Name = "FP"
        Me.FP.Size = New System.Drawing.Size(130, 29)
        Me.FP.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(1042, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "F. Préstamo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(1192, 475)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 21)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "F. Devolución"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(1056, 547)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 21)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Nombre Bibliotecario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(942, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 37)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "PRÉSTAMOS"
        '
        'CantP
        '
        Me.CantP.BackColor = System.Drawing.SystemColors.Control
        Me.CantP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CantP.Enabled = False
        Me.CantP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.CantP.Location = New System.Drawing.Point(771, 501)
        Me.CantP.Name = "CantP"
        Me.CantP.Size = New System.Drawing.Size(199, 22)
        Me.CantP.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(1056, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 21)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Ciudad"
        '
        'LBNac
        '
        Me.LBNac.AutoSize = True
        Me.LBNac.BackColor = System.Drawing.Color.Transparent
        Me.LBNac.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNac.ForeColor = System.Drawing.Color.DimGray
        Me.LBNac.Location = New System.Drawing.Point(766, 398)
        Me.LBNac.Name = "LBNac"
        Me.LBNac.Size = New System.Drawing.Size(113, 21)
        Me.LBNac.TabIndex = 47
        Me.LBNac.Text = "Nacionalidad"
        '
        'CBBN
        '
        Me.CBBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBBN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.CBBN.FormattingEnabled = True
        Me.CBBN.IntegralHeight = False
        Me.CBBN.Location = New System.Drawing.Point(1057, 574)
        Me.CBBN.Margin = New System.Windows.Forms.Padding(6)
        Me.CBBN.Name = "CBBN"
        Me.CBBN.Size = New System.Drawing.Size(268, 29)
        Me.CBBN.TabIndex = 48
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.SystemColors.Control
        Me.ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ID.Location = New System.Drawing.Point(762, 615)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(68, 22)
        Me.ID.TabIndex = 51
        Me.ID.Visible = False
        '
        'CBEdit
        '
        Me.CBEdit.AutoSize = True
        Me.CBEdit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEdit.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBEdit.Location = New System.Drawing.Point(532, 137)
        Me.CBEdit.Name = "CBEdit"
        Me.CBEdit.Size = New System.Drawing.Size(204, 24)
        Me.CBEdit.TabIndex = 53
        Me.CBEdit.Text = "Editar/Eliminar Préstamo"
        Me.CBEdit.UseVisualStyleBackColor = True
        '
        'CBFiltro
        '
        Me.CBFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.IntegralHeight = False
        Me.CBFiltro.Items.AddRange(New Object() {"Nombre", "Identificación"})
        Me.CBFiltro.Location = New System.Drawing.Point(366, 114)
        Me.CBFiltro.Margin = New System.Windows.Forms.Padding(6)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(156, 29)
        Me.CBFiltro.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(362, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 21)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Búsqueda por"
        '
        'idPrestamo
        '
        Me.idPrestamo.BackColor = System.Drawing.SystemColors.Control
        Me.idPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.idPrestamo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPrestamo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.idPrestamo.Location = New System.Drawing.Point(836, 615)
        Me.idPrestamo.Name = "idPrestamo"
        Me.idPrestamo.Size = New System.Drawing.Size(68, 22)
        Me.idPrestamo.TabIndex = 56
        Me.idPrestamo.Visible = False
        '
        'Lupa
        '
        Me.Lupa.BackColor = System.Drawing.SystemColors.Control
        Me.Lupa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lupa.Image = Global.HonDB.My.Resources.Resources.Loupe
        Me.Lupa.Location = New System.Drawing.Point(1286, 433)
        Me.Lupa.Name = "Lupa"
        Me.Lupa.Size = New System.Drawing.Size(27, 26)
        Me.Lupa.TabIndex = 57
        Me.Lupa.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'BTEliminar
        '
        Me.BTEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTEliminar.Image = Global.HonDB.My.Resources.Resources.DeleteBT
        Me.BTEliminar.Location = New System.Drawing.Point(1207, 647)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(40, 40)
        Me.BTEliminar.TabIndex = 10
        Me.BTEliminar.TabStop = False
        '
        'BTActualizar
        '
        Me.BTActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTActualizar.Image = Global.HonDB.My.Resources.Resources.UpdateBT
        Me.BTActualizar.Location = New System.Drawing.Point(1112, 647)
        Me.BTActualizar.Name = "BTActualizar"
        Me.BTActualizar.Size = New System.Drawing.Size(40, 40)
        Me.BTActualizar.TabIndex = 9
        Me.BTActualizar.TabStop = False
        '
        'BTGuardar
        '
        Me.BTGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTGuardar.Image = Global.HonDB.My.Resources.Resources.SaveBT2
        Me.BTGuardar.Location = New System.Drawing.Point(1014, 647)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(40, 40)
        Me.BTGuardar.TabIndex = 8
        Me.BTGuardar.TabStop = False
        '
        'BTEditar
        '
        Me.BTEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTEditar.Image = Global.HonDB.My.Resources.Resources.EditBT
        Me.BTEditar.Location = New System.Drawing.Point(932, 647)
        Me.BTEditar.Name = "BTEditar"
        Me.BTEditar.Size = New System.Drawing.Size(35, 40)
        Me.BTEditar.TabIndex = 7
        Me.BTEditar.TabStop = False
        '
        'BTCrear
        '
        Me.BTCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTCrear.Image = Global.HonDB.My.Resources.Resources.CreateBT
        Me.BTCrear.Location = New System.Drawing.Point(843, 647)
        Me.BTCrear.Name = "BTCrear"
        Me.BTCrear.Size = New System.Drawing.Size(40, 40)
        Me.BTCrear.TabIndex = 6
        Me.BTCrear.TabStop = False
        '
        'BookLogo
        '
        Me.BookLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BookLogo.Image = Global.HonDB.My.Resources.Resources.BookLogo
        Me.BookLogo.Location = New System.Drawing.Point(751, 8)
        Me.BookLogo.Name = "BookLogo"
        Me.BookLogo.Size = New System.Drawing.Size(65, 50)
        Me.BookLogo.TabIndex = 3
        Me.BookLogo.TabStop = False
        '
        'RetornoIcon
        '
        Me.RetornoIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RetornoIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RetornoIcon.Image = Global.HonDB.My.Resources.Resources.Arrow3
        Me.RetornoIcon.Location = New System.Drawing.Point(0, 0)
        Me.RetornoIcon.Name = "RetornoIcon"
        Me.RetornoIcon.Size = New System.Drawing.Size(70, 70)
        Me.RetornoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RetornoIcon.TabIndex = 1
        Me.RetornoIcon.TabStop = False
        '
        'Limpiar
        '
        Me.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(532, 105)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(198, 23)
        Me.Limpiar.TabIndex = 59
        Me.Limpiar.Text = "Limpiar Campos"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Ciudad
        '
        Me.Ciudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ciudad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Ciudad.FormattingEnabled = True
        Me.Ciudad.IntegralHeight = False
        Me.Ciudad.Items.AddRange(New Object() {"Managua", "Masaya", "Leon", "Granada", "Carazo", "Esteli", "Rivas", "Chinandenga", "Chontales", "Madriz", "Matagalpa", "Nueva Segovia", "Boaco", "Rio San Juan", "Caribe Sur", "Jinotega", "Caribe Norte"})
        Me.Ciudad.Location = New System.Drawing.Point(1046, 351)
        Me.Ciudad.Margin = New System.Windows.Forms.Padding(6)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(279, 29)
        Me.Ciudad.TabIndex = 61
        '
        'Pais
        '
        Me.Pais.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pais.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Pais.FormattingEnabled = True
        Me.Pais.IntegralHeight = False
        Me.Pais.Items.AddRange(New Object() {"Nicaragua"})
        Me.Pais.Location = New System.Drawing.Point(752, 353)
        Me.Pais.Margin = New System.Windows.Forms.Padding(6)
        Me.Pais.Name = "Pais"
        Me.Pais.Size = New System.Drawing.Size(279, 29)
        Me.Pais.TabIndex = 62
        '
        'Nacionalidad
        '
        Me.Nacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Nacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nacionalidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nacionalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Nacionalidad.FormattingEnabled = True
        Me.Nacionalidad.IntegralHeight = False
        Me.Nacionalidad.Items.AddRange(New Object() {"Nicaraguense"})
        Me.Nacionalidad.Location = New System.Drawing.Point(752, 425)
        Me.Nacionalidad.Margin = New System.Windows.Forms.Padding(6)
        Me.Nacionalidad.Name = "Nacionalidad"
        Me.Nacionalidad.Size = New System.Drawing.Size(231, 29)
        Me.Nacionalidad.TabIndex = 63
        '
        'Sexo
        '
        Me.Sexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Sexo.FormattingEnabled = True
        Me.Sexo.IntegralHeight = False
        Me.Sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Sexo.Location = New System.Drawing.Point(1046, 267)
        Me.Sexo.Margin = New System.Windows.Forms.Padding(6)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(279, 29)
        Me.Sexo.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(1056, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Sexo"
        '
        'Ventana_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.Nacionalidad)
        Me.Controls.Add(Me.Pais)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Lupa)
        Me.Controls.Add(Me.idPrestamo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CBFiltro)
        Me.Controls.Add(Me.CBEdit)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.CBBN)
        Me.Controls.Add(Me.LBNac)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CantP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FD)
        Me.Controls.Add(Me.FP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBPrestamos)
        Me.Controls.Add(Me.IDUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbNS)
        Me.Controls.Add(Me.NUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBBusqueda)
        Me.Controls.Add(Me.LbEliminar)
        Me.Controls.Add(Me.LbActualizar)
        Me.Controls.Add(Me.LbGuardar)
        Me.Controls.Add(Me.LbEditar)
        Me.Controls.Add(Me.LbCrear)
        Me.Controls.Add(Me.BTEliminar)
        Me.Controls.Add(Me.BTActualizar)
        Me.Controls.Add(Me.BTGuardar)
        Me.Controls.Add(Me.BTEditar)
        Me.Controls.Add(Me.BTCrear)
        Me.Controls.Add(Me.DatosGrid)
        Me.Controls.Add(Me.BookLogo)
        Me.Controls.Add(Me.LabelLogo)
        Me.Controls.Add(Me.RetornoIcon)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventana_Registro"
        Me.Text = "Ventana_Registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTCrear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetornoIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RetornoIcon As PictureBox
    Friend WithEvents LabelLogo As Label
    Friend WithEvents BookLogo As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents DatosGrid As DataGridView
    Friend WithEvents BTCrear As PictureBox
    Friend WithEvents BTEditar As PictureBox
    Friend WithEvents BTGuardar As PictureBox
    Friend WithEvents BTActualizar As PictureBox
    Friend WithEvents BTEliminar As PictureBox
    Friend WithEvents LbCrear As Label
    Friend WithEvents LbEditar As Label
    Friend WithEvents LbGuardar As Label
    Friend WithEvents LbActualizar As Label
    Friend WithEvents LbEliminar As Label
    Friend WithEvents RectangleBusqueda As PowerPacks.RectangleShape
    Friend WithEvents TBBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RectangleNS As PowerPacks.RectangleShape
    Friend WithEvents NUsuario As TextBox
    Friend WithEvents LbNS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents AUsuario As TextBox
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents IDUsuario As TextBox
    Friend WithEvents LBPrestamos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FD As DateTimePicker
    Friend WithEvents FP As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents CantP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LBNac As Label
    Friend WithEvents CBBN As ComboBox
    Friend WithEvents ID As TextBox
    Friend WithEvents CBEdit As CheckBox
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents idPrestamo As TextBox
    Friend WithEvents Lupa As PictureBox
    Friend WithEvents Limpiar As Button
    Friend WithEvents Ciudad As ComboBox
    Friend WithEvents Pais As ComboBox
    Friend WithEvents Nacionalidad As ComboBox
    Friend WithEvents Sexo As ComboBox
    Friend WithEvents Label11 As Label
End Class
