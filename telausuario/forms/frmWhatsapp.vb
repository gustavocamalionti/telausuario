
Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Public Class frmWhatsapp


    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim NumeroDestinatario As String = "" & Me.txtDDI.Text & "" & Me.txtNumeroComDdd.Text & " ".Trim()
        Dim MensagemDestinatario As String = Me.memMensagem.Text.Replace(" ", "%20")
        Dim endereco As String = "https://wa.me/" & NumeroDestinatario & "?text=" & Me.memMensagem.Text & ""
        System.Diagnostics.Process.Start(endereco)
    End Sub


    Private Sub frmWhatsapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarGrid()
    End Sub

    Private Sub CarregarGrid()
        CarregarDados("select Codigo, Nome, Celular, CodPais from cliente", grdListaClientes)
    End Sub

    Private Sub Limpar()
        Me.memMensagem.ResetText()
        Me.txtNumeroComDdd.ResetText()
        Me.txtDDI.ResetText()
    End Sub

    Private Sub MostrarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle


        Me.memMensagem.Text = "Olá " & Me.grd1.GetRowCellDisplayText(Index, Me.colNome) & "! meu nome é " & Environment.MachineName & " da NANO SYSTEMS, podemos conversar agora? "


        If Me.grd1.GetRowCellDisplayText(Index, Me.colCodPais).ToString <> "" Then
            Dim dtPesquisarPais As DataTable = CarregarDataTable("select * from Pais where CodIBGE = " & Me.grd1.GetRowCellDisplayText(Index, Me.colCodPais) & "")
            Dim NumeroCelular As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCelular)

            Me.txtDDI.Text = dtPesquisarPais.Rows.Item(0).Item("CodDDI")
            Dim QuantidadeCaracterDDI As Integer = Me.txtDDI.Text.ToString.Count

            'Verificar se o Numero de Celular já possui DDI

            Dim VerificarPrimeirosDigitos As String = NumeroCelular.Substring(0, QuantidadeCaracterDDI).ToString
            If VerificarPrimeirosDigitos = Me.txtDDI.Text Then
                Me.txtNumeroComDdd.Text = NumeroCelular.Substring(QuantidadeCaracterDDI, NumeroCelular.Count - QuantidadeCaracterDDI)
            Else
                Me.txtNumeroComDdd.Text = NumeroCelular
            End If
        End If

    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        MostrarDados()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub

End Class