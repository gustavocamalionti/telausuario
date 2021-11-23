
Imports telausuario.clsFuncao
Public Class frmSelecionarNumero

    Private Sub LimparCheckedRadio()
        Me.rbTelefone.Checked = False
        Me.rbCelular.Checked = False
        Me.rbFax.Checked = False
        Me.rbNovoNumero.Checked = False

        Me.txtNovoNumero.Properties.ReadOnly = True
    End Sub

    Private Sub MostrarDados()
        Dim dt As DataTable = CarregarDataTable("select * from Cliente where Codigo = 2 ")
        Me.txtTelefone.Text = dt.Rows.Item(0).Item("Telefone").ToString
        Me.txtCelular.Text = dt.Rows.Item(0).Item("Celular").ToString
        Me.txtFax.Text = dt.Rows.Item(0).Item("Fax").ToString
    End Sub

    Private Sub rb1_Click(sender As Object, e As EventArgs) Handles rbTelefone.Click
        LimparCheckedRadio()
        Me.rbTelefone.Checked = True
    End Sub

    Private Sub rb2_Click(sender As Object, e As EventArgs) Handles rbCelular.Click
        LimparCheckedRadio()
        Me.rbCelular.Checked = True
    End Sub

    Private Sub rb3_Click(sender As Object, e As EventArgs) Handles rbFax.Click
        LimparCheckedRadio()
        Me.rbFax.Checked = True
    End Sub
    Private Sub rb4_Click(sender As Object, e As EventArgs) Handles rbNovoNumero.Click
        LimparCheckedRadio()
        Me.rbNovoNumero.Checked = True
        Me.txtNovoNumero.Properties.ReadOnly = False
    End Sub

    Private Sub frmSelecionarNumero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDados()
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtNovoNumero_EditValueChanged(sender As Object, e As EventArgs) Handles txtNovoNumero.EditValueChanged

    End Sub

    Private Sub txtNovoNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNovoNumero.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If


        End If
    End Sub
End Class