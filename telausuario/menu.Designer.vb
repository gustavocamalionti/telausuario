<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCadCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEstoque = New DevExpress.XtraBars.BarSubItem()
        Me.btnCadastrarProduto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPedidos = New DevExpress.XtraBars.BarSubItem()
        Me.btnCadastrarPedido = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConsultarPedido = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnCadastrarUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBloquearUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.princ = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Principal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCadCliente, Me.btnEstoque, Me.btnCadastrarProduto, Me.btnPedidos, Me.btnCadastrarPedido, Me.BarStaticItem1, Me.BarStaticItem2, Me.btnConsultarPedido, Me.BarButtonItem1, Me.btnCadastrarUsuario, Me.btnBloquearUsuario})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 128
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.princ})
        Me.RibbonControl.Size = New System.Drawing.Size(436, 145)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnCadastrarUsuario)
        Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnBloquearUsuario)
        Me.RibbonControl.TransparentEditors = True
        '
        'btnCadCliente
        '
        Me.btnCadCliente.Caption = "Cadastro de Clientes"
        Me.btnCadCliente.Id = 3
        Me.btnCadCliente.LargeGlyph = Global.telausuario.My.Resources.Resources.cli_ente
        Me.btnCadCliente.Name = "btnCadCliente"
        '
        'btnEstoque
        '
        Me.btnEstoque.Caption = "Estoque"
        Me.btnEstoque.Id = 118
        Me.btnEstoque.LargeGlyph = Global.telausuario.My.Resources.Resources.blockdevice
        Me.btnEstoque.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCadastrarProduto)})
        Me.btnEstoque.Name = "btnEstoque"
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.Caption = "Cadastrar Produto"
        Me.btnCadastrarProduto.Glyph = Global.telausuario.My.Resources.Resources.blockdevice
        Me.btnCadastrarProduto.Id = 119
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        '
        'btnPedidos
        '
        Me.btnPedidos.Caption = "Pedidos"
        Me.btnPedidos.Id = 120
        Me.btnPedidos.LargeGlyph = Global.telausuario.My.Resources.Resources.playlist50
        Me.btnPedidos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCadastrarPedido, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnConsultarPedido, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.btnPedidos.Name = "btnPedidos"
        '
        'btnCadastrarPedido
        '
        Me.btnCadastrarPedido.Caption = "Cadastrar"
        Me.btnCadastrarPedido.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.btnCadastrarPedido.Id = 121
        Me.btnCadastrarPedido.LargeGlyph = Global.telausuario.My.Resources.Resources.apply18x18
        Me.btnCadastrarPedido.Name = "btnCadastrarPedido"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Alterar"
        Me.BarButtonItem1.Glyph = Global.telausuario.My.Resources.Resources.Alterar
        Me.BarButtonItem1.Id = 125
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnConsultarPedido
        '
        Me.btnConsultarPedido.Caption = "Consultar"
        Me.btnConsultarPedido.Glyph = Global.telausuario.My.Resources.Resources.viewmag
        Me.btnConsultarPedido.Id = 124
        Me.btnConsultarPedido.Name = "btnConsultarPedido"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "TesteBarStatic"
        Me.BarStaticItem1.Id = 122
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "testeBarStatic2"
        Me.BarStaticItem2.Id = 123
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnCadastrarUsuario
        '
        Me.btnCadastrarUsuario.Caption = "btnCadastrarUsuario"
        Me.btnCadastrarUsuario.Glyph = Global.telausuario.My.Resources.Resources.Usu
        Me.btnCadastrarUsuario.Id = 126
        Me.btnCadastrarUsuario.Name = "btnCadastrarUsuario"
        '
        'btnBloquearUsuario
        '
        Me.btnBloquearUsuario.Caption = "BarButtonItem2"
        Me.btnBloquearUsuario.Glyph = Global.telausuario.My.Resources.Resources.cadeado
        Me.btnBloquearUsuario.Id = 127
        Me.btnBloquearUsuario.Name = "btnBloquearUsuario"
        '
        'princ
        '
        Me.princ.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.Principal})
        Me.princ.Name = "princ"
        '
        'Principal
        '
        Me.Principal.ItemLinks.Add(Me.btnCadCliente)
        Me.Principal.ItemLinks.Add(Me.btnEstoque)
        Me.Principal.ItemLinks.Add(Me.btnPedidos)
        Me.Principal.Name = "Principal"
        Me.Principal.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 417)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(436, 32)
        Me.RibbonStatusBar.ToolTipController = Me.ToolTipController1
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Active = False
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmMenu"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Menu Principal"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents princ As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Principal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCadCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstoque As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnCadastrarProduto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPedidos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnCadastrarPedido As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnConsultarPedido As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCadastrarUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBloquearUsuario As DevExpress.XtraBars.BarButtonItem


End Class
