<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhatsapp
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
        Me.txtNumeroComDdd = New DevExpress.XtraEditors.TextEdit()
        Me.lblNumeroDestino = New DevExpress.XtraEditors.LabelControl()
        Me.lblMensagemEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.memMensagem = New DevExpress.XtraEditors.MemoEdit()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdListaClientes = New DevExpress.XtraGrid.GridControl()
        Me.dsListaContato = New System.Data.DataSet()
        Me.dtListaContato = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCelular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDDI = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumeroComDdd
        '
        Me.txtNumeroComDdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroComDdd.Location = New System.Drawing.Point(465, 151)
        Me.txtNumeroComDdd.Name = "txtNumeroComDdd"
        Me.txtNumeroComDdd.Properties.MaxLength = 15
        Me.txtNumeroComDdd.Size = New System.Drawing.Size(162, 20)
        Me.txtNumeroComDdd.TabIndex = 0
        '
        'lblNumeroDestino
        '
        Me.lblNumeroDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDestino.Location = New System.Drawing.Point(271, 154)
        Me.lblNumeroDestino.Name = "lblNumeroDestino"
        Me.lblNumeroDestino.Size = New System.Drawing.Size(113, 13)
        Me.lblNumeroDestino.TabIndex = 1
        Me.lblNumeroDestino.Text = "Número do Destinatário"
        '
        'lblMensagemEnvio
        '
        Me.lblMensagemEnvio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensagemEnvio.Location = New System.Drawing.Point(74, 180)
        Me.lblMensagemEnvio.Name = "lblMensagemEnvio"
        Me.lblMensagemEnvio.Size = New System.Drawing.Size(51, 13)
        Me.lblMensagemEnvio.TabIndex = 3
        Me.lblMensagemEnvio.Text = "Mensagem"
        '
        'memMensagem
        '
        Me.memMensagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memMensagem.Location = New System.Drawing.Point(131, 177)
        Me.memMensagem.Name = "memMensagem"
        Me.memMensagem.Size = New System.Drawing.Size(496, 62)
        Me.memMensagem.TabIndex = 4
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Location = New System.Drawing.Point(425, 245)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(99, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar Mensagem"
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.Location = New System.Drawing.Point(530, 245)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(97, 23)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        '
        'grdListaClientes
        '
        Me.grdListaClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListaClientes.DataMember = "dtListaContato"
        Me.grdListaClientes.DataSource = Me.dsListaContato
        Me.grdListaClientes.Location = New System.Drawing.Point(12, 12)
        Me.grdListaClientes.MainView = Me.grd1
        Me.grdListaClientes.Name = "grdListaClientes"
        Me.grdListaClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdListaClientes.Size = New System.Drawing.Size(615, 133)
        Me.grdListaClientes.TabIndex = 7
        Me.grdListaClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsListaContato
        '
        Me.dsListaContato.DataSetName = "dsListaContato"
        Me.dsListaContato.Tables.AddRange(New System.Data.DataTable() {Me.dtListaContato})
        '
        'dtListaContato
        '
        Me.dtListaContato.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.dtListaContato.TableName = "dtListaContato"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Nome"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Celular"
        Me.DataColumn3.ColumnName = "Celular"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "CodPais"
        Me.DataColumn4.ColumnName = "CodPais"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colCelular, Me.colCodPais})
        Me.grd1.GridControl = Me.grdListaClientes
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.ColumnEdit = Me.txtAlterarGrid
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'txtAlterarGrid
        '
        Me.txtAlterarGrid.AutoHeight = False
        Me.txtAlterarGrid.Name = "txtAlterarGrid"
        '
        'colNome
        '
        Me.colNome.ColumnEdit = Me.txtAlterarGrid
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 0
        '
        'colCelular
        '
        Me.colCelular.ColumnEdit = Me.txtAlterarGrid
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 1
        '
        'colCodPais
        '
        Me.colCodPais.ColumnEdit = Me.txtAlterarGrid
        Me.colCodPais.FieldName = "CodPais"
        Me.colCodPais.Name = "colCodPais"
        '
        'txtDDI
        '
        Me.txtDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDDI.Location = New System.Drawing.Point(390, 151)
        Me.txtDDI.Name = "txtDDI"
        Me.txtDDI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDDI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDDI.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDDI.Properties.MaxLength = 15
        Me.txtDDI.Size = New System.Drawing.Size(76, 20)
        Me.txtDDI.TabIndex = 10
        '
        'frmWhatsapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 280)
        Me.Controls.Add(Me.txtDDI)
        Me.Controls.Add(Me.grdListaClientes)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.memMensagem)
        Me.Controls.Add(Me.lblMensagemEnvio)
        Me.Controls.Add(Me.lblNumeroDestino)
        Me.Controls.Add(Me.txtNumeroComDdd)
        Me.Name = "frmWhatsapp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWhatsapp"
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumeroComDdd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumeroDestino As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensagemEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memMensagem As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdListaClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsListaContato As System.Data.DataSet
    Friend WithEvents dtListaContato As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDDI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPais As DevExpress.XtraGrid.Columns.GridColumn
End Class
