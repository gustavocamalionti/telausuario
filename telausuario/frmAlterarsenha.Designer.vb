<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarSenha
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
        Me.txtSenhaAntiga = New DevExpress.XtraEditors.TextEdit()
        Me.lblSenhaAntiga = New DevExpress.XtraEditors.LabelControl()
        Me.lblNovaSenha = New DevExpress.XtraEditors.LabelControl()
        Me.txtNovaSenha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConfirmarSenha = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSenhaAntiga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNovaSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmarSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSenhaAntiga
        '
        Me.txtSenhaAntiga.EnterMoveNextControl = True
        Me.txtSenhaAntiga.Location = New System.Drawing.Point(100, 9)
        Me.txtSenhaAntiga.Name = "txtSenhaAntiga"
        Me.txtSenhaAntiga.Properties.UseSystemPasswordChar = True
        Me.txtSenhaAntiga.Size = New System.Drawing.Size(124, 20)
        Me.txtSenhaAntiga.TabIndex = 0
        '
        'lblSenhaAntiga
        '
        Me.lblSenhaAntiga.Location = New System.Drawing.Point(30, 12)
        Me.lblSenhaAntiga.Name = "lblSenhaAntiga"
        Me.lblSenhaAntiga.Size = New System.Drawing.Size(64, 13)
        Me.lblSenhaAntiga.TabIndex = 1
        Me.lblSenhaAntiga.Text = "Senha Antiga"
        '
        'lblNovaSenha
        '
        Me.lblNovaSenha.Location = New System.Drawing.Point(36, 38)
        Me.lblNovaSenha.Name = "lblNovaSenha"
        Me.lblNovaSenha.Size = New System.Drawing.Size(58, 13)
        Me.lblNovaSenha.TabIndex = 3
        Me.lblNovaSenha.Text = "Nova Senha"
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.EnterMoveNextControl = True
        Me.txtNovaSenha.Location = New System.Drawing.Point(100, 35)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.Properties.UseSystemPasswordChar = True
        Me.txtNovaSenha.Size = New System.Drawing.Size(124, 20)
        Me.txtNovaSenha.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Confirmar Senha"
        '
        'txtConfirmarSenha
        '
        Me.txtConfirmarSenha.EnterMoveNextControl = True
        Me.txtConfirmarSenha.Location = New System.Drawing.Point(100, 61)
        Me.txtConfirmarSenha.Name = "txtConfirmarSenha"
        Me.txtConfirmarSenha.Properties.UseSystemPasswordChar = True
        Me.txtConfirmarSenha.Size = New System.Drawing.Size(124, 20)
        Me.txtConfirmarSenha.TabIndex = 2
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Location = New System.Drawing.Point(14, 87)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(0, 5)
        Me.PanelControl4.TabIndex = 71
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(135, 99)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(19, 99)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        '
        'frmAlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 131)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtConfirmarSenha)
        Me.Controls.Add(Me.lblNovaSenha)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.lblSenhaAntiga)
        Me.Controls.Add(Me.txtSenhaAntiga)
        Me.Name = "frmAlterarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Senha"
        CType(Me.txtSenhaAntiga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNovaSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmarSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSenhaAntiga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSenhaAntiga As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNovaSenha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNovaSenha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConfirmarSenha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
End Class
