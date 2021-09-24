Imports telausuario.clsFuncao
Public Class frmBloquearUsuario

    Private Sub frmBloquearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtBloqueiosPrincipal As DataTable = CarregarDataTable("select Principal from bloqueios")
        Dim dtBloqueiosRelatorios As DataTable = CarregarDataTable("select Relatorios from bloqueios")
        Dim dtPesquisarUsuarios As DataTable = CarregarDataTable("select Nome from Usuario")

        If dtPesquisarUsuarios.Rows.Count > 0 Then
            For c = 0 To dtPesquisarUsuarios.Rows.Count - 1
                If dtPesquisarUsuarios.Rows.Item(c).Item("Nome").ToString <> "" Then
                    cboUsuarios.Properties.Items.Add(dtPesquisarUsuarios.Rows.Item(c).Item("Nome"))
                End If
            Next
        End If

        If dtBloqueiosPrincipal.Rows.Count > 0 Then
            For c = 0 To dtBloqueiosPrincipal.Rows.Count - 1
                If dtBloqueiosPrincipal.Rows.Item(c).Item("Principal").ToString <> "" Then
                    chkAbaPrincipal.Items.Add(dtBloqueiosPrincipal.Rows.Item(c).Item("Principal"))
                End If
            Next
        End If

        If dtBloqueiosRelatorios.Rows.Count > 0 Then
            For c = 0 To dtBloqueiosRelatorios.Rows.Count - 1
                If dtBloqueiosRelatorios.Rows.Item(c).Item("Relatorios").ToString <> "" Then
                    chkAbaRelatorios.Items.Add(dtBloqueiosRelatorios.Rows.Item(c).Item("Relatorios"))
                End If
            Next
        End If


    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkAbaPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkAbaPrincipal.SelectedIndexChanged

    End Sub
End Class