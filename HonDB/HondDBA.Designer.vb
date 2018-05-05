<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HondDBA
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HondDBA))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LVersion = New System.Windows.Forms.Label()
        Me.LCopy = New System.Windows.Forms.Label()
        Me.LCompania = New System.Windows.Forms.Label()
        Me.TBDes = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PBLogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 294)
        Me.Panel1.TabIndex = 0
        '
        'PBLogo
        '
        Me.PBLogo.Image = CType(resources.GetObject("PBLogo.Image"), System.Drawing.Image)
        Me.PBLogo.Location = New System.Drawing.Point(3, 3)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(289, 288)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(315, 15)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(48, 17)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Label1"
        '
        'LVersion
        '
        Me.LVersion.AutoSize = True
        Me.LVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVersion.Location = New System.Drawing.Point(315, 40)
        Me.LVersion.Name = "LVersion"
        Me.LVersion.Size = New System.Drawing.Size(46, 17)
        Me.LVersion.TabIndex = 2
        Me.LVersion.Text = "Label2"
        '
        'LCopy
        '
        Me.LCopy.AutoSize = True
        Me.LCopy.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCopy.Location = New System.Drawing.Point(315, 66)
        Me.LCopy.Name = "LCopy"
        Me.LCopy.Size = New System.Drawing.Size(46, 17)
        Me.LCopy.TabIndex = 3
        Me.LCopy.Text = "Label3"
        '
        'LCompania
        '
        Me.LCompania.AutoSize = True
        Me.LCompania.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCompania.Location = New System.Drawing.Point(315, 91)
        Me.LCompania.Name = "LCompania"
        Me.LCompania.Size = New System.Drawing.Size(46, 17)
        Me.LCompania.TabIndex = 4
        Me.LCompania.Text = "Label4"
        '
        'TBDes
        '
        Me.TBDes.Enabled = False
        Me.TBDes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDes.Location = New System.Drawing.Point(318, 111)
        Me.TBDes.Multiline = True
        Me.TBDes.Name = "TBDes"
        Me.TBDes.ReadOnly = True
        Me.TBDes.Size = New System.Drawing.Size(382, 163)
        Me.TBDes.TabIndex = 5
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(625, 283)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 6
        Me.OKButton.Text = "Aceptar"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'HondDBA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(712, 318)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TBDes)
        Me.Controls.Add(Me.LCompania)
        Me.Controls.Add(Me.LCopy)
        Me.Controls.Add(Me.LVersion)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HondDBA"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HondDBA"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LVersion As Label
    Friend WithEvents LCopy As Label
    Friend WithEvents LCompania As Label
    Friend WithEvents TBDes As TextBox
    Friend WithEvents OKButton As Button
End Class
