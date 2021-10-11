<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutos
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.lblModelo = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnAdicionar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFunções = New DevExpress.XtraBars.BarSubItem()
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.tabInicial = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPrincipal = New DevExpress.XtraTab.XtraTabPage()
        Me.pnl = New DevExpress.XtraEditors.PanelControl()
        Me.grdQtde = New DevExpress.XtraGrid.GridControl()
        Me.dsQuantidade = New System.Data.DataSet()
        Me.tbQtd = New System.Data.DataTable()
        Me.Codigo = New System.Data.DataColumn()
        Me.CodProd = New System.Data.DataColumn()
        Me.Tamanho = New System.Data.DataColumn()
        Me.qtdeMaxima = New System.Data.DataColumn()
        Me.Lote = New System.Data.DataColumn()
        Me.ValorCusto = New System.Data.DataColumn()
        Me.QtdeMinima = New System.Data.DataColumn()
        Me.Qtd = New System.Data.DataColumn()
        Me.EmFalta = New System.Data.DataColumn()
        Me.Acabou = New System.Data.DataColumn()
        Me.CodConfig = New System.Data.DataColumn()
        Me.DataFim = New System.Data.DataColumn()
        Me.Cor = New System.Data.DataColumn()
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGridQtde = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqtdeMaxima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtdeMinima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGridNumero = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEmFalta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcabou = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataFim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblObservacao = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.lblEmPromocao = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblValoresProduto = New DevExpress.XtraEditors.LabelControl()
        Me.pnlValoresProduto = New DevExpress.XtraEditors.PanelControl()
        Me.txtLocacao = New DevExpress.XtraEditors.TextEdit()
        Me.memObservacao = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDescontoPorc = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit()
        Me.txtVendaPorc = New DevExpress.XtraEditors.TextEdit()
        Me.txtVenda = New DevExpress.XtraEditors.TextEdit()
        Me.txtCusto = New DevExpress.XtraEditors.TextEdit()
        Me.txtComissao = New DevExpress.XtraEditors.TextEdit()
        Me.cboUniMed = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboTipo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFamilia = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboGrupo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFornecedor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboCodBarra = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboSetor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtProduto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodFor = New DevExpress.XtraEditors.TextEdit()
        Me.lblDescontoPorc = New DevExpress.XtraEditors.LabelControl()
        Me.lblDesconto = New DevExpress.XtraEditors.LabelControl()
        Me.lblCusto = New DevExpress.XtraEditors.LabelControl()
        Me.lblComissao = New DevExpress.XtraEditors.LabelControl()
        Me.lblVenda = New DevExpress.XtraEditors.LabelControl()
        Me.lblTipo = New DevExpress.XtraEditors.LabelControl()
        Me.lblUniMed = New DevExpress.XtraEditors.LabelControl()
        Me.lblLocacao = New DevExpress.XtraEditors.LabelControl()
        Me.lblFamilia = New DevExpress.XtraEditors.LabelControl()
        Me.lblGrupo = New DevExpress.XtraEditors.LabelControl()
        Me.lblFornecedor = New DevExpress.XtraEditors.LabelControl()
        Me.lblSetor = New DevExpress.XtraEditors.LabelControl()
        Me.lblProduto = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodBarra = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodFor = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.chkCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodigoInterno = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tabSATFiscal = New DevExpress.XtraTab.XtraTabPage()
        Me.tabHistorico = New DevExpress.XtraTab.XtraTabPage()
        Me.QtdeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTelaUsuario = New telausuario.dsTelaUsuario()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCapitalEstoque = New DevExpress.XtraEditors.TextEdit()
        Me.cboCustoVenda = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblCapitalEstoque = New System.Windows.Forms.Label()
        Me.txtQtdTotal = New DevExpress.XtraEditors.TextEdit()
        Me.lblQtdTotal = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtProdCadastrados = New DevExpress.XtraEditors.TextEdit()
        Me.lblProdCadastrados = New System.Windows.Forms.Label()
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.ProdutosTableAdapter()
        Me.TableAdapterManager = New telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager()
        Me.grdProdCadastrados = New DevExpress.XtraGrid.GridControl()
        Me.dsProdCadastrados = New System.Data.DataSet()
        Me.tbClienteQtd = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.CodigoInterno = New System.Data.DataColumn()
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVenda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidMed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservacao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlterarPreco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuplicar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTribPadrao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodProd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTamanho1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqtdeMaxima1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLote1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorCusto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmFalta1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAcabou1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodConfig1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataFim1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodBarra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpProdCadastrados = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimparBusca = New DevExpress.XtraEditors.SimpleButton()
        Me.cboBuscarProd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblInativo = New DevExpress.XtraEditors.LabelControl()
        Me.chkInativo = New DevExpress.XtraEditors.CheckEdit()
        Me.lblTribPadrao = New DevExpress.XtraEditors.LabelControl()
        Me.chkTribPadrao = New DevExpress.XtraEditors.CheckEdit()
        Me.lblAlterarPreco = New DevExpress.XtraEditors.LabelControl()
        Me.chkAlterarPreco = New DevExpress.XtraEditors.CheckEdit()
        Me.lblDuplicar = New DevExpress.XtraEditors.LabelControl()
        Me.chkDuplicar = New DevExpress.XtraEditors.CheckEdit()
        Me.QtdeTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.QtdeTableAdapter()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInicial.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.grdQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGridQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGridNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlValoresProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocacao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memObservacao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescontoPorc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendaPorc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComissao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFornecedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodBarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSetor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCapitalEstoque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCustoVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProdCadastrados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProdCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProdCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbClienteQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProdCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProdCadastrados.SuspendLayout()
        CType(Me.cboBuscarProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTribPadrao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterarPreco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDuplicar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.lblModelo, Me.BarEditItem1, Me.btnAdicionar, Me.btnEtiquetas, Me.btnFunções, Me.btnVisualizar, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit2})
        Me.BarManager1.StatusBar = Me.bar1
        '
        'bar1
        '
        Me.bar1.BarAppearance.Disabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bar1.BarAppearance.Disabled.BackColor2 = System.Drawing.Color.Yellow
        Me.bar1.BarAppearance.Disabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bar1.BarAppearance.Disabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bar1.BarAppearance.Disabled.Options.UseBackColor = True
        Me.bar1.BarAppearance.Disabled.Options.UseBorderColor = True
        Me.bar1.BarAppearance.Disabled.Options.UseForeColor = True
        Me.bar1.BarName = "Status bar"
        Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.lblModelo), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdicionar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEtiquetas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFunções, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.bar1.OptionsBar.AllowQuickCustomization = False
        Me.bar1.OptionsBar.DrawDragBorder = False
        Me.bar1.OptionsBar.UseWholeRow = True
        Me.bar1.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "Excluir"
        Me.btnExcluir.Glyph = Global.telausuario.My.Resources.Resources.delete
        Me.btnExcluir.Id = 2
        Me.btnExcluir.Name = "btnExcluir"
        '
        'lblModelo
        '
        Me.lblModelo.Caption = "Modelo"
        Me.lblModelo.Id = 4
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Edit = Me.RepositoryItemButtonEdit2
        Me.BarEditItem1.Glyph = Global.telausuario.My.Resources.Resources.edit_add
        Me.BarEditItem1.Id = 6
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 138
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Glyph = Global.telausuario.My.Resources.Resources.edit_add
        Me.btnAdicionar.Id = 7
        Me.btnAdicionar.Name = "btnAdicionar"
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.Caption = "Etiquetas"
        Me.btnEtiquetas.Glyph = Global.telausuario.My.Resources.Resources.Impressora
        Me.btnEtiquetas.Id = 8
        Me.btnEtiquetas.Name = "btnEtiquetas"
        '
        'btnFunções
        '
        Me.btnFunções.Caption = "Funções"
        Me.btnFunções.Glyph = Global.telausuario.My.Resources.Resources.Giro24
        Me.btnFunções.Id = 10
        Me.btnFunções.Name = "btnFunções"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "Visualizar"
        Me.btnVisualizar.Glyph = Global.telausuario.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 11
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.btnSalvar.Id = 12
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "Alterar"
        Me.btnAlterar.Glyph = Global.telausuario.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 13
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 14
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 15
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 625)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 41)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 625)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 625)
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'tabInicial
        '
        Me.tabInicial.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tabInicial.Appearance.Options.UseBackColor = True
        Me.tabInicial.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabInicial.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabInicial.AppearancePage.Header.ForeColor = System.Drawing.Color.White
        Me.tabInicial.AppearancePage.Header.Options.UseBackColor = True
        Me.tabInicial.AppearancePage.Header.Options.UseFont = True
        Me.tabInicial.AppearancePage.Header.Options.UseForeColor = True
        Me.tabInicial.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabInicial.AppearancePage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.tabInicial.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.tabInicial.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabInicial.Location = New System.Drawing.Point(0, 0)
        Me.tabInicial.Name = "tabInicial"
        Me.tabInicial.SelectedTabPage = Me.tabPrincipal
        Me.tabInicial.Size = New System.Drawing.Size(1008, 295)
        Me.tabInicial.TabIndex = 4
        Me.tabInicial.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPrincipal, Me.tabSATFiscal, Me.tabHistorico})
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.pnl)
        Me.tabPrincipal.Controls.Add(Me.lblObservacao)
        Me.tabPrincipal.Controls.Add(Me.PanelControl3)
        Me.tabPrincipal.Controls.Add(Me.lblEmPromocao)
        Me.tabPrincipal.Controls.Add(Me.PanelControl2)
        Me.tabPrincipal.Controls.Add(Me.lblValoresProduto)
        Me.tabPrincipal.Controls.Add(Me.pnlValoresProduto)
        Me.tabPrincipal.Controls.Add(Me.txtLocacao)
        Me.tabPrincipal.Controls.Add(Me.memObservacao)
        Me.tabPrincipal.Controls.Add(Me.txtDescontoPorc)
        Me.tabPrincipal.Controls.Add(Me.txtDesconto)
        Me.tabPrincipal.Controls.Add(Me.txtVendaPorc)
        Me.tabPrincipal.Controls.Add(Me.txtVenda)
        Me.tabPrincipal.Controls.Add(Me.txtCusto)
        Me.tabPrincipal.Controls.Add(Me.txtComissao)
        Me.tabPrincipal.Controls.Add(Me.cboUniMed)
        Me.tabPrincipal.Controls.Add(Me.cboTipo)
        Me.tabPrincipal.Controls.Add(Me.cboFamilia)
        Me.tabPrincipal.Controls.Add(Me.cboGrupo)
        Me.tabPrincipal.Controls.Add(Me.cboFornecedor)
        Me.tabPrincipal.Controls.Add(Me.cboCodBarra)
        Me.tabPrincipal.Controls.Add(Me.cboSetor)
        Me.tabPrincipal.Controls.Add(Me.txtProduto)
        Me.tabPrincipal.Controls.Add(Me.txtCodFor)
        Me.tabPrincipal.Controls.Add(Me.lblDescontoPorc)
        Me.tabPrincipal.Controls.Add(Me.lblDesconto)
        Me.tabPrincipal.Controls.Add(Me.lblCusto)
        Me.tabPrincipal.Controls.Add(Me.lblComissao)
        Me.tabPrincipal.Controls.Add(Me.lblVenda)
        Me.tabPrincipal.Controls.Add(Me.lblTipo)
        Me.tabPrincipal.Controls.Add(Me.lblUniMed)
        Me.tabPrincipal.Controls.Add(Me.lblLocacao)
        Me.tabPrincipal.Controls.Add(Me.lblFamilia)
        Me.tabPrincipal.Controls.Add(Me.lblGrupo)
        Me.tabPrincipal.Controls.Add(Me.lblFornecedor)
        Me.tabPrincipal.Controls.Add(Me.lblSetor)
        Me.tabPrincipal.Controls.Add(Me.lblProduto)
        Me.tabPrincipal.Controls.Add(Me.lblCodBarra)
        Me.tabPrincipal.Controls.Add(Me.lblCodFor)
        Me.tabPrincipal.Controls.Add(Me.lblCodigo)
        Me.tabPrincipal.Controls.Add(Me.chkCodigo)
        Me.tabPrincipal.Controls.Add(Me.txtCodigoInterno)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton7)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton6)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton5)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton4)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton3)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton2)
        Me.tabPrincipal.Controls.Add(Me.SimpleButton1)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.Size = New System.Drawing.Size(1002, 267)
        Me.tabPrincipal.Text = "Principal"
        '
        'pnl
        '
        Me.pnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.grdQtde)
        Me.pnl.Location = New System.Drawing.Point(630, 22)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(365, 238)
        Me.pnl.TabIndex = 112
        '
        'grdQtde
        '
        Me.grdQtde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdQtde.DataMember = "tbQtd"
        Me.grdQtde.DataSource = Me.dsQuantidade
        GridLevelNode1.RelationName = "Level1"
        Me.grdQtde.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdQtde.Location = New System.Drawing.Point(5, 5)
        Me.grdQtde.MainView = Me.grd3
        Me.grdQtde.MenuManager = Me.BarManager1
        Me.grdQtde.Name = "grdQtde"
        Me.grdQtde.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGridNumero, Me.txtAlterarGridQtde})
        Me.grdQtde.Size = New System.Drawing.Size(355, 228)
        Me.grdQtde.TabIndex = 0
        Me.grdQtde.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3, Me.GridView1})
        '
        'dsQuantidade
        '
        Me.dsQuantidade.DataSetName = "dsQuantidade"
        Me.dsQuantidade.Tables.AddRange(New System.Data.DataTable() {Me.tbQtd})
        '
        'tbQtd
        '
        Me.tbQtd.Columns.AddRange(New System.Data.DataColumn() {Me.Codigo, Me.CodProd, Me.Tamanho, Me.qtdeMaxima, Me.Lote, Me.ValorCusto, Me.QtdeMinima, Me.Qtd, Me.EmFalta, Me.Acabou, Me.CodConfig, Me.DataFim, Me.Cor})
        Me.tbQtd.TableName = "tbQtd"
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.ColumnName = "Codigo"
        '
        'CodProd
        '
        Me.CodProd.Caption = "ColCodPod"
        Me.CodProd.ColumnName = "CodProd"
        '
        'Tamanho
        '
        Me.Tamanho.Caption = "Tamanho"
        Me.Tamanho.ColumnName = "Tamanho"
        '
        'qtdeMaxima
        '
        Me.qtdeMaxima.Caption = "QtdeMaxima"
        Me.qtdeMaxima.ColumnName = "qtdeMaxima"
        '
        'Lote
        '
        Me.Lote.Caption = "Lote"
        Me.Lote.ColumnName = "Lote"
        '
        'ValorCusto
        '
        Me.ValorCusto.Caption = "ValorCusto"
        Me.ValorCusto.ColumnName = "ValorCusto"
        '
        'QtdeMinima
        '
        Me.QtdeMinima.Caption = "QtdeMinima"
        Me.QtdeMinima.ColumnName = "QtdeMinima"
        '
        'Qtd
        '
        Me.Qtd.Caption = "Qtd"
        Me.Qtd.ColumnName = "Qtd"
        '
        'EmFalta
        '
        Me.EmFalta.Caption = "EmFalta"
        Me.EmFalta.ColumnName = "EmFalta"
        '
        'Acabou
        '
        Me.Acabou.Caption = "Acabou"
        Me.Acabou.ColumnName = "Acabou"
        '
        'CodConfig
        '
        Me.CodConfig.Caption = "CodConfig"
        Me.CodConfig.ColumnName = "CodConfig"
        '
        'DataFim
        '
        Me.DataFim.Caption = "DataFim"
        Me.DataFim.ColumnName = "DataFim"
        '
        'Cor
        '
        Me.Cor.Caption = "Cor"
        Me.Cor.ColumnName = "Cor"
        '
        'grd3
        '
        Me.grd3.BestFitMaxRowCount = 1
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo1, Me.colCodProd, Me.colTamanho, Me.colqtdeMaxima, Me.colLote, Me.colValorCusto, Me.colQtdeMinima, Me.colQtd, Me.colEmFalta, Me.colAcabou, Me.colCodConfig, Me.colDataFim, Me.colCor})
        Me.grd3.GridControl = Me.grdQtde
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsNavigation.EnterMoveNextColumn = True
        Me.grd3.OptionsView.EnableAppearanceEvenRow = True
        Me.grd3.OptionsView.EnableAppearanceOddRow = True
        '
        'colCodigo1
        '
        Me.colCodigo1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigo1.ColumnEdit = Me.txtAlterarGridQtde
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.Name = "colCodigo1"
        '
        'txtAlterarGridQtde
        '
        Me.txtAlterarGridQtde.AutoHeight = False
        Me.txtAlterarGridQtde.MaxLength = 10
        Me.txtAlterarGridQtde.Name = "txtAlterarGridQtde"
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodProd.ColumnEdit = Me.txtAlterarGridQtde
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTamanho.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTamanho.ColumnEdit = Me.txtAlterarGridQtde
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 0
        Me.colTamanho.Width = 79
        '
        'colqtdeMaxima
        '
        Me.colqtdeMaxima.AppearanceCell.Options.UseTextOptions = True
        Me.colqtdeMaxima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqtdeMaxima.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colqtdeMaxima.ColumnEdit = Me.txtAlterarGridQtde
        Me.colqtdeMaxima.FieldName = "qtdeMaxima"
        Me.colqtdeMaxima.Name = "colqtdeMaxima"
        '
        'colLote
        '
        Me.colLote.AppearanceCell.Options.UseTextOptions = True
        Me.colLote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLote.ColumnEdit = Me.txtAlterarGridQtde
        Me.colLote.FieldName = "Lote"
        Me.colLote.Name = "colLote"
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 1
        Me.colLote.Width = 85
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorCusto.ColumnEdit = Me.txtAlterarGridQtde
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        '
        'colQtdeMinima
        '
        Me.colQtdeMinima.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdeMinima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdeMinima.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtdeMinima.ColumnEdit = Me.txtAlterarGridQtde
        Me.colQtdeMinima.FieldName = "QtdeMinima"
        Me.colQtdeMinima.Name = "colQtdeMinima"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtd.ColumnEdit = Me.txtAlterarGridNumero
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 2
        Me.colQtd.Width = 85
        '
        'txtAlterarGridNumero
        '
        Me.txtAlterarGridNumero.AutoHeight = False
        Me.txtAlterarGridNumero.MaxLength = 10
        Me.txtAlterarGridNumero.Name = "txtAlterarGridNumero"
        '
        'colEmFalta
        '
        Me.colEmFalta.AppearanceCell.Options.UseTextOptions = True
        Me.colEmFalta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmFalta.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colEmFalta.ColumnEdit = Me.txtAlterarGridQtde
        Me.colEmFalta.FieldName = "EmFalta"
        Me.colEmFalta.Name = "colEmFalta"
        '
        'colAcabou
        '
        Me.colAcabou.AppearanceCell.Options.UseTextOptions = True
        Me.colAcabou.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAcabou.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colAcabou.ColumnEdit = Me.txtAlterarGridQtde
        Me.colAcabou.FieldName = "Acabou"
        Me.colAcabou.Name = "colAcabou"
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodConfig.ColumnEdit = Me.txtAlterarGridQtde
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        '
        'colDataFim
        '
        Me.colDataFim.AppearanceCell.Options.UseTextOptions = True
        Me.colDataFim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataFim.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataFim.ColumnEdit = Me.txtAlterarGridQtde
        Me.colDataFim.FieldName = "DataFim"
        Me.colDataFim.Name = "colDataFim"
        '
        'colCor
        '
        Me.colCor.AppearanceCell.Options.UseTextOptions = True
        Me.colCor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCor.ColumnEdit = Me.txtAlterarGridQtde
        Me.colCor.FieldName = "Cor"
        Me.colCor.Name = "colCor"
        Me.colCor.Visible = True
        Me.colCor.VisibleIndex = 3
        Me.colCor.Width = 88
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdQtde
        Me.GridView1.Name = "GridView1"
        '
        'lblObservacao
        '
        Me.lblObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObservacao.Location = New System.Drawing.Point(279, 195)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(58, 13)
        Me.lblObservacao.TabIndex = 85
        Me.lblObservacao.Text = "Observação"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Location = New System.Drawing.Point(267, 203)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(349, 5)
        Me.PanelControl3.TabIndex = 111
        '
        'lblEmPromocao
        '
        Me.lblEmPromocao.Location = New System.Drawing.Point(53, 195)
        Me.lblEmPromocao.Name = "lblEmPromocao"
        Me.lblEmPromocao.Size = New System.Drawing.Size(64, 13)
        Me.lblEmPromocao.TabIndex = 84
        Me.lblEmPromocao.Text = "Em Promocão"
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(8, 203)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(184, 5)
        Me.PanelControl2.TabIndex = 110
        '
        'lblValoresProduto
        '
        Me.lblValoresProduto.Location = New System.Drawing.Point(53, 136)
        Me.lblValoresProduto.Name = "lblValoresProduto"
        Me.lblValoresProduto.Size = New System.Drawing.Size(91, 13)
        Me.lblValoresProduto.TabIndex = 83
        Me.lblValoresProduto.Text = "Valores do Produto"
        '
        'pnlValoresProduto
        '
        Me.pnlValoresProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlValoresProduto.Location = New System.Drawing.Point(9, 140)
        Me.pnlValoresProduto.Name = "pnlValoresProduto"
        Me.pnlValoresProduto.Size = New System.Drawing.Size(607, 5)
        Me.pnlValoresProduto.TabIndex = 109
        '
        'txtLocacao
        '
        Me.txtLocacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocacao.EnterMoveNextControl = True
        Me.txtLocacao.Location = New System.Drawing.Point(431, 110)
        Me.txtLocacao.MenuManager = Me.BarManager1
        Me.txtLocacao.Name = "txtLocacao"
        Me.txtLocacao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLocacao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtLocacao.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtLocacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocacao.Properties.MaxLength = 50
        Me.txtLocacao.Size = New System.Drawing.Size(184, 20)
        Me.txtLocacao.TabIndex = 10
        '
        'memObservacao
        '
        Me.memObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memObservacao.EnterMoveNextControl = True
        Me.memObservacao.Location = New System.Drawing.Point(266, 214)
        Me.memObservacao.MenuManager = Me.BarManager1
        Me.memObservacao.Name = "memObservacao"
        Me.memObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memObservacao.Size = New System.Drawing.Size(349, 46)
        Me.memObservacao.TabIndex = 17
        '
        'txtDescontoPorc
        '
        Me.txtDescontoPorc.EnterMoveNextControl = True
        Me.txtDescontoPorc.Location = New System.Drawing.Point(159, 214)
        Me.txtDescontoPorc.MenuManager = Me.BarManager1
        Me.txtDescontoPorc.Name = "txtDescontoPorc"
        Me.txtDescontoPorc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescontoPorc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDescontoPorc.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDescontoPorc.Properties.MaxLength = 5
        Me.txtDescontoPorc.Size = New System.Drawing.Size(33, 20)
        Me.txtDescontoPorc.TabIndex = 16
        '
        'txtDesconto
        '
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(92, 214)
        Me.txtDesconto.MenuManager = Me.BarManager1
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDesconto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDesconto.Properties.MaxLength = 10
        Me.txtDesconto.Size = New System.Drawing.Size(68, 20)
        Me.txtDesconto.TabIndex = 15
        '
        'txtVendaPorc
        '
        Me.txtVendaPorc.EnterMoveNextControl = True
        Me.txtVendaPorc.Location = New System.Drawing.Point(519, 163)
        Me.txtVendaPorc.MenuManager = Me.BarManager1
        Me.txtVendaPorc.Name = "txtVendaPorc"
        Me.txtVendaPorc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVendaPorc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVendaPorc.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtVendaPorc.Properties.MaxLength = 5
        Me.txtVendaPorc.Size = New System.Drawing.Size(72, 20)
        Me.txtVendaPorc.TabIndex = 14
        '
        'txtVenda
        '
        Me.txtVenda.EnterMoveNextControl = True
        Me.txtVenda.Location = New System.Drawing.Point(431, 163)
        Me.txtVenda.MenuManager = Me.BarManager1
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVenda.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtVenda.Properties.MaxLength = 10
        Me.txtVenda.Size = New System.Drawing.Size(89, 20)
        Me.txtVenda.TabIndex = 13
        '
        'txtCusto
        '
        Me.txtCusto.EnterMoveNextControl = True
        Me.txtCusto.Location = New System.Drawing.Point(267, 163)
        Me.txtCusto.MenuManager = Me.BarManager1
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCusto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCusto.Properties.MaxLength = 10
        Me.txtCusto.Size = New System.Drawing.Size(88, 20)
        Me.txtCusto.TabIndex = 12
        '
        'txtComissao
        '
        Me.txtComissao.EnterMoveNextControl = True
        Me.txtComissao.Location = New System.Drawing.Point(92, 163)
        Me.txtComissao.MenuManager = Me.BarManager1
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComissao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtComissao.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtComissao.Properties.MaxLength = 10
        Me.txtComissao.Size = New System.Drawing.Size(100, 20)
        Me.txtComissao.TabIndex = 11
        '
        'cboUniMed
        '
        Me.cboUniMed.EnterMoveNextControl = True
        Me.cboUniMed.Location = New System.Drawing.Point(92, 110)
        Me.cboUniMed.MenuManager = Me.BarManager1
        Me.cboUniMed.Name = "cboUniMed"
        Me.cboUniMed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUniMed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUniMed.Properties.MaxLength = 2
        Me.cboUniMed.Size = New System.Drawing.Size(100, 20)
        Me.cboUniMed.TabIndex = 8
        '
        'cboTipo
        '
        Me.cboTipo.EnterMoveNextControl = True
        Me.cboTipo.Location = New System.Drawing.Point(267, 110)
        Me.cboTipo.MenuManager = Me.BarManager1
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.Appearance.Options.UseTextOptions = True
        Me.cboTipo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboTipo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Properties.MaxLength = 30
        Me.cboTipo.Size = New System.Drawing.Size(88, 20)
        Me.cboTipo.TabIndex = 9
        '
        'cboFamilia
        '
        Me.cboFamilia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFamilia.EnterMoveNextControl = True
        Me.cboFamilia.Location = New System.Drawing.Point(431, 84)
        Me.cboFamilia.MenuManager = Me.BarManager1
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Properties.Appearance.Options.UseTextOptions = True
        Me.cboFamilia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboFamilia.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cboFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFamilia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFamilia.Properties.MaxLength = 30
        Me.cboFamilia.Size = New System.Drawing.Size(160, 20)
        Me.cboFamilia.TabIndex = 7
        '
        'cboGrupo
        '
        Me.cboGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupo.EnterMoveNextControl = True
        Me.cboGrupo.Location = New System.Drawing.Point(431, 58)
        Me.cboGrupo.MenuManager = Me.BarManager1
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Properties.Appearance.Options.UseTextOptions = True
        Me.cboGrupo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboGrupo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cboGrupo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupo.Properties.MaxLength = 30
        Me.cboGrupo.Size = New System.Drawing.Size(160, 20)
        Me.cboGrupo.TabIndex = 5
        '
        'cboFornecedor
        '
        Me.cboFornecedor.EnterMoveNextControl = True
        Me.cboFornecedor.Location = New System.Drawing.Point(92, 84)
        Me.cboFornecedor.MenuManager = Me.BarManager1
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFornecedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Properties.MaxLength = 50
        Me.cboFornecedor.Size = New System.Drawing.Size(221, 20)
        Me.cboFornecedor.TabIndex = 6
        '
        'cboCodBarra
        '
        Me.cboCodBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCodBarra.EnterMoveNextControl = True
        Me.cboCodBarra.Location = New System.Drawing.Point(431, 5)
        Me.cboCodBarra.MenuManager = Me.BarManager1
        Me.cboCodBarra.Name = "cboCodBarra"
        Me.cboCodBarra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodBarra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cboCodBarra.Properties.MaxLength = 80
        Me.cboCodBarra.Size = New System.Drawing.Size(160, 20)
        Me.cboCodBarra.TabIndex = 2
        '
        'cboSetor
        '
        Me.cboSetor.EnterMoveNextControl = True
        Me.cboSetor.Location = New System.Drawing.Point(92, 58)
        Me.cboSetor.MenuManager = Me.BarManager1
        Me.cboSetor.Name = "cboSetor"
        Me.cboSetor.Properties.Appearance.Options.UseTextOptions = True
        Me.cboSetor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboSetor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cboSetor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSetor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSetor.Properties.MaxLength = 30
        Me.cboSetor.Size = New System.Drawing.Size(238, 20)
        Me.cboSetor.TabIndex = 4
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.EnterMoveNextControl = True
        Me.txtProduto.Location = New System.Drawing.Point(92, 32)
        Me.txtProduto.MenuManager = Me.BarManager1
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtProduto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Properties.MaxLength = 150
        Me.txtProduto.Size = New System.Drawing.Size(523, 20)
        Me.txtProduto.TabIndex = 3
        '
        'txtCodFor
        '
        Me.txtCodFor.EnterMoveNextControl = True
        Me.txtCodFor.Location = New System.Drawing.Point(268, 5)
        Me.txtCodFor.MenuManager = Me.BarManager1
        Me.txtCodFor.Name = "txtCodFor"
        Me.txtCodFor.Properties.MaxLength = 80
        Me.txtCodFor.Size = New System.Drawing.Size(89, 20)
        Me.txtCodFor.TabIndex = 1
        '
        'lblDescontoPorc
        '
        Me.lblDescontoPorc.Location = New System.Drawing.Point(203, 217)
        Me.lblDescontoPorc.Name = "lblDescontoPorc"
        Me.lblDescontoPorc.Size = New System.Drawing.Size(11, 13)
        Me.lblDescontoPorc.TabIndex = 90
        Me.lblDescontoPorc.Text = "%"
        '
        'lblDesconto
        '
        Me.lblDesconto.Location = New System.Drawing.Point(25, 217)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(61, 13)
        Me.lblDesconto.TabIndex = 89
        Me.lblDesconto.Text = "Desconto R$"
        '
        'lblCusto
        '
        Me.lblCusto.Location = New System.Drawing.Point(216, 166)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(44, 13)
        Me.lblCusto.TabIndex = 88
        Me.lblCusto.Text = "Custo R$"
        '
        'lblComissao
        '
        Me.lblComissao.Location = New System.Drawing.Point(27, 166)
        Me.lblComissao.Name = "lblComissao"
        Me.lblComissao.Size = New System.Drawing.Size(59, 13)
        Me.lblComissao.TabIndex = 87
        Me.lblComissao.Text = "Comissão %"
        '
        'lblVenda
        '
        Me.lblVenda.Location = New System.Drawing.Point(379, 166)
        Me.lblVenda.Name = "lblVenda"
        Me.lblVenda.Size = New System.Drawing.Size(46, 13)
        Me.lblVenda.TabIndex = 86
        Me.lblVenda.Text = "Venda R$"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(242, 113)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(20, 13)
        Me.lblTipo.TabIndex = 82
        Me.lblTipo.Text = "Tipo"
        '
        'lblUniMed
        '
        Me.lblUniMed.Location = New System.Drawing.Point(44, 113)
        Me.lblUniMed.Name = "lblUniMed"
        Me.lblUniMed.Size = New System.Drawing.Size(42, 13)
        Me.lblUniMed.TabIndex = 81
        Me.lblUniMed.Text = "Uni. Med"
        '
        'lblLocacao
        '
        Me.lblLocacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocacao.Location = New System.Drawing.Point(386, 113)
        Me.lblLocacao.Name = "lblLocacao"
        Me.lblLocacao.Size = New System.Drawing.Size(39, 13)
        Me.lblLocacao.TabIndex = 80
        Me.lblLocacao.Text = "Locacao"
        '
        'lblFamilia
        '
        Me.lblFamilia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFamilia.Location = New System.Drawing.Point(396, 87)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(32, 13)
        Me.lblFamilia.TabIndex = 79
        Me.lblFamilia.Text = "Familia"
        '
        'lblGrupo
        '
        Me.lblGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupo.Location = New System.Drawing.Point(396, 61)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(29, 13)
        Me.lblGrupo.TabIndex = 78
        Me.lblGrupo.Text = "Grupo"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.Location = New System.Drawing.Point(31, 87)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(55, 13)
        Me.lblFornecedor.TabIndex = 77
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'lblSetor
        '
        Me.lblSetor.Location = New System.Drawing.Point(60, 61)
        Me.lblSetor.Name = "lblSetor"
        Me.lblSetor.Size = New System.Drawing.Size(26, 13)
        Me.lblSetor.TabIndex = 76
        Me.lblSetor.Text = "Setor"
        '
        'lblProduto
        '
        Me.lblProduto.Location = New System.Drawing.Point(48, 35)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(38, 13)
        Me.lblProduto.TabIndex = 75
        Me.lblProduto.Text = "Produto"
        '
        'lblCodBarra
        '
        Me.lblCodBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodBarra.Location = New System.Drawing.Point(373, 9)
        Me.lblCodBarra.Name = "lblCodBarra"
        Me.lblCodBarra.Size = New System.Drawing.Size(52, 13)
        Me.lblCodBarra.TabIndex = 74
        Me.lblCodBarra.Text = "Cód. Barra"
        '
        'lblCodFor
        '
        Me.lblCodFor.Location = New System.Drawing.Point(216, 9)
        Me.lblCodFor.Name = "lblCodFor"
        Me.lblCodFor.Size = New System.Drawing.Size(46, 13)
        Me.lblCodFor.TabIndex = 73
        Me.lblCodFor.Text = "Cód. For."
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(53, 7)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(33, 13)
        Me.lblCodigo.TabIndex = 72
        Me.lblCodigo.Text = "Código"
        '
        'chkCodigo
        '
        Me.chkCodigo.EnterMoveNextControl = True
        Me.chkCodigo.Location = New System.Drawing.Point(176, 6)
        Me.chkCodigo.MenuManager = Me.BarManager1
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Properties.Caption = ""
        Me.chkCodigo.Size = New System.Drawing.Size(16, 19)
        Me.chkCodigo.TabIndex = 100
        '
        'txtCodigoInterno
        '
        Me.txtCodigoInterno.Enabled = False
        Me.txtCodigoInterno.EnterMoveNextControl = True
        Me.txtCodigoInterno.Location = New System.Drawing.Point(92, 6)
        Me.txtCodigoInterno.MenuManager = Me.BarManager1
        Me.txtCodigoInterno.Name = "txtCodigoInterno"
        Me.txtCodigoInterno.Properties.MaxLength = 10
        Me.txtCodigoInterno.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoInterno.TabIndex = 0
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SimpleButton7.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton7.Location = New System.Drawing.Point(590, 163)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton7.TabIndex = 107
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton6.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton6.Location = New System.Drawing.Point(591, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton6.TabIndex = 101
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton5.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton5.Location = New System.Drawing.Point(590, 58)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton5.TabIndex = 103
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton4.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton4.Location = New System.Drawing.Point(591, 84)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton4.TabIndex = 106
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12
        Me.SimpleButton3.Location = New System.Drawing.Point(336, 84)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(19, 20)
        Me.SimpleButton3.TabIndex = 105
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton2.Location = New System.Drawing.Point(312, 84)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton2.TabIndex = 104
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton1.Location = New System.Drawing.Point(330, 58)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton1.TabIndex = 102
        '
        'tabSATFiscal
        '
        Me.tabSATFiscal.Name = "tabSATFiscal"
        Me.tabSATFiscal.Size = New System.Drawing.Size(1002, 267)
        Me.tabSATFiscal.Text = "SAT Fiscal"
        '
        'tabHistorico
        '
        Me.tabHistorico.Name = "tabHistorico"
        Me.tabHistorico.Size = New System.Drawing.Size(1002, 267)
        Me.tabHistorico.Text = "Histórico"
        '
        'QtdeBindingSource
        '
        Me.QtdeBindingSource.DataMember = "Qtde"
        Me.QtdeBindingSource.DataSource = Me.DsTelaUsuario
        '
        'DsTelaUsuario
        '
        Me.DsTelaUsuario.DataSetName = "dsTelaUsuario"
        Me.DsTelaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtCapitalEstoque)
        Me.PanelControl1.Controls.Add(Me.cboCustoVenda)
        Me.PanelControl1.Controls.Add(Me.lblCapitalEstoque)
        Me.PanelControl1.Controls.Add(Me.txtQtdTotal)
        Me.PanelControl1.Controls.Add(Me.lblQtdTotal)
        Me.PanelControl1.Controls.Add(Me.btnCalcular)
        Me.PanelControl1.Controls.Add(Me.txtProdCadastrados)
        Me.PanelControl1.Controls.Add(Me.lblProdCadastrados)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 581)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 44)
        Me.PanelControl1.TabIndex = 2
        '
        'txtCapitalEstoque
        '
        Me.txtCapitalEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCapitalEstoque.Location = New System.Drawing.Point(729, 14)
        Me.txtCapitalEstoque.MenuManager = Me.BarManager1
        Me.txtCapitalEstoque.Name = "txtCapitalEstoque"
        Me.txtCapitalEstoque.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCapitalEstoque.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCapitalEstoque.Properties.ReadOnly = True
        Me.txtCapitalEstoque.Size = New System.Drawing.Size(267, 20)
        Me.txtCapitalEstoque.TabIndex = 33
        '
        'cboCustoVenda
        '
        Me.cboCustoVenda.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cboCustoVenda.Location = New System.Drawing.Point(320, 14)
        Me.cboCustoVenda.MenuManager = Me.BarManager1
        Me.cboCustoVenda.Name = "cboCustoVenda"
        Me.cboCustoVenda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCustoVenda.Properties.Items.AddRange(New Object() {"Valor Venda", "Valor Custo"})
        Me.cboCustoVenda.Size = New System.Drawing.Size(100, 20)
        Me.cboCustoVenda.TabIndex = 31
        '
        'lblCapitalEstoque
        '
        Me.lblCapitalEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapitalEstoque.AutoSize = True
        Me.lblCapitalEstoque.Location = New System.Drawing.Point(608, 17)
        Me.lblCapitalEstoque.Name = "lblCapitalEstoque"
        Me.lblCapitalEstoque.Size = New System.Drawing.Size(115, 13)
        Me.lblCapitalEstoque.TabIndex = 6
        Me.lblCapitalEstoque.Text = "Capital em Estoque R$"
        '
        'txtQtdTotal
        '
        Me.txtQtdTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtQtdTotal.Location = New System.Drawing.Point(510, 13)
        Me.txtQtdTotal.MenuManager = Me.BarManager1
        Me.txtQtdTotal.Name = "txtQtdTotal"
        Me.txtQtdTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdTotal.Properties.ReadOnly = True
        Me.txtQtdTotal.Size = New System.Drawing.Size(74, 20)
        Me.txtQtdTotal.TabIndex = 32
        '
        'lblQtdTotal
        '
        Me.lblQtdTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblQtdTotal.AutoSize = True
        Me.lblQtdTotal.Location = New System.Drawing.Point(453, 16)
        Me.lblQtdTotal.Name = "lblQtdTotal"
        Me.lblQtdTotal.Size = New System.Drawing.Size(51, 13)
        Me.lblQtdTotal.TabIndex = 4
        Me.lblQtdTotal.Text = "Qtd Total"
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCalcular.Location = New System.Drawing.Point(239, 11)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 30
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtProdCadastrados
        '
        Me.txtProdCadastrados.Location = New System.Drawing.Point(129, 13)
        Me.txtProdCadastrados.MenuManager = Me.BarManager1
        Me.txtProdCadastrados.Name = "txtProdCadastrados"
        Me.txtProdCadastrados.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtProdCadastrados.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtProdCadastrados.Properties.ReadOnly = True
        Me.txtProdCadastrados.Size = New System.Drawing.Size(100, 20)
        Me.txtProdCadastrados.TabIndex = 29
        '
        'lblProdCadastrados
        '
        Me.lblProdCadastrados.AutoSize = True
        Me.lblProdCadastrados.Location = New System.Drawing.Point(12, 16)
        Me.lblProdCadastrados.Name = "lblProdCadastrados"
        Me.lblProdCadastrados.Size = New System.Drawing.Size(111, 13)
        Me.lblProdCadastrados.TabIndex = 0
        Me.lblProdCadastrados.Text = "Produtos Cadastrados"
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.DsTelaUsuario
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.QtdeTableAdapter = Nothing
        Me.TableAdapterManager.TotalConsigTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'grdProdCadastrados
        '
        Me.grdProdCadastrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProdCadastrados.DataMember = "tbClienteQtd"
        Me.grdProdCadastrados.DataSource = Me.dsProdCadastrados
        Me.grdProdCadastrados.Location = New System.Drawing.Point(0, 22)
        Me.grdProdCadastrados.MainView = Me.grd2
        Me.grdProdCadastrados.MenuManager = Me.BarManager1
        Me.grdProdCadastrados.Name = "grdProdCadastrados"
        Me.grdProdCadastrados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdProdCadastrados.Size = New System.Drawing.Size(1008, 273)
        Me.grdProdCadastrados.TabIndex = 8
        Me.grdProdCadastrados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'dsProdCadastrados
        '
        Me.dsProdCadastrados.DataSetName = "NewDataSet"
        Me.dsProdCadastrados.Tables.AddRange(New System.Data.DataTable() {Me.tbClienteQtd})
        '
        'tbClienteQtd
        '
        Me.tbClienteQtd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn2, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn22, Me.DataColumn21, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.CodigoInterno})
        Me.tbClienteQtd.TableName = "tbClienteQtd"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Codigo"
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "CodBarra"
        Me.DataColumn3.ColumnName = "CodBarra"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Produto"
        Me.DataColumn4.ColumnName = "Produto"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Setor"
        Me.DataColumn5.ColumnName = "Setor"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Grupo"
        Me.DataColumn6.ColumnName = "Grupo"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Fornecedor"
        Me.DataColumn7.ColumnName = "Fornecedor"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "Familia"
        Me.DataColumn8.ColumnName = "Familia"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "UnidMed"
        Me.DataColumn9.ColumnName = "UnidMed"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "Tipo"
        Me.DataColumn10.ColumnName = "Tipo"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "Locacao"
        Me.DataColumn11.ColumnName = "Locacao"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "Comissao"
        Me.DataColumn12.ColumnName = "Comissao"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Custo"
        Me.DataColumn2.ColumnName = "Custo"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "Venda"
        Me.DataColumn13.ColumnName = "Venda"
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "Desconto"
        Me.DataColumn14.ColumnName = "Desconto"
        '
        'DataColumn15
        '
        Me.DataColumn15.Caption = "Observacao"
        Me.DataColumn15.ColumnName = "Observacao"
        '
        'DataColumn16
        '
        Me.DataColumn16.Caption = "AlterarPreco"
        Me.DataColumn16.ColumnName = "AlterarPreco"
        '
        'DataColumn17
        '
        Me.DataColumn17.Caption = "Duplicar"
        Me.DataColumn17.ColumnName = "Duplicar"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "TribPadrao"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Inativo"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "CodProd"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Tamanho"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "qtdeMaxima"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Lote"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ValorCusto"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Qtd"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "EmFalta"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Acabou"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "CodConfig"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "DataFim"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Cor"
        '
        'CodigoInterno
        '
        Me.CodigoInterno.ColumnName = "CodigoInterno"
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodigoInterno, Me.colProduto, Me.colQtd1, Me.colCusto, Me.colVenda, Me.colDesconto, Me.colSetor, Me.colGrupo, Me.colFornecedor, Me.colFamilia, Me.colUnidMed, Me.colTipo, Me.colLocacao, Me.colComissao, Me.colObservacao, Me.colAlterarPreco, Me.colDuplicar, Me.colTribPadrao, Me.colInativo, Me.colCodProd1, Me.colTamanho1, Me.colqtdeMaxima1, Me.colLote1, Me.colValorCusto1, Me.colEmFalta1, Me.colAcabou1, Me.colCodConfig1, Me.colDataFim1, Me.colCor1, Me.colCodBarra})
        Me.grd2.GridControl = Me.grdProdCadastrados
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ColumnAutoWidth = False
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        Me.grd2.OptionsView.ShowFooter = True
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
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
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigoInterno.ColumnEdit = Me.txtAlterarGrid
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        '
        'colProduto
        '
        Me.colProduto.ColumnEdit = Me.txtAlterarGrid
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        '
        'colQtd1
        '
        Me.colQtd1.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtd1.ColumnEdit = Me.txtAlterarGrid
        Me.colQtd1.FieldName = "Qtd"
        Me.colQtd1.Name = "colQtd1"
        Me.colQtd1.OptionsColumn.ReadOnly = True
        Me.colQtd1.Visible = True
        Me.colQtd1.VisibleIndex = 2
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCusto.ColumnEdit = Me.txtAlterarGrid
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 3
        '
        'colVenda
        '
        Me.colVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colVenda.ColumnEdit = Me.txtAlterarGrid
        Me.colVenda.FieldName = "Venda"
        Me.colVenda.Name = "colVenda"
        Me.colVenda.OptionsColumn.ReadOnly = True
        Me.colVenda.Visible = True
        Me.colVenda.VisibleIndex = 4
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDesconto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDesconto.ColumnEdit = Me.txtAlterarGrid
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 5
        '
        'colSetor
        '
        Me.colSetor.AppearanceCell.Options.UseTextOptions = True
        Me.colSetor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSetor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSetor.ColumnEdit = Me.txtAlterarGrid
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        Me.colSetor.Visible = True
        Me.colSetor.VisibleIndex = 6
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colGrupo.ColumnEdit = Me.txtAlterarGrid
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 7
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceCell.Options.UseTextOptions = True
        Me.colFornecedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFornecedor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFornecedor.ColumnEdit = Me.txtAlterarGrid
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 8
        '
        'colFamilia
        '
        Me.colFamilia.AppearanceCell.Options.UseTextOptions = True
        Me.colFamilia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFamilia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colFamilia.ColumnEdit = Me.txtAlterarGrid
        Me.colFamilia.FieldName = "Familia"
        Me.colFamilia.Name = "colFamilia"
        Me.colFamilia.OptionsColumn.ReadOnly = True
        Me.colFamilia.Visible = True
        Me.colFamilia.VisibleIndex = 9
        '
        'colUnidMed
        '
        Me.colUnidMed.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidMed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidMed.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUnidMed.FieldName = "UnidMed"
        Me.colUnidMed.Name = "colUnidMed"
        Me.colUnidMed.OptionsColumn.ReadOnly = True
        Me.colUnidMed.Visible = True
        Me.colUnidMed.VisibleIndex = 10
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTipo.ColumnEdit = Me.txtAlterarGrid
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 11
        '
        'colLocacao
        '
        Me.colLocacao.AppearanceCell.Options.UseTextOptions = True
        Me.colLocacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocacao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLocacao.ColumnEdit = Me.txtAlterarGrid
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.OptionsColumn.ReadOnly = True
        Me.colLocacao.Visible = True
        Me.colLocacao.VisibleIndex = 12
        '
        'colComissao
        '
        Me.colComissao.AppearanceCell.Options.UseTextOptions = True
        Me.colComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComissao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colComissao.ColumnEdit = Me.txtAlterarGrid
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 13
        '
        'colObservacao
        '
        Me.colObservacao.FieldName = "Observacao"
        Me.colObservacao.Name = "colObservacao"
        Me.colObservacao.OptionsColumn.ReadOnly = True
        Me.colObservacao.Visible = True
        Me.colObservacao.VisibleIndex = 14
        '
        'colAlterarPreco
        '
        Me.colAlterarPreco.ColumnEdit = Me.txtAlterarGrid
        Me.colAlterarPreco.FieldName = "AlterarPreco"
        Me.colAlterarPreco.Name = "colAlterarPreco"
        Me.colAlterarPreco.OptionsColumn.ReadOnly = True
        Me.colAlterarPreco.Visible = True
        Me.colAlterarPreco.VisibleIndex = 15
        '
        'colDuplicar
        '
        Me.colDuplicar.ColumnEdit = Me.txtAlterarGrid
        Me.colDuplicar.FieldName = "Duplicar"
        Me.colDuplicar.Name = "colDuplicar"
        Me.colDuplicar.OptionsColumn.ReadOnly = True
        Me.colDuplicar.Visible = True
        Me.colDuplicar.VisibleIndex = 16
        '
        'colTribPadrao
        '
        Me.colTribPadrao.ColumnEdit = Me.txtAlterarGrid
        Me.colTribPadrao.FieldName = "TribPadrao"
        Me.colTribPadrao.Name = "colTribPadrao"
        Me.colTribPadrao.OptionsColumn.ReadOnly = True
        Me.colTribPadrao.Visible = True
        Me.colTribPadrao.VisibleIndex = 17
        '
        'colInativo
        '
        Me.colInativo.ColumnEdit = Me.txtAlterarGrid
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        Me.colInativo.OptionsColumn.ReadOnly = True
        Me.colInativo.Visible = True
        Me.colInativo.VisibleIndex = 18
        '
        'colCodProd1
        '
        Me.colCodProd1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodProd1.FieldName = "CodProd"
        Me.colCodProd1.Name = "colCodProd1"
        Me.colCodProd1.OptionsColumn.ReadOnly = True
        Me.colCodProd1.Visible = True
        Me.colCodProd1.VisibleIndex = 19
        '
        'colTamanho1
        '
        Me.colTamanho1.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTamanho1.ColumnEdit = Me.txtAlterarGrid
        Me.colTamanho1.FieldName = "Tamanho"
        Me.colTamanho1.Name = "colTamanho1"
        Me.colTamanho1.OptionsColumn.ReadOnly = True
        Me.colTamanho1.Visible = True
        Me.colTamanho1.VisibleIndex = 20
        '
        'colqtdeMaxima1
        '
        Me.colqtdeMaxima1.AppearanceCell.Options.UseTextOptions = True
        Me.colqtdeMaxima1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colqtdeMaxima1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colqtdeMaxima1.ColumnEdit = Me.txtAlterarGrid
        Me.colqtdeMaxima1.FieldName = "qtdeMaxima"
        Me.colqtdeMaxima1.Name = "colqtdeMaxima1"
        Me.colqtdeMaxima1.OptionsColumn.ReadOnly = True
        Me.colqtdeMaxima1.Visible = True
        Me.colqtdeMaxima1.VisibleIndex = 21
        '
        'colLote1
        '
        Me.colLote1.AppearanceCell.Options.UseTextOptions = True
        Me.colLote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colLote1.ColumnEdit = Me.txtAlterarGrid
        Me.colLote1.FieldName = "Lote"
        Me.colLote1.Name = "colLote1"
        Me.colLote1.OptionsColumn.ReadOnly = True
        Me.colLote1.Visible = True
        Me.colLote1.VisibleIndex = 22
        '
        'colValorCusto1
        '
        Me.colValorCusto1.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValorCusto1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorCusto1.ColumnEdit = Me.txtAlterarGrid
        Me.colValorCusto1.FieldName = "ValorCusto"
        Me.colValorCusto1.Name = "colValorCusto1"
        Me.colValorCusto1.OptionsColumn.ReadOnly = True
        Me.colValorCusto1.Visible = True
        Me.colValorCusto1.VisibleIndex = 23
        '
        'colEmFalta1
        '
        Me.colEmFalta1.AppearanceCell.Options.UseTextOptions = True
        Me.colEmFalta1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmFalta1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colEmFalta1.ColumnEdit = Me.txtAlterarGrid
        Me.colEmFalta1.FieldName = "EmFalta"
        Me.colEmFalta1.Name = "colEmFalta1"
        Me.colEmFalta1.OptionsColumn.ReadOnly = True
        Me.colEmFalta1.Visible = True
        Me.colEmFalta1.VisibleIndex = 24
        '
        'colAcabou1
        '
        Me.colAcabou1.FieldName = "Acabou"
        Me.colAcabou1.Name = "colAcabou1"
        Me.colAcabou1.OptionsColumn.ReadOnly = True
        Me.colAcabou1.Visible = True
        Me.colAcabou1.VisibleIndex = 25
        '
        'colCodConfig1
        '
        Me.colCodConfig1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodConfig1.ColumnEdit = Me.txtAlterarGrid
        Me.colCodConfig1.FieldName = "CodConfig"
        Me.colCodConfig1.Name = "colCodConfig1"
        Me.colCodConfig1.OptionsColumn.ReadOnly = True
        Me.colCodConfig1.Visible = True
        Me.colCodConfig1.VisibleIndex = 26
        '
        'colDataFim1
        '
        Me.colDataFim1.AppearanceCell.Options.UseTextOptions = True
        Me.colDataFim1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataFim1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDataFim1.ColumnEdit = Me.txtAlterarGrid
        Me.colDataFim1.FieldName = "DataFim"
        Me.colDataFim1.Name = "colDataFim1"
        Me.colDataFim1.OptionsColumn.ReadOnly = True
        Me.colDataFim1.Visible = True
        Me.colDataFim1.VisibleIndex = 27
        '
        'colCor1
        '
        Me.colCor1.AppearanceCell.Options.UseTextOptions = True
        Me.colCor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCor1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCor1.ColumnEdit = Me.txtAlterarGrid
        Me.colCor1.FieldName = "Cor"
        Me.colCor1.Name = "colCor1"
        Me.colCor1.OptionsColumn.ReadOnly = True
        Me.colCor1.Visible = True
        Me.colCor1.VisibleIndex = 28
        '
        'colCodBarra
        '
        Me.colCodBarra.ColumnEdit = Me.txtAlterarGrid
        Me.colCodBarra.FieldName = "CodBarra"
        Me.colCodBarra.Name = "colCodBarra"
        Me.colCodBarra.OptionsColumn.ReadOnly = True
        Me.colCodBarra.Visible = True
        Me.colCodBarra.VisibleIndex = 29
        '
        'grpProdCadastrados
        '
        Me.grpProdCadastrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProdCadastrados.Controls.Add(Me.btnLimparBusca)
        Me.grpProdCadastrados.Controls.Add(Me.cboBuscarProd)
        Me.grpProdCadastrados.Controls.Add(Me.lblInativo)
        Me.grpProdCadastrados.Controls.Add(Me.chkInativo)
        Me.grpProdCadastrados.Controls.Add(Me.lblTribPadrao)
        Me.grpProdCadastrados.Controls.Add(Me.chkTribPadrao)
        Me.grpProdCadastrados.Controls.Add(Me.lblAlterarPreco)
        Me.grpProdCadastrados.Controls.Add(Me.chkAlterarPreco)
        Me.grpProdCadastrados.Controls.Add(Me.lblDuplicar)
        Me.grpProdCadastrados.Controls.Add(Me.chkDuplicar)
        Me.grpProdCadastrados.Controls.Add(Me.grdProdCadastrados)
        Me.grpProdCadastrados.Location = New System.Drawing.Point(0, 289)
        Me.grpProdCadastrados.Name = "grpProdCadastrados"
        Me.grpProdCadastrados.Size = New System.Drawing.Size(1008, 295)
        Me.grpProdCadastrados.TabIndex = 9
        Me.grpProdCadastrados.Text = "Produtos Cadastrados"
        '
        'btnLimparBusca
        '
        Me.btnLimparBusca.Location = New System.Drawing.Point(269, 28)
        Me.btnLimparBusca.Name = "btnLimparBusca"
        Me.btnLimparBusca.Size = New System.Drawing.Size(75, 23)
        Me.btnLimparBusca.TabIndex = 130
        Me.btnLimparBusca.Text = "Limpar"
        '
        'cboBuscarProd
        '
        Me.cboBuscarProd.Location = New System.Drawing.Point(6, 29)
        Me.cboBuscarProd.MenuManager = Me.BarManager1
        Me.cboBuscarProd.Name = "cboBuscarProd"
        Me.cboBuscarProd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBuscarProd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBuscarProd.Size = New System.Drawing.Size(257, 20)
        Me.cboBuscarProd.TabIndex = 128
        '
        'lblInativo
        '
        Me.lblInativo.Location = New System.Drawing.Point(719, 3)
        Me.lblInativo.Name = "lblInativo"
        Me.lblInativo.Size = New System.Drawing.Size(34, 13)
        Me.lblInativo.TabIndex = 127
        Me.lblInativo.Text = "Inativo"
        '
        'chkInativo
        '
        Me.chkInativo.Location = New System.Drawing.Point(694, 0)
        Me.chkInativo.MenuManager = Me.BarManager1
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Properties.Caption = ""
        Me.chkInativo.Size = New System.Drawing.Size(19, 19)
        Me.chkInativo.TabIndex = 28
        '
        'lblTribPadrao
        '
        Me.lblTribPadrao.Location = New System.Drawing.Point(621, 4)
        Me.lblTribPadrao.Name = "lblTribPadrao"
        Me.lblTribPadrao.Size = New System.Drawing.Size(59, 13)
        Me.lblTribPadrao.TabIndex = 125
        Me.lblTribPadrao.Text = "Trib. Padrão"
        '
        'chkTribPadrao
        '
        Me.chkTribPadrao.Location = New System.Drawing.Point(596, 0)
        Me.chkTribPadrao.MenuManager = Me.BarManager1
        Me.chkTribPadrao.Name = "chkTribPadrao"
        Me.chkTribPadrao.Properties.Caption = ""
        Me.chkTribPadrao.Size = New System.Drawing.Size(19, 19)
        Me.chkTribPadrao.TabIndex = 27
        '
        'lblAlterarPreco
        '
        Me.lblAlterarPreco.Location = New System.Drawing.Point(527, 3)
        Me.lblAlterarPreco.Name = "lblAlterarPreco"
        Me.lblAlterarPreco.Size = New System.Drawing.Size(63, 13)
        Me.lblAlterarPreco.TabIndex = 123
        Me.lblAlterarPreco.Text = "Alterar Preço"
        '
        'chkAlterarPreco
        '
        Me.chkAlterarPreco.Location = New System.Drawing.Point(502, 0)
        Me.chkAlterarPreco.MenuManager = Me.BarManager1
        Me.chkAlterarPreco.Name = "chkAlterarPreco"
        Me.chkAlterarPreco.Properties.Caption = ""
        Me.chkAlterarPreco.Size = New System.Drawing.Size(19, 19)
        Me.chkAlterarPreco.TabIndex = 26
        '
        'lblDuplicar
        '
        Me.lblDuplicar.Location = New System.Drawing.Point(167, 4)
        Me.lblDuplicar.Name = "lblDuplicar"
        Me.lblDuplicar.Size = New System.Drawing.Size(38, 13)
        Me.lblDuplicar.TabIndex = 121
        Me.lblDuplicar.Text = "Duplicar"
        '
        'chkDuplicar
        '
        Me.chkDuplicar.Location = New System.Drawing.Point(142, 1)
        Me.chkDuplicar.MenuManager = Me.BarManager1
        Me.chkDuplicar.Name = "chkDuplicar"
        Me.chkDuplicar.Properties.Caption = ""
        Me.chkDuplicar.Size = New System.Drawing.Size(19, 19)
        Me.chkDuplicar.TabIndex = 25
        '
        'QtdeTableAdapter
        '
        Me.QtdeTableAdapter.ClearBeforeFill = True
        '
        'frmCadProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 666)
        Me.Controls.Add(Me.grpProdCadastrados)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tabInicial)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCadProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Produtos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInicial.ResumeLayout(False)
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPrincipal.PerformLayout()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.grdQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGridQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGridNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlValoresProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocacao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memObservacao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescontoPorc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendaPorc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComissao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFornecedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodBarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSetor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCapitalEstoque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCustoVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProdCadastrados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProdCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProdCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbClienteQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProdCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProdCadastrados.ResumeLayout(False)
        Me.grpProdCadastrados.PerformLayout()
        CType(Me.cboBuscarProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTribPadrao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterarPreco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDuplicar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblModelo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnAdicionar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFunções As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProdCadastrados As System.Windows.Forms.Label
    Friend WithEvents tabInicial As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPrincipal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabSATFiscal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtProdCadastrados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCapitalEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQtdTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQtdTotal As System.Windows.Forms.Label
    Friend WithEvents txtCapitalEstoque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCustoVenda As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tabHistorico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblObservacao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblEmPromocao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblValoresProduto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlValoresProduto As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtLocacao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents memObservacao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDescontoPorc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVendaPorc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComissao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboUniMed As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboTipo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFamilia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFornecedor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboCodBarra As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSetor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtProduto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodFor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoInterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescontoPorc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesconto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCusto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComissao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVenda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTipo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUniMed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLocacao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFamilia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGrupo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFornecedor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSetor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProduto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodBarra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodFor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTelaUsuario As telausuario.dsTelaUsuario
    Friend WithEvents ProdutosTableAdapter As telausuario.dsTelaUsuarioTableAdapters.ProdutosTableAdapter
    Friend WithEvents TableAdapterManager As telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager
    Friend WithEvents grdProdCadastrados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpProdCadastrados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblInativo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkInativo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblTribPadrao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkTribPadrao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblAlterarPreco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAlterarPreco As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDuplicar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkDuplicar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents QtdeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QtdeTableAdapter As telausuario.dsTelaUsuarioTableAdapters.QtdeTableAdapter
    Friend WithEvents dsQuantidade As System.Data.DataSet
    Friend WithEvents tbQtd As System.Data.DataTable
    Friend WithEvents Codigo As System.Data.DataColumn
    Friend WithEvents CodProd As System.Data.DataColumn
    Friend WithEvents Tamanho As System.Data.DataColumn
    Friend WithEvents qtdeMaxima As System.Data.DataColumn
    Friend WithEvents Lote As System.Data.DataColumn
    Friend WithEvents ValorCusto As System.Data.DataColumn
    Friend WithEvents QtdeMinima As System.Data.DataColumn
    Friend WithEvents Qtd As System.Data.DataColumn
    Friend WithEvents EmFalta As System.Data.DataColumn
    Friend WithEvents Acabou As System.Data.DataColumn
    Friend WithEvents CodConfig As System.Data.DataColumn
    Friend WithEvents DataFim As System.Data.DataColumn
    Friend WithEvents Cor As System.Data.DataColumn
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdQtde As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqtdeMaxima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdeMinima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmFalta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcabou As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataFim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsProdCadastrados As System.Data.DataSet
    Friend WithEvents tbClienteQtd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents txtAlterarGridNumero As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidMed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlterarPreco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuplicar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTribPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqtdeMaxima1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmFalta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAcabou1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataFim1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CodigoInterno As System.Data.DataColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterarGridQtde As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnLimparBusca As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboBuscarProd As DevExpress.XtraEditors.ComboBoxEdit
End Class
