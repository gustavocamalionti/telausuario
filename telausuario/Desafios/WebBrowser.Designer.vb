<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.rchConteudoHTML = New System.Windows.Forms.RichTextBox()
        Me.btnTransformarHTML = New DevExpress.XtraEditors.SimpleButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(292, 64)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(265, 198)
        Me.WebBrowser1.TabIndex = 0
        '
        'rchConteudoHTML
        '
        Me.rchConteudoHTML.Location = New System.Drawing.Point(12, 64)
        Me.rchConteudoHTML.Name = "rchConteudoHTML"
        Me.rchConteudoHTML.Size = New System.Drawing.Size(245, 155)
        Me.rchConteudoHTML.TabIndex = 1
        Me.rchConteudoHTML.Text = ""
        '
        'btnTransformarHTML
        '
        Me.btnTransformarHTML.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnTransformarHTML.Appearance.Options.UseFont = True
        Me.btnTransformarHTML.Location = New System.Drawing.Point(351, 8)
        Me.btnTransformarHTML.Name = "btnTransformarHTML"
        Me.btnTransformarHTML.Size = New System.Drawing.Size(102, 50)
        Me.btnTransformarHTML.TabIndex = 2
        Me.btnTransformarHTML.Text = "Transformar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(639, 150)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 426)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnTransformarHTML)
        Me.Controls.Add(Me.rchConteudoHTML)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "WebBrowser"
        Me.Text = "WebBrowser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents rchConteudoHTML As System.Windows.Forms.RichTextBox
    Friend WithEvents btnTransformarHTML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
