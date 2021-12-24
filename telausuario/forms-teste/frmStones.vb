Imports telausuario.clsFuncao
Imports telausuario.clsStoneJson
Imports telausuario.clsStone
'Imports telausuario.modFuncoes
Public Class frmStones
    Dim strIdEstabelecimento As String
    Dim strIdPos As String
    Dim strIdPreTransacao As String
    Dim token As String
    Dim dtPreTransacoes As DataTable

    Private Sub frmStones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StoneToken()
        token = dtStoneToken.Rows.Item(0).Item("token").ToString

       

        txtCnpj.Text = "14566555000100"
        txtNomeFantasia.Text = "Sistemas Nano"
        txtRazaoSocial.Text = "Era Systems Soluções"
        txtStoneCode.Text = "211732177"

        Dim strRetorno As String
        Dim dtListagemEstabelecimento As DataTable = StoneConsultarTodosEstabelecimento(token, strRetorno)
        Dim I As Integer
        For I = 0 To dtListagemEstabelecimento.Rows.Count - 1
            If dtListagemEstabelecimento.Rows.Item(I).Item("establishment_is_active") = True And dtListagemEstabelecimento.Rows.Item(I).Item("document") = txtCnpj.Text Then
                strIdEstabelecimento = dtListagemEstabelecimento.Rows.Item(I).Item("id").ToString

            End If
        Next
        txtIdEstabelecimento.Text = strIdEstabelecimento
    End Sub

    Private Sub Limpar()
        rtbRetorno.ResetText()

        Grid1.Columns.Clear()
    End Sub

    Private Sub btnToken_Click(sender As Object, e As EventArgs) Handles btnToken.Click
        'Dim datData As new DateTime = dtStoneToken.Rows.Item(0).Item("data").ToString
        'If datData <> "" And datData.Date <= DateDiff(DateInterval.Hour, My.Computer.Clock.LocalTime.Date, datData) Then
        'End If
        StoneToken()
        token = dtStoneToken.Rows.Item(0).Item("token").ToString
    End Sub

    Private Sub btnRegistrarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnRegistrarEstabelecimento.Click
        StoneRegistrarEstabelecimento(token, "Sistemas Nano", "Eder", "14566555000100", "211732177", 1238)
    End Sub

    Private Sub btnConsultarTodosEstabelecimentos_Click(sender As Object, e As EventArgs) Handles btnConsultarTodosEstabelecimentos.Click
        Dim strRetorno As String
        StoneConsultarTodosEstabelecimento(token, strRetorno)
    End Sub

    Private Sub btnDeletarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnDeletarEstabelecimento.Click

        StoneDeletarEstabelecimento(token, "db4362a6-7710-4f52-ab97-4ddcf59bd18b")
    End Sub

    Private Sub btnConsultarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnConsultarEstabelecimento.Click
        Dim strRetorno As String
        Dim dtListagemEstabelecimento As DataTable = StoneConsultarTodosEstabelecimento(token, strRetorno)
        Dim I As Integer
        For I = 0 To dtListagemEstabelecimento.Rows.Count - 1
            If dtListagemEstabelecimento.Rows.Item(I).Item("establishment_is_active") = True And dtListagemEstabelecimento.Rows.Item(I).Item("document") = "14566555000100" Then
                strIdEstabelecimento = dtListagemEstabelecimento.Rows.Item(I).Item("id").ToString
            End If
        Next
    End Sub

    Private Sub btnConfigurarAtivarPos_Click(sender As Object, e As EventArgs) Handles btnConfigurarAtivarPos.Click
        StoneConfigurarPos(token, strIdEstabelecimento, 0, 1, False, 0, False, 0, True, False, 1500)
        StoneAtivarPos(token, strIdEstabelecimento, "1", "1", "Caixa Principal", "6G433486")
        Dim dtPos As DataTable = StoneConsultarPos(token, strIdEstabelecimento)

        strIdPos = dtPos.Rows.Item(0).Item(0).ToString
    End Sub



    Private Sub btnExcluirPreTransacao_Click(sender As Object, e As EventArgs) Handles btnExcluirPreTransacao.Click
        For I = 0 To dtPreTransacoes.Rows.Count - 1
            StoneDeletarPreTransacao(token, dtPreTransacoes.Rows.Item(I).Item(0).ToString)
        Next

    End Sub

    Private Sub btnListarTransações_Click(sender As Object, e As EventArgs) Handles btnListarTransações.Click

        'StoneListarTransacoes(token, strIdEstabelecimento, "day", "20211220", 1)

    End Sub

    Private Sub btnConsultarTransacao_Click(sender As Object, e As EventArgs) Handles btnConsultarTransacao.Click

        StoneConsultaTransacaoID(token, strIdPreTransacao)
        'StoneConsultaTransacaoID(token, "fc0e39d9-9b16-466c-a95b-2caed8d0b14b")

    End Sub

    Private Sub btnWebHook_Click(sender As Object, e As EventArgs) Handles btnWebHook.Click
        StoneWebhookPreTransacao(token, strIdEstabelecimento, "https://webhook.site/c8345d23-f2be-4790-b2fc-fcf3b9a3cfae")
    End Sub

    Private Sub btnCadEstab_CheckedChanged(sender As Object, e As EventArgs) Handles btnCadEstab.CheckedChanged
        Limpar()
        rtbRetorno.Text = StoneRegistrarEstabelecimento(token, txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtStoneCode.Text, 1238)
    End Sub

    Private Sub btnCriarPreTransacoes_Click(sender As Object, e As EventArgs) Handles btnCriarPreTransacoes.Click
        strIdPreTransacao = StoneCriarPreTransacoes(token, strIdEstabelecimento, strIdPos, 100, "TESTE CRÉDITO GUSTAVO: 1 PARCELA.", 2)
    End Sub

    Private Sub btnListarPreTransacoes_Click(sender As Object, e As EventArgs) Handles btnListarPreTransacoes.Click
        dtPreTransacoes = StoneConsultaPreTransacoes(token, strIdEstabelecimento, "20211220")
    End Sub

    Private Sub btnListarEstab_CheckedChanged(sender As Object, e As EventArgs) Handles btnListarEstab.CheckedChanged
        Limpar()
        Dim strRetorno As String
        Dim dtListagem As DataTable = StoneConsultarTodosEstabelecimento(token, strRetorno)
        rtbRetorno.Text = strRetorno
        GridListagem.DataSource = dtListagem
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Limpar()
    End Sub

    Private Sub btnConsultarEstab_CheckedChanged(sender As Object, e As EventArgs) Handles btnConsultarEstab.CheckedChanged
        Dim index As Integer
        index = Grid1.FocusedRowHandle
        Dim idEstabelecimento As String = Grid1.GetRowCellValue(index, "id")
        If idEstabelecimento <> "" Then
            rtbRetorno.Text = StoneConsultaEstabelecimentoEspecifico(token, idEstabelecimento)
        End If



    End Sub

    Private Sub btnExcluirEstab_CheckedChanged(sender As Object, e As EventArgs) Handles btnInativarEstab.CheckedChanged

        Dim index As Integer
        index = Grid1.FocusedRowHandle
        Dim idEstabelecimento As String = Grid1.GetRowCellValue(index, "id")
        If idEstabelecimento <> "" Then
            Dim answer As String = MsgBox("Deseja Inativar esse estabelecimento?", MsgBoxStyle.YesNo).ToString
            If answer = "Yes" Then
                rtbRetorno.Text = StoneDeletarEstabelecimento(token, idEstabelecimento)

            End If

        End If


    End Sub

End Class