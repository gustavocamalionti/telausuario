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



Public Class frmDropBoxTeste
    Private Sub btnCriarPasta_Click(sender As Object, e As EventArgs) Handles btnCriarPasta.Click
        CriarPastaDropBox("/backup/" & CNPJEmpresa & "")

        MsgBox("OPERAÇÃO REALIZADA", MsgBoxStyle.Information)
    End Sub

    Private Sub btnBackupBanco_Click(sender As Object, e As EventArgs) Handles btnBackupBanco.Click
        Dim strCaminhoArquivo As String = "C:\NANO\BD\dbTeste5"
        Dim bolExistBak As Boolean = My.Computer.FileSystem.FileExists(strCaminhoArquivo + ".bak")
        Dim bolExistZip As Boolean = My.Computer.FileSystem.FileExists(strCaminhoArquivo + ".zip")


        If bolExistBak = True Then
            My.Computer.FileSystem.DeleteFile(strCaminhoArquivo + ".bak")
        End If
        If bolExistZip = True Then
            My.Computer.FileSystem.DeleteFile(strCaminhoArquivo + ".zip")
        End If

        CriarBackupBanco("backup database dbTeste5 to disk = '" & strCaminhoArquivo & "" + ".bak'")
        compactarArquivo(strCaminhoArquivo + ".bak", strCaminhoArquivo + ".zip")

        MsgBox("OPERAÇÃO REALIZADA", MsgBoxStyle.Information)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim strCaminhoArquivo As String = "C:\NANO\BD\dbTeste5"
        UploadDropBox("dbTeste5.zip", "backup/" & CNPJEmpresa & "")

        MsgBox("OPERAÇÃO REALIZADA", MsgBoxStyle.Information)
    End Sub

    Private Sub btnListarArquivos_Click(sender As Object, e As EventArgs) Handles btnListarArquivos.Click

        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        dt.Columns.Remove(".tag")
        dt.Columns.Remove("path_lower")
        dt.Columns.Remove("path_display")
        dt.Columns.Remove("rev")
        dt.Columns.Remove("is_downloadable")
        dt.Columns.Remove("content_hash")
        grd1.DataSource = dt


    End Sub

End Class