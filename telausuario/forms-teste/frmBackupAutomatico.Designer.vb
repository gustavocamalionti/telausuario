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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.btnRemoverPesquisarGrid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtRemoverCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.btnUltimoBackup = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDownload = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage1.Controls.Add(Me.btnRemoverPesquisarGrid)
        Me.XtraTabPage1.Controls.Add(Me.txtRemoverCodigo)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1008, 558)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1014, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 638)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1014, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 638)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1014, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 638)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1002, 513)
        Me.PanelControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(998, 509)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "LabelControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 52)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1014, 586)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'btnRemoverPesquisarGrid
        '
        Me.btnRemoverPesquisarGrid.Location = New System.Drawing.Point(454, 16)
        Me.btnRemoverPesquisarGrid.MenuManager = Me.BarManager1
        Me.btnRemoverPesquisarGrid.Name = "btnRemoverPesquisarGrid"
        Me.btnRemoverPesquisarGrid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnRemoverPesquisarGrid.Size = New System.Drawing.Size(20, 20)
        Me.btnRemoverPesquisarGrid.TabIndex = 26
        '
        'txtRemoverCodigo
        '
        Me.txtRemoverCodigo.EnterMoveNextControl = True
        Me.txtRemoverCodigo.Location = New System.Drawing.Point(85, 16)
        Me.txtRemoverCodigo.MenuManager = Me.BarManager1
        Me.txtRemoverCodigo.Name = "txtRemoverCodigo"
        Me.txtRemoverCodigo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtRemoverCodigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemoverCodigo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemoverCodigo.Properties.MaxLength = 10
        Me.txtRemoverCodigo.Size = New System.Drawing.Size(372, 20)
        Me.txtRemoverCodigo.TabIndex = 25
        '
        'btnUltimoBackup
        '
        Me.btnUltimoBackup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUltimoBackup.Location = New System.Drawing.Point(0, 0)
        Me.btnUltimoBackup.Name = "btnUltimoBackup"
        Me.btnUltimoBackup.Size = New System.Drawing.Size(75, 33)
        Me.btnUltimoBackup.TabIndex = 27
        Me.btnUltimoBackup.Text = "Ultimo Backup"
        '
        'btnDownload
        '
        Me.btnDownload.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDownload.Location = New System.Drawing.Point(80, 0)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 33)
        Me.btnDownload.TabIndex = 26
        Me.btnDownload.Text = "Download"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnUltimoBackup)
        Me.PanelControl2.Controls.Add(Me.btnDownload)
        Me.PanelControl2.Location = New System.Drawing.Point(850, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(155, 33)
        Me.PanelControl2.TabIndex = 29
        '
        'frmBackupAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 661)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBackupAutomatico"
        Me.Text = "frmBackupAutomatico"
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemoverPesquisarGrid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtRemoverCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUltimoBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDownload As DevExpress.XtraEditors.SimpleButton
End Class
