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
    Public NomeEmpresa As String = "NANO SISTEMAS"



    Public StringConexaoFTP As String = "ftp://207.244.245.160/nanoapp.com.br/public/uploads/arquivos/empresas/cnpj/"
    Public LoginFTP As String = "ftpuser"
    Public SenhaFTP As String = "Nano@@20221!@#"
End Module
