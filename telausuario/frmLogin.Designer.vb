<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLogin = New DevExpress.XtraEditors.LabelControl()
        Me.lblSenha = New DevExpress.XtraEditors.LabelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSair = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
        Me.txtSenha = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.Appearance.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblLogin.Location = New System.Drawing.Point(99, 88)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(44, 19)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login"
        '
        'lblSenha
        '
        Me.lblSenha.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSenha.Appearance.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblSenha.Location = New System.Drawing.Point(93, 117)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(50, 19)
        Me.lblSenha.TabIndex = 2
        Me.lblSenha.Text = "Senha"
        '
        'btnOk
        '
        Me.btnOk.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOk.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.btnOk.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOk.Appearance.Options.UseBackColor = True
        Me.btnOk.Appearance.Options.UseBorderColor = True
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Appearance.Options.UseForeColor = True
        Me.btnOk.Location = New System.Drawing.Point(169, 195)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 30)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        '
        'btnSair
        '
        Me.btnSair.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSair.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.btnSair.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSair.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSair.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSair.Appearance.Options.UseBackColor = True
        Me.btnSair.Appearance.Options.UseBorderColor = True
        Me.btnSair.Appearance.Options.UseFont = True
        Me.btnSair.Appearance.Options.UseForeColor = True
        Me.btnSair.Location = New System.Drawing.Point(250, 195)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 30)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        '
        'txtLogin
        '
        Me.txtLogin.EnterMoveNextControl = True
        Me.txtLogin.Location = New System.Drawing.Point(149, 88)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtLogin.Properties.Appearance.Options.UseFont = True
        Me.txtLogin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Properties.MaxLength = 12
        Me.txtLogin.Size = New System.Drawing.Size(176, 22)
        Me.txtLogin.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(149, 114)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtSenha.Properties.Appearance.Options.UseFont = True
        Me.txtSenha.Properties.MaxLength = 12
        Me.txtSenha.Properties.UseSystemPasswordChar = True
        Me.txtSenha.Size = New System.Drawing.Size(176, 22)
        Me.txtSenha.TabIndex = 2
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.telausuario.My.Resources.Resources.TelaLogin
        Me.ClientSize = New System.Drawing.Size(342, 237)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSenha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSenha As DevExpress.XtraEditors.TextEdit
End Class
