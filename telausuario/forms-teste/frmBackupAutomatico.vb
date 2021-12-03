Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Imports telausuario.modFuncoes
Imports telausuario.clsWebHook
Imports telausuario.clsFuncaoDropBox
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
        Dim dt As DataTable = ListarArquivosDropBox("/backup/" & strCnpjCliente & "/")
        dt.Columns.Remove(".tag")
        dt.Columns.Remove("path_lower")
        dt.Columns.Remove("path_display")
        dt.Columns.Remove("rev")
        dt.Columns.Remove("is_downloadable")
        dt.Columns.Remove("content_hash")
        dt.Columns.Remove("server_modified")
        grdListagem.DataSource = dt
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUltimoBackup.ItemClick
        PegarUltimoBackup(CNPJEmpresa)
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

End Class