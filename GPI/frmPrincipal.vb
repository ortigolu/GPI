Public Class frmPrincipal




    Private Sub DetallesDeFacultadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeFacultadesToolStripMenuItem.Click
        Dim frm As New frmDetalles
        frm.MdiParent = Me
        frmDetalles.Show()
    End Sub

    Private Sub DetallesDeMateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesDeMateriasToolStripMenuItem.Click
        Dim frm As New frmMateria
        frm.MdiParent = Me
        frmMateria.Show()
    End Sub
End Class
