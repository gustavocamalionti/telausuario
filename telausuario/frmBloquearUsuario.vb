Imports telausuario.clsFuncao
Public Class frmBloquearUsuario

    Private Sub frmBloquearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtBloqueiosPrincipal As DataTable = CarregarDataTable("select Principal from bloqueios")
        Dim dtBloqueiosRelatorios As DataTable = CarregarDataTable("select Relatorios from bloqueios")

        If dtBloqueiosPrincipal.Rows.Count > 0 Then

            For c = 0 To dtBloqueiosPrincipal.Rows.Count - 1
                tbBloqueiosPrincipal.Rows.Add(0)
                tbBloqueiosPrincipal.Rows.Item(0).Item("Principal") = dtBloqueiosPrincipal.Rows.Item(c).Item("Principal")
            Next

        End If

        If dtBloqueiosRelatorios.Rows.Count > 0 Then

            For c = 0 To dtBloqueiosRelatorios.Rows.Count - 1
                tbBloqueiosRelatorios.Rows.Add()
                tbBloqueiosRelatorios.Rows.Item(0).Item("Relatorios") = dtBloqueiosRelatorios.Rows.Item(c).Item("Relatorios")
            Next

        End If


    End Sub
End Class