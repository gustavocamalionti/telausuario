Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Public Class clsWebHook
    Public Shared Function WHListarEventos() As String
        Dim dadosConta As New clsJson.clsWBListarEventos

        'dadosConta.Type = "extract_jsonpath"

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Accept") = "application/json"

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://hookb.in/oXrn6RWl7KtBnPZZnjpo"


        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim webClient As New System.Net.WebClient
            Dim jsonResult As String = webClient.DownloadString(strURL)
            'Dim jsonResult As String = Encoding.UTF8.downloadString(client.UploadData(strURL, "POST", jsonBytes))

            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            'Dim strJson As String = successResult("click").ToString


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
            Catch
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson

        End Try
    End Function

    Public Shared Function WHClick() As String
        Dim dadosConta As New clsJson.clsWBClick

        dadosConta.click = True

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"

        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://hookb.in/oXrn6RWl7KtBnPZZnjpo"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))




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
            Catch
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson

        End Try
    End Function

End Class
