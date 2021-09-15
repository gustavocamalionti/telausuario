<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim lblEmpresa As System.Windows.Forms.Label
        Dim lblCnpj As System.Windows.Forms.Label
        Dim lblVersaoNano As System.Windows.Forms.Label
        Dim lblTelefone As System.Windows.Forms.Label
        Dim lblEndereco As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.DsTelaUsuario = New telausuario.dsTelaUsuario()
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfigTableAdapter = New telausuario.dsTelaUsuarioTableAdapters.ConfigTableAdapter()
        Me.TableAdapterManager = New telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager()
        Me.ConfigBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.txtCnpj = New DevExpress.XtraEditors.TextEdit()
        Me.txtVersaoNano = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefone = New DevExpress.XtraEditors.TextEdit()
        Me.txtEndereco = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        lblEmpresa = New System.Windows.Forms.Label()
        lblCnpj = New System.Windows.Forms.Label()
        lblVersaoNano = New System.Windows.Forms.Label()
        lblTelefone = New System.Windows.Forms.Label()
        lblEndereco = New System.Windows.Forms.Label()
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfigBindingNavigator.SuspendLayout()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersaoNano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndereco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        lblEmpresa.AutoSize = True
        lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEmpresa.Location = New System.Drawing.Point(56, 44)
        lblEmpresa.Name = "lblEmpresa"
        lblEmpresa.Size = New System.Drawing.Size(72, 18)
        lblEmpresa.TabIndex = 3
        lblEmpresa.Text = "Empresa:"
        '
        'lblCnpj
        '
        lblCnpj.AutoSize = True
        lblCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCnpj.Location = New System.Drawing.Point(76, 74)
        lblCnpj.Name = "lblCnpj"
        lblCnpj.Size = New System.Drawing.Size(52, 18)
        lblCnpj.TabIndex = 5
        lblCnpj.Text = "CNPJ:"
        '
        'lblVersaoNano
        '
        lblVersaoNano.AutoSize = True
        lblVersaoNano.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblVersaoNano.Location = New System.Drawing.Point(29, 104)
        lblVersaoNano.Name = "lblVersaoNano"
        lblVersaoNano.Size = New System.Drawing.Size(99, 18)
        lblVersaoNano.TabIndex = 7
        lblVersaoNano.Text = "Versao Nano:"
        '
        'lblTelefone
        '
        lblTelefone.AutoSize = True
        lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTelefone.Location = New System.Drawing.Point(59, 134)
        lblTelefone.Name = "lblTelefone"
        lblTelefone.Size = New System.Drawing.Size(69, 18)
        lblTelefone.TabIndex = 9
        lblTelefone.Text = "Telefone:"
        '
        'lblEndereco
        '
        lblEndereco.AutoSize = True
        lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEndereco.Location = New System.Drawing.Point(52, 164)
        lblEndereco.Name = "lblEndereco"
        lblEndereco.Size = New System.Drawing.Size(76, 18)
        lblEndereco.TabIndex = 11
        lblEndereco.Text = "Endereco:"
        '
        'DsTelaUsuario
        '
        Me.DsTelaUsuario.DataSetName = "dsTelaUsuario"
        Me.DsTelaUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsTelaUsuario
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AjusteQtdeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager.EntradaNfTableAdapter = Nothing
        Me.TableAdapterManager.ItensConsigTableAdapter = Nothing
        Me.TableAdapterManager.OrdensTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.QtdeTableAdapter = Nothing
        Me.TableAdapterManager.TotalConsigTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'ConfigBindingNavigator
        '
        Me.ConfigBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConfigBindingNavigator.BindingSource = Me.ConfigBindingSource
        Me.ConfigBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConfigBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConfigBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConfigBindingNavigatorSaveItem})
        Me.ConfigBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConfigBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConfigBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConfigBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConfigBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConfigBindingNavigator.Name = "ConfigBindingNavigator"
        Me.ConfigBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConfigBindingNavigator.Size = New System.Drawing.Size(385, 25)
        Me.ConfigBindingNavigator.TabIndex = 0
        Me.ConfigBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ConfigBindingNavigatorSaveItem
        '
        Me.ConfigBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfigBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConfigBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConfigBindingNavigatorSaveItem.Name = "ConfigBindingNavigatorSaveItem"
        Me.ConfigBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConfigBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Empresa", True))
        Me.txtEmpresa.EnterMoveNextControl = True
        Me.txtEmpresa.Location = New System.Drawing.Point(134, 41)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtEmpresa.Properties.Appearance.Options.UseFont = True
        Me.txtEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa.Size = New System.Drawing.Size(203, 24)
        Me.txtEmpresa.TabIndex = 1
        '
        'txtCnpj
        '
        Me.txtCnpj.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CNPJ", True))
        Me.txtCnpj.EnterMoveNextControl = True
        Me.txtCnpj.Location = New System.Drawing.Point(134, 71)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtCnpj.Properties.Appearance.Options.UseFont = True
        Me.txtCnpj.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCnpj.Size = New System.Drawing.Size(203, 24)
        Me.txtCnpj.TabIndex = 2
        '
        'txtVersaoNano
        '
        Me.txtVersaoNano.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "VersaoNano", True))
        Me.txtVersaoNano.Enabled = False
        Me.txtVersaoNano.EnterMoveNextControl = True
        Me.txtVersaoNano.Location = New System.Drawing.Point(134, 101)
        Me.txtVersaoNano.Name = "txtVersaoNano"
        Me.txtVersaoNano.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtVersaoNano.Properties.Appearance.Options.UseFont = True
        Me.txtVersaoNano.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVersaoNano.Size = New System.Drawing.Size(203, 24)
        Me.txtVersaoNano.TabIndex = 3
        '
        'txtTelefone
        '
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Telefone", True))
        Me.txtTelefone.EnterMoveNextControl = True
        Me.txtTelefone.Location = New System.Drawing.Point(134, 131)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtTelefone.Properties.Appearance.Options.UseFont = True
        Me.txtTelefone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone.Size = New System.Drawing.Size(203, 24)
        Me.txtTelefone.TabIndex = 4
        '
        'txtEndereco
        '
        Me.txtEndereco.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Endereco", True))
        Me.txtEndereco.EnterMoveNextControl = True
        Me.txtEndereco.Location = New System.Drawing.Point(134, 161)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtEndereco.Properties.Appearance.Options.UseFont = True
        Me.txtEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Size = New System.Drawing.Size(203, 24)
        Me.txtEndereco.TabIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "Salvar "
        Me.BarButtonItem1.Glyph = Global.telausuario.My.Resources.Resources.apply
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Fechar"
        Me.BarButtonItem2.Glyph = Global.telausuario.My.Resources.Resources.delete
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(385, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 229)
        Me.barDockControlBottom.Size = New System.Drawing.Size(385, 41)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 229)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(385, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 229)
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 270)
        Me.Controls.Add(lblEmpresa)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(lblCnpj)
        Me.Controls.Add(Me.txtCnpj)
        Me.Controls.Add(lblVersaoNano)
        Me.Controls.Add(Me.txtVersaoNano)
        Me.Controls.Add(lblTelefone)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(lblEndereco)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.ConfigBindingNavigator)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmConfig"
        Me.Text = "Config"
        CType(Me.DsTelaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfigBindingNavigator.ResumeLayout(False)
        Me.ConfigBindingNavigator.PerformLayout()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersaoNano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndereco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsTelaUsuario As telausuario.dsTelaUsuario
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As telausuario.dsTelaUsuarioTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager As telausuario.dsTelaUsuarioTableAdapters.TableAdapterManager
    Friend WithEvents ConfigBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfigBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVersaoNano As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEndereco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
