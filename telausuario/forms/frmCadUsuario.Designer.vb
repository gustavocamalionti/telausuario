<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadUsuario
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barRodape = New DevExpress.XtraBars.Bar()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grpUsuariosCadastrados = New DevExpress.XtraEditors.GroupControl()
        Me.chkInativo = New DevExpress.XtraEditors.CheckEdit()
        Me.grdUsuariosCadastrados = New DevExpress.XtraGrid.GridControl()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTelaUsuario = New telausuario.dsTelaUsuario()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colLogin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSenha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNivel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsultas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelatorios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSkin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanoFundo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFundoPadrao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExibicao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UsuarioTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLoja = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.rdgNivel = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSenha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtConfirmarSenha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUsuariosCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUsuariosCadastrados.SuspendLayout()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUsuariosCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmarSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barRodape})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.barRodape
        '
        'barRodape
        '
        Me.barRodape.BarName = "Status bar"
        Me.barRodape.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.barRodape.DockCol = 0
        Me.barRodape.DockRow = 0
        Me.barRodape.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.barRodape.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.barRodape.OptionsBar.AllowQuickCustomization = False
        Me.barRodape.OptionsBar.DrawDragBorder = False
        Me.barRodape.OptionsBar.UseWholeRow = True
        Me.barRodape.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnExcluir.Caption = "Excluir"
        Me.btnExcluir.Glyph = Global.telausuario.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "Alterar"
        Me.btnAlterar.Glyph = Global.telausuario.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
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
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(576, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 433)
        Me.barDockControlBottom.Size = New System.Drawing.Size(576, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 433)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(576, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 433)
        '
        'grpUsuariosCadastrados
        '
        Me.grpUsuariosCadastrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUsuariosCadastrados.Controls.Add(Me.chkInativo)
        Me.grpUsuariosCadastrados.Controls.Add(Me.grdUsuariosCadastrados)
        Me.grpUsuariosCadastrados.Location = New System.Drawing.Point(0, 178)
        Me.grpUsuariosCadastrados.Name = "grpUsuariosCadastrados"
        Me.grpUsuariosCadastrados.Size = New System.Drawing.Size(576, 256)
        Me.grpUsuariosCadastrados.TabIndex = 4
        Me.grpUsuariosCadastrados.Text = "Usuários Cadastrados"
        '
        'chkInativo
        '
        Me.chkInativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInativo.Location = New System.Drawing.Point(496, 2)
        Me.chkInativo.MenuManager = Me.BarManager1
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Properties.Caption = "Inativo"
        Me.chkInativo.Size = New System.Drawing.Size(75, 19)
        Me.chkInativo.TabIndex = 6
        '
        'grdUsuariosCadastrados
        '
        Me.grdUsuariosCadastrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUsuariosCadastrados.DataSource = Me.UsuarioBindingSource
        Me.grdUsuariosCadastrados.Location = New System.Drawing.Point(0, 21)
        Me.grdUsuariosCadastrados.MainView = Me.grd1
        Me.grdUsuariosCadastrados.MenuManager = Me.BarManager1
        Me.grdUsuariosCadastrados.Name = "grdUsuariosCadastrados"
        Me.grdUsuariosCadastrados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdUsuariosCadastrados.Size = New System.Drawing.Size(576, 235)
        Me.grdUsuariosCadastrados.TabIndex = 0
        Me.grdUsuariosCadastrados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DsTelaUsuario
        '
        'DsTelaUsuario
        '
        Me.DsTelaUsuario.DataSetName = "dsTelaUsuario"
        Me.DsTelaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colLogin, Me.colSenha, Me.colNome, Me.colNivel, Me.colPrincipal, Me.colConsultas, Me.colRelatorios, Me.colSkin, Me.colPlanoFundo, Me.colFundoPadrao, Me.colExibicao, Me.colCodConfig, Me.colInativo})
        Me.grd1.GridControl = Me.grdUsuariosCadastrados
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.ColumnEdit = Me.txtAlterarGrid
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'txtAlterarGrid
        '
        Me.txtAlterarGrid.AutoHeight = False
        Me.txtAlterarGrid.Name = "txtAlterarGrid"
        '
        'colLogin
        '
        Me.colLogin.AppearanceCell.Options.UseTextOptions = True
        Me.colLogin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLogin.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLogin.ColumnEdit = Me.txtAlterarGrid
        Me.colLogin.FieldName = "Login"
        Me.colLogin.Name = "colLogin"
        Me.colLogin.Visible = True
        Me.colLogin.VisibleIndex = 0
        '
        'colSenha
        '
        Me.colSenha.AppearanceCell.Options.UseTextOptions = True
        Me.colSenha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSenha.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSenha.ColumnEdit = Me.txtAlterarGrid
        Me.colSenha.FieldName = "Senha"
        Me.colSenha.Name = "colSenha"
        Me.colSenha.Visible = True
        Me.colSenha.VisibleIndex = 1
        '
        'colNome
        '
        Me.colNome.AppearanceCell.Options.UseTextOptions = True
        Me.colNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNome.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNome.ColumnEdit = Me.txtAlterarGrid
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 2
        '
        'colNivel
        '
        Me.colNivel.AppearanceCell.Options.UseTextOptions = True
        Me.colNivel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNivel.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNivel.ColumnEdit = Me.txtAlterarGrid
        Me.colNivel.FieldName = "Nivel"
        Me.colNivel.Name = "colNivel"
        Me.colNivel.Visible = True
        Me.colNivel.VisibleIndex = 3
        '
        'colPrincipal
        '
        Me.colPrincipal.FieldName = "Principal"
        Me.colPrincipal.Name = "colPrincipal"
        '
        'colConsultas
        '
        Me.colConsultas.FieldName = "Consultas"
        Me.colConsultas.Name = "colConsultas"
        '
        'colRelatorios
        '
        Me.colRelatorios.FieldName = "Relatorios"
        Me.colRelatorios.Name = "colRelatorios"
        '
        'colSkin
        '
        Me.colSkin.FieldName = "Skin"
        Me.colSkin.Name = "colSkin"
        '
        'colPlanoFundo
        '
        Me.colPlanoFundo.FieldName = "PlanoFundo"
        Me.colPlanoFundo.Name = "colPlanoFundo"
        '
        'colFundoPadrao
        '
        Me.colFundoPadrao.FieldName = "FundoPadrao"
        Me.colFundoPadrao.Name = "colFundoPadrao"
        '
        'colExibicao
        '
        Me.colExibicao.FieldName = "Exibicao"
        Me.colExibicao.Name = "colExibicao"
        '
        'colCodConfig
        '
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        '
        'colInativo
        '
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjusteQtdeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ConfigTableAdapter = Nothing
        Me.TableAdapterManager.EntradaNfTableAdapter = Nothing
        Me.TableAdapterManager.ItensConsigTableAdapter = Nothing
        Me.TableAdapterManager.OrdensTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.QtdeTableAdapter = Nothing
        Me.TableAdapterManager.TotalConsigTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(111, 12)
        Me.txtNome.MenuManager = Me.BarManager1
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Properties.MaxLength = 80
        Me.txtNome.Size = New System.Drawing.Size(455, 20)
        Me.txtNome.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(80, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Nome"
        '
        'cboLoja
        '
        Me.cboLoja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLoja.EnterMoveNextControl = True
        Me.cboLoja.Location = New System.Drawing.Point(432, 85)
        Me.cboLoja.MenuManager = Me.BarManager1
        Me.cboLoja.Name = "cboLoja"
        Me.cboLoja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoja.Properties.MaxLength = 10
        Me.cboLoja.Size = New System.Drawing.Size(134, 20)
        Me.cboLoja.TabIndex = 5
        '
        'rdgNivel
        '
        Me.rdgNivel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgNivel.Location = New System.Drawing.Point(111, 57)
        Me.rdgNivel.MenuManager = Me.BarManager1
        Me.rdgNivel.Name = "rdgNivel"
        Me.rdgNivel.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "USUÁRIO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "ADMINISTRADOR"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "MASTER")})
        Me.rdgNivel.Size = New System.Drawing.Size(455, 22)
        Me.rdgNivel.TabIndex = 1
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl55.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl55.Location = New System.Drawing.Point(39, 38)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl55.TabIndex = 71
        Me.LabelControl55.Text = "Pessoas Autorizadas"
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Location = New System.Drawing.Point(17, 46)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(549, 5)
        Me.PanelControl4.TabIndex = 70
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(80, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl2.TabIndex = 73
        Me.LabelControl2.Text = "Login"
        '
        'txtLogin
        '
        Me.txtLogin.EnterMoveNextControl = True
        Me.txtLogin.Location = New System.Drawing.Point(111, 85)
        Me.txtLogin.MenuManager = Me.BarManager1
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Properties.MaxLength = 20
        Me.txtLogin.Size = New System.Drawing.Size(156, 20)
        Me.txtLogin.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(75, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl3.TabIndex = 75
        Me.LabelControl3.Text = "Senha"
        '
        'txtSenha
        '
        Me.txtSenha.EnterMoveNextControl = True
        Me.txtSenha.Location = New System.Drawing.Point(111, 111)
        Me.txtSenha.MenuManager = Me.BarManager1
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Properties.MaxLength = 10
        Me.txtSenha.Properties.UseSystemPasswordChar = True
        Me.txtSenha.Size = New System.Drawing.Size(156, 20)
        Me.txtSenha.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(25, 140)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 77
        Me.LabelControl4.Text = "Confirmar Senha"
        '
        'txtConfirmarSenha
        '
        Me.txtConfirmarSenha.EnterMoveNextControl = True
        Me.txtConfirmarSenha.Location = New System.Drawing.Point(111, 137)
        Me.txtConfirmarSenha.MenuManager = Me.BarManager1
        Me.txtConfirmarSenha.Name = "txtConfirmarSenha"
        Me.txtConfirmarSenha.Properties.MaxLength = 10
        Me.txtConfirmarSenha.Properties.UseSystemPasswordChar = True
        Me.txtConfirmarSenha.Size = New System.Drawing.Size(156, 20)
        Me.txtConfirmarSenha.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(82, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 78
        Me.LabelControl5.Text = "Nível"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Location = New System.Drawing.Point(406, 88)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl6.TabIndex = 79
        Me.LabelControl6.Text = "Loja"
        '
        'frmCadUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 468)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtConfirmarSenha)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.LabelControl55)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.rdgNivel)
        Me.Controls.Add(Me.cboLoja)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.grpUsuariosCadastrados)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCadUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Usuário"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUsuariosCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUsuariosCadastrados.ResumeLayout(False)
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUsuariosCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmarSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barRodape As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpUsuariosCadastrados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTelaUsuario As telausuario.dsTelaUsuario
    Friend WithEvents UsuarioTableAdapter As telausuario.dsTelaUsuarioTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager
    Friend WithEvents rdgNivel As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cboLoja As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdUsuariosCadastrados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSenha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNivel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsultas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelatorios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSkin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanoFundo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFundoPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExibicao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConfirmarSenha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSenha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkInativo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
