<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbOrientacion = New System.Windows.Forms.ComboBox()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtDesaprobadas = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDesMas2 = New System.Windows.Forms.TextBox()
        Me.txtDesCon2 = New System.Windows.Forms.TextBox()
        Me.txtSinDesaprobar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtComu = New System.Windows.Forms.TextBox()
        Me.txtSociales = New System.Windows.Forms.TextBox()
        Me.txtEconomia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalInscriptos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LstAlumnos = New System.Windows.Forms.ListBox()
        Me.rbnCon2 = New System.Windows.Forms.RadioButton()
        Me.rbnHasta2 = New System.Windows.Forms.RadioButton()
        Me.rbnSinDes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        CType(Me.txtDesaprobadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Orientación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Materias Desaprobadas"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(210, 160)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(184, 27)
        Me.txtApellido.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(210, 193)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 27)
        Me.txtNombre.TabIndex = 3
        '
        'cmbOrientacion
        '
        Me.cmbOrientacion.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.cmbOrientacion.FormattingEnabled = True
        Me.cmbOrientacion.Items.AddRange(New Object() {"Comunicaciones", "Economía y Administración", "Sociales"})
        Me.cmbOrientacion.Location = New System.Drawing.Point(210, 226)
        Me.cmbOrientacion.Name = "cmbOrientacion"
        Me.cmbOrientacion.Size = New System.Drawing.Size(230, 27)
        Me.cmbOrientacion.TabIndex = 4
        '
        'txtLegajo
        '
        Me.txtLegajo.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLegajo.Location = New System.Drawing.Point(210, 127)
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(184, 27)
        Me.txtLegajo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Legajo"
        '
        'btnModificar
        '
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(87, 14)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 86)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 86)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Tag = ""
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(380, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(74, 87)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(168, 14)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 86)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.Location = New System.Drawing.Point(122, 304)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(75, 86)
        Me.btnPrimero.TabIndex = 6
        Me.btnPrimero.Tag = ""
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrimero.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(203, 304)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 86)
        Me.btnAnterior.TabIndex = 7
        Me.btnAnterior.Tag = ""
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(284, 304)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 86)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Tag = "Agregar"
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnUltimo
        '
        Me.btnUltimo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(365, 304)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 86)
        Me.btnUltimo.TabIndex = 9
        Me.btnUltimo.Tag = "Agregar"
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(972, 503)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 86)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.Tag = ""
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtDesaprobadas
        '
        Me.txtDesaprobadas.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.txtDesaprobadas.Location = New System.Drawing.Point(210, 262)
        Me.txtDesaprobadas.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtDesaprobadas.Name = "txtDesaprobadas"
        Me.txtDesaprobadas.Size = New System.Drawing.Size(41, 27)
        Me.txtDesaprobadas.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(460, 13)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 87)
        Me.btnGuardar.TabIndex = 53
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.txtDesMas2)
        Me.GroupBox1.Controls.Add(Me.txtDesCon2)
        Me.GroupBox1.Controls.Add(Me.txtSinDesaprobar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtComu)
        Me.GroupBox1.Controls.Add(Me.txtSociales)
        Me.GroupBox1.Controls.Add(Me.txtEconomia)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotalInscriptos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 427)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 162)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'txtDesMas2
        '
        Me.txtDesMas2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDesMas2.Enabled = False
        Me.txtDesMas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesMas2.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDesMas2.Location = New System.Drawing.Point(332, 131)
        Me.txtDesMas2.Name = "txtDesMas2"
        Me.txtDesMas2.Size = New System.Drawing.Size(63, 22)
        Me.txtDesMas2.TabIndex = 14
        '
        'txtDesCon2
        '
        Me.txtDesCon2.BackColor = System.Drawing.Color.Yellow
        Me.txtDesCon2.Enabled = False
        Me.txtDesCon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesCon2.Location = New System.Drawing.Point(332, 107)
        Me.txtDesCon2.Name = "txtDesCon2"
        Me.txtDesCon2.Size = New System.Drawing.Size(63, 22)
        Me.txtDesCon2.TabIndex = 13
        '
        'txtSinDesaprobar
        '
        Me.txtSinDesaprobar.BackColor = System.Drawing.Color.GreenYellow
        Me.txtSinDesaprobar.Enabled = False
        Me.txtSinDesaprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinDesaprobar.Location = New System.Drawing.Point(303, 83)
        Me.txtSinDesaprobar.Name = "txtSinDesaprobar"
        Me.txtSinDesaprobar.Size = New System.Drawing.Size(63, 22)
        Me.txtSinDesaprobar.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(317, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Cantidad de alumnos inscriptos con más de 2 materias sin aprobar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(316, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cantidad de alumnos inscriptos con 1 o 2  materias desaprobadas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(281, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cantidad de alumnos inscriptos sin materias desaprobadas"
        '
        'txtComu
        '
        Me.txtComu.Enabled = False
        Me.txtComu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComu.Location = New System.Drawing.Point(332, 59)
        Me.txtComu.Name = "txtComu"
        Me.txtComu.Size = New System.Drawing.Size(63, 22)
        Me.txtComu.TabIndex = 8
        '
        'txtSociales
        '
        Me.txtSociales.Enabled = False
        Me.txtSociales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSociales.Location = New System.Drawing.Point(464, 59)
        Me.txtSociales.Name = "txtSociales"
        Me.txtSociales.Size = New System.Drawing.Size(63, 22)
        Me.txtSociales.TabIndex = 7
        '
        'txtEconomia
        '
        Me.txtEconomia.Enabled = False
        Me.txtEconomia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEconomia.Location = New System.Drawing.Point(162, 59)
        Me.txtEconomia.Name = "txtEconomia"
        Me.txtEconomia.Size = New System.Drawing.Size(63, 22)
        Me.txtEconomia.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Comunicaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(411, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sociales"
        '
        'txtTotalInscriptos
        '
        Me.txtTotalInscriptos.Enabled = False
        Me.txtTotalInscriptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalInscriptos.Location = New System.Drawing.Point(175, 17)
        Me.txtTotalInscriptos.Name = "txtTotalInscriptos"
        Me.txtTotalInscriptos.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalInscriptos.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Economía y Administración"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cantidad de alumnos inscriptos por orientacion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cantidad de alumnos inscriptos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 411)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'LstAlumnos
        '
        Me.LstAlumnos.FormattingEnabled = True
        Me.LstAlumnos.Location = New System.Drawing.Point(6, 117)
        Me.LstAlumnos.Name = "LstAlumnos"
        Me.LstAlumnos.Size = New System.Drawing.Size(470, 316)
        Me.LstAlumnos.TabIndex = 56
        '
        'rbnCon2
        '
        Me.rbnCon2.AutoSize = True
        Me.rbnCon2.Location = New System.Drawing.Point(79, 60)
        Me.rbnCon2.Name = "rbnCon2"
        Me.rbnCon2.Size = New System.Drawing.Size(225, 17)
        Me.rbnCon2.TabIndex = 57
        Me.rbnCon2.TabStop = True
        Me.rbnCon2.Text = "Alumnos con 1 o 2 materias desaprobadas"
        Me.rbnCon2.UseVisualStyleBackColor = True
        '
        'rbnHasta2
        '
        Me.rbnHasta2.AutoSize = True
        Me.rbnHasta2.Location = New System.Drawing.Point(79, 83)
        Me.rbnHasta2.Name = "rbnHasta2"
        Me.rbnHasta2.Size = New System.Drawing.Size(236, 17)
        Me.rbnHasta2.TabIndex = 58
        Me.rbnHasta2.TabStop = True
        Me.rbnHasta2.Text = "Alumnos con hasta 2 materias desaprobadas"
        Me.rbnHasta2.UseVisualStyleBackColor = True
        '
        'rbnSinDes
        '
        Me.rbnSinDes.AutoSize = True
        Me.rbnSinDes.Location = New System.Drawing.Point(79, 37)
        Me.rbnSinDes.Name = "rbnSinDes"
        Me.rbnSinDes.Size = New System.Drawing.Size(193, 17)
        Me.rbnSinDes.TabIndex = 59
        Me.rbnSinDes.TabStop = True
        Me.rbnSinDes.Text = "Alumnos sin materias desaprobadas"
        Me.rbnSinDes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox3.Controls.Add(Me.LstAlumnos)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btnMostrar)
        Me.GroupBox3.Controls.Add(Me.rbnSinDes)
        Me.GroupBox3.Controls.Add(Me.rbnHasta2)
        Me.GroupBox3.Controls.Add(Me.rbnCon2)
        Me.GroupBox3.Location = New System.Drawing.Point(564, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(483, 440)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 20)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Mostrar"
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.Location = New System.Drawing.Point(349, 37)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 62)
        Me.btnMostrar.TabIndex = 60
        Me.btnMostrar.Text = "Button1"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDesaprobadas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.cmbOrientacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscripción de Alumnos"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.txtDesaprobadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbOrientacion As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtLegajo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtDesaprobadas As NumericUpDown
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalInscriptos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtComu As TextBox
    Friend WithEvents txtSociales As TextBox
    Friend WithEvents txtEconomia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDesMas2 As TextBox
    Friend WithEvents txtDesCon2 As TextBox
    Friend WithEvents txtSinDesaprobar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LstAlumnos As ListBox
    Friend WithEvents rbnCon2 As RadioButton
    Friend WithEvents rbnHasta2 As RadioButton
    Friend WithEvents rbnSinDes As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Label14 As Label
End Class
