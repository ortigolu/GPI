<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtEmail = New TextBox()
        txtTefefono = New TextBox()
        txtDireccion = New TextBox()
        txtDescripcion = New TextBox()
        txtNombreFacultad = New TextBox()
        txtFacultadID = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        btnBorrar = New Button()
        btnActualizar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        GroupBox3 = New GroupBox()
        txtBuscarPorNombre = New TextBox()
        dgw = New DataGridView()
        FacultadID = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgw, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(-3, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(914, 32)
        Label1.TabIndex = 112
        Label1.Text = "Detalle de Facultades"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtTefefono)
        GroupBox1.Controls.Add(txtDireccion)
        GroupBox1.Controls.Add(txtDescripcion)
        GroupBox1.Controls.Add(txtNombreFacultad)
        GroupBox1.Controls.Add(txtFacultadID)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(13, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(529, 245)
        GroupBox1.TabIndex = 113
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de la Facultad"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(202, 207)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(321, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtTefefono
        ' 
        txtTefefono.Location = New Point(202, 171)
        txtTefefono.Name = "txtTefefono"
        txtTefefono.Size = New Size(100, 27)
        txtTefefono.TabIndex = 10
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(202, 138)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(321, 27)
        txtDireccion.TabIndex = 9
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(202, 105)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(321, 27)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtNombreFacultad
        ' 
        txtNombreFacultad.Location = New Point(202, 72)
        txtNombreFacultad.Name = "txtNombreFacultad"
        txtNombreFacultad.Size = New Size(321, 27)
        txtNombreFacultad.TabIndex = 7
        ' 
        ' txtFacultadID
        ' 
        txtFacultadID.Cursor = Cursors.IBeam
        txtFacultadID.Location = New Point(202, 39)
        txtFacultadID.Name = "txtFacultadID"
        txtFacultadID.ReadOnly = True
        txtFacultadID.Size = New Size(100, 27)
        txtFacultadID.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 20)
        Label7.TabIndex = 5
        Label7.Text = "Email :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 4
        Label5.Text = "Telefono :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 20)
        Label6.TabIndex = 3
        Label6.Text = "Direccion :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 2
        Label4.Text = "Descripcion :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 20)
        Label3.TabIndex = 1
        Label3.Text = "Nombre de la Facultad :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 0
        Label2.Text = "Facultad ID :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.Controls.Add(btnActualizar)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Location = New Point(572, 49)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(108, 198)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Location = New Point(9, 146)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(92, 40)
        btnBorrar.TabIndex = 3
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(9, 102)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(92, 40)
        btnActualizar.TabIndex = 2
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(9, 58)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(92, 40)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(9, 14)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(92, 40)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtBuscarPorNombre)
        GroupBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(17, 304)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(363, 72)
        GroupBox3.TabIndex = 114
        GroupBox3.TabStop = False
        GroupBox3.Text = "Buscar Por Nombre"
        ' 
        ' txtBuscarPorNombre
        ' 
        txtBuscarPorNombre.Location = New Point(22, 29)
        txtBuscarPorNombre.Name = "txtBuscarPorNombre"
        txtBuscarPorNombre.Size = New Size(194, 27)
        txtBuscarPorNombre.TabIndex = 0
        ' 
        ' dgw
        ' 
        dgw.AllowUserToAddRows = False
        dgw.AllowUserToDeleteRows = False
        dgw.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgw.BackgroundColor = Color.White
        dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgw.ColumnHeadersHeight = 45
        dgw.Columns.AddRange(New DataGridViewColumn() {FacultadID, Nombre, Descripcion, Direccion, Telefono, Email})
        dgw.EnableHeadersVisualStyles = False
        dgw.GridColor = Color.White
        dgw.Location = New Point(17, 382)
        dgw.MultiSelect = False
        dgw.Name = "dgw"
        dgw.ReadOnly = True
        dgw.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgw.RowTemplate.Height = 25
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgw.Size = New Size(878, 309)
        dgw.TabIndex = 115
        ' 
        ' FacultadID
        ' 
        FacultadID.HeaderText = "FacultadID"
        FacultadID.Name = "FacultadID"
        FacultadID.ReadOnly = True
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        ' 
        ' Descripcion
        ' 
        Descripcion.HeaderText = "Descripcion"
        Descripcion.Name = "Descripcion"
        Descripcion.ReadOnly = True
        ' 
        ' Direccion
        ' 
        Direccion.HeaderText = "Direccion"
        Direccion.Name = "Direccion"
        Direccion.ReadOnly = True
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.Name = "Telefono"
        Telefono.ReadOnly = True
        ' 
        ' Email
        ' 
        Email.HeaderText = "Email"
        Email.Name = "Email"
        Email.ReadOnly = True
        ' 
        ' frmDetalles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 655)
        Controls.Add(dgw)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "frmDetalles"
        Text = "Detalles de Facultades"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgw, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreFacultad As TextBox
    Friend WithEvents txtFacultadID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTefefono As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBuscarPorNombre As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents FacultadID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
End Class
