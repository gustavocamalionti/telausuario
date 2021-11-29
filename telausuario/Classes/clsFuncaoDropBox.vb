Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters

Imports telausuario.clsFuncao
Public Class clsFuncaoDropBox

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
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
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

        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
        client.Headers("Dropbox-API-Arg") = myData

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://content.dropboxapi.com/2/files/upload"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            ConverteArquivo(strCaminhoArquivoZip)
            DeletarArquivoDropBox(dadosConta.path.ToString)

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

    Public Shared Function downloadDropBox(NomeArquivo As String, CaminhoPastaDropbox As String) As String

        Dim dadosConta As New clsJsonDropBox.clsDownload

       
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
        client.Headers("Dropbox-API-Arg") = "/backup/36916588000175/dbTeste5-29112021-141137.zip"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://content.dropboxapi.com/2/files/download"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            strLinkDownloadAnexo = successResult("url").ToString.Replace("dl=0", "dl=1")


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

    Public Shared Function CriarLinkDropBox(NomeArquivo As String, CaminhoPastaDropbox As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = "/" & CaminhoPastaDropbox & "/" & NomeArquivo & ""

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/sharing/create_shared_link_with_settings"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            strLinkDownloadAnexo = successResult("url").ToString.Replace("dl=0", "dl=1")


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
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
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
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/files/list_folder"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            'Dim jsonResultComReplace As String = jsonResult.Substring(0, jsonResult.IndexOf("]")).Replace("""entries"": [", "") & "}"



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

    Public Shared Function RecuperarLinkDropBox(NomeArquivo As String, NomePastaEmpresa As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = "/" & NomePastaEmpresa & "/" & NomeArquivo & ""

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer tsS3SIRj_SAAAAAAAAAAAZe_nOphlq6s7LwWc6JA5MAAdtcscgk9pVaP0IWPSiuR"
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.dropboxapi.com/2/sharing/list_shared_links"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strJsonOriginal As String = successResult("links").ToString
            Dim strjsonEditado As String = strJsonOriginal.Substring(0, strJsonOriginal.IndexOf("link_permissions") - 8) & "}]"
            Dim dtLinkRecuperado As New DataTable
            PopulateDataTable(strjsonEditado, dtLinkRecuperado)

            If dtLinkRecuperado.Rows.Count > 0 Then
                strLinkDownloadAnexo = dtLinkRecuperado.Rows.Item(0).Item("url").ToString.Replace("dl=0", "dl=1")
            End If



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
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson


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
        '
        'Verificação
        CriarPastaDropBox("/backup/" & CNPJEmpresa & "")
        Dim dt As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim DatDataAnalise As Date

        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            DatDataAnalise = dt.Rows.Item(I).Item("client_modified")
            If DateDiff(DateInterval.Day, DatDataAnalise, Today) < 1 Then
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
        NomeDoBancoSql = "dbTeste5"
        Dim strCaminhoArquivoBak As String = "C:\NANO\BD\" & NomeDoBancoSql & ".bak"
        Dim bolExistBak As Boolean = My.Computer.FileSystem.FileExists(strCaminhoArquivoBak)

        If bolExistBak = True Then
            My.Computer.FileSystem.DeleteFile(strCaminhoArquivoBak)
        End If

        CriarBackupBanco("backup database " & NomeDoBancoSql & " to disk = '" & strCaminhoArquivoBak & "'")

        '''''''''No projeto oficial, criar uma string do tipo dim mesmo para strCaminhoArquivoZip
        strCaminhoArquivoZip = "C:\NANO\BD\" & NomeDoBancoSql & My.Computer.Clock.LocalTime.ToString.Replace(" ", "").Replace(":", "").Replace("/", "") & ".zip"

        compactarArquivo(strCaminhoArquivoBak, strCaminhoArquivoZip)

        'UPLOAD 
        Dim indexUltimaBarra As String = strCaminhoArquivoZip.LastIndexOf("\")
        Dim NomeArquivo As String = strCaminhoArquivoZip.Substring(indexUltimaBarra + 1, (strCaminhoArquivoZip.Count - 1) - (indexUltimaBarra))

        UploadDropBox(NomeArquivo, "backup/" & CNPJEmpresa & "")

        My.Computer.FileSystem.DeleteFile(strCaminhoArquivoZip)
        My.Computer.FileSystem.DeleteFile(strCaminhoArquivoBak)

        'Pegar o Último backup do banco do cliente'
        Dim dt2 As DataTable = ListarArquivosDropBox("/backup/" + CNPJEmpresa)
        Dim datUltimaData As Date
        Dim strNomeUltimaData As String = ""
        Dim strTamanhoZip As String = ""
        Dim strIdDropbox As String = ""
        Dim datDataHoraEnvio As Date
        Dim intDiferencaFusoHorario As Integer

        For I = 0 To dt.Rows.Count - 1
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

End Class

