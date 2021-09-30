<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desafioTimer
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnStart = New DevExpress.XtraEditors.SimpleButton()
        Me.lblVelocidade = New DevExpress.XtraEditors.LabelControl()
        Me.rdgVelocidade = New DevExpress.XtraEditors.RadioGroup()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.imgGato = New DevExpress.XtraEditors.PictureEdit()
        Me.imgRato = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.rdgVelocidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.imgGato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnStart)
        Me.PanelControl1.Controls.Add(Me.lblVelocidade)
        Me.PanelControl1.Controls.Add(Me.rdgVelocidade)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1024, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Appearance.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.btnStart.Appearance.Options.UseFont = True
        Me.btnStart.Location = New System.Drawing.Point(813, 33)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(148, 34)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        '
        'lblVelocidade
        '
        Me.lblVelocidade.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lblVelocidade.Location = New System.Drawing.Point(29, 42)
        Me.lblVelocidade.Name = "lblVelocidade"
        Me.lblVelocidade.Size = New System.Drawing.Size(101, 25)
        Me.lblVelocidade.TabIndex = 1
        Me.lblVelocidade.Text = "Velocidade"
        '
        'rdgVelocidade
        '
        Me.rdgVelocidade.Location = New System.Drawing.Point(136, 29)
        Me.rdgVelocidade.Name = "rdgVelocidade"
        Me.rdgVelocidade.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.rdgVelocidade.Properties.Appearance.Options.UseFont = True
        Me.rdgVelocidade.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "2"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "3"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "4"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "5")})
        Me.rdgVelocidade.Size = New System.Drawing.Size(234, 47)
        Me.rdgVelocidade.TabIndex = 0
        '
        'timer1
        '
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.imgGato)
        Me.PanelControl2.Controls.Add(Me.imgRato)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 100)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1024, 620)
        Me.PanelControl2.TabIndex = 1
        '
        'imgGato
        '
        Me.imgGato.EditValue = Global.telausuario.My.Resources.Resources.gatoleft_30
        Me.imgGato.Location = New System.Drawing.Point(536, 131)
        Me.imgGato.Name = "imgGato"
        Me.imgGato.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgGato.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.imgGato.Properties.Appearance.Options.UseBackColor = True
        Me.imgGato.Properties.Appearance.Options.UseForeColor = True
        Me.imgGato.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.imgGato.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.imgGato.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.imgGato.Size = New System.Drawing.Size(41, 43)
        Me.imgGato.TabIndex = 2
        Me.imgGato.Visible = False
        '
        'imgRato
        '
        Me.imgRato.EditValue = Global.telausuario.My.Resources.Resources.rato1
        Me.imgRato.Location = New System.Drawing.Point(413, 38)
        Me.imgRato.Name = "imgRato"
        Me.imgRato.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgRato.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.imgRato.Properties.Appearance.Options.UseBackColor = True
        Me.imgRato.Properties.Appearance.Options.UseForeColor = True
        Me.imgRato.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.imgRato.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.imgRato.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.imgRato.Size = New System.Drawing.Size(86, 105)
        Me.imgRato.TabIndex = 1
        '
        'desafioTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "desafioTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraForm2"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.rdgVelocidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.imgGato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVelocidade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgVelocidade As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents imgRato As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents imgGato As DevExpress.XtraEditors.PictureEdit
End Class
