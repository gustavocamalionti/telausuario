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
        Me.dsBloqueios = New System.Data.DataSet()
        Me.tbBloqueiosPrincipal = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.tbBloqueiosRelatorios = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.grpAbaRelatorios = New DevExpress.XtraEditors.GroupControl()
        Me.grdAbaRelatorios = New DevExpress.XtraGrid.GridControl()
        Me.grid2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrincipal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelatorios1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnBloquear = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.cboUsuarios = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.chkPrincipal = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkRelatorios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelatorios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdAbaPrincipal = New DevExpress.XtraGrid.GridControl()
        CType(Me.grpAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaPrincipal.SuspendLayout()
        CType(Me.dsBloqueios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBloqueiosPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBloqueiosRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaRelatorios.SuspendLayout()
        CType(Me.grdAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAbaPrincipal
        '
        Me.grpAbaPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAbaPrincipal.Controls.Add(Me.CheckedListBox1)
        Me.grpAbaPrincipal.Controls.Add(Me.grdAbaPrincipal)
        Me.grpAbaPrincipal.Location = New System.Drawing.Point(0, 41)
        Me.grpAbaPrincipal.Name = "grpAbaPrincipal"
        Me.grpAbaPrincipal.Size = New System.Drawing.Size(309, 302)
        Me.grpAbaPrincipal.TabIndex = 0
        Me.grpAbaPrincipal.Text = "Aba Principal"
        '
        'dsBloqueios
        '
        Me.dsBloqueios.DataSetName = "NewDataSet"
        Me.dsBloqueios.Tables.AddRange(New System.Data.DataTable() {Me.tbBloqueiosPrincipal, Me.tbBloqueiosRelatorios})
        '
        'tbBloqueiosPrincipal
        '
        Me.tbBloqueiosPrincipal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1})
        Me.tbBloqueiosPrincipal.TableName = "tbBloqueiosPrincipal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Principal"
        '
        'tbBloqueiosRelatorios
        '
        Me.tbBloqueiosRelatorios.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2})
        Me.tbBloqueiosRelatorios.TableName = "tbBloqueiosRelatorios"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Relatorios"
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
        'grdAbaRelatorios
        '
        Me.grdAbaRelatorios.DataMember = "tbBloqueiosRelatorios"
        Me.grdAbaRelatorios.DataSource = Me.dsBloqueios
        Me.grdAbaRelatorios.Location = New System.Drawing.Point(0, 21)
        Me.grdAbaRelatorios.MainView = Me.grid2
        Me.grdAbaRelatorios.Name = "grdAbaRelatorios"
        Me.grdAbaRelatorios.Size = New System.Drawing.Size(309, 281)
        Me.grdAbaRelatorios.TabIndex = 1
        Me.grdAbaRelatorios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid2})
        '
        'grid2
        '
        Me.grid2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrincipal1, Me.colRelatorios1})
        Me.grid2.GridControl = Me.grdAbaRelatorios
        Me.grid2.Name = "grid2"
        Me.grid2.OptionsView.ShowGroupPanel = False
        '
        'colPrincipal1
        '
        Me.colPrincipal1.FieldName = "Principal"
        Me.colPrincipal1.Name = "colPrincipal1"
        '
        'colRelatorios1
        '
        Me.colRelatorios1.FieldName = "Relatorios"
        Me.colRelatorios1.Name = "colRelatorios1"
        Me.colRelatorios1.Visible = True
        Me.colRelatorios1.VisibleIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnBloquear})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnBloquear, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnBloquear
        '
        Me.btnBloquear.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnBloquear.Caption = "Bloquear"
        Me.btnBloquear.Glyph = Global.telausuario.My.Resources.Resources.cadeado
        Me.btnBloquear.Id = 0
        Me.btnBloquear.Name = "btnBloquear"
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
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(5, 24)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 84)
        Me.CheckedListBox1.TabIndex = 1
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoHeight = False
        Me.chkPrincipal.Name = "chkPrincipal"
        '
        'chkRelatorios
        '
        Me.chkRelatorios.AutoHeight = False
        Me.chkRelatorios.Name = "chkRelatorios"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrincipal, Me.colRelatorios})
        Me.grd1.GridControl = Me.grdAbaPrincipal
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colPrincipal
        '
        Me.colPrincipal.AppearanceCell.Options.UseTextOptions = True
        Me.colPrincipal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPrincipal.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
        Me.colPrincipal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPrincipal.ColumnEdit = Me.chkPrincipal
        Me.colPrincipal.FieldName = "Principal"
        Me.colPrincipal.Name = "colPrincipal"
        Me.colPrincipal.Visible = True
        Me.colPrincipal.VisibleIndex = 0
        '
        'colRelatorios
        '
        Me.colRelatorios.AppearanceCell.Options.UseTextOptions = True
        Me.colRelatorios.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colRelatorios.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
        Me.colRelatorios.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colRelatorios.ColumnEdit = Me.chkRelatorios
        Me.colRelatorios.FieldName = "Relatorios"
        Me.colRelatorios.Name = "colRelatorios"
        '
        'grdAbaPrincipal
        '
        Me.grdAbaPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAbaPrincipal.DataMember = "tbBloqueiosPrincipal"
        Me.grdAbaPrincipal.DataSource = Me.dsBloqueios
        Me.grdAbaPrincipal.Location = New System.Drawing.Point(0, 21)
        Me.grdAbaPrincipal.MainView = Me.grd1
        Me.grdAbaPrincipal.Name = "grdAbaPrincipal"
        Me.grdAbaPrincipal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkPrincipal, Me.chkRelatorios})
        Me.grdAbaPrincipal.Size = New System.Drawing.Size(309, 281)
        Me.grdAbaPrincipal.TabIndex = 0
        Me.grdAbaPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
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
        CType(Me.dsBloqueios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBloqueiosPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBloqueiosRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAbaRelatorios.ResumeLayout(False)
        CType(Me.grdAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAbaPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAbaPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpAbaRelatorios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdAbaRelatorios As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnBloquear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cboUsuarios As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dsBloqueios As System.Data.DataSet
    Friend WithEvents tbBloqueiosPrincipal As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents colPrincipal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelatorios1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbBloqueiosRelatorios As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents grdAbaPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPrincipal As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colRelatorios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkRelatorios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
