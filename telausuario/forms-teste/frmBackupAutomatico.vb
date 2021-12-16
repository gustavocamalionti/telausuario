Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Imports telausuario.modFuncoes
Imports telausuario.clsWebHook
Imports telausuario.clsDropBoxFuncao
Imports Microsoft.Win32
Imports System.Threading
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Class frmBackupAutomatico
    Private Sub btnDownload_Click(sender As Object, e As EventArgs)
        indexPedidoAtual = Me.grd1.FocusedRowHandle

        If Me.grd1.GetRowCellValue(indexPedidoAtual, "name") <> "" Then
            Dim strNomeBackupEspecifico As String = Me.grd1.GetRowCellValue(indexPedidoAtual, "name")
            BackupEspecifico(strNomeBackupEspecifico, CNPJEmpresa)
        Else
            MsgBox("Selecione um Backup")
        End If
    End Sub

    Private Sub btnListar1_Click(sender As Object, e As EventArgs) Handles btnListar1.Click
        Dim strCnpjCliente As String = CNPJEmpresa
        Dim dt As New DataTable


        dt.Columns.Add("name")
        dt.Columns.Add("id")
        dt.Columns.Add("client_modified")
        dt.Columns.Add("size")
        dt = ListarArquivosDropBox("/backup/" & strCnpjCliente & "/")
        dt.Columns.Add("Cnpj")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            dt.Rows.Item(I).Item("Cnpj") = strCnpjCliente
        Next

        dt.Columns.Remove(".tag")
        dt.Columns.Remove("path_lower")
        dt.Columns.Remove("path_display")
        dt.Columns.Remove("rev")
        dt.Columns.Remove("is_downloadable")
        dt.Columns.Remove("content_hash")
        dt.Columns.Remove("server_modified")
        grd1.Columns.Clear()
        grdListagem.DataSource = dt

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUltimoBackup.ItemClick
        DownloadUltimoBackup(CNPJEmpresa)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDownload.ItemClick
        indexPedidoAtual = Me.grd1.FocusedRowHandle

        If Me.grd1.GetRowCellValue(indexPedidoAtual, "name") <> "" Then
            Dim strNomeBackupEspecifico As String = Me.grd1.GetRowCellValue(indexPedidoAtual, "name")
            BackupEspecifico(strNomeBackupEspecifico, CNPJEmpresa)
        Else
            MsgBox("Selecione um Backup")
        End If
    End Sub

    Private Sub btnFechar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelatorioGeral_Click(sender As Object, e As EventArgs) Handles btnRelatorioGeral.Click
        Dim dtListaEmpresas As DataTable = ListarArquivosDropBox("/Aplicativos/SQL Backup Master/")
        Dim I As Integer

        Dim dtBackupUltimoResultado As New DataTable
        Dim dtRelatorioGeral As New DataTable
        dtRelatorioGeral.Columns.Add("data")
        dtRelatorioGeral.Columns.Add("Empresa")
        dtRelatorioGeral.Columns.Add("Cnpj")
        dtRelatorioGeral.Columns.Add("nome")



        For I = 0 To dtListaEmpresas.Rows.Count - 1
            dtBackupUltimoResultado = ListarUltimoBackup(dtListaEmpresas.Rows.Item(I).Item("name"))
            dtRelatorioGeral.ImportRow(dtBackupUltimoResultado.Rows.Item(0))
        Next

        grd1.Columns.Clear()
        grdListagem.DataSource = dtRelatorioGeral
    End Sub
End Class