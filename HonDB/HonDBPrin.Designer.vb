<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HonDBPrin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HonDBPrin))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSLTiempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BAcercaDe = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BRegistro = New System.Windows.Forms.Button()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.BReporte = New System.Windows.Forms.Button()
        Me.BAdministrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLTiempo})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'TSSLTiempo
        '
        Me.TSSLTiempo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSSLTiempo.Name = "TSSLTiempo"
        resources.ApplyResources(Me.TSSLTiempo, "TSSLTiempo")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BAcercaDe
        '
        Me.BAcercaDe.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonAcercade
        resources.ApplyResources(Me.BAcercaDe, "BAcercaDe")
        Me.BAcercaDe.Name = "BAcercaDe"
        Me.BAcercaDe.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonSalir
        resources.ApplyResources(Me.BSalir, "BSalir")
        Me.BSalir.Name = "BSalir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BRegistro
        '
        Me.BRegistro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BRegistro.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonRegistros03
        resources.ApplyResources(Me.BRegistro, "BRegistro")
        Me.BRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BRegistro.Name = "BRegistro"
        Me.BRegistro.UseVisualStyleBackColor = False
        '
        'BBusqueda
        '
        Me.BBusqueda.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonBusqueda03
        resources.ApplyResources(Me.BBusqueda, "BBusqueda")
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'BReporte
        '
        Me.BReporte.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonReportes04
        resources.ApplyResources(Me.BReporte, "BReporte")
        Me.BReporte.Name = "BReporte"
        Me.BReporte.UseVisualStyleBackColor = True
        '
        'BAdministrar
        '
        Me.BAdministrar.BackgroundImage = Global.HonDB.My.Resources.Resources.BotonAdministrar03
        resources.ApplyResources(Me.BAdministrar, "BAdministrar")
        Me.BAdministrar.Name = "BAdministrar"
        Me.BAdministrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BAcercaDe)
        Me.Panel3.Controls.Add(Me.BSalir)
        Me.Panel3.Controls.Add(Me.BAdministrar)
        Me.Panel3.Controls.Add(Me.BReporte)
        Me.Panel3.Controls.Add(Me.BBusqueda)
        Me.Panel3.Controls.Add(Me.BRegistro)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'HonDBPrin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HonDBPrin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSLTiempo As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BRegistro As Button
    Friend WithEvents BBusqueda As Button
    Friend WithEvents BAdministrar As Button
    Friend WithEvents BReporte As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BAcercaDe As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents Panel3 As Panel
End Class
