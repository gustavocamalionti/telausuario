<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBloquearUsuario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpAbaPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.grpAbaRelatorios = New DevExpress.XtraEditors.GroupControl()
        Me.grdAbaPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdAbaRelatorios = New DevExpress.XtraGrid.GridControl()
        Me.grid2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.cboUsuarios = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.grpAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaPrincipal.SuspendLayout()
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaRelatorios.SuspendLayout()
        CType(Me.grdAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAbaPrincipal
        '
        Me.grpAbaPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAbaPrincipal.Controls.Add(Me.grdAbaPrincipal)
        Me.grpAbaPrincipal.Location = New System.Drawing.Point(0, 41)
        Me.grpAbaPrincipal.Name = "grpAbaPrincipal"
        Me.grpAbaPrincipal.Size = New System.Drawing.Size(309, 302)
        Me.grpAbaPrincipal.TabIndex = 0
        Me.grpAbaPrincipal.Text = "Aba Principal"
        '
        'grpAbaRelatorios
        '
        Me.grpAbaRelatorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAbaRelatorios.Controls.Add(Me.grdAbaRelatorios)
        Me.grpAbaRelatorios.Location = New System.Drawing.Point(312, 41)
        Me.grpAbaRelatorios.Name = "grpAbaRelatorios"
        Me.grpAbaRelatorios.Size = New System.Drawing.Size(309, 302)
        Me.grpAbaRelatorios.TabIndex = 1
        Me.grpAbaRelatorios.Text = "Aba de Relatórios"
        '
        'grdAbaPrincipal
        '
        Me.grdAbaPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAbaPrincipal.Location = New System.Drawing.Point(0, 21)
        Me.grdAbaPrincipal.MainView = Me.grd1
        Me.grdAbaPrincipal.Name = "grdAbaPrincipal"
        Me.grdAbaPrincipal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grdAbaPrincipal.Size = New System.Drawing.Size(309, 281)
        Me.grdAbaPrincipal.TabIndex = 0
        Me.grdAbaPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.GridControl = Me.grdAbaPrincipal
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'grdAbaRelatorios
        '
        Me.grdAbaRelatorios.Location = New System.Drawing.Point(0, 21)
        Me.grdAbaRelatorios.MainView = Me.grid2
        Me.grdAbaRelatorios.Name = "grdAbaRelatorios"
        Me.grdAbaRelatorios.Size = New System.Drawing.Size(309, 281)
        Me.grdAbaRelatorios.TabIndex = 1
        Me.grdAbaRelatorios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid2})
        '
        'grid2
        '
        Me.grid2.GridControl = Me.grdAbaRelatorios
        Me.grid2.Name = "grid2"
        Me.grid2.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(622, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 349)
        Me.barDockControlBottom.Size = New System.Drawing.Size(622, 45)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 349)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(622, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 349)
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "Bloquear"
        Me.BarButtonItem1.Glyph = Global.telausuario.My.Resources.Resources.cadeado
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(32, 15)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(36, 13)
        Me.lblUsuario.TabIndex = 7
        Me.lblUsuario.Text = "Usuário"
        '
        'cboUsuarios
        '
        Me.cboUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUsuarios.Location = New System.Drawing.Point(74, 12)
        Me.cboUsuarios.MenuManager = Me.BarManager1
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUsuarios.Properties.Items.AddRange(New Object() {"teste1" & Global.Microsoft.VisualBasic.ChrW(9), "teste2"})
        Me.cboUsuarios.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUsuarios.Size = New System.Drawing.Size(235, 20)
        Me.cboUsuarios.TabIndex = 8
        '
        'frmBloquearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 394)
        Me.Controls.Add(Me.cboUsuarios)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.grpAbaRelatorios)
        Me.Controls.Add(Me.grpAbaPrincipal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBloquearUsuario"
        Me.Text = "Bloquear Usuário"
        CType(Me.grpAbaPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAbaPrincipal.ResumeLayout(False)
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAbaRelatorios.ResumeLayout(False)
        CType(Me.grdAbaPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAbaPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpAbaRelatorios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdAbaPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdAbaRelatorios As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cboUsuarios As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
End Class
