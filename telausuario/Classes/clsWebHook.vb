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

    Public Shared Function WHPost() As String

        'Dim httpWebRequest As HttpWebRequest = WebRequest.Create("https://webhook.site/ebcd180e-e2f2-4ff2-ae84-b1745e1d959c/token")

        'httpWebRequest.ContentType = "application/json"
        'httpWebRequest.Method = "POST"
        'Try
        'Dim response As StreamWriter = New StreamWriter(HttpWebRequest.GetRequestStream())
        ' Dim json As String = "{ ""name"": ""Jhon""}"

        ' StreamWriter.Null.Write(json)
        ' StreamWriter.Null.Flush()
        ' StreamWriter.Null.Close()

        ' Catch
        ' End Try



        '  Dim httpResponse As HttpWebResponse = HttpWebRequest.GetResponse()
        'Try
        'Dim response As StreamReader = New StreamReader(httpResponse.GetResponseStream)
        '  Dim result As String = response.ReadToEnd()

        'Catch
        ' End Try


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

        Dim strURL As String = "https://webhook.site/ebcd180e-e2f2-4ff2-ae84-b1745e1d959c/token"

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

    Public Shared Function WHGet() As String
        Dim tempcookies As New CookieContainer
        Dim encoding As New UTF8Encoding

        Dim postreq As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://webhook.site/ebcd180e-e2f2-4ff2-ae84-b1745e1d959c/send_request"), HttpWebRequest)
        postreq.Method = "GET"
        postreq.KeepAlive = True
        postreq.CookieContainer = tempcookies
        postreq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729"
        postreq.ContentType = "application/json"
        Dim postresponse As HttpWebResponse
        postresponse = DirectCast(postreq.GetResponse, HttpWebResponse)
        tempcookies.Add(postresponse.Cookies)

        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
        Dim thepage As String = postreqreader.ReadToEnd
    End Function
End Class
