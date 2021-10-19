Imports DevExpress.XtraReports.UI
Imports telausuario.clsFuncao
Imports telausuario.modBloqueios
Public Class frmCadCliente
    Dim bolStatusAlteracao As Boolean
    Dim intCodigo As Integer

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        AtualizarGrid()

        'Bloqueios 
        If bolBloquearCadastroCliente = True Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

    End Sub

    Private Sub AtualizarGrid()
        CarregarDados("select Codigo, Nome, Fantasia, CPF, RGIE, Sexo, Status, Cep, Estado, Cidade, Endereco, Numero, Complemento, Bairro, Telefone, Email, Contato, Inativo, Observacao from Cliente", grdClientesCad)
    End Sub
    Private Sub Limpar()
        bolStatusAlteracao = False
        intCodigo = 0

        Me.tabClientes.SelectedTabPageIndex = 0
        Me.grd1.ClearColumnsFilter()

        Me.txtNomeRazao.ResetText()
        Me.txtFantasia.ResetText()
        Me.rdgCpfCnpj.SelectedIndex = 0
        Me.txtCpfCnpj.ResetText()
        Me.txtRgIe.ResetText()
        Me.dtNascim.ResetText()
        Me.cboSexo.SelectedIndex = -1
        Me.cboStatus.SelectedIndex = -1
        Me.tabEndereco.SelectedTabPageIndex = 0
        Me.txtClienteCep.ResetText()
        Me.cboClienteUf.SelectedIndex = -1
        Me.cboClienteCidade.SelectedIndex = -1
        Me.txtClienteEndereco.ResetText()
        Me.txtClienteNum.ResetText()
        Me.txtClienteComp.ResetText()
        Me.cboClienteBairro.SelectedIndex = -1
        Me.txtTelefone1.ResetText()
        Me.txtTelefone2.ResetText()
        Me.txtEmail.ResetText()
        Me.txtTelefone3.ResetText()
        Me.txtContato.ResetText()
        Me.chkInativo.Checked = False
        Me.chkPendencia.Checked = False
        Me.memObservacoes.ResetText()
        Me.cboAniverMes.SelectedIndex = -1

        If bolBloquearCadastroCliente = False And BolBloquearAlterarCliente = True Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub Alterar()
        Atualizar("update Cliente set Nome = '" & Me.txtNomeRazao.Text & "', Fantasia = '" & Me.txtFantasia.Text & "', " & _
                  "CPF = '" & Me.txtCpfCnpj.Text & "', RGIE = '" & Me.txtRgIe.Text & "', Sexo = '" & Me.cboSexo.Text & "', " & _
                  "Status ='" & Me.cboStatus.Text & "', Cep = '" & Me.txtClienteCep.Text & "', Estado = '" & Me.cboClienteUf.Text & "', " & _
                  "Cidade = '" & Me.cboClienteCidade.Text & "', Endereco = '" & Me.txtClienteEndereco.Text & "', Numero = '" & Me.txtClienteNum.Text & "', " & _
                  "Complemento = '" & Me.txtClienteComp.Text & "', Bairro = '" & Me.cboClienteBairro.Text & "', Telefone = '" & Me.txtTelefone1.Text & "', " & _
                  "Email = '" & Me.txtEmail.Text & "', Contato = '" & Me.txtContato.Text & "', Inativo = '" & Me.chkInativo.Checked & "', " & _
                  "Observacao = '" & Me.memObservacoes.Text & "'  where Codigo = " & intCodigo & ";")
    End Sub

    Private Sub InserirDados()
        Inserir("insert into cliente (Nome, Fantasia, CPF, RGIE, Sexo, Status, Cep, Estado, Cidade, Endereco, Numero, Complemento, Bairro, " & _
                "Telefone, Email, Contato, Inativo, Observacao) values ('" & Me.txtNomeRazao.Text & "', '" & Me.txtFantasia.Text & "', " & _
                "'" & Me.txtCpfCnpj.Text & "', '" & Me.txtRgIe.Text & "', '" & Me.cboSexo.Text & "', '" & Me.cboStatus.Text & "', " & _
                "'" & Me.txtClienteCep.Text & "', '" & Me.cboClienteUf.Text & "', '" & Me.cboClienteCidade.Text & "', " & _
                "'" & Me.txtClienteEndereco.Text & "', '" & Me.txtClienteNum.Text & "', '" & Me.txtClienteComp.Text & "', " & _
                "'" & Me.cboClienteBairro.Text & "', '" & Me.txtTelefone1.Text & "', '" & Me.txtEmail.Text & "', '" & Me.txtContato.Text & "', " & _
                "'" & Me.chkInativo.Checked & "', '" & Me.memObservacoes.Text & "');")
        AtualizarGrid()
        Limpar()
    End Sub

    Private Sub DeletarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        Dim intCodigo As String = Me.grd1.GetRowCellValue(Index, colCodigo)
        Deletar("delete Cliente where Codigo = " & intCodigo & ";")
        AtualizarGrid()
        Limpar()
    End Sub

    Private Sub MostrarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        'Me.txtNomeRazao.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNome)

        intCodigo = Me.grd1.GetRowCellValue(Index, Me.colCodigo)
        Me.txtNomeRazao.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colNome)
        Me.txtFantasia.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colFantasia)
        Me.txtCpfCnpj.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colCPF)
        Me.txtRgIe.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colRGIE)
        Me.cboSexo.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colSexo)
        Me.cboStatus.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colStatus)
        Me.txtClienteCep.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colCep)
        Me.cboClienteUf.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colEstado)
        Me.cboClienteCidade.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colCidade)
        Me.txtClienteEndereco.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colEndereco)
        Me.txtClienteNum.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colNumero)
        Me.txtClienteComp.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colComplemento)
        Me.cboClienteBairro.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colBairro)
        Me.txtTelefone1.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colTelefone)
        Me.txtEmail.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colEmail)
        Me.txtContato.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colContato)
        Me.chkInativo.Checked = Me.grd1.GetRowCellValue(Index, Me.colInativo)
        Me.memObservacoes.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colObservacao)
    End Sub

    Private Sub btnExclui_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExclui.ItemClick
        If bolStatusAlteracao = True Then
            DeletarDados()
            AtualizarGrid()
            bolStatusAlteracao = False
            MsgBox("Registro Excluído.", MsgBoxStyle.Information)


        Else
            MsgBox("Falha! Selecione um registro e clique em Alterar.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If Me.txtNomeRazao.Text = "" Then
            MsgBox("O campo Nome/Razão é Obrigatório. Tente novamente.", MsgBoxStyle.Exclamation)
        Else
            If bolStatusAlteracao = True Then
                If intCodigo = "1" Then
                    Limpar()
                    MsgBox("Não é possível atualizar o registro 'CONSUMIDOR.", MsgBoxStyle.Exclamation)
                    bolStatusAlteracao = False
                    Exit Sub
                End If
                Alterar()
                AtualizarGrid()
                bolStatusAlteracao = False
                MsgBox("Alteração Realizada.", MsgBoxStyle.Information)
            Else
                InserirDados()
                MsgBox("Registro Adicionado com Sucesso.", MsgBoxStyle.Information)

                Dim contador As DataTable = CarregarDataTable("select count(*) from Cliente")
                txtClientesCadastrados.Text = contador.Rows.Item(0).Item(0)

            End If
            Limpar()
        End If
    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Dim ResultLimparCampo As DialogResult = MsgBox("Deseja Limpar Todos os Campos?", MsgBoxStyle.YesNo)
        If ResultLimparCampo = DialogResult.Yes Then
            Me.Limpar()
            bolStatusAlteracao = False
        End If

    End Sub

    Private Sub btnAlterar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Me.MostrarDados()
        bolStatusAlteracao = True

    End Sub

    Private Sub btnFIltrar_Click(sender As Object, e As EventArgs) Handles btnFIltrar.Click
        CarregarDados("select Nome, Fantasia, CPF, RGIE, Sexo, Status, Cep, Estado, Cidade, Endereco, Numero, Complemento, Bairro, Telefone, Email, Contato, Inativo, Observacao from Cliente where Nome = '" & cboAniverMes.Text & "';", grdClientesCad)

    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnBuscaCep_Click(sender As Object, e As EventArgs) Handles btnBuscaCep.Click
        Dim ht As Hashtable = BuscaCep(Me.txtClienteCep.Text)
        Me.txtClienteEndereco.Text = ht("tipologradouro") & " " & ht("logradouro")
        Me.cboClienteUf.Text = ht("UF")
        Me.cboClienteCidade.Text = ht("cidade")
        Me.cboClienteBairro.Text = ht("bairro")
    End Sub

    Private Sub txtClientesCadastrados_VisibleChanged(sender As Object, e As EventArgs) Handles txtClientesCadastrados.VisibleChanged
        cfgContador(txtClientesCadastrados, grd1)
    End Sub

    Private Sub txtCpfCnpj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpfCnpj.KeyPress
        'Aceitar apenas Números 
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'aceitar Delete
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If

        'PARA CPF 
        If rdgCpfCnpj.SelectedIndex = 0 Then
            Me.txtCpfCnpj.Properties.MaxLength = 14
            Select Case Me.txtCpfCnpj.Text.Length
                Case 3
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "."
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length

                Case 7
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "."
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length

                Case 11
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "-"
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length
            End Select


            'PARA CNPJ
        Else
            Me.txtCpfCnpj.Properties.MaxLength = 18
            Select Case Me.txtCpfCnpj.Text.Length
                Case 2
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "."
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length

                Case 6
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "."
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length

                Case 10
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "\"
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length

                Case 15
                    Me.txtCpfCnpj.Text = Me.txtCpfCnpj.Text & "-"
                    Me.txtCpfCnpj.SelectionStart = Me.txtCpfCnpj.Text.Length
            End Select
        End If

    End Sub

    Private Sub txtClienteCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClienteCep.KeyPress
        'Aceitar apenas Números 
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'Não aceitar Espaços
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If

        Me.txtClienteCep.Properties.MaxLength = 9
        If Me.txtClienteCep.Text.Length = 5 Then
            Me.txtClienteCep.Text = Me.txtClienteCep.Text & "-"
            Me.txtClienteCep.SelectionStart = Me.txtClienteCep.Text.Length
        End If
    End Sub

    Private Sub txtCpfCnpj_Leave(sender As Object, e As EventArgs) Handles txtCpfCnpj.Leave
        'CLIENTE CADASTRADO?

        If txtCpfCnpj.Text.Length <> 14 And rdgCpfCnpj.SelectedIndex = 0 Then
            MsgBox("CPF INVÁLIDO.", MsgBoxStyle.Exclamation)
            txtCpfCnpj.ResetText()
            Exit Sub

        ElseIf txtCpfCnpj.Text.Length <> 18 And rdgCpfCnpj.SelectedIndex = 1 Then
            MsgBox("CNPJ INVÁLIDO.", MsgBoxStyle.Exclamation)
            txtCpfCnpj.ResetText()
            Exit Sub

        End If

        Dim i As Integer
        For i = 0 To grd1.RowCount - 1
            If grd1.GetRowCellValue(i, colCPF) = txtCpfCnpj.Text Then
                MsgBox("Cliente já cadastrado nesse CPF/CNPJ.", MsgBoxStyle.Exclamation)
                txtCpfCnpj.ResetText()
                Exit Sub
            End If
        Next

        Dim strTesteCpfCnpj As String = txtCpfCnpj.Text
        strTesteCpfCnpj = strTesteCpfCnpj.Replace(".", "")
        strTesteCpfCnpj = strTesteCpfCnpj.Replace("-", "")
        strTesteCpfCnpj = strTesteCpfCnpj.Replace("\", "")


        'VALIDAÇÃO DE CPF 
        If rdgCpfCnpj.SelectedIndex = 0 And txtCpfCnpj.Text <> "" Then

            'VERIFICAR O PRIMEIRO DÍGITO PARA CPF
            Dim intSomaCpfUm As Integer
            Dim intRestoCpfUm As Integer

            intSomaCpfUm = strTesteCpfCnpj.Substring(0, 1) * 10 + strTesteCpfCnpj.Substring(1, 1) * 9 + strTesteCpfCnpj.Substring(2, 1) * 8 + strTesteCpfCnpj.Substring(3, 1) * 7 + strTesteCpfCnpj.Substring(4, 1) * 6 + strTesteCpfCnpj.Substring(5, 1) * 5 + strTesteCpfCnpj.Substring(6, 1) * 4 + strTesteCpfCnpj.Substring(7, 1) * 3 + strTesteCpfCnpj.Substring(8, 1) * 2
            intRestoCpfUm = 11 - (intSomaCpfUm Mod 11)

            If intRestoCpfUm = strTesteCpfCnpj.Substring(9, 1) Or (intRestoCpfUm >= 10 And strTesteCpfCnpj.Substring(9, 1) = 0) Then

                'VERIFICAR O SEGUNDO DÍGITO PARA CPF
                Dim intSomaCpfDois As Integer
                Dim intRestoCpfDois As Integer

                intSomaCpfDois = strTesteCpfCnpj.Substring(0, 1) * 11 + strTesteCpfCnpj.Substring(1, 1) * 10 + strTesteCpfCnpj.Substring(2, 1) * 9 + strTesteCpfCnpj.Substring(3, 1) * 8 + strTesteCpfCnpj.Substring(4, 1) * 7 + strTesteCpfCnpj.Substring(5, 1) * 6 + strTesteCpfCnpj.Substring(6, 1) * 5 + strTesteCpfCnpj.Substring(7, 1) * 4 + strTesteCpfCnpj.Substring(8, 1) * 3 + strTesteCpfCnpj.Substring(9, 1) * 2
                intRestoCpfDois = 11 - (intSomaCpfDois Mod 11)

                If intRestoCpfDois = strTesteCpfCnpj.Substring(10, 1) Or (intRestoCpfDois >= 10 And strTesteCpfCnpj.Substring(10, 1) = 0) Then 'CPF VERIFICADO

                Else
                    MsgBox("CPF INVÁLIDO!", MsgBoxStyle.Exclamation)
                    txtCpfCnpj.ResetText()
                End If

            Else
                MsgBox("CPF INVÁLIDO!", MsgBoxStyle.Exclamation)
                txtCpfCnpj.ResetText()
            End If

            'VALIDACAO DE CNPJ
        Else

            'VERIFICAR O PRIMEIRO DIGITO PARA CNPJ
            Dim intSomaCnpjUm As Integer
            Dim intRestoCnpjUm As Integer

            intSomaCnpjUm = strTesteCpfCnpj.Substring(11, 1) * 2 + strTesteCpfCnpj.Substring(10, 1) * 3 + strTesteCpfCnpj.Substring(9, 1) * 4 + strTesteCpfCnpj.Substring(8, 1) * 5 + strTesteCpfCnpj.Substring(7, 1) * 6 + strTesteCpfCnpj.Substring(6, 1) * 7 + strTesteCpfCnpj.Substring(5, 1) * 8 + strTesteCpfCnpj.Substring(4, 1) * 9 + strTesteCpfCnpj.Substring(3, 1) * 2 + strTesteCpfCnpj.Substring(2, 1) * 3 + strTesteCpfCnpj.Substring(1, 1) * 4 + strTesteCpfCnpj.Substring(0, 1) * 5
            intRestoCnpjUm = 11 - (intSomaCnpjUm Mod 11)

            If intRestoCnpjUm = strTesteCpfCnpj.Substring(12, 1) Or (intRestoCnpjUm >= 10 And strTesteCpfCnpj.Substring(12, 1) = 0) Then

                'VERIFICAR O SEGUNDO DÍGITO PARA CNPJ
                Dim intSomaCnpjDois As Integer
                Dim intRestoCnpjDois As Integer

                intSomaCnpjDois = strTesteCpfCnpj.Substring(12, 1) * 2 + strTesteCpfCnpj.Substring(11, 1) * 3 + strTesteCpfCnpj.Substring(10, 1) * 4 + strTesteCpfCnpj.Substring(9, 1) * 5 + strTesteCpfCnpj.Substring(8, 1) * 6 + strTesteCpfCnpj.Substring(7, 1) * 7 + strTesteCpfCnpj.Substring(6, 1) * 8 + strTesteCpfCnpj.Substring(5, 1) * 9 + strTesteCpfCnpj.Substring(4, 1) * 2 + strTesteCpfCnpj.Substring(3, 1) * 3 + strTesteCpfCnpj.Substring(2, 1) * 4 + strTesteCpfCnpj.Substring(1, 1) * 5 + strTesteCpfCnpj.Substring(0, 1) * 6
                intRestoCnpjDois = 11 - (intSomaCnpjDois Mod 11)

                If intRestoCnpjDois = strTesteCpfCnpj.Substring(13, 1) Or (intRestoCnpjDois >= 10 And strTesteCpfCnpj.Substring(13, 1) = 0) Then 'CPF VERIFICADO

                Else
                    MsgBox("CNPJ INVÁLIDO!", MsgBoxStyle.Exclamation)
                    txtCpfCnpj.ResetText()
                End If

            Else
                MsgBox("CNPJ INVÁLIDO!", MsgBoxStyle.Exclamation)
                txtCpfCnpj.ResetText()
            End If
        End If

    End Sub

    Private Sub rdgCpfCnpj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdgCpfCnpj.SelectedIndexChanged
        If txtCpfCnpj.Text.Length = 14 And rdgCpfCnpj.SelectedIndex = 1 Then
            Me.txtCpfCnpj.ResetText()
        ElseIf txtCpfCnpj.Text.Length = 18 And rdgCpfCnpj.SelectedIndex = 0 Then
            Me.txtCpfCnpj.ResetText()
        End If
    End Sub

    Private Sub txtClienteCep_Leave(sender As Object, e As EventArgs) Handles txtClienteCep.Leave
        Dim ht As Hashtable = BuscaCep(Me.txtClienteCep.Text)
        Me.txtClienteEndereco.Text = ht("tipologradouro") & " " & ht("logradouro")
        Me.cboClienteUf.Text = ht("UF")
        Me.cboClienteCidade.Text = ht("cidade")
        Me.cboClienteBairro.Text = ht("bairro")
    End Sub

    'Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
    '    MostrarDados()
    '    bolStatusAlteracao = True
    'End Sub

    Private Sub AlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles AlterarGrid.DoubleClick
        MostrarDados()
        bolStatusAlteracao = True
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        CodigoCliente = Me.grd1.GetRowCellValue(Index, colCodigo)

        If Me.Tag = "ConsultarCliente" Then
            CodigoCliente = Me.grd1.GetRowCellValue(Index, colCodigo)
            Me.Close()
        End If

        'Bloqueios 
        If bolBloquearCadastroCliente = False And BolBloquearAlterarCliente = True Then
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub txtFantasia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFantasia.KeyPress, txtTelefone3.KeyPress, txtTelefone2.KeyPress, txtTelefone1.KeyPress, txtRgIe.KeyPress, txtEmail.KeyPress, txtContato.KeyPress, txtClienteNum.KeyPress, txtClienteEndereco.KeyPress, txtClienteComp.KeyPress, memObservacoes.KeyPress, cboClienteCidade.KeyPress, cboClienteBairro.KeyPress, txtNomeRazao.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRelatorioClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelatorioClientes.ItemClick
        Dim rel As New relCliente
        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from Cliente")
        For i = 0 To dtProdutoSelect.Rows.Count - 1
            rel.tbClientes.Rows.Add()
            rel.tbClientes.Rows.Item(i).Item("Nome") = dtProdutoSelect.Rows.Item(i).Item("Nome")
            rel.tbClientes.Rows.Item(i).Item("Endereco") = dtProdutoSelect.Rows.Item(i).Item("Endereco")
            rel.tbClientes.Rows.Item(i).Item("RgIe") = dtProdutoSelect.Rows.Item(i).Item("RGIE")
            rel.tbClientes.Rows.Item(i).Item("CPF") = dtProdutoSelect.Rows.Item(i).Item("CPF")
            rel.tbClientes.Rows.Item(i).Item("Numero") = dtProdutoSelect.Rows.Item(i).Item("Numero")
            rel.tbClientes.Rows.Item(i).Item("Bairro") = dtProdutoSelect.Rows.Item(i).Item("Bairro")
            rel.tbClientes.Rows.Item(i).Item("Cidade") = dtProdutoSelect.Rows.Item(i).Item("Cidade")
            rel.tbClientes.Rows.Item(i).Item("Telefone") = dtProdutoSelect.Rows.Item(i).Item("Telefone")
        Next
        rel.ShowPreview()

    End Sub

    Private Sub btnCancelamento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelamento.ItemClick
        If bolStatusAlteracao = True Then
            frmCancelamento.ShowDialog()
        Else
            MsgBox("Selecione um cliente", MsgBoxStyle.Information)
        End If
    End Sub

End Class