'usar os códigos dentro das dll
Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.IO.Compression
Imports System.Text


Public Class clsFuncao
    'conexao com o banco para select no campo
    Public Shared Function CarregarDados(ByVal parQuery As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean
        parQuery = "SET DATEFORMAT dmy " & parQuery
        Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario) 'String de Conexão
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        da = New SqlDataAdapter(parQuery, conexao)
        dt = New DataTable

        Try
            da.Fill(dt)
            parGrid.DataSource = dt.DefaultView
            Return True
        Catch ex As Exception
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information
                   )
            Return False
        End Try

    End Function

    Public Shared Function CarregarDataTable(ByVal parQuery As String) As DataTable
        parQuery = "SET DATEFORMAT dmy " & parQuery
        Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario) 'String de Conexão
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        da = New SqlDataAdapter(parQuery, conexao)
        dt = New DataTable

        Try
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information
                   )
        End Try

    End Function

    Public Shared Function Inserir(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Atualizar(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Deletar(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function CriarBackupBanco(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function



    Public Shared Function compactarArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)


        ' Descompacta a string compactada previamente.  primeiro , cria a entrada do arquivo stream
        Dim streamFonte As New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)

        ' ----- Cria a saida do arquivo stream
        Dim streamDestino As New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

        ' ----- Os bytes serão processados por um compressor de streams
        Dim streamCompactado As New GZipStream(streamDestino, CompressionMode.Compress, True)

        Try
            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer

            Do
                bytesLidos = streamFonte.Read(buffer, 0, tamanhoBloco)

                If (bytesLidos = 0) Then Exit Do

                streamCompactado.Write(buffer, 0, bytesLidos)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            ' ----- Fecha todos os streams
            streamFonte.Close()
            streamCompactado.Close()
            streamDestino.Close()
        End Try

    End Function
    Public Shared Function BuscaCep(ByVal cep As String) As Hashtable
        Dim ds As DataSet
        Dim _resultado As String
        Dim ht As System.Collections.Hashtable
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    _resultado = ds.Tables(0).Rows(0).Item("resultado").ToString()
                    ht = New Hashtable
                    Select Case _resultado
                        Case "1"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                            ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim())
                            ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                            ht.Add("tipo", 1)

                        Case "2"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)

                        Case Else
                            ht.Add("tipo", 0)
                    End Select
                End If
            End If
            Return ht
        Catch ex As Exception
            Throw New Exception("Falha ao Buscar o Cep" & vbCrLf & ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function cfgPressNumVirgulas(campo As DevExpress.XtraEditors.TextEdit, z As KeyPressEventArgs)
        If campo.Text.Contains(",") = True Then
            If z.KeyChar = "," Then
                z.Handled = True
                Exit Function
            End If
        End If
        If campo.Text.Contains("-") = True Then
            If z.KeyChar = "-" Then
                z.Handled = True
                Exit Function
            End If

        End If

        If z.KeyChar = "-" And campo.Text.Length <> 0 Then
            z.Handled = True
            Exit Function
        End If

        If Char.IsNumber(z.KeyChar) = False And z.KeyChar <> vbBack And z.KeyChar <> "," And z.KeyChar <> "-" Then
            z.Handled = True
        End If

    End Function
    Public Shared Function cfgLeaveNumVirgulas(campo As DevExpress.XtraEditors.TextEdit)
        If campo.Text = "" Then
            campo.Text = FormatNumber(0, 3)
            Exit Function
        End If

        If campo.Text.Substring(0, 1) = "," Then
            campo.Text = FormatNumber(0, 3)
            Exit Function
        End If

        If campo.Text.Length >= 2 Then
            If campo.Text.Substring(0, 1) = "-" And campo.Text.Substring(1, 1) = "," Then
                campo.Text = FormatNumber(0, 3)
                Exit Function
            End If
        End If
        If IsNumeric(campo.Text.Substring(0, 1)) = True Then
            If campo.Text.Contains("-") Then
                campo.ResetText()
                Exit Function
            End If
            Dim dblAproximacao As Double = campo.Text
            campo.Text = FormatNumber(dblAproximacao, 3)
            Exit Function
        End If
    End Function


    Public Shared Function cfgPressTelefone(campo As DevExpress.XtraEditors.TextEdit, z As KeyPressEventArgs)

        If Char.IsNumber(z.KeyChar) = False Then
            z.Handled = True
        End If

        If z.KeyChar = vbBack Then
            z.Handled = False
            Exit Function

        ElseIf Char.IsNumber(z.KeyChar) = True Then

            campo.Properties.MaxLength = 14
            Select Case campo.Text.Length
                Case 0
                    campo.Text = campo.Text & "("
                    campo.SelectionStart = campo.Text.Length

                Case 3
                    campo.Text = campo.Text & ")"
                    campo.SelectionStart = campo.Text.Length

                Case 9
                    campo.Text = campo.Text & "-"
                    campo.SelectionStart = campo.Text.Length
            End Select

        End If
    End Function

    Public Shared Function cfgContador(campo As DevExpress.XtraEditors.TextEdit, ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim intContLinhas As Integer
        intContLinhas = Grid.RowCount()

        campo.Text = intContLinhas
    End Function

    Public Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream
        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream
        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes
        Return ms.ToArray()

    End Function

    Public Shared Function PrimeiraLetraMaiuscula(ByVal str As String) As String
        'TRANFORMA A FRASE TODA EM MINUSCULA
        str = str.ToLower
        '**SEPARA AS PALAVRAS DA FRASE EM UM ARRAY  USAMOS A FUNÇÃO  SPLIT PARA OBTER O  RESULTADO **
        Dim palavras As String() = str.Split(New Char() {" "c})
        '**VARIAVEL QUE RECEBERÁ A PALAVRA QUANDO  PERCORRERMOS O ARRAY
        Dim palavra As String
        '**VARIAVEL DE APOIO PARA TRANSFORMAR A PRIMEIRA LETRA EM MAIUSCULO
        Dim troca As String
        '*** RETORNO VARIAVEL QUE IRÁ GUARDAR A CONCATENÇÃO  DO  ARRAY GERADO
        Dim retorno As String = Nothing
        '** ARRAY PARA MONTARMOS NOVAMENTE A FRASE JA FORMATADA
        Dim resul(UBound(palavras)) As String
        '*** VARIAVEL DE APOIO PARA DETERMINARMOS O INDICE DO  ARRAY QUANDO  RECEBER A PALAVRA
        Dim cont As Integer = 0
        '** LAÇO PARA CONVERTER A PRIMEIRA LETRA DE CADA PALAVRA EM MAIUSCULA
        For Each palavra In palavras
            '***CONDIÇÃO  PARA GARANTIR QUE PALAVRAS COM MAIS DE 2 CARACTERES SOFRAM A ACTION DA FUNÇÃO
            If Len(Trim(palavra)) > 1 Then
                'troca = UCase(Mid(palavra, 1, 1))
                'palavra = palavra.Replace(LCase(troca), troca)
                troca = palavra.Substring(0, 1).ToUpper
                resul(cont) = troca & palavra.Substring(1, Len(palavra) - 1)
            Else
                resul(cont) = palavra.ToUpper
            End If
            cont += 1
        Next
        retorno = Join(resul)
        Return retorno
    End Function

    Public Shared Function CheckIfFIlesExists(ByVal parURL As String, ByVal username As String, ByVal password As String) As Boolean
        Dim request = DirectCast(System.Net.WebRequest.Create(parURL), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(username, password)
        request.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
        Try
            Using response As System.Net.FtpWebResponse = DirectCast(request.GetResponse(), System.Net.FtpWebResponse)
                ' Folder exists here
                Return True
            End Using

        Catch ex As System.Net.WebException
            Dim response As System.Net.FtpWebResponse = DirectCast(ex.Response, System.Net.FtpWebResponse)
            'Does not exist
            If response.StatusCode = System.Net.FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If
        End Try
    End Function

    Public Shared Function InserirImagemFtp(ByVal parCaminhoImagem As String, ByVal parURL As String, ByVal username As String, ByVal password As String) As Boolean
        Try
            Dim arquivoInfo As FileInfo = New FileInfo(parCaminhoImagem)

            Dim request As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(New Uri(parURL)), System.Net.FtpWebRequest)
            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            request.Credentials = New System.Net.NetworkCredential(username, password)
            request.UseBinary = True
            request.ContentLength = arquivoInfo.Length

            Using fs As FileStream = arquivoInfo.OpenRead()
                Dim buffer As Byte() = New Byte(2047) {}
                Dim bytesSent As Integer = 0
                Dim bytes As Integer = 0

                Using stream As Stream = request.GetRequestStream()

                    While bytesSent < arquivoInfo.Length
                        bytes = fs.Read(buffer, 0, buffer.Length)
                        stream.Write(buffer, 0, bytes)
                        bytesSent += bytes
                    End While
                End Using
            End Using

            Return True
        Catch ex As System.Net.WebException

            Dim response As System.Net.FtpWebResponse = DirectCast(ex.Response, System.Net.FtpWebResponse)
            'Does not exist
            If response.StatusCode = System.Net.FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If

            Return False
        End Try
    End Function

    Public Shared Function ExcluirImagemFtp(ByVal parCaminhoImagem As String, ByVal parURL As String, ByVal username As String, ByVal password As String) As Boolean
        Try
            Dim arquivoInfo As FileInfo = New FileInfo(parCaminhoImagem)

            Dim request As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(New Uri(parURL)), System.Net.FtpWebRequest)
            request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
            request.Credentials = New System.Net.NetworkCredential(username, password)
            request.UseBinary = True
            request.ContentLength = arquivoInfo.Length
            Dim RespostaCriarPasta As System.Net.FtpWebResponse = CType(request.GetResponse(), System.Net.FtpWebResponse)
            RespostaCriarPasta.Close()
            Return True
        Catch ex As System.Net.WebException

            Dim response As System.Net.FtpWebResponse = DirectCast(ex.Response, System.Net.FtpWebResponse)
            'Does not exist
            If response.StatusCode = System.Net.FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            Else
                MsgBox(ex.Message)
                Return False
            End If

        End Try
    End Function
    Public Shared Function CriarPastaFtp(ByVal parURL As String, ByVal username As String, ByVal password As String, ByVal parTipo As String) As Boolean
        Try
            Dim CriarPasta As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(New Uri(parURL)), System.Net.FtpWebRequest)
            CriarPasta.KeepAlive = False
            CriarPasta.UseBinary = True
            CriarPasta.Credentials = New System.Net.NetworkCredential(username, password)

            CriarPasta.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory
            Dim RespostaCriarPasta As System.Net.FtpWebResponse = CType(CriarPasta.GetResponse(), System.Net.FtpWebResponse)
            RespostaCriarPasta.Close()
            Return True
        Catch ex As System.Net.WebException

            Dim response As System.Net.FtpWebResponse = DirectCast(ex.Response, System.Net.FtpWebResponse)
            'Does not exist
            If response.StatusCode = System.Net.FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            Else
                MsgBox("Erro ao criar " & parTipo & "!" & vbCrLf & ex.Message)
                Return False
            End If
        End Try
    End Function

    Public Shared Function removeAcentos(ByVal texto As String) As String
        Dim vPos As Byte

        Const vComAcento = "ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÒÓÔÕÖÙÚÛÜàáâãäåçèéêëìíîïòóôõöùúûü"
        Const vSemAcento = "AAAAAACEEEEIIIIOOOOOUUUUaaaaaaceeeeiiiiooooouuuu"

        For i = 1 To Len(texto)
            vPos = InStr(1, vComAcento, Mid(texto, i, 1))
            If vPos > 0 Then
                Mid(texto, i, 1) = Mid(vSemAcento, vPos, 1)
            End If
        Next
        removeAcentos = texto
    End Function

    Public Shared Function AnaliseArquivosFtp(ByVal parURL As String, ByVal username As String, ByVal password As String) As Array
        Dim request As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(New Uri(parURL)), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(username, password)
        request.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails
        Dim sr As New StreamReader(request.GetResponse().GetResponseStream())
        Dim str As String = sr.ReadLine()

        Dim dtItens As New DataTable
        dtItens.Columns.Add(New DataColumn("Coluna1", GetType(String)))
        Dim I As Integer = 0
        While Not str Is Nothing
            dtItens.Rows.Add()
            dtItens.Rows.Item(I).Item("Coluna1") = str
            I += 1
            str = sr.ReadLine()
        End While
        sr.Close()
        sr = Nothing
        Dim list = dtItens.Rows.Cast(Of DataRow).ToList
        request = Nothing

        Dim z As Integer = 0
        For z = 2 To dtItens.Rows.Count - 1
            Dim item As String = dtItens.Rows.Item(z).Item("Coluna1").ToString.Replace(" ", "/")
            Dim BuscaData As Array = item.Split("/")
            Dim NomeArquivo As String
            Try
                Dim PosNomeArquivo As Integer = BuscaData.Length - 1
                NomeArquivo = BuscaData(PosNomeArquivo).ToString
            Catch
            End Try
            Dim dataModificacao As Date = DataArquivoFtp(parURL & "/" & NomeArquivo, LoginFTP, SenhaFTP).ToString
            Dim dtDataLimite As Date = dataModificacao.AddMonths(2)

            Dim DiferencaData As Integer = DateDiff(DateInterval.Month, Today, dtDataLimite)
            If DiferencaData <= 0 Then
                ExcluirImagemFtp(parURL & "/" & NomeArquivo, StringConexaoFTP & CNPJEmpresa, LoginFTP, SenhaFTP)
            End If
        Next
    End Function

    Public Shared Function DataArquivoFtp(sAdresse As String, sUser As String, sPass As String) As DateTime
        Dim uriFTPFile As Uri = New Uri(sAdresse)
        Dim ftpRequest As System.Net.FtpWebRequest = CType(System.Net.WebRequest.Create(uriFTPFile), System.Net.FtpWebRequest)
        ftpRequest.Credentials = New System.Net.NetworkCredential(sUser, sPass)
        ftpRequest.Method = System.Net.WebRequestMethods.Ftp.GetDateTimestamp
        Dim ftpResponse As System.Net.FtpWebResponse = CType(ftpRequest.GetResponse(), System.Net.FtpWebResponse)
        Dim dtLastModified As DateTime = ftpResponse.LastModified
        Return dtLastModified
    End Function

    Public Shared Function VerificarPastaBackupAutomatico(ByVal parDiretorioPasta As String)
        'Criar Pasta/Verificar Pasta
        If Not IO.Directory.Exists(parDiretorioPasta) Then
            System.IO.Directory.CreateDirectory(parDiretorioPasta)
        End If

    End Function

    Public Shared Function ExcluirArquivosPastaBackup(ByVal parDiretorioPasta As String)

        Dim vetListaArquivos As Array = {}

        vetListaArquivos = System.IO.Directory.GetFiles(parDiretorioPasta)

        Dim I As Integer
        For I = 0 To vetListaArquivos.Length - 1
            Try
                System.IO.File.Delete(vetListaArquivos(I))
            Catch ExIO As Exception
                Debug.Print(ExIO.Message)
            End Try
        Next

    End Function

End Class


