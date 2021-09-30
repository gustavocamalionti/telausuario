<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCliente
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relCliente))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer()
        Me.grdClientesCad = New DevExpress.XtraGrid.GridControl()
        Me.dsCliente = New System.Data.DataSet()
        Me.tbClientes = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colNumero1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.lblRelatorioCliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgCliente = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.linbottom = New DevExpress.XtraReports.UI.XRLine()
        Me.lintop = New DevExpress.XtraReports.UI.XRLine()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.grdClientesCad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer2})
        Me.Detail.HeightF = 286.0416!
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003973643!, 0.0!)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.SizeF = New System.Drawing.SizeF(820.0!, 276.0416!)
        Me.WinControlContainer2.WinControl = Me.grdClientesCad
        '
        'grdClientesCad
        '
        Me.grdClientesCad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClientesCad.DataMember = "tbClientes"
        Me.grdClientesCad.DataSource = Me.dsCliente
        Me.grdClientesCad.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.grdClientesCad.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grdClientesCad.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        GridLevelNode1.RelationName = "Level1"
        Me.grdClientesCad.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grdClientesCad.Location = New System.Drawing.Point(2, 24)
        Me.grdClientesCad.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.grdClientesCad.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdClientesCad.MainView = Me.grd1
        Me.grdClientesCad.Name = "grdClientesCad"
        Me.grdClientesCad.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.AlterarGrid})
        Me.grdClientesCad.Size = New System.Drawing.Size(787, 265)
        Me.grdClientesCad.TabIndex = 78
        Me.grdClientesCad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCliente
        '
        Me.dsCliente.DataSetName = "dsCliente"
        Me.dsCliente.Tables.AddRange(New System.Data.DataTable() {Me.tbClientes})
        '
        'tbClientes
        '
        Me.tbClientes.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.tbClientes.TableName = "tbClientes"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Nome"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Endereco"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "RgIe"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CPF"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Numero"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Bairro"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Cidade"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Telefone"
        '
        'grd1
        '
        Me.grd1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White
        Me.grd1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grd1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.GridColumn2, Me.colCPF, Me.GridColumn3, Me.colNumero, Me.colComplemento, Me.colBairro, Me.colCep, Me.GridColumn5, Me.colEstado, Me.colTelefone, Me.colFax, Me.colCelular, Me.colEmail, Me.colData, Me.colFantasia, Me.colObservacao, Me.colStatus, Me.colSexo, Me.colInativo, Me.colContato, Me.colNumero1})
        Me.grd1.GridControl = Me.grdClientesCad
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.RowAutoHeight = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNumero1, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.Red
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.AlterarGrid
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 53
        '
        'AlterarGrid
        '
        Me.AlterarGrid.AutoHeight = False
        Me.AlterarGrid.Name = "AlterarGrid"
        '
        'colNome
        '
        Me.colNome.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceCell.Options.UseBackColor = True
        Me.colNome.AppearanceCell.Options.UseTextOptions = True
        Me.colNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNome.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.Options.UseBackColor = True
        Me.colNome.ColumnEdit = Me.AlterarGrid
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 0
        Me.colNome.Width = 378
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn2.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn2.ColumnEdit = Me.AlterarGrid
        Me.GridColumn2.FieldName = "RGIE"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 185
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceCell.Options.UseBackColor = True
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.ColumnEdit = Me.AlterarGrid
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 1
        Me.colCPF.Width = 249
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn3.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn3.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn3.ColumnEdit = Me.AlterarGrid
        Me.GridColumn3.FieldName = "Endereco"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Width = 208
        '
        'colNumero
        '
        Me.colNumero.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colNumero.AppearanceCell.Options.UseBackColor = True
        Me.colNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colNumero.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumero.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colNumero.AppearanceHeader.Options.UseBackColor = True
        Me.colNumero.ColumnEdit = Me.AlterarGrid
        Me.colNumero.FieldName = "N°"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 30
        '
        'colComplemento
        '
        Me.colComplemento.AppearanceCell.Options.UseTextOptions = True
        Me.colComplemento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colComplemento.ColumnEdit = Me.AlterarGrid
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Width = 271
        '
        'colBairro
        '
        Me.colBairro.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colBairro.AppearanceCell.Options.UseBackColor = True
        Me.colBairro.AppearanceCell.Options.UseTextOptions = True
        Me.colBairro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colBairro.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colBairro.AppearanceHeader.Options.UseBackColor = True
        Me.colBairro.ColumnEdit = Me.AlterarGrid
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.ReadOnly = True
        Me.colBairro.Width = 130
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
        Me.colCep.Width = 123
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.GridColumn5.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.GridColumn5.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn5.ColumnEdit = Me.AlterarGrid
        Me.GridColumn5.FieldName = "Cidade"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 265
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.ColumnEdit = Me.AlterarGrid
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Width = 86
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colTelefone.AppearanceCell.Options.UseBackColor = True
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTelefone.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTelefone.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colTelefone.AppearanceHeader.Options.UseBackColor = True
        Me.colTelefone.ColumnEdit = Me.AlterarGrid
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 3
        Me.colTelefone.Width = 104
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.ReadOnly = True
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
        Me.colContato.Width = 105
        '
        'colNumero1
        '
        Me.colNumero1.FieldName = "Numero"
        Me.colNumero1.Name = "colNumero1"
        Me.colNumero1.Width = 67
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblRelatorioCliente, Me.imgCliente, Me.linbottom, Me.lintop})
        Me.TopMargin.HeightF = 117.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblRelatorioCliente
        '
        Me.lblRelatorioCliente.AutoWidth = True
        Me.lblRelatorioCliente.Font = New System.Drawing.Font("Calibri", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelatorioCliente.LocationFloat = New DevExpress.Utils.PointFloat(263.5417!, 36.41667!)
        Me.lblRelatorioCliente.Name = "lblRelatorioCliente"
        Me.lblRelatorioCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRelatorioCliente.SizeF = New System.Drawing.SizeF(314.5833!, 45.95833!)
        Me.lblRelatorioCliente.StylePriority.UseFont = False
        Me.lblRelatorioCliente.Text = "RELATÓRIO DE CLIENTES"
        '
        'imgCliente
        '
        Me.imgCliente.Image = CType(resources.GetObject("imgCliente.Image"), System.Drawing.Image)
        Me.imgCliente.LocationFloat = New DevExpress.Utils.PointFloat(165.2083!, 23.0!)
        Me.imgCliente.Name = "imgCliente"
        Me.imgCliente.SizeF = New System.Drawing.SizeF(70.83334!, 70.83334!)
        Me.imgCliente.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'linbottom
        '
        Me.linbottom.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 93.83334!)
        Me.linbottom.Name = "linbottom"
        Me.linbottom.SizeF = New System.Drawing.SizeF(820.0!, 23.0!)
        '
        'lintop
        '
        Me.lintop.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.lintop.Name = "lintop"
        Me.lintop.SizeF = New System.Drawing.SizeF(820.0!, 23.0!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 7.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relCliente
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(15, 15, 117, 7)
        Me.Version = "12.2"
        CType(Me.grdClientesCad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents lblRelatorioCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents imgCliente As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents linbottom As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lintop As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents grdClientesCad As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents dsCliente As System.Data.DataSet
    Friend WithEvents tbClientes As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colNumero1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
