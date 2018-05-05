<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BotonLimpiarBusquedaLibro = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BotonAgregarBusqueda = New System.Windows.Forms.Button()
        Me.BotonCancelarBusqueda = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TBI)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BotonLimpiarBusquedaLibro)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 86)
        Me.Panel1.TabIndex = 0
        '
        'TBI
        '
        Me.TBI.Location = New System.Drawing.Point(696, 10)
        Me.TBI.Name = "TBI"
        Me.TBI.Size = New System.Drawing.Size(100, 20)
        Me.TBI.TabIndex = 13
        Me.TBI.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Búsqueda de Libros"
        '
        'BotonLimpiarBusquedaLibro
        '
        Me.BotonLimpiarBusquedaLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonLimpiarBusquedaLibro.Location = New System.Drawing.Point(368, 52)
        Me.BotonLimpiarBusquedaLibro.Name = "BotonLimpiarBusquedaLibro"
        Me.BotonLimpiarBusquedaLibro.Size = New System.Drawing.Size(75, 24)
        Me.BotonLimpiarBusquedaLibro.TabIndex = 1
        Me.BotonLimpiarBusquedaLibro.Text = "Limpiar"
        Me.BotonLimpiarBusquedaLibro.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(20, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 24)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 79)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(807, 328)
        Me.DataGridView1.TabIndex = 1
        '
        'BotonAgregarBusqueda
        '
        Me.BotonAgregarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonAgregarBusqueda.Location = New System.Drawing.Point(692, 413)
        Me.BotonAgregarBusqueda.Name = "BotonAgregarBusqueda"
        Me.BotonAgregarBusqueda.Size = New System.Drawing.Size(96, 38)
        Me.BotonAgregarBusqueda.TabIndex = 2
        Me.BotonAgregarBusqueda.Text = "Agregar"
        Me.BotonAgregarBusqueda.UseVisualStyleBackColor = True
        '
        'BotonCancelarBusqueda
        '
        Me.BotonCancelarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCancelarBusqueda.Location = New System.Drawing.Point(12, 413)
        Me.BotonCancelarBusqueda.Name = "BotonCancelarBusqueda"
        Me.BotonCancelarBusqueda.Size = New System.Drawing.Size(99, 35)
        Me.BotonCancelarBusqueda.TabIndex = 3
        Me.BotonCancelarBusqueda.Text = "Cerrar"
        Me.BotonCancelarBusqueda.UseVisualStyleBackColor = True
        '
        'Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.BotonCancelarBusqueda)
        Me.Controls.Add(Me.BotonAgregarBusqueda)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Busqueda"
        Me.Text = "Búsqueda de Libros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BotonLimpiarBusquedaLibro As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BotonAgregarBusqueda As Button
    Friend WithEvents BotonCancelarBusqueda As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TBI As TextBox
End Class
