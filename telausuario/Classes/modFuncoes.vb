Module modFuncoes
    'Conexões - Tabela: banco
    Public StringDeConexao As String
    Public VersaoSistemaProjeto As String = "1.0.3"
    Public VersaoSistemaBanco As String
    Public NomeBanco As String
    Public NomeDoBancoSql As String

    Public CodConfig As String
    Public LoginUsuarioConectado As String
    Public CNPJEmpresa As String = "36916588000175"

    Public CodOrdem As String = 0
    Public CodigoCliente As Integer
    Public CodigoProduto As Integer
    Public CodInterno As Double
    Public NomeProduto As String
    Public indexPedidoAtual As Integer
    Public NomeEmpresa As String = "SISTEMAS NANO"
    Public strCaminhoArquivoZip As String

    Public strLinkDownloadAnexo As String
    Public strCaminhoArquivo As String
    Public mybyte As Byte()

    Public AccessToken As String
    Public RefreshToken As String

    Public strStoneChave As String = "MDBkMDZkNzItYmIxOC00MzgwLWIzNzItYjc0ZTQyZTQyYmVm"
    Public dtStoneToken As New DataTable


    Public StringConexaoFTP As String = "ftp://ftp.nanoapp.com.br/whatsapp/cnpj/"
    Public LoginFTP As String = "nanoapp"
    Public SenhaFTP As String = "Erp@2019era"
End Module
