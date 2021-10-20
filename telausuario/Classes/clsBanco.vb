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
                    "Relatorios varchar (60));")
            End If

        End If

        Dim intVersao As Integer = VersaoSistemaBanco.Replace(".", "")
        If intVersao <= 100 Then
            Atualizar("Update Config set versaoNano = '1.0.1';")

            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Cadastrar Cliente', '');") '0
            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Cadastrar Produto', '');") '1
            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Alterar Cliente', '');") '2
            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Alterar Produto', '');") '3
            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Cadastrar Usuario', '');") '4
            ExecutaSQL("insert into Bloqueios (Principal, Relatorios) values ('Bloquear Usuario', '')") '5

        End If

        If intVersao <= 101 Then
            Atualizar("Update config set versaoNano = '1.0.2';")

            ExecutaSQL("Alter Table Cliente ADD Cancelamento bit;")
            ExecutaSQL("Alter Table Cliente ADD MotivoCancelamento varchar(75);")
            ExecutaSQL("Alter Table Cliente ADD DetalhesCancelamento nvarchar(max);")
            ExecutaSQL("Alter Table Cliente ADD DataCancelamento varchar(35);")
        End If


        If intVersao <= 102 Then
            Atualizar("Update config set VersaoNano = '1.0.3';")

            If ExisteTabela("Pais") = False Then
                ExecutaSQL("CREATE TABLE Pais (" & _
                        "Codigo INT IDENTITY CONSTRAINT primarykey13 PRIMARY KEY," & _
                        "[Pais] [varchar](60)," & _
                        "[CodIBGE] [varchar](15));")
            End If

            ExecutaSQL("Alter table Cliente add CodPais varchar(4);")
            ExecutaSQL("Delete Pais;")
            ExecutaSQL("Alter table Pais add CodDDI [varchar](15)")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('AFEGANISTAO',132,93);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('AFRICA DO SUL',7560,27);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ALBANIA, REPUBLICA DA',175,355);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ALEMANHA',230,49);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ANDORRA',370,376);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ANGOLA',400,244);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ANGUILLA',418,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ANTIGUA E BARBUDA',434,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ANTILHAS HOLANDESAS',477,599);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ARABIA SAUDITA',531,966);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ARGELIA',590,213);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ARGENTINA',639,54);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ARMENIA, REPUBLICA DA',647,374);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ARUBA',655,297);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('AUSTRALIA',698,61);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('AUSTRIA',728,43);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('AZERBAIJAO, REPUBLICA DO',736,994);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BAHAMAS, ILHAS',779,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BAHREIN, ILHAS',809,973);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BANGLADESH',817,880);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BARBADOS',833,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BELARUS, REPUBLICA DA',850,375);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BELGICA',876,32);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BELIZE',884,501);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BENIN',2291,229);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BERMUDAS',906,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BOLIVIA',973,591);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BOSNIA-HERZEGOVINA (REPUBLICA DA)',981,387);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BOTSUANA',1015,267);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BRASIL',1058,55);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BRUNEI',1082,673);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BULGARIA, REPUBLICA DA',1112,359);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BURKINA FASO',310,226);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BURUNDI',1155,257);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('BUTAO',1198,975);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CABO VERDE, REPUBLICA DE',1279,238);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CAMAROES',1457,237);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CAMBOJA',1414,855);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CANADA',1490,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CANARIAS, ILHAS',1511,34);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CATAR',1546,974);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CAYMAN, ILHAS',1376,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CAZAQUISTAO, REPUBLICA DO',1538,7);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CHADE',7889,237);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CHILE',1589,56);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CHINA, REPUBLICA POPULAR',1600,86);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CHIPRE',1635,357);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CHRISTMAS,ILHA (NAVIDAD)',5118,61);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CINGAPURA',7412,65);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COCOS(KEELING),ILHAS',1651,61);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COLOMBIA',1694,57);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COMORES, ILHAS',1732,269);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CONGO',1775,243);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CONGO, REPUBLICA DEMOCRATICA DO',8885,243);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COOK, ILHAS',1830,682);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COREIA, REP.POP.DEMOCRATICA',1872,82);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COREIA, REPUBLICA DA',1902,82);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COSTA DO MARFIM',1937,225);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COSTA RICA',1961,506);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('COVEITE',1988,965);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CROACIA (REPUBLICA DA)',1953,385);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('CUBA',1996,53);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('DINAMARCA',2321,45);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('DJIBUTI',7838,253);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('DOMINICA,ILHA',2356,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('EGITO',2402,20);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('EL SALVADOR',6874,503);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('EMIRADOS ARABES UNIDOS',2445,971);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('EQUADOR',2399,593);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ERITREIA',2437,291);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ESLOVACA, REPUBLICA',2470,421);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ESLOVENIA, REPUBLICA DA',2461,386);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ESPANHA',2453,34);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ESTADOS UNIDOS',2496,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ESTONIA, REPUBLICA DA',2518,372);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ETIOPIA',2534,251);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FALKLAND (ILHAS MALVINAS)',2550,500);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FEROE, ILHAS',2593,298);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FIJI',8702,679);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FILIPINAS',2674,63);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FINLANDIA',2712,358);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FORMOSA (TAIWAN)',1619,886);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('FRANCA',2755,33);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GABAO',2810,241);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GAMBIA',2852,220);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GANA',2895,233);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GEORGIA, REPUBLICA DA',2917,995);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GIBRALTAR',2933,350);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GRANADA',2976,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GRECIA',3018,30);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GROENLANDIA',3050,299);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUADALUPE',3093,590);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUAM',3131,671);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUATEMALA',3174,502);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUERNSEY, ILHA DO CANAL (INCLUI ALDERNEY E SARK)',1504,44);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUIANA',3379,592);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUIANA FRANCESA',3255,594);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUINE',3298,224);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUINE-BISSAU',3344,245);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('GUINE-EQUATORIAL',3310,240);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('HAITI',3417,509);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('HONDURAS',3450,504);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('HONG KONG',3514,852);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('HUNGRIA, REPUBLICA DA',3557,36);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('IEMEN',3573,967);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('INDIA',3611,91);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('INDONESIA',3654,62);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('IRA, REPUBLICA ISLAMICA DO',3727,98);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('IRAQUE',3697,964);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('IRLANDA',3751,353);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ISLANDIA',3794,354);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ISRAEL',3832,972);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ITALIA',3867,39);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('JAMAICA',3913,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('JAPAO',3999,81);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('JERSEY, ILHA DO CANAL',1508,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('JOHNSTON, ILHAS',3964,NULL);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('JORDANIA',4030,962);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('KIRIBATI',4111,686);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LAOS, REP.POP.DEMOCR.DO',4200,856);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LEBUAN,ILHAS',4235,NULL);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LESOTO',4260,266);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LETONIA, REPUBLICA DA',4278,371);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LIBANO',4316,961);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LIBERIA',4340,231);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LIBIA',4383,218);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LIECHTENSTEIN',4405,423);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LITUANIA, REPUBLICA DA',4421,370);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('LUXEMBURGO',4456,352);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MACAU',4472,853);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MACEDONIA, ANT.REP.IUGOSLAVA',4499,389);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MADAGASCAR',4502,261);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MADEIRA, ILHA DA',4525,NULL);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MALASIA',4553,60);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MALAVI',4588,265);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MALDIVAS',4618,960);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MALI',4642,223);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MALTA',4677,356);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MAN, ILHA DE',3595,44);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MARIANAS DO NORTE',4723,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MARROCOS',4740,212);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MARSHALL,ILHAS',4766,692);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MARTINICA',4774,596);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MAURICIO',4855,230);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MAURITANIA',4880,222);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MAYOTTE (ILHAS FRANCESAS)',4885,262);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MEXICO',4936,52);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MIANMAR (BIRMANIA)',930,95);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MICRONESIA',4995,691);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MIDWAY, ILHAS',4901,838);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MOCAMBIQUE',5053,258);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MOLDAVIA, REPUBLICA DA',4944,373);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MONACO',4952,377);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MONGOLIA',4979,976);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MONTENEGRO',4985,382);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('MONTSERRAT,ILHAS',5010,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NAMIBIA',5070,264);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NAURU',5088,674);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NEPAL',5177,977);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NICARAGUA',5215,505);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NIGER',5258,227);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NIGERIA',5282,234);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NIUE,ILHA',5312,683);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NORFOLK,ILHA',5355,672);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NORUEGA',5380,47);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NOVA CALEDONIA',5428,687);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('NOVA ZELANDIA',5487,64);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('OMA',5568,968);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PACIFICO,ILHAS DO (POSSESSAO DOS EUA)',5665,NULL);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PAISES BAIXOS (HOLANDA)',5738,31);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PALAU',5754,680);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PALESTINA',5780,970);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PANAMA',5800,507);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PAPUA NOVA GUINE',5452,675);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PAQUISTAO',5762,92);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PARAGUAI',5860,595);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PERU',5894,51);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PITCAIRN,ILHA',5932,64);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('POLINESIA FRANCESA',5991,689);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('POLONIA, REPUBLICA DA',6033,48);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PORTO RICO',6114,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('PORTUGAL',6076,351);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('QUENIA',6238,254);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('QUIRGUIZ, REPUBLICA',6254,996);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('REINO UNIDO',6289,44);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('REPUBLICA CENTRO-AFRICANA',6408,236);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('REPUBLICA DOMINICANA',6475,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('REUNIAO, ILHA',6602,262);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ROMENIA',6700,40);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('RUANDA',6750,250);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('RUSSIA, FEDERACAO DA',6769,7);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAARA OCIDENTAL',6858,212);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAINT KITTS E NEVIS',6781,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SALOMAO, ILHAS',6777,677);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAMOA',6904,685);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAMOA AMERICANA',6912,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAN MARINO',6971,378);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SANTA HELENA',7102,247);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SANTA LUCIA',7153,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAO CRISTOVAO E NEVES,ILHAS',6955,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAO PEDRO E MIQUELON',7005,508);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAO TOME E PRINCIPE, ILHAS',7200,239);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SAO VICENTE E GRANADINAS',7056,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SENEGAL',7285,221);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SERRA LEOA',7358,232);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SERVIA',7370,381);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SEYCHELLES',7315,248);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SIRIA, REPUBLICA ARABE DA',7447,963);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SOMALIA',7480,252);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SRI LANKA',7501,94);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SUAZILANDIA',7544,268);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SUDAO',7595,249);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SUDAO DO SUL',7600,211);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SUECIA',7641,46);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SUICA',7676,41);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('SURINAME',7706,597);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TADJIQUISTAO, REPUBLICA DO',7722,992);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TAILANDIA',7765,66);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TANZANIA, REP.UNIDA DA',7803,255);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TCHECA, REPUBLICA',7919,420);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TERRITORIO BRIT.OC.INDICO',7820,246);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TIMOR LESTE',7951,670);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TOGO',8001,228);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TONGA',8109,676);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TOQUELAU,ILHAS',8052,690);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TRINIDAD E TOBAGO',8150,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TUNISIA',8206,216);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TURCAS E CAICOS,ILHAS',8230,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TURCOMENISTAO, REPUBLICA DO',8249,993);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TURQUIA',8273,90);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('TUVALU',8281,688);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('UCRANIA',8311,380);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('UGANDA',8338,256);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('URUGUAI',8451,598);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('UZBEQUISTAO, REPUBLICA DO',8478,998);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VANUATU',5517,678);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VATICANO, EST.DA CIDADE DO',8486,379);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VENEZUELA',8508,58);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VIETNA',8583,84);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VIRGENS,ILHAS (BRITANICAS)',8630,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('VIRGENS,ILHAS (E.U.A.)',8664,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('WAKE, ILHA',8737,1);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ZAMBIA',8907,260);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ZIMBABUE',6653,263);")
            ExecutaSQL("insert into Pais (Pais,CodIBGE,CodDDI) values('ZONA DO CANAL DO PANAMA',8958,NULL);")
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