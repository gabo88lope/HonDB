<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HonDBSec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TCHonDB = New System.Windows.Forms.TabControl()
        Me.TPPrestamo = New System.Windows.Forms.TabPage()
        Me.TPBusqueda = New System.Windows.Forms.TabPage()
        Me.TPHistorial = New System.Windows.Forms.TabPage()
        Me.TPAdmin = New System.Windows.Forms.TabPage()
        Me.TPOpciones = New System.Windows.Forms.TabPage()
        Me.Panel2.SuspendLayout()
        Me.TCHonDB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 83)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TCHonDB)
        Me.Panel2.Location = New System.Drawing.Point(13, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 537)
        Me.Panel2.TabIndex = 1
        '
        'TCHonDB
        '
        Me.TCHonDB.Controls.Add(Me.TPPrestamo)
        Me.TCHonDB.Controls.Add(Me.TPBusqueda)
        Me.TCHonDB.Controls.Add(Me.TPHistorial)
        Me.TCHonDB.Controls.Add(Me.TPAdmin)
        Me.TCHonDB.Controls.Add(Me.TPOpciones)
        Me.TCHonDB.Location = New System.Drawing.Point(4, 3)
        Me.TCHonDB.Name = "TCHonDB"
        Me.TCHonDB.SelectedIndex = 0
        Me.TCHonDB.Size = New System.Drawing.Size(1279, 561)
        Me.TCHonDB.TabIndex = 0
        '
        'TPPrestamo
        '
        Me.TPPrestamo.Location = New System.Drawing.Point(4, 22)
        Me.TPPrestamo.Name = "TPPrestamo"
        Me.TPPrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPrestamo.Size = New System.Drawing.Size(1271, 535)
        Me.TPPrestamo.TabIndex = 0
        Me.TPPrestamo.Text = "Nuevo Préstamo"
        Me.TPPrestamo.UseVisualStyleBackColor = True
        '
        'TPBusqueda
        '
        Me.TPBusqueda.Location = New System.Drawing.Point(4, 22)
        Me.TPBusqueda.Name = "TPBusqueda"
        Me.TPBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.TPBusqueda.Size = New System.Drawing.Size(1271, 535)
        Me.TPBusqueda.TabIndex = 1
        Me.TPBusqueda.Text = "Búsqueda de Libro"
        Me.TPBusqueda.UseVisualStyleBackColor = True
        '
        'TPHistorial
        '
        Me.TPHistorial.Location = New System.Drawing.Point(4, 22)
        Me.TPHistorial.Name = "TPHistorial"
        Me.TPHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.TPHistorial.Size = New System.Drawing.Size(1271, 535)
        Me.TPHistorial.TabIndex = 2
        Me.TPHistorial.Text = "Historial de Préstamos"
        Me.TPHistorial.UseVisualStyleBackColor = True
        '
        'TPAdmin
        '
        Me.TPAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, CType(0, Byte))
        Me.TPAdmin.Location = New System.Drawing.Point(4, 22)
        Me.TPAdmin.Name = "TPAdmin"
        Me.TPAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.TPAdmin.Size = New System.Drawing.Size(1271, 535)
        Me.TPAdmin.TabIndex = 3
        Me.TPAdmin.Text = "Administración"
        Me.TPAdmin.UseVisualStyleBackColor = True
        '
        'TPOpciones
        '
        Me.TPOpciones.Location = New System.Drawing.Point(4, 22)
        Me.TPOpciones.Name = "TPOpciones"
        Me.TPOpciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TPOpciones.Size = New System.Drawing.Size(1271, 535)
        Me.TPOpciones.TabIndex = 4
        Me.TPOpciones.Text = "Opciones"
        Me.TPOpciones.UseVisualStyleBackColor = True
        '
        'HonDBSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HonDBSec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.TCHonDB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TCHonDB As TabControl
    Friend WithEvents TPPrestamo As TabPage
    Friend WithEvents TPBusqueda As TabPage
    Friend WithEvents TPHistorial As TabPage
    Friend WithEvents TPAdmin As TabPage
    Friend WithEvents TPOpciones As TabPage
End Class
