Imports telausuario.clsFuncao
Public Class frmCadProdutos
    Dim bolStatusAlteracao As Boolean
    Dim intCodigoProduto As Integer
    Dim dblResultado As Double

    Private Sub frmCadProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        AtualizarGrid()

        If Me.Tag = "ConsultarProdutoRemover" Then
            Me.grdQtde.Visible = False
            Me.colAlterarPreco.Visible = False
            Me.colLocacao.Visible = False
            Me.colComissao.Visible = False
            Me.colCusto.Visible = False
            Me.colVenda.Visible = False
            Me.colQtd1.Visible = False
            Me.colDesconto.Visible = False
            Me.colObservacao.Visible = False
            Me.colAlterarPreco.Visible = False
            Me.colDuplicar.Visible = False
            Me.colTribPadrao.Visible = False
            Me.colInativo.Visible = False
            Me.colLote1.Visible = False
            Me.colCodBarra.Visible = False
            Me.colQtd1.Visible = False
            Me.colAcabou1.Visible = False
            Me.colLote1.Visible = False
            Me.colCodConfig1.Visible = False
            Me.colDataFim1.Visible = False
            Me.colCor1.Visible = False
            Me.colEmFalta1.Visible = False
            Me.colValorCusto1.Visible = False
            Me.colqtdeMaxima1.Visible = False
            Me.colCodProd1.Visible = False
            Me.colTamanho1.Visible = False
            Me.grd2.OptionsView.ColumnAutoWidth = True
            Me.btnLimparBusca.Visible = False
            Me.cboBuscarProd.Visible = False

        ElseIf Me.Tag = "ConsultarProdutoAdicionar" Then
            Me.txtCodigoInterno.Visible = True
            Me.grdQtde.Visible = True
            Me.colAlterarPreco.Visible = True
            Me.colLocacao.Visible = True
            Me.colComissao.Visible = True
            Me.colCusto.Visible = True
            Me.colVenda.Visible = True
            Me.colQtd1.Visible = True
            Me.colDesconto.Visible = True
            Me.colObservacao.Visible = True
            Me.colAlterarPreco.Visible = True
            Me.colDuplicar.Visible = True
            Me.colTribPadrao.Visible = True
            Me.colInativo.Visible = True
            Me.colLote1.Visible = True
            Me.colCodBarra.Visible = True
            Me.colQtd1.Visible = True
            Me.colAcabou1.Visible = True
            Me.colLote1.Visible = True
            Me.colCodConfig1.Visible = True
            Me.colDataFim1.Visible = True
            Me.colCor1.Visible = True
            Me.colEmFalta1.Visible = True
            Me.colValorCusto1.Visible = True
            Me.colqtdeMaxima1.Visible = True
            Me.colCodProd1.Visible = True
            Me.colTamanho1.Visible = True
            Me.btnLimparBusca.Visible = True
            Me.cboBuscarProd.Visible = True
            Me.cboBuscarProd.Text = NomeProduto

            Me.grd2.OptionsView.ColumnAutoWidth = False


            CarregarDados("select P.Codigo, P.CodigoInterno, P.CodFor, P.CodBarra, P.Produto, P.Setor, P.Grupo, P.Fornecedor, P.Familia, P.UnidMed, P.Tipo, " & _
                      "P.Locacao, P.Comissao, P.Custo, P.Venda, ((select case when sum(qtd) is null then 0 else sum(qtd) end from Entradanf " & _
                      "where entradanf.codprod = P.codigo) - (select case when sum(qtd) is null then 0 else sum(qtd) end from Pedido " & _
                      "where Pedido.codprod = P.codigo) + (select case when sum(qtd) is null then 0 else sum(qtd) end from AjusteQtde " & _
                      "where AjusteQtde.codprod = P.codigo)) as Qtd,  P.Desconto, P.Observacao, P.AlterarPreco, P.Duplicar, P.TribPadrao, " & _
                      "P.Inativo, Q.Tamanho, Q.Cor, Q.Lote from Produtos as P left join Qtde as Q on Q.CodProd = P.Codigo where P.Produto like '%" & NomeProduto & "%';", grdProdCadastrados)

        Else
            Me.txtCodigoInterno.Visible = True
            Me.grdQtde.Visible = True
            Me.colAlterarPreco.Visible = True
            Me.colLocacao.Visible = True
            Me.colComissao.Visible = True
            Me.colCusto.Visible = True
            Me.colVenda.Visible = True
            Me.colQtd1.Visible = True
            Me.colDesconto.Visible = True
            Me.colObservacao.Visible = True
            Me.colAlterarPreco.Visible = True
            Me.colDuplicar.Visible = True
            Me.colTribPadrao.Visible = True
            Me.colInativo.Visible = True
            Me.colLote1.Visible = True
            Me.colCodBarra.Visible = True
            Me.colQtd1.Visible = True
            Me.colAcabou1.Visible = True
            Me.colLote1.Visible = True
            Me.colCodConfig1.Visible = True
            Me.colDataFim1.Visible = True
            Me.colCor1.Visible = True
            Me.colEmFalta1.Visible = True
            Me.colValorCusto1.Visible = True
            Me.colqtdeMaxima1.Visible = True
            Me.colCodProd1.Visible = True
            Me.colTamanho1.Visible = True
            Me.btnLimparBusca.Visible = False
            Me.cboBuscarProd.Visible = False

            Me.grd2.OptionsView.ColumnAutoWidth = False
        End If

    End Sub

    Private Sub AtualizarGrid()
        If Me.Tag = "ConsultarProdutoRemover" Then
            CarregarDados("select P.Codigo, P.CodigoInterno, P.Produto, P.Setor, P.Grupo, P.Fornecedor, P.Familia, P.UnidMed, P.Tipo " & _
                      "from Produtos as P left join Qtde as Q on Q.CodProd = P.Codigo order by P.Produto;", grdProdCadastrados)

        Else
            CarregarDados("select P.Codigo, P.CodigoInterno, P.CodFor, P.CodBarra, P.Produto, P.Setor, P.Grupo, P.Fornecedor, P.Familia, P.UnidMed, P.Tipo, " & _
                      "P.Locacao, P.Comissao, P.Custo, P.Venda, ((select case when sum(qtd) is null then 0 else sum(qtd) end from Entradanf " & _
                      "where entradanf.codprod = P.codigo) - (select case when sum(qtd) is null then 0 else sum(qtd) end from Pedido " & _
                      "where Pedido.codprod = P.codigo) + (select case when sum(qtd) is null then 0 else sum(qtd) end from AjusteQtde " & _
                      "where AjusteQtde.codprod = P.codigo)) as Qtd,  P.Desconto, P.Observacao, P.AlterarPreco, P.Duplicar, P.TribPadrao, " & _
                      "P.Inativo, Q.Tamanho, Q.Cor, Q.Lote from Produtos as P left join Qtde as Q on Q.CodProd = P.Codigo;", grdProdCadastrados)
        End If

    End Sub

    Private Sub Limpar()

        Me.tbQtd.Rows.Clear()
        Me.tbQtd.Rows.Add()
        Me.tbQtd.Rows.Item(0).Item("Tamanho") = ""
        Me.tbQtd.Rows.Item(0).Item("Cor") = ""
        Me.tbQtd.Rows.Item(0).Item("Qtd") = ""
        Me.tbQtd.Rows.Item(0).Item("Lote") = ""

        bolStatusAlteracao = False
        intCodigoProduto = 0
        dblResultado = 0

        Me.tabInicial.SelectedTabPageIndex = 0
        Me.grd2.ClearColumnsFilter()
        Me.grd3.ClearColumnsFilter()

        Me.txtCodigoInterno.ResetText()
        Me.chkCodigo.Checked = False
        Me.txtCodFor.ResetText()
        Me.cboCodBarra.SelectedIndex = 0
        Me.txtProduto.ResetText()
        Me.cboSetor.SelectedIndex = 0
        Me.cboGrupo.SelectedIndex = 0
        Me.cboFornecedor.SelectedIndex = 0
        Me.cboFamilia.SelectedIndex = 0
        Me.cboUniMed.SelectedIndex = 0
        Me.cboTipo.SelectedIndex = 0
        Me.txtLocacao.ResetText()
        Me.txtComissao.ResetText()
        Me.txtCusto.ResetText()
        Me.txtVenda.ResetText()
        Me.txtVendaPorc.ResetText()
        Me.txtDesconto.ResetText()
        Me.txtDescontoPorc.ResetText()
        Me.memObservacao.ResetText()
        Me.chkDuplicar.Checked = False
        Me.chkAlterarPreco.Checked = False
        Me.chkTribPadrao.Checked = False
        Me.cboBuscarProd.ResetText()

    End Sub

    Private Sub Alterar()
        CalculoEntradaSaidaAjuste()
        Dim parQtde As Double = Me.grd3.GetRowCellValue(0, "Qtd")

        Atualizar("update Produtos set COdigoInterno = '" & Me.txtCodigoInterno.Text & "', CodFor = '" & Me.txtCodFor.Text & "', CodBarra = '" & Me.cboCodBarra.Text & "', " & _
                  "Produto = '" & Me.txtProduto.Text & "', Setor = '" & Me.cboSetor.Text & "', Grupo = '" & Me.cboGrupo.Text & "', " & _
                  "Fornecedor = '" & Me.cboFornecedor.Text & "', Familia = '" & Me.cboFamilia.Text & "', UnidMed = '" & Me.cboUniMed.Text & "', " & _
                  "Tipo = '" & Me.cboTipo.Text & "', Locacao = '" & Me.txtLocacao.Text & "', Comissao = '" & Me.txtComissao.Text & "', " & _
                  "Custo = '" & Me.txtCusto.Text & "', Venda = '" & Me.txtVenda.Text & "', Desconto = '" & Me.txtDesconto.Text & "', " & _
                  "Observacao = '" & Me.memObservacao.Text & "', Duplicar = '" & Me.chkDuplicar.Checked & "', " & _
                  "AlterarPreco = '" & Me.chkAlterarPreco.Checked & "', TribPadrao = '" & Me.chkTribPadrao.Checked & "', " & _
                  "Inativo = '" & Me.chkInativo.Checked & "' where codigo = '" & intCodigoProduto & "';")

        Dim strCalculoAjuste As String = (Me.grd3.GetRowCellValue(0, "Qtd")) - (dblResultado)

        Inserir("insert into AjusteQtde (CodProd, Qtd, Data, Username) values(" & intCodigoProduto & ", " & _
                " " & strCalculoAjuste.Replace(",", ".") & ", " & _
                "getdate(), '" & Environment.MachineName.ToString & "' );")

        CalculoEntradaSaidaAjuste()
        Atualizar("update Qtde set Tamanho = '" & Me.grd3.GetRowCellValue(0, "Tamanho") & "', Qtd = " & dblResultado & ", " & _
                  "Lote = '" & Me.grd3.GetRowCellValue(0, "Lote") & "', EmFalta = '" & Me.grd3.GetRowCellValue(0, "EmFalta") & "', " & _
                  "Acabou = '" & Me.grd3.GetRowCellValue(0, "Acabou") & "', CodConfig = '" & Me.grd3.GetRowCellValue(0, "CodConfig") & "', " & _
                  "DataFim = '" & Me.grd3.GetRowCellValue(0, "DataFim") & "', Cor = '" & Me.grd3.GetRowCellValue(0, "Cor") & "' " & _
                  "where CodProd = " & Me.intCodigoProduto & ";")

        AtualizarGrid()
    End Sub

    Private Sub MostrarDados()
        Dim index As Integer = Me.grd2.FocusedRowHandle
        intCodigoProduto = Me.grd2.GetRowCellValue(index, colCodigo)
        Me.txtCodigoInterno.Text = Me.grd2.GetRowCellDisplayText(index, Me.colCodigoInterno)
        Me.cboCodBarra.Text = Me.grd2.GetRowCellDisplayText(index, Me.colCodBarra)
        Me.txtProduto.Text = Me.grd2.GetRowCellDisplayText(index, Me.colProduto)
        Me.cboSetor.Text = Me.grd2.GetRowCellDisplayText(index, Me.colSetor)
        Me.cboGrupo.Text = Me.grd2.GetRowCellDisplayText(index, Me.colGrupo)
        Me.cboFornecedor.Text = Me.grd2.GetRowCellDisplayText(index, Me.colFornecedor)
        Me.cboFamilia.Text = Me.grd2.GetRowCellDisplayText(index, Me.colFamilia)
        Me.cboUniMed.Text = Me.grd2.GetRowCellDisplayText(index, Me.colUnidMed)
        Me.cboTipo.Text = Me.grd2.GetRowCellDisplayText(index, Me.colTipo)
        Me.txtLocacao.Text = Me.grd2.GetRowCellDisplayText(index, Me.colLocacao)
        Me.txtComissao.Text = Me.grd2.GetRowCellDisplayText(index, Me.colComissao)
        Me.txtCusto.Text = Me.grd2.GetRowCellDisplayText(index, Me.colCusto)
        Me.txtVenda.Text = Me.grd2.GetRowCellDisplayText(index, Me.colVenda)
        Me.txtDesconto.Text = Me.grd2.GetRowCellDisplayText(index, Me.colDesconto)
        Me.memObservacao.Text = Me.grd2.GetRowCellDisplayText(index, Me.colObservacao)
        Me.chkDuplicar.Checked = Me.grd2.GetRowCellValue(index, Me.colDuplicar)
        Me.chkAlterarPreco.Checked = Me.grd2.GetRowCellValue(index, Me.colAlterarPreco)
        Me.chkTribPadrao.Checked = Me.grd2.GetRowCellValue(index, Me.colTribPadrao)
        Me.chkInativo.Checked = Me.grd2.GetRowCellValue(index, Me.colInativo)


        Dim dt As DataTable = CarregarDataTable("select * from Qtde where CodProd = " & intCodigoProduto & "; ")
        Dim dtAjust As DataTable = CarregarDataTable("select Produtos.Produto, (select case when sum(qtd) is null " & _
                                                            "then 0 else sum(qtd) end from Entradanf where entradanf.codprod = " & _
                                                            "produtos.codigo) - (select case when sum(qtd) is null then 0 else sum(qtd) " & _
                                                            "end from Pedido where Pedido.codprod = produtos.codigo) +(select case when " & _
                                                            "sum(qtd) is null then 0 else sum(qtd) end from AjusteQtde where AjusteQtde.codprod " & _
                                                            "= produtos.codigo) as Qtd from produtos where codigo = " & intCodigoProduto & "; ")
        If dt.Rows.Count > 0 Then
            Me.grd3.SetRowCellValue(0, "Tamanho", dt.Rows.Item(0).Item("Tamanho"))
            Me.grd3.SetRowCellValue(0, "Cor", dt.Rows.Item(0).Item("Cor"))
            Me.grd3.SetRowCellValue(0, "Lote", dt.Rows.Item(0).Item("Lote"))
            Me.grd3.SetRowCellValue(0, "Qtd", dtAjust.Rows.Item(0).Item("Qtd"))
        Else
            Me.grd3.SetRowCellValue(0, "Tamanho", "")
            Me.grd3.SetRowCellValue(0, "Cor", "")
            Me.grd3.SetRowCellValue(0, "Lote", "")
            Me.grd3.SetRowCellValue(0, "Qtd", "")
        End If

    End Sub

    Private Sub InserirDados()
        Inserir("insert into Produtos (CodigoInterno, CodFor, CodBarra, Produto, Setor, Grupo, Fornecedor, Familia, UnidMed, Tipo, Locacao, Comissao, " & _
                "Custo, Venda, Desconto, Observacao, AlterarPreco, Duplicar, TribPadrao, Inativo) values ('" & Me.txtCodigoInterno.Text & "', '" & Me.txtCodFor.Text & "', " & _
                "'" & Me.cboCodBarra.Text & "', '" & Me.txtProduto.Text & "', '" & Me.cboSetor.Text & "', '" & Me.cboGrupo.Text & "', " & _
                "'" & Me.cboFornecedor.Text & "', '" & Me.cboFamilia.Text & "','" & Me.cboUniMed.Text & "', '" & Me.cboTipo.Text & "', " & _
                "'" & Me.txtLocacao.Text & "', '" & Me.txtComissao.Text & "', '" & Me.txtCusto.Text & "', '" & Me.txtVenda.Text & "', " & _
                "'" & Me.txtDesconto.Text & "', '" & Me.memObservacao.Text & "', '" & Me.chkAlterarPreco.Checked & "', " & _
                "'" & Me.chkDuplicar.Checked & "', '" & Me.chkTribPadrao.Checked & "', '" & Me.chkInativo.Checked & "');")

        Dim dtUltimoInsert As DataTable = CarregarDataTable("select max(Codigo) as 'Ultimo Codigo' from Produtos;")
        Inserir("insert into Qtde (CodProd, Tamanho, Qtd,  Lote, EmFalta, Acabou, CodConfig, DataFim, Cor) values " & _
                "(" & dtUltimoInsert.Rows.Item(0).Item("Ultimo Codigo") & ", '" & Me.tbQtd.Rows.Item(0).Item("Tamanho") & "', " & _
                "" & (Me.tbQtd.Rows.Item(0).Item("Qtd").ToString).Replace(",", ".") & ", '" & Me.tbQtd.Rows.Item(0).Item("Lote") & "', " & _
                "'" & Me.tbQtd.Rows.Item(0).Item("EmFalta") & "', '" & Me.tbQtd.Rows.Item(0).Item("Acabou") & "', " & _
                "'" & Me.tbQtd.Rows.Item(0).Item("CodConfig") & "', '" & Me.tbQtd.Rows.Item(0).Item("DataFim") & "', " & _
                "'" & Me.tbQtd.Rows.Item(0).Item("Cor") & "')")

        Inserir("insert into AjusteQtde (CodProd, Qtd, Data, Username) values(" & dtUltimoInsert.Rows.Item(0).Item("Ultimo Codigo") & ", " & _
                " " & grd3.GetRowCellValue(0, "Qtd").ToString.Replace(",", ".") & ", getdate(), '" & Environment.MachineName.ToString & "' );")

        AtualizarGrid()
        Limpar()
    End Sub

    Private Sub DeletarDados()
        Dim Index As Integer = Me.grd2.FocusedRowHandle
        intCodigoProduto = Me.grd2.GetRowCellValue(Index, colCodigo)
        Deletar("delete Qtde where CodProd = " & intCodigoProduto & ";")
        Deletar("delete EntradaNf where CodProd = " & intCodigoProduto & ";")
        Deletar("delete Pedido where CodProd = " & intCodigoProduto & ";")
        Deletar("delete AjusteQtde where CodProd = " & intCodigoProduto & ";")
        Deletar("delete Produtos where Codigo = " & intCodigoProduto & ";")
        Limpar()
        AtualizarGrid()
    End Sub

    Private Sub CalculoEntradaSaidaAjuste()
        Dim dtSomaAjuste As DataTable = CarregarDataTable("select (select case when sum(qtd) is null then 0 else sum(qtd) end from AjusteQtde where AjusteQtde.codprod = P.codigo) from Produtos as P where Codigo = " & Me.intCodigoProduto & ";")
        Dim dtSomaEntrada As DataTable = CarregarDataTable("select (select case when sum(qtd) is null then 0 else sum(qtd) end from EntradaNf where entradanf.codprod = P.codigo) from Produtos as P where Codigo = " & Me.intCodigoProduto & ";")
        Dim dtSomaSaida As DataTable = CarregarDataTable("select (select case when sum(qtd) is null then 0 else sum(qtd) end from Pedido where Pedido.codprod = P.codigo) from Produtos as P where Codigo = " & Me.intCodigoProduto & ";")


        dblResultado = dtSomaEntrada.Rows.Item(0).Item(0) - dtSomaSaida.Rows.Item(0).Item(0) + dtSomaAjuste.Rows.Item(0).Item(0)

    End Sub

    Private Sub bntSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bntSalvar.ItemClick
        If Me.txtProduto.Text = "" Then
            MsgBox("O campo Produto é Obrigatório, tente novamente!", MsgBoxStyle.Exclamation)
            Exit Sub

            'ElseIf Me.txtQtde.Text = "" Then
            '    MsgBox("O campo Quantidade(Qtde) é Obrigatório, tente novamente!", MsgBoxStyle.Exclamation)
            '    Exit Sub

        ElseIf Me.txtCusto.Text = "" Then
            MsgBox("O campo Custo é Obrigatório, tente novamente!", MsgBoxStyle.Exclamation)
            Exit Sub

        ElseIf Me.txtVenda.Text = "" Then
            MsgBox("O campo Venda é Obrigatório, tente novamente!", MsgBoxStyle.Exclamation)
            Exit Sub

        ElseIf Me.grd3.GetRowCellValue(0, "Qtd").ToString = "" Then
            MsgBox("O campo Qtd é Obrigatório, tente novamente!", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            If bolStatusAlteracao = False Then
                InserirDados()
                MsgBox("Registro adicionado com sucesso!", MsgBoxStyle.Information)

            Else
                Alterar()
                bolStatusAlteracao = False
                MsgBox("Obrigado " & Environment.MachineName & " ! " & Me.txtProduto.Text & " Foi atualizado.", MsgBoxStyle.Information)
                Limpar()
            End If
        End If
        cfgContador(txtProdCadastrados, grd2)
    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Dim ResultLimparCampo As DialogResult = MsgBox("Deseja Limpar Todos os Campos?", MsgBoxStyle.YesNo)
        If ResultLimparCampo = DialogResult.Yes Then
            Me.Limpar()
            bolStatusAlteracao = False
        End If
    End Sub

    Private Sub btnAlterar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        MostrarDados()
        bolStatusAlteracao = True
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        If MessageBox.Show("Deseja voltar para o menu de navegação? ", My.Application.Info.Title, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If bolStatusAlteracao = True Then
            DeletarDados()
            bolStatusAlteracao = False
            MsgBox("Registro Excluído.", MsgBoxStyle.Information)

        Else
            MsgBox("Falha! Selecione um registro e clique em Alterar.", MsgBoxStyle.Exclamation)
        End If
        cfgContador(txtProdCadastrados, grd2)
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoInterno.KeyPress
        'Aceitar Apenas Números
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'Não aceitar Espaços
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If

    End Sub

    Private Sub txtCodFor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodFor.KeyPress
        'Aceitar Apenas Números
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'Não aceitar Espaços
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If

    End Sub

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If Me.chkCodigo.Checked = True Then
            Me.txtCodigoInterno.Enabled = True

        Else
            Me.txtCodigoInterno.Enabled = False
        End If
    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        If Me.Tag = "ConsultarProdutoAdicionar" Then
            Dim Index As Integer = Me.grd2.FocusedRowHandle
            CodigoProduto = Me.grd2.GetRowCellValue(Index, colCodigo)
            Me.Close()

        ElseIf Me.Tag = "ConsultarProdutoRemover" Then
            Dim Index As Integer = Me.grd2.FocusedRowHandle
            CodigoProduto = Me.grd2.GetRowCellValue(Index, colCodigo)
            Me.Close()

        ElseIf Me.Tag = "CadastrarProduto" Then
            Dim Index As Integer = Me.grd2.FocusedRowHandle
            intCodigoProduto = Me.grd2.GetRowCellValue(Index, colCodigo)
            MostrarDados()
            If intCodigoProduto <= 0 Then
                bolStatusAlteracao = False
                Exit Sub
            End If

            bolStatusAlteracao = True

        End If

    End Sub

    Private Sub lbInativo_Click(sender As Object, e As EventArgs) Handles lblInativo.Click

        If Me.chkInativo.Checked = False Then
            Me.chkInativo.Checked = True
        Else
            Me.chkInativo.Checked = False
        End If

    End Sub

    Private Sub lblTribPadrao_Click(sender As Object, e As EventArgs) Handles lblTribPadrao.Click
        If Me.chkTribPadrao.Checked = False Then
            Me.chkTribPadrao.Checked = True
        Else
            Me.chkTribPadrao.Checked = False
        End If
    End Sub

    Private Sub lblAlterarPreco_Click(sender As Object, e As EventArgs) Handles lblAlterarPreco.Click
        If Me.chkAlterarPreco.Checked = False Then
            Me.chkAlterarPreco.Checked = True
        Else
            Me.chkAlterarPreco.Checked = False
        End If
    End Sub

    Private Sub lblDuplicar_Click(sender As Object, e As EventArgs) Handles lblDuplicar.Click
        If Me.chkDuplicar.Checked = False Then
            Me.chkDuplicar.Checked = True
        Else
            Me.chkDuplicar.Checked = False
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim intSomaVenda As Double
        Dim intSomaCusto As Double
        Dim i As Integer

        For i = 0 To (grd2.RowCount - 1)
            If Me.grd2.GetRowCellValue(i, colQtd) <> 0 Then
                intSomaVenda = intSomaVenda + Me.grd2.GetRowCellValue(i, colVenda) * Me.grd2.GetRowCellValue(i, colQtd)
                intSomaCusto = intSomaCusto + Me.grd2.GetRowCellValue(i, colCusto) * Me.grd2.GetRowCellValue(i, colQtd)
            End If

        Next

        If Me.cboCustoVenda.Text = "Valor Venda" Then
            Me.txtCapitalEstoque.Text = FormatNumber(intSomaVenda, 3)

        ElseIf Me.cboCustoVenda.Text = "Valor Custo" Then
            Me.txtCapitalEstoque.Text = FormatNumber(intSomaCusto, 3)
        End If

        Dim intSomaQtd As Double
        Dim t As Integer

        For t = 0 To (grd2.RowCount - 1)
            intSomaQtd = intSomaQtd + Me.grd2.GetRowCellValue(t, colQtd)
        Next
        Me.txtQtdTotal.Text = intSomaQtd
    End Sub

    Private Sub lblAlterarPreco_MouseHover(sender As Object, e As EventArgs) Handles lblAlterarPreco.MouseHover
        Me.chkAlterarPreco.BackColor = Color.White

    End Sub

    Private Sub lblAlterarPreco_MouseLeave(sender As Object, e As EventArgs) Handles lblAlterarPreco.MouseLeave
        Me.chkAlterarPreco.BackColor = Color.FromArgb(235, 236, 239)
    End Sub

    Private Sub lblTribPadrao_MouseHover(sender As Object, e As EventArgs) Handles lblTribPadrao.MouseHover
        Me.chkTribPadrao.BackColor = Color.White
    End Sub

    Private Sub lblTribPadrao_MouseLeave(sender As Object, e As EventArgs) Handles lblTribPadrao.MouseLeave
        chkTribPadrao.BackColor = Color.FromArgb(235, 236, 239)
    End Sub

    Private Sub lbInativo_MouseHover(sender As Object, e As EventArgs) Handles lblInativo.MouseHover
        chkInativo.BackColor = Color.White
    End Sub

    Private Sub lbInativo_MouseLeave(sender As Object, e As EventArgs) Handles lblInativo.MouseLeave
        Me.chkInativo.BackColor = Color.FromArgb(235, 236, 239)
    End Sub

    Private Sub lblDuplicar_MouseHover(sender As Object, e As EventArgs) Handles lblDuplicar.MouseHover
        Me.chkDuplicar.BackColor = Color.White
    End Sub

    Private Sub lblDuplicar_MouseLeave(sender As Object, e As EventArgs) Handles lblDuplicar.MouseLeave
        Me.chkDuplicar.BackColor = Color.FromArgb(235, 236, 239)
    End Sub

    Private Sub frmCadProdutos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'If Me.Width <= 1024 Then
        '    pnl.Anchor = AnchorStyles.Top + AnchorStyles.Left

        'Else
        '    pnl.Anchor = AnchorStyles.Top + AnchorStyles.Right
        'End If
    End Sub

    Private Sub txtComissao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComissao.KeyPress
        cfgPressNumVirgulas(txtComissao, e)
    End Sub

    Private Sub txtComissao_Leave(sender As Object, e As EventArgs) Handles txtComissao.Leave
        cfgLeaveNumVirgulas(txtComissao)
    End Sub

    Private Sub txtProdCadastrados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdCadastrados.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtProdCadastrados_VisibleChanged(sender As Object, e As EventArgs) Handles txtProdCadastrados.VisibleChanged
        cfgContador(txtProdCadastrados, grd2)
    End Sub

    Private Sub Desconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        cfgPressNumVirgulas(txtDesconto, e)
    End Sub

    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        cfgLeaveNumVirgulas(txtDesconto)
        If Me.txtVenda.Text <> "" And Me.txtDesconto.Text <> "" Then
            Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text / (Me.txtVenda.Text) * 100, 3)
        End If

    End Sub

    Private Sub txtQtde_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVenda.KeyPress
        cfgPressNumVirgulas(txtVenda, e)
    End Sub

    Private Sub txtVenda_Leave(sender As Object, e As EventArgs) Handles txtVenda.Leave
        cfgLeaveNumVirgulas(txtVenda)
        If Me.txtCusto.Text <> "" And Me.txtVenda.Text <> "" Then
            Me.txtVendaPorc.Text = FormatNumber(Me.txtVenda.Text * 100 / Me.txtCusto.Text - 100, 3)
        End If

    End Sub

    Private Sub txtVendaPorc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVendaPorc.KeyPress
        cfgPressNumVirgulas(txtVendaPorc, e)
    End Sub

    Private Sub txtVendaPorc_Leave(sender As Object, e As EventArgs) Handles txtVendaPorc.Leave
        cfgLeaveNumVirgulas(txtVendaPorc)
        If Me.txtCusto.Text <> "" And Me.txtVendaPorc.Text <> "" Then
            Me.txtVenda.Text = FormatNumber(Me.txtCusto.Text * (Me.txtVendaPorc.Text + 100) / 100, 3)
        End If
        cfgLeaveNumVirgulas(txtVendaPorc)
    End Sub

    Private Sub txtCapitalEstoque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapitalEstoque.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtQtdTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdTotal.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusto.KeyPress
        cfgPressNumVirgulas(txtCusto, e)
    End Sub

    Private Sub txtCusto_Leave(sender As Object, e As EventArgs) Handles txtCusto.Leave
        cfgLeaveNumVirgulas(txtCusto)
    End Sub

    Private Sub txtAlterarGridNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlterarGridNumero.KeyPress

        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescontoPorc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescontoPorc.KeyPress
        cfgPressNumVirgulas(txtDescontoPorc, e)
    End Sub

    Private Sub txtDescontoPorc_Leave(sender As Object, e As EventArgs) Handles txtDescontoPorc.Leave
        If Me.txtVenda.Text <> "" And Me.txtDescontoPorc.Text <> "" Then
            Me.txtDesconto.Text = FormatNumber(Me.txtVenda.Text * Me.txtDescontoPorc.Text / 100, 3)
        End If

        cfgLeaveNumVirgulas(txtDescontoPorc)
    End Sub

    Private Sub txtDescontoPorc_VisibleChanged(sender As Object, e As EventArgs) Handles txtDescontoPorc.VisibleChanged
        Me.txtDescontoPorc.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub txtVendaPorc_EditValueChanged(sender As Object, e As EventArgs) Handles txtVendaPorc.EditValueChanged

    End Sub

    Private Sub txtVendaPorc_VisibleChanged(sender As Object, e As EventArgs) Handles txtVendaPorc.VisibleChanged
        Me.txtVendaPorc.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub memObservacao_EditValueChanged(sender As Object, e As EventArgs) Handles memObservacao.EditValueChanged

    End Sub

    Private Sub memObservacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles memObservacao.KeyPress, txtProduto.KeyPress, txtLocacao.KeyPress, txtAlterarGridQtde.KeyPress, cboUniMed.KeyPress, cboTipo.KeyPress, cboSetor.KeyPress, cboGrupo.KeyPress, cboFornecedor.KeyPress, cboFamilia.KeyPress, cboCustoVenda.KeyPress, cboCodBarra.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCusto_EditValueChanged(sender As Object, e As EventArgs) Handles txtCusto.EditValueChanged

    End Sub

    Private Sub txtVenda_EditValueChanged(sender As Object, e As EventArgs) Handles txtVenda.EditValueChanged

    End Sub

    Private Sub txtDesconto_EditValueChanged(sender As Object, e As EventArgs) Handles txtDesconto.EditValueChanged

    End Sub

    Private Sub cboBuscarProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBuscarProd.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub cboBuscarProd_KeyUp(sender As Object, e As KeyEventArgs) Handles cboBuscarProd.KeyUp
        CarregarDados("select P.Codigo, P.CodigoInterno, P.CodFor, P.CodBarra, P.Produto, P.Setor, P.Grupo, P.Fornecedor, P.Familia, P.UnidMed, P.Tipo, " & _
                  "P.Locacao, P.Comissao, P.Custo, P.Venda, ((select case when sum(qtd) is null then 0 else sum(qtd) end from Entradanf " & _
                  "where entradanf.codprod = P.codigo) - (select case when sum(qtd) is null then 0 else sum(qtd) end from Pedido " & _
                  "where Pedido.codprod = P.codigo) + (select case when sum(qtd) is null then 0 else sum(qtd) end from AjusteQtde " & _
                  "where AjusteQtde.codprod = P.codigo)) as Qtd,  P.Desconto, P.Observacao, P.AlterarPreco, P.Duplicar, P.TribPadrao, " & _
                  "P.Inativo, Q.Tamanho, Q.Cor, Q.Lote from Produtos as P left join Qtde as Q on Q.CodProd = P.Codigo where P.Produto like '%" & cboBuscarProd.Text & "%';", grdProdCadastrados)

    End Sub

    Private Sub btnLimparBusca_Click(sender As Object, e As EventArgs) Handles btnLimparBusca.Click
        Limpar()
        AtualizarGrid()
    End Sub
End Class