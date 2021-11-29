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
        Me.grd1 = New DevExpress.XtraGrid.GridControl()
        Me.grdListagem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnUltimoBackup = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnListarArquivos = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnUpload = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBackupBanco = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCriarPasta = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.btnVerificacoes = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.btnFuncaoCompleta = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
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
        Me.PanelControl3.Size = New System.Drawing.Size(549, 248)
        Me.PanelControl3.TabIndex = 6
        '
        'grd1
        '
        Me.grd1.Dock = System.Windows.Forms.DockStyle.Left
        Me.grd1.Location = New System.Drawing.Point(2, 2)
        Me.grd1.MainView = Me.grdListagem
        Me.grd1.Name = "grd1"
        Me.grd1.Size = New System.Drawing.Size(416, 206)
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
        Me.PanelControl7.Location = New System.Drawing.Point(2, 208)
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnUltimoBackup)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 208)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl1.TabIndex = 7
        '
        'btnUltimoBackup
        '
        Me.btnUltimoBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUltimoBackup.Location = New System.Drawing.Point(2, 2)
        Me.btnUltimoBackup.Name = "btnUltimoBackup"
        Me.btnUltimoBackup.Size = New System.Drawing.Size(192, 36)
        Me.btnUltimoBackup.TabIndex = 6
        Me.btnUltimoBackup.Text = "Ultimo Backup"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnListarArquivos)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 163)
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
        Me.btnListarArquivos.Text = "Listar "
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnUpload)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 123)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl4.TabIndex = 9
        '
        'btnUpload
        '
        Me.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpload.Location = New System.Drawing.Point(2, 2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(192, 36)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "Upload"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btnBackupBanco)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(0, 83)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl5.TabIndex = 10
        '
        'btnBackupBanco
        '
        Me.btnBackupBanco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBackupBanco.Location = New System.Drawing.Point(2, 2)
        Me.btnBackupBanco.Name = "btnBackupBanco"
        Me.btnBackupBanco.Size = New System.Drawing.Size(192, 36)
        Me.btnBackupBanco.TabIndex = 3
        Me.btnBackupBanco.Text = "Backup Banco"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.btnCriarPasta)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 43)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl6.TabIndex = 11
        '
        'btnCriarPasta
        '
        Me.btnCriarPasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCriarPasta.Location = New System.Drawing.Point(2, 2)
        Me.btnCriarPasta.Name = "btnCriarPasta"
        Me.btnCriarPasta.Size = New System.Drawing.Size(192, 36)
        Me.btnCriarPasta.TabIndex = 2
        Me.btnCriarPasta.Text = "Criar Pasta"
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.btnVerificacoes)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl8.Location = New System.Drawing.Point(0, 3)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(196, 40)
        Me.PanelControl8.TabIndex = 12
        '
        'btnVerificacoes
        '
        Me.btnVerificacoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerificacoes.Location = New System.Drawing.Point(2, 2)
        Me.btnVerificacoes.Name = "btnVerificacoes"
        Me.btnVerificacoes.Size = New System.Drawing.Size(192, 36)
        Me.btnVerificacoes.TabIndex = 3
        Me.btnVerificacoes.Text = "Verificações"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.btnFuncaoCompleta)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(418, 2)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(129, 206)
        Me.PanelControl9.TabIndex = 9
        '
        'btnFuncaoCompleta
        '
        Me.btnFuncaoCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFuncaoCompleta.Location = New System.Drawing.Point(2, 2)
        Me.btnFuncaoCompleta.Name = "btnFuncaoCompleta"
        Me.btnFuncaoCompleta.Size = New System.Drawing.Size(125, 202)
        Me.btnFuncaoCompleta.TabIndex = 0
        Me.btnFuncaoCompleta.Text = "Função Completa"
        '
        'frmDropBoxTeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 248)
        Me.Controls.Add(Me.PanelControl8)
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "frmDropBoxTeste"
        Me.Text = "frmDropBox"
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdListagem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUltimoBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnListarArquivos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnUpload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBackupBanco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCriarPasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnVerificacoes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFuncaoCompleta As DevExpress.XtraEditors.SimpleButton
End Class
