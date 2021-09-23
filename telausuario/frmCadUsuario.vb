Imports telausuario.clsFuncao
Public Class frmCadUsuario
    Dim bolAlterar As Boolean
    Dim intCodigo As Boolean
    Dim strNivel As String
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTelaUsuario)

    End Sub

    Private Sub frmCadUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTelaUsuario.Usuario' table. You can move, or remove it, as needed.
        Me.UsuarioTableAdapter.Fill(Me.DsTelaUsuario.Usuario)
        Me.MaximizeBox = False
        AtualizarGrid()
        Limpar()
    End Sub

    Private Sub AtualizarGrid()
        CarregarDados("select Codigo, Login, Nome, Senha, Nivel, Inativo from Usuario", grdUsuariosCadastrados)
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
        Atualizar("Update usuario set (Nome = '" & Me.txtNome.Text & "', Login = '" & Me.txtLogin.Text & "'," & _
                  " Senha = '" & Me.txtConfirmarSenha.Text & "', Inativo = '" & Me.chkInativo.Checked & "', CodConfig ='" & Me.cboLoja.Text.Replace(",", ".") & "'," & _
                  " Nivel = '" & rdgNivel.Text & "')  where Codigo = " & intCodigo & ";")
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


        Me.txtNome.Text = Me.grd1.GetRowCellValue(Index, colNome)
        Me.txtLogin.Text = Me.grd1.GetRowCellValue(Index, colLogin)
        Me.txtSenha.Text = Me.grd1.GetRowCellValue(Index, colSenha)

        Me.txtConfirmarSenha.ResetText()
        Me.chkInativo.Checked = Me.grd1.GetRowCellValue(Index, colInativo)
        Me.cboLoja.Text = Me.grd1.GetRowCellDisplayText(Index, colCodConfig)

        If Me.grd1.GetRowCellDisplayText(Index, colNivel) = "USUÁRIO" Then
            Me.rdgNivel.SelectedIndex = 0
        ElseIf Me.grd1.GetRowCellDisplayText(Index, colNivel) = "ADMINISTRADOR" Then
            Me.rdgNivel.SelectedIndex = 1
        Else
            Me.rdgNivel.SelectedIndex = 2
        End If



    End Sub

    Private Sub DeletarDados()
        Dim Index As Integer = Me.grd1.FocusedRowHandle
        Dim intCodigo As String = Me.grd1.GetRowCellValue(Index, colCodigo)
        Deletar("delete Cliente where Codigo = " & intCodigo & ";")
        AtualizarGrid()
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
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress, txtSenha.KeyPress, txtLogin.KeyPress, txtConfirmarSenha.KeyPress, cboLoja.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Limpar()
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        DeletarDados()
    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        inserirDados()

    End Sub

    Private Sub txtAlterarGrid_DoubleClick(sender As Object, e As EventArgs) Handles txtAlterarGrid.DoubleClick
        Dim Index As Integer = Me.grd1.FocusedRowHandle

        If Index >= 0 Then
            bolAlterar = True
            MostrarDados()
        Else
            Exit Sub
        End If

    End Sub


End Class