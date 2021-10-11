<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetas
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
        Me.btnArdoxGarantia = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEtiqueta = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btnArdoxGarantia
        '
        Me.btnArdoxGarantia.Location = New System.Drawing.Point(12, 30)
        Me.btnArdoxGarantia.Name = "btnArdoxGarantia"
        Me.btnArdoxGarantia.Size = New System.Drawing.Size(85, 23)
        Me.btnArdoxGarantia.TabIndex = 0
        Me.btnArdoxGarantia.Text = "Ardox Garantia"
        '
        'btnEtiqueta
        '
        Me.btnEtiqueta.Location = New System.Drawing.Point(160, 30)
        Me.btnEtiqueta.Name = "btnEtiqueta"
        Me.btnEtiqueta.Size = New System.Drawing.Size(85, 23)
        Me.btnEtiqueta.TabIndex = 1
        Me.btnEtiqueta.Text = "Etiqueta Menor "
        '
        'frmEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEtiqueta)
        Me.Controls.Add(Me.btnArdoxGarantia)
        Me.Name = "frmEtiquetas"
        Me.Text = "frmEtiquetas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArdoxGarantia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEtiqueta As DevExpress.XtraEditors.SimpleButton
End Class
