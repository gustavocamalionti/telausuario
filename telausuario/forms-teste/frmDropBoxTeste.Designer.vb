<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDropBoxTeste
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
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.btnFuncaoCompleta = New DevExpress.XtraEditors.SimpleButton()
        Me.grd1 = New DevExpress.XtraGrid.GridControl()
        Me.grdListagem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDownload = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnListarArquivos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLocalizarBackup = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl9)
        Me.PanelControl3.Controls.Add(Me.grd1)
        Me.PanelControl3.Controls.Add(Me.PanelControl7)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl3.Location = New System.Drawing.Point(196, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(549, 287)
        Me.PanelControl3.TabIndex = 6
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.btnFuncaoCompleta)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(418, 2)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(129, 245)
        Me.PanelControl9.TabIndex = 9
        '
        'btnFuncaoCompleta
        '
        Me.btnFuncaoCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFuncaoCompleta.Location = New System.Drawing.Point(2, 2)
        Me.btnFuncaoCompleta.Name = "btnFuncaoCompleta"
        Me.btnFuncaoCompleta.Size = New System.Drawing.Size(125, 241)
        Me.btnFuncaoCompleta.TabIndex = 0
        Me.btnFuncaoCompleta.Text = "Função Completa"
        '
        'grd1
        '
        Me.grd1.Dock = System.Windows.Forms.DockStyle.Left
        Me.grd1.Location = New System.Drawing.Point(2, 2)
        Me.grd1.MainView = Me.grdListagem
        Me.grd1.Name = "grd1"
        Me.grd1.Size = New System.Drawing.Size(416, 245)
        Me.grd1.TabIndex = 8
        Me.grd1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdListagem})
        '
        'grdListagem
        '
        Me.grdListagem.GridControl = Me.grd1
        Me.grdListagem.Name = "grdListagem"
        '
        'PanelControl7
        '
        Me.PanelControl7.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl7.Appearance.Options.UseBackColor = True
        Me.PanelControl7.Controls.Add(Me.lblStatus)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl7.Location = New System.Drawing.Point(2, 247)
        Me.PanelControl7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.PanelControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(545, 38)
        Me.PanelControl7.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblStatus.Location = New System.Drawing.Point(182, 6)
        Me.lblStatus.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.lblStatus.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(234, 24)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "OPERAÇÃO REALIZADA"
        Me.lblStatus.Visible = False
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.btnDownload)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl10.Location = New System.Drawing.Point(0, 202)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl10.TabIndex = 13
        '
        'btnDownload
        '
        Me.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDownload.Location = New System.Drawing.Point(2, 2)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(192, 36)
        Me.btnDownload.TabIndex = 3
        Me.btnDownload.Text = "Download - Último Backup"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnListarArquivos)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 242)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(196, 45)
        Me.PanelControl2.TabIndex = 8
        '
        'btnListarArquivos
        '
        Me.btnListarArquivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnListarArquivos.Location = New System.Drawing.Point(2, 2)
        Me.btnListarArquivos.Name = "btnListarArquivos"
        Me.btnListarArquivos.Size = New System.Drawing.Size(192, 41)
        Me.btnListarArquivos.TabIndex = 5
        Me.btnListarArquivos.Text = "Listar Backups"
        '
        'btnLocalizarBackup
        '
        Me.btnLocalizarBackup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLocalizarBackup.Location = New System.Drawing.Point(0, 166)
        Me.btnLocalizarBackup.Name = "btnLocalizarBackup"
        Me.btnLocalizarBackup.Size = New System.Drawing.Size(196, 36)
        Me.btnLocalizarBackup.TabIndex = 14
        Me.btnLocalizarBackup.Text = "Localizar Backup"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 130)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(196, 36)
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.Text = "Teste"
        '
        'frmDropBoxTeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 287)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnLocalizarBackup)
        Me.Controls.Add(Me.PanelControl10)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "frmDropBoxTeste"
        Me.Text = "frmDropBox"
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdListagem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFuncaoCompleta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDownload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnListarArquivos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLocalizarBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
