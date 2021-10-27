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
        Me.dblformatoNumero = New DevExpress.XtraEditors.LabelControl()
        Me.lblDDI = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroComDdd = New DevExpress.XtraEditors.TextEdit()
        Me.lblNumero = New DevExpress.XtraEditors.LabelControl()
        Me.txtDDI = New DevExpress.XtraEditors.TextEdit()
        Me.lblMensagemEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.memMensagem = New DevExpress.XtraEditors.MemoEdit()
        Me.tabPrincipal = New DevExpress.XtraTab.XtraTabControl()
        Me.tabEnviarMensagem = New DevExpress.XtraTab.XtraTabPage()
        Me.cboEnviarArquivo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEnviarSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblAnexo = New DevExpress.XtraEditors.LabelControl()
        Me.cboTitulo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblWhatsapp = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.tabConfigurações = New DevExpress.XtraTab.XtraTabPage()
        Me.btnRemoverMensagem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalvarMensagem = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.lblTagPularLinha = New DevExpress.XtraEditors.LabelControl()
        Me.lblPularLinha = New DevExpress.XtraEditors.LabelControl()
        Me.lblTagQuebrarLinha = New DevExpress.XtraEditors.LabelControl()
        Me.lblQuebrarLinha = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTagMaquina = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTagEmpresa = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmpresa = New DevExpress.XtraEditors.LabelControl()
        Me.lblTagCliente = New DevExpress.XtraEditors.LabelControl()
        Me.lblOrientacoes = New DevExpress.XtraEditors.LabelControl()
        Me.lblObjetivoCliente = New DevExpress.XtraEditors.LabelControl()
        Me.cboTituloConfig = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.memMensagemConfig = New DevExpress.XtraEditors.MemoEdit()
        Me.lblMensagemConfig = New DevExpress.XtraEditors.LabelControl()
        Me.lblTituloConfig = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.lblClientesCadastrados = New DevExpress.XtraEditors.LabelControl()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.tabEnviarMensagem.SuspendLayout()
        CType(Me.cboEnviarArquivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfigurações.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.cboTituloConfig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMensagemConfig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdListaClientes
        '
        Me.grdListaClientes.DataMember = "dtListaContato"
        Me.grdListaClientes.DataSource = Me.dsListaContato
        Me.grdListaClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdListaClientes.Location = New System.Drawing.Point(2, 124)
        Me.grdListaClientes.MainView = Me.grd1
        Me.grdListaClientes.Name = "grdListaClientes"
        Me.grdListaClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdListaClientes.Size = New System.Drawing.Size(433, 325)
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
        'dblformatoNumero
        '
        Me.dblformatoNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dblformatoNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dblformatoNumero.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.dblformatoNumero.Location = New System.Drawing.Point(390, 46)
        Me.dblformatoNumero.Name = "dblformatoNumero"
        Me.dblformatoNumero.Size = New System.Drawing.Size(80, 13)
        Me.dblformatoNumero.TabIndex = 29
        Me.dblformatoNumero.Text = "DDD+NÚMERO"
        Me.dblformatoNumero.ToolTip = "Discagem Direta à Distância + Número de Telefone) "
        '
        'lblDDI
        '
        Me.lblDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDDI.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDDI.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDDI.Location = New System.Drawing.Point(337, 46)
        Me.lblDDI.Name = "lblDDI"
        Me.lblDDI.Size = New System.Drawing.Size(40, 13)
        Me.lblDDI.TabIndex = 28
        Me.lblDDI.Text = "DDI (?)"
        Me.lblDDI.ToolTip = "Discagem Direta Internacional (Brasil = 55)"
        Me.lblDDI.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(64, 120)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "Título:"
        '
        'txtNumeroComDdd
        '
        Me.txtNumeroComDdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroComDdd.EnterMoveNextControl = True
        Me.txtNumeroComDdd.Location = New System.Drawing.Point(376, 65)
        Me.txtNumeroComDdd.Name = "txtNumeroComDdd"
        Me.txtNumeroComDdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroComDdd.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroComDdd.Properties.MaxLength = 15
        Me.txtNumeroComDdd.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroComDdd.TabIndex = 1
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.Location = New System.Drawing.Point(282, 68)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 22
        Me.lblNumero.Text = "Número"
        '
        'txtDDI
        '
        Me.txtDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDDI.EnterMoveNextControl = True
        Me.txtDDI.Location = New System.Drawing.Point(332, 65)
        Me.txtDDI.Name = "txtDDI"
        Me.txtDDI.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDDI.Properties.Appearance.Options.UseFont = True
        Me.txtDDI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDDI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDDI.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDDI.Properties.MaxLength = 15
        Me.txtDDI.Size = New System.Drawing.Size(45, 20)
        Me.txtDDI.TabIndex = 0
        '
        'lblMensagemEnvio
        '
        Me.lblMensagemEnvio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensagemEnvio.Location = New System.Drawing.Point(34, 146)
        Me.lblMensagemEnvio.Name = "lblMensagemEnvio"
        Me.lblMensagemEnvio.Size = New System.Drawing.Size(65, 13)
        Me.lblMensagemEnvio.TabIndex = 23
        Me.lblMensagemEnvio.Text = "Mensagem:"
        '
        'memMensagem
        '
        Me.memMensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memMensagem.EnterMoveNextControl = True
        Me.memMensagem.Location = New System.Drawing.Point(105, 143)
        Me.memMensagem.Name = "memMensagem"
        Me.memMensagem.Size = New System.Drawing.Size(365, 224)
        Me.memMensagem.TabIndex = 3
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPrincipal.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tabPrincipal.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabPrincipal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tabPrincipal.Appearance.Options.UseBackColor = True
        Me.tabPrincipal.Appearance.Options.UseFont = True
        Me.tabPrincipal.Appearance.Options.UseForeColor = True
        Me.tabPrincipal.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.tabPrincipal.AppearancePage.Header.Options.UseBackColor = True
        Me.tabPrincipal.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabPrincipal.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.tabPrincipal.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabPrincipal.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.tabPrincipal.Location = New System.Drawing.Point(455, 70)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedTabPage = Me.tabEnviarMensagem
        Me.tabPrincipal.Size = New System.Drawing.Size(492, 411)
        Me.tabPrincipal.TabIndex = 30
        Me.tabPrincipal.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabEnviarMensagem, Me.tabConfigurações})
        '
        'tabEnviarMensagem
        '
        Me.tabEnviarMensagem.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabEnviarMensagem.Appearance.Header.Options.UseFont = True
        Me.tabEnviarMensagem.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.tabEnviarMensagem.Appearance.HeaderActive.Options.UseForeColor = True
        Me.tabEnviarMensagem.Controls.Add(Me.cboEnviarArquivo)
        Me.tabEnviarMensagem.Controls.Add(Me.lblAnexo)
        Me.tabEnviarMensagem.Controls.Add(Me.cboTitulo)
        Me.tabEnviarMensagem.Controls.Add(Me.lblWhatsapp)
        Me.tabEnviarMensagem.Controls.Add(Me.PictureEdit1)
        Me.tabEnviarMensagem.Controls.Add(Me.txtDDI)
        Me.tabEnviarMensagem.Controls.Add(Me.dblformatoNumero)
        Me.tabEnviarMensagem.Controls.Add(Me.memMensagem)
        Me.tabEnviarMensagem.Controls.Add(Me.lblDDI)
        Me.tabEnviarMensagem.Controls.Add(Me.lblMensagemEnvio)
        Me.tabEnviarMensagem.Controls.Add(Me.lblNumero)
        Me.tabEnviarMensagem.Controls.Add(Me.lblTitulo)
        Me.tabEnviarMensagem.Controls.Add(Me.txtNumeroComDdd)
        Me.tabEnviarMensagem.Name = "tabEnviarMensagem"
        Me.tabEnviarMensagem.Size = New System.Drawing.Size(486, 383)
        Me.tabEnviarMensagem.Text = "Enviar Mensagem"
        '
        'cboEnviarArquivo
        '
        Me.cboEnviarArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEnviarArquivo.EnterMoveNextControl = True
        Me.cboEnviarArquivo.Location = New System.Drawing.Point(105, 92)
        Me.cboEnviarArquivo.MenuManager = Me.BarManager1
        Me.cboEnviarArquivo.Name = "cboEnviarArquivo"
        Me.cboEnviarArquivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cboEnviarArquivo.Properties.CaseSensitiveSearch = True
        Me.cboEnviarArquivo.Size = New System.Drawing.Size(365, 20)
        Me.cboEnviarArquivo.TabIndex = 34
        Me.cboEnviarArquivo.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnClientes, Me.btnEnviarSalvar, Me.btnFechar, Me.btnLimpar})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClientes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEnviarSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnClientes
        '
        Me.btnClientes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnClientes.Caption = "Clientes"
        Me.btnClientes.Glyph = Global.telausuario.My.Resources.Resources.Cliente
        Me.btnClientes.Id = 0
        Me.btnClientes.Name = "btnClientes"
        '
        'btnEnviarSalvar
        '
        Me.btnEnviarSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEnviarSalvar.Caption = "Enviar"
        Me.btnEnviarSalvar.Glyph = Global.telausuario.My.Resources.Resources.apply18x18
        Me.btnEnviarSalvar.Id = 1
        Me.btnEnviarSalvar.Name = "btnEnviarSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(956, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 487)
        Me.barDockControlBottom.Size = New System.Drawing.Size(956, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(956, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'lblAnexo
        '
        Me.lblAnexo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAnexo.Location = New System.Drawing.Point(15, 95)
        Me.lblAnexo.Name = "lblAnexo"
        Me.lblAnexo.Size = New System.Drawing.Size(84, 13)
        Me.lblAnexo.TabIndex = 33
        Me.lblAnexo.Text = "Enviar arquivo:"
        Me.lblAnexo.Visible = False
        '
        'cboTitulo
        '
        Me.cboTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTitulo.EnterMoveNextControl = True
        Me.cboTitulo.Location = New System.Drawing.Point(105, 117)
        Me.cboTitulo.MenuManager = Me.BarManager1
        Me.cboTitulo.Name = "cboTitulo"
        Me.cboTitulo.Properties.AutoComplete = False
        Me.cboTitulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTitulo.Properties.CaseSensitiveSearch = True
        Me.cboTitulo.Size = New System.Drawing.Size(365, 20)
        Me.cboTitulo.TabIndex = 2
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWhatsapp.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblWhatsapp.Location = New System.Drawing.Point(86, 20)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(166, 35)
        Me.lblWhatsapp.TabIndex = 0
        Me.lblWhatsapp.Text = "WHATSAPP"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.telausuario.My.Resources.Resources.Message_Bubble_icon1
        Me.PictureEdit1.Location = New System.Drawing.Point(6, 7)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PictureEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PictureEdit1.Size = New System.Drawing.Size(87, 69)
        Me.PictureEdit1.TabIndex = 32
        '
        'tabConfigurações
        '
        Me.tabConfigurações.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabConfigurações.Appearance.Header.Options.UseFont = True
        Me.tabConfigurações.Controls.Add(Me.btnRemoverMensagem)
        Me.tabConfigurações.Controls.Add(Me.btnSalvarMensagem)
        Me.tabConfigurações.Controls.Add(Me.PanelControl4)
        Me.tabConfigurações.Controls.Add(Me.cboTituloConfig)
        Me.tabConfigurações.Controls.Add(Me.memMensagemConfig)
        Me.tabConfigurações.Controls.Add(Me.lblMensagemConfig)
        Me.tabConfigurações.Controls.Add(Me.lblTituloConfig)
        Me.tabConfigurações.Name = "tabConfigurações"
        Me.tabConfigurações.Size = New System.Drawing.Size(486, 383)
        Me.tabConfigurações.Text = "Configurar Mensagem Automática"
        '
        'btnRemoverMensagem
        '
        Me.btnRemoverMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoverMensagem.Image = Global.telausuario.My.Resources.Resources.delete
        Me.btnRemoverMensagem.Location = New System.Drawing.Point(220, 242)
        Me.btnRemoverMensagem.Name = "btnRemoverMensagem"
        Me.btnRemoverMensagem.Size = New System.Drawing.Size(96, 35)
        Me.btnRemoverMensagem.TabIndex = 43
        Me.btnRemoverMensagem.Text = "Remover"
        '
        'btnSalvarMensagem
        '
        Me.btnSalvarMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarMensagem.Image = Global.telausuario.My.Resources.Resources.apply
        Me.btnSalvarMensagem.Location = New System.Drawing.Point(322, 242)
        Me.btnSalvarMensagem.Name = "btnSalvarMensagem"
        Me.btnSalvarMensagem.Size = New System.Drawing.Size(148, 35)
        Me.btnSalvarMensagem.TabIndex = 42
        Me.btnSalvarMensagem.Text = "Salvar Mensagem"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.lblTagPularLinha)
        Me.PanelControl4.Controls.Add(Me.lblPularLinha)
        Me.PanelControl4.Controls.Add(Me.lblTagQuebrarLinha)
        Me.PanelControl4.Controls.Add(Me.lblQuebrarLinha)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.lblTagMaquina)
        Me.PanelControl4.Controls.Add(Me.LabelControl6)
        Me.PanelControl4.Controls.Add(Me.lblTagEmpresa)
        Me.PanelControl4.Controls.Add(Me.lblEmpresa)
        Me.PanelControl4.Controls.Add(Me.lblTagCliente)
        Me.PanelControl4.Controls.Add(Me.lblOrientacoes)
        Me.PanelControl4.Controls.Add(Me.lblObjetivoCliente)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 283)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(486, 100)
        Me.PanelControl4.TabIndex = 41
        '
        'lblTagPularLinha
        '
        Me.lblTagPularLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagPularLinha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagPularLinha.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTagPularLinha.Location = New System.Drawing.Point(382, 73)
        Me.lblTagPularLinha.Name = "lblTagPularLinha"
        Me.lblTagPularLinha.Size = New System.Drawing.Size(48, 14)
        Me.lblTagPularLinha.TabIndex = 51
        Me.lblTagPularLinha.Text = "<PLIN>"
        '
        'lblPularLinha
        '
        Me.lblPularLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPularLinha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPularLinha.Location = New System.Drawing.Point(283, 73)
        Me.lblPularLinha.Name = "lblPularLinha"
        Me.lblPularLinha.Size = New System.Drawing.Size(72, 14)
        Me.lblPularLinha.TabIndex = 50
        Me.lblPularLinha.Text = "Pular Linha:"
        '
        'lblTagQuebrarLinha
        '
        Me.lblTagQuebrarLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagQuebrarLinha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagQuebrarLinha.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTagQuebrarLinha.Location = New System.Drawing.Point(374, 51)
        Me.lblTagQuebrarLinha.Name = "lblTagQuebrarLinha"
        Me.lblTagQuebrarLinha.Size = New System.Drawing.Size(57, 14)
        Me.lblTagQuebrarLinha.TabIndex = 49
        Me.lblTagQuebrarLinha.Text = "<QBLIN>"
        '
        'lblQuebrarLinha
        '
        Me.lblQuebrarLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuebrarLinha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuebrarLinha.Location = New System.Drawing.Point(265, 51)
        Me.lblQuebrarLinha.Name = "lblQuebrarLinha"
        Me.lblQuebrarLinha.Size = New System.Drawing.Size(90, 14)
        Me.lblQuebrarLinha.TabIndex = 48
        Me.lblQuebrarLinha.Text = "Quebrar Linha:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelControl3.Location = New System.Drawing.Point(385, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 14)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "<DAT>"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(322, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl4.TabIndex = 46
        Me.LabelControl4.Text = "Data:"
        '
        'lblTagMaquina
        '
        Me.lblTagMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagMaquina.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagMaquina.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTagMaquina.Location = New System.Drawing.Point(167, 51)
        Me.lblTagMaquina.Name = "lblTagMaquina"
        Me.lblTagMaquina.Size = New System.Drawing.Size(52, 14)
        Me.lblTagMaquina.TabIndex = 44
        Me.lblTagMaquina.Text = "<USER>"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(22, 51)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(114, 14)
        Me.LabelControl6.TabIndex = 43
        Me.LabelControl6.Text = "Usuário - Máquina:"
        '
        'lblTagEmpresa
        '
        Me.lblTagEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagEmpresa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagEmpresa.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTagEmpresa.Location = New System.Drawing.Point(157, 29)
        Me.lblTagEmpresa.Name = "lblTagEmpresa"
        Me.lblTagEmpresa.Size = New System.Drawing.Size(62, 14)
        Me.lblTagEmpresa.TabIndex = 42
        Me.lblTagEmpresa.Text = "<EMPRE>"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmpresa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpresa.Location = New System.Drawing.Point(81, 29)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(55, 14)
        Me.lblEmpresa.TabIndex = 41
        Me.lblEmpresa.Text = "Empresa:"
        '
        'lblTagCliente
        '
        Me.lblTagCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTagCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagCliente.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTagCliente.Location = New System.Drawing.Point(177, 73)
        Me.lblTagCliente.Name = "lblTagCliente"
        Me.lblTagCliente.Size = New System.Drawing.Size(40, 14)
        Me.lblTagCliente.TabIndex = 40
        Me.lblTagCliente.Text = "<CLI>"
        '
        'lblOrientacoes
        '
        Me.lblOrientacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrientacoes.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblOrientacoes.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.lblOrientacoes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblOrientacoes.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblOrientacoes.Location = New System.Drawing.Point(5, 5)
        Me.lblOrientacoes.Name = "lblOrientacoes"
        Me.lblOrientacoes.Size = New System.Drawing.Size(270, 18)
        Me.lblOrientacoes.TabIndex = 38
        Me.lblOrientacoes.Text = "Deixe sua mensagem personalizada:"
        '
        'lblObjetivoCliente
        '
        Me.lblObjetivoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObjetivoCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblObjetivoCliente.Location = New System.Drawing.Point(90, 73)
        Me.lblObjetivoCliente.Name = "lblObjetivoCliente"
        Me.lblObjetivoCliente.Size = New System.Drawing.Size(46, 14)
        Me.lblObjetivoCliente.TabIndex = 39
        Me.lblObjetivoCliente.Text = "Cliente:"
        '
        'cboTituloConfig
        '
        Me.cboTituloConfig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTituloConfig.Location = New System.Drawing.Point(73, 20)
        Me.cboTituloConfig.MenuManager = Me.BarManager1
        Me.cboTituloConfig.Name = "cboTituloConfig"
        Me.cboTituloConfig.Properties.AutoComplete = False
        Me.cboTituloConfig.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTituloConfig.Size = New System.Drawing.Size(397, 20)
        Me.cboTituloConfig.TabIndex = 37
        '
        'memMensagemConfig
        '
        Me.memMensagemConfig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memMensagemConfig.Location = New System.Drawing.Point(73, 46)
        Me.memMensagemConfig.Name = "memMensagemConfig"
        Me.memMensagemConfig.Size = New System.Drawing.Size(397, 191)
        Me.memMensagemConfig.TabIndex = 35
        '
        'lblMensagemConfig
        '
        Me.lblMensagemConfig.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensagemConfig.Location = New System.Drawing.Point(5, 48)
        Me.lblMensagemConfig.Name = "lblMensagemConfig"
        Me.lblMensagemConfig.Size = New System.Drawing.Size(62, 13)
        Me.lblMensagemConfig.TabIndex = 34
        Me.lblMensagemConfig.Text = "Mensagem"
        '
        'lblTituloConfig
        '
        Me.lblTituloConfig.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTituloConfig.Location = New System.Drawing.Point(35, 23)
        Me.lblTituloConfig.Name = "lblTituloConfig"
        Me.lblTituloConfig.Size = New System.Drawing.Size(32, 13)
        Me.lblTituloConfig.TabIndex = 36
        Me.lblTituloConfig.Text = "Título"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.lblCliente)
        Me.PanelControl1.Controls.Add(Me.tabPrincipal)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(956, 487)
        Me.PanelControl1.TabIndex = 32
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Controls.Add(Me.grdListaClientes)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 25)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(437, 451)
        Me.PanelControl3.TabIndex = 33
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.PictureEdit2)
        Me.PanelControl2.Controls.Add(Me.lblClientesCadastrados)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(433, 122)
        Me.PanelControl2.TabIndex = 31
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.telausuario.My.Resources.Resources.Nano
        Me.PictureEdit2.Location = New System.Drawing.Point(3, 3)
        Me.PictureEdit2.MenuManager = Me.BarManager1
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(118, 113)
        Me.PictureEdit2.TabIndex = 2
        '
        'lblClientesCadastrados
        '
        Me.lblClientesCadastrados.Appearance.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblClientesCadastrados.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClientesCadastrados.Location = New System.Drawing.Point(127, 43)
        Me.lblClientesCadastrados.Name = "lblClientesCadastrados"
        Me.lblClientesCadastrados.Size = New System.Drawing.Size(297, 28)
        Me.lblClientesCadastrados.TabIndex = 1
        Me.lblClientesCadastrados.Text = "CLIENTES CADASTRADOS"
        '
        'lblCliente
        '
        Me.lblCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblCliente.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(456, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(82, 28)
        Me.lblCliente.TabIndex = 32
        Me.lblCliente.Text = "Cliente"
        '
        'frmWhatsapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 522)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmWhatsapp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWhatsapp"
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabEnviarMensagem.ResumeLayout(False)
        Me.tabEnviarMensagem.PerformLayout()
        CType(Me.cboEnviarArquivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfigurações.ResumeLayout(False)
        Me.tabConfigurações.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.cboTituloConfig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memMensagemConfig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdListaClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsListaContato As System.Data.DataSet
    Friend WithEvents dtListaContato As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblWhatsapp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabPrincipal As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabEnviarMensagem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDDI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dblformatoNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memMensagem As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblDDI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensagemEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroComDdd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabConfigurações As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblClientesCadastrados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEnviarSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cboTitulo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboTituloConfig As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents memMensagemConfig As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblMensagemConfig As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTituloConfig As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTagCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblObjetivoCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTagMaquina As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTagEmpresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmpresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOrientacoes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTagQuebrarLinha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblQuebrarLinha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalvarMensagem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTagPularLinha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPularLinha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemoverMensagem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAnexo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboEnviarArquivo As DevExpress.XtraEditors.ComboBoxEdit
End Class
