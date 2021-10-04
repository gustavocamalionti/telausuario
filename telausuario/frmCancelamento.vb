Imports telausuario.clsFuncao
Imports telausuario.modFuncoes

Public Class frmCancelamento
    Public intConfirmarBloqueio As Integer

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmCancelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        Dim dt As DataTable = CarregarDataTable("select nome, Cancelamento, MotivoCancelamento, DetalhesCancelamento, DataCancelamento from cliente where Codigo = " & CodigoCliente & "")
        Me.grpCancelarUsuario.Text = dt.Rows.Item(0).Item("nome")

        'Carregar informações de Cancelamento
        Dim dtComboMotivo As DataTable = CarregarDataTable("select distinct MotivoCancelamento from Cliente")
        Dim i As Integer
        If dtComboMotivo.Rows.Count > 0 Then
            For i = 0 To dtComboMotivo.Rows.Count - 1
                If dtComboMotivo.Rows.Item(i).Item("MotivoCancelamento").ToString <> "REATIVADO" And dtComboMotivo.Rows.Item(i).Item("MotivoCancelamento").ToString <> "" Then
                    Me.cboMotivo.Properties.Items.Add(dtComboMotivo.Rows.Item(i).Item("MotivoCancelamento"))
                End If
            Next
        End If

        'Carregar informações do Cliente
        If dt.Rows.Item(0).Item("Cancelamento").ToString = "True" Then
            Me.dtData.Text = dt.Rows.Item(0).Item("DataCancelamento")
            Me.cboMotivo.Text = dt.Rows.Item(0).Item("MotivoCancelamento")
            Me.memDescricao.Text = dt.Rows.Item(0).Item("DetalhesCancelamento")

            Me.dtData.Properties.ReadOnly = True
            Me.cboMotivo.Properties.ReadOnly = True
            Me.memDescricao.Properties.ReadOnly = True

            Me.btnSalvar.Enabled = False
            Me.btnReativar.Enabled = True
        Else
            dtData.Properties.ReadOnly = False
            cboMotivo.Properties.ReadOnly = False
            memDescricao.Properties.ReadOnly = False
            Me.btnSalvar.Enabled = True
            Me.btnReativar.Enabled = False
        End If
    End Sub

    Private Sub Limpar()
        Me.cboMotivo.Properties.Items.Clear()
        intConfirmarBloqueio = 0

        Me.dtData.ResetText()
        Me.cboMotivo.ResetText()
        Me.memDescricao.ResetText()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Dim dt As DataTable = CarregarDataTable("select nome from cliente where Codigo = " & CodigoCliente & "")
        If Me.cboMotivo.Text = "" Or Me.dtData.Text = "" Then
            MsgBox("Tente novamente, talvez alguns campos não foram preenchidos.")
        Else
            intConfirmarBloqueio = MsgBox("Confirmar bloqueio de " & dt.Rows.Item(0).Item("nome") & " ?", MsgBoxStyle.YesNo)
            If intConfirmarBloqueio = vbYes Then

                Atualizar("update Cliente set Cancelamento = 1, MotivoCancelamento = '" & Me.cboMotivo.Text & "', DetalhesCancelamento = '" & Me.memDescricao.Text & "', DataCancelamento = '" & Me.dtData.Text & "' where codigo = " & CodigoCliente & " ")
                MsgBox("Cliente Bloqueado com sucesso!")
                Limpar()
                Me.Close()
            Else

            End If
        End If
        
    End Sub

    Private Sub btnSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReativar.ItemClick
        Dim dt As DataTable = CarregarDataTable("select Nome, Cancelamento, DataCancelamento from Cliente where Codigo = " & CodigoCliente & ";")
        If dt.Rows.Item(0).Item("Cancelamento") = True Then
            Dim resposta As String
            resposta = MsgBox("Deseja reativar o cancelamento de '" & dt.Rows.Item(0).Item("Nome") & " realizado em '" & dt.Rows.Item(0).Item("DataCancelamento") & "'?", MsgBoxStyle.YesNoCancel)
            If resposta = vbYes Then
                Atualizar("update Cliente set Cancelamento = 0, MotivoCancelamento = 'REATIVADO', DataCancelamento = getdate(), DetalhesCancelamento = 'REATIVADO' where Codigo = " & CodigoCliente & " ")
                MsgBox("Cliente reativado com sucesso!", MsgBoxStyle.Information)
                Limpar()
                Me.Close()

            End If
        Else
            MsgBox("Cliente ativo, não é possível reativa-lo.")
        End If

    End Sub

    Private Sub memDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles memDescricao.KeyPress, dtData.KeyPress, cboMotivo.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
End Class