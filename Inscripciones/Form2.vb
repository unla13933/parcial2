Public Class frmAlumnos
    Private RegistroActual As Single, Opcion As Byte
    Private miConexion As New OleDb.OleDbConnection, miAdapter As OleDb.OleDbDataAdapter,
            miComandoABM As OleDb.OleDbCommandBuilder, miDataSet As New DataSet
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cambiar(True)
        btnPrimero_Click(sender, e)
        btnSalir.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Cambiar(False)
        inicializar()
        Opcion = 1

    End Sub

    Private Sub txtLegajo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLegajo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtApellido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApellido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbOrientacion.Focus()
        End If
    End Sub

    Private Sub cmbOrientacion_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbOrientacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDesaprobadas.Focus()
        End If
    End Sub

    Private Sub cmbOrientacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrientacion.SelectedIndexChanged
        txtDesaprobadas.Focus()
    End Sub

    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion.ConnectionString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\colegio.mdb"
        miConexion.Open()
        miAdapter = New OleDb.OleDbDataAdapter("select * from INSCRIPCIONES order by LEGAJO ASC", miConexion)
        miAdapter.Fill(miDataSet, "dtInscripciones")
        miComandoABM = New OleDb.OleDbCommandBuilder(miAdapter)
        miConexion.Close()
        Cambiar(True)
        btnPrimero_Click(sender, e)
        carga_estadistica()
    End Sub
    Private Sub cargar(ByVal Nregistro As Single)
        txtLegajo.Text = miDataSet.Tables("dtInscripciones").Rows(Nregistro).Item("legajo").ToString
        txtApellido.Text = miDataSet.Tables("dtInscripciones").Rows(Nregistro).Item("apellido").ToString
        txtNombre.Text = miDataSet.Tables("dtInscripciones").Rows(Nregistro).Item("nombre").ToString
        cmbOrientacion.Text = miDataSet.Tables("dtInscripciones").Rows(Nregistro).Item("orientacion").ToString
        txtDesaprobadas.Text = miDataSet.Tables("dtInscripciones").Rows(Nregistro).Item("desaprobadas").ToString
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        RegistroActual = 0
        cargar(RegistroActual)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If RegistroActual > 0 Then
            RegistroActual -= 1
            cargar(RegistroActual)
        Else
            MsgBox("No hay mas registros antes de este ....", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If RegistroActual < miDataSet.Tables("dtInscripciones").Rows.Count - 1 Then
            RegistroActual += 1
            cargar(RegistroActual)
        Else
            MsgBox("No hay mas registros ....", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        RegistroActual = miDataSet.Tables("dtInscripciones").Rows.Count - 1
        cargar(RegistroActual)
    End Sub
    Private Sub carga_estadistica()
        Dim posicion As Integer
        Dim total_inscriptos As Single = 0
        Dim total_eco_y_adm As Single = 0
        Dim total_comu As Single = 0
        Dim total_sociales As Single = 0
        Dim total_sin_desaprobadas As Single = 0
        Dim total_con2_desaprobadas As Single = 0
        Dim total_mas2_desaprobadas As Single = 0
        Dim aux_des As Single = 0
        Dim orientacion As String = ""


        Do While posicion < miDataSet.Tables("dtInscripciones").Rows.Count
            total_inscriptos = miDataSet.Tables("dtInscripciones").Rows.Count

            'si el campo orientacion del registro actual contiene la orientacion Comunicaciones incrementa el contador
            orientacion = miDataSet.Tables("dtInscripciones").Rows(posicion).Item("orientacion")

            If orientacion = "Comunicaciones" Then
                total_comu += 1
            End If
            'si el campo orientacion del registro actual contiene la orientacion Economia y Administración incrementa el contador
            If orientacion = "Economía y Administración" Then
                total_eco_y_adm += 1
            End If
            'si el campo orientacion del registro actual contiene la orientacion Sociales incrementa el contador
            If orientacion = "Sociales" Then
                total_sociales += 1
            End If





            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(posicion).Item("desaprobadas"))
            If aux_des = 0 Then
                total_sin_desaprobadas += 1
            ElseIf (aux_des <= 2 And aux_des > 0) Then
                total_con2_desaprobadas += 1
            ElseIf aux_des > 2 Then
                total_mas2_desaprobadas += 1
            End If
            posicion += 1
        Loop
        txtTotalInscriptos.Text = total_inscriptos
        txtEconomia.Text = total_eco_y_adm
        txtComu.Text = total_comu
        txtSociales.Text = total_sociales
        txtSinDesaprobar.Text = total_sin_desaprobadas
        txtDesCon2.Text = total_con2_desaprobadas
        txtDesMas2.Text = total_mas2_desaprobadas







    End Sub
    Private Sub Cambiar(ByVal Cambio As Boolean)
        btnAgregar.Enabled = Cambio
        btnModificar.Enabled = Cambio
        btnEliminar.Enabled = Cambio
        btnPrimero.Enabled = Cambio
        btnAnterior.Enabled = Cambio
        btnSiguiente.Enabled = Cambio
        btnUltimo.Enabled = Cambio

        txtLegajo.Enabled = Not Cambio
        txtApellido.Enabled = Not Cambio
        txtNombre.Enabled = Not Cambio
        cmbOrientacion.Enabled = Not Cambio
        txtDesaprobadas.Enabled = Not Cambio
        btnGuardar.Enabled = Not Cambio
        btnCancelar.Enabled = Not Cambio
    End Sub
    Private Function busca_legajo(ByVal legajo_a_buscar As Single) As Boolean
        Dim i As Integer
        Dim legajo As Single
        Dim resultado As Boolean = False
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            MsgBox(legajo & "" & legajo_a_buscar, MsgBoxStyle.Exclamation)
            If legajo = legajo_a_buscar Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function validar_datos() As Boolean
        If txtApellido.Text <> "" And txtNombre.Text <> "" And cmbOrientacion.Text <> "" And IsNumeric(txtLegajo.Text) Then
            Return True
        Else
            MsgBox("Debe llenar correctamente los campos", MsgBoxStyle.Exclamation)
            Return False
        End If
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Registro As DataRow
        Dim datos_validos As Boolean = False
        datos_validos = validar_datos()
        If Opcion = 1 And datos_validos = True Then
            Registro = miDataSet.Tables("dtInscripciones").NewRow()
            Registro("legajo") = txtLegajo.Text
            Registro("apellido") = txtApellido.Text
            Registro("nombre") = txtNombre.Text
            Registro("orientacion") = cmbOrientacion.Text
            Registro("desaprobadas") = txtDesaprobadas.Value
            If busca_legajo(txtLegajo.Text) = False Then
                miDataSet.Tables("dtInscripciones").Rows.Add(Registro)
            Else
                MsgBox("Ese legajo ya existe....", MsgBoxStyle.Exclamation)
            End If

        ElseIf Opcion = 2 And datos_validos = True Then
            Registro = miDataSet.Tables("dtInscripciones").Rows(RegistroActual)
            Registro("legajo") = txtLegajo.Text
            Registro("apellido") = txtApellido.Text
            Registro("nombre") = txtNombre.Text
            Registro("orientacion") = cmbOrientacion.Text
            Registro("desaprobadas") = txtDesaprobadas.Value
        End If

        miConexion.Open()
        miAdapter.Update(miDataSet.Tables("dtInscripciones"))
        miConexion.Close()

        Cambiar(True)
        btnPrimero_Click(sender, e)
        carga_estadistica()
        LstAlumnos.Items.Clear()
        btnSalir.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As DialogResult = MessageBox.Show("Está seguro que desea borrar este registro?",
                                                      "Advertencia!!!",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta.ToString = "Yes" Then
            Dim registro As DataRow
            registro = miDataSet.Tables("dtInscripciones").Rows(RegistroActual)
            registro.Delete()

            miConexion.Open()
            Me.miAdapter.Update(Me.miDataSet.Tables("dtInscripciones"))
            miConexion.Close()
        Else
            MsgBox("Eliminacion cancelada ...", MsgBoxStyle.Exclamation, "Mensaje")
        End If

        carga_estadistica()
        btnPrimero_Click(sender, e)
    End Sub
    Private Sub mostrarSinMaterias()
        Dim i As Integer
        Dim orientacion As String = ""
        Dim aux_des As Single
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Comunicaciones" And aux_des = 0 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Economía y Administración" And aux_des = 0 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Sociales" And aux_des = 0 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
    End Sub
    Private Sub mostrarCon2Materias()
        Dim i As Integer
        Dim orientacion As String = ""
        Dim aux_des As Single
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Comunicaciones" And aux_des > 0 And aux_des <= 2 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1

            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Economía y Administración" And aux_des > 0 And aux_des <= 2 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            orientacion = miDataSet.Tables("dtInscripciones").Rows(i).Item("orientacion")
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If orientacion = "Sociales" And aux_des > 0 And aux_des <= 2 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
    End Sub
    Private Sub mostrarHasta2Materias()
        Dim i As Integer
        Dim aux_des As Single
        For i = 0 To miDataSet.Tables(0).Rows.Count - 1
            aux_des = Int(miDataSet.Tables("dtInscripciones").Rows(i).Item("desaprobadas"))
            If aux_des >= 0 And aux_des <= 2 Then
                LstAlumnos.Items.Add(miDataSet.Tables("dtInscripciones").Rows(i).Item("legajo") & " - " & miDataSet.Tables("dtInscripciones").Rows(i).Item("Apellido") & ", " & miDataSet.Tables("dtInscripciones").Rows(i).Item("nombre"))
            End If
        Next
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        LstAlumnos.Items.Clear()
        If rbnSinDes.Checked = True Then
            mostrarSinMaterias()
        ElseIf rbnCon2.Checked = True Then
            mostrarCon2Materias()
        ElseIf rbnHasta2.Checked = True Then
            mostrarHasta2Materias()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Cambiar(False)
        Opcion = 2
        txtLegajo.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtDesaprobadas_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtDesaprobadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar.Focus()
        End If
    End Sub
    Private Sub inicializar()
        txtLegajo.Text = ""
        txtApellido.Text = ""
        txtNombre.Text = ""
        cmbOrientacion.Text = ""
        txtDesaprobadas.Value = 0
        txtLegajo.Focus()
    End Sub
End Class