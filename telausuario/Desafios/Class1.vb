
Imports System.IO.File
Imports System.Net
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Imports System.Drawing
Imports System.Security.Cryptography

Public Class Class1
    Public Shared Function ConsultarTransacao2() As String

        Dim client As New WebClient
        System.Net.ServicePointManager.SecurityProtocol = 3072
        client.Headers("Accept-Encoding") = "gzip"
        'client.Headers("Connection") = "keep-alive"

        client.Headers("Content-Type") = "application/json"
        client.Headers("Accept") = "application/json"
        client.Headers("Api-Access-Key") = "46851542-F368-4458-98C7-29D798BD842A"
        Dim strValorHash As String = "get:/v1/accounts/1214DC9C-4422-9B1A-9A6B-8604FF7E47A2/transactions/5205B50D-B691-7550-BF46-EC5068DFBB23"

        Dim strHash As String = Create_HMACSHA256_Sign("41D3728D-1F9E-4F78-964A-0B7EE3101767", strValorHash)

        client.Headers("Transaction-Hash") = strHash
        ServicePointManager.Expect100Continue = False
        Dim strURL As String = String.Format("https://era-flagship-prd-mp-server.maas.link/v1/accounts/{0}/transactions/{1}", "1214DC9C-4422-9B1A-9A6B-8604FF7E47A2", "5205B50D-B691-7550-BF46-EC5068DFBB23")

        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))

            If jsonResult = "{""data"":{""transactions"":[]}}" Then
                Return jsonResult
            End If
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult.Replace("[", "").Replace("]", ""))

            Return successResult.Item("data")("transactions")("transactionStatus").ToString

            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)

            Return json
        Catch ex As WebException
            Dim strErro As String = ""
            Try
                Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()

                If response.Contains("error") = True Then
                    Dim successResult2 As Linq.JObject = JsonConvert.DeserializeObject(response)
                    Dim strCod As String = successResult2.Item("error")("code").ToString
                    strErro = successResult2.Item("error")("description").ToString

                End If
            Catch ex2 As Exception
            End Try
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return ""
        End Try
    End Function





    Public Shared Function Create_HMACSHA256_Sign(ByVal SecretKey As String, ByVal Message As String) As String
        Dim Encoding = New ASCIIEncoding()
        Dim KeyByte As Byte() = Encoding.GetBytes(SecretKey)
        Dim MessageBytes As Byte() = Encoding.GetBytes(Message)
        Using Hmacsha256 = New HMACSHA256(KeyByte)
            Dim HashBytes As Byte() = Hmacsha256.ComputeHash(MessageBytes)
            Return BitConverter.ToString(HashBytes).Replace("-", "").ToLower()
        End Using
    End Function
End Class
