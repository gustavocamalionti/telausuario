Imports telausuario.clsFuncao
Imports telausuario.modFuncoes
Public Class frmAlterarSenha

    Private Sub Limpar()
        Me.txtConfirmarSenha.ResetText()
        Me.txtNovaSenha.ResetText()
        Me.txtSenhaAntiga.ResetText()
    End Sub

    Private Sub Salvar()
        Dim dtSenhaUsuarioConectado As DataTable = CarregarDataTable("select Senha from usuario where login = '" & LoginUsuarioConectado & "';")
        Dim strSenhaUsuarioConectado As String = dtSenhaUsuarioConectado.Rows.Item(0).Item(0)
        If Me.txtSenhaAntiga.Text = strSenhaUsuarioConectado And Me.txtNovaSenha.Text = Me.txtConfirmarSenha.Text Then
            Atualizar("update usuario set Senha = '" & Me.txtConfirmarSenha.Text & "' where login = '" & LoginUsuarioConectado & "'")
            MsgBox("Senha alterada com Sucesso")
            Limpar()
            Me.Close()
        Else
            MsgBox("Dados incorretos. Tente novamente!")
            Limpar()
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Salvar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
        Me.Close()
    End Sub

    Private Sub txtConfirmarSenha_EditValueChanged(sender As Object, e As EventArgs) Handles txtConfirmarSenha.EditValueChanged

    End Sub

    Private Sub txtConfirmarSenha_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Salvar()
        End If
    End Sub

    Private Sub txtConfirmarSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmarSenha.KeyPress, txtSenhaAntiga.KeyPress, txtNovaSenha.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
End Class