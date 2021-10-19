
Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Public Class frmWhatsapp


    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim NumeroDestinatario As String = Me.txtNumeroDestino.Text
        Dim MensagemDestinatario As String = Me.memMensagem.Text.Replace(" ", "%20")
        System.Diagnostics.Process.Start("https://wa.me/" & NumeroDestinatario & "?text=" & Me.memMensagem.Text & "")
    End Sub


    Private Sub frmWhatsapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarGrid()
    End Sub

    Private Sub CarregarGrid()
        CarregarDados("select Codigo, Nome, Celular from cliente", grdListaClientes)
    End Sub

    Private Sub Limpar()
        Me.memMensagem.ResetText()
        Me.txtNumeroDestino.ResetText()
    End Sub

    Private Sub MostrarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        Me.txtNumeroDestino.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colCelular)
        Me.memMensagem.Text = "Olá " & Me.grd1.GetRowCellDisplayText(Index, Me.colNome) & "! meu nome é " & Environment.MachineName & " da NANO SYSTEMS, podemos conversar agora? "

    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        MostrarDados()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
End Class