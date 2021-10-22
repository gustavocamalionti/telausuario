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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.L = New DevExpress.XtraBars.Bar()
        Me.btnClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnEnviar = New DevExpress.XtraBars.BarButtonItem()
        Me.dblformatoNumero = New DevExpress.XtraEditors.LabelControl()
        Me.lblDDI = New DevExpress.XtraEditors.LabelControl()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroComDdd = New DevExpress.XtraEditors.TextEdit()
        Me.lblNumero = New DevExpress.XtraEditors.LabelControl()
        Me.txtDDI = New DevExpress.XtraEditors.TextEdit()
        Me.lblMensagemEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.memMensagem = New DevExpress.XtraEditors.MemoEdit()
        Me.tabPrincipal = New DevExpress.XtraTab.XtraTabControl()
        Me.tabEnviarMensagem = New DevExpress.XtraTab.XtraTabPage()
        Me.tabConfigurações = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblWhatsapp = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtListaContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.tabEnviarMensagem.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdListaClientes
        '
        Me.grdListaClientes.DataMember = "dtListaContato"
        Me.grdListaClientes.DataSource = Me.dsListaContato
        Me.grdListaClientes.Location = New System.Drawing.Point(12, 144)
        Me.grdListaClientes.MainView = Me.grd1
        Me.grdListaClientes.Name = "grdListaClientes"
        Me.grdListaClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdListaClientes.Size = New System.Drawing.Size(436, 324)
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.L})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEnviar, Me.btnFechar, Me.btnLimpar, Me.btnClientes, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.L
        '
        'L
        '
        Me.L.BarName = "Status bar"
        Me.L.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.L.DockCol = 0
        Me.L.DockRow = 0
        Me.L.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.L.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClientes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 487)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 35)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'btnEnviar
        '
        Me.btnEnviar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEnviar.Caption = "Enviar"
        Me.btnEnviar.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.btnEnviar.Id = 0
        Me.btnEnviar.Name = "btnEnviar"
        '
        'dblformatoNumero
        '
        Me.dblformatoNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dblformatoNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dblformatoNumero.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.dblformatoNumero.Location = New System.Drawing.Point(129, 24)
        Me.dblformatoNumero.Name = "dblformatoNumero"
        Me.dblformatoNumero.Size = New System.Drawing.Size(80, 13)
        Me.dblformatoNumero.TabIndex = 29
        Me.dblformatoNumero.Text = "DDD+NÚMERO"
        '
        'lblDDI
        '
        Me.lblDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDDI.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDDI.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDDI.Location = New System.Drawing.Point(88, 24)
        Me.lblDDI.Name = "lblDDI"
        Me.lblDDI.Size = New System.Drawing.Size(21, 13)
        Me.lblDDI.TabIndex = 28
        Me.lblDDI.Text = "DDI"
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitulo.Location = New System.Drawing.Point(74, 69)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTitulo.Properties.Appearance.Options.UseFont = True
        Me.txtTitulo.Properties.MaxLength = 50
        Me.txtTitulo.Size = New System.Drawing.Size(424, 20)
        Me.txtTitulo.TabIndex = 27
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(36, 72)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(32, 13)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "Título"
        '
        'txtNumeroComDdd
        '
        Me.txtNumeroComDdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroComDdd.Location = New System.Drawing.Point(118, 43)
        Me.txtNumeroComDdd.Name = "txtNumeroComDdd"
        Me.txtNumeroComDdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroComDdd.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroComDdd.Properties.MaxLength = 15
        Me.txtNumeroComDdd.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroComDdd.TabIndex = 21
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.Location = New System.Drawing.Point(24, 46)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 22
        Me.lblNumero.Text = "Número"
        '
        'txtDDI
        '
        Me.txtDDI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDDI.Location = New System.Drawing.Point(74, 43)
        Me.txtDDI.Name = "txtDDI"
        Me.txtDDI.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDDI.Properties.Appearance.Options.UseFont = True
        Me.txtDDI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDDI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDDI.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDDI.Properties.MaxLength = 15
        Me.txtDDI.Size = New System.Drawing.Size(45, 20)
        Me.txtDDI.TabIndex = 25
        '
        'lblMensagemEnvio
        '
        Me.lblMensagemEnvio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensagemEnvio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensagemEnvio.Location = New System.Drawing.Point(6, 97)
        Me.lblMensagemEnvio.Name = "lblMensagemEnvio"
        Me.lblMensagemEnvio.Size = New System.Drawing.Size(62, 13)
        Me.lblMensagemEnvio.TabIndex = 23
        Me.lblMensagemEnvio.Text = "Mensagem"
        '
        'memMensagem
        '
        Me.memMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.memMensagem.Location = New System.Drawing.Point(74, 95)
        Me.memMensagem.Name = "memMensagem"
        Me.memMensagem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.memMensagem.Properties.Appearance.Options.UseFont = True
        Me.memMensagem.Size = New System.Drawing.Size(424, 181)
        Me.memMensagem.TabIndex = 24
        '
        'tabPrincipal
        '
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
        Me.tabPrincipal.Location = New System.Drawing.Point(467, 103)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SelectedTabPage = Me.tabEnviarMensagem
        Me.tabPrincipal.Size = New System.Drawing.Size(515, 320)
        Me.tabPrincipal.TabIndex = 30
        Me.tabPrincipal.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabEnviarMensagem, Me.tabConfigurações})
        '
        'tabEnviarMensagem
        '
        Me.tabEnviarMensagem.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabEnviarMensagem.Appearance.Header.Options.UseFont = True
        Me.tabEnviarMensagem.Appearance.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.tabEnviarMensagem.Appearance.HeaderActive.Options.UseForeColor = True
        Me.tabEnviarMensagem.Controls.Add(Me.txtDDI)
        Me.tabEnviarMensagem.Controls.Add(Me.dblformatoNumero)
        Me.tabEnviarMensagem.Controls.Add(Me.memMensagem)
        Me.tabEnviarMensagem.Controls.Add(Me.lblDDI)
        Me.tabEnviarMensagem.Controls.Add(Me.lblMensagemEnvio)
        Me.tabEnviarMensagem.Controls.Add(Me.txtTitulo)
        Me.tabEnviarMensagem.Controls.Add(Me.lblNumero)
        Me.tabEnviarMensagem.Controls.Add(Me.lblTitulo)
        Me.tabEnviarMensagem.Controls.Add(Me.txtNumeroComDdd)
        Me.tabEnviarMensagem.Name = "tabEnviarMensagem"
        Me.tabEnviarMensagem.Size = New System.Drawing.Size(509, 292)
        Me.tabEnviarMensagem.Text = "Enviar Mensagem"
        '
        'tabConfigurações
        '
        Me.tabConfigurações.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabConfigurações.Appearance.Header.Options.UseFont = True
        Me.tabConfigurações.Name = "tabConfigurações"
        Me.tabConfigurações.Size = New System.Drawing.Size(509, 292)
        Me.tabConfigurações.Text = "Configurar Mensagem Automática"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblWhatsapp)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.grdListaClientes)
        Me.PanelControl1.Controls.Add(Me.tabPrincipal)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 487)
        Me.PanelControl1.TabIndex = 32
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblWhatsapp.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblWhatsapp.Location = New System.Drawing.Point(191, 12)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(257, 48)
        Me.lblWhatsapp.TabIndex = 0
        Me.lblWhatsapp.Text = "- WHATSAPP"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Location = New System.Drawing.Point(12, 66)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(436, 79)
        Me.PanelControl2.TabIndex = 31
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Enviar"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmWhatsapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 522)
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroComDdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDDI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memMensagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabEnviarMensagem.ResumeLayout(False)
        Me.tabEnviarMensagem.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents L As DevExpress.XtraBars.Bar
    Friend WithEvents btnClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblWhatsapp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabPrincipal As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabEnviarMensagem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDDI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dblformatoNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memMensagem As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblDDI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensagemEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroComDdd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabConfigurações As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnEnviar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
