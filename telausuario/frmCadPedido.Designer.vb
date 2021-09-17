<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadPedido
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
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnPromissoria = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompromisso = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVender = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEntrada = New DevExpress.XtraBars.BarButtonItem()
        Me.btF3Salvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pnlPrincipal = New DevExpress.XtraEditors.PanelControl()
        Me.btnOrdem = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOrdem = New DevExpress.XtraEditors.TextEdit()
        Me.lblOrdem = New DevExpress.XtraEditors.LabelControl()
        Me.btnYoutube = New DevExpress.XtraEditors.SimpleButton()
        Me.dtData = New DevExpress.XtraEditors.DateEdit()
        Me.lblData = New DevExpress.XtraEditors.LabelControl()
        Me.cboNossoStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblNossoStatus = New DevExpress.XtraEditors.LabelControl()
        Me.cboStatusNano = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblStatusNano = New DevExpress.XtraEditors.LabelControl()
        Me.cboVendedor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblVendedor = New DevExpress.XtraEditors.LabelControl()
        Me.tabClientesProdutos = New DevExpress.XtraTab.XtraTabControl()
        Me.tabProdutos = New DevExpress.XtraTab.XtraTabPage()
        Me.tabAddRemover = New DevExpress.XtraTab.XtraTabControl()
        Me.tabRemoverProdutos = New DevExpress.XtraTab.XtraTabPage()
        Me.btnRemoverPesquisarGrid = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtRemoverCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemoverQtd = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemoverProduto = New DevExpress.XtraEditors.TextEdit()
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRQtd = New DevExpress.XtraEditors.LabelControl()
        Me.lblRProduto = New DevExpress.XtraEditors.LabelControl()
        Me.chkRemoverCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.lblRCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.tabAddProdutos = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPreco = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddPesquisarProduto = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtAddCodigoInterno = New DevExpress.XtraEditors.TextEdit()
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblProduto = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddQtd = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldo = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmPedido = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddProduto = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescontoPorc = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCusto = New DevExpress.XtraEditors.TextEdit()
        Me.txtEstoque = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAdicionar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkCusto = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.lblCusto = New DevExpress.XtraEditors.LabelControl()
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.lblQtd = New DevExpress.XtraEditors.LabelControl()
        Me.lblPreco = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescontoPorc = New DevExpress.XtraEditors.LabelControl()
        Me.lblDesconto = New DevExpress.XtraEditors.LabelControl()
        Me.lblMecanico = New DevExpress.XtraEditors.LabelControl()
        Me.lblSaldo = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmPedido = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmEstoque = New DevExpress.XtraEditors.LabelControl()
        Me.rdgPS = New DevExpress.XtraEditors.RadioGroup()
        Me.tabCliente = New DevExpress.XtraTab.XtraTabPage()
        Me.tabDadosHistorico = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDados = New DevExpress.XtraTab.XtraTabPage()
        Me.dtDataSaida = New DevExpress.XtraEditors.DateEdit()
        Me.dtDataEntrada = New DevExpress.XtraEditors.DateEdit()
        Me.btnPesquisarNome = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.txtCor = New DevExpress.XtraEditors.TextEdit()
        Me.txtModelo = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtKmSaida = New DevExpress.XtraEditors.TextEdit()
        Me.txtKmEntrada = New DevExpress.XtraEditors.TextEdit()
        Me.txtAno = New DevExpress.XtraEditors.TextEdit()
        Me.txtMotor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelular = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefone = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblDadosVeiculo = New DevExpress.XtraEditors.LabelControl()
        Me.pnlDadosVeiculo = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblKmSaida = New DevExpress.XtraEditors.LabelControl()
        Me.lblKmEntrada = New DevExpress.XtraEditors.LabelControl()
        Me.lblDataSaida = New DevExpress.XtraEditors.LabelControl()
        Me.lblDataEntrada = New DevExpress.XtraEditors.LabelControl()
        Me.lblAno = New DevExpress.XtraEditors.LabelControl()
        Me.lblMotor = New DevExpress.XtraEditors.LabelControl()
        Me.lblCelular = New DevExpress.XtraEditors.LabelControl()
        Me.lblTelefone = New DevExpress.XtraEditors.LabelControl()
        Me.lblCpfCnpj = New DevExpress.XtraEditors.LabelControl()
        Me.lblNome = New DevExpress.XtraEditors.LabelControl()
        Me.lblCor = New DevExpress.XtraEditors.LabelControl()
        Me.lblNivelComb = New DevExpress.XtraEditors.LabelControl()
        Me.lblModelo = New DevExpress.XtraEditors.LabelControl()
        Me.lblPlaca = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.txtNivelComb = New DevExpress.XtraEditors.TextEdit()
        Me.txtCpfCnpj = New DevExpress.XtraEditors.TextEdit()
        Me.tabHistorico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNCompras = New DevExpress.XtraEditors.TextEdit()
        Me.txtCredDev = New DevExpress.XtraEditors.TextEdit()
        Me.txtLimiteUsado = New DevExpress.XtraEditors.TextEdit()
        Me.txtLimiteCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtLimiteAtual = New DevExpress.XtraEditors.TextEdit()
        Me.txtUltimaVisita = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiasAtraso = New DevExpress.XtraEditors.TextEdit()
        Me.txtDataCadastro = New DevExpress.XtraEditors.TextEdit()
        Me.lblIgual = New DevExpress.XtraEditors.LabelControl()
        Me.lblMais = New DevExpress.XtraEditors.LabelControl()
        Me.btnVendas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsumo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCredDev = New DevExpress.XtraEditors.LabelControl()
        Me.lblNCompras = New DevExpress.XtraEditors.LabelControl()
        Me.lblLimiteCliente = New DevExpress.XtraEditors.LabelControl()
        Me.lblLimiteUsado = New DevExpress.XtraEditors.LabelControl()
        Me.lblLimiteAtual = New DevExpress.XtraEditors.LabelControl()
        Me.lblDiasAtraso = New DevExpress.XtraEditors.LabelControl()
        Me.lblUltimaVisita = New DevExpress.XtraEditors.LabelControl()
        Me.btnDataCadastro = New DevExpress.XtraEditors.LabelControl()
        Me.grpDescontoAcrescimo = New DevExpress.XtraEditors.GroupControl()
        Me.txtValorFrete = New DevExpress.XtraEditors.TextEdit()
        Me.txtPorcentagem = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorDistribuido = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDesconto = New DevExpress.XtraEditors.TextEdit()
        Me.btnDescontoAcrescimo = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.rdgTPS = New DevExpress.XtraEditors.RadioGroup()
        Me.rdgDescontoAcrescimo = New DevExpress.XtraEditors.RadioGroup()
        Me.lblValorFrete = New DevExpress.XtraEditors.LabelControl()
        Me.lblPorcentagem = New DevExpress.XtraEditors.LabelControl()
        Me.lblValor = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDesconto = New DevExpress.XtraEditors.LabelControl()
        Me.grpObservacoes = New DevExpress.XtraEditors.GroupControl()
        Me.memObservacoes = New DevExpress.XtraEditors.MemoEdit()
        Me.grpDefeitosVeiculo = New DevExpress.XtraEditors.GroupControl()
        Me.memDefeitosVeiculo = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grpItens = New DevExpress.XtraEditors.GroupControl()
        Me.txtTotalServicos = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalProdutos = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalGeral = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalGeral = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalProdutos = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalServicos = New DevExpress.XtraEditors.LabelControl()
        Me.btnExcluirItem = New DevExpress.XtraEditors.SimpleButton()
        Me.rdgVendaCusto = New DevExpress.XtraEditors.RadioGroup()
        Me.cboItensTab = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tabItensTab = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPedidoAtual = New DevExpress.XtraTab.XtraTabPage()
        Me.grdPedidoAtual = New DevExpress.XtraGrid.GridControl()
        Me.dsPedidoAtual = New System.Data.DataSet()
        Me.tbPedidoAtual = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.Tipo = New System.Data.DataColumn()
        Me.CodProd = New System.Data.DataColumn()
        Me.DescComDistribuicao = New System.Data.DataColumn()
        Me.DescSemDistribuicao = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodFor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescComDistribuicao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescSemDistribuicao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPedAut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodOrdens = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabUltimoPedido = New DevExpress.XtraTab.XtraTabPage()
        Me.grdUltimoPedido = New DevExpress.XtraGrid.GridControl()
        Me.dsUltimoPedido = New System.Data.DataSet()
        Me.tbUltimoPedido = New System.Data.DataTable()
        Me.ValorTotal = New System.Data.DataColumn()
        Me.ValorUnit = New System.Data.DataColumn()
        Me.SemDesc = New System.Data.DataColumn()
        Me.Qtde = New System.Data.DataColumn()
        Me.Produto = New System.Data.DataColumn()
        Me.CodigoInterno = New System.Data.DataColumn()
        Me.CodPed = New System.Data.DataColumn()
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colValorTotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSemDesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtde1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoInterno1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTodosPedido = New DevExpress.XtraTab.XtraTabPage()
        Me.grdTodosPedidos = New DevExpress.XtraGrid.GridControl()
        Me.dtTodosPedidos = New System.Data.DataSet()
        Me.tbTodosPedidos = New System.Data.DataTable()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoInterno2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPed1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduto2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtde2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSemDesc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorUnit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValorTotal2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.btnOrdem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNossoStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatusNano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabClientesProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClientesProdutos.SuspendLayout()
        Me.tabProdutos.SuspendLayout()
        CType(Me.tabAddRemover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddRemover.SuspendLayout()
        Me.tabRemoverProdutos.SuspendLayout()
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemoverQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemoverProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddProdutos.SuspendLayout()
        CType(Me.txtPreco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddPesquisarProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescontoPorc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstoque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgPS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCliente.SuspendLayout()
        CType(Me.tabDadosHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDadosHistorico.SuspendLayout()
        Me.tabDados.SuspendLayout()
        CType(Me.dtDataSaida.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDataSaida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDataEntrada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDataEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPesquisarNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKmSaida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKmEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDadosVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivelComb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistorico.SuspendLayout()
        CType(Me.txtNCompras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimiteUsado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimiteCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimiteAtual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUltimaVisita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataCadastro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDescontoAcrescimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescontoAcrescimo.SuspendLayout()
        CType(Me.txtValorFrete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDistribuido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTPS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDescontoAcrescimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpObservacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObservacoes.SuspendLayout()
        CType(Me.memObservacoes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDefeitosVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDefeitosVeiculo.SuspendLayout()
        CType(Me.memDefeitosVeiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.txtTotalServicos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalProdutos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalGeral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgVendaCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItensTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabItensTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabItensTab.SuspendLayout()
        Me.tabPedidoAtual.SuspendLayout()
        CType(Me.grdPedidoAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPedidoAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPedidoAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUltimoPedido.SuspendLayout()
        CType(Me.grdUltimoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsUltimoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUltimoPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTodosPedido.SuspendLayout()
        CType(Me.grdTodosPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTodosPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTodosPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPromissoria, Me.btnCompromisso, Me.btnVender, Me.btnEntrada, Me.btF3Salvar, Me.btnLimpar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPromissoria, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCompromisso, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVender, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEntrada, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btF3Salvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnPromissoria
        '
        Me.btnPromissoria.Caption = "Promissória"
        Me.btnPromissoria.Glyph = Global.telausuario.My.Resources.Resources.playlist
        Me.btnPromissoria.Id = 0
        Me.btnPromissoria.Name = "btnPromissoria"
        '
        'btnCompromisso
        '
        Me.btnCompromisso.Caption = "Compromisso"
        Me.btnCompromisso.Glyph = Global.telausuario.My.Resources.Resources.cal_2
        Me.btnCompromisso.Id = 1
        Me.btnCompromisso.Name = "btnCompromisso"
        '
        'btnVender
        '
        Me.btnVender.Caption = "Vender"
        Me.btnVender.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.btnVender.Id = 2
        Me.btnVender.Name = "btnVender"
        '
        'btnEntrada
        '
        Me.btnEntrada.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEntrada.Caption = "Entrada"
        Me.btnEntrada.Glyph = Global.telausuario.My.Resources.Resources.credit_card
        Me.btnEntrada.Id = 3
        Me.btnEntrada.Name = "btnEntrada"
        '
        'btF3Salvar
        '
        Me.btF3Salvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btF3Salvar.Caption = "F3 Salvar"
        Me.btF3Salvar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Gravar_32x32
        Me.btF3Salvar.Id = 4
        Me.btF3Salvar.Name = "btF3Salvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 5
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.telausuario.My.Resources.Resources.delete
        Me.btnFechar.Id = 6
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
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.Controls.Add(Me.btnOrdem)
        Me.pnlPrincipal.Controls.Add(Me.SimpleButton5)
        Me.pnlPrincipal.Controls.Add(Me.txtOrdem)
        Me.pnlPrincipal.Controls.Add(Me.lblOrdem)
        Me.pnlPrincipal.Controls.Add(Me.btnYoutube)
        Me.pnlPrincipal.Controls.Add(Me.dtData)
        Me.pnlPrincipal.Controls.Add(Me.lblData)
        Me.pnlPrincipal.Controls.Add(Me.cboNossoStatus)
        Me.pnlPrincipal.Controls.Add(Me.lblNossoStatus)
        Me.pnlPrincipal.Controls.Add(Me.cboStatusNano)
        Me.pnlPrincipal.Controls.Add(Me.lblStatusNano)
        Me.pnlPrincipal.Controls.Add(Me.cboVendedor)
        Me.pnlPrincipal.Controls.Add(Me.lblVendedor)
        Me.pnlPrincipal.Controls.Add(Me.tabClientesProdutos)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 1)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1008, 274)
        Me.pnlPrincipal.TabIndex = 4
        '
        'btnOrdem
        '
        Me.btnOrdem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOrdem.Location = New System.Drawing.Point(230, 11)
        Me.btnOrdem.MenuManager = Me.BarManager1
        Me.btnOrdem.Name = "btnOrdem"
        Me.btnOrdem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnOrdem.Size = New System.Drawing.Size(20, 20)
        Me.btnOrdem.TabIndex = 113
        Me.btnOrdem.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton5.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton5.Location = New System.Drawing.Point(753, 37)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton5.TabIndex = 104
        '
        'txtOrdem
        '
        Me.txtOrdem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOrdem.Location = New System.Drawing.Point(90, 11)
        Me.txtOrdem.MenuManager = Me.BarManager1
        Me.txtOrdem.Name = "txtOrdem"
        Me.txtOrdem.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtOrdem.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtOrdem.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtOrdem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrdem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtOrdem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtOrdem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtOrdem.Size = New System.Drawing.Size(143, 20)
        Me.txtOrdem.TabIndex = 112
        Me.txtOrdem.Visible = False
        '
        'lblOrdem
        '
        Me.lblOrdem.Location = New System.Drawing.Point(39, 14)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(47, 13)
        Me.lblOrdem.TabIndex = 114
        Me.lblOrdem.Text = "N° Ordem"
        Me.lblOrdem.Visible = False
        '
        'btnYoutube
        '
        Me.btnYoutube.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYoutube.Location = New System.Drawing.Point(969, 10)
        Me.btnYoutube.Name = "btnYoutube"
        Me.btnYoutube.Size = New System.Drawing.Size(21, 21)
        Me.btnYoutube.TabIndex = 9
        '
        'dtData
        '
        Me.dtData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtData.EditValue = Nothing
        Me.dtData.Location = New System.Drawing.Point(868, 11)
        Me.dtData.MenuManager = Me.BarManager1
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtData.Size = New System.Drawing.Size(101, 20)
        Me.dtData.TabIndex = 8
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData.Location = New System.Drawing.Point(839, 14)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(23, 13)
        Me.lblData.TabIndex = 7
        Me.lblData.Text = "Data"
        '
        'cboNossoStatus
        '
        Me.cboNossoStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNossoStatus.Location = New System.Drawing.Point(640, 37)
        Me.cboNossoStatus.MenuManager = Me.BarManager1
        Me.cboNossoStatus.Name = "cboNossoStatus"
        Me.cboNossoStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNossoStatus.Size = New System.Drawing.Size(115, 20)
        Me.cboNossoStatus.TabIndex = 6
        '
        'lblNossoStatus
        '
        Me.lblNossoStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNossoStatus.Location = New System.Drawing.Point(571, 40)
        Me.lblNossoStatus.Name = "lblNossoStatus"
        Me.lblNossoStatus.Size = New System.Drawing.Size(63, 13)
        Me.lblNossoStatus.TabIndex = 5
        Me.lblNossoStatus.Text = "Nosso Status"
        '
        'cboStatusNano
        '
        Me.cboStatusNano.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusNano.Location = New System.Drawing.Point(640, 11)
        Me.cboStatusNano.MenuManager = Me.BarManager1
        Me.cboStatusNano.Name = "cboStatusNano"
        Me.cboStatusNano.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatusNano.Properties.Items.AddRange(New Object() {"Pendente", "Orçamento"})
        Me.cboStatusNano.Size = New System.Drawing.Size(138, 20)
        Me.cboStatusNano.TabIndex = 4
        '
        'lblStatusNano
        '
        Me.lblStatusNano.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusNano.Location = New System.Drawing.Point(575, 14)
        Me.lblStatusNano.Name = "lblStatusNano"
        Me.lblStatusNano.Size = New System.Drawing.Size(59, 13)
        Me.lblStatusNano.TabIndex = 3
        Me.lblStatusNano.Text = "Status Nano"
        '
        'cboVendedor
        '
        Me.cboVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVendedor.Location = New System.Drawing.Point(307, 11)
        Me.cboVendedor.MenuManager = Me.BarManager1
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVendedor.Size = New System.Drawing.Size(238, 20)
        Me.cboVendedor.TabIndex = 2
        '
        'lblVendedor
        '
        Me.lblVendedor.Location = New System.Drawing.Point(256, 14)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(46, 13)
        Me.lblVendedor.TabIndex = 1
        Me.lblVendedor.Text = "Vendedor"
        '
        'tabClientesProdutos
        '
        Me.tabClientesProdutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabClientesProdutos.Location = New System.Drawing.Point(2, 45)
        Me.tabClientesProdutos.Name = "tabClientesProdutos"
        Me.tabClientesProdutos.SelectedTabPage = Me.tabProdutos
        Me.tabClientesProdutos.Size = New System.Drawing.Size(1008, 213)
        Me.tabClientesProdutos.TabIndex = 0
        Me.tabClientesProdutos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCliente, Me.tabProdutos})
        '
        'tabProdutos
        '
        Me.tabProdutos.Controls.Add(Me.tabAddRemover)
        Me.tabProdutos.Name = "tabProdutos"
        Me.tabProdutos.Size = New System.Drawing.Size(1002, 185)
        Me.tabProdutos.Text = "Produtos - F2"
        '
        'tabAddRemover
        '
        Me.tabAddRemover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAddRemover.Location = New System.Drawing.Point(0, 1)
        Me.tabAddRemover.Name = "tabAddRemover"
        Me.tabAddRemover.SelectedTabPage = Me.tabRemoverProdutos
        Me.tabAddRemover.Size = New System.Drawing.Size(1001, 193)
        Me.tabAddRemover.TabIndex = 1
        Me.tabAddRemover.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAddProdutos, Me.tabRemoverProdutos})
        '
        'tabRemoverProdutos
        '
        Me.tabRemoverProdutos.Controls.Add(Me.btnRemoverPesquisarGrid)
        Me.tabRemoverProdutos.Controls.Add(Me.txtRemoverCodigo)
        Me.tabRemoverProdutos.Controls.Add(Me.txtRemoverQtd)
        Me.tabRemoverProdutos.Controls.Add(Me.txtRemoverProduto)
        Me.tabRemoverProdutos.Controls.Add(Me.btnRemover)
        Me.tabRemoverProdutos.Controls.Add(Me.lblRQtd)
        Me.tabRemoverProdutos.Controls.Add(Me.lblRProduto)
        Me.tabRemoverProdutos.Controls.Add(Me.chkRemoverCodigo)
        Me.tabRemoverProdutos.Controls.Add(Me.lblRCodigo)
        Me.tabRemoverProdutos.Name = "tabRemoverProdutos"
        Me.tabRemoverProdutos.Size = New System.Drawing.Size(995, 165)
        Me.tabRemoverProdutos.Text = "Remover Produtos"
        '
        'btnRemoverPesquisarGrid
        '
        Me.btnRemoverPesquisarGrid.Location = New System.Drawing.Point(226, 99)
        Me.btnRemoverPesquisarGrid.MenuManager = Me.BarManager1
        Me.btnRemoverPesquisarGrid.Name = "btnRemoverPesquisarGrid"
        Me.btnRemoverPesquisarGrid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.btnRemoverPesquisarGrid.Size = New System.Drawing.Size(20, 20)
        Me.btnRemoverPesquisarGrid.TabIndex = 24
        '
        'txtRemoverCodigo
        '
        Me.txtRemoverCodigo.EnterMoveNextControl = True
        Me.txtRemoverCodigo.Location = New System.Drawing.Point(86, 99)
        Me.txtRemoverCodigo.MenuManager = Me.BarManager1
        Me.txtRemoverCodigo.Name = "txtRemoverCodigo"
        Me.txtRemoverCodigo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRemoverCodigo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtRemoverCodigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemoverCodigo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemoverCodigo.Properties.MaxLength = 10
        Me.txtRemoverCodigo.Size = New System.Drawing.Size(143, 20)
        Me.txtRemoverCodigo.TabIndex = 23
        '
        'txtRemoverQtd
        '
        Me.txtRemoverQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemoverQtd.EnterMoveNextControl = True
        Me.txtRemoverQtd.Location = New System.Drawing.Point(862, 99)
        Me.txtRemoverQtd.MenuManager = Me.BarManager1
        Me.txtRemoverQtd.Name = "txtRemoverQtd"
        Me.txtRemoverQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemoverQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemoverQtd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemoverQtd.Properties.MaxLength = 10
        Me.txtRemoverQtd.Size = New System.Drawing.Size(124, 20)
        Me.txtRemoverQtd.TabIndex = 26
        '
        'txtRemoverProduto
        '
        Me.txtRemoverProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemoverProduto.EnterMoveNextControl = True
        Me.txtRemoverProduto.Location = New System.Drawing.Point(303, 100)
        Me.txtRemoverProduto.MenuManager = Me.BarManager1
        Me.txtRemoverProduto.Name = "txtRemoverProduto"
        Me.txtRemoverProduto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemoverProduto.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemoverProduto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemoverProduto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRemoverProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemoverProduto.Size = New System.Drawing.Size(471, 20)
        Me.txtRemoverProduto.TabIndex = 25
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.Image = Global.telausuario.My.Resources.Resources.Remove_Item
        Me.btnRemover.Location = New System.Drawing.Point(862, 123)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(124, 23)
        Me.btnRemover.TabIndex = 143
        Me.btnRemover.Text = "Remover"
        '
        'lblRQtd
        '
        Me.lblRQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRQtd.Location = New System.Drawing.Point(840, 103)
        Me.lblRQtd.Name = "lblRQtd"
        Me.lblRQtd.Size = New System.Drawing.Size(18, 13)
        Me.lblRQtd.TabIndex = 141
        Me.lblRQtd.Text = "Qtd"
        '
        'lblRProduto
        '
        Me.lblRProduto.Location = New System.Drawing.Point(260, 102)
        Me.lblRProduto.Name = "lblRProduto"
        Me.lblRProduto.Size = New System.Drawing.Size(38, 13)
        Me.lblRProduto.TabIndex = 139
        Me.lblRProduto.Text = "Produto"
        '
        'chkRemoverCodigo
        '
        Me.chkRemoverCodigo.Location = New System.Drawing.Point(8, 100)
        Me.chkRemoverCodigo.MenuManager = Me.BarManager1
        Me.chkRemoverCodigo.Name = "chkRemoverCodigo"
        Me.chkRemoverCodigo.Properties.Caption = ""
        Me.chkRemoverCodigo.Size = New System.Drawing.Size(21, 19)
        Me.chkRemoverCodigo.TabIndex = 138
        '
        'lblRCodigo
        '
        Me.lblRCodigo.Location = New System.Drawing.Point(47, 102)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(33, 13)
        Me.lblRCodigo.TabIndex = 136
        Me.lblRCodigo.Text = "Código"
        '
        'tabAddProdutos
        '
        Me.tabAddProdutos.Controls.Add(Me.txtPreco)
        Me.tabAddProdutos.Controls.Add(Me.btnAddPesquisarProduto)
        Me.tabAddProdutos.Controls.Add(Me.txtAddCodigoInterno)
        Me.tabAddProdutos.Controls.Add(Me.ButtonEdit1)
        Me.tabAddProdutos.Controls.Add(Me.TextEdit1)
        Me.tabAddProdutos.Controls.Add(Me.lblProduto)
        Me.tabAddProdutos.Controls.Add(Me.txtAddQtd)
        Me.tabAddProdutos.Controls.Add(Me.txtSaldo)
        Me.tabAddProdutos.Controls.Add(Me.txtEmPedido)
        Me.tabAddProdutos.Controls.Add(Me.txtAddProduto)
        Me.tabAddProdutos.Controls.Add(Me.txtDescontoPorc)
        Me.tabAddProdutos.Controls.Add(Me.txtDesconto)
        Me.tabAddProdutos.Controls.Add(Me.txtCusto)
        Me.tabAddProdutos.Controls.Add(Me.txtEstoque)
        Me.tabAddProdutos.Controls.Add(Me.PanelControl2)
        Me.tabAddProdutos.Controls.Add(Me.btnAdicionar)
        Me.tabAddProdutos.Controls.Add(Me.chkCusto)
        Me.tabAddProdutos.Controls.Add(Me.chkCodigo)
        Me.tabAddProdutos.Controls.Add(Me.lblCusto)
        Me.tabAddProdutos.Controls.Add(Me.lblCodigo)
        Me.tabAddProdutos.Controls.Add(Me.lblQtd)
        Me.tabAddProdutos.Controls.Add(Me.lblPreco)
        Me.tabAddProdutos.Controls.Add(Me.lblDescontoPorc)
        Me.tabAddProdutos.Controls.Add(Me.lblDesconto)
        Me.tabAddProdutos.Controls.Add(Me.lblMecanico)
        Me.tabAddProdutos.Controls.Add(Me.lblSaldo)
        Me.tabAddProdutos.Controls.Add(Me.lblEmPedido)
        Me.tabAddProdutos.Controls.Add(Me.lblEmEstoque)
        Me.tabAddProdutos.Controls.Add(Me.rdgPS)
        Me.tabAddProdutos.Name = "tabAddProdutos"
        Me.tabAddProdutos.Size = New System.Drawing.Size(995, 165)
        Me.tabAddProdutos.Text = "Adicionar Produtos"
        '
        'txtPreco
        '
        Me.txtPreco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreco.EnterMoveNextControl = True
        Me.txtPreco.Location = New System.Drawing.Point(864, 88)
        Me.txtPreco.MenuManager = Me.BarManager1
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPreco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPreco.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtPreco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPreco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPreco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreco.Properties.MaxLength = 20
        Me.txtPreco.Size = New System.Drawing.Size(118, 20)
        Me.txtPreco.TabIndex = 162
        '
        'btnAddPesquisarProduto
        '
        Me.btnAddPesquisarProduto.Location = New System.Drawing.Point(226, 62)
        Me.btnAddPesquisarProduto.MenuManager = Me.BarManager1
        Me.btnAddPesquisarProduto.Name = "btnAddPesquisarProduto"
        Me.btnAddPesquisarProduto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.btnAddPesquisarProduto.Size = New System.Drawing.Size(20, 20)
        Me.btnAddPesquisarProduto.TabIndex = 156
        '
        'txtAddCodigoInterno
        '
        Me.txtAddCodigoInterno.EnterMoveNextControl = True
        Me.txtAddCodigoInterno.Location = New System.Drawing.Point(84, 62)
        Me.txtAddCodigoInterno.MenuManager = Me.BarManager1
        Me.txtAddCodigoInterno.Name = "txtAddCodigoInterno"
        Me.txtAddCodigoInterno.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtAddCodigoInterno.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAddCodigoInterno.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtAddCodigoInterno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddCodigoInterno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAddCodigoInterno.Properties.MaxLength = 10
        Me.txtAddCodigoInterno.Size = New System.Drawing.Size(162, 20)
        Me.txtAddCodigoInterno.TabIndex = 155
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(332, 88)
        Me.ButtonEdit1.MenuManager = Me.BarManager1
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.ButtonEdit1.Size = New System.Drawing.Size(21, 20)
        Me.ButtonEdit1.TabIndex = 154
        Me.ButtonEdit1.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(303, 88)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(34, 20)
        Me.TextEdit1.TabIndex = 159
        Me.TextEdit1.Visible = False
        '
        'lblProduto
        '
        Me.lblProduto.Location = New System.Drawing.Point(260, 65)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(38, 13)
        Me.lblProduto.TabIndex = 126
        Me.lblProduto.Text = "Produto"
        '
        'txtAddQtd
        '
        Me.txtAddQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddQtd.EnterMoveNextControl = True
        Me.txtAddQtd.Location = New System.Drawing.Point(864, 62)
        Me.txtAddQtd.MenuManager = Me.BarManager1
        Me.txtAddQtd.Name = "txtAddQtd"
        Me.txtAddQtd.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtAddQtd.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAddQtd.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtAddQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAddQtd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddQtd.Properties.MaxLength = 10
        Me.txtAddQtd.Size = New System.Drawing.Size(118, 20)
        Me.txtAddQtd.TabIndex = 157
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.EnterMoveNextControl = True
        Me.txtSaldo.Location = New System.Drawing.Point(864, 9)
        Me.txtSaldo.MenuManager = Me.BarManager1
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtSaldo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSaldo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.Size = New System.Drawing.Size(118, 20)
        Me.txtSaldo.TabIndex = 151
        Me.txtSaldo.Visible = False
        '
        'txtEmPedido
        '
        Me.txtEmPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmPedido.EnterMoveNextControl = True
        Me.txtEmPedido.Location = New System.Drawing.Point(663, 9)
        Me.txtEmPedido.MenuManager = Me.BarManager1
        Me.txtEmPedido.Name = "txtEmPedido"
        Me.txtEmPedido.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtEmPedido.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEmPedido.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtEmPedido.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmPedido.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmPedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmPedido.Size = New System.Drawing.Size(111, 20)
        Me.txtEmPedido.TabIndex = 150
        Me.txtEmPedido.Visible = False
        '
        'txtAddProduto
        '
        Me.txtAddProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddProduto.EnterMoveNextControl = True
        Me.txtAddProduto.Location = New System.Drawing.Point(303, 62)
        Me.txtAddProduto.MenuManager = Me.BarManager1
        Me.txtAddProduto.Name = "txtAddProduto"
        Me.txtAddProduto.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtAddProduto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtAddProduto.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtAddProduto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddProduto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAddProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtAddProduto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtAddProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddProduto.Size = New System.Drawing.Size(471, 20)
        Me.txtAddProduto.TabIndex = 156
        '
        'txtDescontoPorc
        '
        Me.txtDescontoPorc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescontoPorc.EnterMoveNextControl = True
        Me.txtDescontoPorc.Location = New System.Drawing.Point(663, 88)
        Me.txtDescontoPorc.MenuManager = Me.BarManager1
        Me.txtDescontoPorc.Name = "txtDescontoPorc"
        Me.txtDescontoPorc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescontoPorc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescontoPorc.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDescontoPorc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescontoPorc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDescontoPorc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescontoPorc.Properties.MaxLength = 10
        Me.txtDescontoPorc.Size = New System.Drawing.Size(111, 20)
        Me.txtDescontoPorc.TabIndex = 161
        '
        'txtDesconto
        '
        Me.txtDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(430, 88)
        Me.txtDesconto.MenuManager = Me.BarManager1
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesconto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.Properties.MaxLength = 10
        Me.txtDesconto.Size = New System.Drawing.Size(111, 20)
        Me.txtDesconto.TabIndex = 160
        '
        'txtCusto
        '
        Me.txtCusto.EnterMoveNextControl = True
        Me.txtCusto.Location = New System.Drawing.Point(84, 88)
        Me.txtCusto.MenuManager = Me.BarManager1
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCusto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCusto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCusto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCusto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusto.Size = New System.Drawing.Size(162, 20)
        Me.txtCusto.TabIndex = 158
        Me.txtCusto.Visible = False
        '
        'txtEstoque
        '
        Me.txtEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEstoque.EnterMoveNextControl = True
        Me.txtEstoque.Location = New System.Drawing.Point(430, 9)
        Me.txtEstoque.MenuManager = Me.BarManager1
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtEstoque.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEstoque.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtEstoque.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstoque.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEstoque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoque.Size = New System.Drawing.Size(111, 20)
        Me.txtEstoque.TabIndex = 145
        Me.txtEstoque.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(17, 41)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(965, 4)
        Me.PanelControl2.TabIndex = 139
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdicionar.Location = New System.Drawing.Point(864, 113)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(118, 23)
        Me.btnAdicionar.TabIndex = 163
        Me.btnAdicionar.Text = "Adicionar"
        '
        'chkCusto
        '
        Me.chkCusto.Location = New System.Drawing.Point(2, 85)
        Me.chkCusto.MenuManager = Me.BarManager1
        Me.chkCusto.Name = "chkCusto"
        Me.chkCusto.Properties.Caption = ""
        Me.chkCusto.Size = New System.Drawing.Size(27, 19)
        Me.chkCusto.TabIndex = 136
        Me.chkCusto.Visible = False
        '
        'chkCodigo
        '
        Me.chkCodigo.Location = New System.Drawing.Point(3, 64)
        Me.chkCodigo.MenuManager = Me.BarManager1
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Properties.Caption = ""
        Me.chkCodigo.Size = New System.Drawing.Size(27, 19)
        Me.chkCodigo.TabIndex = 135
        '
        'lblCusto
        '
        Me.lblCusto.Location = New System.Drawing.Point(34, 91)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(44, 13)
        Me.lblCusto.TabIndex = 133
        Me.lblCusto.Text = "Custo R$"
        Me.lblCusto.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(45, 67)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(33, 13)
        Me.lblCodigo.TabIndex = 131
        Me.lblCodigo.Text = "Código"
        '
        'lblQtd
        '
        Me.lblQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQtd.Location = New System.Drawing.Point(840, 65)
        Me.lblQtd.Name = "lblQtd"
        Me.lblQtd.Size = New System.Drawing.Size(18, 13)
        Me.lblQtd.TabIndex = 129
        Me.lblQtd.Text = "Qtd"
        '
        'lblPreco
        '
        Me.lblPreco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPreco.Location = New System.Drawing.Point(831, 91)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(27, 13)
        Me.lblPreco.TabIndex = 128
        Me.lblPreco.Text = "Preço"
        '
        'lblDescontoPorc
        '
        Me.lblDescontoPorc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescontoPorc.Location = New System.Drawing.Point(598, 91)
        Me.lblDescontoPorc.Name = "lblDescontoPorc"
        Me.lblDescontoPorc.Size = New System.Drawing.Size(59, 13)
        Me.lblDescontoPorc.TabIndex = 123
        Me.lblDescontoPorc.Text = "Desconto %"
        '
        'lblDesconto
        '
        Me.lblDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesconto.Location = New System.Drawing.Point(363, 91)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(61, 13)
        Me.lblDesconto.TabIndex = 121
        Me.lblDesconto.Text = "Desconto R$"
        '
        'lblMecanico
        '
        Me.lblMecanico.Location = New System.Drawing.Point(254, 91)
        Me.lblMecanico.Name = "lblMecanico"
        Me.lblMecanico.Size = New System.Drawing.Size(44, 13)
        Me.lblMecanico.TabIndex = 105
        Me.lblMecanico.Text = "Mecânico"
        Me.lblMecanico.Visible = False
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldo.Location = New System.Drawing.Point(832, 10)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(26, 13)
        Me.lblSaldo.TabIndex = 119
        Me.lblSaldo.Text = "Saldo"
        Me.lblSaldo.Visible = False
        '
        'lblEmPedido
        '
        Me.lblEmPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmPedido.Location = New System.Drawing.Point(608, 12)
        Me.lblEmPedido.Name = "lblEmPedido"
        Me.lblEmPedido.Size = New System.Drawing.Size(49, 13)
        Me.lblEmPedido.TabIndex = 117
        Me.lblEmPedido.Text = "Em Pedido"
        Me.lblEmPedido.Visible = False
        '
        'lblEmEstoque
        '
        Me.lblEmEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmEstoque.Location = New System.Drawing.Point(385, 12)
        Me.lblEmEstoque.Name = "lblEmEstoque"
        Me.lblEmEstoque.Size = New System.Drawing.Size(39, 13)
        Me.lblEmEstoque.TabIndex = 115
        Me.lblEmEstoque.Text = "Estoque"
        Me.lblEmEstoque.Visible = False
        '
        'rdgPS
        '
        Me.rdgPS.Location = New System.Drawing.Point(84, 7)
        Me.rdgPS.Name = "rdgPS"
        Me.rdgPS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgPS.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "P"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "S")})
        Me.rdgPS.Size = New System.Drawing.Size(131, 22)
        Me.rdgPS.TabIndex = 114
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.tabDadosHistorico)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Size = New System.Drawing.Size(1002, 185)
        Me.tabCliente.Text = "Clientes - F7"
        '
        'tabDadosHistorico
        '
        Me.tabDadosHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDadosHistorico.Location = New System.Drawing.Point(-1, 3)
        Me.tabDadosHistorico.Name = "tabDadosHistorico"
        Me.tabDadosHistorico.SelectedTabPage = Me.tabDados
        Me.tabDadosHistorico.Size = New System.Drawing.Size(1003, 176)
        Me.tabDadosHistorico.TabIndex = 0
        Me.tabDadosHistorico.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDados, Me.tabHistorico})
        '
        'tabDados
        '
        Me.tabDados.Controls.Add(Me.dtDataSaida)
        Me.tabDados.Controls.Add(Me.dtDataEntrada)
        Me.tabDados.Controls.Add(Me.btnPesquisarNome)
        Me.tabDados.Controls.Add(Me.txtNome)
        Me.tabDados.Controls.Add(Me.txtCor)
        Me.tabDados.Controls.Add(Me.txtModelo)
        Me.tabDados.Controls.Add(Me.txtEmail)
        Me.tabDados.Controls.Add(Me.txtKmSaida)
        Me.tabDados.Controls.Add(Me.txtKmEntrada)
        Me.tabDados.Controls.Add(Me.txtAno)
        Me.tabDados.Controls.Add(Me.txtMotor)
        Me.tabDados.Controls.Add(Me.txtCelular)
        Me.tabDados.Controls.Add(Me.txtTelefone)
        Me.tabDados.Controls.Add(Me.ComboBoxEdit2)
        Me.tabDados.Controls.Add(Me.lblDadosVeiculo)
        Me.tabDados.Controls.Add(Me.pnlDadosVeiculo)
        Me.tabDados.Controls.Add(Me.SimpleButton2)
        Me.tabDados.Controls.Add(Me.lblKmSaida)
        Me.tabDados.Controls.Add(Me.lblKmEntrada)
        Me.tabDados.Controls.Add(Me.lblDataSaida)
        Me.tabDados.Controls.Add(Me.lblDataEntrada)
        Me.tabDados.Controls.Add(Me.lblAno)
        Me.tabDados.Controls.Add(Me.lblMotor)
        Me.tabDados.Controls.Add(Me.lblCelular)
        Me.tabDados.Controls.Add(Me.lblTelefone)
        Me.tabDados.Controls.Add(Me.lblCpfCnpj)
        Me.tabDados.Controls.Add(Me.lblNome)
        Me.tabDados.Controls.Add(Me.lblCor)
        Me.tabDados.Controls.Add(Me.lblNivelComb)
        Me.tabDados.Controls.Add(Me.lblModelo)
        Me.tabDados.Controls.Add(Me.lblPlaca)
        Me.tabDados.Controls.Add(Me.lblEmail)
        Me.tabDados.Controls.Add(Me.txtNivelComb)
        Me.tabDados.Controls.Add(Me.txtCpfCnpj)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Size = New System.Drawing.Size(997, 148)
        Me.tabDados.Text = "Dados"
        '
        'dtDataSaida
        '
        Me.dtDataSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDataSaida.EditValue = Nothing
        Me.dtDataSaida.Location = New System.Drawing.Point(867, 38)
        Me.dtDataSaida.MenuManager = Me.BarManager1
        Me.dtDataSaida.Name = "dtDataSaida"
        Me.dtDataSaida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDataSaida.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDataSaida.Size = New System.Drawing.Size(114, 20)
        Me.dtDataSaida.TabIndex = 116
        '
        'dtDataEntrada
        '
        Me.dtDataEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDataEntrada.EditValue = Nothing
        Me.dtDataEntrada.Location = New System.Drawing.Point(867, 12)
        Me.dtDataEntrada.MenuManager = Me.BarManager1
        Me.dtDataEntrada.Name = "dtDataEntrada"
        Me.dtDataEntrada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDataEntrada.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDataEntrada.Size = New System.Drawing.Size(114, 20)
        Me.dtDataEntrada.TabIndex = 115
        '
        'btnPesquisarNome
        '
        Me.btnPesquisarNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisarNome.Location = New System.Drawing.Point(522, 12)
        Me.btnPesquisarNome.MenuManager = Me.BarManager1
        Me.btnPesquisarNome.Name = "btnPesquisarNome"
        Me.btnPesquisarNome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.telausuario.My.Resources.Resources.Lupa_Azul_12x12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.btnPesquisarNome.Size = New System.Drawing.Size(20, 20)
        Me.btnPesquisarNome.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(89, 12)
        Me.txtNome.MenuManager = Me.BarManager1
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtNome.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNome.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNome.Properties.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(435, 20)
        Me.txtNome.TabIndex = 0
        '
        'txtCor
        '
        Me.txtCor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCor.EnterMoveNextControl = True
        Me.txtCor.Location = New System.Drawing.Point(304, 115)
        Me.txtCor.MenuManager = Me.BarManager1
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCor.Size = New System.Drawing.Size(238, 20)
        Me.txtCor.TabIndex = 13
        Me.txtCor.Visible = False
        '
        'txtModelo
        '
        Me.txtModelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelo.EnterMoveNextControl = True
        Me.txtModelo.Location = New System.Drawing.Point(304, 89)
        Me.txtModelo.MenuManager = Me.BarManager1
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtModelo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtModelo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtModelo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModelo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Size = New System.Drawing.Size(238, 20)
        Me.txtModelo.TabIndex = 9
        Me.txtModelo.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(304, 38)
        Me.txtEmail.MenuManager = Me.BarManager1
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmail.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtEmail.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEmail.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEmail.Properties.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(238, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtKmSaida
        '
        Me.txtKmSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKmSaida.EnterMoveNextControl = True
        Me.txtKmSaida.Location = New System.Drawing.Point(867, 115)
        Me.txtKmSaida.MenuManager = Me.BarManager1
        Me.txtKmSaida.Name = "txtKmSaida"
        Me.txtKmSaida.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKmSaida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKmSaida.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtKmSaida.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKmSaida.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKmSaida.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKmSaida.Size = New System.Drawing.Size(114, 20)
        Me.txtKmSaida.TabIndex = 16
        Me.txtKmSaida.Visible = False
        '
        'txtKmEntrada
        '
        Me.txtKmEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKmEntrada.EnterMoveNextControl = True
        Me.txtKmEntrada.Location = New System.Drawing.Point(867, 89)
        Me.txtKmEntrada.MenuManager = Me.BarManager1
        Me.txtKmEntrada.Name = "txtKmEntrada"
        Me.txtKmEntrada.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKmEntrada.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKmEntrada.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtKmEntrada.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKmEntrada.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKmEntrada.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKmEntrada.Size = New System.Drawing.Size(114, 20)
        Me.txtKmEntrada.TabIndex = 11
        Me.txtKmEntrada.Visible = False
        '
        'txtAno
        '
        Me.txtAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAno.EnterMoveNextControl = True
        Me.txtAno.Location = New System.Drawing.Point(637, 115)
        Me.txtAno.MenuManager = Me.BarManager1
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAno.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtAno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAno.Size = New System.Drawing.Size(138, 20)
        Me.txtAno.TabIndex = 15
        Me.txtAno.Visible = False
        '
        'txtMotor
        '
        Me.txtMotor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotor.EnterMoveNextControl = True
        Me.txtMotor.Location = New System.Drawing.Point(637, 89)
        Me.txtMotor.MenuManager = Me.BarManager1
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMotor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMotor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtMotor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMotor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotor.Size = New System.Drawing.Size(138, 20)
        Me.txtMotor.TabIndex = 10
        Me.txtMotor.Visible = False
        '
        'txtCelular
        '
        Me.txtCelular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCelular.EnterMoveNextControl = True
        Me.txtCelular.Location = New System.Drawing.Point(637, 38)
        Me.txtCelular.MenuManager = Me.BarManager1
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCelular.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCelular.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCelular.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCelular.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCelular.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCelular.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCelular.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Properties.ReadOnly = True
        Me.txtCelular.Size = New System.Drawing.Size(138, 20)
        Me.txtCelular.TabIndex = 6
        '
        'txtTelefone
        '
        Me.txtTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone.EnterMoveNextControl = True
        Me.txtTelefone.Location = New System.Drawing.Point(637, 12)
        Me.txtTelefone.MenuManager = Me.BarManager1
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTelefone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTelefone.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtTelefone.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefone.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelefone.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTelefone.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTelefone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone.Properties.ReadOnly = True
        Me.txtTelefone.Size = New System.Drawing.Size(138, 20)
        Me.txtTelefone.TabIndex = 2
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(89, 89)
        Me.ComboBoxEdit2.MenuManager = Me.BarManager1
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(134, 20)
        Me.ComboBoxEdit2.TabIndex = 8
        Me.ComboBoxEdit2.Visible = False
        '
        'lblDadosVeiculo
        '
        Me.lblDadosVeiculo.Location = New System.Drawing.Point(55, 66)
        Me.lblDadosVeiculo.Name = "lblDadosVeiculo"
        Me.lblDadosVeiculo.Size = New System.Drawing.Size(81, 13)
        Me.lblDadosVeiculo.TabIndex = 110
        Me.lblDadosVeiculo.Text = "Dados do Veículo"
        Me.lblDadosVeiculo.Visible = False
        '
        'pnlDadosVeiculo
        '
        Me.pnlDadosVeiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDadosVeiculo.Location = New System.Drawing.Point(11, 75)
        Me.pnlDadosVeiculo.Name = "pnlDadosVeiculo"
        Me.pnlDadosVeiculo.Size = New System.Drawing.Size(974, 4)
        Me.pnlDadosVeiculo.TabIndex = 111
        Me.pnlDadosVeiculo.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.telausuario.My.Resources.Resources.edit_add
        Me.SimpleButton2.Location = New System.Drawing.Point(220, 89)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton2.TabIndex = 106
        Me.SimpleButton2.Visible = False
        '
        'lblKmSaida
        '
        Me.lblKmSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKmSaida.Location = New System.Drawing.Point(818, 118)
        Me.lblKmSaida.Name = "lblKmSaida"
        Me.lblKmSaida.Size = New System.Drawing.Size(43, 13)
        Me.lblKmSaida.TabIndex = 30
        Me.lblKmSaida.Text = "Km Saída"
        Me.lblKmSaida.Visible = False
        '
        'lblKmEntrada
        '
        Me.lblKmEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKmEntrada.Location = New System.Drawing.Point(806, 92)
        Me.lblKmEntrada.Name = "lblKmEntrada"
        Me.lblKmEntrada.Size = New System.Drawing.Size(55, 13)
        Me.lblKmEntrada.TabIndex = 28
        Me.lblKmEntrada.Text = "Km Entrada"
        Me.lblKmEntrada.Visible = False
        '
        'lblDataSaida
        '
        Me.lblDataSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataSaida.Location = New System.Drawing.Point(809, 41)
        Me.lblDataSaida.Name = "lblDataSaida"
        Me.lblDataSaida.Size = New System.Drawing.Size(52, 13)
        Me.lblDataSaida.TabIndex = 26
        Me.lblDataSaida.Text = "Data Saída"
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntrada.Location = New System.Drawing.Point(797, 15)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(64, 13)
        Me.lblDataEntrada.TabIndex = 24
        Me.lblDataEntrada.Text = "Data Entrada"
        '
        'lblAno
        '
        Me.lblAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAno.Location = New System.Drawing.Point(612, 118)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(19, 13)
        Me.lblAno.TabIndex = 22
        Me.lblAno.Text = "Ano"
        Me.lblAno.Visible = False
        '
        'lblMotor
        '
        Me.lblMotor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMotor.Location = New System.Drawing.Point(605, 92)
        Me.lblMotor.Name = "lblMotor"
        Me.lblMotor.Size = New System.Drawing.Size(28, 13)
        Me.lblMotor.TabIndex = 20
        Me.lblMotor.Text = "Motor"
        Me.lblMotor.Visible = False
        '
        'lblCelular
        '
        Me.lblCelular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCelular.Location = New System.Drawing.Point(598, 41)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(33, 13)
        Me.lblCelular.TabIndex = 18
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone
        '
        Me.lblTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefone.Location = New System.Drawing.Point(591, 15)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(42, 13)
        Me.lblTelefone.TabIndex = 16
        Me.lblTelefone.Text = "Telefone"
        '
        'lblCpfCnpj
        '
        Me.lblCpfCnpj.Location = New System.Drawing.Point(35, 41)
        Me.lblCpfCnpj.Name = "lblCpfCnpj"
        Me.lblCpfCnpj.Size = New System.Drawing.Size(48, 13)
        Me.lblCpfCnpj.TabIndex = 12
        Me.lblCpfCnpj.Text = "CPF/CNPJ"
        '
        'lblNome
        '
        Me.lblNome.Location = New System.Drawing.Point(34, 15)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(49, 13)
        Me.lblNome.TabIndex = 10
        Me.lblNome.Text = "F7 - Nome"
        '
        'lblCor
        '
        Me.lblCor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCor.Location = New System.Drawing.Point(269, 118)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(17, 13)
        Me.lblCor.TabIndex = 38
        Me.lblCor.Text = "Cor"
        Me.lblCor.Visible = False
        '
        'lblNivelComb
        '
        Me.lblNivelComb.Location = New System.Drawing.Point(26, 118)
        Me.lblNivelComb.Name = "lblNivelComb"
        Me.lblNivelComb.Size = New System.Drawing.Size(57, 13)
        Me.lblNivelComb.TabIndex = 36
        Me.lblNivelComb.Text = "Nivel Comb."
        Me.lblNivelComb.Visible = False
        '
        'lblModelo
        '
        Me.lblModelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModelo.Location = New System.Drawing.Point(264, 92)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(34, 13)
        Me.lblModelo.TabIndex = 34
        Me.lblModelo.Text = "Modelo"
        Me.lblModelo.Visible = False
        '
        'lblPlaca
        '
        Me.lblPlaca.Location = New System.Drawing.Point(58, 92)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(25, 13)
        Me.lblPlaca.TabIndex = 32
        Me.lblPlaca.Text = "Placa"
        Me.lblPlaca.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(270, 41)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(28, 13)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "E-Mail"
        '
        'txtNivelComb
        '
        Me.txtNivelComb.EnterMoveNextControl = True
        Me.txtNivelComb.Location = New System.Drawing.Point(89, 115)
        Me.txtNivelComb.MenuManager = Me.BarManager1
        Me.txtNivelComb.Name = "txtNivelComb"
        Me.txtNivelComb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNivelComb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNivelComb.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtNivelComb.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNivelComb.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNivelComb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNivelComb.Size = New System.Drawing.Size(158, 20)
        Me.txtNivelComb.TabIndex = 12
        Me.txtNivelComb.Visible = False
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.EnterMoveNextControl = True
        Me.txtCpfCnpj.Location = New System.Drawing.Point(89, 38)
        Me.txtCpfCnpj.MenuManager = Me.BarManager1
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCpfCnpj.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCpfCnpj.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtCpfCnpj.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCpfCnpj.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCpfCnpj.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCpfCnpj.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCpfCnpj.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCpfCnpj.Properties.ReadOnly = True
        Me.txtCpfCnpj.Size = New System.Drawing.Size(158, 20)
        Me.txtCpfCnpj.TabIndex = 4
        '
        'tabHistorico
        '
        Me.tabHistorico.Controls.Add(Me.txtNCompras)
        Me.tabHistorico.Controls.Add(Me.txtCredDev)
        Me.tabHistorico.Controls.Add(Me.txtLimiteUsado)
        Me.tabHistorico.Controls.Add(Me.txtLimiteCliente)
        Me.tabHistorico.Controls.Add(Me.txtLimiteAtual)
        Me.tabHistorico.Controls.Add(Me.txtUltimaVisita)
        Me.tabHistorico.Controls.Add(Me.txtDiasAtraso)
        Me.tabHistorico.Controls.Add(Me.txtDataCadastro)
        Me.tabHistorico.Controls.Add(Me.lblIgual)
        Me.tabHistorico.Controls.Add(Me.lblMais)
        Me.tabHistorico.Controls.Add(Me.btnVendas)
        Me.tabHistorico.Controls.Add(Me.btnConsumo)
        Me.tabHistorico.Controls.Add(Me.lblCredDev)
        Me.tabHistorico.Controls.Add(Me.lblNCompras)
        Me.tabHistorico.Controls.Add(Me.lblLimiteCliente)
        Me.tabHistorico.Controls.Add(Me.lblLimiteUsado)
        Me.tabHistorico.Controls.Add(Me.lblLimiteAtual)
        Me.tabHistorico.Controls.Add(Me.lblDiasAtraso)
        Me.tabHistorico.Controls.Add(Me.lblUltimaVisita)
        Me.tabHistorico.Controls.Add(Me.btnDataCadastro)
        Me.tabHistorico.Name = "tabHistorico"
        Me.tabHistorico.PageEnabled = False
        Me.tabHistorico.Size = New System.Drawing.Size(997, 148)
        Me.tabHistorico.Text = "Histórico"
        '
        'txtNCompras
        '
        Me.txtNCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNCompras.Location = New System.Drawing.Point(637, 9)
        Me.txtNCompras.MenuManager = Me.BarManager1
        Me.txtNCompras.Name = "txtNCompras"
        Me.txtNCompras.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCompras.Size = New System.Drawing.Size(138, 20)
        Me.txtNCompras.TabIndex = 149
        '
        'txtCredDev
        '
        Me.txtCredDev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCredDev.Location = New System.Drawing.Point(637, 61)
        Me.txtCredDev.MenuManager = Me.BarManager1
        Me.txtCredDev.Name = "txtCredDev"
        Me.txtCredDev.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCredDev.Size = New System.Drawing.Size(138, 20)
        Me.txtCredDev.TabIndex = 148
        '
        'txtLimiteUsado
        '
        Me.txtLimiteUsado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLimiteUsado.Location = New System.Drawing.Point(865, 35)
        Me.txtLimiteUsado.MenuManager = Me.BarManager1
        Me.txtLimiteUsado.Name = "txtLimiteUsado"
        Me.txtLimiteUsado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimiteUsado.Size = New System.Drawing.Size(112, 20)
        Me.txtLimiteUsado.TabIndex = 147
        '
        'txtLimiteCliente
        '
        Me.txtLimiteCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLimiteCliente.Location = New System.Drawing.Point(865, 61)
        Me.txtLimiteCliente.MenuManager = Me.BarManager1
        Me.txtLimiteCliente.Name = "txtLimiteCliente"
        Me.txtLimiteCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimiteCliente.Size = New System.Drawing.Size(112, 20)
        Me.txtLimiteCliente.TabIndex = 146
        '
        'txtLimiteAtual
        '
        Me.txtLimiteAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLimiteAtual.Location = New System.Drawing.Point(865, 9)
        Me.txtLimiteAtual.MenuManager = Me.BarManager1
        Me.txtLimiteAtual.Name = "txtLimiteAtual"
        Me.txtLimiteAtual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimiteAtual.Size = New System.Drawing.Size(112, 20)
        Me.txtLimiteAtual.TabIndex = 145
        '
        'txtUltimaVisita
        '
        Me.txtUltimaVisita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUltimaVisita.Location = New System.Drawing.Point(430, 35)
        Me.txtUltimaVisita.MenuManager = Me.BarManager1
        Me.txtUltimaVisita.Name = "txtUltimaVisita"
        Me.txtUltimaVisita.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimaVisita.Size = New System.Drawing.Size(112, 20)
        Me.txtUltimaVisita.TabIndex = 144
        '
        'txtDiasAtraso
        '
        Me.txtDiasAtraso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiasAtraso.Location = New System.Drawing.Point(431, 61)
        Me.txtDiasAtraso.MenuManager = Me.BarManager1
        Me.txtDiasAtraso.Name = "txtDiasAtraso"
        Me.txtDiasAtraso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasAtraso.Size = New System.Drawing.Size(111, 20)
        Me.txtDiasAtraso.TabIndex = 143
        '
        'txtDataCadastro
        '
        Me.txtDataCadastro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataCadastro.Location = New System.Drawing.Point(430, 9)
        Me.txtDataCadastro.MenuManager = Me.BarManager1
        Me.txtDataCadastro.Name = "txtDataCadastro"
        Me.txtDataCadastro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataCadastro.Size = New System.Drawing.Size(112, 20)
        Me.txtDataCadastro.TabIndex = 142
        '
        'lblIgual
        '
        Me.lblIgual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIgual.Location = New System.Drawing.Point(781, 46)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(8, 13)
        Me.lblIgual.TabIndex = 141
        Me.lblIgual.Text = "="
        '
        'lblMais
        '
        Me.lblMais.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMais.Location = New System.Drawing.Point(781, 27)
        Me.lblMais.Name = "lblMais"
        Me.lblMais.Size = New System.Drawing.Size(8, 13)
        Me.lblMais.TabIndex = 140
        Me.lblMais.Text = "+"
        '
        'btnVendas
        '
        Me.btnVendas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVendas.Image = Global.telausuario.My.Resources.Resources.Itens_24x24
        Me.btnVendas.Location = New System.Drawing.Point(196, 12)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(138, 23)
        Me.btnVendas.TabIndex = 139
        Me.btnVendas.Text = "Vendas"
        '
        'btnConsumo
        '
        Me.btnConsumo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsumo.Image = Global.telausuario.My.Resources.Resources.Itens_24x24
        Me.btnConsumo.Location = New System.Drawing.Point(196, 45)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(138, 23)
        Me.btnConsumo.TabIndex = 138
        Me.btnConsumo.Text = "Consumo"
        '
        'lblCredDev
        '
        Me.lblCredDev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCredDev.Location = New System.Drawing.Point(578, 64)
        Me.lblCredDev.Name = "lblCredDev"
        Me.lblCredDev.Size = New System.Drawing.Size(53, 13)
        Me.lblCredDev.TabIndex = 38
        Me.lblCredDev.Text = "Créd. Dev."
        '
        'lblNCompras
        '
        Me.lblNCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNCompras.Location = New System.Drawing.Point(574, 12)
        Me.lblNCompras.Name = "lblNCompras"
        Me.lblNCompras.Size = New System.Drawing.Size(57, 13)
        Me.lblNCompras.TabIndex = 34
        Me.lblNCompras.Text = "N° Compras"
        '
        'lblLimiteCliente
        '
        Me.lblLimiteCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLimiteCliente.Location = New System.Drawing.Point(796, 64)
        Me.lblLimiteCliente.Name = "lblLimiteCliente"
        Me.lblLimiteCliente.Size = New System.Drawing.Size(63, 13)
        Me.lblLimiteCliente.TabIndex = 32
        Me.lblLimiteCliente.Text = "Limite Cliente"
        '
        'lblLimiteUsado
        '
        Me.lblLimiteUsado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLimiteUsado.Location = New System.Drawing.Point(799, 38)
        Me.lblLimiteUsado.Name = "lblLimiteUsado"
        Me.lblLimiteUsado.Size = New System.Drawing.Size(60, 13)
        Me.lblLimiteUsado.TabIndex = 30
        Me.lblLimiteUsado.Text = "Limite Usado"
        '
        'lblLimiteAtual
        '
        Me.lblLimiteAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLimiteAtual.Location = New System.Drawing.Point(804, 12)
        Me.lblLimiteAtual.Name = "lblLimiteAtual"
        Me.lblLimiteAtual.Size = New System.Drawing.Size(55, 13)
        Me.lblLimiteAtual.TabIndex = 28
        Me.lblLimiteAtual.Text = "Limite Atual"
        '
        'lblDiasAtraso
        '
        Me.lblDiasAtraso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiasAtraso.Location = New System.Drawing.Point(370, 64)
        Me.lblDiasAtraso.Name = "lblDiasAtraso"
        Me.lblDiasAtraso.Size = New System.Drawing.Size(55, 13)
        Me.lblDiasAtraso.TabIndex = 26
        Me.lblDiasAtraso.Text = "Dias Atraso"
        '
        'lblUltimaVisita
        '
        Me.lblUltimaVisita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUltimaVisita.Location = New System.Drawing.Point(367, 38)
        Me.lblUltimaVisita.Name = "lblUltimaVisita"
        Me.lblUltimaVisita.Size = New System.Drawing.Size(57, 13)
        Me.lblUltimaVisita.TabIndex = 24
        Me.lblUltimaVisita.Text = "Última Visita"
        '
        'btnDataCadastro
        '
        Me.btnDataCadastro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDataCadastro.Location = New System.Drawing.Point(354, 12)
        Me.btnDataCadastro.Name = "btnDataCadastro"
        Me.btnDataCadastro.Size = New System.Drawing.Size(70, 13)
        Me.btnDataCadastro.TabIndex = 22
        Me.btnDataCadastro.Text = "Data Cadastro"
        '
        'grpDescontoAcrescimo
        '
        Me.grpDescontoAcrescimo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDescontoAcrescimo.Controls.Add(Me.txtValorFrete)
        Me.grpDescontoAcrescimo.Controls.Add(Me.txtPorcentagem)
        Me.grpDescontoAcrescimo.Controls.Add(Me.txtValorDistribuido)
        Me.grpDescontoAcrescimo.Controls.Add(Me.txtTotalDesconto)
        Me.grpDescontoAcrescimo.Controls.Add(Me.btnDescontoAcrescimo)
        Me.grpDescontoAcrescimo.Controls.Add(Me.PanelControl1)
        Me.grpDescontoAcrescimo.Controls.Add(Me.rdgTPS)
        Me.grpDescontoAcrescimo.Controls.Add(Me.rdgDescontoAcrescimo)
        Me.grpDescontoAcrescimo.Controls.Add(Me.lblValorFrete)
        Me.grpDescontoAcrescimo.Controls.Add(Me.lblPorcentagem)
        Me.grpDescontoAcrescimo.Controls.Add(Me.lblValor)
        Me.grpDescontoAcrescimo.Controls.Add(Me.lblTotalDesconto)
        Me.grpDescontoAcrescimo.Location = New System.Drawing.Point(808, 250)
        Me.grpDescontoAcrescimo.Name = "grpDescontoAcrescimo"
        Me.grpDescontoAcrescimo.Size = New System.Drawing.Size(200, 367)
        Me.grpDescontoAcrescimo.TabIndex = 5
        Me.grpDescontoAcrescimo.Text = "Desconto / Acréscimo"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorFrete.EnterMoveNextControl = True
        Me.txtValorFrete.Location = New System.Drawing.Point(10, 281)
        Me.txtValorFrete.MenuManager = Me.BarManager1
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValorFrete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorFrete.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValorFrete.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorFrete.Properties.Appearance.Options.UseFont = True
        Me.txtValorFrete.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorFrete.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorFrete.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorFrete.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtValorFrete.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorFrete.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValorFrete.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorFrete.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValorFrete.Size = New System.Drawing.Size(181, 30)
        Me.txtValorFrete.TabIndex = 22
        '
        'txtPorcentagem
        '
        Me.txtPorcentagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorcentagem.EnterMoveNextControl = True
        Me.txtPorcentagem.Location = New System.Drawing.Point(10, 207)
        Me.txtPorcentagem.MenuManager = Me.BarManager1
        Me.txtPorcentagem.Name = "txtPorcentagem"
        Me.txtPorcentagem.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtPorcentagem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPorcentagem.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtPorcentagem.Properties.Appearance.Options.UseBackColor = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseFont = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseForeColor = True
        Me.txtPorcentagem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorcentagem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPorcentagem.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtPorcentagem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPorcentagem.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtPorcentagem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPorcentagem.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtPorcentagem.Size = New System.Drawing.Size(181, 30)
        Me.txtPorcentagem.TabIndex = 21
        '
        'txtValorDistribuido
        '
        Me.txtValorDistribuido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDistribuido.EnterMoveNextControl = True
        Me.txtValorDistribuido.Location = New System.Drawing.Point(10, 147)
        Me.txtValorDistribuido.MenuManager = Me.BarManager1
        Me.txtValorDistribuido.Name = "txtValorDistribuido"
        Me.txtValorDistribuido.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValorDistribuido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorDistribuido.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValorDistribuido.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorDistribuido.Properties.Appearance.Options.UseFont = True
        Me.txtValorDistribuido.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorDistribuido.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorDistribuido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorDistribuido.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtValorDistribuido.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorDistribuido.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValorDistribuido.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorDistribuido.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValorDistribuido.Size = New System.Drawing.Size(181, 30)
        Me.txtValorDistribuido.TabIndex = 20
        '
        'txtTotalDesconto
        '
        Me.txtTotalDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDesconto.Location = New System.Drawing.Point(10, 55)
        Me.txtTotalDesconto.MenuManager = Me.BarManager1
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalDesconto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtTotalDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotalDesconto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtTotalDesconto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotalDesconto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalDesconto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalDesconto.Properties.ReadOnly = True
        Me.txtTotalDesconto.Size = New System.Drawing.Size(181, 30)
        Me.txtTotalDesconto.TabIndex = 19
        '
        'btnDescontoAcrescimo
        '
        Me.btnDescontoAcrescimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDescontoAcrescimo.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDescontoAcrescimo.Appearance.Options.UseFont = True
        Me.btnDescontoAcrescimo.Image = Global.telausuario.My.Resources.Resources.Porcentagem2
        Me.btnDescontoAcrescimo.Location = New System.Drawing.Point(2, 344)
        Me.btnDescontoAcrescimo.Name = "btnDescontoAcrescimo"
        Me.btnDescontoAcrescimo.Size = New System.Drawing.Size(200, 23)
        Me.btnDescontoAcrescimo.TabIndex = 113
        Me.btnDescontoAcrescimo.Text = "F6 - Desconto / Acréscimo"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(7, 243)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(184, 5)
        Me.PanelControl1.TabIndex = 112
        '
        'rdgTPS
        '
        Me.rdgTPS.Location = New System.Drawing.Point(80, 119)
        Me.rdgTPS.Name = "rdgTPS"
        Me.rdgTPS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgTPS.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "T"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "P"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "S")})
        Me.rdgTPS.Size = New System.Drawing.Size(111, 22)
        Me.rdgTPS.TabIndex = 102
        '
        'rdgDescontoAcrescimo
        '
        Me.rdgDescontoAcrescimo.Location = New System.Drawing.Point(13, 91)
        Me.rdgDescontoAcrescimo.Name = "rdgDescontoAcrescimo"
        Me.rdgDescontoAcrescimo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgDescontoAcrescimo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Desconto"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Acréscimo")})
        Me.rdgDescontoAcrescimo.Size = New System.Drawing.Size(178, 22)
        Me.rdgDescontoAcrescimo.TabIndex = 101
        '
        'lblValorFrete
        '
        Me.lblValorFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorFrete.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblValorFrete.Location = New System.Drawing.Point(13, 256)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(101, 19)
        Me.lblValorFrete.TabIndex = 47
        Me.lblValorFrete.Text = "Valor Frete R$"
        '
        'lblPorcentagem
        '
        Me.lblPorcentagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentagem.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblPorcentagem.Location = New System.Drawing.Point(10, 179)
        Me.lblPorcentagem.Name = "lblPorcentagem"
        Me.lblPorcentagem.Size = New System.Drawing.Size(113, 19)
        Me.lblPorcentagem.TabIndex = 45
        Me.lblPorcentagem.Text = "Porcentagem %"
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblValor.Location = New System.Drawing.Point(13, 119)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(61, 19)
        Me.lblValor.TabIndex = 43
        Me.lblValor.Text = "Valor R$"
        '
        'lblTotalDesconto
        '
        Me.lblTotalDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalDesconto.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTotalDesconto.Location = New System.Drawing.Point(10, 31)
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        Me.lblTotalDesconto.Size = New System.Drawing.Size(130, 19)
        Me.lblTotalDesconto.TabIndex = 41
        Me.lblTotalDesconto.Text = "Total Desconto R$"
        '
        'grpObservacoes
        '
        Me.grpObservacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpObservacoes.Controls.Add(Me.memObservacoes)
        Me.grpObservacoes.Location = New System.Drawing.Point(1, 550)
        Me.grpObservacoes.Name = "grpObservacoes"
        Me.grpObservacoes.Size = New System.Drawing.Size(458, 65)
        Me.grpObservacoes.TabIndex = 6
        Me.grpObservacoes.Text = "Observações"
        '
        'memObservacoes
        '
        Me.memObservacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memObservacoes.EnterMoveNextControl = True
        Me.memObservacoes.Location = New System.Drawing.Point(-1, 23)
        Me.memObservacoes.MenuManager = Me.BarManager1
        Me.memObservacoes.Name = "memObservacoes"
        Me.memObservacoes.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.memObservacoes.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.memObservacoes.Size = New System.Drawing.Size(459, 46)
        Me.memObservacoes.TabIndex = 17
        '
        'grpDefeitosVeiculo
        '
        Me.grpDefeitosVeiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDefeitosVeiculo.Controls.Add(Me.memDefeitosVeiculo)
        Me.grpDefeitosVeiculo.Location = New System.Drawing.Point(459, 550)
        Me.grpDefeitosVeiculo.Name = "grpDefeitosVeiculo"
        Me.grpDefeitosVeiculo.Size = New System.Drawing.Size(348, 65)
        Me.grpDefeitosVeiculo.TabIndex = 7
        Me.grpDefeitosVeiculo.Text = "Defeitos do Veículo"
        '
        'memDefeitosVeiculo
        '
        Me.memDefeitosVeiculo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memDefeitosVeiculo.EnterMoveNextControl = True
        Me.memDefeitosVeiculo.Location = New System.Drawing.Point(0, 23)
        Me.memDefeitosVeiculo.MenuManager = Me.BarManager1
        Me.memDefeitosVeiculo.Name = "memDefeitosVeiculo"
        Me.memDefeitosVeiculo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.memDefeitosVeiculo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.memDefeitosVeiculo.Size = New System.Drawing.Size(348, 46)
        Me.memDefeitosVeiculo.TabIndex = 18
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.grpItens)
        Me.GroupControl1.Controls.Add(Me.rdgVendaCusto)
        Me.GroupControl1.Controls.Add(Me.cboItensTab)
        Me.GroupControl1.Controls.Add(Me.tabItensTab)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 250)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(807, 300)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Itens - Tab."
        '
        'grpItens
        '
        Me.grpItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItens.Controls.Add(Me.txtTotalServicos)
        Me.grpItens.Controls.Add(Me.txtTotalProdutos)
        Me.grpItens.Controls.Add(Me.txtTotalGeral)
        Me.grpItens.Controls.Add(Me.lblTotalGeral)
        Me.grpItens.Controls.Add(Me.lblTotalProdutos)
        Me.grpItens.Controls.Add(Me.lblTotalServicos)
        Me.grpItens.Controls.Add(Me.btnExcluirItem)
        Me.grpItens.Location = New System.Drawing.Point(2, 243)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(802, 55)
        Me.grpItens.TabIndex = 106
        Me.grpItens.Text = "N° Itens"
        '
        'txtTotalServicos
        '
        Me.txtTotalServicos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalServicos.Location = New System.Drawing.Point(200, 23)
        Me.txtTotalServicos.MenuManager = Me.BarManager1
        Me.txtTotalServicos.Name = "txtTotalServicos"
        Me.txtTotalServicos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalServicos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalServicos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalServicos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalServicos.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtTotalServicos.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalServicos.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotalServicos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalServicos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalServicos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalServicos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalServicos.Properties.ReadOnly = True
        Me.txtTotalServicos.Size = New System.Drawing.Size(196, 30)
        Me.txtTotalServicos.TabIndex = 160
        '
        'txtTotalProdutos
        '
        Me.txtTotalProdutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalProdutos.Location = New System.Drawing.Point(402, 23)
        Me.txtTotalProdutos.MenuManager = Me.BarManager1
        Me.txtTotalProdutos.Name = "txtTotalProdutos"
        Me.txtTotalProdutos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalProdutos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalProdutos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalProdutos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalProdutos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalProdutos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalProdutos.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtTotalProdutos.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalProdutos.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotalProdutos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Moccasin
        Me.txtTotalProdutos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalProdutos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalProdutos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalProdutos.Properties.ReadOnly = True
        Me.txtTotalProdutos.Size = New System.Drawing.Size(196, 30)
        Me.txtTotalProdutos.TabIndex = 159
        '
        'txtTotalGeral
        '
        Me.txtTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGeral.Location = New System.Drawing.Point(604, 23)
        Me.txtTotalGeral.MenuManager = Me.BarManager1
        Me.txtTotalGeral.Name = "txtTotalGeral"
        Me.txtTotalGeral.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalGeral.Properties.Appearance.Options.UseFont = True
        Me.txtTotalGeral.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalGeral.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalGeral.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtTotalGeral.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalGeral.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotalGeral.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotalGeral.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotalGeral.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalGeral.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalGeral.Properties.ReadOnly = True
        Me.txtTotalGeral.Size = New System.Drawing.Size(196, 30)
        Me.txtTotalGeral.TabIndex = 158
        '
        'lblTotalGeral
        '
        Me.lblTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalGeral.Location = New System.Drawing.Point(601, 2)
        Me.lblTotalGeral.Name = "lblTotalGeral"
        Me.lblTotalGeral.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalGeral.TabIndex = 110
        Me.lblTotalGeral.Text = "Total Geral R$"
        '
        'lblTotalProdutos
        '
        Me.lblTotalProdutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalProdutos.Location = New System.Drawing.Point(399, 4)
        Me.lblTotalProdutos.Name = "lblTotalProdutos"
        Me.lblTotalProdutos.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalProdutos.TabIndex = 109
        Me.lblTotalProdutos.Text = "Total Produtos R$"
        '
        'lblTotalServicos
        '
        Me.lblTotalServicos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalServicos.Location = New System.Drawing.Point(197, 2)
        Me.lblTotalServicos.Name = "lblTotalServicos"
        Me.lblTotalServicos.Size = New System.Drawing.Size(83, 13)
        Me.lblTotalServicos.TabIndex = 108
        Me.lblTotalServicos.Text = "Total Serviços R$"
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnExcluirItem.Appearance.Options.UseFont = True
        Me.btnExcluirItem.Image = Global.telausuario.My.Resources.Resources.Remove_Item
        Me.btnExcluirItem.Location = New System.Drawing.Point(5, 23)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Size = New System.Drawing.Size(138, 26)
        Me.btnExcluirItem.TabIndex = 0
        Me.btnExcluirItem.Text = "Excluir Item(ns)"
        '
        'rdgVendaCusto
        '
        Me.rdgVendaCusto.Location = New System.Drawing.Point(184, -1)
        Me.rdgVendaCusto.Name = "rdgVendaCusto"
        Me.rdgVendaCusto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgVendaCusto.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Venda"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Custo")})
        Me.rdgVendaCusto.Size = New System.Drawing.Size(173, 22)
        Me.rdgVendaCusto.TabIndex = 103
        '
        'cboItensTab
        '
        Me.cboItensTab.Location = New System.Drawing.Point(70, 1)
        Me.cboItensTab.MenuManager = Me.BarManager1
        Me.cboItensTab.Name = "cboItensTab"
        Me.cboItensTab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboItensTab.Size = New System.Drawing.Size(108, 20)
        Me.cboItensTab.TabIndex = 105
        '
        'tabItensTab
        '
        Me.tabItensTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabItensTab.Location = New System.Drawing.Point(1, 24)
        Me.tabItensTab.Name = "tabItensTab"
        Me.tabItensTab.SelectedTabPage = Me.tabPedidoAtual
        Me.tabItensTab.Size = New System.Drawing.Size(806, 220)
        Me.tabItensTab.TabIndex = 0
        Me.tabItensTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPedidoAtual, Me.tabUltimoPedido, Me.tabTodosPedido})
        '
        'tabPedidoAtual
        '
        Me.tabPedidoAtual.Controls.Add(Me.grdPedidoAtual)
        Me.tabPedidoAtual.Name = "tabPedidoAtual"
        Me.tabPedidoAtual.Size = New System.Drawing.Size(800, 192)
        Me.tabPedidoAtual.Text = "Pedido Atual"
        '
        'grdPedidoAtual
        '
        Me.grdPedidoAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoAtual.DataMember = "tbPedidoAtual"
        Me.grdPedidoAtual.DataSource = Me.dsPedidoAtual
        Me.grdPedidoAtual.Location = New System.Drawing.Point(-1, 0)
        Me.grdPedidoAtual.MainView = Me.grd1
        Me.grdPedidoAtual.MenuManager = Me.BarManager1
        Me.grdPedidoAtual.Name = "grdPedidoAtual"
        Me.grdPedidoAtual.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdPedidoAtual.Size = New System.Drawing.Size(801, 194)
        Me.grdPedidoAtual.TabIndex = 0
        Me.grdPedidoAtual.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsPedidoAtual
        '
        Me.dsPedidoAtual.DataSetName = "dsPedidoAtual"
        Me.dsPedidoAtual.Tables.AddRange(New System.Data.DataTable() {Me.tbPedidoAtual})
        '
        'tbPedidoAtual
        '
        Me.tbPedidoAtual.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn7, Me.Tipo, Me.CodProd, Me.DescComDistribuicao, Me.DescSemDistribuicao, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.tbPedidoAtual.TableName = "tbPedidoAtual"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Produto"
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Qtde"
        Me.DataColumn2.ColumnName = "Qtde"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "CodFor"
        Me.DataColumn3.ColumnName = "CodFor"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "SemDesc"
        Me.DataColumn4.ColumnName = "SemDesc"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "CodigoInterno"
        Me.DataColumn5.ColumnName = "CodigoInterno"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Um"
        Me.DataColumn6.ColumnName = "Um"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Excluir"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Aut"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ValorTotal"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorUnitario"
        '
        'Tipo
        '
        Me.Tipo.Caption = "Tipo"
        Me.Tipo.ColumnName = "Tipo"
        '
        'CodProd
        '
        Me.CodProd.ColumnName = "CodProd"
        '
        'DescComDistribuicao
        '
        Me.DescComDistribuicao.Caption = "DescComDistribuicao"
        Me.DescComDistribuicao.ColumnName = "DescComDistribuicao"
        '
        'DescSemDistribuicao
        '
        Me.DescSemDistribuicao.ColumnName = "DescSemDistribuicao"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "CodPedAut"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Custo"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "CodOrdens"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colQtde, Me.colCodFor, Me.colSemDesc, Me.colCodigoInterno, Me.colUm, Me.colExcluir, Me.colAut, Me.colValorUnitario, Me.colValorTotal, Me.colTipo, Me.colCodProd, Me.colDescComDistribuicao, Me.colDescSemDistribuicao, Me.colCodPedAut, Me.colCusto, Me.colCodOrdens})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colTipo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "VENDA"
        StyleFormatCondition1.Value2 = ""
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colTipo
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "SERVIÇO"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.grdPedidoAtual
        Me.grd1.Name = "grd1"
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProduto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colProduto.ColumnEdit = Me.txtAlterarGrid
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 0
        '
        'txtAlterarGrid
        '
        Me.txtAlterarGrid.AutoHeight = False
        Me.txtAlterarGrid.Name = "txtAlterarGrid"
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtde.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colQtde.ColumnEdit = Me.txtAlterarGrid
        Me.colQtde.FieldName = "Qtde"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.OptionsColumn.ReadOnly = True
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 1
        '
        'colCodFor
        '
        Me.colCodFor.AppearanceCell.Options.UseTextOptions = True
        Me.colCodFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodFor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodFor.ColumnEdit = Me.txtAlterarGrid
        Me.colCodFor.FieldName = "CodFor"
        Me.colCodFor.Name = "colCodFor"
        Me.colCodFor.OptionsColumn.ReadOnly = True
        '
        'colSemDesc
        '
        Me.colSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSemDesc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSemDesc.ColumnEdit = Me.txtAlterarGrid
        Me.colSemDesc.FieldName = "SemDesc"
        Me.colSemDesc.Name = "colSemDesc"
        Me.colSemDesc.OptionsColumn.ReadOnly = True
        Me.colSemDesc.Visible = True
        Me.colSemDesc.VisibleIndex = 2
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
        '
        'colUm
        '
        Me.colUm.AppearanceCell.Options.UseTextOptions = True
        Me.colUm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colUm.ColumnEdit = Me.txtAlterarGrid
        Me.colUm.FieldName = "Um"
        Me.colUm.Name = "colUm"
        Me.colUm.OptionsColumn.ReadOnly = True
        '
        'colExcluir
        '
        Me.colExcluir.AppearanceCell.Options.UseTextOptions = True
        Me.colExcluir.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExcluir.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colExcluir.ColumnEdit = Me.txtAlterarGrid
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.OptionsColumn.ReadOnly = True
        '
        'colAut
        '
        Me.colAut.AppearanceCell.Options.UseTextOptions = True
        Me.colAut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAut.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colAut.ColumnEdit = Me.txtAlterarGrid
        Me.colAut.FieldName = "Aut"
        Me.colAut.Name = "colAut"
        Me.colAut.OptionsColumn.ReadOnly = True
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorUnitario.ColumnEdit = Me.txtAlterarGrid
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 3
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colValorTotal.ColumnEdit = Me.txtAlterarGrid
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 4
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colDescComDistribuicao
        '
        Me.colDescComDistribuicao.AppearanceCell.Options.UseTextOptions = True
        Me.colDescComDistribuicao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDescComDistribuicao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDescComDistribuicao.FieldName = "DescComDistribuicao"
        Me.colDescComDistribuicao.Name = "colDescComDistribuicao"
        Me.colDescComDistribuicao.OptionsColumn.ReadOnly = True
        Me.colDescComDistribuicao.Visible = True
        Me.colDescComDistribuicao.VisibleIndex = 5
        '
        'colDescSemDistribuicao
        '
        Me.colDescSemDistribuicao.AppearanceCell.Options.UseTextOptions = True
        Me.colDescSemDistribuicao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDescSemDistribuicao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDescSemDistribuicao.FieldName = "DescSemDistribuicao"
        Me.colDescSemDistribuicao.Name = "colDescSemDistribuicao"
        Me.colDescSemDistribuicao.OptionsColumn.ReadOnly = True
        Me.colDescSemDistribuicao.Visible = True
        Me.colDescSemDistribuicao.VisibleIndex = 6
        '
        'colCodPedAut
        '
        Me.colCodPedAut.FieldName = "CodPedAut"
        Me.colCodPedAut.Name = "colCodPedAut"
        Me.colCodPedAut.OptionsColumn.ReadOnly = True
        '
        'colCusto
        '
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        '
        'colCodOrdens
        '
        Me.colCodOrdens.FieldName = "CodOrdens"
        Me.colCodOrdens.Name = "colCodOrdens"
        Me.colCodOrdens.OptionsColumn.ReadOnly = True
        '
        'tabUltimoPedido
        '
        Me.tabUltimoPedido.Controls.Add(Me.grdUltimoPedido)
        Me.tabUltimoPedido.Name = "tabUltimoPedido"
        Me.tabUltimoPedido.Size = New System.Drawing.Size(800, 192)
        Me.tabUltimoPedido.Text = "Último Pedido"
        '
        'grdUltimoPedido
        '
        Me.grdUltimoPedido.DataMember = "tbUltimoPedido"
        Me.grdUltimoPedido.DataSource = Me.dsUltimoPedido
        Me.grdUltimoPedido.Location = New System.Drawing.Point(-2, 0)
        Me.grdUltimoPedido.MainView = Me.grd2
        Me.grdUltimoPedido.MenuManager = Me.BarManager1
        Me.grdUltimoPedido.Name = "grdUltimoPedido"
        Me.grdUltimoPedido.Size = New System.Drawing.Size(804, 192)
        Me.grdUltimoPedido.TabIndex = 0
        Me.grdUltimoPedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'dsUltimoPedido
        '
        Me.dsUltimoPedido.DataSetName = "NewDataSet"
        Me.dsUltimoPedido.Tables.AddRange(New System.Data.DataTable() {Me.tbUltimoPedido})
        '
        'tbUltimoPedido
        '
        Me.tbUltimoPedido.Columns.AddRange(New System.Data.DataColumn() {Me.ValorTotal, Me.ValorUnit, Me.SemDesc, Me.Qtde, Me.Produto, Me.CodigoInterno, Me.CodPed})
        Me.tbUltimoPedido.TableName = "tbUltimoPedido"
        '
        'ValorTotal
        '
        Me.ValorTotal.ColumnName = "ValorTotal"
        '
        'ValorUnit
        '
        Me.ValorUnit.ColumnName = "ValorUnit"
        '
        'SemDesc
        '
        Me.SemDesc.ColumnName = "SemDesc"
        '
        'Qtde
        '
        Me.Qtde.ColumnName = "Qtde"
        '
        'Produto
        '
        Me.Produto.ColumnName = "Produto"
        '
        'CodigoInterno
        '
        Me.CodigoInterno.ColumnName = "CodigoInterno"
        '
        'CodPed
        '
        Me.CodPed.ColumnName = "CodPed"
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colValorTotal1, Me.colValorUnit, Me.colSemDesc1, Me.colQtde1, Me.colProduto1, Me.colCodigoInterno1, Me.colCodPed})
        Me.grd2.GridControl = Me.grdUltimoPedido
        Me.grd2.Name = "grd2"
        '
        'colValorTotal1
        '
        Me.colValorTotal1.FieldName = "ValorTotal"
        Me.colValorTotal1.Name = "colValorTotal1"
        Me.colValorTotal1.Visible = True
        Me.colValorTotal1.VisibleIndex = 0
        '
        'colValorUnit
        '
        Me.colValorUnit.FieldName = "ValorUnit"
        Me.colValorUnit.Name = "colValorUnit"
        Me.colValorUnit.Visible = True
        Me.colValorUnit.VisibleIndex = 1
        '
        'colSemDesc1
        '
        Me.colSemDesc1.FieldName = "SemDesc"
        Me.colSemDesc1.Name = "colSemDesc1"
        Me.colSemDesc1.Visible = True
        Me.colSemDesc1.VisibleIndex = 2
        '
        'colQtde1
        '
        Me.colQtde1.FieldName = "Qtde"
        Me.colQtde1.Name = "colQtde1"
        Me.colQtde1.Visible = True
        Me.colQtde1.VisibleIndex = 3
        '
        'colProduto1
        '
        Me.colProduto1.FieldName = "Produto"
        Me.colProduto1.Name = "colProduto1"
        Me.colProduto1.Visible = True
        Me.colProduto1.VisibleIndex = 4
        '
        'colCodigoInterno1
        '
        Me.colCodigoInterno1.FieldName = "CodigoInterno"
        Me.colCodigoInterno1.Name = "colCodigoInterno1"
        Me.colCodigoInterno1.Visible = True
        Me.colCodigoInterno1.VisibleIndex = 5
        '
        'colCodPed
        '
        Me.colCodPed.FieldName = "CodPed"
        Me.colCodPed.Name = "colCodPed"
        Me.colCodPed.Visible = True
        Me.colCodPed.VisibleIndex = 6
        '
        'tabTodosPedido
        '
        Me.tabTodosPedido.Controls.Add(Me.grdTodosPedidos)
        Me.tabTodosPedido.Name = "tabTodosPedido"
        Me.tabTodosPedido.Size = New System.Drawing.Size(800, 192)
        Me.tabTodosPedido.Text = "Todos Pedidos"
        '
        'grdTodosPedidos
        '
        Me.grdTodosPedidos.DataMember = "tbTodosPedidos"
        Me.grdTodosPedidos.DataSource = Me.dtTodosPedidos
        Me.grdTodosPedidos.Location = New System.Drawing.Point(-2, 0)
        Me.grdTodosPedidos.MainView = Me.grd3
        Me.grdTodosPedidos.MenuManager = Me.BarManager1
        Me.grdTodosPedidos.Name = "grdTodosPedidos"
        Me.grdTodosPedidos.Size = New System.Drawing.Size(802, 192)
        Me.grdTodosPedidos.TabIndex = 0
        Me.grdTodosPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'dtTodosPedidos
        '
        Me.dtTodosPedidos.DataSetName = "NewDataSet"
        Me.dtTodosPedidos.Tables.AddRange(New System.Data.DataTable() {Me.tbTodosPedidos})
        '
        'tbTodosPedidos
        '
        Me.tbTodosPedidos.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17})
        Me.tbTodosPedidos.TableName = "tbTodosPedidos"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodigoInterno"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CodPed"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Produto"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Qtde"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SemDesc"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ValorUnit"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ValorTotal"
        '
        'grd3
        '
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoInterno2, Me.colCodPed1, Me.colProduto2, Me.colQtde2, Me.colSemDesc2, Me.colValorUnit1, Me.colValorTotal2})
        Me.grd3.GridControl = Me.grdTodosPedidos
        Me.grd3.Name = "grd3"
        '
        'colCodigoInterno2
        '
        Me.colCodigoInterno2.FieldName = "CodigoInterno"
        Me.colCodigoInterno2.Name = "colCodigoInterno2"
        Me.colCodigoInterno2.Visible = True
        Me.colCodigoInterno2.VisibleIndex = 0
        '
        'colCodPed1
        '
        Me.colCodPed1.FieldName = "CodPed"
        Me.colCodPed1.Name = "colCodPed1"
        Me.colCodPed1.Visible = True
        Me.colCodPed1.VisibleIndex = 1
        '
        'colProduto2
        '
        Me.colProduto2.FieldName = "Produto"
        Me.colProduto2.Name = "colProduto2"
        Me.colProduto2.Visible = True
        Me.colProduto2.VisibleIndex = 2
        '
        'colQtde2
        '
        Me.colQtde2.FieldName = "Qtde"
        Me.colQtde2.Name = "colQtde2"
        Me.colQtde2.Visible = True
        Me.colQtde2.VisibleIndex = 3
        '
        'colSemDesc2
        '
        Me.colSemDesc2.FieldName = "SemDesc"
        Me.colSemDesc2.Name = "colSemDesc2"
        Me.colSemDesc2.Visible = True
        Me.colSemDesc2.VisibleIndex = 4
        '
        'colValorUnit1
        '
        Me.colValorUnit1.FieldName = "ValorUnit"
        Me.colValorUnit1.Name = "colValorUnit1"
        Me.colValorUnit1.Visible = True
        Me.colValorUnit1.VisibleIndex = 5
        '
        'colValorTotal2
        '
        Me.colValorTotal2.FieldName = "ValorTotal"
        Me.colValorTotal2.Name = "colValorTotal2"
        Me.colValorTotal2.Visible = True
        Me.colValorTotal2.VisibleIndex = 6
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 0
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1008, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 661)
        Me.BarDockControl2.Size = New System.Drawing.Size(1008, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 661)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1008, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 661)
        '
        'frmCadPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grpDefeitosVeiculo)
        Me.Controls.Add(Me.grpObservacoes)
        Me.Controls.Add(Me.grpDescontoAcrescimo)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.KeyPreview = True
        Me.Name = "frmCadPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pedido"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.btnOrdem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNossoStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatusNano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabClientesProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClientesProdutos.ResumeLayout(False)
        Me.tabProdutos.ResumeLayout(False)
        CType(Me.tabAddRemover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddRemover.ResumeLayout(False)
        Me.tabRemoverProdutos.ResumeLayout(False)
        Me.tabRemoverProdutos.PerformLayout()
        CType(Me.btnRemoverPesquisarGrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemoverQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemoverProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRemoverCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddProdutos.ResumeLayout(False)
        Me.tabAddProdutos.PerformLayout()
        CType(Me.txtPreco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddPesquisarProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddCodigoInterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescontoPorc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstoque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgPS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCliente.ResumeLayout(False)
        CType(Me.tabDadosHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDadosHistorico.ResumeLayout(False)
        Me.tabDados.ResumeLayout(False)
        Me.tabDados.PerformLayout()
        CType(Me.dtDataSaida.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDataSaida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDataEntrada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDataEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPesquisarNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKmSaida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKmEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDadosVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivelComb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistorico.ResumeLayout(False)
        Me.tabHistorico.PerformLayout()
        CType(Me.txtNCompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimiteUsado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimiteCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimiteAtual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUltimaVisita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataCadastro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDescontoAcrescimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescontoAcrescimo.ResumeLayout(False)
        Me.grpDescontoAcrescimo.PerformLayout()
        CType(Me.txtValorFrete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDistribuido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTPS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDescontoAcrescimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpObservacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObservacoes.ResumeLayout(False)
        CType(Me.memObservacoes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDefeitosVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDefeitosVeiculo.ResumeLayout(False)
        CType(Me.memDefeitosVeiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        Me.grpItens.PerformLayout()
        CType(Me.txtTotalServicos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalProdutos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalGeral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgVendaCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItensTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabItensTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabItensTab.ResumeLayout(False)
        Me.tabPedidoAtual.ResumeLayout(False)
        CType(Me.grdPedidoAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPedidoAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPedidoAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUltimoPedido.ResumeLayout(False)
        CType(Me.grdUltimoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsUltimoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUltimoPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTodosPedido.ResumeLayout(False)
        CType(Me.grdTodosPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTodosPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTodosPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnPromissoria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompromisso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEntrada As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btF3Salvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpDescontoAcrescimo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnYoutube As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNossoStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblNossoStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboStatusNano As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblStatusNano As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboVendedor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblVendedor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabClientesProdutos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCliente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDadosHistorico As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabHistorico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabProdutos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblValorFrete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorcentagem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalDesconto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgTPS As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rdgDescontoAcrescimo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdgVendaCusto As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cboItensTab As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tabItensTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPedidoAtual As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabUltimoPedido As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTodosPedido As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grpDefeitosVeiculo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents memDefeitosVeiculo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents grpObservacoes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents memObservacoes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblTotalGeral As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalProdutos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalServicos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExcluirItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDescontoAcrescimo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents tabAddRemover As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabAddProdutos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblProduto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescontoPorc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesconto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMecanico As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmPedido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmEstoque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgPS As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tabRemoverProdutos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAdicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkCusto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCusto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblQtd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPreco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRQtd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRProduto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkRemoverCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblRCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIgual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMais As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnVendas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsumo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCredDev As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNCompras As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLimiteCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLimiteUsado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLimiteAtual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDiasAtraso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUltimaVisita As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDataCadastro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTotalServicos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalProdutos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalGeral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorFrete As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorcentagem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorDistribuido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabDados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNivelComb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCpfCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKmSaida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKmEntrada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMotor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCelular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblDadosVeiculo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlDadosVeiculo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblKmSaida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblKmEntrada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDataSaida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDataEntrada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMotor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCelular As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTelefone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCpfCnpj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNivelComb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblModelo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPlaca As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNCompras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCredDev As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLimiteUsado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLimiteCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLimiteAtual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUltimaVisita As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiasAtraso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDataCadastro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddQtd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddProduto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescontoPorc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEstoque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemoverQtd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemoverProduto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPesquisarNome As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAddPesquisarProduto As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtAddCodigoInterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRemoverPesquisarGrid As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtRemoverCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dsPedidoAtual As System.Data.DataSet
    Friend WithEvents tbPedidoAtual As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Private WithEvents grdPedidoAtual As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPreco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Tipo As System.Data.DataColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CodProd As System.Data.DataColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescComDistribuicao As System.Data.DataColumn
    Friend WithEvents DescSemDistribuicao As System.Data.DataColumn
    Friend WithEvents colDescComDistribuicao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescSemDistribuicao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdUltimoPedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsUltimoPedido As System.Data.DataSet
    Friend WithEvents tbUltimoPedido As System.Data.DataTable
    Friend WithEvents ValorTotal As System.Data.DataColumn
    Friend WithEvents ValorUnit As System.Data.DataColumn
    Friend WithEvents SemDesc As System.Data.DataColumn
    Friend WithEvents Qtde As System.Data.DataColumn
    Friend WithEvents Produto As System.Data.DataColumn
    Friend WithEvents CodigoInterno As System.Data.DataColumn
    Friend WithEvents CodPed As System.Data.DataColumn
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colValorTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSemDesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdTodosPedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtTodosPedidos As System.Data.DataSet
    Friend WithEvents tbTodosPedidos As System.Data.DataTable
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoInterno2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSemDesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnOrdem As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtOrdem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOrdem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents colCodPedAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents colCodOrdens As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtDataSaida As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtDataEntrada As DevExpress.XtraEditors.DateEdit
End Class
