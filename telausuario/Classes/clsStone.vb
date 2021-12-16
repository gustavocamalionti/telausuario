Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters

Imports telausuario.modFuncoes
Public Class clsStone
    Public Shared Function StoneToken() As String
        dtStoneToken.Clear()
        dtStoneToken.Columns.Add("token")
        dtStoneToken.Columns.Add("data")
        dtStoneToken.Rows.Add(0)

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim client As New WebClient
        client.Headers("Authorization") = "Bearer " + strStoneChave

        ServicePointManager.Expect100Continue = False
        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/token"

        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            dtStoneToken.Rows.Item(0).Item("token") = successResult("token").ToString
            dtStoneToken.Rows.Item(0).Item("data") = My.Computer.Clock.LocalTime

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
                    strErro = ""
                End If
            Catch ex2 As Exception
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson
        End Try
    End Function

    Public Shared Function StoneRegistrarEstabelecimento(ByVal parToken As String, ByVal parLegalName As String, ByVal parBusinessName As String, ByVal parDocumentNumber As String, ByVal parStoneCode As String, ByVal parPartnerStoneId As Integer) As String


        Dim body As New clsStoneJson.clsRegistrarEstabelecimento
        body.is_establishment_to_production = True
        body.legal_name = parLegalName
        body.business_name = parBusinessName
        body.document_number = parDocumentNumber
        body.stone_code = parStoneCode
        body.partner_stone_id = parPartnerStoneId

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/establishment/create-existing-stone"

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

    Public Shared Function StoneConsultarEstabelecimento(ByVal parToken As String) As String

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim client As New WebClient
        client.Headers("Authorization") = "Bearer " + parToken

        ServicePointManager.Expect100Continue = False
        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/token"

        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            dtStoneToken.Rows.Item(0).Item("token") = successResult("token").ToString
            dtStoneToken.Rows.Item(0).Item("data") = My.Computer.Clock.LocalTime

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
                    strErro = ""
                End If
            Catch ex2 As Exception
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return strJson
        End Try
    End Function
End Class
