<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Registro))
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LbCrear = New System.Windows.Forms.Label()
        Me.LbEditar = New System.Windows.Forms.Label()
        Me.LbGuardar = New System.Windows.Forms.Label()
        Me.LbActualizar = New System.Windows.Forms.Label()
        Me.LbEliminar = New System.Windows.Forms.Label()
        Me.BTEliminar = New System.Windows.Forms.PictureBox()
        Me.BTActualizar = New System.Windows.Forms.PictureBox()
        Me.BTGuardar = New System.Windows.Forms.PictureBox()
        Me.BTEditar = New System.Windows.Forms.PictureBox()
        Me.BTCrear = New System.Windows.Forms.PictureBox()
        Me.BookLogo = New System.Windows.Forms.PictureBox()
        Me.RetornoIcon = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 729)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1324, 491)
        Me.DataGridView1.TabIndex = 5
        '
        'LbCrear
        '
        Me.LbCrear.AutoSize = True
        Me.LbCrear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCrear.Location = New System.Drawing.Point(68, 704)
        Me.LbCrear.Name = "LbCrear"
        Me.LbCrear.Size = New System.Drawing.Size(50, 21)
        Me.LbCrear.TabIndex = 11
        Me.LbCrear.Text = "Crear"
        '
        'LbEditar
        '
        Me.LbEditar.AutoSize = True
        Me.LbEditar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEditar.Location = New System.Drawing.Point(208, 704)
        Me.LbEditar.Name = "LbEditar"
        Me.LbEditar.Size = New System.Drawing.Size(55, 21)
        Me.LbEditar.TabIndex = 12
        Me.LbEditar.Text = "Editar"
        '
        'LbGuardar
        '
        Me.LbGuardar.AutoSize = True
        Me.LbGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGuardar.Location = New System.Drawing.Point(357, 704)
        Me.LbGuardar.Name = "LbGuardar"
        Me.LbGuardar.Size = New System.Drawing.Size(71, 21)
        Me.LbGuardar.TabIndex = 13
        Me.LbGuardar.Text = "Guardar"
        '
        'LbActualizar
        '
        Me.LbActualizar.AutoSize = True
        Me.LbActualizar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbActualizar.Location = New System.Drawing.Point(504, 704)
        Me.LbActualizar.Name = "LbActualizar"
        Me.LbActualizar.Size = New System.Drawing.Size(87, 21)
        Me.LbActualizar.TabIndex = 14
        Me.LbActualizar.Text = "Actualizar"
        '
        'LbEliminar
        '
        Me.LbEliminar.AutoSize = True
        Me.LbEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEliminar.Location = New System.Drawing.Point(656, 704)
        Me.LbEliminar.Name = "LbEliminar"
        Me.LbEliminar.Size = New System.Drawing.Size(74, 21)
        Me.LbEliminar.TabIndex = 15
        Me.LbEliminar.Text = "Eliminar"
        '
        'BTEliminar
        '
        Me.BTEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTEliminar.Image = Global.HonDB.My.Resources.Resources.DeleteBT
        Me.BTEliminar.Location = New System.Drawing.Point(670, 661)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(40, 40)
        Me.BTEliminar.TabIndex = 10
        Me.BTEliminar.TabStop = False
        '
        'BTActualizar
        '
        Me.BTActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTActualizar.Image = Global.HonDB.My.Resources.Resources.UpdateBT
        Me.BTActualizar.Location = New System.Drawing.Point(526, 661)
        Me.BTActualizar.Name = "BTActualizar"
        Me.BTActualizar.Size = New System.Drawing.Size(40, 40)
        Me.BTActualizar.TabIndex = 9
        Me.BTActualizar.TabStop = False
        '
        'BTGuardar
        '
        Me.BTGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTGuardar.Image = Global.HonDB.My.Resources.Resources.SaveBT2
        Me.BTGuardar.Location = New System.Drawing.Point(372, 661)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(40, 40)
        Me.BTGuardar.TabIndex = 8
        Me.BTGuardar.TabStop = False
        '
        'BTEditar
        '
        Me.BTEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTEditar.Image = Global.HonDB.My.Resources.Resources.EditBT
        Me.BTEditar.Location = New System.Drawing.Point(218, 663)
        Me.BTEditar.Name = "BTEditar"
        Me.BTEditar.Size = New System.Drawing.Size(35, 40)
        Me.BTEditar.TabIndex = 7
        Me.BTEditar.TabStop = False
        '
        'BTCrear
        '
        Me.BTCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTCrear.Image = Global.HonDB.My.Resources.Resources.CreateBT
        Me.BTCrear.Location = New System.Drawing.Point(74, 661)
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
        'Ventana_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BookLogo)
        Me.Controls.Add(Me.LabelLogo)
        Me.Controls.Add(Me.RetornoIcon)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventana_Registro"
        Me.Text = "Ventana_Registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
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
End Class
