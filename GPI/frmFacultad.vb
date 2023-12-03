Public Class frmFacultad
    Dim InstruccionSQL As String
    Dim dtFacultad As New DataTable

    Private Sub frmFacultad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = cadenaconexion
        CargarGrillaFacultad()
    End Sub
    Sub CargarGrillaFacultad()
        Try
            dtFacultad = generar_datatabla("select h.codFacultad as 'Codigo Facultad', h.NombreFacultad as 'Nombre Facultad', h.Descripcion , h.Direccion , h.Telefono, h.Email from Facultad h")
            dvgFacultad.DataSource = dtFacultad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dvgFacultad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgFacultad.CellContentClick

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class