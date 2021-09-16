Imports telausuario.clsFuncao
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmCadPedido
    Dim dblSomaDesconto As Double = FormatNumber(0, 3)
    Dim dblSomaGeral As Double = FormatNumber(0, 3)
    Dim dblSomaVenda As Double = FormatNumber(0, 3)
    Dim dblSomaServico As Double = FormatNumber(0, 3)
    Dim dblFrete As Double = FormatNumber(0, 3)
    Dim vetDelete As New List(Of String)
    Dim bolStatusAlteracao As Boolean
    Dim dblValorTotalGeralSemDesc As Double = FormatNumber(0, 3)
    Dim dblValorTotalGeralComDesc As Double = FormatNumber(0, 3)

    Private Sub frmCadPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()

        If Me.Tag = "ConsultarPedido" Then
            Me.Text = "Consultar Pedido"
            Me.tabAddRemover.Enabled = False
            Me.lblOrdem.Visible = True
            Me.txtOrdem.Visible = True
            Me.btnOrdem.Visible = True

            Me.txtPorcentagem.Properties.ReadOnly = True
            Me.txtValorDistribuido.Properties.ReadOnly = True
            Me.txtValorFrete.Properties.ReadOnly = True

            Me.lblVendedor.Location = New Point(256, 14)
            Me.cboVendedor.Location = New Point(307, 11)
            Me.cboVendedor.Size = New Size(238, 20)

            btnExcluirItem.Visible = False
            Me.txtNome.Enabled = False
            Me.txtNome.Properties.AppearanceDisabled.BackColor = Color.White
            Me.txtTelefone.Properties.ReadOnly = True
            Me.txtCpfCnpj.Properties.ReadOnly = True

            btnPesquisarNome.Enabled = False
            btnPesquisarNome.Properties.AppearanceDisabled.BackColor = Color.White

            Me.txtPorcentagem.Properties.ReadOnly = False
            Me.txtValorDistribuido.Properties.ReadOnly = False
            Me.txtValorFrete.Properties.ReadOnly = False


        ElseIf Me.Tag = "CadastrarPedido" Then
            Me.Text = "Cadastrar Pedido"
            Me.tabAddRemover.Enabled = True
            Me.lblOrdem.Visible = False
            Me.txtOrdem.Visible = False
            Me.btnOrdem.Visible = False
            Me.txtPorcentagem.Properties.ReadOnly = False
            Me.txtValorDistribuido.Properties.ReadOnly = False
            Me.txtValorFrete.Properties.ReadOnly = False
            Me.btnExcluirItem.Visible = True
            Me.txtNome.Enabled = True
            Me.txtTelefone.Properties.ReadOnly = True
            Me.txtCpfCnpj.Properties.ReadOnly = True
            Me.btnPesquisarNome.Enabled = True
            Me.lblVendedor.Location = New Point(38, 14)
            Me.cboVendedor.Location = New Point(90, 11)
            Me.cboVendedor.Size = New Size(455, 20)

        ElseIf Me.Tag = "AlterarPedido" Then
            Me.Text = "Alterar Pedido"
            Me.tabAddRemover.Enabled = True
            Me.tabDadosHistorico.Enabled = True
            Me.lblOrdem.Visible = True
            Me.txtOrdem.Visible = True
            Me.btnOrdem.Visible = True
            Me.txtNome.Enabled = False
            Me.txtNome.Properties.AppearanceDisabled.BackColor = Color.White
            Me.txtTelefone.Properties.ReadOnly = True
            Me.txtCpfCnpj.Properties.ReadOnly = True
            Me.btnExcluirItem.Visible = True
            Me.btnPesquisarNome.Enabled = False
            Me.btnPesquisarNome.Properties.AppearanceDisabled.BackColor = Color.White
            Me.txtPorcentagem.Properties.ReadOnly = False
            Me.txtValorDistribuido.Properties.ReadOnly = False
            Me.txtValorFrete.Properties.ReadOnly = False

            Me.lblVendedor.Location = New Point(256, 14)
            Me.cboVendedor.Location = New Point(307, 11)
            Me.cboVendedor.Size = New Size(238, 20)

        End If


    End Sub

    Private Sub frmCadPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F7
                Me.tabClientesProdutos.SelectedTabPageIndex = 0

            Case Keys.F2
                Me.tabClientesProdutos.SelectedTabPageIndex = 1

            Case Keys.F3

                Dim dblSomaCusto As Double
                Dim UltimoCodTabTotalConsig As DataTable = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")

                If tbPedidoAtual.Rows.Count > 0 Then
                    If Me.txtNome.Text <> "" Then
                        If UltimoCodTabTotalConsig.Rows.Count = 0 Then
                            Inserir("insert into Ordens (Cod, Tabela, Auxiliar) values (100, 'TotalConsig', '" & Environment.MachineName.ToString & "');")
                        Else
                            Inserir("insert into Ordens (Cod, Tabela, Auxiliar) values (" & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) + 1 & ", 'TotalConsig', '" & Environment.MachineName.ToString & "');")
                            For i = 0 To tbPedidoAtual.Rows.Count - 1
                                NomeProduto = tbPedidoAtual.Rows.Item(i).Item("Produto")
                                Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Produto = '" & NomeProduto & "';")
                                If ProdutoSelect.Rows.Count > 0 Then
                                    CodigoProduto = ProdutoSelect.Rows.Item(0).Item("Codigo")

                                    Dim dblDescComDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao")
                                    Dim dblDescSemDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao")
                                    Dim dbldesconto As Double = dblDescComDistribuicao + dblDescSemDistribuicao

                                    Inserir("insert into ItensConsig (CodigoInterno, CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, Custo, Desconto,DescComDistribuicao, DescSemDistribuicao, DataAdd) values " & _
                                            "(" & ProdutoSelect.Rows.Item(0).Item("CodigoInterno") & ", " & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) + 1 & ", " & _
                                            "" & (tbPedidoAtual.Rows.Item(i).Item("Qtde").replace(".", "")).ToString.Replace(",", ".") & ", " & CodigoProduto & ", " & _
                                            "'" & tbPedidoAtual.Rows.Item(i).Item("Produto") & "', " & (tbPedidoAtual.Rows.Item(i).Item("ValorUnitario").ToString.Replace(".", "")).Replace("," & _
                                            "", ".") & ", " & (tbPedidoAtual.Rows.Item(i).Item("ValorTotal").ToString.Replace(".", "")).Replace(",", ".") & ", " & (ProdutoSelect.Rows.Item(0).Item("Cus" & _
                                            "to").replace(".", "")).replace(",", ".") & ", " & (dbldesconto.ToString.Replace(".", "")).Replace(",", ".") & ", " & _
                                            "" & (dblDescComDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", " & (dblDescSemDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", getdate()); ")

                                    dblSomaCusto = dblSomaCusto + ProdutoSelect.Rows.Item(0).Item("Custo")

                                End If
                            Next

                            UltimoCodTabTotalConsig = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")

                            Inserir("insert into TotalConsig (CodOrdens, Data,CodCli, Total, Descricao, Status, Custo, Desconto) values (" & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) & ", getdate(), " & CodigoCliente & ", " & Me.txtTotalGeral.Text.Replace(".", "").Replace(",", ".") & ", '" & Me.memObservacoes.Text & "', 'Pendente', " & dblSomaCusto.ToString.Replace(".", "").Replace(",", ".") & ", " & Me.txtTotalDesconto.Text.ToString.Replace(".", "").Replace(",", ".") & " );")

                        End If
                        Limpar()
                    Else
                        MsgBox("Nenhum cliente selecionado.", MsgBoxStyle.Exclamation)
                    End If

                Else
                    MsgBox("Nenhum item adicionado.", MsgBoxStyle.Exclamation)
                End If
        End Select

    End Sub

    Private Sub Limpar()

        bolStatusAlteracao = False
        vetDelete.Clear()
        CodigoProduto = -1
        CodigoCliente = -1
        NomeProduto = ""
        dblSomaDesconto = FormatNumber(0, 3)
        dblSomaGeral = FormatNumber(0, 3)
        dblSomaVenda = FormatNumber(0, 3)
        dblSomaServico = FormatNumber(0, 3)
        dblFrete = FormatNumber(0, 3)
        dblValorTotalGeralComDesc = FormatNumber(0, 3)
        dblValorTotalGeralSemDesc = FormatNumber(0, 3)
        Me.tabClientesProdutos.SelectedTabPageIndex = 0
        Me.tabDadosHistorico.SelectedTabPageIndex = 0
        Me.tabAddRemover.SelectedTabPageIndex = 0

        Me.txtNome.ResetText()
        Me.txtCpfCnpj.ResetText()
        Me.txtEmail.ResetText()
        Me.txtNivelComb.ResetText()
        Me.txtCor.ResetText()
        Me.txtTelefone.ResetText()
        Me.txtCelular.ResetText()
        Me.txtKmSaida.ResetText()
        Me.txtKmEntrada.ResetText()
        Me.txtModelo.ResetText()
        Me.txtTotalDesconto.ResetText()
        Me.txtTotalGeral.ResetText()
        Me.txtTotalProdutos.ResetText()
        Me.txtTotalServicos.ResetText()
        Me.txtOrdem.ResetText()

        Me.txtAddCodigoInterno.ResetText()
        Me.txtAddProduto.ResetText()
        Me.txtDescontoPorc.Text = FormatNumber(0, 3)
        Me.txtDesconto.Text = FormatNumber(0, 3)
        Me.txtAddQtd.Text = 1
        Me.txtPreco.Text = FormatNumber(0, 3)
        Me.txtValorFrete.Text = FormatNumber(0, 3)

        Me.txtRemoverCodigo.ResetText()
        Me.txtRemoverProduto.ResetText()
        Me.txtRemoverQtd.Text = 1
        Me.grd1.ClearColumnsFilter()

        Me.tbPedidoAtual.Rows.Clear()
        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
        Me.txtTotalGeral.Text = FormatNumber(0, 3)
        Me.txtTotalProdutos.Text = FormatNumber(0, 3)
        Me.txtTotalServicos.Text = FormatNumber(0, 3)
        Me.txtValorDistribuido.Text = FormatNumber(0, 3)
        Me.txtPorcentagem.Text = FormatNumber(0, 3)

    End Sub


    Private Sub LimparProdutos()

        Me.grd1.ClearColumnsFilter()
        bolStatusAlteracao = False
        CodigoProduto = -1

        Me.txtAddCodigoInterno.ResetText()
        Me.txtAddProduto.ResetText()
        Me.txtDescontoPorc.Text = FormatNumber(0, 3)
        Me.txtDesconto.Text = FormatNumber(0, 3)
        Me.txtAddQtd.Text = 0
        Me.txtPreco.Text = FormatNumber(0, 3)
        Me.txtRemoverCodigo.ResetText()
        Me.txtRemoverProduto.ResetText()
        Me.txtRemoverQtd.Text = 0

    End Sub

    Private Sub ResetarTotalUnitario()
        If tbPedidoAtual.Rows.Count > 0 Then
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("semDesc") - (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde")), 3)
                tbPedidoAtual.Rows.Item(i).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * tbPedidoAtual.Rows.Item(i).Item("Qtde"), 3)
                tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") = FormatNumber(0, 3)

            Next
        End If
    End Sub

    Private Sub SomarTotalProdutoServico()
        dblSomaDesconto = FormatNumber(0, 3)
        dblSomaGeral = FormatNumber(0, 3)
        dblSomaServico = FormatNumber(0, 3)
        dblSomaVenda = FormatNumber(0, 3)
        dblFrete = FormatNumber(0, 3)


        If tbPedidoAtual.Rows.Count > 0 Then
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "VENDA" Then
                    dblSomaVenda = FormatNumber(dblSomaVenda + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)

                Else
                    dblSomaServico = FormatNumber(dblSomaServico + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)

                End If

                dblSomaDesconto = dblSomaDesconto + tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao")
                dblSomaGeral = FormatNumber(dblSomaGeral + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)
            Next

            txtTotalProdutos.Text = FormatNumber(dblSomaVenda, 3)
            txtTotalServicos.Text = FormatNumber(dblSomaServico, 3)

            If rdgDescontoAcrescimo.SelectedIndex = 0 Then
                txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

            Else
                If Me.txtValorDistribuido.Text = "" Then
                    Me.txtValorDistribuido.Text = FormatNumber(dblSomaDesconto, 3)
                End If
            End If

            If Me.txtValorFrete.Text <> "" Then
                dblFrete = txtValorFrete.Text
                txtTotalGeral.Text = FormatNumber(dblSomaGeral + dblFrete, 3)

            Else
                txtTotalGeral.Text = FormatNumber(dblSomaGeral)
            End If

        Else
        End If
    End Sub
    Private Sub btnPesquisarNome_Click(sender As Object, e As EventArgs) Handles btnPesquisarNome.Click
        frmCadCliente.Tag = "ConsultarCliente"
        frmCadCliente.ShowDialog()
        Dim ClienteSelect As DataTable = CarregarDataTable("select * from Cliente where Codigo = " & CodigoCliente & "")

        If ClienteSelect.Rows.Count > 0 Then
            Me.txtNome.Text = ClienteSelect.Rows.Item(0).Item("Nome").ToString
            Me.txtCpfCnpj.Text = ClienteSelect.Rows.Item(0).Item("CPF").ToString
            Me.txtEmail.Text = ClienteSelect.Rows.Item(0).Item("Email").ToString
            Me.txtTelefone.Text = ClienteSelect.Rows.Item(0).Item("Telefone").ToString
            Me.txtCelular.Text = ClienteSelect.Rows.Item(0).Item("Celular").ToString
        End If
    End Sub

    Private Sub btnPesquisarAddProduto_Click(sender As Object, e As EventArgs) Handles btnAddPesquisarProduto.Click
        If Me.Tag = "AlterarPedido" Then
            If txtOrdem.Text = "" Then
                MsgBox("Selecione um pedido em ORDEM.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        frmCadProdutos.Tag = "ConsultarProdutoAdicionar"
        frmCadProdutos.ShowDialog()

        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")


        If dtProdutoSelect.Rows.Count > 0 Then
            Me.txtAddCodigoInterno.Text = dtProdutoSelect.Rows.Item(0).Item("CodigoInterno")
            Me.txtAddProduto.Text = dtProdutoSelect.Rows.Item(0).Item("Produto").ToString
            Me.txtAddQtd.Text = FormatNumber(1, 3)


            If dtProdutoSelect.Rows.Item(0).Item("Desconto") = "" Then
                Me.txtDescontoPorc.Text = FormatNumber(0, 3)
                Me.txtDesconto.Text = FormatNumber(0, 3)

            Else
                Me.txtDesconto.Text = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Desconto"), 3)
                Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text / dtProdutoSelect.Rows.Item(0).Item("Venda") * 100, 3)
            End If

            Me.txtPreco.Text = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Venda") - Me.txtDesconto.Text, 3)
        End If

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        If Me.txtAddProduto.Text = "" Then
            MsgBox("Nenhum produto selecionado", MsgBoxStyle.Exclamation)
            LimparProdutos()
            Exit Sub

        Else
            Select Case bolStatusAlteracao
                Case True 'Atualizar produto em tbPedidoAtual)
                    If Me.txtAddQtd.Text <= 0 Then
                        MsgBox("Quantidade Insuficiente", MsgBoxStyle.Exclamation)
                        Me.txtAddQtd.ResetText()
                        Exit Sub
                    Else
                        Dim dtProdutoSelect As DataTable = CarregarDataTable("select P.Codigo, IC.CodOrdens, P.Venda, P.Produto, P.Custo, IC.CodPedAut from Produtos as P left Join ItensConsig as IC on P.Codigo = IC.CodigoProduto where Codigo = " & CodigoProduto & ";")
                        If dtProdutoSelect.Rows.Count > 0 Then

                            dblSomaVenda = FormatNumber(dblSomaVenda - tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorTotal"), 3)
                            dblSomaServico = FormatNumber(dblSomaServico - tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorTotal"), 3)
                            dblSomaGeral = FormatNumber(dblSomaGeral - tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorTotal"), 3)
                            dblSomaDesconto = FormatNumber(dblSomaDesconto - (tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("DescSemDistribuicao") - tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("DescComDistribuicao")), 3)

                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("CodProd") = dtProdutoSelect.Rows.Item(0).Item("Codigo")
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Produto") = Me.txtAddProduto.Text
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Qtde") = FormatNumber(Me.txtAddQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("DescSemDistribuicao") = FormatNumber(Me.txtDesconto.Text * tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Qtde"), 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("SemDesc") = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Venda"), 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorUnitario") = FormatNumber(Me.txtPreco.Text, 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorUnitario") * tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Qtde"), 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Custo") = dtProdutoSelect.Rows.Item(0).Item("Custo")
                            tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("CodPedAut") = dtProdutoSelect.Rows.Item(0).Item("CodPedAut")

                            If rdgPS.SelectedIndex = 0 Then
                                tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Tipo") = "VENDA"

                            Else
                                tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Tipo") = "SERVIÇO"
                            End If

                            SomarTotalProdutoServico()
                            bolStatusAlteracao = False
                            LimparProdutos()

                        End If
                    End If

                Case False 'Adicionar produto em tbPedidoAtual
                    If Me.txtAddQtd.Text <= 0 Then
                        MsgBox("Quantidade Insuficiente", MsgBoxStyle.Exclamation)
                        Me.txtAddQtd.ResetText()
                        Exit Sub
                    Else

                        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & ";")
                        If dtProdutoSelect.Rows.Count > 0 Then
                            ResetarTotalUnitario()

                            tbPedidoAtual.Rows.Add(0)
                            Dim PosicaoLinha As Integer = tbPedidoAtual.Rows.Count - 1
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("CodProd") = dtProdutoSelect.Rows.Item(0).Item("Codigo")
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Produto") = Me.txtAddProduto.Text
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Qtde") = FormatNumber(Me.txtAddQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("DescSemDistribuicao") = FormatNumber(Me.txtDesconto.Text * tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Qtde"), 3)
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("SemDesc") = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Venda"), 3)
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorUnitario") = FormatNumber(Me.txtPreco.Text, 3)
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorUnitario") * tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Qtde"), 3)
                            tbPedidoAtual.Rows.Item(PosicaoLinha).Item("DescComDistribuicao") = FormatNumber(0, 3)

                            If rdgPS.SelectedIndex = 0 Then
                                tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Tipo") = "VENDA"

                            Else
                                tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Tipo") = "SERVIÇO"
                            End If
                            SomarTotalProdutoServico()
                            LimparProdutos()
                        End If
                    End If

            End Select

        End If

    End Sub

    Private Sub btnRemoverPesquisarGrid_Click(sender As Object, e As EventArgs) Handles btnRemoverPesquisarGrid.Click

        frmCadProdutos.Tag = "ConsultarProdutoRemover"
        frmCadProdutos.ShowDialog()

        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")

        If dtProdutoSelect.Rows.Count > 0 Then
            Me.txtRemoverCodigo.Text = dtProdutoSelect.Rows.Item(0).Item("Codigo")
            Me.txtRemoverProduto.Text = dtProdutoSelect.Rows.Item(0).Item("Produto")
            Me.txtRemoverQtd.Text = 1
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If Me.txtRemoverProduto.Text = "" Then
            MsgBox("Nenhum item selecionado.", MsgBoxStyle.Information)
            LimparProdutos()
            Exit Sub
        ElseIf Me.txtRemoverQtd.Text <= 0 Then
            MsgBox("Nenhum item selecionado.", MsgBoxStyle.Information)
            LimparProdutos()
            Exit Sub

        Else
            Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")
            If dtProdutoSelect.Rows.Count > 0 Then
                For i = 0 To tbPedidoAtual.Rows.Count - 1
                    If tbPedidoAtual.Rows.Item(i).Item("Produto") = dtProdutoSelect.Rows.Item(0).Item("Produto") Then
                        If Me.txtRemoverQtd.Text = tbPedidoAtual.Rows.Item(i).Item("Qtde") Then 'Quantidades iguais para serem removidas - Delete ROW
                            If tbPedidoAtual.Rows.Item(i).Item("Tipo") = "VENDA" Then

                                dblSomaVenda = dblSomaVenda - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                                Me.txtTotalProdutos.Text = FormatNumber(dblSomaVenda, 3)
                            Else
                                dblSomaServico = dblSomaServico - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                                Me.txtTotalServicos.Text = FormatNumber(dblSomaServico, 3)

                            End If

                            dblSomaGeral = dblSomaGeral - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                            Me.txtTotalGeral.Text = FormatNumber(dblSomaGeral, 3)

                            dblSomaDesconto = dblSomaDesconto - tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao")
                            tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3)
                            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

                            If Me.Tag = "AlterarPedido" Then
                                If tbPedidoAtual.Rows.Item(i).Item("CodPedAut") = "" Then
                                    MsgBox("Item inválido, escolha novamente.", MsgBoxStyle.Exclamation)
                                    Exit Sub
                                ElseIf tbPedidoAtual.Rows.Item(i).Item("CodPedAut") > 0 Then
                                    Dim strNovoItem As String = tbPedidoAtual.Rows.Item(i).Item("CodPedAut")
                                    vetDelete.Add(strNovoItem)
                                End If
                            End If


                            tbPedidoAtual.Rows.RemoveAt(i)
                            LimparProdutos()
                            bolStatusAlteracao = False
                            Exit Sub


                        ElseIf Me.txtRemoverQtd.Text < tbPedidoAtual.Rows.Item(i).Item("Qtde") Then 'Quantidades Diferentes para serem removidas - atualizar valores do datatable
                            If tbPedidoAtual.Rows.Item(i).Item("Tipo") = "VENDA" Then
                                dblSomaVenda = dblSomaVenda - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                                Me.txtTotalProdutos.Text = FormatNumber(dblSomaVenda, 3)
                            Else
                                dblSomaServico = dblSomaServico - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                                Me.txtTotalServicos.Text = FormatNumber(dblSomaServico, 3)

                            End If

                            dblSomaGeral = dblSomaGeral - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                            Me.txtTotalGeral.Text = FormatNumber(dblSomaGeral, 3)

                            dblSomaDesconto = FormatNumber(dblSomaDesconto - (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde")) * Me.txtRemoverQtd.Text / Me.txtRemoverQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") - (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde")) * Me.txtRemoverQtd.Text, 3)
                            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

                            tbPedidoAtual.Rows.Item(i).Item("Qtde") = FormatNumber(Me.tbPedidoAtual.Rows.Item(i).Item("Qtde") - Me.txtRemoverQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(i).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("ValorTotal") - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text, 3)
                            LimparProdutos()
                            Exit Sub
                        End If
                    End If
                Next
                MsgBox("Não há produto para ser removido! Tente Novamente.", MsgBoxStyle.Exclamation)
                LimparProdutos()
            End If
        End If

    End Sub

    Private Sub btF3Salvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btF3Salvar.ItemClick
        Dim dblSomaCusto As Double
        Dim UltimoCodTabTotalConsig As DataTable = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")


        If tbPedidoAtual.Rows.Count > 0 Then
            If Me.Tag = "ConsultarPedido" Then
                Limpar()
                Exit Sub
            End If

            If Me.txtNome.Text <> "" Then
                If Me.Tag = "AlterarPedido" Then
                    dblSomaCusto = 0
                    For z = 0 To vetDelete.Count - 1 'Item do Vetor
                        Dim strCodigo As String = vetDelete(z)
                        Deletar("delete ItensConsig where CodPedAut = " & strCodigo & "")
                    Next
                    SomarTotalProdutoServico()
                    vetDelete.Clear()
                    If tbPedidoAtual.Rows.Count = 0 Then
                        Deletar("delete totalconsig where CodOrdens = " & txtOrdem.Text & "")

                    End If

                    For i = 0 To tbPedidoAtual.Rows.Count - 1 'Item da linha
                        Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = '" & tbPedidoAtual.Rows.Item(i).Item("CodProd") & "';")
                        CodigoProduto = ProdutoSelect.Rows.Item(0).Item("Codigo")
                        If tbPedidoAtual.Rows.Item(i).Item("CodPedAut").ToString = "" Then

                            Dim dblDescComDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao")
                            Dim dblDescSemDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao")
                            Dim dbldesconto As Double = dblDescComDistribuicao + dblDescSemDistribuicao

                            Inserir("insert into ItensConsig (Tipo, CodigoInterno, CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, Custo, Desconto,DescComDistribuicao, DescSemDistribuicao, DataAdd) values " & _
                                    "('" & tbPedidoAtual.Rows.Item(i).Item("Tipo") & "', '" & ProdutoSelect.Rows.Item(0).Item("CodigoInterno") & "', " & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) & ", " & _
                                    "" & (tbPedidoAtual.Rows.Item(i).Item("Qtde").replace(".", "")).ToString.Replace(",", ".") & ", " & CodigoProduto & ", " & _
                                    "'" & tbPedidoAtual.Rows.Item(i).Item("Produto") & "', " & (tbPedidoAtual.Rows.Item(i).Item("ValorUnitario").ToString.Replace(".", "")).Replace("," & _
                                    "", ".") & ", " & (tbPedidoAtual.Rows.Item(i).Item("ValorTotal").ToString.Replace(".", "")).Replace(",", ".") & ", " & (ProdutoSelect.Rows.Item(0).Item("Cus" & _
                                    "to").replace(".", "")).replace(",", ".") & ", " & (dbldesconto.ToString.Replace(".", "")).Replace(",", ".") & ", " & _
                                    "" & (dblDescComDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", " & (dblDescSemDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", getdate()); ")

                            dblSomaCusto = dblSomaCusto + ProdutoSelect.Rows.Item(0).Item("Custo")

                        Else
                            Atualizar("update ItensConsig set CodOrdens = " & tbPedidoAtual.Rows.Item(i).Item("CodOrdens") & "," & _
                                        "Qtd = " & (tbPedidoAtual.Rows.Item(i).Item("Qtde").ToString.Replace(".", "")).Replace(",", ".") & ", Produto = " & _
                                        "'" & tbPedidoAtual.Rows.Item(i).Item("Produto") & "', ValorUnitario = " & _
                                        "" & (tbPedidoAtual.Rows.Item(i).Item("ValorUnitario").ToString.Replace(".", "")).Replace(",", ".") & ", ValorTotal = " & _
                                        "" & (tbPedidoAtual.Rows.Item(i).Item("ValorTotal").ToString.Replace(".", "")).Replace(",", ".") & ", DescComDistribuicao = " & _
                                        "" & (tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao").ToString.Replace(".", "")).Replace(",", ".") & ", DescSemDistribuicao = " & _
                                        "" & (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao").ToString.Replace(".", "")).Replace(",", ".") & ", Tipo = " & _
                                        "'" & tbPedidoAtual.Rows.Item(i).Item("Tipo") & "' where CodPedAut = " & tbPedidoAtual.Rows.Item(i).Item("CodPedAut") & "; ")
                            dblSomaCusto = dblSomaCusto + ProdutoSelect.Rows.Item(0).Item("Custo")
                        End If

                    Next

                    Atualizar("update TotalConsig set DataSaida = , Data = getdate(), Total = " & Me.txtTotalGeral.Text.Replace(".", "").Replace(",", ".") & ", Descricao = '" & Me.memObservacoes.Text & "', Custo = " & dblSomaCusto.ToString.Replace(".", "").Replace(",", ".") & ", Desconto = " & Me.txtTotalDesconto.Text.ToString.Replace(".", "").Replace(",", ".") & "")
                    Limpar()
                    Exit Sub

                End If
                If UltimoCodTabTotalConsig.Rows.Count = 0 Then
                    Inserir("insert into Ordens (Cod, Tabela, Auxiliar) values (100, 'TotalConsig', '" & Environment.MachineName.ToString & "');")
                    UltimoCodTabTotalConsig = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")

                Else
                    Inserir("insert into Ordens (Cod, Tabela, Auxiliar) values (" & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) + 1 & ", 'TotalConsig', '" & Environment.MachineName.ToString & "');")
                End If

                UltimoCodTabTotalConsig = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")

                For i = 0 To tbPedidoAtual.Rows.Count - 1
                    NomeProduto = tbPedidoAtual.Rows.Item(i).Item("Produto")
                    Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Produto = '" & NomeProduto & "';")
                    If ProdutoSelect.Rows.Count > 0 Then
                        CodigoProduto = ProdutoSelect.Rows.Item(0).Item("Codigo")

                        Dim dblDescComDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao")
                        Dim dblDescSemDistribuicao As Double = tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao")
                        Dim dbldesconto As Double = dblDescComDistribuicao + dblDescSemDistribuicao

                        Inserir("insert into ItensConsig (Tipo, CodigoInterno, CodOrdens, Qtd, CodigoProduto, Produto, ValorUnitario, ValorTotal, Custo, Desconto,DescComDistribuicao, DescSemDistribuicao, DataAdd) values " & _
                                "('" & tbPedidoAtual.Rows.Item(i).Item("Tipo") & "', '" & ProdutoSelect.Rows.Item(0).Item("CodigoInterno") & "', " & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) & ", " & _
                                "" & (tbPedidoAtual.Rows.Item(i).Item("Qtde").replace(".", "")).ToString.Replace(",", ".") & ", " & CodigoProduto & ", " & _
                                "'" & tbPedidoAtual.Rows.Item(i).Item("Produto") & "', " & (tbPedidoAtual.Rows.Item(i).Item("ValorUnitario").ToString.Replace(".", "")).Replace("," & _
                                "", ".") & ", " & (tbPedidoAtual.Rows.Item(i).Item("ValorTotal").ToString.Replace(".", "")).Replace(",", ".") & ", " & (ProdutoSelect.Rows.Item(0).Item("Cus" & _
                                "to").replace(".", "")).replace(",", ".") & ", " & (dbldesconto.ToString.Replace(".", "")).Replace(",", ".") & ", " & _
                                "" & (dblDescComDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", " & (dblDescSemDistribuicao.ToString.Replace(".", "")).Replace(",", ".") & ", getdate()); ")

                        dblSomaCusto = dblSomaCusto + ProdutoSelect.Rows.Item(0).Item("Custo")

                    End If
                Next

                UltimoCodTabTotalConsig = CarregarDataTable("select max(cod) as 'Ultimo Registro', Tabela from Ordens where Tabela = 'TotalConsig' group by Tabela;")

                Inserir("insert into TotalConsig (CodOrdens, Data,CodCli, Total, Descricao, Status, Custo, Desconto) values (" & UltimoCodTabTotalConsig.Rows.Item(0).Item(0) & ", getdate(), " & CodigoCliente & ", " & Me.txtTotalGeral.Text.Replace(".", "").Replace(",", ".") & ", '" & Me.memObservacoes.Text & "', 'Pendente', " & dblSomaCusto.ToString.Replace(".", "").Replace(",", ".") & ", " & Me.txtTotalDesconto.Text.ToString.Replace(".", "").Replace(",", ".") & " );")

                Limpar()
            Else
                MsgBox("Nenhum cliente selecionado.", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Nenhum item adicionado.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnExcluirItem_Click(sender As Object, e As EventArgs) Handles btnExcluirItem.Click
        If Me.txtRemoverProduto.Text = "" Then
            MsgBox("Nenhum item selecionado.", MsgBoxStyle.Information)
            LimparProdutos()
            Exit Sub
            If Me.txtRemoverQtd.Text <= 0 Then
                MsgBox("Nenhum item selecionado.", MsgBoxStyle.Information)
                LimparProdutos()
                Exit Sub
            End If
        Else
            Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")
            If dtProdutoSelect.Rows.Count > 0 Then
                For i = 0 To tbPedidoAtual.Rows.Count - 1
                    If tbPedidoAtual.Rows.Item(i).Item("Produto") = dtProdutoSelect.Rows.Item(0).Item("Produto") Then
                        If Me.txtRemoverQtd.Text = tbPedidoAtual.Rows.Item(i).Item("Qtde") Then 'Quantidades iguais para serem removidas - Delete ROW
                            If tbPedidoAtual.Rows.Item(i).Item("Tipo") = "VENDA" Then

                                dblSomaVenda = dblSomaVenda - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                                Me.txtTotalProdutos.Text = FormatNumber(dblSomaVenda, 3)
                            Else
                                dblSomaServico = dblSomaServico - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                                Me.txtTotalServicos.Text = FormatNumber(dblSomaServico, 3)

                            End If

                            dblSomaGeral = dblSomaGeral - tbPedidoAtual.Rows.Item(i).Item("ValorTotal")
                            Me.txtTotalGeral.Text = FormatNumber(dblSomaGeral, 3)

                            dblSomaDesconto = dblSomaDesconto - tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao")
                            tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3)
                            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

                            If Me.Tag = "AlterarPedido" Then
                                If tbPedidoAtual.Rows.Item(i).Item("CodPedAut") = "" Then
                                    MsgBox("Item inválido, escolha novamente.", MsgBoxStyle.Exclamation)
                                    Exit Sub
                                ElseIf tbPedidoAtual.Rows.Item(i).Item("CodPedAut") > 0 Then
                                    Dim strNovoItem As String = tbPedidoAtual.Rows.Item(i).Item("CodPedAut")
                                    vetDelete.Add(strNovoItem)


                                End If

                            End If

                            tbPedidoAtual.Rows.RemoveAt(i)
                            LimparProdutos()
                            bolStatusAlteracao = False
                            Exit Sub


                        ElseIf Me.txtRemoverQtd.Text < tbPedidoAtual.Rows.Item(i).Item("Qtde") Then 'Quantidades Diferentes para serem removidas - atualizar valores do datatable
                            If tbPedidoAtual.Rows.Item(i).Item("Tipo") = "VENDA" Then
                                dblSomaVenda = dblSomaVenda - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                                Me.txtTotalProdutos.Text = FormatNumber(dblSomaVenda, 3)
                            Else
                                dblSomaServico = dblSomaServico - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                                Me.txtTotalServicos.Text = FormatNumber(dblSomaServico, 3)

                            End If

                            dblSomaGeral = dblSomaGeral - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text
                            Me.txtTotalGeral.Text = FormatNumber(dblSomaGeral, 3)

                            dblSomaDesconto = FormatNumber(dblSomaDesconto - (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde")) * Me.txtRemoverQtd.Text / Me.txtRemoverQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") - (tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde")) * Me.txtRemoverQtd.Text, 3)
                            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

                            tbPedidoAtual.Rows.Item(i).Item("Qtde") = FormatNumber(Me.tbPedidoAtual.Rows.Item(i).Item("Qtde") - Me.txtRemoverQtd.Text, 3)
                            tbPedidoAtual.Rows.Item(i).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("ValorTotal") - tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * Me.txtRemoverQtd.Text, 3)
                            LimparProdutos()
                            Exit Sub
                        End If
                    End If
                Next
                MsgBox("Não há produto para ser removido! Tente Novamente.", MsgBoxStyle.Exclamation)
                LimparProdutos()
            End If
        End If

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnOrdem_Click(sender As Object, e As EventArgs) Handles btnOrdem.Click
        frmConsultaOrdem.ShowDialog()


        Dim dtOrdemSelect As DataTable = CarregarDataTable("select * from ItensConsig where CodOrdens = " & CodOrdem & "")


        If dtOrdemSelect.Rows.Count > 0 Then
            If Me.Tag = "ConsultarPedido" Or Me.Tag = "AlterarPedido" Then
                Me.tbPedidoAtual.Rows.Clear()
                Dim dblSomaValorDistribuido As Double = FormatNumber(0, 3)
                Dim dblSomaDescontoDistribuicao As Double = FormatNumber(0, 3)
                dblValorTotalGeralSemDesc = FormatNumber(0, 3)
                dblFrete = FormatNumber(0, 3)
                dblSomaGeral = FormatNumber(0, 3)

                Dim dtProdutoSelect As DataTable = CarregarDataTable("select C.Nome, C.CPF, C.Telefone, IC.CodOrdens, IC.CodPedAut, IC.CodigoProduto, P.Produto, IC.Qtd as 'Qtde', IC.DescSemDistribuicao, IC.DescComDistribuicao, P.Venda as 'SemDesc', IC.ValorUnitario, IC.ValorTotal, IC.Tipo from ItensConsig as IC left Join Produtos as P on IC.CodigoProduto = P.Codigo left Join TotalConsig as TC on TC.CodOrdens = IC.CodOrdens left Join Cliente as C on C.Codigo = TC.CodCli where IC.CodOrdens = " & CodOrdem & ";")
                txtNome.Text = dtProdutoSelect.Rows.Item(0).Item("Nome").ToString
                txtCpfCnpj.Text = dtProdutoSelect.Rows.Item(0).Item("CPF").ToString
                txtTelefone.Text = dtProdutoSelect.Rows.Item(0).Item("Telefone").ToString
                txtOrdem.Text = dtOrdemSelect.Rows.Item(0).Item("CodOrdens")
                For i = 0 To dtProdutoSelect.Rows.Count - 1
                    tbPedidoAtual.Rows.Add(0)
                    Dim PosicaoLinha As Integer = tbPedidoAtual.Rows.Count - 1
                    Dim dbValor As Double = dtProdutoSelect.Rows.Item(i).Item("DescComDistribuicao")
                    dblSomaValorDistribuido = FormatNumber(dblSomaValorDistribuido + dbValor, 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("CodProd") = dtProdutoSelect.Rows.Item(i).Item("CodigoProduto")
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Produto") = dtProdutoSelect.Rows.Item(i).Item("Produto")
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Qtde") = FormatNumber(dtProdutoSelect.Rows.Item(i).Item("Qtde"), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("DescSemDistribuicao") = FormatNumber(dtProdutoSelect.Rows.Item(i).Item("DescSemDistribuicao"), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("SemDesc") = FormatNumber(dtProdutoSelect.Rows.Item(i).Item("SemDesc"), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorUnitario") = FormatNumber(dtProdutoSelect.Rows.Item(i).Item("ValorUnitario"), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorTotal") = FormatNumber(FormatNumber(dtProdutoSelect.Rows.Item(i).Item("ValorTotal"), 3), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("DescComDistribuicao") = FormatNumber(dtProdutoSelect.Rows.Item(i).Item("DescComDistribuicao"), 3)
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("Tipo") = dtProdutoSelect.Rows.Item(i).Item("Tipo")
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("CodPedAut") = dtProdutoSelect.Rows.Item(i).Item("CodPedAut")
                    tbPedidoAtual.Rows.Item(PosicaoLinha).Item("CodOrdens") = dtProdutoSelect.Rows.Item(i).Item("CodOrdens")
                    dblSomaGeral = dblSomaGeral + tbPedidoAtual.Rows.Item(PosicaoLinha).Item("ValorTotal")
                Next
                Dim tbselect As DataTable = CarregarDataTable("select Total from TotalConsig where CodOrdens = " & CodOrdem & "; ")

                Me.txtValorFrete.Text = FormatNumber(tbselect.Rows.Item(0).Item("Total") - dblSomaGeral, 3)

                Me.txtValorDistribuido.Text = FormatNumber(dblSomaValorDistribuido, 3)
                SomarTotalProdutoServico()

                For i = 0 To tbPedidoAtual.Rows.Count - 1
                    If tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                        dblValorTotalGeralSemDesc = FormatNumber(dblValorTotalGeralSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                    End If
                Next

                If dblValorTotalGeralSemDesc = FormatNumber(0, 3) Then
                    txtPorcentagem.Text = FormatNumber(0, 3)
                    txtValorDistribuido.Text = FormatNumber(0, 3)
                    Exit Sub
                End If

                Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblValorTotalGeralSemDesc, 3)
            End If
        End If
    End Sub
    Private Sub txtAlterarGrid_Click(sender As Object, e As EventArgs) Handles txtAlterarGrid.Click

    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        indexPedidoAtual = Me.grd1.FocusedRowHandle
        CodigoProduto = Me.grd1.GetRowCellValue(indexPedidoAtual, colCodProd)
        If tabAddRemover.SelectedTabPageIndex = 0 And IsNumeric(CodigoProduto) Then 'ADD Produto
            bolStatusAlteracao = True
            Me.txtAddProduto.Text = tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Produto")
            Me.txtAddQtd.Text = FormatNumber(1, 3)
            Me.txtDesconto.Text = FormatNumber(tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("SemDesc") - tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorUnitario"), 3)
            Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text / tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("SemDesc") * 100, 3)
            Me.txtPreco.Text = FormatNumber(tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("ValorUnitario"), 3)

            If tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("CodigoInterno").ToString = "" Then
                Me.txtAddCodigoInterno.Text = ""
            Else
                Me.txtAddCodigoInterno.Text = tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("CodigoInterno")
            End If

        ElseIf tabAddRemover.SelectedTabPageIndex = 1 And IsNumeric(CodigoProduto) Then 'Remover Produto
            Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")

            If dtProdutoSelect.Rows.Count > 0 Then
                Me.txtRemoverCodigo.Text = dtProdutoSelect.Rows.Item(0).Item("CodigoInterno")
                Me.txtRemoverProduto.Text = tbPedidoAtual.Rows.Item(indexPedidoAtual).Item("Produto")
                Me.txtRemoverQtd.Text = FormatNumber(1, 3)
            End If

        End If

    End Sub

    Private Sub txtRemoverQtd_Leave(sender As Object, e As EventArgs) Handles txtRemoverQtd.Leave

        If txtRemoverQtd.Text = "" Then
            MsgBox("Valor inválido! tente novamente", MsgBoxStyle.Exclamation)
            txtRemoverQtd.Text = FormatNumber(1, 3)
            Exit Sub
        End If

        Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")
        If ProdutoSelect.Rows.Count > 0 Then
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("Produto") = ProdutoSelect.Rows.Item(0).Item("Produto") Then
                    If txtRemoverQtd.Text <= 0 Then
                        MsgBox("Valor inválido! tente novamente", MsgBoxStyle.Exclamation)
                        txtRemoverQtd.Text = FormatNumber(1, 3)
                        Exit Sub


                    ElseIf txtRemoverQtd.Text > tbPedidoAtual.Rows.Item(i).Item("Qtde") Then
                        MsgBox("Valor inválido! tente novamente", MsgBoxStyle.Exclamation)
                        txtRemoverQtd.Text = FormatNumber(1, 3)
                        Exit Sub
                    End If
                End If
            Next
        End If
        cfgLeaveNumVirgulas(txtRemoverQtd)

    End Sub

    Private Sub txtAddQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddQtd.KeyPress
        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtAddQtd_Leave(sender As Object, e As EventArgs) Handles txtAddQtd.Leave
        If txtAddQtd.Text = "" Then
            txtAddQtd.Text = 1
        End If

        If txtAddQtd.Text <= 0 Then
            MsgBox("Valor inválido! tente novamente", MsgBoxStyle.Exclamation)
            txtRemoverQtd.Text = FormatNumber(1, 3)
        End If

        cfgLeaveNumVirgulas(txtAddQtd)
    End Sub

    Private Sub txtDescontoPorc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescontoPorc.KeyPress
        cfgPressNumVirgulas(txtDescontoPorc, e)
    End Sub

    Private Sub txtDescontoPorc_Leave(sender As Object, e As EventArgs) Handles txtDescontoPorc.Leave
        cfgLeaveNumVirgulas(txtDescontoPorc)
        Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")
        If ProdutoSelect.Rows.Count > 0 Then
            If txtDescontoPorc.Text = "" Then
                Me.txtDescontoPorc.Text = FormatNumber(0, 3)
                Me.txtDesconto.Text = FormatNumber(0, 3)
                Me.txtPreco.Text = FormatNumber(0, 3)
            Else
                Me.txtDesconto.Text = FormatNumber(ProdutoSelect.Rows.Item(0).Item("Venda") * (Me.txtDescontoPorc.Text) / 100, 3)
                Me.txtPreco.Text = FormatNumber((ProdutoSelect.Rows.Item(0).Item("Venda")) - Me.txtDesconto.Text, 3)
            End If
        End If

        cfgLeaveNumVirgulas(txtDescontoPorc)
        cfgLeaveNumVirgulas(txtDesconto)
    End Sub

    Private Sub txtDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        cfgPressNumVirgulas(txtDesconto, e)
    End Sub

    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        cfgLeaveNumVirgulas(txtDesconto)
        Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")
        If ProdutoSelect.Rows.Count > 0 Then
            If txtDesconto.Text = "" Then
                Me.txtDesconto.Text = FormatNumber(0, 3)
                Me.txtDescontoPorc.Text = FormatNumber(0, 3)
                Me.txtPreco.Text = FormatNumber(0, 3)

            End If
            Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text / ProdutoSelect.Rows.Item(0).Item("Venda") * 100, 3)
            Me.txtPreco.Text = FormatNumber((ProdutoSelect.Rows.Item(0).Item("Venda")) - Me.txtDesconto.Text, 3)
        End If

        cfgLeaveNumVirgulas(txtDesconto)
        cfgLeaveNumVirgulas(txtDescontoPorc)
    End Sub

    Private Sub txtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreco.KeyPress
        cfgPressNumVirgulas(txtPreco, e)
    End Sub

    Private Sub txtPreco_Leave(sender As Object, e As EventArgs) Handles txtPreco.Leave
        Dim ProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")

        If ProdutoSelect.Rows.Count > 0 Then
            If txtPreco.Text = "" Then
                txtPreco.Text = FormatNumber(0, 3)
            End If

            Me.txtDesconto.Text = FormatNumber(ProdutoSelect.Rows.Item(0).Item("Venda") - Me.txtPreco.Text, 3)
            Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text * 100 / ProdutoSelect.Rows.Item(0).Item("Venda"), 3)
        End If

        cfgLeaveNumVirgulas(txtPreco)
    End Sub

    Private Sub txtRQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemoverQtd.KeyPress
        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAddCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddCodigoInterno.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtValorFrete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorFrete.KeyPress
        cfgPressNumVirgulas(txtValorFrete, e)
    End Sub

    Private Sub txtValorFrete_Leave(sender As Object, e As EventArgs) Handles txtValorFrete.Leave
        cfgLeaveNumVirgulas(txtValorFrete)

        If Me.txtValorFrete.Text = "" Then
            Me.txtValorFrete.Text = FormatNumber(0, 3)
        End If
        SomarTotalProdutoServico()

    End Sub

    Private Sub txtPorcentagem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentagem.KeyPress
        cfgPressNumVirgulas(txtPorcentagem, e)
    End Sub

    Private Sub txtPorcentagem_Leave(sender As Object, e As EventArgs) Handles txtPorcentagem.Leave

        Dim dblValorTotalGeralSemDesc As Double = FormatNumber(0, 3)
        Dim dblvalorTotalVendaSemDesc As Double = FormatNumber(0, 3)
        Dim dblValorTotalServicoSemDesc As Double = FormatNumber(0, 3)

        Dim i As Integer
        If txtPorcentagem.Text = "" Then
            txtPorcentagem.Text = FormatNumber(0, 3)
        End If

        If tbPedidoAtual.Rows.Count > 0 Then
            ResetarTotalUnitario()
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                    dblValorTotalGeralSemDesc = FormatNumber(dblValorTotalGeralSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)
                End If

                If tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "VENDA" Then
                    dblvalorTotalVendaSemDesc = FormatNumber(dblvalorTotalVendaSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)
                End If

                If tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "SERVIÇO" Then
                    dblValorTotalServicoSemDesc = FormatNumber(dblValorTotalServicoSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)

                End If
            Next
        Else
            Exit Sub
        End If


        Select Case rdgDescontoAcrescimo.SelectedIndex
            Case 0 'DESCONTO
                Select Case rdgTPS.SelectedIndex
                    Case 0 'TOTAL
                        Dim z
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblValorTotalGeralSemDesc / 100) / dblValorTotalGeralSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalGeralSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalGeralSemDesc / 100, 3)

                    Case 1 'PRODUTO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1

                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "VENDA" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblvalorTotalVendaSemDesc / 100) / dblvalorTotalVendaSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblvalorTotalVendaSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalGeralSemDesc / 100, 3)

                    Case 2 'SERVIÇO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "SERVIÇO" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblValorTotalServicoSemDesc / 100) / dblValorTotalServicoSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalServicoSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalGeralSemDesc / 100, 3)

                End Select

            Case 1 'ACRÉSCIMO
                Select Case rdgTPS.SelectedIndex
                    Case 0 'TOTAL
                        Dim z
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblValorTotalGeralSemDesc / 100) / dblValorTotalGeralSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalGeralSemDesc = Format(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalGeralSemDesc / 100, 3)

                    Case 1 'PRODUTO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "VENDA" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblvalorTotalVendaSemDesc / 100) / dblvalorTotalVendaSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblvalorTotalVendaSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If
                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalGeralSemDesc / 100, 3)

                    Case 2 'SERVIÇO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "SERVIÇO" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * (Me.txtPorcentagem.Text * dblValorTotalServicoSemDesc / 100) / dblValorTotalServicoSemDesc)
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)

                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                                Me.txtValorDistribuido.Text = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalServicoSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorPorcentagem As Double = FormatNumber(Me.txtPorcentagem.Text, 3)
                        Me.txtValorDistribuido.Text = FormatNumber(dblValorPorcentagem * dblValorTotalServicoSemDesc / 100, 3)

                End Select
        End Select
        cfgLeaveNumVirgulas(txtPorcentagem)

    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorDistribuido.KeyPress
        cfgPressNumVirgulas(txtValorDistribuido, e)
    End Sub

    Private Sub txtValorDistribuido_Leave(sender As Object, e As EventArgs) Handles txtValorDistribuido.Leave
        dblValorTotalGeralSemDesc = FormatNumber(0, 3)
        Dim dblvalorTotalVendaSemDesc As Double = FormatNumber(0, 3)
        Dim dblValorTotalServicoSemDesc As Double = FormatNumber(0, 3)

        Dim i As Integer
        If txtValorDistribuido.Text = "" Then
            txtValorDistribuido.Text = FormatNumber(0, 3)
        End If

        If tbPedidoAtual.Rows.Count > 0 Then
            ResetarTotalUnitario()
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                    dblValorTotalGeralSemDesc = FormatNumber(dblValorTotalGeralSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)
                End If

                If tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "VENDA" And tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                    dblvalorTotalVendaSemDesc = FormatNumber(dblvalorTotalVendaSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)
                End If

                If tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "SERVIÇO" And tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                    dblValorTotalServicoSemDesc = FormatNumber(dblValorTotalServicoSemDesc + tbPedidoAtual.Rows.Item(i).Item("ValorTotal"), 3)

                End If
            Next
        Else
            Exit Sub
        End If


        Select Case rdgDescontoAcrescimo.SelectedIndex
            Case 0 'DESCONTO
                Select Case rdgTPS.SelectedIndex
                    Case 0 'TOTAL
                        Dim z
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblValorTotalGeralSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()

                        If dblValorTotalGeralSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblValorTotalGeralSemDesc, 3)

                    Case 1 'PRODUTO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1

                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "VENDA" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblvalorTotalVendaSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next

                        SomarTotalProdutoServico()
                        If dblvalorTotalVendaSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblvalorTotalVendaSemDesc, 3)

                    Case 2 'SERVIÇO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "SERVIÇO" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblValorTotalServicoSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") - dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") + dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalServicoSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblValorTotalServicoSemDesc, 3)

                End Select

            Case 1 'ACRÉSCIMO
                Select Case rdgTPS.SelectedIndex
                    Case 0 'TOTAL
                        Dim z
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblValorTotalGeralSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next

                        SomarTotalProdutoServico()
                        If dblValorTotalGeralSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblValorTotalGeralSemDesc, 3)

                    Case 1 'PRODUTO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "VENDA" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblvalorTotalVendaSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                            End If
                        Next

                        SomarTotalProdutoServico()
                        If dblvalorTotalVendaSemDesc = FormatNumber(0, 3) Then
                            txtPorcentagem.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblvalorTotalVendaSemDesc, 3)

                    Case 2 'SERVIÇO
                        For z = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(z).Item("Tipo").ToString = "SERVIÇO" And tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao").ToString = FormatNumber(0, 3) Then
                                Dim dblCalculoDistribuicao As Double = (tbPedidoAtual.Rows.Item(z).Item("SemDesc") * txtValorDistribuido.Text) / dblValorTotalServicoSemDesc
                                tbPedidoAtual.Rows.Item(z).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") + dblCalculoDistribuicao, 3)
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("DescSemDistribuicao") - dblCalculoDistribuicao * tbPedidoAtual.Rows.Item(z).Item("Qtde"), 3)
                                tbPedidoAtual.Rows.Item(z).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(z).Item("SemDesc") * tbPedidoAtual.Rows.Item(z).Item("Qtde") - tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao"), 3)
                            Else
                                tbPedidoAtual.Rows.Item(z).Item("DescComDistribuicao") = FormatNumber(0, 3)
                                Me.txtPorcentagem.Text = FormatNumber(0, 3)
                            End If
                        Next
                        SomarTotalProdutoServico()
                        If dblValorTotalServicoSemDesc = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                            Me.txtValorDistribuido.Text = FormatNumber(0, 3)
                            Exit Sub
                        End If

                        Dim dblValorDistribuido As Double = Me.txtValorDistribuido.Text
                        Me.txtPorcentagem.Text = FormatNumber(100 * dblValorDistribuido / dblValorTotalServicoSemDesc, 3)


                End Select
        End Select
        cfgLeaveNumVirgulas(txtValorDistribuido)
    End Sub

    Private Sub txtTotalDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalDesconto.KeyPress
        cfgPressNumVirgulas(txtTotalDesconto, e)
    End Sub

    Private Sub txtTotalDesconto_Leave(sender As Object, e As EventArgs) Handles txtTotalDesconto.Leave
        cfgLeaveNumVirgulas(txtTotalDesconto)
    End Sub

    Private Sub rdgTPS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdgTPS.SelectedIndexChanged
        If Me.Tag = "CadastrarPedido" Then
            ResetarTotalUnitario()
            Me.txtValorDistribuido.Text = FormatNumber(0, 3)
            Me.txtPorcentagem.Text = FormatNumber(0, 3)
            SomarTotalProdutoServico()


        ElseIf Me.Tag = "ConsultarPedido" Then
            Select Case rdgDescontoAcrescimo.SelectedIndex
                Case 0
                    If rdgTPS.SelectedIndex = 0 Then 'Total
                        Dim dblSomarDesconto As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComDesconto As Double

                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") > 0 Then
                                dblSomarDesconto = FormatNumber(dblSomarDesconto + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComDesconto = FormatNumber(dblSomarTotalProdComDesconto + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarDesconto, 3)

                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarDesconto, 3)
                        If dblSomarDesconto = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarDesconto * 100 / dblSomarTotalProdComDesconto, 3)
                        End If
                    ElseIf rdgTPS.SelectedIndex = 1 Then
                        Dim dblSomarDesconto As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComDesconto As Double

                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") > 0 And tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "VENDA" Then
                                dblSomarDesconto = FormatNumber(dblSomarDesconto + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComDesconto = FormatNumber(dblSomarTotalProdComDesconto + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarDesconto, 3)

                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarDesconto, 3)
                        If dblSomarDesconto = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarDesconto * 100 / dblSomarTotalProdComDesconto, 3)
                        End If
                    ElseIf rdgTPS.SelectedIndex = 2 Then
                        Dim dblSomarDesconto As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComDesconto As Double

                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") > 0 And tbPedidoAtual.Rows.Item(i).Item("Tipo").ToString = "SERVIÇO" Then
                                dblSomarDesconto = FormatNumber(dblSomarDesconto + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComDesconto = FormatNumber(dblSomarTotalProdComDesconto + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarDesconto, 3)

                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarDesconto, 3)
                        If dblSomarDesconto = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarDesconto * 100 / dblSomarTotalProdComDesconto, 3)
                        End If
                    End If
                    SomarTotalProdutoServico()
                Case 1
                    If rdgTPS.SelectedIndex = 0 Then
                        Dim dblSomarAcrescimo As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComAcrescimo As Double
                        lblTotalDesconto.Text = "Total Acréscimo R$"
                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") < 0 Then
                                dblSomarAcrescimo = FormatNumber(dblSomarAcrescimo + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComAcrescimo = FormatNumber(dblSomarTotalProdComAcrescimo + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarAcrescimo, 3)
                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarAcrescimo, 3)
                        If dblSomarAcrescimo = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarAcrescimo * 100 / dblSomarTotalProdComAcrescimo, 3)
                        End If
                    ElseIf rdgTPS.SelectedIndex = 1 Then
                        Dim dblSomarAcrescimo As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComAcrescimo As Double
                        lblTotalDesconto.Text = "Total Acréscimo R$"
                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") < 0 And tbPedidoAtual.Rows.Item(i).Item("Tipo") = "VENDA" Then
                                dblSomarAcrescimo = FormatNumber(dblSomarAcrescimo + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComAcrescimo = FormatNumber(dblSomarTotalProdComAcrescimo + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarAcrescimo, 3)
                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarAcrescimo, 3)
                        If dblSomarAcrescimo = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarAcrescimo * 100 / dblSomarTotalProdComAcrescimo, 3)
                        End If
                    ElseIf rdgTPS.SelectedIndex = 2 Then
                        Dim dblSomarAcrescimo As Double = FormatNumber(0, 3)
                        Dim dblSomarTotalProdComAcrescimo As Double
                        lblTotalDesconto.Text = "Total Acréscimo R$"
                        Me.txtTotalDesconto.Text = FormatNumber(0, 3)
                        For i = 0 To tbPedidoAtual.Rows.Count - 1
                            If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") < 0 And tbPedidoAtual.Rows.Item(i).Item("Tipo") = "SERVIÇO" Then
                                dblSomarAcrescimo = FormatNumber(dblSomarAcrescimo + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                                dblSomarTotalProdComAcrescimo = FormatNumber(dblSomarTotalProdComAcrescimo + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarAcrescimo, 3)
                            End If
                        Next
                        Me.txtValorDistribuido.Text = FormatNumber(dblSomarAcrescimo, 3)
                        If dblSomarAcrescimo = FormatNumber(0, 3) Then
                            Me.txtPorcentagem.Text = FormatNumber(0, 3)
                        Else
                            Me.txtPorcentagem.Text = FormatNumber(dblSomarAcrescimo * 100 / dblSomarTotalProdComAcrescimo, 3)
                        End If
                    End If
                    SomarTotalProdutoServico()
            End Select
        End If
    End Sub

    Private Sub rdgDescontoAcrescimo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdgDescontoAcrescimo.SelectedIndexChanged

        If Me.Tag = "CadastrarPedido" Then
            ResetarTotalUnitario()
            Me.txtValorDistribuido.ResetText()
            Me.txtPorcentagem.ResetText()
        End If


        If rdgDescontoAcrescimo.SelectedIndex = 0 Then
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") <> FormatNumber(0, 3) And tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") < 0 Then
                    tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber((-1) * tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao"), 3)
                    tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("SemDesc") - tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde"), 3)
                    tbPedidoAtual.Rows.Item(i).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * tbPedidoAtual.Rows.Item(i).Item("Qtde"), 3)
                End If
            Next

            lblTotalDesconto.Text = "Total Desconto R$"
            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)

            Dim dblSomarDesconto As Double = FormatNumber(0, 3)
            Dim dblSomarTotalProdComDesconto As Double

            Me.txtTotalDesconto.Text = FormatNumber(0, 3)
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") > 0 Then
                    dblSomarDesconto = FormatNumber(dblSomarDesconto + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                    dblSomarTotalProdComDesconto = FormatNumber(dblSomarTotalProdComDesconto + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarDesconto, 3)

                End If
            Next
            Me.txtValorDistribuido.Text = FormatNumber(dblSomarDesconto, 3)
            If dblSomarDesconto = FormatNumber(0, 3) Then
                Me.txtPorcentagem.Text = FormatNumber(0, 3)
            Else
                Me.txtPorcentagem.Text = FormatNumber(dblSomarDesconto * 100 / dblSomarTotalProdComDesconto, 3)
            End If

        Else
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") <> FormatNumber(0, 3) And tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") > 0 Then
                    tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") = FormatNumber((-1) * tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao"), 3)
                    tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("SemDesc") - tbPedidoAtual.Rows.Item(i).Item("DescSemDistribuicao") / tbPedidoAtual.Rows.Item(i).Item("Qtde"), 3)
                    tbPedidoAtual.Rows.Item(i).Item("ValorTotal") = FormatNumber(tbPedidoAtual.Rows.Item(i).Item("ValorUnitario") * tbPedidoAtual.Rows.Item(i).Item("Qtde"), 3)
                End If
            Next

            Dim dblSomarAcrescimo As Double = FormatNumber(0, 3)
            Dim dblSomarTotalProdComAcrescimo As Double
            lblTotalDesconto.Text = "Total Acréscimo R$"
            Me.txtTotalDesconto.Text = FormatNumber(dblSomaDesconto, 3)
            For i = 0 To tbPedidoAtual.Rows.Count - 1
                If tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao") < 0 Then
                    dblSomarAcrescimo = FormatNumber(dblSomarAcrescimo + tbPedidoAtual.Rows.Item(i).Item("DescComDistribuicao"), 3)
                    dblSomarTotalProdComAcrescimo = FormatNumber(dblSomarTotalProdComAcrescimo + tbPedidoAtual.Rows.Item(i).Item("ValorTotal") + dblSomarAcrescimo, 3)
                End If
            Next
            Me.txtValorDistribuido.Text = FormatNumber(dblSomarAcrescimo, 3)
            If dblSomarAcrescimo = FormatNumber(0, 3) Then
                Me.txtPorcentagem.Text = FormatNumber(0, 3)
            Else
                Me.txtPorcentagem.Text = FormatNumber(dblSomarAcrescimo * 100 / dblSomarTotalProdComAcrescimo, 3)
            End If

        End If
        SomarTotalProdutoServico()
        If txtTotalDesconto.Text < 0 Then
            txtTotalDesconto.Text = (-1) * txtTotalDesconto.Text
        End If
    End Sub

    Private Sub txtNome_Click(sender As Object, e As EventArgs) Handles txtNome.Click
        frmCadCliente.Tag = "ConsultarCliente"
        frmCadCliente.ShowDialog()
        Dim ClienteSelect As DataTable = CarregarDataTable("select * from Cliente where Codigo = " & CodigoCliente & "")

        If ClienteSelect.Rows.Count > 0 Then
            Me.txtNome.Text = ClienteSelect.Rows.Item(0).Item("Nome").ToString
            Me.txtCpfCnpj.Text = ClienteSelect.Rows.Item(0).Item("CPF").ToString
            Me.txtEmail.Text = ClienteSelect.Rows.Item(0).Item("Email").ToString
            Me.txtTelefone.Text = ClienteSelect.Rows.Item(0).Item("Telefone").ToString
            Me.txtCelular.Text = ClienteSelect.Rows.Item(0).Item("Celular").ToString
        End If
    End Sub

    Private Sub txtRemoverProduto_Click(sender As Object, e As EventArgs) Handles txtRemoverProduto.Click

        frmCadProdutos.Tag = "ConsultarProdutoRemover"
        frmCadProdutos.ShowDialog()

        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")

        If dtProdutoSelect.Rows.Count > 0 Then
            Me.txtRemoverCodigo.Text = dtProdutoSelect.Rows.Item(0).Item("Codigo")
            Me.txtRemoverProduto.Text = dtProdutoSelect.Rows.Item(0).Item("Produto")
            Me.txtRemoverQtd.Text = FormatNumber(1, 3)
        End If
    End Sub

    Private Sub txtAddProduto_Click(sender As Object, e As EventArgs) Handles txtAddProduto.Click
        frmCadProdutos.Tag = "ConsultarProdutoAdicionar"
        frmCadProdutos.ShowDialog()
        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Produtos where Codigo = " & CodigoProduto & "")


        If dtProdutoSelect.Rows.Count > 0 Then
            Me.txtAddCodigoInterno.Text = dtProdutoSelect.Rows.Item(0).Item("CodigoInterno")
            Me.txtAddProduto.Text = dtProdutoSelect.Rows.Item(0).Item("Produto").ToString
            Me.txtAddQtd.Text = FormatNumber(1, 3)


            If dtProdutoSelect.Rows.Item(0).Item("Desconto") = "" Then
                Me.txtDescontoPorc.Text = FormatNumber(0, 3)
                Me.txtDesconto.Text = FormatNumber(0, 3)

            Else
                Me.txtDesconto.Text = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Desconto"), 3)
                Me.txtDescontoPorc.Text = FormatNumber(Me.txtDesconto.Text / dtProdutoSelect.Rows.Item(0).Item("Venda") * 100, 3)
            End If

            Me.txtPreco.Text = FormatNumber(dtProdutoSelect.Rows.Item(0).Item("Venda") - Me.txtDesconto.Text, 3)
        End If
    End Sub

    Private Sub memObservacoes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles memObservacoes.KeyPress, txtRemoverCodigo.KeyPress, cboVendedor.KeyPress, cboStatusNano.KeyPress, cboNossoStatus.KeyPress, txtNivelComb.KeyPress, txtMotor.KeyPress, txtModelo.KeyPress, txtKmSaida.KeyPress, txtKmEntrada.KeyPress, txtCor.KeyPress, txtAno.KeyPress, memDefeitosVeiculo.KeyPress, ComboBoxEdit2.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDataEntrada_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDesconto_EditValueChanged(sender As Object, e As EventArgs) Handles txtDesconto.EditValueChanged

    End Sub

    Private Sub txtAddQtd_EditValueChanged(sender As Object, e As EventArgs) Handles txtAddQtd.EditValueChanged

    End Sub

    Private Sub txtDescontoPorc_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescontoPorc.EditValueChanged

    End Sub

    Private Sub txtRemoverQtd_EditValueChanged(sender As Object, e As EventArgs) Handles txtRemoverQtd.EditValueChanged
        
    End Sub

    Private Sub btnRemoverPesquisarGrid_EditValueChanged(sender As Object, e As EventArgs) Handles btnRemoverPesquisarGrid.EditValueChanged

    End Sub

    Private Sub tabRemoverProdutos_Paint(sender As Object, e As PaintEventArgs) Handles tabRemoverProdutos.Paint

    End Sub

    Private Sub tabAddRemover_Click(sender As Object, e As EventArgs) Handles tabAddRemover.Click
    End Sub

    Private Sub tabAddRemover_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabAddRemover.SelectedPageChanged
        LimparProdutos()
    End Sub
End Class
