
Imports telausuario.modFuncoes
Imports telausuario.clsFuncao
Imports telausuario.modBloqueios
Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barNanoVersaoComputador.Caption = "NANO Versão " & VersaoSistemaProjeto & " - Nome do Computador: " & Environment.MachineName.ToString & ""
        barHora.Caption = Date.Today

        BloqueiosConfig()

        'Bloqueios
        If bolBloquearCadastroUsuario = True Then
            btnCadastrarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If bolBloquearBloqueioUsuario = True Then
            btnBloquearUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub BloqueiosConfig()
        Dim dtCarregarBloqueiosUsuario As DataTable = CarregarDataTable("select Principal, Relatorios from usuario where Login = '" & LoginUsuarioConectado & "' ")

        If dtCarregarBloqueiosUsuario.Rows.Count <> 0 Then
            Dim strPrincipal As String = dtCarregarBloqueiosUsuario.Rows.Item(0).Item("Principal").ToString
            Dim strRelatorios As String = dtCarregarBloqueiosUsuario.Rows.Item(0).Item("Relatorios").ToString


            Dim vetPrincipal As Array = Split(strPrincipal, "|")
            Dim vetRelatorios As Array = Split(strRelatorios, "|")


            For I = 0 To vetPrincipal.Length - 1
                Select Case vetPrincipal(I)
                    Case ""
                    Case 0 'Cadastrar Cliente
                        bolBloquearCadastroCliente = True

                    Case 1 'Cadastrar Produto
                        bolBloquearCadastroProduto = True

                    Case 2 'Alterar Cliente
                        BolBloquearAlterarCliente = True

                    Case 3 'Alterar Produto
                        bolBloquearAlterarProduto = True

                    Case 4 'Cadastrar Usuarios
                        bolBloquearCadastroUsuario = True

                    Case 5 'Bloquear Usuario
                        bolBloquearBloqueioUsuario = True
                End Select
            Next
        End If
    End Sub


    Private Sub btnCadCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadCliente.ItemClick
        frmCadCliente.Tag = "CadastrarCliente"
        frmCadCliente.ShowDialog()

    End Sub

    Private Sub btnCadastrarProduto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadastrarProduto.ItemClick
        frmCadProdutos.Tag = "CadastrarProduto"
        frmCadProdutos.ShowDialog()
    End Sub

    Private Sub btnCadastrarPedido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadastrarPedido.ItemClick
        frmCadPedido.Tag = "CadastrarPedido"
        frmCadPedido.ShowDialog()

    End Sub

    Private Sub btnConsultarPedido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarPedido.ItemClick
        frmCadPedido.Tag = "ConsultarPedido"
        frmCadPedido.ShowDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frmCadPedido.Tag = "AlterarPedido"
        frmCadPedido.ShowDialog()
    End Sub

    Private Sub btnCadastrarUsuario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCadastrarUsuario.ItemClick
        frmCadUsuario.ShowDialog()
        MsgBox("REINICIE O PROGRAMA PARA APLICAR AS CONFIGURAÇÕES!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btnBloquearUsuario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBloquearUsuario.ItemClick
        frmBloquearUsuario.ShowDialog()
        MsgBox("REINICIE O PROGRAMA PARA APLICAR AS CONFIGURAÇÕES!", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btnAlterarSenha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterarSenha.ItemClick
        frmAlterarSenha.ShowDialog()
    End Sub

    Private Sub btnWhatsapp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnWhatsapp.ItemClick

    End Sub
End Class