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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Registro As DataRow
        If Opcion = 1 Then
            Registro = miDataSet.Tables("dtInscripciones").NewRow()
            Registro("legajo") = txtLegajo.Text
            Registro("apellido") = txtApellido.Text
            Registro("nombre") = txtNombre.Text
            Registro("orientacion") = cmbOrientacion.Text
            Registro("desaprobadas") = txtDesaprobadas.Value

            miDataSet.Tables("dtInscripciones").Rows.Add(Registro)
        Else
            Registro = miDataSet.Tables("dtInscripciones").Rows(RegistroActual)
            Registro("legajo") = txtLegajo.Text
            Registro("apellido") = txtApellido.Text
            Registro("nombre") = txtNombre.Text
            Registro("orientacion") = cmbOrientacion.Text
            Registro("desaprobadas") = txtDesaprobadas.Value
        End If

        miConexion.Open()
        Me.miAdapter.Update(Me.miDataSet.Tables("dtInscripciones"))
        miConexion.Close()

        Cambiar(True)
        btnPrimero_Click(sender, e)
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



        btnPrimero_Click(sender, e)
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