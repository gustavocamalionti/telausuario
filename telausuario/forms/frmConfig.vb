Public Class frmConfig

    Private Sub ConfigBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ConfigBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConfigBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTelaUsuario)

    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTelaUsuario.Config' table. You can move, or remove it, as needed.
        Me.ConfigTableAdapter.Fill(Me.DsTelaUsuario.Config)

    End Sub

    Private Sub CNPJTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Aceitar apenas Números 
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If

        'aceitar Delete
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If

        'PARA CNPJ
        Me.txtCnpj.Properties.MaxLength = 18
        Select Case Me.txtCnpj.Text.Length
            Case 2
                Me.txtCnpj.Text = Me.txtCnpj.Text & "."
                Me.txtCnpj.SelectionStart = Me.txtCnpj.Text.Length

            Case 6
                Me.txtCnpj.Text = Me.txtCnpj.Text & "."
                Me.txtCnpj.SelectionStart = Me.txtCnpj.Text.Length

            Case 10
                Me.txtCnpj.Text = Me.txtCnpj.Text & "\"
                Me.txtCnpj.SelectionStart = Me.txtCnpj.Text.Length

            Case 15
                Me.txtCnpj.Text = Me.txtCnpj.Text & "-"
                Me.txtCnpj.SelectionStart = Me.txtCnpj.Text.Length
        End Select

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Validate()
        Me.ConfigBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTelaUsuario)
        MsgBox("Alterações Realizadas com Sucesso.", MsgBoxStyle.Exclamation)
        Me.Close()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub txtEndereco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEndereco.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Validate()
            Me.ConfigBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsTelaUsuario)
            MsgBox("Alterações Realizadas com Sucesso.", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub txtEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpresa.KeyPress, txtTelefone.KeyPress, txtEndereco.KeyPress, txtCnpj.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEndereco_EditValueChanged(sender As Object, e As EventArgs) Handles txtEndereco.EditValueChanged

    End Sub
End Class