<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOrdem
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterarGrid = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodOrdens = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdConsultaPedidos = New DevExpress.XtraGrid.GridControl()
        Me.dsConsultaPedidos = New System.Data.DataSet()
        Me.tbConsultaPedidos = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.d = New System.Data.DataColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdConsultaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsConsultaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbConsultaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnVisualizar, Me.btnOk, Me.btnFechar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "Visualizar"
        Me.btnVisualizar.Glyph = Global.telausuario.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 0
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "Ok"
        Me.btnOk.Glyph = Global.telausuario.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnOk.Id = 1
        Me.btnOk.Name = "btnOk"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(703, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 289)
        Me.barDockControlBottom.Size = New System.Drawing.Size(703, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 289)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(703, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 289)
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStatus, Me.colData, Me.colDescricao, Me.colNome, Me.colCodOrdens, Me.colTotal})
        StyleFormatCondition1.Tag = ""
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.grdConsultaPedidos
        Me.grd1.Name = "grd1"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status Sistema"
        Me.colStatus.ColumnEdit = Me.txtAlterarGrid
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 0
        '
        'txtAlterarGrid
        '
        Me.txtAlterarGrid.AutoHeight = False
        Me.txtAlterarGrid.Name = "txtAlterarGrid"
        '
        'colData
        '
        Me.colData.ColumnEdit = Me.txtAlterarGrid
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Observação"
        Me.colDescricao.ColumnEdit = Me.txtAlterarGrid
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 2
        '
        'colNome
        '
        Me.colNome.Caption = "Cliente"
        Me.colNome.ColumnEdit = Me.txtAlterarGrid
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 3
        '
        'colCodOrdens
        '
        Me.colCodOrdens.Caption = "N° Ped"
        Me.colCodOrdens.ColumnEdit = Me.txtAlterarGrid
        Me.colCodOrdens.FieldName = "CodOrdens"
        Me.colCodOrdens.Name = "colCodOrdens"
        Me.colCodOrdens.Visible = True
        Me.colCodOrdens.VisibleIndex = 4
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total R$"
        Me.colTotal.ColumnEdit = Me.txtAlterarGrid
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        '
        'grdConsultaPedidos
        '
        Me.grdConsultaPedidos.DataMember = "tbConsultaPedidos"
        Me.grdConsultaPedidos.DataSource = Me.dsConsultaPedidos
        Me.grdConsultaPedidos.Location = New System.Drawing.Point(0, -1)
        Me.grdConsultaPedidos.MainView = Me.grd1
        Me.grdConsultaPedidos.Name = "grdConsultaPedidos"
        Me.grdConsultaPedidos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarGrid})
        Me.grdConsultaPedidos.Size = New System.Drawing.Size(703, 290)
        Me.grdConsultaPedidos.TabIndex = 0
        Me.grdConsultaPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsConsultaPedidos
        '
        Me.dsConsultaPedidos.DataSetName = "dsConsultaPedidos"
        Me.dsConsultaPedidos.Tables.AddRange(New System.Data.DataTable() {Me.tbConsultaPedidos})
        '
        'tbConsultaPedidos
        '
        Me.tbConsultaPedidos.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.d})
        Me.tbConsultaPedidos.TableName = "tbConsultaPedidos"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Status"
        Me.DataColumn1.ColumnName = "Status"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Data"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Descricao"
        Me.DataColumn3.ColumnName = "Descricao"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Nome"
        Me.DataColumn4.ColumnName = "Nome"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "CodOrdens"
        Me.DataColumn5.ColumnName = "CodOrdens"
        '
        'd
        '
        Me.d.Caption = "Total"
        Me.d.ColumnName = "Total"
        '
        'frmConsultaOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 324)
        Me.Controls.Add(Me.grdConsultaPedidos)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmConsultaOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pedidos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdConsultaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsConsultaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbConsultaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdConsultaPedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsConsultaPedidos As System.Data.DataSet
    Friend WithEvents tbConsultaPedidos As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents d As System.Data.DataColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdens As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterarGrid As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
