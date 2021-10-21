
Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Public Class frmWhatsapp
    Dim bolCelular As Boolean
    Dim CodigoCliente As Integer
    Private Sub frmWhatsapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        CarregarGrid()
    End Sub

    Private Sub CarregarGrid()
        CarregarDados("select Codigo, Nome, Celular, CodPais from cliente", grdListaClientes)
    End Sub

    Private Sub Limpar()
        bolCelular = True
        Me.memMensagem.ResetText()
        Me.txtNumeroComDdd.ResetText()
        Me.txtDDI.ResetText()
        Me.txtTitulo.ResetText()
        CarregarGrid()
    End Sub

    Private Sub MostrarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        CodigoCliente = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)

        Me.memMensagem.Text = "Olá " & Me.grd1.GetRowCellDisplayText(Index, Me.colNome) & "! meu nome é " & Environment.MachineName & " da NANO SYSTEMS, podemos conversar agora? "


        If Me.grd1.GetRowCellDisplayText(Index, Me.colCodPais).ToString <> "" Then
            Dim dtPesquisarPais As DataTable = CarregarDataTable("select * from Pais where CodIBGE = " & Me.grd1.GetRowCellDisplayText(Index, Me.colCodPais) & "")
            Dim NumeroCelular As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCelular)

            If NumeroCelular = "" Then
                bolCelular = False
            End If

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
        If Me.txtDDI.Text <> "" And Me.txtNumeroComDdd.Text <> "" And Me.memMensagem.Text <> "" Then
            Dim NumeroDestinatario As String = "" & Me.txtDDI.Text & "" & Me.txtNumeroComDdd.Text & " ".Trim()
            Dim MensagemDestinatario As String = Me.memMensagem.Text.Replace(" ", "%20")
            Dim TituloDestinatario As String = Me.txtTitulo.Text.Replace(" ", "%20")
            Dim endereco As String
            If Me.txtTitulo.Text <> "" Then
                endereco = "https://wa.me/" & NumeroDestinatario & "?text=*" & TituloDestinatario & "*%0A%0A" & MensagemDestinatario & ""
            Else
                endereco = "https://wa.me/" & NumeroDestinatario & "?text=" & MensagemDestinatario & ""
            End If

            If bolCelular = False Then
                Dim dtBuscaPais As DataTable = CarregarDataTable("select * from Pais where CodDDI = " & Me.txtDDI.Text & "")
                Atualizar("update Cliente set Celular = '" & NumeroDestinatario & "', CodPais = " & dtBuscaPais.Rows.Item(0).Item("CodIBGE") & " where Codigo = " & CodigoCliente & " ")

            End If

            System.Diagnostics.Process.Start(endereco)
            Limpar()
            Else
                MsgBox("Preencha todos os campos!.", MsgBoxStyle.Exclamation)
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

End Class