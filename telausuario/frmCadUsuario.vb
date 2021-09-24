Imports telausuario.clsFuncao
Public Class frmCadUsuario
    Dim bolAlterar As Boolean
    Dim intCodigo As Integer
    Dim strNivel As String
    Dim strPrincipal As String
    Dim strRelatorios As String

    Private Sub frmCadUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        AtualizarGrid()
        Limpar()

        strPrincipal = "4|2|5|1"
        Dim vetPrinc As Array = Split(strPrincipal, "|")
    End Sub

    Private Sub AtualizarGrid()
        CarregarDados("select Codigo, Login, Nome, Senha, Nivel, Inativo, CodConfig, Principal, Relatorios from Usuario", grdUsuariosCadastrados)
    End Sub
    Private Sub Limpar()
        bolAlterar = False
        intCodigo = -1
        strNivel = ""

        Me.txtNome.ResetText()
        Me.txtLogin.ResetText()
        Me.txtSenha.ResetText()
        Me.txtConfirmarSenha.ResetText()
        Me.chkInativo.Checked = False
        Me.cboLoja.SelectedIndex = -1
        Me.rdgNivel.SelectedIndex = 0
    End Sub

    Private Sub Alterar()
        ConverterRdgNivel()
        Atualizar("Update usuario set Nome = '" & Me.txtNome.Text & "', Login = '" & Me.txtLogin.Text & "'," & _
                  " Senha = '" & Me.txtConfirmarSenha.Text & "', Inativo = '" & Me.chkInativo.Checked & "', CodConfig ='" & Me.cboLoja.Text.Replace(",", ".") & "'," & _
                  " Nivel = '" & strNivel & "'  where Codigo = " & intCodigo & ";")
        Limpar()
        AtualizarGrid()
    End Sub

    Private Sub inserirDados()
        ConverterRdgNivel()
        Inserir("insert into usuario (Nome, Login, Senha, Inativo, CodConfig, Nivel) values ('" & Me.txtNome.Text & "', '" & Me.txtLogin.Text & "', '" & Me.txtConfirmarSenha.Text & "', '" & Me.chkInativo.Checked & "', '" & Me.cboLoja.Text.Replace(",", ".") & "', '" & Me.strNivel & "')")
        Limpar()
        AtualizarGrid()
    End Sub

    Private Sub MostrarDados()

        Dim Index As Integer = Me.grd1.FocusedRowHandle
        intCodigo = Me.grd1.GetRowCellValue(Index, Me.colCodigo)
        bolAlterar = True
        If intCodigo <> 1 Then
            Me.txtNome.Text = Me.grd1.GetRowCellValue(Index, colNome)
            Me.txtLogin.Text = Me.grd1.GetRowCellValue(Index, colLogin)
            Me.txtSenha.Text = Me.grd1.GetRowCellValue(Index, colSenha)
            Me.txtConfirmarSenha.ResetText()
            Me.chkInativo.Checked = Me.grd1.GetRowCellValue(Index, colInativo)
            Me.cboLoja.Text = Me.grd1.GetRowCellDisplayText(Index, colCodConfig)

            Select Case Me.grd1.GetRowCellDisplayText(Index, colNivel)
                Case "USUÁRIO"
                    Me.rdgNivel.SelectedIndex = 0
                Case "ADMINISTRADOR"
                    Me.rdgNivel.SelectedIndex = 1
                Case "MASTER"
                    Me.rdgNivel.SelectedIndex = 2
            End Select

        Else
            MsgBox("NÃO É POSSÍVEL ALTERAR O USUÁRIO ADM.")
            Limpar()
        End If

    End Sub

    Private Sub DeletarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        intCodigo = Me.grd1.GetRowCellValue(Index, colCodigo)

        If intCodigo <> 1 Then
            Deletar("delete Usuario where Codigo = " & intCodigo & ";")
            AtualizarGrid()
        Else
            MsgBox("NÃO É POSSÍVEL EXCLUIR O USUÁRIO ADM.")
        End If

        Limpar()
    End Sub

    Private Sub ConverterRdgNivel()
        If Me.rdgNivel.SelectedIndex = 0 Then
            strNivel = "USUÁRIO"

        ElseIf Me.rdgNivel.SelectedIndex = 1 Then
            strNivel = "ADMINISTRADOR"
        Else
            strNivel = "MASTER"
        End If
    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        DeletarDados()

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Me.txtNome.Text <> "" And Me.txtSenha.Text <> "" And Me.txtConfirmarSenha.Text <> "" And Me.txtLogin.Text <> "" And Me.cboLoja.Text <> "" Then
            If Me.txtSenha.Text = Me.txtConfirmarSenha.Text Then
                If bolAlterar = True Then
                    Alterar()
                    bolAlterar = False
                    MsgBox("USUÁRIO ALTERADO COM SUCESSO!.", MsgBoxStyle.Information)
                Else
                    MsgBox("NOVO USUÁRIO CADASTRADO COM SUCESSO!.", MsgBoxStyle.Information)
                    inserirDados()
                End If
            Else
                MsgBox("SENHAS NÃO CONFEREM, POR FAVOR, TENTE NOVAMENTE.", MsgBoxStyle.Exclamation)
                Me.txtSenha.ResetText()
                Me.txtConfirmarSenha.ResetText()
            End If
        Else
            MsgBox("ALGUM CAMPO DEVE ESTÁ VAZIO! POR FAVOR, PREENCHA TODOS ANTES DE SALVAR.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnAlterar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        MostrarDados()
    End Sub
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress, txtSenha.KeyPress, txtLogin.KeyPress, txtConfirmarSenha.KeyPress, cboLoja.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        MostrarDados()
    End Sub
    
End Class