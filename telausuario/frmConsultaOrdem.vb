Imports telausuario.clsFuncao
Imports telausuario.modFuncoes
Public Class frmConsultaOrdem

    Private Sub AtualizarGrid()
        CarregarDados("select TC.CodOrdens, c.Nome, TC.Data, TC.Status, TC.Total from totalConsig as TC Left Join Cliente as C on C.Codigo = TC.CodCli;", grdConsultaPedidos)
    End Sub
    Private Sub frmConsultaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarGrid()
        CodOrdem = 0
    End Sub

    Private Sub txtAlterarGrid_Click(sender As Object, e As EventArgs) Handles txtAlterarGrid.Click
        indexPedidoAtual = Me.grd1.FocusedRowHandle
        CodOrdem = Me.grd1.GetRowCellValue(indexPedidoAtual, colCodOrdens)

        Dim dtProdutoSelect As DataTable = CarregarDataTable("select * from ItensConsig where CodOrdens = " & CodOrdem & "")

        If dtProdutoSelect.Rows.Count > 0 Then

        Else
            MsgBox("Item não encontrado. Tente Novamente.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        indexPedidoAtual = Me.grd1.FocusedRowHandle
        CodOrdem = Me.grd1.GetRowCellValue(indexPedidoAtual, colCodOrdens)

        Dim dtOrdemSelect As DataTable = CarregarDataTable("select * from ItensConsig where CodOrdens = " & CodOrdem & "")

        If dtOrdemSelect.Rows.Count > 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnOk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If CodOrdem <> "" Then
            Me.Close()
        Else
            MsgBox("Selecione um item antes de concluir.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class