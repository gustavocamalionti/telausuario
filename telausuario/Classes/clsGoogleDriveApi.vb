Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Public Class clsGoogleDriveApi


    Public Shared Function CriarPastaGoogleDrive(NomePastaEmpresa As String) As String

        Dim dadosToken As New ClassesJson.clsAccessToken

        'dadosToken.grant_type = "application/x-www-form-urlencoded"
        dadosToken.client_id = "613336258335-9te99rs60c16dt7m80121caddmd0057j.apps.googleusercontent.com"

        ' dadosNFe.client_id = "3200249308754173"
        dadosToken.client_secret = "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"
        'dadosToken.code = Me.TextEdit1.Text
        dadosToken.redirect_uri = "https://webhook.site/1f292bc4-db0f-47c5-9fcc-368854b9eba8"
        dadosToken.response_type = "code"
        dadosToken.scope = "email profile"

        Dim myData As String = JsonConvert.SerializeObject(dadosToken)

        Dim client As New WebClient
        'client.BaseAddress = "https://oauth2.googleapis.com/token"
        'client.Headers("Authorization") = "Basic " & apiKey
        'client.Headers("Accept") = "application/json"
        'client.Headers("Content-Type") = "application/json"

        'client.Headers("Response_Type") = "code"

        ServicePointManager.Expect100Continue = False

        'Dim strURL As String = "https://accounts.google.com/o/oauth2/auth"
        Dim strURL As String = "https://accounts.google.com/o/oauth2/auth"

        Try
            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)

            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))

            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            'Me.MemoEdit1.Text = jsonResult
            AccessToken = successResult("access_token")
            RefreshToken = successResult("refresh_token")

        Catch ex As WebException
            Dim str As String = "teste"
        End Try

    End Function

    Public Shared Function UploadGoogleDrive(NomeArquivo As String, NomePastaEmpresa As String) As String

        Dim dadosConta As New clsJsonDropBox.clsUpload
        dadosConta.path = "/" & NomePastaEmpresa & "/" & NomeArquivo & ""
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

            ConverteArquivo(strCaminhoArquivo)
            DeletarArquivoGoogleDrive(dadosConta.path.ToString)

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

    Public Shared Function ReceberToken(NomeArquivo As String, NomePastaEmpresa As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = "/" & NomePastaEmpresa & "/" & NomeArquivo & ""

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

    Public Shared Function CriarLinkGoogleDrive(NomeArquivo As String, NomePastaEmpresa As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = "/" & NomePastaEmpresa & "/" & NomeArquivo & ""

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

    Public Shared Function DeletarArquivoGoogleDrive(ByVal caminho As String)
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

    Public Shared Function ListarArquivosGoogleDrive(ByVal CaminhoPastaEmpresa As String)
        Dim dadosConta As New clsJsonDropBox.clsListarArquivos

        dadosConta.path = CaminhoPastaEmpresa

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

    Public Shared Function RecuperarLinkGoogleDrive(NomeArquivo As String, NomePastaEmpresa As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink

        dadosConta.path = "/" & NomePastaEmpresa & "/" & NomeArquivo & ""

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer fIC5DvLUAqwAAAAAAAAAASG3cPReUZV1gMa1tW0G-hRiT8u0Z2psf0lY2LG-oKc4"
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
    Public Shared Function PopulateDataTable(json As String, target As DataTable, Optional settings As JsonSerializerSettings = Nothing)
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

End Class
