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

Public Class frmDropBoxTeste
    Private Sub btnCriarPasta_Click(sender As Object, e As EventArgs)
        CriarPastaDropBox("/backup/" & CNPJEmpresa & "")

        MsgBox("OPERAÇÃO REALIZADA", MsgBoxStyle.Information)
    End Sub

    Private Sub btnBackupBanco_Click(sender As Object, e As EventArgs)

        'teste
        NomeDoBancoSql = "dbTeste5"
        Dim strCaminhoArquivoBak As String = "C:\NANO\BD\" & NomeDoBancoSql & ".bak"
        Dim bolExistBak As Boolean = My.Computer.FileSystem.FileExists(strCaminhoArquivoBak)

        If bolExistBak = True Then
            My.Computer.FileSystem.DeleteFile(strCaminhoArquivoBak)
        End If

        CriarBackupBanco("backup database " & NomeDoBancoSql & " to disk = '" & strCaminhoArquivoBak & "'")

        'No projeto oficial, criar uma string do tipo dim mesmo para strCaminhoArquivoZip
        strCaminhoArquivoZip = "C:\NANO\BD\" & NomeDoBancoSql & "-" & My.Computer.Clock.LocalTime.ToString.Replace(" ", "-").Replace(":", "").Replace("/", "") & ".zip"

        compactarArquivo(strCaminhoArquivoBak, strCaminhoArquivoZip)


        MsgBox("OPERAÇÃO REALIZADA", MsgBoxStyle.Information)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs)
        Dim indexUltimaBarra As String = strCaminhoArquivoZip.LastIndexOf("\")
        Dim NomeArquivo As String = strCaminhoArquivoZip.Substring(indexUltimaBarra + 1, (strCaminhoArquivoZip.Count - 1) - (indexUltimaBarra))

        UploadDropBox(NomeArquivo, "backup/" & CNPJEmpresa & "")

        My.Computer.FileSystem.DeleteFile(strCaminhoArquivoZip)

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

    Private Sub btnUltimobackup_Click(sender As Object, e As EventArgs)
        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim DatDataAnalise As Date

        Dim datUltimaData As Date
        Dim strNomeUltimaData As String = ""
        Dim strTamanhoZip As String = ""
        Dim strIdDropbox As String = ""
        Dim strDataHoraEnvio As String = ""

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")

            If DatDataAnalise > datUltimaData Then
                datUltimaData = DatDataAnalise
                strNomeUltimaData = dt.Rows.Item(I).Item("name")
                strTamanhoZip = dt.Rows.Item(I).Item("size")
                strIdDropbox = dt.Rows.Item(I).Item("id")
                strDataHoraEnvio = dt.Rows.Item(I).Item("client_modified")

            End If
        Next

    End Sub

    Private Sub btnVerificacoes_Click(sender As Object, e As EventArgs)
        'Dim strNomeBancoAtual As String = CarregarDataTable("SELECT DB_NAME() AS [Current Database];").Rows.Item(0).Item("Current Database").ToString
        'Dim strNomeBancoRecomendado As String = "db" + (PrimeiraLetraMaiuscula(NomeEmpresa)).Replace(" ", "")

        'If strNomeBancoAtual <> strNomeBancoRecomendado Then
        'Atualizar("ALTER DATABASE " & strNomeBancoAtual & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;")
        'Atualizar("ALTER DATABASE " & strNomeBancoAtual & " MODIFY NAME = " & strNomeBancoRecomendado & ";")
        ' Atualizar("USE MASTER; ALTER DATABASE " & strNomeBancoRecomendado & " SET MULTI_USER; USE " & strNomeBancoRecomendado & "")
        'End If

        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim DatDataAnalise As Date

        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")
            If DateDiff(DateInterval.Day, DatDataAnalise, Today) < 1 Then
                Exit Sub
            End If
        Next
        Dim datHoraBackupProgramado As DateTime = "17:30"
        'CONFIGURAÇÃO DE BACKUP PROGRAMADO
        If My.Computer.Clock.LocalTime.TimeOfDay < datHoraBackupProgramado.TimeOfDay Then
            Exit Sub
        End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnFuncaoCompleta.Click
        BackupNuvemAutomatico()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        DownloadUltimoBackup(CNPJEmpresa)
    End Sub

    Private Sub btnLocalizarBackup_Click(sender As Object, e As EventArgs) Handles btnLocalizarBackup.Click
        frmBackupAutomatico.ShowDialog()
    End Sub

    Private Sub frmDropBoxTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class