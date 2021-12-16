Imports telausuario.clsFuncao
Imports telausuario.clsStoneJson
Imports telausuario.clsStone
'Imports telausuario.modFuncoes
Public Class frmStones

    Private Sub frmStones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnToken_Click(sender As Object, e As EventArgs) Handles btnToken.Click
        'Dim datData As new DateTime = dtStoneToken.Rows.Item(0).Item("data").ToString
        'If datData <> "" And datData.Date <= DateDiff(DateInterval.Hour, My.Computer.Clock.LocalTime.Date, datData) Then
        'End If
        StoneToken()
    End Sub

    Private Sub btnRegistrarEstabelecimento_Click(sender As Object, e As EventArgs) Handles btnRegistrarEstabelecimento.Click
        Dim token As String = dtStoneToken.Rows.Item(0).Item("token").ToString
        StoneRegistrarEstabelecimento(token, "Legal Name", "Gustavo Camalionti Gomes", "29359476000103", "211732177", 41451154)
    End Sub
End Class