<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnExclui = New DevExpress.XtraBars.BarButtonItem()
        Me.lblModelo = New DevExpress.XtraBars.BarStaticItem()
        Me.cboModelo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiquetas = New DevExpress.XtraBars.BarButtonItem()
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
        Me.RepositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.RepositoryItemFontEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.grpRodapeClientesCadastrados = New DevExpress.XtraEditors.GroupControl()
        Me.cboAniverMes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblClientesCadastrados = New DevExpress.XtraEditors.LabelControl()
        Me.txtClientesCadastrados = New DevExpress.XtraEditors.TextEdit()
        Me.lblAniverMes = New DevExpress.XtraEditors.LabelControl()
        Me.pnlDesign3 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlDesign2 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlDesign1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnVisualizar2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFIltrar = New DevExpress.XtraEditors.SimpleButton()
        Me.grpClientecadastro = New DevExpress.XtraEditors.GroupControl()
        Me.grdClientesCad = New DevExpress.XtraGrid.GridControl()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTelaUsuario = New telausuario.dsTelaUsuario()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRGIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCelular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservacao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabGeral = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPrincipal = New DevExpress.XtraTab.XtraTabPage()
        Me.btnPesquisarCpfCnpj = New DevExpress.XtraEditors.SimpleButton()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblSexo = New DevExpress.XtraEditors.LabelControl()
        Me.cboSexo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtNascim = New DevExpress.XtraEditors.DateEdit()
        Me.grpObservacoes = New DevExpress.XtraEditors.GroupControl()
        Me.chkInativo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPendencia = New DevExpress.XtraEditors.CheckEdit()
        Me.memObservacoes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.txtContato = New DevExpress.XtraEditors.TextEdit()
        Me.lblContato = New DevExpress.XtraEditors.LabelControl()
        Me.lblTelefone3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefone3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefone2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblTelefone2 = New DevExpress.XtraEditors.LabelControl()
        Me.rdgCpfCnpj = New DevExpress.XtraEditors.RadioGroup()
        Me.lblTelefone1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefone1 = New DevExpress.XtraEditors.TextEdit()
        Me.tabEndereco = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCliente = New DevExpress.XtraTab.XtraTabPage()
        Me.btnBuscaCep = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddFrete = New DevExpress.XtraEditors.SimpleButton()
        Me.cboClienteBairro = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboClienteCidade = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboClienteUf = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblClienteBairro = New DevExpress.XtraEditors.LabelControl()
        Me.lblClienteCidade = New DevExpress.XtraEditors.LabelControl()
        Me.lblClienteUf = New DevExpress.XtraEditors.LabelControl()
        Me.lblClienteComp = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteComp = New DevExpress.XtraEditors.TextEdit()
        Me.lblClienteEndereco = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteEndereco = New DevExpress.XtraEditors.TextEdit()
        Me.lblClienteNum = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteNum = New DevExpress.XtraEditors.TextEdit()
        Me.lblClienteCep = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteCep = New DevExpress.XtraEditors.TextEdit()
        Me.tabEnderecoEntrega = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCpfCnpj = New DevExpress.XtraEditors.TextEdit()
        Me.lblRgIe = New DevExpress.XtraEditors.LabelControl()
        Me.txtRgIe = New DevExpress.XtraEditors.TextEdit()
        Me.lblNascim = New DevExpress.XtraEditors.LabelControl()
        Me.lblFantasia = New DevExpress.XtraEditors.LabelControl()
        Me.txtFantasia = New DevExpress.XtraEditors.TextEdit()
        Me.lblNomeRazao = New DevExpress.XtraEditors.LabelControl()
        Me.txtNomeRazao = New DevExpress.XtraEditors.TextEdit()
        Me.tabComplementos = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExcluirCredDev = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsumo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVendas = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDiasAtraso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLimCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSaldoDevedor = New DevExpress.XtraEditors.TextEdit()
        Me.lblultVisita = New DevExpress.XtraEditors.LabelControl()
        Me.txtUltVisita = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLimAtual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCompras = New DevExpress.XtraEditors.TextEdit()
        Me.lblCadastro = New DevExpress.XtraEditors.LabelControl()
        Me.txtCadastro = New DevExpress.XtraEditors.TextEdit()
        Me.dtDataFatura = New DevExpress.XtraEditors.DateEdit()
        Me.lblMoradia = New DevExpress.XtraEditors.LabelControl()
        Me.cboMoradia = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit36 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit37 = New DevExpress.XtraEditors.TextEdit()
        Me.lblBancoContaCorrente = New DevExpress.XtraEditors.LabelControl()
        Me.txtContaCorrente = New DevExpress.XtraEditors.TextEdit()
        Me.lblBancoBanco = New DevExpress.XtraEditors.LabelControl()
        Me.txtBanco = New DevExpress.XtraEditors.TextEdit()
        Me.lblBancoAgencia = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgencia = New DevExpress.XtraEditors.TextEdit()
        Me.lblConjugeNome = New DevExpress.XtraEditors.LabelControl()
        Me.txtConjugeNome = New DevExpress.XtraEditors.TextEdit()
        Me.lblConjugeTelefone = New DevExpress.XtraEditors.LabelControl()
        Me.txtConjugeTelefone = New DevExpress.XtraEditors.TextEdit()
        Me.lblAutorizadasNome2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizadasNome2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblAutorizadasRg2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizadasRg2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblAutorizadasRg1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizadasRg1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblAutorizadasNome1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAutorizadasNome1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblTelefone = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefone = New DevExpress.XtraEditors.TextEdit()
        Me.lblTempTrab = New DevExpress.XtraEditors.LabelControl()
        Me.txtTempTrab = New DevExpress.XtraEditors.TextEdit()
        Me.lblFaixaSalarial = New DevExpress.XtraEditors.LabelControl()
        Me.txtFaixaSalarial = New DevExpress.XtraEditors.TextEdit()
        Me.lblEmpresa = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.tabNfe = New DevExpress.XtraTab.XtraTabPage()
        Me.cboPais = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.rdgIssRetido = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIm = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSuframa = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodPais = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.tabClientes = New DevExpress.XtraTab.XtraTabControl()
        Me.PrintBarManager1 = New DevExpress.XtraPrinting.Preview.PrintBarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager3 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl12 = New DevExpress.XtraBars.BarDockControl()
        Me.ClienteTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.ClienteTableAdapter()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.grpRodapeClientesCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRodapeClientesCadastrados.SuspendLayout()
        CType(Me.cboAniverMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClientesCadastrados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDesign3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDesign2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDesign1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpClientecadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClientecadastro.SuspendLayout()
        CType(Me.grdClientesCad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGeral.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNascim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNascim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpObservacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObservacoes.SuspendLayout()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPendencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memObservacoes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEndereco.SuspendLayout()
        Me.tabCliente.SuspendLayout()
        CType(Me.cboClienteBairro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteUf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteEndereco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRgIe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFantasia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeRazao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabComplementos.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoDevedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUltVisita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimAtual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCompras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCadastro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDataFatura.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDataFatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoradia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit36.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit37.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConjugeNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConjugeTelefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizadasNome2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizadasRg2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizadasRg1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizadasNome1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTempTrab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaixaSalarial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNfe.SuspendLayout()
        CType(Me.cboPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgIssRetido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuframa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClientes.SuspendLayout()
        CType(Me.PrintBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExclui, Me.btnAdd, Me.btnEtiquetas, Me.btnVisualizar, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar, Me.cboModelo, Me.lblModelo})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemFontEdit1, Me.RepositoryItemFontEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.FloatSize = New System.Drawing.Size(50, 0)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExclui, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.lblModelo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.cboModelo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEtiquetas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExclui
        '
        Me.btnExclui.Caption = "Excluir"
        Me.btnExclui.Glyph = CType(resources.GetObject("btnExclui.Glyph"), System.Drawing.Image)
        Me.btnExclui.Id = 0
        Me.btnExclui.Name = "btnExclui"
        '
        'lblModelo
        '
        Me.lblModelo.Caption = "Modelo"
        Me.lblModelo.Id = 14
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'cboModelo
        '
        Me.cboModelo.Caption = "BarEditItem1"
        Me.cboModelo.Edit = Me.RepositoryItemComboBox1
        Me.cboModelo.Id = 11
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Width = 157
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'btnAdd
        '
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 2
        Me.btnAdd.Name = "btnAdd"
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.Caption = "Etiquetas"
        Me.btnEtiquetas.Glyph = CType(resources.GetObject("btnEtiquetas.Glyph"), System.Drawing.Image)
        Me.btnEtiquetas.Id = 3
        Me.btnEtiquetas.Name = "btnEtiquetas"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "Visualizar"
        Me.btnVisualizar.Glyph = CType(resources.GetObject("btnVisualizar.Glyph"), System.Drawing.Image)
        Me.btnVisualizar.Id = 4
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = CType(resources.GetObject("btnSalvar.Glyph"), System.Drawing.Image)
        Me.btnSalvar.Id = 5
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Caption = "Alterar"
        Me.btnAlterar.Glyph = CType(resources.GetObject("btnAlterar.Glyph"), System.Drawing.Image)
        Me.btnAlterar.Id = 6
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = CType(resources.GetObject("btnLimpar.Glyph"), System.Drawing.Image)
        Me.btnLimpar.Id = 7
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = CType(resources.GetObject("btnFechar.Glyph"), System.Drawing.Image)
        Me.btnFechar.Id = 8
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1014, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 620)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1014, 41)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 620)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1014, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 620)
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
        'RepositoryItemFontEdit1
        '
        Me.RepositoryItemFontEdit1.AutoHeight = False
        Me.RepositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemFontEdit1.Name = "RepositoryItemFontEdit1"
        '
        'RepositoryItemFontEdit2
        '
        Me.RepositoryItemFontEdit2.AutoHeight = False
        Me.RepositoryItemFontEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemFontEdit2.Name = "RepositoryItemFontEdit2"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.grpRodapeClientesCadastrados)
        Me.XtraTabPage1.Controls.Add(Me.grpClientecadastro)
        Me.XtraTabPage1.Controls.Add(Me.tabGeral)
        Me.XtraTabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1008, 593)
        Me.XtraTabPage1.Text = "Cliente"
        '
        'grpRodapeClientesCadastrados
        '
        Me.grpRodapeClientesCadastrados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRodapeClientesCadastrados.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.grpRodapeClientesCadastrados.AppearanceCaption.Options.UseFont = True
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.cboAniverMes)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.lblClientesCadastrados)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.txtClientesCadastrados)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.lblAniverMes)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.pnlDesign3)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.pnlDesign2)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.pnlDesign1)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.btnVisualizar2)
        Me.grpRodapeClientesCadastrados.Controls.Add(Me.btnFIltrar)
        Me.grpRodapeClientesCadastrados.Location = New System.Drawing.Point(0, 550)
        Me.grpRodapeClientesCadastrados.Name = "grpRodapeClientesCadastrados"
        Me.grpRodapeClientesCadastrados.Size = New System.Drawing.Size(1008, 43)
        Me.grpRodapeClientesCadastrados.TabIndex = 77
        '
        'cboAniverMes
        '
        Me.cboAniverMes.Location = New System.Drawing.Point(131, 13)
        Me.cboAniverMes.MenuManager = Me.BarManager1
        Me.cboAniverMes.Name = "cboAniverMes"
        Me.cboAniverMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAniverMes.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboAniverMes.Properties.Items.AddRange(New Object() {"", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cboAniverMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAniverMes.Size = New System.Drawing.Size(184, 20)
        Me.cboAniverMes.TabIndex = 23
        '
        'lblClientesCadastrados
        '
        Me.lblClientesCadastrados.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblClientesCadastrados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClientesCadastrados.Location = New System.Drawing.Point(728, 16)
        Me.lblClientesCadastrados.Name = "lblClientesCadastrados"
        Me.lblClientesCadastrados.Size = New System.Drawing.Size(119, 13)
        Me.lblClientesCadastrados.TabIndex = 81
        Me.lblClientesCadastrados.Text = "Clientes Cadastrados"
        '
        'txtClientesCadastrados
        '
        Me.txtClientesCadastrados.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtClientesCadastrados.Enabled = False
        Me.txtClientesCadastrados.Location = New System.Drawing.Point(853, 7)
        Me.txtClientesCadastrados.Name = "txtClientesCadastrados"
        Me.txtClientesCadastrados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txtClientesCadastrados.Properties.Appearance.Options.UseFont = True
        Me.txtClientesCadastrados.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtClientesCadastrados.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtClientesCadastrados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtClientesCadastrados.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClientesCadastrados.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtClientesCadastrados.Properties.ReadOnly = True
        Me.txtClientesCadastrados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtClientesCadastrados.Size = New System.Drawing.Size(147, 28)
        Me.txtClientesCadastrados.TabIndex = 80
        '
        'lblAniverMes
        '
        Me.lblAniverMes.Location = New System.Drawing.Point(13, 16)
        Me.lblAniverMes.Name = "lblAniverMes"
        Me.lblAniverMes.Size = New System.Drawing.Size(112, 13)
        Me.lblAniverMes.TabIndex = 57
        Me.lblAniverMes.Text = "Aniversariantes do mês"
        '
        'pnlDesign3
        '
        Me.pnlDesign3.Appearance.BackColor = System.Drawing.Color.Black
        Me.pnlDesign3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pnlDesign3.Appearance.Options.UseBackColor = True
        Me.pnlDesign3.Appearance.Options.UseFont = True
        Me.pnlDesign3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pnlDesign3.Location = New System.Drawing.Point(510, 10)
        Me.pnlDesign3.Name = "pnlDesign3"
        Me.pnlDesign3.Size = New System.Drawing.Size(2, 27)
        Me.pnlDesign3.TabIndex = 6
        '
        'pnlDesign2
        '
        Me.pnlDesign2.Appearance.BackColor = System.Drawing.Color.Black
        Me.pnlDesign2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pnlDesign2.Appearance.Options.UseBackColor = True
        Me.pnlDesign2.Appearance.Options.UseFont = True
        Me.pnlDesign2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pnlDesign2.Location = New System.Drawing.Point(410, 10)
        Me.pnlDesign2.Name = "pnlDesign2"
        Me.pnlDesign2.Size = New System.Drawing.Size(2, 27)
        Me.pnlDesign2.TabIndex = 5
        '
        'pnlDesign1
        '
        Me.pnlDesign1.Appearance.BackColor = System.Drawing.Color.Black
        Me.pnlDesign1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.pnlDesign1.Appearance.Options.UseBackColor = True
        Me.pnlDesign1.Appearance.Options.UseFont = True
        Me.pnlDesign1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.pnlDesign1.Location = New System.Drawing.Point(329, 10)
        Me.pnlDesign1.Name = "pnlDesign1"
        Me.pnlDesign1.Size = New System.Drawing.Size(2, 27)
        Me.pnlDesign1.TabIndex = 4
        '
        'btnVisualizar2
        '
        Me.btnVisualizar2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnVisualizar2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVisualizar2.Appearance.Options.UseBackColor = True
        Me.btnVisualizar2.Appearance.Options.UseFont = True
        Me.btnVisualizar2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnVisualizar2.Image = CType(resources.GetObject("btnVisualizar2.Image"), System.Drawing.Image)
        Me.btnVisualizar2.Location = New System.Drawing.Point(410, 10)
        Me.btnVisualizar2.Name = "btnVisualizar2"
        Me.btnVisualizar2.Size = New System.Drawing.Size(102, 23)
        Me.btnVisualizar2.TabIndex = 1
        Me.btnVisualizar2.Text = "Visualizar"
        '
        'btnFIltrar
        '
        Me.btnFIltrar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnFIltrar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFIltrar.Appearance.Options.UseBackColor = True
        Me.btnFIltrar.Appearance.Options.UseFont = True
        Me.btnFIltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFIltrar.Image = CType(resources.GetObject("btnFIltrar.Image"), System.Drawing.Image)
        Me.btnFIltrar.Location = New System.Drawing.Point(329, 10)
        Me.btnFIltrar.Name = "btnFIltrar"
        Me.btnFIltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFIltrar.TabIndex = 0
        Me.btnFIltrar.Text = "Filtrar"
        '
        'grpClientecadastro
        '
        Me.grpClientecadastro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClientecadastro.Appearance.BackColor = System.Drawing.Color.White
        Me.grpClientecadastro.Appearance.Options.UseBackColor = True
        Me.grpClientecadastro.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpClientecadastro.AppearanceCaption.Options.UseFont = True
        Me.grpClientecadastro.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grpClientecadastro.Controls.Add(Me.grdClientesCad)
        Me.grpClientecadastro.Location = New System.Drawing.Point(1, 330)
        Me.grpClientecadastro.Name = "grpClientecadastro"
        Me.grpClientecadastro.Size = New System.Drawing.Size(1004, 230)
        Me.grpClientecadastro.TabIndex = 76
        Me.grpClientecadastro.Text = "Clientes Cadastrados"
        '
        'grdClientesCad
        '
        Me.grdClientesCad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClientesCad.DataSource = Me.ClienteBindingSource
        Me.grdClientesCad.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        GridLevelNode2.RelationName = "Level1"
        Me.grdClientesCad.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.grdClientesCad.Location = New System.Drawing.Point(2, 24)
        Me.grdClientesCad.MainView = Me.grd1
        Me.grdClientesCad.MenuManager = Me.BarManager1
        Me.grdClientesCad.Name = "grdClientesCad"
        Me.grdClientesCad.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.AlterarGrid})
        Me.grdClientesCad.Size = New System.Drawing.Size(1002, 197)
        Me.grdClientesCad.TabIndex = 78
        Me.grdClientesCad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DsTelaUsuario
        '
        'DsTelaUsuario
        '
        Me.DsTelaUsuario.DataSetName = "dsTelaUsuario"
        Me.DsTelaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colRGIE, Me.colCPF, Me.colEndereco, Me.colNumero, Me.colComplemento, Me.colBairro, Me.colCep, Me.colCidade, Me.colEstado, Me.colTelefone, Me.colFax, Me.colCelular, Me.colEmail, Me.colData, Me.colFantasia, Me.colObservacao, Me.colStatus, Me.colSexo, Me.colInativo, Me.colContato})
        Me.grd1.GridControl = Me.grdClientesCad
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBairro, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.AlterarGrid
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 53
        '
        'AlterarGrid
        '
        Me.AlterarGrid.AutoHeight = False
        Me.AlterarGrid.Name = "AlterarGrid"
        '
        'colNome
        '
        Me.colNome.AppearanceCell.Options.UseTextOptions = True
        Me.colNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome.ColumnEdit = Me.AlterarGrid
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        Me.colNome.Width = 309
        '
        'colRGIE
        '
        Me.colRGIE.AppearanceCell.Options.UseTextOptions = True
        Me.colRGIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRGIE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colRGIE.ColumnEdit = Me.AlterarGrid
        Me.colRGIE.FieldName = "RGIE"
        Me.colRGIE.Name = "colRGIE"
        Me.colRGIE.OptionsColumn.ReadOnly = True
        Me.colRGIE.Visible = True
        Me.colRGIE.VisibleIndex = 3
        Me.colRGIE.Width = 137
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCPF.ColumnEdit = Me.AlterarGrid
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 4
        Me.colCPF.Width = 121
        '
        'colEndereco
        '
        Me.colEndereco.AppearanceCell.Options.UseTextOptions = True
        Me.colEndereco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEndereco.ColumnEdit = Me.AlterarGrid
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.OptionsColumn.ReadOnly = True
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 2
        Me.colEndereco.Width = 367
        '
        'colNumero
        '
        Me.colNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNumero.ColumnEdit = Me.AlterarGrid
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 5
        Me.colNumero.Width = 58
        '
        'colComplemento
        '
        Me.colComplemento.AppearanceCell.Options.UseTextOptions = True
        Me.colComplemento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colComplemento.ColumnEdit = Me.AlterarGrid
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Visible = True
        Me.colComplemento.VisibleIndex = 6
        Me.colComplemento.Width = 271
        '
        'colBairro
        '
        Me.colBairro.AppearanceCell.Options.UseTextOptions = True
        Me.colBairro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colBairro.ColumnEdit = Me.AlterarGrid
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.ReadOnly = True
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 7
        Me.colBairro.Width = 168
        '
        'colCep
        '
        Me.colCep.AppearanceCell.Options.UseTextOptions = True
        Me.colCep.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCep.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCep.ColumnEdit = Me.AlterarGrid
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.OptionsColumn.ReadOnly = True
        Me.colCep.Visible = True
        Me.colCep.VisibleIndex = 8
        Me.colCep.Width = 123
        '
        'colCidade
        '
        Me.colCidade.AppearanceCell.Options.UseTextOptions = True
        Me.colCidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colCidade.ColumnEdit = Me.AlterarGrid
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        Me.colCidade.Visible = True
        Me.colCidade.VisibleIndex = 9
        Me.colCidade.Width = 167
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.ColumnEdit = Me.AlterarGrid
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 10
        Me.colEstado.Width = 86
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTelefone.ColumnEdit = Me.AlterarGrid
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 11
        Me.colTelefone.Width = 120
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.ReadOnly = True
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 12
        Me.colFax.Width = 63
        '
        'colCelular
        '
        Me.colCelular.AppearanceCell.Options.UseTextOptions = True
        Me.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCelular.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCelular.ColumnEdit = Me.AlterarGrid
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.OptionsColumn.ReadOnly = True
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 13
        Me.colCelular.Width = 106
        '
        'colEmail
        '
        Me.colEmail.AppearanceCell.Options.UseTextOptions = True
        Me.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colEmail.ColumnEdit = Me.AlterarGrid
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 14
        Me.colEmail.Width = 247
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colData.ColumnEdit = Me.AlterarGrid
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 15
        Me.colData.Width = 125
        '
        'colFantasia
        '
        Me.colFantasia.AppearanceCell.Options.UseTextOptions = True
        Me.colFantasia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colFantasia.ColumnEdit = Me.AlterarGrid
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.OptionsColumn.ReadOnly = True
        Me.colFantasia.Visible = True
        Me.colFantasia.VisibleIndex = 16
        Me.colFantasia.Width = 194
        '
        'colObservacao
        '
        Me.colObservacao.AppearanceCell.Options.UseTextOptions = True
        Me.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colObservacao.ColumnEdit = Me.AlterarGrid
        Me.colObservacao.FieldName = "Observacao"
        Me.colObservacao.Name = "colObservacao"
        Me.colObservacao.OptionsColumn.ReadOnly = True
        Me.colObservacao.Visible = True
        Me.colObservacao.VisibleIndex = 17
        Me.colObservacao.Width = 228
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 18
        Me.colStatus.Width = 74
        '
        'colSexo
        '
        Me.colSexo.AppearanceCell.Options.UseTextOptions = True
        Me.colSexo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSexo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSexo.FieldName = "Sexo"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.OptionsColumn.ReadOnly = True
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 19
        Me.colSexo.Width = 63
        '
        'colInativo
        '
        Me.colInativo.AppearanceCell.Options.UseTextOptions = True
        Me.colInativo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInativo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        Me.colInativo.OptionsColumn.ReadOnly = True
        Me.colInativo.Visible = True
        Me.colInativo.VisibleIndex = 20
        Me.colInativo.Width = 61
        '
        'colContato
        '
        Me.colContato.AppearanceCell.Options.UseTextOptions = True
        Me.colContato.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContato.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colContato.FieldName = "Contato"
        Me.colContato.Name = "colContato"
        Me.colContato.OptionsColumn.ReadOnly = True
        Me.colContato.Visible = True
        Me.colContato.VisibleIndex = 21
        Me.colContato.Width = 105
        '
        'tabGeral
        '
        Me.tabGeral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabGeral.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabGeral.AppearancePage.Header.Options.UseFont = True
        Me.tabGeral.Location = New System.Drawing.Point(3, 3)
        Me.tabGeral.Name = "tabGeral"
        Me.tabGeral.SelectedTabPage = Me.tabPrincipal
        Me.tabGeral.Size = New System.Drawing.Size(1005, 333)
        Me.tabGeral.TabIndex = 2
        Me.tabGeral.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPrincipal, Me.tabComplementos, Me.tabNfe})
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.btnPesquisarCpfCnpj)
        Me.tabPrincipal.Controls.Add(Me.NavBarControl1)
        Me.tabPrincipal.Controls.Add(Me.lblStatus)
        Me.tabPrincipal.Controls.Add(Me.cboStatus)
        Me.tabPrincipal.Controls.Add(Me.lblSexo)
        Me.tabPrincipal.Controls.Add(Me.cboSexo)
        Me.tabPrincipal.Controls.Add(Me.dtNascim)
        Me.tabPrincipal.Controls.Add(Me.grpObservacoes)
        Me.tabPrincipal.Controls.Add(Me.txtEmail)
        Me.tabPrincipal.Controls.Add(Me.lblEmail)
        Me.tabPrincipal.Controls.Add(Me.txtContato)
        Me.tabPrincipal.Controls.Add(Me.lblContato)
        Me.tabPrincipal.Controls.Add(Me.lblTelefone3)
        Me.tabPrincipal.Controls.Add(Me.txtTelefone3)
        Me.tabPrincipal.Controls.Add(Me.txtTelefone2)
        Me.tabPrincipal.Controls.Add(Me.lblTelefone2)
        Me.tabPrincipal.Controls.Add(Me.rdgCpfCnpj)
        Me.tabPrincipal.Controls.Add(Me.lblTelefone1)
        Me.tabPrincipal.Controls.Add(Me.txtTelefone1)
        Me.tabPrincipal.Controls.Add(Me.tabEndereco)
        Me.tabPrincipal.Controls.Add(Me.txtCpfCnpj)
        Me.tabPrincipal.Controls.Add(Me.lblRgIe)
        Me.tabPrincipal.Controls.Add(Me.txtRgIe)
        Me.tabPrincipal.Controls.Add(Me.lblNascim)
        Me.tabPrincipal.Controls.Add(Me.lblFantasia)
        Me.tabPrincipal.Controls.Add(Me.txtFantasia)
        Me.tabPrincipal.Controls.Add(Me.lblNomeRazao)
        Me.tabPrincipal.Controls.Add(Me.txtNomeRazao)
        Me.tabPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.Size = New System.Drawing.Size(999, 305)
        Me.tabPrincipal.Text = "Principal"
        '
        'btnPesquisarCpfCnpj
        '
        Me.btnPesquisarCpfCnpj.Image = CType(resources.GetObject("btnPesquisarCpfCnpj.Image"), System.Drawing.Image)
        Me.btnPesquisarCpfCnpj.Location = New System.Drawing.Point(341, 35)
        Me.btnPesquisarCpfCnpj.Name = "btnPesquisarCpfCnpj"
        Me.btnPesquisarCpfCnpj.Size = New System.Drawing.Size(20, 20)
        Me.btnPesquisarCpfCnpj.TabIndex = 101
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Location = New System.Drawing.Point(858, 4)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 138
        Me.NavBarControl1.Size = New System.Drawing.Size(138, 294)
        Me.NavBarControl1.TabIndex = 79
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "NavBarGroup1"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(773, 38)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(31, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.EditValue = ""
        Me.cboStatus.EnterMoveNextControl = True
        Me.cboStatus.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cboStatus.Location = New System.Drawing.Point(810, 36)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboStatus.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboStatus.Properties.MaxLength = 3
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(37, 20)
        Me.cboStatus.TabIndex = 6
        '
        'lblSexo
        '
        Me.lblSexo.Location = New System.Drawing.Point(701, 38)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(24, 13)
        Me.lblSexo.TabIndex = 6
        Me.lblSexo.Text = "Sexo"
        '
        'cboSexo
        '
        Me.cboSexo.EnterMoveNextControl = True
        Me.cboSexo.Location = New System.Drawing.Point(731, 35)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSexo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboSexo.Properties.Items.AddRange(New Object() {"M", "F"})
        Me.cboSexo.Properties.MaxLength = 1
        Me.cboSexo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSexo.Size = New System.Drawing.Size(36, 20)
        Me.cboSexo.TabIndex = 5
        '
        'dtNascim
        '
        Me.dtNascim.EditValue = Nothing
        Me.dtNascim.EnterMoveNextControl = True
        Me.dtNascim.Location = New System.Drawing.Point(612, 35)
        Me.dtNascim.Name = "dtNascim"
        Me.dtNascim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNascim.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.dtNascim.Properties.MaxLength = 16
        Me.dtNascim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNascim.Size = New System.Drawing.Size(83, 20)
        Me.dtNascim.TabIndex = 4
        '
        'grpObservacoes
        '
        Me.grpObservacoes.Appearance.BackColor = System.Drawing.Color.White
        Me.grpObservacoes.Appearance.Options.UseBackColor = True
        Me.grpObservacoes.AutoSize = True
        Me.grpObservacoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grpObservacoes.Controls.Add(Me.chkInativo)
        Me.grpObservacoes.Controls.Add(Me.chkPendencia)
        Me.grpObservacoes.Controls.Add(Me.memObservacoes)
        Me.grpObservacoes.Location = New System.Drawing.Point(3, 237)
        Me.grpObservacoes.Name = "grpObservacoes"
        Me.grpObservacoes.Size = New System.Drawing.Size(852, 61)
        Me.grpObservacoes.TabIndex = 74
        Me.grpObservacoes.Text = "Observações"
        '
        'chkInativo
        '
        Me.chkInativo.Location = New System.Drawing.Point(167, -1)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkInativo.Properties.Appearance.Options.UseForeColor = True
        Me.chkInativo.Properties.Caption = "Inativo"
        Me.chkInativo.Size = New System.Drawing.Size(75, 19)
        Me.chkInativo.TabIndex = 105
        '
        'chkPendencia
        '
        Me.chkPendencia.Location = New System.Drawing.Point(80, -1)
        Me.chkPendencia.Name = "chkPendencia"
        Me.chkPendencia.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkPendencia.Properties.Appearance.Options.UseForeColor = True
        Me.chkPendencia.Properties.Caption = "Pendência"
        Me.chkPendencia.Size = New System.Drawing.Size(75, 19)
        Me.chkPendencia.TabIndex = 104
        '
        'memObservacoes
        '
        Me.memObservacoes.Location = New System.Drawing.Point(3, 24)
        Me.memObservacoes.Name = "memObservacoes"
        Me.memObservacoes.Size = New System.Drawing.Size(846, 32)
        Me.memObservacoes.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(612, 175)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.MaxLength = 50
        Me.txtEmail.Size = New System.Drawing.Size(235, 20)
        Me.txtEmail.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(582, 178)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(24, 13)
        Me.lblEmail.TabIndex = 68
        Me.lblEmail.Text = "Email"
        '
        'txtContato
        '
        Me.txtContato.EnterMoveNextControl = True
        Me.txtContato.Location = New System.Drawing.Point(318, 201)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtContato.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContato.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtContato.Properties.MaxLength = 30
        Me.txtContato.Size = New System.Drawing.Size(192, 22)
        Me.txtContato.TabIndex = 18
        '
        'lblContato
        '
        Me.lblContato.Location = New System.Drawing.Point(273, 205)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(39, 13)
        Me.lblContato.TabIndex = 66
        Me.lblContato.Text = "Contato"
        '
        'lblTelefone3
        '
        Me.lblTelefone3.Location = New System.Drawing.Point(46, 204)
        Me.lblTelefone3.Name = "lblTelefone3"
        Me.lblTelefone3.Size = New System.Drawing.Size(51, 13)
        Me.lblTelefone3.TabIndex = 65
        Me.lblTelefone3.Text = "Telefone 3"
        '
        'txtTelefone3
        '
        Me.txtTelefone3.EnterMoveNextControl = True
        Me.txtTelefone3.Location = New System.Drawing.Point(103, 201)
        Me.txtTelefone3.Name = "txtTelefone3"
        Me.txtTelefone3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtTelefone3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTelefone3.Properties.MaxLength = 18
        Me.txtTelefone3.Size = New System.Drawing.Size(148, 22)
        Me.txtTelefone3.TabIndex = 17
        '
        'txtTelefone2
        '
        Me.txtTelefone2.EnterMoveNextControl = True
        Me.txtTelefone2.Location = New System.Drawing.Point(318, 175)
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtTelefone2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTelefone2.Properties.MaxLength = 18
        Me.txtTelefone2.Size = New System.Drawing.Size(192, 22)
        Me.txtTelefone2.TabIndex = 15
        '
        'lblTelefone2
        '
        Me.lblTelefone2.Location = New System.Drawing.Point(261, 179)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(51, 13)
        Me.lblTelefone2.TabIndex = 59
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'rdgCpfCnpj
        '
        Me.rdgCpfCnpj.Location = New System.Drawing.Point(9, 33)
        Me.rdgCpfCnpj.Name = "rdgCpfCnpj"
        Me.rdgCpfCnpj.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgCpfCnpj.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CNPJ")})
        Me.rdgCpfCnpj.Size = New System.Drawing.Size(95, 22)
        Me.rdgCpfCnpj.TabIndex = 100
        '
        'lblTelefone1
        '
        Me.lblTelefone1.Location = New System.Drawing.Point(46, 178)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(51, 13)
        Me.lblTelefone1.TabIndex = 57
        Me.lblTelefone1.Text = "Telefone 1"
        '
        'txtTelefone1
        '
        Me.txtTelefone1.EnterMoveNextControl = True
        Me.txtTelefone1.Location = New System.Drawing.Point(103, 175)
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtTelefone1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTelefone1.Properties.MaxLength = 18
        Me.txtTelefone1.Size = New System.Drawing.Size(148, 22)
        Me.txtTelefone1.TabIndex = 14
        '
        'tabEndereco
        '
        Me.tabEndereco.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabEndereco.AppearancePage.Header.Options.UseFont = True
        Me.tabEndereco.Location = New System.Drawing.Point(3, 65)
        Me.tabEndereco.Name = "tabEndereco"
        Me.tabEndereco.SelectedTabPage = Me.tabCliente
        Me.tabEndereco.Size = New System.Drawing.Size(849, 104)
        Me.tabEndereco.TabIndex = 9
        Me.tabEndereco.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCliente, Me.tabEnderecoEntrega})
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.btnBuscaCep)
        Me.tabCliente.Controls.Add(Me.btnAddFrete)
        Me.tabCliente.Controls.Add(Me.cboClienteBairro)
        Me.tabCliente.Controls.Add(Me.cboClienteCidade)
        Me.tabCliente.Controls.Add(Me.cboClienteUf)
        Me.tabCliente.Controls.Add(Me.lblClienteBairro)
        Me.tabCliente.Controls.Add(Me.lblClienteCidade)
        Me.tabCliente.Controls.Add(Me.lblClienteUf)
        Me.tabCliente.Controls.Add(Me.lblClienteComp)
        Me.tabCliente.Controls.Add(Me.txtClienteComp)
        Me.tabCliente.Controls.Add(Me.lblClienteEndereco)
        Me.tabCliente.Controls.Add(Me.txtClienteEndereco)
        Me.tabCliente.Controls.Add(Me.lblClienteNum)
        Me.tabCliente.Controls.Add(Me.txtClienteNum)
        Me.tabCliente.Controls.Add(Me.lblClienteCep)
        Me.tabCliente.Controls.Add(Me.txtClienteCep)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Size = New System.Drawing.Size(843, 76)
        Me.tabCliente.Text = "Endereço Cliente"
        '
        'btnBuscaCep
        '
        Me.btnBuscaCep.Image = CType(resources.GetObject("btnBuscaCep.Image"), System.Drawing.Image)
        Me.btnBuscaCep.Location = New System.Drawing.Point(227, 16)
        Me.btnBuscaCep.Name = "btnBuscaCep"
        Me.btnBuscaCep.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaCep.TabIndex = 102
        '
        'btnAddFrete
        '
        Me.btnAddFrete.Image = CType(resources.GetObject("btnAddFrete.Image"), System.Drawing.Image)
        Me.btnAddFrete.Location = New System.Drawing.Point(814, 42)
        Me.btnAddFrete.Name = "btnAddFrete"
        Me.btnAddFrete.Size = New System.Drawing.Size(25, 20)
        Me.btnAddFrete.TabIndex = 103
        '
        'cboClienteBairro
        '
        Me.cboClienteBairro.EnterMoveNextControl = True
        Me.cboClienteBairro.Location = New System.Drawing.Point(608, 42)
        Me.cboClienteBairro.Name = "cboClienteBairro"
        Me.cboClienteBairro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboClienteBairro.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboClienteBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteBairro.Properties.Items.AddRange(New Object() {"Jd. Paulista"})
        Me.cboClienteBairro.Properties.MaxLength = 100
        Me.cboClienteBairro.Size = New System.Drawing.Size(206, 20)
        Me.cboClienteBairro.TabIndex = 13
        '
        'cboClienteCidade
        '
        Me.cboClienteCidade.EnterMoveNextControl = True
        Me.cboClienteCidade.Location = New System.Drawing.Point(402, 16)
        Me.cboClienteCidade.Name = "cboClienteCidade"
        Me.cboClienteCidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboClienteCidade.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboClienteCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteCidade.Properties.Items.AddRange(New Object() {"Indaiatuba" & Global.Microsoft.VisualBasic.ChrW(9), "Salto", "Campinas"})
        Me.cboClienteCidade.Properties.MaxLength = 80
        Me.cboClienteCidade.Size = New System.Drawing.Size(104, 20)
        Me.cboClienteCidade.TabIndex = 9
        '
        'cboClienteUf
        '
        Me.cboClienteUf.EnterMoveNextControl = True
        Me.cboClienteUf.Location = New System.Drawing.Point(314, 16)
        Me.cboClienteUf.Name = "cboClienteUf"
        Me.cboClienteUf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboClienteUf.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboClienteUf.Properties.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboClienteUf.Properties.MaxLength = 2
        Me.cboClienteUf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboClienteUf.Size = New System.Drawing.Size(43, 20)
        Me.cboClienteUf.TabIndex = 8
        '
        'lblClienteBairro
        '
        Me.lblClienteBairro.Location = New System.Drawing.Point(574, 47)
        Me.lblClienteBairro.Name = "lblClienteBairro"
        Me.lblClienteBairro.Size = New System.Drawing.Size(28, 13)
        Me.lblClienteBairro.TabIndex = 54
        Me.lblClienteBairro.Text = "Bairro"
        '
        'lblClienteCidade
        '
        Me.lblClienteCidade.Location = New System.Drawing.Point(363, 19)
        Me.lblClienteCidade.Name = "lblClienteCidade"
        Me.lblClienteCidade.Size = New System.Drawing.Size(33, 13)
        Me.lblClienteCidade.TabIndex = 52
        Me.lblClienteCidade.Text = "Cidade"
        '
        'lblClienteUf
        '
        Me.lblClienteUf.Location = New System.Drawing.Point(295, 20)
        Me.lblClienteUf.Name = "lblClienteUf"
        Me.lblClienteUf.Size = New System.Drawing.Size(13, 13)
        Me.lblClienteUf.TabIndex = 50
        Me.lblClienteUf.Text = "UF"
        '
        'lblClienteComp
        '
        Me.lblClienteComp.Location = New System.Drawing.Point(277, 47)
        Me.lblClienteComp.Name = "lblClienteComp"
        Me.lblClienteComp.Size = New System.Drawing.Size(31, 13)
        Me.lblClienteComp.TabIndex = 0
        Me.lblClienteComp.Text = "Comp."
        '
        'txtClienteComp
        '
        Me.txtClienteComp.EnterMoveNextControl = True
        Me.txtClienteComp.Location = New System.Drawing.Point(314, 45)
        Me.txtClienteComp.Name = "txtClienteComp"
        Me.txtClienteComp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteComp.Properties.MaxLength = 75
        Me.txtClienteComp.Size = New System.Drawing.Size(192, 20)
        Me.txtClienteComp.TabIndex = 12
        '
        'lblClienteEndereco
        '
        Me.lblClienteEndereco.Location = New System.Drawing.Point(557, 19)
        Me.lblClienteEndereco.Name = "lblClienteEndereco"
        Me.lblClienteEndereco.Size = New System.Drawing.Size(45, 13)
        Me.lblClienteEndereco.TabIndex = 47
        Me.lblClienteEndereco.Text = "Endereço"
        '
        'txtClienteEndereco
        '
        Me.txtClienteEndereco.EnterMoveNextControl = True
        Me.txtClienteEndereco.Location = New System.Drawing.Point(608, 16)
        Me.txtClienteEndereco.Name = "txtClienteEndereco"
        Me.txtClienteEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteEndereco.Properties.MaxLength = 150
        Me.txtClienteEndereco.Size = New System.Drawing.Size(231, 20)
        Me.txtClienteEndereco.TabIndex = 10
        '
        'lblClienteNum
        '
        Me.lblClienteNum.Location = New System.Drawing.Point(84, 47)
        Me.lblClienteNum.Name = "lblClienteNum"
        Me.lblClienteNum.Size = New System.Drawing.Size(12, 13)
        Me.lblClienteNum.TabIndex = 10
        Me.lblClienteNum.Text = "N°"
        '
        'txtClienteNum
        '
        Me.txtClienteNum.EnterMoveNextControl = True
        Me.txtClienteNum.Location = New System.Drawing.Point(102, 44)
        Me.txtClienteNum.Name = "txtClienteNum"
        Me.txtClienteNum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtClienteNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteNum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtClienteNum.Properties.MaxLength = 10
        Me.txtClienteNum.Size = New System.Drawing.Size(145, 22)
        Me.txtClienteNum.TabIndex = 11
        '
        'lblClienteCep
        '
        Me.lblClienteCep.Location = New System.Drawing.Point(77, 19)
        Me.lblClienteCep.Name = "lblClienteCep"
        Me.lblClienteCep.Size = New System.Drawing.Size(19, 13)
        Me.lblClienteCep.TabIndex = 6
        Me.lblClienteCep.Text = "CEP"
        '
        'txtClienteCep
        '
        Me.txtClienteCep.EnterMoveNextControl = True
        Me.txtClienteCep.Location = New System.Drawing.Point(102, 16)
        Me.txtClienteCep.Name = "txtClienteCep"
        Me.txtClienteCep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtClienteCep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteCep.Properties.MaxLength = 20
        Me.txtClienteCep.Size = New System.Drawing.Size(125, 22)
        Me.txtClienteCep.TabIndex = 7
        '
        'tabEnderecoEntrega
        '
        Me.tabEnderecoEntrega.Name = "tabEnderecoEntrega"
        Me.tabEnderecoEntrega.Size = New System.Drawing.Size(843, 76)
        Me.tabEnderecoEntrega.Text = "Endereço Entrega"
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.EnterMoveNextControl = True
        Me.txtCpfCnpj.Location = New System.Drawing.Point(106, 35)
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCpfCnpj.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCpfCnpj.Properties.MaxLength = 25
        Me.txtCpfCnpj.Size = New System.Drawing.Size(237, 20)
        Me.txtCpfCnpj.TabIndex = 2
        '
        'lblRgIe
        '
        Me.lblRgIe.Location = New System.Drawing.Point(372, 39)
        Me.lblRgIe.Name = "lblRgIe"
        Me.lblRgIe.Size = New System.Drawing.Size(28, 13)
        Me.lblRgIe.TabIndex = 10
        Me.lblRgIe.Text = "RG/IE"
        '
        'txtRgIe
        '
        Me.txtRgIe.EnterMoveNextControl = True
        Me.txtRgIe.Location = New System.Drawing.Point(406, 35)
        Me.txtRgIe.Name = "txtRgIe"
        Me.txtRgIe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtRgIe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRgIe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRgIe.Properties.MaxLength = 15
        Me.txtRgIe.Size = New System.Drawing.Size(105, 22)
        Me.txtRgIe.TabIndex = 3
        '
        'lblNascim
        '
        Me.lblNascim.Location = New System.Drawing.Point(569, 38)
        Me.lblNascim.Name = "lblNascim"
        Me.lblNascim.Size = New System.Drawing.Size(37, 13)
        Me.lblNascim.TabIndex = 8
        Me.lblNascim.Text = "Nascim."
        '
        'lblFantasia
        '
        Me.lblFantasia.Location = New System.Drawing.Point(565, 12)
        Me.lblFantasia.Name = "lblFantasia"
        Me.lblFantasia.Size = New System.Drawing.Size(41, 13)
        Me.lblFantasia.TabIndex = 23
        Me.lblFantasia.Text = "Fantasia"
        '
        'txtFantasia
        '
        Me.txtFantasia.EditValue = ""
        Me.txtFantasia.EnterMoveNextControl = True
        Me.txtFantasia.Location = New System.Drawing.Point(612, 9)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFantasia.Properties.MaxLength = 80
        Me.txtFantasia.Size = New System.Drawing.Size(235, 20)
        Me.txtFantasia.TabIndex = 1
        '
        'lblNomeRazao
        '
        Me.lblNomeRazao.Location = New System.Drawing.Point(39, 12)
        Me.lblNomeRazao.Name = "lblNomeRazao"
        Me.lblNomeRazao.Size = New System.Drawing.Size(61, 13)
        Me.lblNomeRazao.TabIndex = 0
        Me.lblNomeRazao.Text = "Nome/Razão"
        '
        'txtNomeRazao
        '
        Me.txtNomeRazao.EnterMoveNextControl = True
        Me.txtNomeRazao.Location = New System.Drawing.Point(106, 9)
        Me.txtNomeRazao.Name = "txtNomeRazao"
        Me.txtNomeRazao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeRazao.Properties.MaxLength = 150
        Me.txtNomeRazao.Size = New System.Drawing.Size(404, 20)
        Me.txtNomeRazao.TabIndex = 0
        '
        'tabComplementos
        '
        Me.tabComplementos.Controls.Add(Me.LabelControl59)
        Me.tabComplementos.Controls.Add(Me.PanelControl7)
        Me.tabComplementos.Controls.Add(Me.LabelControl58)
        Me.tabComplementos.Controls.Add(Me.PanelControl6)
        Me.tabComplementos.Controls.Add(Me.LabelControl57)
        Me.tabComplementos.Controls.Add(Me.PanelControl5)
        Me.tabComplementos.Controls.Add(Me.LabelControl55)
        Me.tabComplementos.Controls.Add(Me.PanelControl4)
        Me.tabComplementos.Controls.Add(Me.LabelControl56)
        Me.tabComplementos.Controls.Add(Me.PanelControl3)
        Me.tabComplementos.Controls.Add(Me.dtDataFatura)
        Me.tabComplementos.Controls.Add(Me.lblMoradia)
        Me.tabComplementos.Controls.Add(Me.cboMoradia)
        Me.tabComplementos.Controls.Add(Me.LabelControl39)
        Me.tabComplementos.Controls.Add(Me.LabelControl40)
        Me.tabComplementos.Controls.Add(Me.TextEdit36)
        Me.tabComplementos.Controls.Add(Me.LabelControl41)
        Me.tabComplementos.Controls.Add(Me.TextEdit37)
        Me.tabComplementos.Controls.Add(Me.lblBancoContaCorrente)
        Me.tabComplementos.Controls.Add(Me.txtContaCorrente)
        Me.tabComplementos.Controls.Add(Me.lblBancoBanco)
        Me.tabComplementos.Controls.Add(Me.txtBanco)
        Me.tabComplementos.Controls.Add(Me.lblBancoAgencia)
        Me.tabComplementos.Controls.Add(Me.txtAgencia)
        Me.tabComplementos.Controls.Add(Me.lblConjugeNome)
        Me.tabComplementos.Controls.Add(Me.txtConjugeNome)
        Me.tabComplementos.Controls.Add(Me.lblConjugeTelefone)
        Me.tabComplementos.Controls.Add(Me.txtConjugeTelefone)
        Me.tabComplementos.Controls.Add(Me.lblAutorizadasNome2)
        Me.tabComplementos.Controls.Add(Me.txtAutorizadasNome2)
        Me.tabComplementos.Controls.Add(Me.lblAutorizadasRg2)
        Me.tabComplementos.Controls.Add(Me.txtAutorizadasRg2)
        Me.tabComplementos.Controls.Add(Me.lblAutorizadasRg1)
        Me.tabComplementos.Controls.Add(Me.txtAutorizadasRg1)
        Me.tabComplementos.Controls.Add(Me.lblAutorizadasNome1)
        Me.tabComplementos.Controls.Add(Me.txtAutorizadasNome1)
        Me.tabComplementos.Controls.Add(Me.lblTelefone)
        Me.tabComplementos.Controls.Add(Me.txtTelefone)
        Me.tabComplementos.Controls.Add(Me.lblTempTrab)
        Me.tabComplementos.Controls.Add(Me.txtTempTrab)
        Me.tabComplementos.Controls.Add(Me.lblFaixaSalarial)
        Me.tabComplementos.Controls.Add(Me.txtFaixaSalarial)
        Me.tabComplementos.Controls.Add(Me.lblEmpresa)
        Me.tabComplementos.Controls.Add(Me.txtEmpresa)
        Me.tabComplementos.Name = "tabComplementos"
        Me.tabComplementos.PageVisible = False
        Me.tabComplementos.Size = New System.Drawing.Size(999, 305)
        Me.tabComplementos.Text = "Complemento"
        '
        'LabelControl59
        '
        Me.LabelControl59.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl59.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl59.Location = New System.Drawing.Point(31, 240)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl59.TabIndex = 75
        Me.LabelControl59.Text = "Cartão"
        '
        'PanelControl7
        '
        Me.PanelControl7.Location = New System.Drawing.Point(9, 248)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(503, 5)
        Me.PanelControl7.TabIndex = 74
        '
        'LabelControl58
        '
        Me.LabelControl58.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl58.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl58.Location = New System.Drawing.Point(31, 195)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl58.TabIndex = 73
        Me.LabelControl58.Text = "Banco"
        '
        'PanelControl6
        '
        Me.PanelControl6.Location = New System.Drawing.Point(9, 203)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(503, 5)
        Me.PanelControl6.TabIndex = 72
        '
        'LabelControl57
        '
        Me.LabelControl57.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl57.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl57.Location = New System.Drawing.Point(31, 145)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl57.TabIndex = 71
        Me.LabelControl57.Text = "Conjugê"
        '
        'PanelControl5
        '
        Me.PanelControl5.Location = New System.Drawing.Point(9, 153)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(503, 5)
        Me.PanelControl5.TabIndex = 70
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl55.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl55.Location = New System.Drawing.Point(31, 67)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl55.TabIndex = 69
        Me.LabelControl55.Text = "Pessoas Autorizadas"
        '
        'PanelControl4
        '
        Me.PanelControl4.Location = New System.Drawing.Point(9, 75)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(503, 5)
        Me.PanelControl4.TabIndex = 67
        '
        'LabelControl56
        '
        Me.LabelControl56.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl56.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl56.Location = New System.Drawing.Point(548, 3)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl56.TabIndex = 66
        Me.LabelControl56.Text = "Histórico"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.btnExcluirCredDev)
        Me.PanelControl3.Controls.Add(Me.btnConsumo)
        Me.PanelControl3.Controls.Add(Me.btnVendas)
        Me.PanelControl3.Controls.Add(Me.LabelControl66)
        Me.PanelControl3.Controls.Add(Me.txtDiasAtraso)
        Me.PanelControl3.Controls.Add(Me.LabelControl65)
        Me.PanelControl3.Controls.Add(Me.txtLimCliente)
        Me.PanelControl3.Controls.Add(Me.LabelControl64)
        Me.PanelControl3.Controls.Add(Me.txtSaldoDevedor)
        Me.PanelControl3.Controls.Add(Me.lblultVisita)
        Me.PanelControl3.Controls.Add(Me.txtUltVisita)
        Me.PanelControl3.Controls.Add(Me.LabelControl62)
        Me.PanelControl3.Controls.Add(Me.txtLimAtual)
        Me.PanelControl3.Controls.Add(Me.LabelControl61)
        Me.PanelControl3.Controls.Add(Me.txtNumCompras)
        Me.PanelControl3.Controls.Add(Me.lblCadastro)
        Me.PanelControl3.Controls.Add(Me.txtCadastro)
        Me.PanelControl3.Location = New System.Drawing.Point(530, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(453, 269)
        Me.PanelControl3.TabIndex = 64
        '
        'btnExcluirCredDev
        '
        Me.btnExcluirCredDev.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExcluirCredDev.Appearance.Options.UseFont = True
        Me.btnExcluirCredDev.Location = New System.Drawing.Point(27, 239)
        Me.btnExcluirCredDev.Name = "btnExcluirCredDev"
        Me.btnExcluirCredDev.Size = New System.Drawing.Size(164, 23)
        Me.btnExcluirCredDev.TabIndex = 95
        Me.btnExcluirCredDev.Text = "Excluir Crédito Dev."
        '
        'btnConsumo
        '
        Me.btnConsumo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnConsumo.Appearance.Options.UseFont = True
        Me.btnConsumo.Location = New System.Drawing.Point(116, 210)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(75, 23)
        Me.btnConsumo.TabIndex = 94
        Me.btnConsumo.Text = "Consumo"
        '
        'btnVendas
        '
        Me.btnVendas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVendas.Appearance.Options.UseFont = True
        Me.btnVendas.Location = New System.Drawing.Point(27, 210)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(75, 23)
        Me.btnVendas.TabIndex = 80
        Me.btnVendas.Text = "Vendas"
        '
        'LabelControl66
        '
        Me.LabelControl66.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl66.Location = New System.Drawing.Point(246, 191)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl66.TabIndex = 89
        Me.LabelControl66.Text = "Dias em Atraso"
        '
        'txtDiasAtraso
        '
        Me.txtDiasAtraso.Location = New System.Drawing.Point(246, 207)
        Me.txtDiasAtraso.Name = "txtDiasAtraso"
        Me.txtDiasAtraso.Size = New System.Drawing.Size(164, 20)
        Me.txtDiasAtraso.TabIndex = 88
        '
        'LabelControl65
        '
        Me.LabelControl65.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl65.Location = New System.Drawing.Point(27, 156)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl65.TabIndex = 87
        Me.LabelControl65.Text = "Limite do Cliente"
        '
        'txtLimCliente
        '
        Me.txtLimCliente.Location = New System.Drawing.Point(27, 172)
        Me.txtLimCliente.Name = "txtLimCliente"
        Me.txtLimCliente.Size = New System.Drawing.Size(164, 20)
        Me.txtLimCliente.TabIndex = 86
        '
        'LabelControl64
        '
        Me.LabelControl64.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl64.Location = New System.Drawing.Point(246, 110)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl64.TabIndex = 85
        Me.LabelControl64.Text = "Saldo Devedor"
        '
        'txtSaldoDevedor
        '
        Me.txtSaldoDevedor.Location = New System.Drawing.Point(246, 126)
        Me.txtSaldoDevedor.Name = "txtSaldoDevedor"
        Me.txtSaldoDevedor.Size = New System.Drawing.Size(164, 20)
        Me.txtSaldoDevedor.TabIndex = 84
        '
        'lblultVisita
        '
        Me.lblultVisita.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblultVisita.Location = New System.Drawing.Point(246, 6)
        Me.lblultVisita.Name = "lblultVisita"
        Me.lblultVisita.Size = New System.Drawing.Size(53, 13)
        Me.lblultVisita.TabIndex = 83
        Me.lblultVisita.Text = "Últ. Visita"
        '
        'txtUltVisita
        '
        Me.txtUltVisita.Location = New System.Drawing.Point(246, 24)
        Me.txtUltVisita.Name = "txtUltVisita"
        Me.txtUltVisita.Size = New System.Drawing.Size(164, 20)
        Me.txtUltVisita.TabIndex = 82
        '
        'LabelControl62
        '
        Me.LabelControl62.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl62.Location = New System.Drawing.Point(27, 110)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl62.TabIndex = 81
        Me.LabelControl62.Text = "Limite Atual"
        '
        'txtLimAtual
        '
        Me.txtLimAtual.Location = New System.Drawing.Point(27, 126)
        Me.txtLimAtual.Name = "txtLimAtual"
        Me.txtLimAtual.Size = New System.Drawing.Size(164, 20)
        Me.txtLimAtual.TabIndex = 80
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl61.Location = New System.Drawing.Point(27, 59)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl61.TabIndex = 79
        Me.LabelControl61.Text = "N° Compras"
        '
        'txtNumCompras
        '
        Me.txtNumCompras.Location = New System.Drawing.Point(27, 75)
        Me.txtNumCompras.Name = "txtNumCompras"
        Me.txtNumCompras.Size = New System.Drawing.Size(164, 20)
        Me.txtNumCompras.TabIndex = 78
        '
        'lblCadastro
        '
        Me.lblCadastro.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCadastro.Location = New System.Drawing.Point(27, 6)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(51, 13)
        Me.lblCadastro.TabIndex = 77
        Me.lblCadastro.Text = "Cadastro"
        '
        'txtCadastro
        '
        Me.txtCadastro.Location = New System.Drawing.Point(27, 24)
        Me.txtCadastro.Name = "txtCadastro"
        Me.txtCadastro.Size = New System.Drawing.Size(164, 20)
        Me.txtCadastro.TabIndex = 76
        '
        'dtDataFatura
        '
        Me.dtDataFatura.EditValue = Nothing
        Me.dtDataFatura.Location = New System.Drawing.Point(387, 261)
        Me.dtDataFatura.Name = "dtDataFatura"
        Me.dtDataFatura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDataFatura.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDataFatura.Size = New System.Drawing.Size(125, 20)
        Me.dtDataFatura.TabIndex = 63
        '
        'lblMoradia
        '
        Me.lblMoradia.Location = New System.Drawing.Point(370, 47)
        Me.lblMoradia.Name = "lblMoradia"
        Me.lblMoradia.Size = New System.Drawing.Size(38, 13)
        Me.lblMoradia.TabIndex = 62
        Me.lblMoradia.Text = "Moradia"
        '
        'cboMoradia
        '
        Me.cboMoradia.Location = New System.Drawing.Point(414, 44)
        Me.cboMoradia.Name = "cboMoradia"
        Me.cboMoradia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMoradia.Size = New System.Drawing.Size(98, 20)
        Me.cboMoradia.TabIndex = 61
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(323, 264)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl39.TabIndex = 60
        Me.LabelControl39.Text = "Data Fatura"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(40, 264)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl40.TabIndex = 58
        Me.LabelControl40.Text = "Número"
        '
        'TextEdit36
        '
        Me.TextEdit36.Location = New System.Drawing.Point(83, 261)
        Me.TextEdit36.Name = "TextEdit36"
        Me.TextEdit36.Size = New System.Drawing.Size(81, 20)
        Me.TextEdit36.TabIndex = 57
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(182, 264)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl41.TabIndex = 56
        Me.LabelControl41.Text = "Senha"
        '
        'TextEdit37
        '
        Me.TextEdit37.Location = New System.Drawing.Point(218, 261)
        Me.TextEdit37.Name = "TextEdit37"
        Me.TextEdit37.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit37.TabIndex = 55
        '
        'lblBancoContaCorrente
        '
        Me.lblBancoContaCorrente.Location = New System.Drawing.Point(306, 221)
        Me.lblBancoContaCorrente.Name = "lblBancoContaCorrente"
        Me.lblBancoContaCorrente.Size = New System.Drawing.Size(75, 13)
        Me.lblBancoContaCorrente.TabIndex = 54
        Me.lblBancoContaCorrente.Text = "Conta Corrente"
        '
        'txtContaCorrente
        '
        Me.txtContaCorrente.Location = New System.Drawing.Point(387, 218)
        Me.txtContaCorrente.Name = "txtContaCorrente"
        Me.txtContaCorrente.Size = New System.Drawing.Size(125, 20)
        Me.txtContaCorrente.TabIndex = 53
        '
        'lblBancoBanco
        '
        Me.lblBancoBanco.Location = New System.Drawing.Point(48, 222)
        Me.lblBancoBanco.Name = "lblBancoBanco"
        Me.lblBancoBanco.Size = New System.Drawing.Size(29, 13)
        Me.lblBancoBanco.TabIndex = 52
        Me.lblBancoBanco.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(83, 218)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(81, 20)
        Me.txtBanco.TabIndex = 51
        '
        'lblBancoAgencia
        '
        Me.lblBancoAgencia.Location = New System.Drawing.Point(174, 222)
        Me.lblBancoAgencia.Name = "lblBancoAgencia"
        Me.lblBancoAgencia.Size = New System.Drawing.Size(38, 13)
        Me.lblBancoAgencia.TabIndex = 50
        Me.lblBancoAgencia.Text = "Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(218, 218)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(76, 20)
        Me.txtAgencia.TabIndex = 49
        '
        'lblConjugeNome
        '
        Me.lblConjugeNome.Location = New System.Drawing.Point(50, 172)
        Me.lblConjugeNome.Name = "lblConjugeNome"
        Me.lblConjugeNome.Size = New System.Drawing.Size(27, 13)
        Me.lblConjugeNome.TabIndex = 48
        Me.lblConjugeNome.Text = "Nome"
        '
        'txtConjugeNome
        '
        Me.txtConjugeNome.Location = New System.Drawing.Point(83, 169)
        Me.txtConjugeNome.Name = "txtConjugeNome"
        Me.txtConjugeNome.Size = New System.Drawing.Size(212, 20)
        Me.txtConjugeNome.TabIndex = 47
        '
        'lblConjugeTelefone
        '
        Me.lblConjugeTelefone.Location = New System.Drawing.Point(339, 172)
        Me.lblConjugeTelefone.Name = "lblConjugeTelefone"
        Me.lblConjugeTelefone.Size = New System.Drawing.Size(42, 13)
        Me.lblConjugeTelefone.TabIndex = 46
        Me.lblConjugeTelefone.Text = "Telefone"
        '
        'txtConjugeTelefone
        '
        Me.txtConjugeTelefone.Location = New System.Drawing.Point(387, 169)
        Me.txtConjugeTelefone.Name = "txtConjugeTelefone"
        Me.txtConjugeTelefone.Size = New System.Drawing.Size(125, 20)
        Me.txtConjugeTelefone.TabIndex = 45
        '
        'lblAutorizadasNome2
        '
        Me.lblAutorizadasNome2.Location = New System.Drawing.Point(50, 122)
        Me.lblAutorizadasNome2.Name = "lblAutorizadasNome2"
        Me.lblAutorizadasNome2.Size = New System.Drawing.Size(27, 13)
        Me.lblAutorizadasNome2.TabIndex = 44
        Me.lblAutorizadasNome2.Text = "Nome"
        '
        'txtAutorizadasNome2
        '
        Me.txtAutorizadasNome2.Location = New System.Drawing.Point(83, 119)
        Me.txtAutorizadasNome2.Name = "txtAutorizadasNome2"
        Me.txtAutorizadasNome2.Size = New System.Drawing.Size(212, 20)
        Me.txtAutorizadasNome2.TabIndex = 43
        '
        'lblAutorizadasRg2
        '
        Me.lblAutorizadasRg2.Location = New System.Drawing.Point(367, 122)
        Me.lblAutorizadasRg2.Name = "lblAutorizadasRg2"
        Me.lblAutorizadasRg2.Size = New System.Drawing.Size(14, 13)
        Me.lblAutorizadasRg2.TabIndex = 42
        Me.lblAutorizadasRg2.Text = "RG"
        '
        'txtAutorizadasRg2
        '
        Me.txtAutorizadasRg2.Location = New System.Drawing.Point(387, 119)
        Me.txtAutorizadasRg2.Name = "txtAutorizadasRg2"
        Me.txtAutorizadasRg2.Size = New System.Drawing.Size(125, 20)
        Me.txtAutorizadasRg2.TabIndex = 41
        '
        'lblAutorizadasRg1
        '
        Me.lblAutorizadasRg1.Location = New System.Drawing.Point(367, 94)
        Me.lblAutorizadasRg1.Name = "lblAutorizadasRg1"
        Me.lblAutorizadasRg1.Size = New System.Drawing.Size(14, 13)
        Me.lblAutorizadasRg1.TabIndex = 38
        Me.lblAutorizadasRg1.Text = "RG"
        '
        'txtAutorizadasRg1
        '
        Me.txtAutorizadasRg1.Location = New System.Drawing.Point(387, 91)
        Me.txtAutorizadasRg1.Name = "txtAutorizadasRg1"
        Me.txtAutorizadasRg1.Size = New System.Drawing.Size(125, 20)
        Me.txtAutorizadasRg1.TabIndex = 37
        '
        'lblAutorizadasNome1
        '
        Me.lblAutorizadasNome1.Location = New System.Drawing.Point(50, 94)
        Me.lblAutorizadasNome1.Name = "lblAutorizadasNome1"
        Me.lblAutorizadasNome1.Size = New System.Drawing.Size(27, 13)
        Me.lblAutorizadasNome1.TabIndex = 36
        Me.lblAutorizadasNome1.Text = "Nome"
        '
        'txtAutorizadasNome1
        '
        Me.txtAutorizadasNome1.Location = New System.Drawing.Point(83, 91)
        Me.txtAutorizadasNome1.Name = "txtAutorizadasNome1"
        Me.txtAutorizadasNome1.Size = New System.Drawing.Size(212, 20)
        Me.txtAutorizadasNome1.TabIndex = 35
        '
        'lblTelefone
        '
        Me.lblTelefone.Location = New System.Drawing.Point(366, 16)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(42, 13)
        Me.lblTelefone.TabIndex = 34
        Me.lblTelefone.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone.Location = New System.Drawing.Point(418, 13)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(98, 20)
        Me.txtTelefone.TabIndex = 33
        '
        'lblTempTrab
        '
        Me.lblTempTrab.Location = New System.Drawing.Point(180, 47)
        Me.lblTempTrab.Name = "lblTempTrab"
        Me.lblTempTrab.Size = New System.Drawing.Size(55, 13)
        Me.lblTempTrab.TabIndex = 32
        Me.lblTempTrab.Text = "Temp. Trab"
        '
        'txtTempTrab
        '
        Me.txtTempTrab.Location = New System.Drawing.Point(241, 44)
        Me.txtTempTrab.Name = "txtTempTrab"
        Me.txtTempTrab.Size = New System.Drawing.Size(54, 20)
        Me.txtTempTrab.TabIndex = 31
        '
        'lblFaixaSalarial
        '
        Me.lblFaixaSalarial.Location = New System.Drawing.Point(14, 47)
        Me.lblFaixaSalarial.Name = "lblFaixaSalarial"
        Me.lblFaixaSalarial.Size = New System.Drawing.Size(63, 13)
        Me.lblFaixaSalarial.TabIndex = 30
        Me.lblFaixaSalarial.Text = "Faixa Salarial"
        '
        'txtFaixaSalarial
        '
        Me.txtFaixaSalarial.Location = New System.Drawing.Point(83, 44)
        Me.txtFaixaSalarial.Name = "txtFaixaSalarial"
        Me.txtFaixaSalarial.Size = New System.Drawing.Size(81, 20)
        Me.txtFaixaSalarial.TabIndex = 29
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(36, 16)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(41, 13)
        Me.lblEmpresa.TabIndex = 28
        Me.lblEmpresa.Text = "Empresa"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(83, 13)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(212, 20)
        Me.txtEmpresa.TabIndex = 27
        '
        'tabNfe
        '
        Me.tabNfe.Controls.Add(Me.cboPais)
        Me.tabNfe.Controls.Add(Me.rdgIssRetido)
        Me.tabNfe.Controls.Add(Me.LabelControl6)
        Me.tabNfe.Controls.Add(Me.LabelControl5)
        Me.tabNfe.Controls.Add(Me.txtIm)
        Me.tabNfe.Controls.Add(Me.LabelControl4)
        Me.tabNfe.Controls.Add(Me.txtSuframa)
        Me.tabNfe.Controls.Add(Me.LabelControl3)
        Me.tabNfe.Controls.Add(Me.LabelControl2)
        Me.tabNfe.Controls.Add(Me.txtCodPais)
        Me.tabNfe.Controls.Add(Me.LabelControl1)
        Me.tabNfe.Controls.Add(Me.txtCodMunicipio)
        Me.tabNfe.Name = "tabNfe"
        Me.tabNfe.PageVisible = False
        Me.tabNfe.Size = New System.Drawing.Size(999, 305)
        Me.tabNfe.Text = "NFE"
        '
        'cboPais
        '
        Me.cboPais.Location = New System.Drawing.Point(233, 38)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPais.Properties.Items.AddRange(New Object() {"Brasil"})
        Me.cboPais.Size = New System.Drawing.Size(143, 20)
        Me.cboPais.TabIndex = 62
        '
        'rdgIssRetido
        '
        Me.rdgIssRetido.Location = New System.Drawing.Point(449, 122)
        Me.rdgIssRetido.Name = "rdgIssRetido"
        Me.rdgIssRetido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rdgIssRetido.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "SIM"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "NÃO")})
        Me.rdgIssRetido.Size = New System.Drawing.Size(100, 22)
        Me.rdgIssRetido.TabIndex = 42
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(393, 128)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "ISS Retido"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(431, 99)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "IM"
        '
        'txtIm
        '
        Me.txtIm.Location = New System.Drawing.Point(449, 96)
        Me.txtIm.Name = "txtIm"
        Me.txtIm.Size = New System.Drawing.Size(100, 20)
        Me.txtIm.TabIndex = 20
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(45, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Suframa"
        '
        'txtSuframa
        '
        Me.txtSuframa.Location = New System.Drawing.Point(91, 64)
        Me.txtSuframa.Name = "txtSuframa"
        Me.txtSuframa.Size = New System.Drawing.Size(285, 20)
        Me.txtSuframa.TabIndex = 18
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(208, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "País"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Cód. País"
        '
        'txtCodPais
        '
        Me.txtCodPais.Location = New System.Drawing.Point(91, 38)
        Me.txtCodPais.Name = "txtCodPais"
        Me.txtCodPais.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPais.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Cód. Município"
        '
        'txtCodMunicipio
        '
        Me.txtCodMunicipio.Location = New System.Drawing.Point(91, 12)
        Me.txtCodMunicipio.Name = "txtCodMunicipio"
        Me.txtCodMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtCodMunicipio.TabIndex = 12
        '
        'tabClientes
        '
        Me.tabClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabClientes.Location = New System.Drawing.Point(0, 0)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.SelectedTabPage = Me.XtraTabPage1
        Me.tabClientes.Size = New System.Drawing.Size(1014, 621)
        Me.tabClientes.TabIndex = 9
        Me.tabClientes.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'PrintBarManager1
        '
        Me.PrintBarManager1.DockControls.Add(Me.BarDockControl1)
        Me.PrintBarManager1.DockControls.Add(Me.BarDockControl2)
        Me.PrintBarManager1.DockControls.Add(Me.BarDockControl3)
        Me.PrintBarManager1.DockControls.Add(Me.BarDockControl4)
        Me.PrintBarManager1.Form = Me
        Me.PrintBarManager1.ImageStream = CType(resources.GetObject("PrintBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintBarManager1.MaxItemId = 57
        Me.PrintBarManager1.PreviewBar = Nothing
        Me.PrintBarManager1.TransparentEditors = True
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1014, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 661)
        Me.BarDockControl2.Size = New System.Drawing.Size(1014, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(1014, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 661)
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl5)
        Me.BarManager2.DockControls.Add(Me.BarDockControl6)
        Me.BarManager2.DockControls.Add(Me.BarDockControl7)
        Me.BarManager2.DockControls.Add(Me.BarDockControl8)
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 0
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Size = New System.Drawing.Size(1014, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 661)
        Me.BarDockControl6.Size = New System.Drawing.Size(1014, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 661)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(1014, 0)
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 661)
        '
        'BarManager3
        '
        Me.BarManager3.DockControls.Add(Me.BarDockControl9)
        Me.BarManager3.DockControls.Add(Me.BarDockControl10)
        Me.BarManager3.DockControls.Add(Me.BarDockControl11)
        Me.BarManager3.DockControls.Add(Me.BarDockControl12)
        Me.BarManager3.Form = Me
        Me.BarManager3.MaxItemId = 0
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl9.Size = New System.Drawing.Size(1014, 0)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 661)
        Me.BarDockControl10.Size = New System.Drawing.Size(1014, 0)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl11.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 661)
        '
        'BarDockControl12
        '
        Me.BarDockControl12.CausesValidation = False
        Me.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl12.Location = New System.Drawing.Point(1014, 0)
        Me.BarDockControl12.Size = New System.Drawing.Size(0, 661)
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 661)
        Me.Controls.Add(Me.tabClientes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl12)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Name = "frmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCliente"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.grpRodapeClientesCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRodapeClientesCadastrados.ResumeLayout(False)
        Me.grpRodapeClientesCadastrados.PerformLayout()
        CType(Me.cboAniverMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClientesCadastrados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDesign3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDesign2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDesign1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpClientecadastro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClientecadastro.ResumeLayout(False)
        CType(Me.grdClientesCad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGeral.ResumeLayout(False)
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPrincipal.PerformLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNascim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNascim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpObservacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObservacoes.ResumeLayout(False)
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPendencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memObservacoes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEndereco.ResumeLayout(False)
        Me.tabCliente.ResumeLayout(False)
        Me.tabCliente.PerformLayout()
        CType(Me.cboClienteBairro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteUf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteEndereco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpfCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRgIe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFantasia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeRazao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabComplementos.ResumeLayout(False)
        Me.tabComplementos.PerformLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtDiasAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDevedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUltVisita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimAtual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCadastro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDataFatura.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDataFatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoradia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit36.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit37.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConjugeNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConjugeTelefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizadasNome2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizadasRg2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizadasRg1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizadasNome1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTempTrab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaixaSalarial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNfe.ResumeLayout(False)
        Me.tabNfe.PerformLayout()
        CType(Me.cboPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgIssRetido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuframa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClientes.ResumeLayout(False)
        CType(Me.PrintBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnExclui As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabClientes As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabGeral As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPrincipal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSexo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSexo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtNascim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grpObservacoes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkInativo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPendencia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents memObservacoes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblContato As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTelefone3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefone3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefone2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTelefone2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdgCpfCnpj As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTelefone1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefone1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabEndereco As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCliente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboClienteBairro As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboClienteCidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboClienteUf As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblClienteBairro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblClienteCidade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblClienteUf As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblClienteComp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteComp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblClienteEndereco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteEndereco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblClienteNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblClienteCep As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteCep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabEnderecoEntrega As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCpfCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRgIe As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRgIe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNascim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFantasia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFantasia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNomeRazao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNomeRazao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabComplementos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExcluirCredDev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsumo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVendas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiasAtraso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLimCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoDevedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblultVisita As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUltVisita As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLimAtual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCompras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCadastro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCadastro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtDataFatura As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMoradia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMoradia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit36 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit37 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBancoContaCorrente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContaCorrente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBancoBanco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBancoAgencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblConjugeNome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConjugeNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblConjugeTelefone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConjugeTelefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAutorizadasNome2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizadasNome2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAutorizadasRg2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizadasRg2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAutorizadasRg1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizadasRg1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAutorizadasNome1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAutorizadasNome1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTelefone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTempTrab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTempTrab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFaixaSalarial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFaixaSalarial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEmpresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabNfe As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboPais As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents rdgIssRetido As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSuframa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodPais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpClientecadastro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdClientesCad As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRGIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboModelo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblModelo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Friend WithEvents RepositoryItemFontEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Friend WithEvents grpRodapeClientesCadastrados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PrintBarManager1 As DevExpress.XtraPrinting.Preview.PrintBarManager
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl12 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager3 As DevExpress.XtraBars.BarManager
    Friend WithEvents DsTelaUsuario As telausuario.dsTelaUsuario
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As telausuario.dsTelaUsuarioTableAdapters.ClienteTableAdapter
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAddFrete As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnFIltrar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnVisualizar2 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents pnlDesign2 As DevExpress.XtraEditors.PanelControl
    Private WithEvents pnlDesign1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents pnlDesign3 As DevExpress.XtraEditors.PanelControl
    Private WithEvents lblClientesCadastrados As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtClientesCadastrados As DevExpress.XtraEditors.TextEdit
    Private WithEvents lblAniverMes As DevExpress.XtraEditors.LabelControl
    Private WithEvents cboAniverMes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnPesquisarCpfCnpj As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscaCep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
