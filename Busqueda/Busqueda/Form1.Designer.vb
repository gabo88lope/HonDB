<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Busqueda
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.BotonBuscarLibro = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotonAgregarBusqueda = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BotonCancelarBusqueda = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(356, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Busqueda avanzada"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ComboBox4)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.BotonBuscarLibro)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 71)
        Me.Panel2.TabIndex = 1
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(501, 50)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 9
        Me.ComboBox4.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(501, 20)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.Visible = False
        '
        'BotonBuscarLibro
        '
        Me.BotonBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonBuscarLibro.Location = New System.Drawing.Point(182, 33)
        Me.BotonBuscarLibro.Name = "BotonBuscarLibro"
        Me.BotonBuscarLibro.Size = New System.Drawing.Size(75, 23)
        Me.BotonBuscarLibro.TabIndex = 4
        Me.BotonBuscarLibro.Text = "Buscar"
        Me.BotonBuscarLibro.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(650, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(650, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(353, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Búsqueda de Libros"
        '
        'BotonAgregarBusqueda
        '
        Me.BotonAgregarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonAgregarBusqueda.Location = New System.Drawing.Point(713, 415)
        Me.BotonAgregarBusqueda.Name = "BotonAgregarBusqueda"
        Me.BotonAgregarBusqueda.Size = New System.Drawing.Size(75, 32)
        Me.BotonAgregarBusqueda.TabIndex = 10
        Me.BotonAgregarBusqueda.Text = "Agregar"
        Me.BotonAgregarBusqueda.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 332)
        Me.DataGridView1.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(164, 140)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(75, 23)
        '
        'BotonCancelarBusqueda
        '
        Me.BotonCancelarBusqueda.Location = New System.Drawing.Point(24, 415)
        Me.BotonCancelarBusqueda.Name = "BotonCancelarBusqueda"
        Me.BotonCancelarBusqueda.Size = New System.Drawing.Size(75, 32)
        Me.BotonCancelarBusqueda.TabIndex = 11
        Me.BotonCancelarBusqueda.Text = "Cancelar"
        Me.BotonCancelarBusqueda.UseVisualStyleBackColor = True
        '
        'Ventana_Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BotonCancelarBusqueda)
        Me.Controls.Add(Me.BotonAgregarBusqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Ventana_Busqueda"
        Me.Text = "Búsquedas de Libros"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BotonBuscarLibro As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BotonAgregarBusqueda As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents BotonCancelarBusqueda As Button
End Class
