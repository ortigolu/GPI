Imports System.Data.SqlClient

Public Class frmMateria
    Sub Resetear()
        txtNombreMateria.Text = ""
        txtDescripcion.Text = ""
        cmbFacultad.Text = ""
        txtNombreMateria.Focus()
        btnGuardar.Enabled = True
        btnActualizar.Enabled = False
        btnBorrar.Enabled = False
        auto()
        GenerarDatos()
    End Sub

    Public Sub GenerarDatos()
        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()
            cmd = New SqlCommand("SELECT codMateria,RTRIM(nombreMateria), RTRIM(a.descripcion),RTRIM(b.NombreFacultad) from Materia a, Facultad b where a.codFacultad = b.codFacultad  order by codMateria", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub auto()
        Try
            Dim Num As Integer = 0
            conexion = New SqlConnection(cadenaconexion)
            conexion.Open()
            Dim sql As String = ("Select MAX(codMateria) from Materia")
            cmd = New SqlCommand(sql)
            cmd.Connection = conexion
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Num = 1
                txtMateriaID.Text = Num.ToString
            Else
                Num = cmd.ExecuteScalar + 1
                txtMateriaID.Text = Num.ToString
            End If
            Dim combo As String = "SELECT codFacultad, nombreFacultad FROM Facultad ORDER BY codFacultad ASC"
            Dim adapter As New SqlDataAdapter(combo, conexion)
            Dim dt As New DataTable

            Try
                ' Fill the DataTable with data from the database
                adapter.Fill(dt)

                ' Bind the DataTable to the ComboBox
                With cmbFacultad
                    .ValueMember = "codFacultad"
                    .DisplayMember = "nombreFacultad"
                    .DataSource = dt
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Dispose of resources
                adapter.Dispose()
            End Try


            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resetear()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cadenaconexion)
            con.Open()
            Dim cq As String = "delete from Materia where codMateria=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtMateriaID.Text))
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Len(Trim(txtNombreMateria.Text)) = 0 Then
            MessageBox.Show("Ingrese el nombre de la Materia", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreMateria.Focus()
            Exit Sub
        End If
        If Len(Trim(txtDescripcion.Text)) = 0 Then
            MessageBox.Show("Ingrese la descripcion", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbFacultad.Text)) = 0 Then
            MessageBox.Show("Seleccione una Facultad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFacultad.Focus()
            Exit Sub
        End If

        ''This is the new code

        If Len(Trim(cmbFacultad.Text)) = 0 Then
            MessageBox.Show("Seleccione una Facultad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbFacultad.Focus()
            Exit Sub
        End If

        Try
            con = New SqlConnection(cadenaconexion)
            con.Open()

            ' Check if the Materia already exists
            Dim ct As String = "SELECT nombreMateria FROM Materia WHERE nombreMateria = @d1"
            cmd = New SqlCommand(ct, con)
            cmd.Parameters.AddWithValue("@d1", txtNombreMateria.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("La Materia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtNombreMateria.Text = ""
                txtNombreMateria.Focus()
                rdr.Close()
                Return
            End If
            ''New code to close the rdr
            rdr.Close()


            ' Auto-generate Materia ID
            auto()

            ' Set up the INSERT query
            Dim cb As String = "INSERT INTO Materia (codMateria, nombreMateria, Descripcion, codFacultad) VALUES (@d1, @d2, @d3, @d4)"
            cmd = New SqlCommand(cb, con)

            ' Set the parameters
            cmd.Parameters.AddWithValue("@d1", Val(txtMateriaID.Text))
            cmd.Parameters.AddWithValue("@d2", txtNombreMateria.Text)
            cmd.Parameters.AddWithValue("@d3", txtDescripcion.Text)

            ' Extract the selected value from the DataRowView (for cmbFacultad)
            Dim selectedFacultad As DataRowView = DirectCast(cmbFacultad.SelectedItem, DataRowView)

            If selectedFacultad IsNot Nothing Then
                ' Set the parameter using the extracted value from the DataRowView object
                cmd.Parameters.AddWithValue("@d4", selectedFacultad("codFacultad"))
            Else
                ' Handle the case where nothing is selected
                MessageBox.Show("Seleccione una Facultad válida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbFacultad.Focus()
                con.Close()
                Return
            End If
            ' Execute the INSERT query
            cmd.ExecuteNonQuery()

            ' Close the connection
            con.Close()

            MessageBox.Show("Guardado Exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnGuardar.Enabled = False
            GenerarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            If dgw.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtMateriaID.Text = dr.Cells(0).Value.ToString()
                txtNombreMateria.Text = dr.Cells(1).Value.ToString()
                txtDescripcion.Text = dr.Cells(2).Value.ToString()
                cmbFacultad.Text = dr.Cells(3).Value.ToString()
                btnActualizar.Enabled = True
                btnBorrar.Enabled = True
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class