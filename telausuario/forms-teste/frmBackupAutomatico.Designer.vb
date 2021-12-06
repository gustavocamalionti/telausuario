<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupAutomatico
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnDownload = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUltimoBackup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grdListagem = New DevExpress.XtraGrid.GridControl()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnRemoverPesquisarGrid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtRemoverCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnListar1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRelatorioGeral = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDownload, Me.btnUltimoBackup, Me.btnFechar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDownload), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUltimoBackup), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFechar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnDownload
        '
        Me.btnDownload.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnDownload.Caption = "Download"
        Me.btnDownload.Id = 0
        Me.btnDownload.Name = "btnDownload"
        '
        'btnUltimoBackup
        '
        Me.btnUltimoBackup.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnUltimoBackup.Caption = "Último Backup"
        Me.btnUltimoBackup.Id = 1
        Me.btnUltimoBackup.Name = "btnUltimoBackup"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(587, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 636)
        Me.barDockControlBottom.Size = New System.Drawing.Size(587, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 636)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(587, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 636)
        '
        'grdListagem
        '
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.Location = New System.Drawing.Point(0, 53)
        Me.grdListagem.MainView = Me.grd1
        Me.grdListagem.MenuManager = Me.BarManager1
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(571, 585)
        Me.grdListagem.TabIndex = 30
        Me.grdListagem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.GridControl = Me.grdListagem
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'btnRemoverPesquisarGrid
        '
        Me.btnRemoverPesquisarGrid.Location = New System.Drawing.Point(371, 18)
        Me.btnRemoverPesquisarGrid.MenuManager = Me.BarManager1
        Me.btnRemoverPesquisarGrid.Name = "btnRemoverPesquisarGrid"
        Me.btnRemoverPesquisarGrid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.btnRemoverPesquisarGrid.Size = New System.Drawing.Size(20, 20)
        Me.btnRemoverPesquisarGrid.TabIndex = 33
        '
        'txtRemoverCodigo
        '
        Me.txtRemoverCodigo.EnterMoveNextControl = True
        Me.txtRemoverCodigo.Location = New System.Drawing.Point(84, 18)
        Me.txtRemoverCodigo.MenuManager = Me.BarManager1
        Me.txtRemoverCodigo.Name = "txtRemoverCodigo"
        Me.txtRemoverCodigo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtRemoverCodigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemoverCodigo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemoverCodigo.Properties.MaxLength = 10
        Me.txtRemoverCodigo.Size = New System.Drawing.Size(290, 20)
        Me.txtRemoverCodigo.TabIndex = 32
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "LabelControl1"
        '
        'btnListar1
        '
        Me.btnListar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListar1.Location = New System.Drawing.Point(509, 12)
        Me.btnListar1.Name = "btnListar1"
        Me.btnListar1.Size = New System.Drawing.Size(62, 33)
        Me.btnListar1.TabIndex = 35
        Me.btnListar1.Text = "Listar"
        '
        'btnRelatorioGeral
        '
        Me.btnRelatorioGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioGeral.Location = New System.Drawing.Point(412, 12)
        Me.btnRelatorioGeral.Name = "btnRelatorioGeral"
        Me.btnRelatorioGeral.Size = New System.Drawing.Size(91, 33)
        Me.btnRelatorioGeral.TabIndex = 40
        Me.btnRelatorioGeral.Text = "Relatório Geral"
        '
        'frmBackupAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 661)
        Me.Controls.Add(Me.btnRelatorioGeral)
        Me.Controls.Add(Me.btnListar1)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.btnRemoverPesquisarGrid)
        Me.Controls.Add(Me.txtRemoverCodigo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBackupAutomatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBackupAutomatico"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grdListagem As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnRemoverPesquisarGrid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtRemoverCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnListar1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDownload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUltimoBackup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelatorioGeral As DevExpress.XtraEditors.SimpleButton
End Class
