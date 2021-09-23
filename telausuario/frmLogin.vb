﻿Imports telausuario.modFuncoes
Imports telausuario.clsBanco
Imports telausuario.clsFuncao

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StringDeConexao = My.Settings.dsTelaUsuario
        Dim intPosicaoDireita As Integer
        Dim intPosicaoEsquerda As Integer

        intPosicaoEsquerda = StringDeConexao.IndexOf("Catalog=")
        NomeBanco = StringDeConexao.Remove(0, intPosicaoEsquerda + 8)

        intPosicaoDireita = NomeBanco.IndexOf(";Persi")
        NomeDoBancoSql = NomeBanco.Remove(intPosicaoDireita)

        If ExisteBanco() = False Then
            CriarBanco()
            VersaoSistemaBanco = "1.0.0"
            GerenciarTabela()
        End If


        Dim dtVersaoNano As DataTable = CarregarDataTable("Select VersaoNano, Empresa from Config")
        If dtVersaoNano.Rows.Item(0).Item("Empresa") = "" Then
            frmConfig.ShowDialog()
            MsgBox("Para as configurações serem aplicadas, abra novamente o sistema.", MsgBoxStyle.Exclamation)
            Me.Close()

        End If

        If dtVersaoNano.Rows.Count > 0 Then
            VersaoSistemaBanco = dtVersaoNano.Rows.Item(0).Item("VersaoNano").ToString
        End If

            GerenciarTabela()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim ValidarSenha As DataTable = CarregarDataTable("select Login, Senha from Usuario;")
        If Me.txtLogin.Text <> "" And Me.txtSenha.Text <> "" Then
            For c = 0 To ValidarSenha.Rows.Count - 1
                If Me.txtLogin.Text = ValidarSenha.Rows.Item(c).Item("Login") And Me.txtSenha.Text = ValidarSenha.Rows.Item(c).Item("Senha") Then
                    MsgBox("Login feito com sucesso!", MsgBoxStyle.Information)
                    Me.txtLogin.ResetText()
                    Me.txtSenha.ResetText()
                    Hide()
                    frmMenu.ShowDialog()
                    Exit Sub
                End If
            Next
            MsgBox("Erro ao fazer login! Verifique as informações fornecidas.", MsgBoxStyle.Exclamation)
            Me.txtSenha.ResetText()
        Else
            Me.txtLogin.ResetText()
            Me.txtSenha.ResetText()
            MsgBox("Preencha os campos antes de enviar.", MsgBoxStyle.Exclamation)
        End If
        
    End Sub

    Private Sub btnOk_VisibleChanged(sender As Object, e As EventArgs) Handles btnOk.VisibleChanged
        btnOk.BackColor = Color.FromArgb(155, 194, 206)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnSair_ContextMenuChanged(sender As Object, e As EventArgs) Handles btnSair.ContextMenuChanged
        btnSair.BackColor = Color.FromArgb(155, 194, 206)
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            Dim ValidarSenha As DataTable = CarregarDataTable("select Login, Senha from Usuario;")
            If Me.txtLogin.Text <> "" And Me.txtSenha.Text <> "" Then
                For c = 0 To ValidarSenha.Rows.Count - 1
                    If Me.txtLogin.Text = ValidarSenha.Rows.Item(c).Item("Login") And Me.txtSenha.Text = ValidarSenha.Rows.Item(c).Item("Senha") Then
                        MsgBox("Login feito com sucesso!", MsgBoxStyle.Information)
                        Me.txtLogin.ResetText()
                        Me.txtSenha.ResetText()
                        Hide()
                        frmMenu.ShowDialog()
                        Exit Sub
                    End If
                Next
                MsgBox("Erro ao fazer login! Verifique as informações fornecidas.", MsgBoxStyle.Exclamation)
            Else
                Me.txtLogin.ResetText()
                Me.txtSenha.ResetText()
                MsgBox("Preencha os campos antes de enviar.", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub


    Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
        txtLogin.Text.Trim()
    End Sub

    Private Sub txtSenha_Leave(sender As Object, e As EventArgs) Handles txtSenha.Leave
        txtSenha.Text.Trim()
    End Sub
End Class