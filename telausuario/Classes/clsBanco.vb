Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports telausuario.clsFuncao
Public Class clsBanco
    Public Shared Function ExisteBanco() As Boolean
        Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
        conexao.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("SELECT * FROM SYSDATABASES where Name = '" & NomeDoBancoSql & "'", conexao)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Dim bolExiste As Boolean = False
        While dr.Read
            bolExiste = True
            Exit While
        End While
        conexao.Close()
        Return bolExiste
    End Function

    Public Shared Function CriarBanco() As Boolean
        Dim strBanco As String
        strBanco = "CREATE DATABASE " & NomeDoBancoSql & " ON PRIMARY " & _
          "(NAME = " & NomeDoBancoSql & "_Data, " & _
          " FILENAME = 'C:\NANO\BD\" & NomeDoBancoSql & ".mdf', " & _
          " SIZE = 5MB, " & _
          " FILEGROWTH = 1MB) " & _
          " LOG ON " & _
          "(NAME = " & NomeDoBancoSql & "_Log, " & _
          " FILENAME = 'C:\NANO\BD\" & NomeDoBancoSql & ".ldf', " & _
          " SIZE = 1MB," & _
          " FILEGROWTH = 10%) "

        CriarBancoSQL(strBanco)

        strBanco = "CREATE DATABASE dbBackup ON PRIMARY " & _
           "(NAME = dbBackup_Data, " & _
           " FILENAME = 'C:\NANO\BD\dbBackup.mdf', " & _
           " SIZE = 5MB, " & _
           " FILEGROWTH = 1MB) " & _
           " LOG ON " & _
           "(NAME = dbBackup_Log, " & _
           " FILENAME = 'C:\NANO\BD\dbBackup.ldf', " & _
           " SIZE = 1MB, " & _
           " FILEGROWTH = 10%) "

        CriarBancoSQL(strBanco)

    End Function

    Public Shared Function CriarBancoSQL(ByVal parQuery As String) As Boolean
        Try
            parQuery = "SET DATEFORMAT dmy " & parQuery
            Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
            Dim cmd As SqlCommand
            conexao.Open()
            cmd = New SqlCommand(parQuery, conexao)
            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.Close()
            Return True
        Catch
            Return False
        End Try

    End Function

    Public Shared Function GerenciarTabela() As Boolean
        If VersaoSistemaBanco = "1.0.0" Then
            If ExisteTabela("Config") = False Then
                ExecutaSQL("CREATE TABLE Config (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey PRIMARY KEY," & _
                "Empresa varchar (100)," & _
                "CNPJ varchar (20)," & _
                "VersaoNano varchar(5)," & _
                "Telefone varchar(30)," & _
                "Endereco varchar(100));")

                ExecutaSQL("Insert Into Config (VersaoNano, Empresa) Values('1.0.0', '')")

            End If

            If ExisteTabela("Cliente") = False Then
                ExecutaSQL("CREATE TABLE Cliente (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey2 PRIMARY KEY," & _
                "Nome varchar (150)," & _
                "RGIE varchar (15)," & _
                "CPF varchar(25)," & _
                "Endereco varchar(150)," & _
                "Numero varchar(10)," & _
                "Complemento varchar(75)," & _
                "Bairro varchar(100)," & _
                "Cep varchar(20)," & _
                "Cidade varchar(80)," & _
                "Estado varchar(40)," & _
                "Telefone varchar (18)," & _
                "Fax varchar (18)," & _
                "Celular varchar (18)," & _
                "Email varchar(50)," & _
                "Data SmallDateTime," & _
                "Fantasia varchar(80)," & _
                "Observacao nvarchar(MAX)," & _
                "Inadimplente Bit," & _
                "Status varchar(1)," & _
                "Nascimento SmallDateTime," & _
                "Sexo varchar(1)," & _
                "Limite varchar (18)," & _
                "Empresa varchar(100)," & _
                "TelEmpresa varchar (18)," & _
                "Salario varchar (18)," & _
                "Credito varchar (18)," & _
                "Marcas varchar (200)," & _
                "CodConfig Integer," & _
                "Pessoa1 varchar(100)," & _
                "Pessoa2 varchar(100)," & _
                "RG1 varchar(15)," & _
                "RG2 varchar(15)," & _
                "Contato varchar(30)," & _
                "Inativo bit);")

                ExecutaSQL("Insert into Cliente (Nome, CPF, Inadimplente, Inativo) values('CONSUMIDOR','000.000.000-00','False','False')")
            End If

            If ExisteTabela("Produtos") = False Then
                ExecutaSQL("CREATE TABLE Produtos (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey3 PRIMARY KEY," & _
                    "[CodFor] [varchar](80) ," & _
                    "[CodBarra] [varchar](80) ," & _
                    "[Produto] [varchar](150)  ," & _
                    "[Setor] [varchar](30) ," & _
                    "[Grupo] [varchar](30) ," & _
                    "[Fornecedor] [varchar](50) ," & _
                    "[Familia] [varchar](30) ," & _
                    "[UnidMed] [varchar](2) ," & _
                    "[Tipo] [varchar](30) ," & _
                    "[Locacao] [varchar](150) ," & _
                    "[Comissao] [varchar](150) ," & _
                    "[Custo] [varchar](150)  ," & _
                    "[Venda] [varchar](150)  ," & _
                    "[Desconto] [varchar](150) ," & _
                    "[Observacao] [text] ," & _
                    "[AlterarPreco] [bit] ," & _
                    "[Duplicar] [bit] ," & _
                    "[TribPadrao] [bit] ," & _
                    "[Inativo] [bit] ," & _
                    "[CodigoInterno] [varchar](80));")
            End If

            If ExisteTabela("Usuario") = False Then
                ExecutaSQL("CREATE TABLE Usuario (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey4 PRIMARY KEY," & _
                    "Login varchar (30)," & _
                    "Nome varchar(80)," & _
                    "Principal varchar(250)," & _
                    "Relatorios varchar(250)," & _
                    "Skin varchar(40)," & _
                    "PlanoFundo image," & _
                    "FundoPadrao bit," & _
                    "Exibicao varchar(1)," & _
                    "CodConfig varchar(10)," & _
                    "Inativo bit," & _
                    "Nivel varchar(15)," & _
                    "Senha varchar (25));")

                ExecutaSQL("Insert into Usuario (Login, Senha, Nome, nivel, Inativo) values ('ADM','spfc', 'ADM', 'MASTER', 0); ")

            End If

            If ExisteTabela("Qtde") = False Then
                ExecutaSQL("CREATE TABLE Qtde (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey5 PRIMARY KEY," & _
                "[CodProd] [varchar](15) ," & _
                "[Tamanho] [varchar](15) ," & _
                "[QtdeMinima] [numeric](15, 3) ," & _
                "[qtdeMaxima] [numeric](15, 3) ," & _
                "[Qtd] [numeric](15, 3) ," & _
                "[Lote] [varchar](15) ," & _
                "[ValorCusto] [varchar](50) ," & _
                "[EmFalta] [varchar](1) ," & _
                "[Acabou] [bit] ," & _
                "[CodConfig] [varchar](15) ," & _
                "[DataFim] [smalldatetime] ," & _
                "[Cor] [varchar](15));")
            End If

            If ExisteTabela("Pedido") = False Then
                ExecutaSQL("CREATE TABLE Pedido (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey6 PRIMARY KEY," & _
                "[CodProd] [varchar](30)," & _
                "[Qtd] [numeric](15, 3));")
            End If

            If ExisteTabela("EntradaNf") = False Then
                ExecutaSQL("CREATE TABLE EntradaNf (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey7 PRIMARY KEY," & _
                "[CodProd] [varchar](30)," & _
                "[Qtd] [numeric](15, 3));")
            End If

            If ExisteTabela("AjusteQtde") = False Then
                ExecutaSQL("CREATE TABLE AjusteQtde (" & _
                "Codigo INT IDENTITY CONSTRAINT primarykey8 PRIMARY KEY," & _
                "[CodProd] [varchar](30)," & _
                "[Qtd] [numeric](15, 3)," & _
                "[Data] [smalldatetime]," & _
                "[Tabela] [varchar](20)," & _
                "[CodConfig] [varchar](30)," & _
                "[CodUser] [varchar](30)," & _
                "[Tamanho] [varchar](30)," & _
                "[Cor] [varchar](30)," & _
                "[UserName] [varchar](30));")

            End If

            If ExisteTabela("TotalConsig") = False Then
                ExecutaSQL("CREATE TABLE TotalConsig (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey9 PRIMARY KEY," & _
                    "[CodOrdens] [int] ," & _
                    "[Data] [smalldatetime] ," & _
                    "[CodCli] [int] ," & _
                    "[Total] [varchar](150) ," & _
                    "[Descricao] [nvarchar](max) ," & _
                    "[Status] [varchar](10) ," & _
                    "[Custo] [varchar](150) ," & _
                    "[Desconto]  [varchar](150) ," & _
                    "[Entrega] [varchar](18) ," & _
                    "[CodFunc] [int] ," & _
                    "[CodConfig] [int] ," & _
                    "[DataVenda] [smalldatetime] ," & _
                    "[CodAnimal] [int] ," & _
                    "[Acrescimo] [varchar](150) ," & _
                    "[DataRetirada] [smalldatetime] ," & _
                    "[DataEntrega] [smalldatetime] ," & _
                    "[Comanda] [varchar](10) ," & _
                    "[StatusPedido] [varchar](80) ," & _
                    "[Placa] [varchar](8) ," & _
                    "[Modelo] [varchar](50) ," & _
                    "[Cor] [varchar](30) ," & _
                    "[Ano] [varchar](20) ," & _
                    "[Motor] [varchar](30) ," & _
                    "[NivelCombustivel] [varchar](20) ," & _
                    "[KMSaida] [varchar](8) ," & _
                    "[KMEntrada] [varchar](8) ," & _
                    "[Seguro] [varchar](80) ," & _
                    "[Sinistro] [varchar](15) ," & _
                    "[UsuarioAlt] [varchar](150) ," & _
                    "[Assinatura] [image] ," & _
                    "[CheckList] [int] ," & _
                    "[ValorFrete] [varchar](150) ," & _
                    "[CodNFe] [int] ," & _
                    "[AuxiliarPed] [varchar](100) ," & _
                    "[Operador] [varchar](80) ," & _
                    "[CodNFSe] [int] ," & _
                    "[TipoDesc] [varchar](1) ," & _
                    "[CodVenda] [int] ," & _
                    "[EnderecoPedido] [varchar](250));")
            End If

            If ExisteTabela("ItensConsig") = False Then
                ExecutaSQL("CREATE TABLE ItensConsig (" & _
                    "CodPedAut INT IDENTITY CONSTRAINT primarykey10 PRIMARY KEY," & _
                    "[CodOrdens] [int]," & _
                    "[Qtd] [numeric](15, 3)," & _
                    "[CodigoProduto] [varchar](10)," & _
                    "[Produto] [varchar](200)," & _
                    "[ValorUnitario] [varchar](150)," & _
                    "[ValorTotal] [varchar](150)," & _
                    "[CodigoInterno] [varchar](38)," & _
                    "[Custo] [varchar](150)," & _
                    "[DescComDistribuicao] [varchar](150)," & _
                    "[DescSemDistribuicao] [varchar](150)," & _
                    "[UM] [varchar](15)," & _
                    "[Tamanho] [varchar](30)," & _
                    "[CodConfig] [int]," & _
                    "[UniSemDesc] [varchar](150)," & _
                    "[Promocao] [bit]," & _
                    "[Desconto] [varchar](150)," & _
                    "[Retorno] [varchar](10)," & _
                    "[MedidaA] [numeric](15, 3)," & _
                    "[MedidaB] [numeric](15, 3)," & _
                    "[QtdMedida] [numeric](15, 3)," & _
                    "[DataAdd] [smalldatetime]," & _
                    "[CodigoFuncionario] [varchar](10)," & _
                    "[Autorizado] [bit]," & _
                    "[CampoPedido] [varchar](max)," & _
                    "[TabelaPreco] [varchar](80)," & _
                    "[AuxiliarPed] [varchar](100)," & _
                    "[Cor] [varchar](30)," & _
                    "[Tipo] [varchar](30));")
            End If

            If ExisteTabela("Ordens") = False Then
                ExecutaSQL("CREATE TABLE Ordens (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey11 PRIMARY KEY," & _
                    "[Cod] [int]," & _
                    "[Tabela] [varchar](25)," & _
                    "[CodConfig] [int]," & _
                    "[CodEmitente] [int]," & _
                    "[StatusEmitente] [varchar](15)," & _
                    "[Auxiliar] [varchar](100));")
            End If

            If ExisteTabela("Bloqueios") = False Then
                ExecutaSQL("CREATE TABLE Bloqueios (" & _
                    "Codigo INT IDENTITY CONSTRAINT primarykey12 PRIMARY KEY," & _
                    "Principal varchar(60)," & _
                    "Relatórios varchar (60));")
            End If

        End If

        Dim intVersao As Integer = VersaoSistemaBanco.Replace(".", "")
        If intVersao <= 100 Then
            Atualizar("Update Config set versaoNano = '1.0.1';")
        End If
    End Function

    Public Shared Function ExisteTabela(ByVal parTabela As String) As Boolean
        Dim tabela As New DataTable

        Dim criterioSQL As String

        criterioSQL = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_TYPE"
        Try

            Dim da As New SqlDataAdapter(criterioSQL, StringDeConexao)

            da.Fill(tabela)

            For Each dr As DataRow In tabela.Rows

                If dr("TABLE_NAME").ToString = parTabela Then

                    Return True

                End If

            Next

            Return False

        Catch ex As Exception

            MessageBox.Show("ERRO " & ex.Message, "Verifica tabela")

            Return False

        End Try
    End Function
    Public Shared Function ExecutaSQL(ByVal parQuery As String) As Boolean
        Try
            Dim conexao As New SqlConnection(StringDeConexao)
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
End Class