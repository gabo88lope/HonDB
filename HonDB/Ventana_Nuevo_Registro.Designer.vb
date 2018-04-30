<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Nuevo_Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Nuevo_Registro))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleNB = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleNac = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleAU = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleISBN = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleLP = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleID = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleNS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LbNuevoPrestamo = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.TBNS = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFP = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFD = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxEP = New System.Windows.Forms.ComboBox()
        Me.NumCant = New System.Windows.Forms.NumericUpDown()
        Me.LbNS = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LbLP = New System.Windows.Forms.Label()
        Me.LbISBN = New System.Windows.Forms.Label()
        Me.LbAU = New System.Windows.Forms.Label()
        Me.LBNac = New System.Windows.Forms.Label()
        Me.LbCant = New System.Windows.Forms.Label()
        Me.LbEP = New System.Windows.Forms.Label()
        Me.LbNB = New System.Windows.Forms.Label()
        Me.LbFP = New System.Windows.Forms.Label()
        Me.LbFD = New System.Windows.Forms.Label()
        Me.BTGuardar = New System.Windows.Forms.Button()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.TBISBN = New System.Windows.Forms.TextBox()
        Me.TBAU = New System.Windows.Forms.TextBox()
        Me.TBNac = New System.Windows.Forms.TextBox()
        Me.TBNB = New System.Windows.Forms.TextBox()
        Me.TBLP = New System.Windows.Forms.TextBox()
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 1179)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 53)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleNB, Me.RectangleNac, Me.RectangleAU, Me.RectangleISBN, Me.RectangleLP, Me.RectangleID, Me.RectangleNS, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(889, 566)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleNB
        '
        Me.RectangleNB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleNB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleNB.BorderWidth = 2
        Me.RectangleNB.CornerRadius = 10
        Me.RectangleNB.Location = New System.Drawing.Point(543, 447)
        Me.RectangleNB.Name = "RectangleNB"
        Me.RectangleNB.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleNac
        '
        Me.RectangleNac.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleNac.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleNac.BorderWidth = 2
        Me.RectangleNac.CornerRadius = 10
        Me.RectangleNac.Location = New System.Drawing.Point(543, 175)
        Me.RectangleNac.Name = "RectangleNac"
        Me.RectangleNac.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleAU
        '
        Me.RectangleAU.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleAU.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleAU.BorderWidth = 2
        Me.RectangleAU.CornerRadius = 10
        Me.RectangleAU.Location = New System.Drawing.Point(543, 88)
        Me.RectangleAU.Name = "RectangleAU"
        Me.RectangleAU.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleISBN
        '
        Me.RectangleISBN.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleISBN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleISBN.BorderWidth = 2
        Me.RectangleISBN.CornerRadius = 10
        Me.RectangleISBN.Location = New System.Drawing.Point(41, 360)
        Me.RectangleISBN.Name = "RectangleISBN"
        Me.RectangleISBN.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleLP
        '
        Me.RectangleLP.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleLP.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleLP.BorderWidth = 2
        Me.RectangleLP.CornerRadius = 10
        Me.RectangleLP.Location = New System.Drawing.Point(41, 267)
        Me.RectangleLP.Name = "RectangleLP"
        Me.RectangleLP.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleID
        '
        Me.RectangleID.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleID.BorderWidth = 2
        Me.RectangleID.CornerRadius = 10
        Me.RectangleID.Location = New System.Drawing.Point(41, 175)
        Me.RectangleID.Name = "RectangleID"
        Me.RectangleID.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleNS
        '
        Me.RectangleNS.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleNS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RectangleNS.BorderWidth = 2
        Me.RectangleNS.CornerRadius = 10
        Me.RectangleNS.Location = New System.Drawing.Point(41, 88)
        Me.RectangleNS.Name = "RectangleNS"
        Me.RectangleNS.Size = New System.Drawing.Size(303, 44)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(905, 39)
        '
        'LbNuevoPrestamo
        '
        Me.LbNuevoPrestamo.AutoSize = True
        Me.LbNuevoPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LbNuevoPrestamo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuevoPrestamo.ForeColor = System.Drawing.Color.White
        Me.LbNuevoPrestamo.Location = New System.Drawing.Point(361, 5)
        Me.LbNuevoPrestamo.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LbNuevoPrestamo.Name = "LbNuevoPrestamo"
        Me.LbNuevoPrestamo.Size = New System.Drawing.Size(176, 30)
        Me.LbNuevoPrestamo.TabIndex = 2
        Me.LbNuevoPrestamo.Text = "Nuevo Préstamo"
        Me.LbNuevoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BTCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTCancelar.FlatAppearance.BorderSize = 2
        Me.BTCancelar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.White
        Me.BTCancelar.Location = New System.Drawing.Point(41, 513)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(110, 41)
        Me.BTCancelar.TabIndex = 4
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'TBNS
        '
        Me.TBNS.BackColor = System.Drawing.SystemColors.Control
        Me.TBNS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBNS.Location = New System.Drawing.Point(57, 98)
        Me.TBNS.Name = "TBNS"
        Me.TBNS.Size = New System.Drawing.Size(271, 26)
        Me.TBNS.TabIndex = 5
        '
        'DateTimePickerFP
        '
        Me.DateTimePickerFP.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DateTimePickerFP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFP.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePickerFP.Location = New System.Drawing.Point(41, 453)
        Me.DateTimePickerFP.Name = "DateTimePickerFP"
        Me.DateTimePickerFP.Size = New System.Drawing.Size(130, 30)
        Me.DateTimePickerFP.TabIndex = 9
        '
        'DateTimePickerFD
        '
        Me.DateTimePickerFD.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DateTimePickerFD.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePickerFD.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.DateTimePickerFD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFD.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePickerFD.Location = New System.Drawing.Point(215, 453)
        Me.DateTimePickerFD.Name = "DateTimePickerFD"
        Me.DateTimePickerFD.Size = New System.Drawing.Size(130, 30)
        Me.DateTimePickerFD.TabIndex = 10
        '
        'ComboBoxEP
        '
        Me.ComboBoxEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxEP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ComboBoxEP.FormattingEnabled = True
        Me.ComboBoxEP.IntegralHeight = False
        Me.ComboBoxEP.Location = New System.Drawing.Point(543, 360)
        Me.ComboBoxEP.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBoxEP.Name = "ComboBoxEP"
        Me.ComboBoxEP.Size = New System.Drawing.Size(200, 33)
        Me.ComboBoxEP.TabIndex = 11
        '
        'NumCant
        '
        Me.NumCant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NumCant.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.NumCant.Location = New System.Drawing.Point(543, 267)
        Me.NumCant.Name = "NumCant"
        Me.NumCant.Size = New System.Drawing.Size(120, 33)
        Me.NumCant.TabIndex = 12
        '
        'LbNS
        '
        Me.LbNS.AutoSize = True
        Me.LbNS.BackColor = System.Drawing.Color.Transparent
        Me.LbNS.ForeColor = System.Drawing.Color.White
        Me.LbNS.Location = New System.Drawing.Point(46, 56)
        Me.LbNS.Name = "LbNS"
        Me.LbNS.Size = New System.Drawing.Size(205, 30)
        Me.LbNS.TabIndex = 16
        Me.LbNS.Text = "Nombre de Usuario"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.BackColor = System.Drawing.Color.Transparent
        Me.LbID.ForeColor = System.Drawing.Color.White
        Me.LbID.Location = New System.Drawing.Point(46, 142)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(148, 30)
        Me.LbID.TabIndex = 17
        Me.LbID.Text = "Identificación"
        '
        'LbLP
        '
        Me.LbLP.AutoSize = True
        Me.LbLP.BackColor = System.Drawing.Color.Transparent
        Me.LbLP.ForeColor = System.Drawing.Color.White
        Me.LbLP.Location = New System.Drawing.Point(46, 236)
        Me.LbLP.Name = "LbLP"
        Me.LbLP.Size = New System.Drawing.Size(201, 30)
        Me.LbLP.TabIndex = 18
        Me.LbLP.Text = "Libros de Préstamo"
        '
        'LbISBN
        '
        Me.LbISBN.AutoSize = True
        Me.LbISBN.BackColor = System.Drawing.Color.Transparent
        Me.LbISBN.ForeColor = System.Drawing.Color.White
        Me.LbISBN.Location = New System.Drawing.Point(46, 329)
        Me.LbISBN.Name = "LbISBN"
        Me.LbISBN.Size = New System.Drawing.Size(62, 30)
        Me.LbISBN.TabIndex = 19
        Me.LbISBN.Text = "ISBN"
        '
        'LbAU
        '
        Me.LbAU.AutoSize = True
        Me.LbAU.BackColor = System.Drawing.Color.Transparent
        Me.LbAU.ForeColor = System.Drawing.Color.White
        Me.LbAU.Location = New System.Drawing.Point(549, 56)
        Me.LbAU.Name = "LbAU"
        Me.LbAU.Size = New System.Drawing.Size(207, 30)
        Me.LbAU.TabIndex = 20
        Me.LbAU.Text = "Apellido de Usuario"
        '
        'LBNac
        '
        Me.LBNac.AutoSize = True
        Me.LBNac.BackColor = System.Drawing.Color.Transparent
        Me.LBNac.ForeColor = System.Drawing.Color.White
        Me.LBNac.Location = New System.Drawing.Point(549, 142)
        Me.LBNac.Name = "LBNac"
        Me.LBNac.Size = New System.Drawing.Size(143, 30)
        Me.LBNac.TabIndex = 21
        Me.LBNac.Text = "Nacionalidad"
        '
        'LbCant
        '
        Me.LbCant.AutoSize = True
        Me.LbCant.BackColor = System.Drawing.Color.Transparent
        Me.LbCant.ForeColor = System.Drawing.Color.White
        Me.LbCant.Location = New System.Drawing.Point(538, 236)
        Me.LbCant.Name = "LbCant"
        Me.LbCant.Size = New System.Drawing.Size(101, 30)
        Me.LbCant.TabIndex = 22
        Me.LbCant.Text = "Cantidad"
        '
        'LbEP
        '
        Me.LbEP.AutoSize = True
        Me.LbEP.BackColor = System.Drawing.Color.Transparent
        Me.LbEP.ForeColor = System.Drawing.Color.White
        Me.LbEP.Location = New System.Drawing.Point(538, 329)
        Me.LbEP.Name = "LbEP"
        Me.LbEP.Size = New System.Drawing.Size(206, 30)
        Me.LbEP.TabIndex = 23
        Me.LbEP.Text = "Estado de Préstamo"
        '
        'LbNB
        '
        Me.LbNB.AutoSize = True
        Me.LbNB.BackColor = System.Drawing.Color.Transparent
        Me.LbNB.ForeColor = System.Drawing.Color.White
        Me.LbNB.Location = New System.Drawing.Point(550, 416)
        Me.LbNB.Name = "LbNB"
        Me.LbNB.Size = New System.Drawing.Size(254, 30)
        Me.LbNB.TabIndex = 24
        Me.LbNB.Text = "Nombre de Bibliotecario"
        '
        'LbFP
        '
        Me.LbFP.AutoSize = True
        Me.LbFP.BackColor = System.Drawing.Color.Transparent
        Me.LbFP.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFP.ForeColor = System.Drawing.Color.White
        Me.LbFP.Location = New System.Drawing.Point(37, 427)
        Me.LbFP.Name = "LbFP"
        Me.LbFP.Size = New System.Drawing.Size(160, 23)
        Me.LbFP.TabIndex = 25
        Me.LbFP.Text = "Fecha de Préstamo"
        '
        'LbFD
        '
        Me.LbFD.AutoSize = True
        Me.LbFD.BackColor = System.Drawing.Color.Transparent
        Me.LbFD.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFD.ForeColor = System.Drawing.Color.White
        Me.LbFD.Location = New System.Drawing.Point(211, 427)
        Me.LbFD.Name = "LbFD"
        Me.LbFD.Size = New System.Drawing.Size(174, 23)
        Me.LbFD.TabIndex = 26
        Me.LbFD.Text = "Fecha de Devolución"
        '
        'BTGuardar
        '
        Me.BTGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BTGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTGuardar.FlatAppearance.BorderSize = 2
        Me.BTGuardar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTGuardar.ForeColor = System.Drawing.Color.White
        Me.BTGuardar.Location = New System.Drawing.Point(737, 513)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(110, 41)
        Me.BTGuardar.TabIndex = 27
        Me.BTGuardar.Text = "Guardar"
        Me.BTGuardar.UseVisualStyleBackColor = False
        '
        'TBID
        '
        Me.TBID.BackColor = System.Drawing.SystemColors.Control
        Me.TBID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBID.Location = New System.Drawing.Point(57, 185)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(271, 26)
        Me.TBID.TabIndex = 28
        '
        'TBISBN
        '
        Me.TBISBN.BackColor = System.Drawing.SystemColors.Control
        Me.TBISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBISBN.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBISBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBISBN.Location = New System.Drawing.Point(57, 370)
        Me.TBISBN.MaxLength = 13
        Me.TBISBN.Name = "TBISBN"
        Me.TBISBN.Size = New System.Drawing.Size(271, 26)
        Me.TBISBN.TabIndex = 29
        '
        'TBAU
        '
        Me.TBAU.BackColor = System.Drawing.SystemColors.Control
        Me.TBAU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBAU.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBAU.Location = New System.Drawing.Point(559, 98)
        Me.TBAU.Name = "TBAU"
        Me.TBAU.Size = New System.Drawing.Size(271, 26)
        Me.TBAU.TabIndex = 30
        '
        'TBNac
        '
        Me.TBNac.BackColor = System.Drawing.SystemColors.Control
        Me.TBNac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNac.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBNac.Location = New System.Drawing.Point(559, 185)
        Me.TBNac.Name = "TBNac"
        Me.TBNac.Size = New System.Drawing.Size(271, 26)
        Me.TBNac.TabIndex = 31
        '
        'TBNB
        '
        Me.TBNB.BackColor = System.Drawing.SystemColors.Control
        Me.TBNB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBNB.Location = New System.Drawing.Point(559, 457)
        Me.TBNB.Name = "TBNB"
        Me.TBNB.Size = New System.Drawing.Size(271, 26)
        Me.TBNB.TabIndex = 32
        '
        'TBLP
        '
        Me.TBLP.BackColor = System.Drawing.SystemColors.Control
        Me.TBLP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBLP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBLP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.TBLP.Location = New System.Drawing.Point(57, 277)
        Me.TBLP.Name = "TBLP"
        Me.TBLP.Size = New System.Drawing.Size(271, 26)
        Me.TBLP.TabIndex = 33
        '
        'Ventana_Nuevo_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HonDB.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(889, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.TBLP)
        Me.Controls.Add(Me.TBNB)
        Me.Controls.Add(Me.TBNac)
        Me.Controls.Add(Me.TBAU)
        Me.Controls.Add(Me.TBISBN)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.BTGuardar)
        Me.Controls.Add(Me.LbFD)
        Me.Controls.Add(Me.LbFP)
        Me.Controls.Add(Me.LbNB)
        Me.Controls.Add(Me.LbEP)
        Me.Controls.Add(Me.LbCant)
        Me.Controls.Add(Me.LBNac)
        Me.Controls.Add(Me.LbAU)
        Me.Controls.Add(Me.LbISBN)
        Me.Controls.Add(Me.LbLP)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.LbNS)
        Me.Controls.Add(Me.NumCant)
        Me.Controls.Add(Me.ComboBoxEP)
        Me.Controls.Add(Me.DateTimePickerFD)
        Me.Controls.Add(Me.DateTimePickerFP)
        Me.Controls.Add(Me.TBNS)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.LbNuevoPrestamo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventana_Nuevo_Registro"
        Me.Text = "Nuevo Préstamo"
        Me.TopMost = True
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents LbNuevoPrestamo As Label
    Friend WithEvents RectangleNS As PowerPacks.RectangleShape
    Friend WithEvents BTCancelar As Button
    Friend WithEvents TBNS As TextBox
    Friend WithEvents RectangleISBN As PowerPacks.RectangleShape
    Friend WithEvents RectangleLP As PowerPacks.RectangleShape
    Friend WithEvents RectangleID As PowerPacks.RectangleShape
    Friend WithEvents DateTimePickerFP As DateTimePicker
    Friend WithEvents DateTimePickerFD As DateTimePicker
    Friend WithEvents RectangleNac As PowerPacks.RectangleShape
    Friend WithEvents RectangleAU As PowerPacks.RectangleShape
    Friend WithEvents ComboBoxEP As ComboBox
    Friend WithEvents RectangleNB As PowerPacks.RectangleShape
    Friend WithEvents NumCant As NumericUpDown
    Friend WithEvents LbNS As Label
    Friend WithEvents LbID As Label
    Friend WithEvents LbLP As Label
    Friend WithEvents LbISBN As Label
    Friend WithEvents LbAU As Label
    Friend WithEvents LBNac As Label
    Friend WithEvents LbCant As Label
    Friend WithEvents LbEP As Label
    Friend WithEvents LbNB As Label
    Friend WithEvents LbFP As Label
    Friend WithEvents LbFD As Label
    Friend WithEvents BTGuardar As Button
    Friend WithEvents TBID As TextBox
    Friend WithEvents TBISBN As TextBox
    Friend WithEvents TBAU As TextBox
    Friend WithEvents TBNac As TextBox
    Friend WithEvents TBNB As TextBox
    Friend WithEvents TBLP As TextBox
End Class
