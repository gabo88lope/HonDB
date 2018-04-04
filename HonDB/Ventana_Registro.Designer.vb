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
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.BookLogo = New System.Windows.Forms.PictureBox()
        Me.RetornoIcon = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
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
        Me.RetornoIcon.Location = New System.Drawing.Point(7, 10)
        Me.RetornoIcon.Name = "RetornoIcon"
        Me.RetornoIcon.Size = New System.Drawing.Size(57, 50)
        Me.RetornoIcon.TabIndex = 1
        Me.RetornoIcon.TabStop = False
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
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1366, 70)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RectangleShape2.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(70, 69)
        '
        'Ventana_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.BookLogo)
        Me.Controls.Add(Me.LabelLogo)
        Me.Controls.Add(Me.RetornoIcon)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Ventana_Registro"
        Me.Text = "Ventana_Registro"
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
End Class
