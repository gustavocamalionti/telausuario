'usar os códigos dentro das dll
Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class clsFuncao


    'conexao com o banco para select no campo
    Public Shared Function CarregarDados(ByVal parQuery As String, ByVal parGrid As DevExpress.XtraGrid.GridControl) As Boolean
        parQuery = "SET DATEFORMAT dmy " & parQuery
        Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario) 'String de Conexão
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        da = New SqlDataAdapter(parQuery, conexao)
        dt = New DataTable

        Try
            da.Fill(dt)
            parGrid.DataSource = dt.DefaultView
            Return True
        Catch ex As Exception
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information
                   )
            Return False
        End Try

    End Function

    Public Shared Function CarregarDataTable(ByVal parQuery As String) As DataTable
        parQuery = "SET DATEFORMAT dmy " & parQuery
        Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario) 'String de Conexão
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        da = New SqlDataAdapter(parQuery, conexao)
        dt = New DataTable

        Try
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information
                   )
        End Try

    End Function

    Public Shared Function Inserir(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Atualizar(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function Deletar(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(My.Settings.dsTelaUsuario)
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            MsgBox("ERRO. O SISTEMA PODE NÃO FUNCIONAR DIREITO.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Public Shared Function BuscaCep(ByVal cep As String) As Hashtable
        Dim ds As DataSet
        Dim _resultado As String
        Dim ht As System.Collections.Hashtable
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    _resultado = ds.Tables(0).Rows(0).Item("resultado").ToString()
                    ht = New Hashtable
                    Select Case _resultado
                        Case "1"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                            ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim())
                            ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                            ht.Add("tipo", 1)

                        Case "2"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)

                        Case Else
                            ht.Add("tipo", 0)
                    End Select
                End If
            End If
            Return ht
        Catch ex As Exception
            Throw New Exception("Falha ao Buscar o Cep" & vbCrLf & ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Shared Function cfgPressNumVirgulas(campo As DevExpress.XtraEditors.TextEdit, z As KeyPressEventArgs)
        If campo.Text.Contains(",") = True Then
            If z.KeyChar = "," Then
                z.Handled = True
                Exit Function
            End If
        End If
        If campo.Text.Contains("-") = True Then
            If z.KeyChar = "-" Then
                z.Handled = True
                Exit Function
            End If

        End If

        If z.KeyChar = "-" And campo.Text.Length <> 0 Then
            z.Handled = True
            Exit Function
        End If

        If Char.IsNumber(z.KeyChar) = False And z.KeyChar <> vbBack And z.KeyChar <> "," And z.KeyChar <> "-" Then
            z.Handled = True
        End If

    End Function
    Public Shared Function cfgLeaveNumVirgulas(campo As DevExpress.XtraEditors.TextEdit)
        If campo.Text = "" Then
            campo.Text = FormatNumber(0, 3)
            Exit Function
        End If

        If campo.Text.Substring(0, 1) = "," Then
            campo.Text = FormatNumber(0, 3)
            Exit Function
        End If

        If campo.Text.Length >= 2 Then
            If campo.Text.Substring(0, 1) = "-" And campo.Text.Substring(1, 1) = "," Then
                campo.Text = FormatNumber(0, 3)
                Exit Function
            End If
        End If
        If IsNumeric(campo.Text.Substring(0, 1)) = True Then
            If campo.Text.Contains("-") Then
                campo.ResetText()
                Exit Function
            End If
            Dim dblAproximacao As Double = campo.Text
            campo.Text = FormatNumber(dblAproximacao, 3)
            Exit Function
        End If
    End Function


    Public Shared Function cfgPressTelefone(campo As DevExpress.XtraEditors.TextEdit, z As KeyPressEventArgs)

        If Char.IsNumber(z.KeyChar) = False Then
            z.Handled = True
        End If

        If z.KeyChar = vbBack Then
            z.Handled = False
            Exit Function

        ElseIf Char.IsNumber(z.KeyChar) = True Then

            campo.Properties.MaxLength = 14
            Select Case campo.Text.Length
                Case 0
                    campo.Text = campo.Text & "("
                    campo.SelectionStart = campo.Text.Length

                Case 3
                    campo.Text = campo.Text & ")"
                    campo.SelectionStart = campo.Text.Length

                Case 9
                    campo.Text = campo.Text & "-"
                    campo.SelectionStart = campo.Text.Length
            End Select

        End If
    End Function

    Public Shared Function cfgContador(campo As DevExpress.XtraEditors.TextEdit, ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim intContLinhas As Integer
        intContLinhas = Grid.RowCount()

        campo.Text = intContLinhas
    End Function

    Public Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream
        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream
        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes
        Return ms.ToArray()

    End Function
End Class


