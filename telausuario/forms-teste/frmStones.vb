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
        StoneConsultarTodosEstabelecimento(token)
    End Sub

    Private Sub btnDeletarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnDeletarEstabelecimento.Click

        StoneDeletarEstabelecimento(token, "db4362a6-7710-4f52-ab97-4ddcf59bd18b")
    End Sub

    Private Sub btnConsultarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnConsultarEstabelecimento.Click

        Dim dtListagemEstabelecimento As DataTable = StoneConsultarTodosEstabelecimento(token)
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

    Private Sub btnCriarTransacao_Click(sender As Object, e As EventArgs) Handles btnCriarPreTransacoes.Click

        strIdPreTransacao = StoneCriarPreTransacoes(token, strIdEstabelecimento, strIdPos, 100, "TESTE CRÉDITO GUSTAVO: 1 PARCELA.", 2)
    End Sub

    Private Sub btnConsultarPreTransacoes_Click(sender As Object, e As EventArgs) Handles btnListarPreTransacoes.Click

        dtPreTransacoes = StoneConsultaPreTransacoes(token, strIdEstabelecimento, "20211220")
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
End Class