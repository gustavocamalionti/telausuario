﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.grpUsuariosCadastrados = New DevExpress.XtraEditors.GroupControl()
        Me.DsTelaUsuario = New telausuario.dsTelaUsuario()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager()
        Me.grdUsuariosCadastrados = New DevExpress.XtraGrid.GridControl()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUsuariosCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUsuariosCadastrados.SuspendLayout()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUsuariosCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarButtonItem1.Caption = "Excluir"
        Me.BarButtonItem1.Glyph = Global.telausuario.My.Resources.Resources.delete
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem2.Caption = "Salvar"
        Me.BarButtonItem2.Glyph = Global.telausuario.My.Resources.Resources.Comando_Gravar_32x32
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem3.Caption = "Alterar"
        Me.BarButtonItem3.Glyph = Global.telausuario.My.Resources.Resources.Alterar
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem4.Caption = "Limpar"
        Me.BarButtonItem4.Glyph = Global.telausuario.My.Resources.Resources.Comando_Limpar_32x32
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem5.Caption = "Fechar"
        Me.BarButtonItem5.Glyph = Global.telausuario.My.Resources.Resources.Comando_Fechar_32x32
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(494, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 433)
        Me.barDockControlBottom.Size = New System.Drawing.Size(494, 35)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(494, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 433)
        '
        'grpUsuariosCadastrados
        '
        Me.grpUsuariosCadastrados.Controls.Add(Me.grdUsuariosCadastrados)
        Me.grpUsuariosCadastrados.Location = New System.Drawing.Point(0, 178)
        Me.grpUsuariosCadastrados.Name = "grpUsuariosCadastrados"
        Me.grpUsuariosCadastrados.Size = New System.Drawing.Size(494, 255)
        Me.grpUsuariosCadastrados.TabIndex = 4
        Me.grpUsuariosCadastrados.Text = "Usuários Cadastrados"
        '
        'DsTelaUsuario
        '
        Me.DsTelaUsuario.DataSetName = "dsTelaUsuario"
        Me.DsTelaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DsTelaUsuario
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
        'grdUsuariosCadastrados
        '
        Me.grdUsuariosCadastrados.DataSource = Me.UsuarioBindingSource
        Me.grdUsuariosCadastrados.Location = New System.Drawing.Point(0, 24)
        Me.grdUsuariosCadastrados.MainView = Me.grd1
        Me.grdUsuariosCadastrados.MenuManager = Me.BarManager1
        Me.grdUsuariosCadastrados.Name = "grdUsuariosCadastrados"
        Me.grdUsuariosCadastrados.Size = New System.Drawing.Size(494, 241)
        Me.grdUsuariosCadastrados.TabIndex = 0
        Me.grdUsuariosCadastrados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
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
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colLogin
        '
        Me.colLogin.AppearanceCell.Options.UseTextOptions = True
        Me.colLogin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLogin.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
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
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(111, 12)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(39, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "LabelControl1"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(108, 116)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEdit1.TabIndex = 11
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(108, 87)
        Me.RadioGroup1.MenuManager = Me.BarManager1
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "USUÁRIO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "ADMINISTRADOR"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "MASTER")})
        Me.RadioGroup1.Size = New System.Drawing.Size(374, 23)
        Me.RadioGroup1.TabIndex = 12
        '
        'frmCadUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 468)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.grpUsuariosCadastrados)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCadUsuario"
        Me.Text = "Cadastrar Usuário"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUsuariosCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUsuariosCadastrados.ResumeLayout(False)
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUsuariosCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpUsuariosCadastrados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTelaUsuario As telausuario.dsTelaUsuario
    Friend WithEvents UsuarioTableAdapter As telausuario.dsTelaUsuarioTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
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
End Class
