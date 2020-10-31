Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        Dim ventana As New frmAlumnos
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
End Class
