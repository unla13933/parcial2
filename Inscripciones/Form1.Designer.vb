<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosPorOrientaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinMateriasDesaprobadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Con1O2MateriasDesaprobadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.MostrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadisticasGeneralesToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'EstadisticasGeneralesToolStripMenuItem
        '
        Me.EstadisticasGeneralesToolStripMenuItem.Name = "EstadisticasGeneralesToolStripMenuItem"
        Me.EstadisticasGeneralesToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EstadisticasGeneralesToolStripMenuItem.Text = "Estadisticas Generales (A,B,C)"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosPorOrientaciónToolStripMenuItem, Me.TodosLosAlumnosToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.InformesToolStripMenuItem.Text = "Informes (D,E,F)"
        '
        'AlumnosPorOrientaciónToolStripMenuItem
        '
        Me.AlumnosPorOrientaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinMateriasDesaprobadasToolStripMenuItem, Me.Con1O2MateriasDesaprobadasToolStripMenuItem})
        Me.AlumnosPorOrientaciónToolStripMenuItem.Name = "AlumnosPorOrientaciónToolStripMenuItem"
        Me.AlumnosPorOrientaciónToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.AlumnosPorOrientaciónToolStripMenuItem.Text = "Alumnos por Orientación"
        '
        'SinMateriasDesaprobadasToolStripMenuItem
        '
        Me.SinMateriasDesaprobadasToolStripMenuItem.Name = "SinMateriasDesaprobadasToolStripMenuItem"
        Me.SinMateriasDesaprobadasToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SinMateriasDesaprobadasToolStripMenuItem.Text = "Sin materias desaprobadas (D)"
        '
        'Con1O2MateriasDesaprobadasToolStripMenuItem
        '
        Me.Con1O2MateriasDesaprobadasToolStripMenuItem.Name = "Con1O2MateriasDesaprobadasToolStripMenuItem"
        Me.Con1O2MateriasDesaprobadasToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.Con1O2MateriasDesaprobadasToolStripMenuItem.Text = "Con 1 o 2 materias desaprobadas (E)"
        '
        'TodosLosAlumnosToolStripMenuItem
        '
        Me.TodosLosAlumnosToolStripMenuItem.Name = "TodosLosAlumnosToolStripMenuItem"
        Me.TodosLosAlumnosToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.TodosLosAlumnosToolStripMenuItem.Text = "Todos los alumnos inscriptos (F)"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Inscripciones.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 445)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Inscripciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasGeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosPorOrientaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinMateriasDesaprobadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Con1O2MateriasDesaprobadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosLosAlumnosToolStripMenuItem As ToolStripMenuItem
End Class
