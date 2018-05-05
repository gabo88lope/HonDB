<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMsg
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
        Me.components = New System.ComponentModel.Container()
        Me.TBEx = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TBMensaje = New System.Windows.Forms.TextBox()
        Me.BDetalles = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.TBError = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBEx
        '
        Me.TBEx.Location = New System.Drawing.Point(12, 112)
        Me.TBEx.Multiline = True
        Me.TBEx.Name = "TBEx"
        Me.TBEx.ReadOnly = True
        Me.TBEx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBEx.Size = New System.Drawing.Size(469, 134)
        Me.TBEx.TabIndex = 0
        Me.TBEx.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TBMensaje
        '
        Me.TBMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBMensaje.Location = New System.Drawing.Point(12, 12)
        Me.TBMensaje.Multiline = True
        Me.TBMensaje.Name = "TBMensaje"
        Me.TBMensaje.ReadOnly = True
        Me.TBMensaje.Size = New System.Drawing.Size(469, 29)
        Me.TBMensaje.TabIndex = 2
        '
        'BDetalles
        '
        Me.BDetalles.Location = New System.Drawing.Point(12, 83)
        Me.BDetalles.Name = "BDetalles"
        Me.BDetalles.Size = New System.Drawing.Size(121, 23)
        Me.BDetalles.TabIndex = 3
        Me.BDetalles.Text = "Ver detalles >>>>"
        Me.BDetalles.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(414, 83)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(67, 23)
        Me.BAceptar.TabIndex = 4
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'TBError
        '
        Me.TBError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBError.Location = New System.Drawing.Point(12, 47)
        Me.TBError.Multiline = True
        Me.TBError.Name = "TBError"
        Me.TBError.ReadOnly = True
        Me.TBError.Size = New System.Drawing.Size(469, 30)
        Me.TBError.TabIndex = 5
        '
        'EMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.BAceptar
        Me.ClientSize = New System.Drawing.Size(493, 260)
        Me.Controls.Add(Me.TBError)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BDetalles)
        Me.Controls.Add(Me.TBMensaje)
        Me.Controls.Add(Me.TBEx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Error"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents TBEx As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TBMensaje As TextBox
    Friend WithEvents BDetalles As Button
    Friend WithEvents BAceptar As Button
    Friend WithEvents TBError As TextBox
End Class
