Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Public Class clsWebHook

    Public Shared Function WHPost(parStatusClick As Boolean) As String

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

        dadosConta.click = parStatusClick

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(dadosConta, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        'client.Headers("Content-Type") = "application/octet-stream"
        client.Headers("Content-Type") = "application/json"
        client.Headers("curl") = "4ae6zsh56luvva4eel2bzzyxosv9e7thdn8dy0qjzqwoge5njo"




        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://events.hookdeck.com/e/src_9sHAtslS1HXXjxYez4tgmG5O"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim resultado As String = ""

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

    Public Shared Function WHGetListEvents() As String
        'A data enviada no link, é uma data fixa ou a data atual sempre?
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://api.hookdeck.com/2021-08-01/events?limit=10"), HttpWebRequest)
        Dim user As String = "4ae6zsh56luvva4eel2bzzyxosv9e7thdn8dy0qjzqwoge5njo"
        Dim password As String = ""
        Dim encoded As String = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(user + ":" + password))
        request.Headers.Add("Authorization", "Basic " + encoded)
        request.ContentType = "application/json"
        request.Method = "GET"
        request.Headers.Add("limit", "50")
        Dim response As HttpWebResponse
        response = CType(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim responseStr As String = New StreamReader(responseStream).ReadToEnd()
        Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(responseStr)

        'Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
        'Dim thepage As String = postreqreader.ReadToEnd

    End Function

    Public Shared Function WHGetEspecificEvent(idEvento As String) As String
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://api.hookdeck.com/2021-08-01/events/" & idEvento & ""), HttpWebRequest)
        Dim user As String = "4ae6zsh56luvva4eel2bzzyxosv9e7thdn8dy0qjzqwoge5njo"
        Dim password As String = ""
        Dim encoded As String = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(user + ":" + password))
        request.Headers.Add("Authorization", "Basic " + encoded)
        request.ContentType = "application/json"
        request.Method = "GET"
        request.ContentLength = 0
        Dim response As HttpWebResponse
        response = CType(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim responseStr As String = New StreamReader(responseStream).ReadToEnd()
        Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(responseStr)

        'Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
        'Dim thepage As String = postreqreader.ReadToEnd

    End Function

End Class
