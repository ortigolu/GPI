Imports System.Data.SqlClient
Public Class frmDetalles
    Sub Resetear()
        txtNombreFacultad.Text = ""
        txtDescripcion.Text = ""
        txtDescripcion.Text = ""
        txtDireccion.Text = ""
        txtTefefono.Text = ""
        txtEmail.Text = ""
        txtNombreFacultad.Focus()
        btnGuardar.Enabled = True
        btnActualizar.Enabled = False
        btnBorrar.Enabled = False
        auto()
        GenerarDatos()


    End Sub

    Private Sub auto()
        Try
            Dim Num As Integer = 0
            conexion = New SqlConnection(cadenaconexion)
            conexion.Open()
            Dim sql As String = ("Select MAX(codFacultad) from Facultad")
            cmd = New SqlCommand(sql)
            cmd.Connection = conexion
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Num = 1
                txtFacultadID.Text = Num.ToString
            Else
                Num = cmd.ExecuteScalar + 1
                txtFacultadID.Text = Num.ToString
            End If
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GenerarDatos()
        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()
            cmd = New SqlCommand("SELECT codFacultad,RTRIM(NombreFacultad), RTRIM(Descripcion),RTRIM(Direccion),Telefono,RTRIM(Email) from Facultad order by codFacultad", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resetear()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cadenaconexion)
            con.Open()
            Dim cq As String = "delete from Facultad where codFacultad=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtFacultadID.Text))
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Borrado Exitosamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GenerarDatos()
                Resetear()
            Else
                MessageBox.Show("No se encontro el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Resetear()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Resetear()
    End Sub

    Private Sub txtBuscarPorNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPorNombre.TextChanged
        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()
            cmd = New SqlCommand("SELECT codFacultad,RTRIM(NombreFacultad), RTRIM(Descripcion),RTRIM(Direccion),Telefono,RTRIM(Email) from Facultad  where NombreFacultad like '%" & txtBuscarPorNombre.Text & "%' order by NombreFacultad", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Len(Trim(txtNombreFacultad.Text)) = 0 Then
            MessageBox.Show("Ingrese el nombre de la facultad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreFacultad.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDescripcion.Text)) = 0 Then
            MessageBox.Show("Ingrese la descripcion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDireccion.Text)) = 0 Then
            MessageBox.Show("Ingrese la direccion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccion.Focus()
            Exit Sub
        End If
        If txtTefefono.Text = "" Then
            MessageBox.Show("Ingrese el telefono", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTefefono.Focus()
            Return
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Ingrese el email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()
            Dim ct As String = "select NombreFacultad from Facultad where NombreFacultad=@d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtNombreFacultad.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("La facultad ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtNombreFacultad.Text = ""
                txtNombreFacultad.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            auto()
            con = New SqlConnection(cadenaconexion)
            con.Open()
            Dim cb As String = "insert into Facultad(codFacultad, NombreFacultad ,Descripcion ,Direccion ,Telefono ,Email) VALUES (" & Val(txtFacultadID.Text) & ",@d1,@d2,@d3,@d4,@d5)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtNombreFacultad.Text)
            cmd.Parameters.AddWithValue("@d2", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@d3", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@d4", txtTefefono.Text)
            cmd.Parameters.AddWithValue("@d5", txtEmail.Text)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Guardado Exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnGuardar.Enabled = False
            GenerarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Len(Trim(txtNombreFacultad.Text)) = 0 Then
            MessageBox.Show("Ingrese el nombre de la facultad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreFacultad.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDescripcion.Text)) = 0 Then
            MessageBox.Show("Ingrese la descripcion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDireccion.Text)) = 0 Then
            MessageBox.Show("Ingrese la direccion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDireccion.Focus()
            Exit Sub
        End If
        If txtTefefono.Text = "" Then
            MessageBox.Show("Ingrese el telefono", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTefefono.Focus()
            Return
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Ingrese el email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()
            Dim cb As String = "Update Facultad set NombreFacultad =@d1,Descripcion=@d2,Direccion= @d3,Telefono=@d4, Email = @d5 where codFacultad=" & Val(txtFacultadID.Text) & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtNombreFacultad.Text)
            cmd.Parameters.AddWithValue("@d2", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@d3", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@d4", txtTefefono.Text)
            cmd.Parameters.AddWithValue("@d5", txtEmail.Text)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Actualizado Exitosamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnActualizar.Enabled = False
            GenerarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            If dgw.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtFacultadID.Text = dr.Cells(0).Value.ToString()
                txtNombreFacultad.Text = dr.Cells(1).Value.ToString()
                txtDescripcion.Text = dr.Cells(2).Value.ToString()
                txtDireccion.Text = dr.Cells(3).Value.ToString()
                txtTefefono.Text = dr.Cells(4).Value.ToString()
                txtEmail.Text = dr.Cells(5).Value.ToString()
                btnActualizar.Enabled = True
                btnBorrar.Enabled = True
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
End Class