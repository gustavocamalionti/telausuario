
Imports telausuario.modFuncoes
Imports telausuario.clsFuncao
Public Class frmMenu

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
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBloquearUsuario.ItemClick
        frmBloquearUsuario.ShowDialog()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class