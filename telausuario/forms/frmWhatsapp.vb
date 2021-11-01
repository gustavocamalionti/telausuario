
Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Imports telausuario.modFuncoes
Imports Microsoft.Win32
Public Class frmWhatsapp
    Dim bolCelular As Boolean
    Dim CodigoCliente As Integer
    Dim indexChangedConfigurar As Integer = -1
    Dim TituloMsgAutomatica As String = ""
    Dim NomeArquivo As String = ""
    Private Sub frmWhatsapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        CarregarGrid()
        CarregarComboBox()
        lblCliente.Visible = False
    End Sub

    Private Sub CarregarComboBox()
        Dim dtPesquisarMsgAutomatica As DataTable = CarregarDataTable("select * from MensagemWhatsapp")

        If dtPesquisarMsgAutomatica.Rows.Count > 0 Then
            For I = 0 To dtPesquisarMsgAutomatica.Rows.Count - 1
                If dtPesquisarMsgAutomatica.Rows.Item(I).Item("Titulo").ToString <> "" Then
                    'Tab: Cadastro de Mensagem automática
                    Me.cboTituloConfig.Properties.Items.Add(dtPesquisarMsgAutomatica.Rows.Item(I).Item("Titulo"))

                    'Tab: Enviar Mensagem
                    Me.cboTitulo.Properties.Items.Add(dtPesquisarMsgAutomatica.Rows.Item(I).Item("Titulo"))

                End If
            Next
        End If
    End Sub
    Private Sub CarregarGrid()
        CarregarDados("select Codigo, Nome, Celular, CodPais from cliente", grdListaClientes)


    End Sub

    Private Sub Limpar()
        bolCelular = True
        Me.memMensagem.ResetText()
        Me.txtNumeroComDdd.ResetText()
        Me.txtDDI.ResetText()
        Me.cboTitulo.ResetText()

        Me.lblCliente.Visible = False
        Me.lblCliente.Text = ""
        Me.cboTituloConfig.Properties.Items.Clear()
        Me.cboTitulo.Properties.Items.Clear()
        Me.cboTituloConfig.ResetText()
        Me.memMensagemConfig.ResetText()
        indexChangedConfigurar = -1
        TituloMsgAutomatica = ""
        Me.btnSalvarMensagem.Image = My.Resources.apply
        Me.btnSalvarMensagem.Text = "Salvar Mensagem"
        Me.btnRemoverMensagem.Visible = False
        Me.cboTituloConfig.Properties.ReadOnly = False
        Me.btnEnviarSalvar.Enabled = True
        Me.cboEnviarArquivo.ResetText()
        NomeArquivo = ""
        strCaminhoArquivo = ""
    End Sub

    Private Sub MostrarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        If Index < 0 Then
            Limpar()
            CarregarGrid()
            CarregarComboBox()
            Exit Sub
        End If
        Me.tabPrincipal.SelectedTabPageIndex = -1
        CodigoCliente = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)
        lblCliente.Visible = True
        lblCliente.Text = Me.grd1.GetRowCellDisplayText(Index, Me.colNome)



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

    Private Sub VerificarArquivo(ByVal parNomeArquivo As String, ByVal parVerificar As Boolean, ByRef parRetorno As Boolean, ByVal CaminhoArquivo As String)
        Dim strURL As String = ""
        parRetorno = False


        If parVerificar = True Then
            strURL = String.Format(StringConexaoFTP & "{0}/", CNPJEmpresa)

            If CheckIfFIlesExists(strURL, LoginFTP, SenhaFTP) = False Then
                If CriarPastaFtp(strURL, LoginFTP, SenhaFTP, "" & CNPJEmpresa & "") = False Then
                    parRetorno = False
                    Exit Sub
                End If
            End If
        End If

        strURL = String.Format(StringConexaoFTP & "{0}/{1}", CNPJEmpresa, parNomeArquivo)

        If ExcluirImagemFtp(CaminhoArquivo & parNomeArquivo, strURL, LoginFTP, SenhaFTP) = False Then
            'MsgBox("Erro ao excluir imagem " & parNomeImagem & " do produto!", MsgBoxStyle.Information)
            'parRetorno = False
            'Exit Sub
        End If

        If InserirImagemFtp(CaminhoArquivo & parNomeArquivo, strURL, LoginFTP, SenhaFTP) = False Then
            'MsgBox("Erro ao inserir imagem " & parNomeImagem & " do produto!", MsgBoxStyle.Information)
            parRetorno = False
            Exit Sub
        Else
            parRetorno = True
        End If
    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        MostrarDados()
    End Sub



    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub


    Private Sub txtDDI_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub btnClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClientes.ItemClick
        frmCadCliente.ShowDialog()
        Limpar()
        CarregarGrid()
        CarregarComboBox()



    End Sub

    Private Sub btnEnviar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarSalvar.ItemClick
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        Dim NomeCliente As String = Me.grd1.GetRowCellDisplayText(Index, colNome)
        If Me.txtDDI.Text <> "" And Me.txtNumeroComDdd.Text <> "" And Me.memMensagem.Text <> "" Then
            Dim NumeroDestinatario As String = "" & Me.txtDDI.Text & "" & Me.txtNumeroComDdd.Text & " ".Trim()
            Dim MensagemDestinatario As String = Me.memMensagem.Text.Replace(" ", "%20").Replace("<EMPRE>", "" & NomeEmpresa & "").Replace("<USER>", "" & PrimeiraLetraMaiuscula(Environment.MachineName) & "").Replace("<CLI>", "" & PrimeiraLetraMaiuscula(NomeCliente) & "").Replace("<DAT>", "" & Date.Today & "").Replace("<QBLIN>", "%0A").Replace("<PLIN>", "%0A%0A")
            Dim TituloDestinatario As String = Me.cboTitulo.Text.Replace(" ", "%20").Replace("<EMPRE>", "" & NomeEmpresa & "").Replace("<USER>", "" & PrimeiraLetraMaiuscula(Environment.MachineName) & "").Replace("<CLI>", "" & PrimeiraLetraMaiuscula(NomeCliente) & "").Replace("<DAT>", "" & Date.Today & "").Replace("<QBLIN>", "%0A").Replace("<PLIN>", "%0A%0A")
            Dim Endereco As String

            If bolCelular = False Then
                Dim dtBuscaPais As DataTable = CarregarDataTable("select * from Pais where CodDDI = " & Me.txtDDI.Text & "")
                Atualizar("update Cliente set Celular = '" & NumeroDestinatario & "', CodPais = " & dtBuscaPais.Rows.Item(0).Item("CodIBGE") & " where Codigo = " & CodigoCliente & " ")
            End If

            

            Select Case My.Computer.FileSystem.FileExists("C:\Users\Usuario\AppData\Local\WhatsApp\Whatsapp.exe")

                Case True
                    If Me.cboTitulo.Text <> "" Then
                        Endereco = "whatsapp://send?phone=" & NumeroDestinatario & "&text=*" & TituloDestinatario & "*%0A%0A" & MensagemDestinatario & ""
                    Else
                        Endereco = "whatsapp://send?phone=" & NumeroDestinatario & "&text=" & MensagemDestinatario & ""

                    End If

                Case False
                    If Me.cboTitulo.Text <> "" Then
                        Endereco = "https://wa.me/" & NumeroDestinatario & "?text=*" & TituloDestinatario & "*%0A%0A" & MensagemDestinatario & ""

                    Else
                        Endereco = "https://wa.me/" & NumeroDestinatario & "?text=" & MensagemDestinatario & "

                    End If
            End Select
            If cboEnviarArquivo.Text <> "" Then
                clsFuncoesDropBox.CriarPastaDropBox()
                clsFuncoesDropBox.UploadDropBox(NomeArquivo)
                clsFuncoesDropBox.CriarLinkDropBox(NomeArquivo)
                Endereco = Endereco & "*%0A%0ABaixe%20Clicando%20aqui: " & strLinkDownloadAnexo & "%0A%0ACaso%20não%20consiga%20visualizar%20o%20arquivo,%20instale%20no%20seu%20dispositivo%20o%20aplicativo%20*dropbox*"
            End If

            'If cboEnviarArquivo.Text <> "" Then
            'Dim indexUltimaBarra As String = cboEnviarArquivo.Text.LastIndexOf("\")
            'Dim NomeArquivo As String = cboEnviarArquivo.Text.Substring(indexUltimaBarra + 1, (cboEnviarArquivo.Text.Count - 1) - (indexUltimaBarra))
            'Dim CaminhoPastaArquivo As String = cboEnviarArquivo.Text.Replace("" & NomeArquivo & "", "")
            'VerificarArquivo("" & NomeArquivo & "", True, False, "" & CaminhoPastaArquivo & "")
            'End If

            System.Diagnostics.Process.Start(Endereco)

            tabPrincipal.SelectedTabPageIndex = 0
            CarregarGrid()
            CarregarComboBox()
        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnFechar_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
        CarregarGrid()
        CarregarComboBox()
    End Sub

    Private Sub tabPrincipal_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabPrincipal.SelectedPageChanged
        Limpar()
        CarregarGrid()
        CarregarComboBox()
        If tabPrincipal.SelectedTabPageIndex = 1 Then
            btnEnviarSalvar.Enabled = False
        End If
    End Sub

    Private Sub btnSalvarMensagem_Click(sender As Object, e As EventArgs) Handles btnSalvarMensagem.Click
        Dim dtPesquisarMsgAutomatica As DataTable = CarregarDataTable("select * from MensagemWhatsapp")

        If Me.cboTituloConfig.Text <> "" And Me.memMensagemConfig.Text <> "" Then
            'Condição para inserir ou Atualizar
            If indexChangedConfigurar = -1 Then
                Inserir("insert into MensagemWhatsapp (Titulo, Mensagem) values ('" & Me.cboTituloConfig.Text.Trim() & "','" & Me.memMensagemConfig.Text.Trim() & "'); ")
                MsgBox("Mensagem automática salva com sucesso!", MsgBoxStyle.Information)
            Else
                MsgBox("Mensagem automática Atualizada com sucesso!", MsgBoxStyle.Information)
                Atualizar("update MensagemWhatsapp set Titulo = '" & Me.cboTituloConfig.Text.Trim() & "', Mensagem = '" & Me.memMensagemConfig.Text.Trim() & "' where Titulo = '" & TituloMsgAutomatica & "'; ")
            End If
            Limpar()
            CarregarGrid()
            CarregarComboBox()
            tabPrincipal.SelectedTabPageIndex = 0
        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub cboTituloConfig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTituloConfig.KeyPress, memMensagemConfig.KeyPress, memMensagem.KeyPress, cboTitulo.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Or e.KeyChar = "+" Then
            e.Handled = True
        End If

    End Sub

    Private Sub cboTituloConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTituloConfig.SelectedIndexChanged
        Dim dtPesquisarMsgAutomatica As DataTable = CarregarDataTable("select * from MensagemWhatsapp")

        indexChangedConfigurar = Me.cboTituloConfig.SelectedIndex
        TituloMsgAutomatica = Me.cboTituloConfig.Text.Trim()
        If Me.cboTituloConfig.SelectedIndex <> -1 Then
            Me.cboTituloConfig.Properties.ReadOnly = True
            For c = 0 To dtPesquisarMsgAutomatica.Rows.Count - 1
                If Me.cboTituloConfig.Text = dtPesquisarMsgAutomatica.Rows.Item(c).Item("Titulo") Then
                    Me.memMensagemConfig.Text = dtPesquisarMsgAutomatica.Rows.Item(c).Item("Mensagem")
                    Me.btnSalvarMensagem.Image = My.Resources.Alterar
                    Me.btnSalvarMensagem.Text = "Alterar Mensagem"
                    Me.btnRemoverMensagem.Visible = True
                End If
            Next
        Else
            Me.cboTituloConfig.Properties.ReadOnly = False
            Me.btnSalvarMensagem.Image = My.Resources.apply
            Me.btnSalvarMensagem.Text = "Salvar Mensagem"
            Me.btnRemoverMensagem.Visible = False
        End If

    End Sub

    Private Sub cboTitulo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "&" Or e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTitulo.SelectedIndexChanged
        Dim dtPesquisarMsgAutomatica As DataTable = CarregarDataTable("select * from MensagemWhatsapp")

        If Me.cboTitulo.SelectedIndex <> -1 Then
            For c = 0 To dtPesquisarMsgAutomatica.Rows.Count - 1
                If Me.cboTitulo.Text = dtPesquisarMsgAutomatica.Rows.Item(c).Item("Titulo") Then
                    Me.memMensagem.Text = dtPesquisarMsgAutomatica.Rows.Item(c).Item("Mensagem")
                End If
            Next
        Else
            Limpar()
            CarregarGrid()
            CarregarComboBox()
        End If
    End Sub

    Private Sub btnRemoverMensagem_Click(sender As Object, e As EventArgs) Handles btnRemoverMensagem.Click
        If indexChangedConfigurar <> -1 Then
            Dim result As String = MsgBox("Deseja excluir essa mensagem automática?", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                Deletar("delete MensagemWhatsapp where Titulo = '" & TituloMsgAutomatica & "';")
                MsgBox("Mensagem automática removida com sucesso!", MsgBoxStyle.Information)
                Limpar()
                CarregarGrid()
                CarregarComboBox()
            End If
        End If
    End Sub

    Private Sub cboEnviarArquivo_Click(sender As Object, e As EventArgs) Handles cboEnviarArquivo.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            strCaminhoArquivo = dialog.FileName
            Me.cboEnviarArquivo.Text = strCaminhoArquivo
            cboEnviarArquivo.Text = strCaminhoArquivo
            Dim indexUltimaBarra As String = strCaminhoArquivo.LastIndexOf("\")
            NomeArquivo = strCaminhoArquivo.Substring(indexUltimaBarra + 1, (strCaminhoArquivo.Count - 1) - (indexUltimaBarra))
        End Using
    End Sub

    Private Sub cboEnviarArquivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEnviarArquivo.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNumeroComDdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroComDdd.KeyPress
        If Me.txtDDI.Text = "" Then

            e.Handled = True
            Me.txtDDI.Text = e.KeyChar
            Me.txtDDI.Select()
            Me.txtDDI.SelectionStart = Me.txtDDI.Text.Length

        End If
    End Sub

    Private Sub txtDDI_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtDDI.KeyPress
        'DDI's COMUNS
        If txtDDI.Text = "5" And e.KeyChar = "5" Then
            Me.txtNumeroComDdd.Select()
            Me.txtNumeroComDdd.SelectionStart = Me.txtNumeroComDdd.Text.Length

        ElseIf txtDDI.Text = "4" And e.KeyChar = "4" Then
            Me.txtNumeroComDdd.Select()
            Me.txtNumeroComDdd.SelectionStart = Me.txtNumeroComDdd.Text.Length

        ElseIf txtDDI.Text = "35" And e.KeyChar = "1" Then
            Me.txtNumeroComDdd.Select()
            Me.txtNumeroComDdd.SelectionStart = Me.txtNumeroComDdd.Text.Length
        End If
    End Sub

    Private Sub cboEnviarArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEnviarArquivo.SelectedIndexChanged

    End Sub

    Private Sub btnListarArquivos_Click(sender As Object, e As EventArgs) Handles btnListarArquivos.Click
        clsFuncoesDropBox.ListarArquivosDropBox("/TestePasta")
    End Sub
End Class