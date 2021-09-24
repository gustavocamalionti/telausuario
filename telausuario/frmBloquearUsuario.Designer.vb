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
        Me.chkAbaPrincipal = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.dsBloqueios = New System.Data.DataSet()
        Me.tbBloqueiosPrincipal = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.tbBloqueiosRelatorios = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.grpAbaRelatorios = New DevExpress.XtraEditors.GroupControl()
        Me.chkAbaRelatorios = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnBloquear = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.cboUsuarios = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.grpAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaPrincipal.SuspendLayout()
        CType(Me.chkAbaPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsBloqueios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBloqueiosPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBloqueiosRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAbaRelatorios.SuspendLayout()
        CType(Me.chkAbaRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAbaPrincipal
        '
        Me.grpAbaPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAbaPrincipal.Controls.Add(Me.chkAbaPrincipal)
        Me.grpAbaPrincipal.Location = New System.Drawing.Point(0, 41)
        Me.grpAbaPrincipal.Name = "grpAbaPrincipal"
        Me.grpAbaPrincipal.Size = New System.Drawing.Size(309, 302)
        Me.grpAbaPrincipal.TabIndex = 0
        Me.grpAbaPrincipal.Text = "Aba Principal"
        '
        'chkAbaPrincipal
        '
        Me.chkAbaPrincipal.CheckOnClick = True
        Me.chkAbaPrincipal.Location = New System.Drawing.Point(0, 21)
        Me.chkAbaPrincipal.Name = "chkAbaPrincipal"
        Me.chkAbaPrincipal.Size = New System.Drawing.Size(309, 281)
        Me.chkAbaPrincipal.TabIndex = 2
        Me.chkAbaPrincipal.ValueMember = "tbBloqueiosPrincipal.Principal"
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
        Me.grpAbaRelatorios.Controls.Add(Me.chkAbaRelatorios)
        Me.grpAbaRelatorios.Location = New System.Drawing.Point(312, 41)
        Me.grpAbaRelatorios.Name = "grpAbaRelatorios"
        Me.grpAbaRelatorios.Size = New System.Drawing.Size(309, 302)
        Me.grpAbaRelatorios.TabIndex = 1
        Me.grpAbaRelatorios.Text = "Aba de Relatórios"
        '
        'chkAbaRelatorios
        '
        Me.chkAbaRelatorios.CheckOnClick = True
        Me.chkAbaRelatorios.DisplayMember = "tbBloqueiosRelatorios.Relatorios"
        Me.chkAbaRelatorios.Location = New System.Drawing.Point(1, 21)
        Me.chkAbaRelatorios.Name = "chkAbaRelatorios"
        Me.chkAbaRelatorios.Size = New System.Drawing.Size(309, 281)
        Me.chkAbaRelatorios.TabIndex = 3
        Me.chkAbaRelatorios.ValueMember = "tbBloqueiosRelatorios.Relatorios"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 347)
        Me.barDockControlBottom.Size = New System.Drawing.Size(622, 47)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 347)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(622, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 347)
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
        Me.cboUsuarios.Properties.Items.AddRange(New Object() {""})
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
        CType(Me.chkAbaPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsBloqueios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBloqueiosPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBloqueiosRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAbaRelatorios.ResumeLayout(False)
        CType(Me.chkAbaRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAbaPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpAbaRelatorios As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents tbBloqueiosRelatorios As System.Data.DataTable
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents chkAbaPrincipal As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkAbaRelatorios As DevExpress.XtraEditors.CheckedListBoxControl
End Class
