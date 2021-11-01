﻿Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Public Class clsFuncoesDropBox

    Public Shared Function CriarPastaDropBox() As String


        Dim dadosConta As New clsJsonDropBox.clsCriarPasta
        dadosConta.path = "/TestePasta"
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

    Public Shared Function UploadDropBox(ByVal parimage As System.Drawing.Image, NomeArquivo As String) As String

        Dim dadosConta As New clsJsonDropBox.clsUpload
        dadosConta.path = "/TestePasta/" & NomeArquivo & ""
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

            Dim jsonBytes As Byte() = converteimagem(parimage)

            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
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

    Public Shared Function UploadDropBox1(NomeArquivo As String) As String

        Dim dadosConta As New clsJsonDropBox.clsUpload
        dadosConta.path = "/TestePasta/" & NomeArquivo & ""
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

            converteArquivo(strCaminhoArquivo)

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

    Public Shared Function CriarLinkDropBox(NomeArquivo As String) As String
        Dim dadosConta As New clsJsonDropBox.clsCriarLink2

        dadosConta.path = "/TestePasta/" & NomeArquivo & ""

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

    Public Shared Function converteArquivo(ByVal caminho As String)
        mybyte = File.ReadAllBytes(caminho)
    End Function

End Class
