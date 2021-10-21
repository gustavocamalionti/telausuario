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
        Me.components = New System.ComponentModel.Container()
        Me.txtNumeroComDdd = New DevExpress.XtraEditors.TextEdit()
        Me.lblNumero = New DevExpress.XtraEditors.LabelControl()
        Me.lblMensagemEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.memMensagem = New DevExpress.XtraEditors.MemoEdit()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.L = New DevExpress.XtraBars.Bar()
        Me.btnClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEnviar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grpDadosMensagem = New DevExpress.XtraEditors.GroupControl()
        Me.dblformatoNumero = New DevExpress.XtraEditors.LabelControl()
        Me.lblDDI = New DevExpress.XtraEditors.LabelControl()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosMensagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosMensagem.SuspendLayout()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumeroComDdd
        '
        Me.txtNumeroComDdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroComDdd.Location = New System.Drawing.Point(106, 196)
        Me.txtNumeroComDdd.Name = "txtNumeroComDdd"
        Me.txtNumeroComDdd.Properties.MaxLength = 15
        Me.txtNumeroComDdd.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroComDdd.TabIndex = 0
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.Location = New System.Drawing.Point(19, 199)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(37, 13)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Número"
        '
        'lblMensagemEnvio
        '
        Me.lblMensagemEnvio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensagemEnvio.Location = New System.Drawing.Point(5, 251)
        Me.lblMensagemEnvio.Name = "lblMensagemEnvio"
        Me.lblMensagemEnvio.Size = New System.Drawing.Size(51, 13)
        Me.lblMensagemEnvio.TabIndex = 3
        Me.lblMensagemEnvio.Text = "Mensagem"
        '
        'memMensagem
        '
        Me.memMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.memMensagem.Location = New System.Drawing.Point(62, 252)
        Me.memMensagem.Name = "memMensagem"
        Me.memMensagem.Size = New System.Drawing.Size(451, 79)
        Me.memMensagem.TabIndex = 4
        '
        'grdListaClientes
        '
        Me.grdListaClientes.DataMember = "dtListaContato"
        Me.grdListaClientes.DataSource = Me.dsListaContato
        Me.grdListaClientes.Location = New System.Drawing.Point(46, 12)
        Me.grdListaClientes.MainView = Me.grd1
        Me.grdListaClientes.Name = "grdListaClientes"
        Me.grdListaClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdListaClientes.Size = New System.Drawing.Size(383, 367)
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
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
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
        Me.colNome.Width = 258
        '
        'colCelular
        '
        Me.colCelular.ColumnEdit = Me.txtAlterarGrid
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 1
        Me.colCelular.Width = 107
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
        Me.txtDDI.Location = New System.Drawing.Point(62, 196)
        Me.txtDDI.Name = "txtDDI"
        Me.txtDDI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDDI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDDI.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDDI.Properties.MaxLength = 15
        Me.txtDDI.Size = New System.Drawing.Size(45, 20)
        Me.txtDDI.TabIndex = 10
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.L})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEnviar, Me.btnFechar, Me.btnLimpar, Me.btnClientes})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.L
        '
        'L
        '
        Me.L.BarName = "Status bar"
        Me.L.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.L.DockCol = 0
        Me.L.DockRow = 0
        Me.L.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.L.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClientes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEnviar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.L.OptionsBar.AllowQuickCustomization = False
        Me.L.OptionsBar.DrawDragBorder = False
        Me.L.OptionsBar.UseWholeRow = True
        Me.L.Text = "Status bar"
        '
        'btnClientes
        '
        Me.btnClientes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnClientes.Caption = "Clientes"
        Me.btnClientes.Glyph = Global.telausuario.My.Resources.Resources.Cliente
        Me.btnClientes.Id = 3
        Me.btnClientes.Name = "btnClientes"
        '
        'btnEnviar
        '
        Me.btnEnviar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEnviar.Caption = "Enviar"
        Me.btnEnviar.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.btnEnviar.Id = 0
        Me.btnEnviar.Name = "btnEnviar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 2
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1008, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 618)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 618)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 618)
        '
        'grpDadosMensagem
        '
        Me.grpDadosMensagem.Controls.Add(Me.WebBrowser1)
        Me.grpDadosMensagem.Controls.Add(Me.dblformatoNumero)
        Me.grpDadosMensagem.Controls.Add(Me.lblDDI)
        Me.grpDadosMensagem.Controls.Add(Me.txtTitulo)
        Me.grpDadosMensagem.Controls.Add(Me.lblTitulo)
        Me.grpDadosMensagem.Controls.Add(Me.txtNumeroComDdd)
        Me.grpDadosMensagem.Controls.Add(Me.lblNumero)
        Me.grpDadosMensagem.Controls.Add(Me.txtDDI)
        Me.grpDadosMensagem.Controls.Add(Me.lblMensagemEnvio)
        Me.grpDadosMensagem.Controls.Add(Me.memMensagem)
        Me.grpDadosMensagem.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpDadosMensagem.Location = New System.Drawing.Point(486, 0)
        Me.grpDadosMensagem.Name = "grpDadosMensagem"
        Me.grpDadosMensagem.Size = New System.Drawing.Size(522, 618)
        Me.grpDadosMensagem.TabIndex = 15
        Me.grpDadosMensagem.Text = "Whatsapp"
        '
        'dblformatoNumero
        '
        Me.dblformatoNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dblformatoNumero.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.dblformatoNumero.Location = New System.Drawing.Point(122, 177)
        Me.dblformatoNumero.Name = "dblformatoNumero"
        Me.dblformatoNumero.Size = New System.Drawing.Size(72, 13)
        Me.dblformatoNumero.TabIndex = 15
        Me.dblformatoNumero.Text = "DDD+NÚMERO"
        '
        'lblDDI
        '
        Me.lblDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDDI.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDDI.Location = New System.Drawing.Point(75, 177)
        Me.lblDDI.Name = "lblDDI"
        Me.lblDDI.Size = New System.Drawing.Size(18, 13)
        Me.lblDDI.TabIndex = 14
        Me.lblDDI.Text = "DDI"
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitulo.Location = New System.Drawing.Point(62, 222)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Properties.MaxLength = 50
        Me.txtTitulo.Size = New System.Drawing.Size(416, 20)
        Me.txtTitulo.TabIndex = 13
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Location = New System.Drawing.Point(30, 225)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(26, 13)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Título"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(5, 348)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(512, 265)
        Me.WebBrowser1.TabIndex = 16
        '
        'frmWhatsapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.grdListaClientes)
        Me.Controls.Add(Me.grpDadosMensagem)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosMensagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosMensagem.ResumeLayout(False)
        Me.grpDadosMensagem.PerformLayout()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNumeroComDdd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensagemEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memMensagem As DevExpress.XtraEditors.MemoEdit
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents L As DevExpress.XtraBars.Bar
    Friend WithEvents btnEnviar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpDadosMensagem As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dblformatoNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDDI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
