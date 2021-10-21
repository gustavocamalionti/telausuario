
Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Public Class frmWhatsapp

    Private Sub frmWhatsapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        CarregarGrid()
    End Sub

    Private Sub CarregarGrid()
        CarregarDados("select Codigo, Nome, Celular, CodPais from cliente", grdListaClientes)
    End Sub

    Private Sub Limpar()
        Me.memMensagem.ResetText()
        Me.txtNumeroComDdd.ResetText()
        Me.txtDDI.ResetText()
        Me.txtTitulo.ResetText()
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

    Private Sub btnEnviar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviar.ItemClick
        If txtDDI.Text <> "" And txtNumeroComDdd.Text <> "" Then
            Dim NumeroDestinatario As String = "" & Me.txtDDI.Text & "" & Me.txtNumeroComDdd.Text & " ".Trim()
            Dim MensagemDestinatario As String = Me.memMensagem.Text.Replace(" ", "%20")
            Dim TituloDestinatario As String = Me.txtTitulo.Text.Replace(" ", "%20")
            Dim endereco As String
            If Me.txtTitulo.Text <> "" Then
                endereco = "https://wa.me/" & NumeroDestinatario & "?text=*" & TituloDestinatario & "*%0A%0A" & MensagemDestinatario & ""
            Else
                endereco = "https://wa.me/" & NumeroDestinatario & "?text=" & MensagemDestinatario & ""
            End If

            System.Diagnostics.Process.Start(endereco)
            Limpar()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAlterar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick
        frmCadCliente.ShowDialog()
        CarregarGrid()
        Limpar()
    End Sub

    Private Sub txtDDI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDDI.KeyPress, txtNumeroComDdd.KeyPress
        'Aceitar apenas Números 
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'aceitar backspace(apagar)
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub grpDadosMensagem_Paint(sender As Object, e As PaintEventArgs) Handles grpDadosMensagem.Paint

    End Sub

    Private Sub memMensagem_EditValueChanged(sender As Object, e As EventArgs) Handles memMensagem.EditValueChanged

    End Sub

    Private Sub lblMensagemEnvio_Click(sender As Object, e As EventArgs) Handles lblMensagemEnvio.Click

    End Sub

    Private Sub txtDDI_EditValueChanged(sender As Object, e As EventArgs) Handles txtDDI.EditValueChanged

    End Sub

    Private Sub txtTitulo_EditValueChanged(sender As Object, e As EventArgs) Handles txtTitulo.EditValueChanged

    End Sub

    Private Sub txtNumeroComDdd_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumeroComDdd.EditValueChanged

    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblNumeroDestino_Click(sender As Object, e As EventArgs) Handles lblNumeroDestino.Click

    End Sub
End Class