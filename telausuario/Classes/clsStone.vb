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
        dtStoneToken.Reset()
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

    Public Shared Function StoneConsultarTodosEstabelecimento(ByVal parToken As String) As DataTable
        Dim dtListaInformacao As New DataTable
        dtListaInformacao.Columns.Add("establishment_is_active")
        dtListaInformacao.Columns.Add("id")
        dtListaInformacao.Columns.Add("legal_name")
        dtListaInformacao.Columns.Add("business_name")
        dtListaInformacao.Columns.Add("document")
        dtListaInformacao.Columns.Add("stone_code")

        '   "id": "db4362a6-7710-4f52-ab97-4ddcf59bd18b",
        '"is_establishment_to_production": true,
        '"legal_name": "Sistemas Nano",
        '"business_name": "Eder",
        '"is_cnpj": true,
        '"document": "14566555000100",
        '"stone_code": null,
        '"establishment_is_active": false,
        '"mamba_released": true,

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim client As New WebClient
        client.Headers("Authorization") = "Bearer " + parToken
        client.Headers("Accept") = "application/json"

        ServicePointManager.Expect100Continue = False
        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/establishment/get-all/1"
        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            'Dim strStoneIdEstabelecimento As String = successResult.Item("establishments")(0)("id").ToString
            'Dim strStoneIdEstabelecimento1 As String = successResult.Item("establishments")(1)("id").ToString
            Dim teste As String = ""
            Dim strJson As String = successResult.Item("establishments").ToString

            PopulateDtEstabelecimento(successResult, dtListaInformacao)

            Return dtListaInformacao
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
            Return dtListaInformacao
        End Try
    End Function

    Public Shared Function StoneConsultarPos(ByVal parToken As String, ByVal parIdEstabelecimento As String) As DataTable
        Dim dtListaPos As New DataTable
        dtListaPos.Columns.Add("pos_reference_id")
        dtListaPos.Columns.Add("pos_serial_number")
        dtListaPos.Columns.Add("is_linked")


        '   "id": "db4362a6-7710-4f52-ab97-4ddcf59bd18b",
        '"is_establishment_to_production": true,
        '"legal_name": "Sistemas Nano",
        '"business_name": "Eder",
        '"is_cnpj": true,
        '"document": "14566555000100",
        '"stone_code": null,
        '"establishment_is_active": false,
        '"mamba_released": true,

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim client As New WebClient
        client.Headers("Authorization") = "Bearer " + parToken
        client.Headers("Accept") = "application/json"

        ServicePointManager.Expect100Continue = False
        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/pos/get-available-pos/" + parIdEstabelecimento
        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            'Dim strStoneIdReferencePos As String = successResult.Item("available_pos_list")(0)("pos_reference_id").ToString
            Dim teste As String = ""
            PopulateDtPos(successResult, dtListaPos)

            Return dtListaPos
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

        End Try
    End Function

    Public Shared Function StoneConfigurarPos(ByVal parToken As String, ByVal parEstablishment_id As String, ByVal parUse_without_pos_config As Integer, ByVal parActivate_linked_pos_config As Integer, ByVal parActivate_unlinked_and_linked_pos_config As Boolean, ByVal parActivate_single_information_automatic_select As Integer, ByVal parActivate_dispose_transaction_any_pos As Boolean, ByVal parLock_app As Integer, ByVal parView_error_request As Boolean, ByVal parDisplay_view_cancel_pre_transaction As Boolean, ByVal parInstruction_activation_time As Integer) As String
        Dim body As New clsStoneJson.clsConfigurarPos
        body.establishment_id = parEstablishment_id
        body.use_without_pos_config = parUse_without_pos_config
        body.activate_linked_pos_config = parActivate_linked_pos_config
        body.activate_unlinked_and_linked_pos_config = parActivate_unlinked_and_linked_pos_config
        body.activate_single_information_automatic_select = parActivate_single_information_automatic_select
        body.activate_dispose_transaction_any_pos = parActivate_dispose_transaction_any_pos
        body.lock_app = parLock_app
        body.view_error_request = parView_error_request
        body.display_view_cancel_pre_transaction = parDisplay_view_cancel_pre_transaction
        body.instruction_activation_time = parInstruction_activation_time

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/pos/control-configuration"

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

    Public Shared Function StoneAtivarPos(ByVal parToken As String, ByVal parEstablishment_id As String, ByVal parCashier_number As String, ByVal parPdv_number As String, ByVal parPos_link_label As String, ByVal parPos_serial_number_to_link As String) As String
        Dim body As New clsStoneJson.clsAtivarPos
        'body.establishment_id = parEstablishment_id
        body.cashier_number = parCashier_number
        body.pdv_number = parPdv_number
        body.pos_link_label = parPos_link_label
        body.pos_serial_number_to_link = parPos_serial_number_to_link

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/pos/activate-pos-link"

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

    Public Shared Function StoneCriarPreTransacoes(ByVal parToken As String, ByVal parestablishment As String, ByVal parReferenceId As String, ByVal parAmount As Integer, ByVal parInformation_title As String, ByVal parType As Integer) As String
        Dim body As New clsStoneJson.clsCriarPreTransacoes
        body.pos_reference_id = parReferenceId

        body.establishment_id = parestablishment
        body.information_title = parInformation_title
        body.amount = parAmount

        body.payment.type = parType
        'body.payment.installment_type = parInstallment_type
        'body.payment.installment = "null"

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/pre-transaction/create"

        Try
            'myData = "{\""path\"": \""/tesstee/math\"",\"": false}"
            'myData = "{""path"":""/ge/32"",""autorename"":false}"

            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim strStoneIdTransacao As String = successResult.Item("pre_transaction")("pre_transaction_id").ToString

            'Dim filename As String = "C:\test\birthday.mp3"

            'Dim dataBytes() As Byte = IO.File.ReadAllBytes(filename)
            'Dim dataStream = New MemoryStream(dataBytes)
            'request.Content = New StreamContent(dataStream)

            'request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg")

            ' Do the upload
            'Dim response = httpClient.SendAsync(request).Result
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            Return strStoneIdTransacao
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
        End Try

    End Function

    Public Shared Function StoneConsultaPreTransacoes(ByVal parToken As String, ByVal parEstablishment As String, ByVal parDate As String) As DataTable
        Dim dtListaPreTransacoes As New DataTable
        dtListaPreTransacoes.Columns.Add("pre_transaction_id")
        dtListaPreTransacoes.Columns.Add("amount")
        dtListaPreTransacoes.Columns.Add("establishment_id")
        dtListaPreTransacoes.Columns.Add("processed")
        dtListaPreTransacoes.Columns.Add("is_active")
        dtListaPreTransacoes.Columns.Add("pre_transaction_token")
        dtListaPreTransacoes.Columns.Add("pos_reference_id")
        dtListaPreTransacoes.Columns.Add("created_at")

        Dim dtListaTransacoes As New DataTable
        Dim body As New clsStoneJson.clsConsultaPreTransacoes
        body.data = parDate

        body.establishment_id = parEstablishment


        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings).Replace("data", "date")

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/pre-transaction/date"

        Try
            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)

            PopulateDtPreTransacao(successResult, dtListaPreTransacoes)
            Return dtListaPreTransacoes

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
                Return dtListaPreTransacoes
            Catch ex2 As Exception
            End Try
            If ex.Message = "O servidor remoto retornou um erro: (409) Conflito." Then
                Exit Function
            End If
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return dtListaPreTransacoes
        End Try

    End Function

    Public Shared Function StoneListarTransacoes(ByVal parToken As String, ByVal parEstablishment As String, ByVal parPeriod_type As String, ByVal parPeriod As String, ByVal parTransaction_status As String) As DataTable
        Dim dtListarTransacoes As New DataTable
        dtListarTransacoes.Columns.Add("pre_transaction_id")
        dtListarTransacoes.Columns.Add("amount")
        dtListarTransacoes.Columns.Add("establishment_id")
        dtListarTransacoes.Columns.Add("processed")
        dtListarTransacoes.Columns.Add("is_active")
        dtListarTransacoes.Columns.Add("pre_transaction_token")
        dtListarTransacoes.Columns.Add("pos_reference_id")
        dtListarTransacoes.Columns.Add("created_at")

        Dim body As New clsStoneJson.clsListarTransacoes
        body.establishment_id = parEstablishment
        body.period_type = parPeriod_type
        body.period = parPeriod
        body.transaction_status = parTransaction_status

        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings).Replace("data", "date")

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/transactions/list/establishment"


        Try
            Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(myData)
            Dim jsonResult As String = Encoding.UTF8.GetString(client.UploadData(strURL, "POST", jsonBytes))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)

            PopulateDtPreTransacao(successResult, dtListarTransacoes)
            Return dtListarTransacoes

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
                Return dtListarTransacoes
            Catch ex2 As Exception
            End Try
            If ex.Message = "O servidor remoto retornou um erro: (409) Conflito." Then
                Exit Function
            End If
            MsgBox(strErro & vbCrLf & ex.Message, MsgBoxStyle.Information)
            Return dtListarTransacoes
        End Try

    End Function

    Public Shared Function StoneConsultaTransacaoID(ByVal parToken As String, ByVal parIdTransacao As String) As DataTable
        Dim dtListaPos As New DataTable
        dtListaPos.Columns.Add("pos_reference_id")
        dtListaPos.Columns.Add("pos_serial_number")
        dtListaPos.Columns.Add("is_linked")


        '   "id": "db4362a6-7710-4f52-ab97-4ddcf59bd18b",
        '"is_establishment_to_production": true,
        '"legal_name": "Sistemas Nano",
        '"business_name": "Eder",
        '"is_cnpj": true,
        '"document": "14566555000100",
        '"stone_code": null,
        '"establishment_is_active": false,
        '"mamba_released": true,

        System.Net.ServicePointManager.SecurityProtocol = 3072
        Dim client As New WebClient
        client.Headers("Authorization") = "Bearer " + parToken
        client.Headers("Accept") = "application/json"

        ServicePointManager.Expect100Continue = False
        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/transactions/single/pre-transaction/" + parIdTransacao
        Try
            Dim jsonResult As String = Encoding.UTF8.GetString(client.DownloadData(strURL))
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(jsonResult)
            Dim json As String = JsonConvert.SerializeObject(successResult, Formatting.Indented)
            'Dim strStoneIdReferencePos As String = successResult.Item("available_pos_list")(0)("pos_reference_id").ToString
            Dim teste As String = ""
            PopulateDtPos(successResult, dtListaPos)

            Return dtListaPos
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

        End Try
    End Function

    Public Shared Function StoneWebhookPreTransacao(ByVal parToken As String, ByVal parEstablishment_id As String, ByVal parPostback_url As String) As String
        Dim body As New clsStoneJson.clsStoneWebhookPreTransacao
        'body.establishment_id = parEstablishment_id
        body.establishment_id = parEstablishment_id
        body.postback_url = parPostback_url
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
        settings.NullValueHandling = NullValueHandling.Ignore

        Dim myData As String = JsonConvert.SerializeObject(body, settings)

        System.Net.ServicePointManager.SecurityProtocol = 3072

        Dim client As New WebClient
        client.Headers("Accept") = "application/json"
        client.Headers("Content-Type") = "application/json"
        client.Headers("Authorization") = "Bearer " + parToken
        ServicePointManager.Expect100Continue = False

        Dim strURL As String = "https://api.siclospag.com.br/connect/v1/webhook/pre-transaction-status"

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

    Public Shared Function StoneDeletarPreTransacao(ByVal parToken As String, ByVal parPre_transaction_id As String) As Boolean

        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("https://api.siclospag.com.br/connect/v1/pre-transaction/delete/" + parPre_transaction_id), HttpWebRequest)
            request.Headers.Add("Authorization", "Bearer " + parToken)
            request.Accept = "application/json"
            request.Method = "DELETE"
            Dim response As HttpWebResponse
            response = CType(request.GetResponse(), HttpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream()
            Dim responseStr As String = New StreamReader(responseStream).ReadToEnd()
            Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(responseStr)
            Return True
        Catch ex As Exception
            Return False
        End Try
        

        'Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

    End Function

    Public Shared Function StoneDeletarEstabelecimento(ByVal parToken As String, ByVal parEstablishmentId As String) As String

        Dim request As HttpWebRequest = CType(WebRequest.Create("https://api.siclospag.com.br/connect/v1/establishment/deactivate-establishment/" + parEstablishmentId), HttpWebRequest)
        request.Headers.Add("Authorization", "Bearer " + parToken)
        request.Accept = "application/json"
        request.Method = "DELETE"
        Dim response As HttpWebResponse
        response = CType(request.GetResponse(), HttpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream()
        Dim responseStr As String = New StreamReader(responseStream).ReadToEnd()
        Dim successResult As Linq.JObject = JsonConvert.DeserializeObject(responseStr)

        'Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

    End Function



    Public Shared Function PopulateDtEstabelecimento(ByVal jsonResults As Linq.JObject, ByRef target As DataTable, Optional settings As JsonSerializerSettings = Nothing)
        Dim I As Integer
        Dim Z As Integer
        For I = 0 To jsonResults.Item("establishments").Count - 1
            target.Rows.Add(0)
            target.Rows.Item(I).Item("establishment_is_active") = jsonResults.Item("establishments")(I)("establishment_is_active").ToString
            target.Rows.Item(I).Item("id") = jsonResults.Item("establishments")(I)("id").ToString
            target.Rows.Item(I).Item("legal_name") = jsonResults.Item("establishments")(I)("legal_name").ToString
            target.Rows.Item(I).Item("business_name") = jsonResults.Item("establishments")(I)("business_name").ToString
            target.Rows.Item(I).Item("document") = jsonResults.Item("establishments")(I)("document").ToString
            target.Rows.Item(I).Item("stone_code") = jsonResults.Item("establishments")(I)("stone_code").ToString
        Next
    End Function

    Public Shared Function PopulateDtPos(ByVal jsonResults As Linq.JObject, ByRef target As DataTable, Optional settings As JsonSerializerSettings = Nothing)
        Dim I As Integer
        Dim Z As Integer
        For I = 0 To jsonResults.Item("available_pos_list").Count - 1
            target.Rows.Add(0)
            target.Rows.Item(I).Item("pos_reference_id") = jsonResults.Item("available_pos_list")(I)("pos_reference_id").ToString
            target.Rows.Item(I).Item("pos_serial_number") = jsonResults.Item("available_pos_list")(I)("pos_serial_number").ToString
            target.Rows.Item(I).Item("is_linked") = jsonResults.Item("available_pos_list")(I)("is_linked").ToString

        Next
    End Function

    Public Shared Function PopulateDtPreTransacao(ByVal jsonResults As Linq.JObject, ByRef target As DataTable, Optional settings As JsonSerializerSettings = Nothing)
        Dim I As Integer
        Dim Z As Integer
        For I = 0 To jsonResults.Item("pre_transactions").Count - 1
            target.Rows.Add(0)
            target.Rows.Item(I).Item("pre_transaction_id") = jsonResults.Item("pre_transactions")(I)("pre_transaction_id").ToString
            target.Rows.Item(I).Item("amount") = jsonResults.Item("pre_transactions")(I)("amount").ToString
            target.Rows.Item(I).Item("establishment_id") = jsonResults.Item("pre_transactions")(I)("establishment_id").ToString
            target.Rows.Item(I).Item("processed") = jsonResults.Item("pre_transactions")(I)("processed").ToString
            target.Rows.Item(I).Item("is_active") = jsonResults.Item("pre_transactions")(I)("is_active").ToString
            target.Rows.Item(I).Item("pos_reference_id") = jsonResults.Item("pre_transactions")(I)("pos_reference_id").ToString
            target.Rows.Item(I).Item("created_at") = jsonResults.Item("pre_transactions")(I)("created_at").ToString
            target.Rows.Item(I).Item("pre_transaction_token") = jsonResults.Item("pre_transactions")(I)("pre_transaction_token").ToString
        Next
    End Function


End Class
