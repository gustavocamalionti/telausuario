Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters

Imports telausuario.clsFuncao
Public Class clsDropBoxFuncao

    Public Shared Function CriarPastaDropBox(NomePastaEmpresa As String) As String


        Dim dadosConta As New clsJsonDropBox.clsCriarPasta
        dadosConta.path = NomePastaEmpresa
        dadosConta.autorename = False

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Content-Type") = "application/json"
        client.Headers("Accept") = "application/json"
        client.Headers("Authorization") = "Bearer tHkvlKuuhpsAAAAAAAAAAQfokQX9OELh3m1-L0uCUxo4PaEGyXMnFAXJG-n7h62v"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/files/create_folder_v2"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)

            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return json
        Catch ex As WebException
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try
            If ex.Message = "O servidor remoto retornou um erro: (409) Conflito." Then 'pasta já foi criada
                Exit Function
            End If
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson


        End Try

    End Function

    Public Shared Function UploadDropBox(NomeArquivo As String, CaminhoPastaDropbox As String) As String

        Dim dadosConta As New clsJsonDropBox.clsUpload
        dadosConta.path = "/" & CaminhoPastaDropbox & "/" & NomeArquivo & ""
        dadosConta.mode = "add"
        dadosConta.autorename = True
        dadosConta.mute = False
        dadosConta.strict_conflict = False
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        Dim client As New WebClient
        client.Headers("Content-Type") = "application/octet-stream"

        client.Headers("Authorization") = "Bearer tHkvlKuuhpsAAAAAAAAAAQfokQX9OELh3m1-L0uCUxo4PaEGyXMnFAXJG-n7h62v"
        client.Headers("Dropbox-API-Arg") = myData

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://content.dropboxapi.com/2/files/upload"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            ConverteArquivo(strCaminhoArquivoZip)
            DeletarArquivoDropBox(dadosConta.path.ToString)

            ' Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))

            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", mybyte))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strId As String = successResult("id").ToString

            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return json
        Catch ex As WebException
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try

            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson
        End Try

    End Function

    Public Shared Function UploadSessionStartDropbox(NomeArquivo As String, CaminhoPastaDropbox As String) As Boolean

        Dim dadosConta As New clsJsonDropBox.clsUploadSessionStart
        dadosConta.close = False
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        Dim client As New WebClient
        client.Headers("Content-Type") = "application/octet-stream"

        client.Headers("Authorization") = "Bearer tHkvlKuuhpsAAAAAAAAAAQfokQX9OELh3m1-L0uCUxo4PaEGyXMnFAXJG-n7h62v"
        client.Headers("Dropbox-API-Arg") = myData

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://content.dropboxapi.com/2/files/upload_session/start"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            ConverteArquivo(strCaminhoArquivoZip)

            ' Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))

            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", mybyte))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strId As String = successResult("id").ToString

            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return json
        Catch ex As WebException
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try

            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson
        End Try

    End Function

    Public Shared Function UploadSessionAppendDropbox(NomeArquivo As String, CaminhoPastaDropbox As String) As String

        Dim dadosConta As New clsJsonDropBox.clsUploadSessionAppend
        dadosConta.close = False
        dadosConta.cursor.offset = 0
        dadosConta.cursor.session_id = ""

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        Dim client As New WebClient
        client.Headers("Content-Type") = "application/octet-stream"

        client.Headers("Authorization") = "Bearer tHkvlKuuhpsAAAAAAAAAAQfokQX9OELh3m1-L0uCUxo4PaEGyXMnFAXJG-n7h62v"
        client.Headers("Dropbox-API-Arg") = myData

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://content.dropboxapi.com/2/files/upload_session/append_v2"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            ConverteArquivo(strCaminhoArquivoZip)

            ' Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))

            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", mybyte))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strId As String = successResult("id").ToString

            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return json
        Catch ex As WebException
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try

            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson
        End Try

    End Function

    Public Shared Function CriarLinkDropBox(NomeArquivo As String, NomePastaDropBox As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = NomePastaDropBox + "/" + NomeArquivo

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer sl.A_rshf5-D_nMdBQTsM7H_yhvbks4bcM2ylT7YvaOCTENtpnvBV8u_SI9gJUj2sYfaC1H86HdDOV-obtdT2dBZT7wAXm7OPemcsD97unJqxwQgD6U6x2MP758mtMEeA3QWJnxahkAZ-so"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/sharing/create_shared_link"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            strLinkDownloadAnexo = successResult("url").ToString.Replace("dl=0", "dl=1")
            Return strLinkDownloadAnexo


            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
        Catch ex As WebException
            strLinkDownloadAnexo = ""
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson


        End Try
    End Function

    Public Shared Function ConverteArquivo(ByVal caminho As String)
        mybyte = File.ReadAllBytes(caminho)
    End Function

    Public Shared Function DeletarArquivoDropBox(ByVal caminho As String)
        Dim dadosConta As New clsJsonDropBox.clsDeletarArquivo

        dadosConta.path = caminho

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer sl.A_rshf5-D_nMdBQTsM7H_yhvbks4bcM2ylT7YvaOCTENtpnvBV8u_SI9gJUj2sYfaC1H86HdDOV-obtdT2dBZT7wAXm7OPemcsD97unJqxwQgD6U6x2MP758mtMEeA3QWJnxahkAZ-so"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/files/delete_v2"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)


            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return json
        Catch ex As WebException
            strLinkDownloadAnexo = ""
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try
            Return strJson

        End Try
    End Function

    Public Shared Function ListarArquivosDropBox(ByVal CaminhoPastaDropbox As String) As DataTable
        Dim dtListaArquivosDropBox As New DataTable
        Dim dadosConta As New clsJsonDropBox.clsListarArquivos

        dadosConta.path = CaminhoPastaDropbox

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer tHkvlKuuhpsAAAAAAAAAAQfokQX9OELh3m1-L0uCUxo4PaEGyXMnFAXJG-n7h62v"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/files/list_folder"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim jsonResultComReplace As String = jsonResult.Substring(0, jsonResult.IndexOf("]")).Replace("""entries"": [", "") & "}"



            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strJson As String = successResult("entries").ToString

            PopulateDataTable(strJson, dtListaArquivosDropBox)

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            'Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return dtListaArquivosDropBox
        Catch ex As WebException
            strLinkDownloadAnexo = ""
            Dim strErro As String = ""
            Dim strJson As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    strJson = JsonConvert.SerializeObject(successResult2, Formatting.Indented)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try
            'Return strJson

        End Try
    End Function

    Public Shared Function PopulateDataTable(ByVal json As String, ByRef target As DataTable, Optional settings As JsonSerializerSettings = Nothing)
        Using reader = New JsonTextReader(New StringReader(json))
            Do
                If reader.TokenType = JsonToken.StartArray Then
                    ' Populate the table
                    Dim converter = New DataTableConverter()
                    converter.ReadJson(reader, target.GetType(), target, JsonSerializer.CreateDefault(settings))
                End If
            Loop While reader.Read()
        End Using
    End Function

    Public Shared Function BackupNuvemAutomatico()
        'Verificação

        Dim dtClient As DataTable = CarregarDataTable("select * from config where CNPJ = ''")

        CNPJEmpresa = "85787288000149"
        CriarPastaDropBox("/backup/" & CNPJEmpresa & "")
        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim DatDataAnalise As Date
        Dim I As Integer


        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")
            Dim tes2te As String = DateDiff(DateInterval.Month, DatDataAnalise, My.Computer.Clock.LocalTime).ToString
            If DateDiff(DateInterval.Month, DatDataAnalise, My.Computer.Clock.LocalTime) >= 2 Then
                DeletarArquivoDropBox("/backup/" & CNPJEmpresa & "/" & dt.Rows.Item(I).Item("name") & "")
            End If
        Next


        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")
            If DateDiff(DateInterval.Day, DatDataAnalise, My.Computer.Clock.LocalTime) < 1 Then
                'Exit Function - tirar o comentario para valer a verificacao
            End If
        Next

        'CONFIGURAÇÃO DE BACKUP PROGRAMADO
        Dim datHoraBackupProgramado As DateTime = "17:30"
        If My.Computer.Clock.LocalTime.TimeOfDay < datHoraBackupProgramado.TimeOfDay Then
            'Exit Function - Tirar o comentario para valer a verificação
        End If

        'BACKUP BANCO
        '''''''teste
        VerificarPastaBackupAutomatico("C:\NANO\BD\BackupAutomatico")
        ExcluirArquivosPastaBackup("C:\NANO\BD\BackupAutomatico\")
        NomeDoBancoSql = "dbTeste5" 'teste 

        Dim strCaminhoArquivoBak As String = "C:\NANO\BD\BackupAutomatico\" & NomeDoBancoSql & ".bak"
        Dim bolExistBak As Boolean = My.Computer.FileSystem.FileExists(strCaminhoArquivoBak)

        CriarBackupBanco("backup database " & NomeDoBancoSql & " to disk = '" & strCaminhoArquivoBak & "'")

        '''''''''No projeto oficial, criar uma string do tipo dim mesmo para strCaminhoArquivoZip
        strCaminhoArquivoZip = "C:\NANO\BD\BackupAutomatico\" & NomeDoBancoSql & My.Computer.Clock.LocalTime.ToString.Replace(" ", "").Replace(":", "").Replace("/", "") & ".zip"

        compactarArquivo(strCaminhoArquivoBak, strCaminhoArquivoZip)

        'UPLOAD 
        strCaminhoArquivoZip = "C:\Users\Usuario\Downloads\TesteDividirArquivo\dbDiskBrejaSincIndaia.zip.001"
        Dim indexUltimaBarra As String = strCaminhoArquivoZip.LastIndexOf("\")
        Dim NomeArquivo As String = strCaminhoArquivoZip.Substring(indexUltimaBarra + 1, (strCaminhoArquivoZip.Count - 1) - (indexUltimaBarra))

        UploadDropBox(NomeArquivo, "backup/" & CNPJEmpresa & "")
        ExcluirArquivosPastaBackup("C:\NANO\BD\BackupAutomatico\")

        'Pegar o Último backup do banco do cliente'
        Dim dt2 As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim datUltimaData As Date
        Dim strNomeUltimaData As String = ""
        Dim strTamanhoZip As String = ""
        Dim strIdDropbox As String = ""
        Dim datDataHoraEnvio As Date
        Dim intDiferencaFusoHorario As Integer


        For I = 0 To dt2.Rows.Count - 1
            DatDataAnalise = dt2.Rows.Item(I).Item("client_modified")

            If DatDataAnalise > datUltimaData Then
                datUltimaData = DatDataAnalise
                strNomeUltimaData = dt2.Rows.Item(I).Item("name")
                strTamanhoZip = dt2.Rows.Item(I).Item("size")
                strIdDropbox = dt2.Rows.Item(I).Item("id")

                'REVER ESSA LINHA DE COMANDO COM O KLEBER
                intDiferencaFusoHorario = CInt(DateDiff(DateInterval.Second, dt2.Rows.Item(I).Item("client_modified"), My.Computer.Clock.LocalTime).ToString)

                datDataHoraEnvio = DateAdd(DateInterval.Second, intDiferencaFusoHorario, dt2.Rows.Item(I).Item("client_modified"))
            End If
        Next
        Dim teste As String = DateDiff(DateInterval.Minute, datDataHoraEnvio, My.Computer.Clock.LocalTime).ToString

        If DateDiff(DateInterval.Minute, datDataHoraEnvio, My.Computer.Clock.LocalTime) <= 15 Then
            MsgBox("VERDADEIRO")
            'Enviar ou atualizar no banco todas as informações do Último backup com status VERDADEIRO
        Else
            MsgBox("FALSO")
            'Enviar ou atualizar no banco todas as informações do último backup com status FALSO 
        End If
    End Function

    Public Shared Function DownloadUltimoBackup(ByVal parCNPJEmpresa As String)
        Dim datUltimaData As Date
        Dim strNomeUltimaData As String = ""
        Dim datDataHoraEnvio As Date
        Dim intDiferencaFusoHorario As Integer
        Dim DatDataAnalise As Date

        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + parCNPJEmpresa)
        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")

            If DatDataAnalise > datUltimaData Then
                datUltimaData = DatDataAnalise
                strNomeUltimaData = dt.Rows.Item(I).Item("name")

                'REVER ESSA LINHA DE COMANDO COM O KLEBER
                intDiferencaFusoHorario = CInt(DateDiff(DateInterval.Second, dt.Rows.Item(I).Item("client_modified"), My.Computer.Clock.LocalTime).ToString)
                datDataHoraEnvio = DateAdd(DateInterval.Second, intDiferencaFusoHorario, dt.Rows.Item(I).Item("client_modified"))
            End If
        Next
        Dim strlinkDownload As String = ""
        strlinkDownload = CriarLinkDropBox(strNomeUltimaData, "/backup/" & parCNPJEmpresa & "")
        Process.Start(strlinkDownload)
    End Function

    Public Shared Function ListarUltimoBackup(ByVal parCNPJEmpresa As String) As DataTable
        Dim datUltimaData As New Date
        Dim strNomeUltimaData As String = ""
        Dim datDataHoraEnvio As Date
        Dim intDiferencaFusoHorario As Integer
        Dim DatDataAnalise As Date


        Dim dtInformacoesBackup As New DataTable
        dtInformacoesBackup.Columns.Add("nome")
        dtInformacoesBackup.Columns.Add("data")
        dtInformacoesBackup.Columns.Add("Cnpj")
        dtInformacoesBackup.Columns.Add("Empresa")
        dtInformacoesBackup.Rows.Add(0)
        'Dim dtNomeEmpresa As DataTable = CarregarDataTable("select Nome from Cliente where Cnpj = '" & parCNPJEmpresa & "'")

        Dim dt As DataTable = ListarArquivosDropBox("/Aplicativos/SQL Backup Master/" + parCNPJEmpresa)
        datDataHoraEnvio = dt.Rows.Item(dt.Rows.Count - 1).Item("client_modified")

        intDiferencaFusoHorario = -10798
        datDataHoraEnvio = DateAdd(DateInterval.Second, intDiferencaFusoHorario, dt.Rows.Item(dt.Rows.Count - 1).Item("client_modified"))

        dtInformacoesBackup.Rows.Item(0).Item("data") = datDataHoraEnvio
        dtInformacoesBackup.Rows.Item(0).Item("nome") = dt.Rows.Item(dt.Rows.Count - 1).Item("name")
        dtInformacoesBackup.Rows.Item(0).Item("cnpj") = parCNPJEmpresa
        'dtInformacoesBackup.Rows.Item(0).Item("Empresa") = dtNomeEmpresa.Rows.Item(0).Item(0)
        'REVER ESSA LINHA DE COMANDO COM O KLEBER

        Return dtInformacoesBackup

    End Function

    Public Shared Function BackupEspecifico(ByVal parNomeArquivo As String, ByVal parCNPJEmpresa As String)
        Dim strLinkDownload As String
        strLinkDownload = CriarLinkDropBox(parNomeArquivo, "/backup/" & parCNPJEmpresa & "")
        Process.Start(strLinkDownload)
    End Function
End Class

