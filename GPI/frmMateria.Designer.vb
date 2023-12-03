<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateria
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
        cmbFacultad = New ComboBox()
        txtDescripcion = New TextBox()
        txtNombreMateria = New TextBox()
        txtMateriaID = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        txtBuscarPorNombre = New TextBox()
        GroupBox2 = New GroupBox()
        btnBorrar = New Button()
        btnActualizar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        dgw = New DataGridView()
        MateriaID = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        Facultad = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgw, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(914, 32)
        Label1.TabIndex = 113
        Label1.Text = "Detalle de Materias"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbFacultad)
        GroupBox1.Controls.Add(txtDescripcion)
        GroupBox1.Controls.Add(txtNombreMateria)
        GroupBox1.Controls.Add(txtMateriaID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(13, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(529, 180)
        GroupBox1.TabIndex = 114
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de la Materia"
        ' 
        ' cmbFacultad
        ' 
        cmbFacultad.FormattingEnabled = True
        cmbFacultad.Location = New Point(202, 138)
        cmbFacultad.Name = "cmbFacultad"
        cmbFacultad.Size = New Size(321, 28)
        cmbFacultad.TabIndex = 10
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(202, 105)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(321, 27)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtNombreMateria
        ' 
        txtNombreMateria.Location = New Point(202, 72)
        txtNombreMateria.Name = "txtNombreMateria"
        txtNombreMateria.Size = New Size(321, 27)
        txtNombreMateria.TabIndex = 7
        ' 
        ' txtMateriaID
        ' 
        txtMateriaID.Cursor = Cursors.IBeam
        txtMateriaID.Location = New Point(202, 39)
        txtMateriaID.Name = "txtMateriaID"
        txtMateriaID.ReadOnly = True
        txtMateriaID.Size = New Size(100, 27)
        txtMateriaID.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 20)
        Label6.TabIndex = 3
        Label6.Text = "Facultad :"
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
        Label3.Size = New Size(168, 20)
        Label3.TabIndex = 1
        Label3.Text = "Nombre de la Materia :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 0
        Label2.Text = "Materia ID :"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtBuscarPorNombre)
        GroupBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(13, 231)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(363, 72)
        GroupBox3.TabIndex = 115
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.Controls.Add(btnActualizar)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Location = New Point(572, 49)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(108, 198)
        GroupBox2.TabIndex = 116
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
        dgw.Columns.AddRange(New DataGridViewColumn() {MateriaID, Nombre, Descripcion, Facultad})
        dgw.EnableHeadersVisualStyles = False
        dgw.GridColor = Color.White
        dgw.Location = New Point(12, 309)
        dgw.MultiSelect = False
        dgw.Name = "dgw"
        dgw.ReadOnly = True
        dgw.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgw.RowTemplate.Height = 25
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgw.Size = New Size(878, 309)
        dgw.TabIndex = 117
        ' 
        ' MateriaID
        ' 
        MateriaID.HeaderText = "MateriaID"
        MateriaID.Name = "MateriaID"
        MateriaID.ReadOnly = True
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
        ' Facultad
        ' 
        Facultad.HeaderText = "Facultad"
        Facultad.Name = "Facultad"
        Facultad.ReadOnly = True
        ' 
        ' frmMateria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 655)
        Controls.Add(dgw)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "frmMateria"
        Text = "Detalles de Materias"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgw, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreMateria As TextBox
    Friend WithEvents txtMateriaID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBuscarPorNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgw As DataGridView
    Friend WithEvents MateriaID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Facultad As DataGridViewTextBoxColumn
    Friend WithEvents cmbFacultad As ComboBox
End Class
