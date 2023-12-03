<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacultad
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        dvgFacultad = New DataGridView()
        btnSalir = New Button()
        GroupBox1.SuspendLayout()
        CType(dvgFacultad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Navy
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1086, 113)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(22, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 33)
        Label1.TabIndex = 0
        Label1.Text = "Lista de Facultades"
        ' 
        ' dvgFacultad
        ' 
        dvgFacultad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgFacultad.Location = New Point(4, 121)
        dvgFacultad.Name = "dvgFacultad"
        dvgFacultad.RowTemplate.Height = 25
        dvgFacultad.Size = New Size(1084, 392)
        dvgFacultad.TabIndex = 1
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(968, 530)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(111, 54)
        btnSalir.TabIndex = 2
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmFacultad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 596)
        Controls.Add(btnSalir)
        Controls.Add(dvgFacultad)
        Controls.Add(GroupBox1)
        Name = "frmFacultad"
        Text = "frmFacultad"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dvgFacultad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgFacultad As DataGridView
    Friend WithEvents btnSalir As Button
End Class
