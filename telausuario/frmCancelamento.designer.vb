<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelamento
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
        Me.grpCancelarUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.lblCancelamento = New DevExpress.XtraEditors.LabelControl()
        Me.pnlCancelamento = New DevExpress.XtraEditors.PanelControl()
        Me.lblMotivo = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescricao = New DevExpress.XtraEditors.LabelControl()
        Me.cboMotivo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReativar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dtData = New DevExpress.XtraEditors.DateEdit()
        Me.lblData = New DevExpress.XtraEditors.LabelControl()
        Me.memDescricao = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.grpCancelarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCancelarUsuario.SuspendLayout()
        CType(Me.pnlCancelamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCancelarUsuario
        '
        Me.grpCancelarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCancelarUsuario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.grpCancelarUsuario.Appearance.Options.UseFont = True
        Me.grpCancelarUsuario.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.grpCancelarUsuario.AppearanceCaption.Options.UseFont = True
        Me.grpCancelarUsuario.Controls.Add(Me.lblCancelamento)
        Me.grpCancelarUsuario.Controls.Add(Me.pnlCancelamento)
        Me.grpCancelarUsuario.Controls.Add(Me.lblMotivo)
        Me.grpCancelarUsuario.Controls.Add(Me.lblDescricao)
        Me.grpCancelarUsuario.Controls.Add(Me.cboMotivo)
        Me.grpCancelarUsuario.Controls.Add(Me.dtData)
        Me.grpCancelarUsuario.Controls.Add(Me.lblData)
        Me.grpCancelarUsuario.Controls.Add(Me.memDescricao)
        Me.grpCancelarUsuario.Location = New System.Drawing.Point(0, 0)
        Me.grpCancelarUsuario.Name = "grpCancelarUsuario"
        Me.grpCancelarUsuario.Size = New System.Drawing.Size(485, 266)
        Me.grpCancelarUsuario.TabIndex = 0
        '
        'lblCancelamento
        '
        Me.lblCancelamento.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblCancelamento.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCancelamento.Location = New System.Drawing.Point(81, 29)
        Me.lblCancelamento.Name = "lblCancelamento"
        Me.lblCancelamento.Size = New System.Drawing.Size(164, 24)
        Me.lblCancelamento.TabIndex = 10
        Me.lblCancelamento.Text = "CANCELAMENTO"
        '
        'pnlCancelamento
        '
        Me.pnlCancelamento.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlCancelamento.Appearance.Options.UseBackColor = True
        Me.pnlCancelamento.Location = New System.Drawing.Point(8, 43)
        Me.pnlCancelamento.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.pnlCancelamento.Name = "pnlCancelamento"
        Me.pnlCancelamento.Size = New System.Drawing.Size(465, 5)
        Me.pnlCancelamento.TabIndex = 9
        '
        'lblMotivo
        '
        Me.lblMotivo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblMotivo.Location = New System.Drawing.Point(28, 81)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(47, 19)
        Me.lblMotivo.TabIndex = 8
        Me.lblMotivo.Text = "Motivo"
        '
        'lblDescricao
        '
        Me.lblDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricao.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblDescricao.Location = New System.Drawing.Point(8, 107)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(67, 19)
        Me.lblDescricao.TabIndex = 7
        Me.lblDescricao.Text = "Descrição"
        '
        'cboMotivo
        '
        Me.cboMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMotivo.EnterMoveNextControl = True
        Me.cboMotivo.Location = New System.Drawing.Point(81, 83)
        Me.cboMotivo.MenuManager = Me.BarManager1
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMotivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMotivo.Properties.MaxLength = 70
        Me.cboMotivo.Size = New System.Drawing.Size(394, 20)
        Me.cboMotivo.TabIndex = 1
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnReativar})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnReativar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'btnReativar
        '
        Me.btnReativar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnReativar.Caption = "Reativar"
        Me.btnReativar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x321
        Me.btnReativar.Id = 2
        Me.btnReativar.Name = "btnReativar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(485, 51)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 274)
        Me.barDockControlBottom.Size = New System.Drawing.Size(485, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 223)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(485, 51)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 223)
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(81, 57)
        Me.dtData.MenuManager = Me.BarManager1
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.MaxLength = 35
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtData.Size = New System.Drawing.Size(132, 20)
        Me.dtData.TabIndex = 0
        '
        'lblData
        '
        Me.lblData.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblData.Location = New System.Drawing.Point(43, 55)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 19)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data"
        '
        'memDescricao
        '
        Me.memDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memDescricao.EnterMoveNextControl = True
        Me.memDescricao.Location = New System.Drawing.Point(81, 109)
        Me.memDescricao.Name = "memDescricao"
        Me.memDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memDescricao.Size = New System.Drawing.Size(394, 144)
        Me.memDescricao.TabIndex = 2
        '
        'frmCancelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 309)
        Me.Controls.Add(Me.grpCancelarUsuario)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "frmCancelamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelamento de Cliente"
        CType(Me.grpCancelarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCancelarUsuario.ResumeLayout(False)
        Me.grpCancelarUsuario.PerformLayout()
        CType(Me.pnlCancelamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCancelarUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents memDescricao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMotivo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescricao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMotivo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblCancelamento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlCancelamento As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnReativar As DevExpress.XtraBars.BarButtonItem
End Class
