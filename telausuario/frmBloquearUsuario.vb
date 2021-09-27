Imports telausuario.clsFuncao
Public Class frmBloquearUsuario

    Private Sub frmBloquearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpar()
        Dim dtBloqueiosPrincipal As DataTable = CarregarDataTable("select Principal from bloqueios")
        Dim dtBloqueiosRelatorios As DataTable = CarregarDataTable("select Relatorios from bloqueios")
        Dim dtPesquisarUsuarios As DataTable = CarregarDataTable("select Nome from Usuario")

        If dtPesquisarUsuarios.Rows.Count > 0 Then
            For I = 0 To dtPesquisarUsuarios.Rows.Count - 1
                If dtPesquisarUsuarios.Rows.Item(I).Item("Nome").ToString <> "" Then
                    cboUsuarios.Properties.Items.Add(dtPesquisarUsuarios.Rows.Item(I).Item("Nome"))
                End If
            Next
        End If

        If dtBloqueiosPrincipal.Rows.Count > 0 And lstAbaPrincipal.Items.Count <= 0 Then
            For I = 0 To dtBloqueiosPrincipal.Rows.Count - 1
                If dtBloqueiosPrincipal.Rows.Item(I).Item("Principal").ToString <> "" Then
                    lstAbaPrincipal.Items.Add(dtBloqueiosPrincipal.Rows.Item(I).Item("Principal"))
                End If
            Next
        End If

        If dtBloqueiosRelatorios.Rows.Count > 0 And lstAbaRelatorios.Items.Count <= 0 Then
            For I = 0 To dtBloqueiosRelatorios.Rows.Count - 1
                If dtBloqueiosRelatorios.Rows.Item(I).Item("Relatorios").ToString <> "" Then
                    lstAbaRelatorios.Items.Add(dtBloqueiosRelatorios.Rows.Item(I).Item("Relatorios"))
                End If
            Next
        End If

    End Sub

    Private Sub Limpar()
        Me.cboUsuarios.ResetText()
        Me.cboUsuarios.Properties.Items.Clear()
        Me.lstAbaPrincipal.UnCheckAll()
        Me.lstAbaRelatorios.UnCheckAll()
    End Sub
    Private Sub btnBloquear_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBloquear.ItemClick
        Dim strPrincipal As String = ""
        Dim strRelatorio As String = ""


        For I = 0 To Me.lstAbaPrincipal.Items.Count - 1
            If lstAbaPrincipal.Items.Item(I).CheckState = CheckState.Checked Then
                strPrincipal = strPrincipal & I & "|"
            End If
        Next

        For I = 0 To Me.lstAbaRelatorios.Items.Count - 1
            If lstAbaRelatorios.Items.Item(I).CheckState = CheckState.Checked Then
                strRelatorio = strRelatorio & I & "|"
            End If
        Next

        Dim dtValidarNivel As DataTable = CarregarDataTable("select * from usuario where nome = '" & Me.cboUsuarios.Text & "'")
        If dtValidarNivel.Rows.Count <> 0 Then
            If Me.cboUsuarios.Text <> "" And dtValidarNivel.Rows.Item(0).Item("Nivel") <> "MASTER" Then
                Atualizar("update usuario set Principal = '" & strPrincipal & "', Relatorios = '" & strRelatorio & "' where Nome = '" & Me.cboUsuarios.Text & "'")
                Limpar()
                MsgBox("Funções bloqueadas com sucesso.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        Limpar()
    End Sub

    Private Sub cboUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsuarios.SelectedIndexChanged
        Me.lstAbaPrincipal.UnCheckAll()
        Me.lstAbaRelatorios.UnCheckAll()

        If cboUsuarios.Text.ToString <> "" Then
            Dim dtBuscarInformacaoPrincipal As DataTable = CarregarDataTable("select Principal from usuario where Nome = '" & Me.cboUsuarios.Text & "'; ")
            Dim dtBuscarInformacaoRelatorios As DataTable = CarregarDataTable("select Relatorios from usuario where Nome = '" & Me.cboUsuarios.Text & "'; ")
            Dim strPrincipal As String = dtBuscarInformacaoPrincipal.Rows.Item(0).Item("Principal").ToString
            Dim vetPrincipal As Array = Split(strPrincipal, "|")
            Dim strRelatorios As String = dtBuscarInformacaoRelatorios.Rows.Item(0).Item("Relatorios").ToString
            Dim vetRelatorios As Array = Split(strRelatorios, "|")

            For I = 0 To vetPrincipal.Length - 1
                If vetPrincipal(I) <> "" Then
                    Dim int As Integer = vetPrincipal(I)
                    lstAbaPrincipal.Items(int).CheckState = CheckState.Checked
                End If
            Next

            For I = 0 To vetRelatorios.Length - 1
                If vetRelatorios(I) <> "" Then
                    Dim int As Integer = vetRelatorios(I)
                    lstAbaRelatorios.Items(int).CheckState = CheckState.Checked
                End If
            Next
        End If
    End Sub
End Class