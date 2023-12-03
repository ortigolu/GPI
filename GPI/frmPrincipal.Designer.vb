<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        MenuStrip1 = New MenuStrip()
        FacultadToolStripMenuItem = New ToolStripMenuItem()
        DetallesDeFacultadesToolStripMenuItem = New ToolStripMenuItem()
        MateriasToolStripMenuItem = New ToolStripMenuItem()
        DetallesDeMateriasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FacultadToolStripMenuItem, MateriasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1066, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FacultadToolStripMenuItem
        ' 
        FacultadToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DetallesDeFacultadesToolStripMenuItem})
        FacultadToolStripMenuItem.Name = "FacultadToolStripMenuItem"
        FacultadToolStripMenuItem.Size = New Size(64, 20)
        FacultadToolStripMenuItem.Text = "Facultad"
        ' 
        ' DetallesDeFacultadesToolStripMenuItem
        ' 
        DetallesDeFacultadesToolStripMenuItem.Name = "DetallesDeFacultadesToolStripMenuItem"
        DetallesDeFacultadesToolStripMenuItem.Size = New Size(190, 22)
        DetallesDeFacultadesToolStripMenuItem.Text = "Detalles de Facultades"
        ' 
        ' MateriasToolStripMenuItem
        ' 
        MateriasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DetallesDeMateriasToolStripMenuItem})
        MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        MateriasToolStripMenuItem.Size = New Size(64, 20)
        MateriasToolStripMenuItem.Text = "Materias"
        ' 
        ' DetallesDeMateriasToolStripMenuItem
        ' 
        DetallesDeMateriasToolStripMenuItem.Name = "DetallesDeMateriasToolStripMenuItem"
        DetallesDeMateriasToolStripMenuItem.Size = New Size(180, 22)
        DetallesDeMateriasToolStripMenuItem.Text = "Detalles de Materias"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1066, 593)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmPrincipal"
        Text = "Menu Principal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FacultadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallesDeFacultadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallesDeMateriasToolStripMenuItem As ToolStripMenuItem
End Class
