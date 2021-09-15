Module modFuncoes
    'Conexões - Tabela: banco
    Public StringDeConexao As String
    Public VersaoSistemaProjeto As String = "1.0.0"
    Public VersaoSistemaBanco As String
    Public NomeBanco As String
    Public NomeDoBancoSql As String

    Public dblValorTotalGeralSemDesc As Double
    Public dblValorTotalGeralComDesc As Double
    Public CodOrdem As String = 0
    Public CodigoCliente As Integer
    Public CodigoProduto As Integer
    Public NomeProduto As String
    Public indexPedidoAtual As Integer
    Public bolAlterarProdutoClickGrid As Boolean

End Module
