Namespace ClassesJson
    Public Class clsExcluirProduto
        Public Property status As String
        Public Property deleted As String
    End Class
    Public Class clsItens
        Public Property title As String
        Public Property category_id As String
        Public Property price As Integer
        Public Property currency_id As String
        Public Property available_quantity As Integer
        Public Property buying_mode As String
        Public Property condition As String
        Public Property listing_type_id As String
        Public Property description As New clsDescription
        Public Property video_id As String
        Public Property sale_terms As IEnumerable(Of clsSale_terms)
        Public Property pictures As IEnumerable(Of clsPictures)
        Public Property attributes As IEnumerable(Of clsAttributes)
    End Class

    Public Class clsDescription
        Public Property plain_text As String
    End Class
    Public Class clsSale_terms
        Public Property id As String
        Public Property value_name As String
    End Class
    Public Class clsPictures
        Public Property source As String
    End Class
    Public Class clsAttributes
        Public Property id As String
        Public Property value_name As String
    End Class

    Public Class clsPais
        Private strsite_id As String
        Public Property site_id() As String
            Get
                Return strsite_id
            End Get
            Set(ByVal value As String)
                strsite_id = value
            End Set
        End Property

    End Class
    Public Class clsAccessToken
        'Private strGrantType As String
        ' Public Property grant_type() As String
        '     Get
        '   Return strGrantType
        ' End Get
        ' Set(ByVal value As String)
        '      strGrantType = value
        '  End Set
        'End Property

        Private strClient_Id As String
        Public Property client_id() As String
            Get
                Return strClient_Id
            End Get
            Set(ByVal value As String)
                strClient_Id = value
            End Set
        End Property

        Private strScope As String
        Public Property scope() As String
            Get
                Return strscope
            End Get
            Set(ByVal value As String)
                strScope = value
            End Set
        End Property

        Private strClient_Secret As String
        Public Property client_secret() As String
            Get
                Return strClient_Secret
            End Get
            Set(ByVal value As String)
                strClient_Secret = value
            End Set
        End Property

        Private strResponse_Type As String
        Public Property response_type() As String
            Get
                Return strResponse_Type
            End Get
            Set(ByVal value As String)
                strResponse_Type = value
            End Set
        End Property

        'Private strCode As String
        'Public Property code() As String
        'Get
        'Return strCode
        'End Get
        'Set(ByVal value As String)
        'strCode = value
        'End Set
        'End Property
        Private strRedirect_Uri As String
        Public Property redirect_uri() As String
            Get
                Return strRedirect_Uri
            End Get
            Set(ByVal value As String)
                strRedirect_Uri = value
            End Set
        End Property
    End Class
    Public Class clsEmpresa
        Private strId As String
        Public Property id() As String
            Get
                Return strId
            End Get
            Set(ByVal value As String)
                strId = value
            End Set
        End Property

        Private strCnpj As String
        Public Property cnpj() As String
            Get
                Return strCnpj
            End Get
            Set(ByVal value As String)
                strCnpj = value
            End Set
        End Property

        Private strInscricaoMunicipal As String
        Public Property inscricaoMunicipal() As String
            Get
                Return strInscricaoMunicipal
            End Get
            Set(ByVal value As String)
                strInscricaoMunicipal = value
            End Set
        End Property

        Private strInscricaoEstadual As String
        Public Property inscricaoEstadual() As String
            Get
                Return strInscricaoEstadual
            End Get
            Set(ByVal value As String)
                strInscricaoEstadual = value
            End Set
        End Property

        Private strRazaoSocial As String
        Public Property razaoSocial() As String
            Get
                Return strRazaoSocial
            End Get
            Set(ByVal value As String)
                strRazaoSocial = value
            End Set
        End Property

        Private strNomeFantasia As String
        Public Property nomeFantasia() As String
            Get
                Return strNomeFantasia
            End Get
            Set(ByVal value As String)
                strNomeFantasia = value
            End Set
        End Property

        Private bolOptanteSimplesNacional As Boolean
        Public Property optanteSimplesNacional() As Boolean
            Get
                Return bolOptanteSimplesNacional
            End Get
            Set(ByVal value As Boolean)
                bolOptanteSimplesNacional = value
            End Set
        End Property

        Private strEmail As String
        Public Property email() As String
            Get
                Return strEmail
            End Get
            Set(ByVal value As String)
                strEmail = value
            End Set
        End Property

        Private bolEnviarEmailCliente As Boolean
        Public Property enviarEmailCliente() As Boolean
            Get
                Return bolEnviarEmailCliente
            End Get
            Set(ByVal value As Boolean)
                bolEnviarEmailCliente = value
            End Set
        End Property

        Private strTelefoneComercial As String
        Public Property telefoneComercial() As String
            Get
                Return strTelefoneComercial
            End Get
            Set(ByVal value As String)
                strTelefoneComercial = value
            End Set
        End Property

        Private bolIncentivadorCultural As Boolean
        Public Property incentivadorCultural() As Boolean
            Get
                Return bolIncentivadorCultural
            End Get
            Set(ByVal value As Boolean)
                bolIncentivadorCultural = value
            End Set
        End Property


        Private clsEndereco As New ClassesJson.clsEnderecoEmpresa
        Public Property endereco() As ClassesJson.clsEnderecoEmpresa
            Get
                Return clsEndereco
            End Get
            Set(ByVal value As ClassesJson.clsEnderecoEmpresa)
                clsEndereco = value
            End Set
        End Property


        Private strRegimeEspecialTributacao As String
        Public Property regimeEspecialTributacao() As String
            Get
                Return strRegimeEspecialTributacao
            End Get
            Set(ByVal value As String)
                strRegimeEspecialTributacao = value
            End Set
        End Property

        Private strCodigoServicoMunicipal As String
        Public Property codigoServicoMunicipal() As String
            Get
                Return strCodigoServicoMunicipal
            End Get
            Set(ByVal value As String)
                strCodigoServicoMunicipal = value
            End Set
        End Property

        Private strItemListaServicoLC116 As String
        Public Property itemListaServicoLC116() As String
            Get
                Return strItemListaServicoLC116
            End Get
            Set(ByVal value As String)
                strItemListaServicoLC116 = value
            End Set
        End Property

        Private strCnae As String
        Public Property cnae() As String
            Get
                Return strCnae
            End Get
            Set(ByVal value As String)
                strCnae = value
            End Set
        End Property

        Private strAliquotaIss As String
        Public Property aliquotaIss() As String
            Get
                Return strAliquotaIss
            End Get
            Set(ByVal value As String)
                strAliquotaIss = value
            End Set
        End Property

        Private strDescricaoServico As String
        Public Property descricaoServico() As String
            Get
                Return strDescricaoServico
            End Get
            Set(ByVal value As String)
                strDescricaoServico = value
            End Set
        End Property

        Private clsNfseHomologacao As New ClassesJson.clsNFSeHomologacaoEmpresa
        Public Property configuracoesNFSeHomologacao() As ClassesJson.clsNFSeHomologacaoEmpresa
            Get
                Return clsNfseHomologacao
            End Get
            Set(ByVal value As ClassesJson.clsNFSeHomologacaoEmpresa)
                clsNfseHomologacao = value
            End Set
        End Property

        Private clsNfseProducao As New ClassesJson.clsNFSeProducaoEmpresa
        Public Property configuracoesNFSeProducao() As ClassesJson.clsNFSeProducaoEmpresa
            Get
                Return clsNfseProducao
            End Get
            Set(ByVal value As ClassesJson.clsNFSeProducaoEmpresa)
                clsNfseProducao = value
            End Set
        End Property
    End Class

    Public Class clsEnderecoEmpresa

        Private intCodigoIbgeUf As Integer
        Public Property codigoIbgeUf() As Integer
            Get
                Return intCodigoIbgeUf
            End Get
            Set(ByVal value As Integer)
                intCodigoIbgeUf = value
            End Set
        End Property

        Private intCodigoIbgeCidade As Integer
        Public Property codigoIbgeCidade() As Integer
            Get
                Return intCodigoIbgeCidade
            End Get
            Set(ByVal value As Integer)
                intCodigoIbgeCidade = value
            End Set
        End Property

        Private strPais As String
        Public Property pais() As String
            Get
                Return strPais
            End Get
            Set(ByVal value As String)
                strPais = value
            End Set
        End Property

        Private strUf As String
        Public Property uf() As String
            Get
                Return strUf
            End Get
            Set(ByVal value As String)
                strUf = value
            End Set
        End Property

        Private strCidade As String
        Public Property cidade() As String
            Get
                Return strCidade
            End Get
            Set(ByVal value As String)
                strCidade = value
            End Set
        End Property

        Private strLogradouro As String
        Public Property logradouro() As String
            Get
                Return strLogradouro
            End Get
            Set(ByVal value As String)
                strLogradouro = value
            End Set
        End Property

        Private strNumero As String
        Public Property numero() As String
            Get
                Return strNumero
            End Get
            Set(ByVal value As String)
                strNumero = value
            End Set
        End Property

        Private strComplemento As String
        Public Property complemento() As String
            Get
                Return strComplemento
            End Get
            Set(ByVal value As String)
                strComplemento = value
            End Set
        End Property

        Private strBairro As String
        Public Property bairro() As String
            Get
                Return strBairro
            End Get
            Set(ByVal value As String)
                strBairro = value
            End Set
        End Property

        Private strCep As String
        Public Property cep() As String
            Get
                Return strCep
            End Get
            Set(ByVal value As String)
                strCep = value
            End Set
        End Property
    End Class

    Public Class clsNFSeHomologacaoEmpresa

        Private intSequencialNFe As Integer
        Public Property sequencialNFe() As Integer
            Get
                Return intSequencialNFe
            End Get
            Set(ByVal value As Integer)
                intSequencialNFe = value
            End Set
        End Property

        Private strSerieNFe As String
        Public Property serieNFe() As String
            Get
                Return strSerieNFe
            End Get
            Set(ByVal value As String)
                strSerieNFe = value
            End Set
        End Property

        Private intSequencialLoteNFe As Integer
        Public Property sequencialLoteNFe() As Integer
            Get
                Return intSequencialLoteNFe
            End Get
            Set(ByVal value As Integer)
                intSequencialLoteNFe = value
            End Set
        End Property

        Private intUsuarioAcessoProvedor As String
        Public Property usuarioAcessoProvedor() As String
            Get
                Return intUsuarioAcessoProvedor
            End Get
            Set(ByVal value As String)
                intUsuarioAcessoProvedor = value
            End Set
        End Property

        Private intSenhaAcessoProvedor As String
        Public Property senhaAcessoProvedor() As String
            Get
                Return intSenhaAcessoProvedor
            End Get
            Set(ByVal value As String)
                intSenhaAcessoProvedor = value
            End Set
        End Property

        Private intTokenAcessoProvedor As String
        Public Property tokenAcessoProvedor() As String
            Get
                Return intTokenAcessoProvedor
            End Get
            Set(ByVal value As String)
                intTokenAcessoProvedor = value
            End Set
        End Property
    End Class

    Public Class clsNFSeProducaoEmpresa

        Private intSequencialNFe As Integer
        Public Property sequencialNFe() As Integer
            Get
                Return intSequencialNFe
            End Get
            Set(ByVal value As Integer)
                intSequencialNFe = value
            End Set
        End Property

        Private strSerieNFe As String
        Public Property serieNFe() As String
            Get
                Return strSerieNFe
            End Get
            Set(ByVal value As String)
                strSerieNFe = value
            End Set
        End Property

        Private intSequencialLoteNFe As Integer
        Public Property sequencialLoteNFe() As Integer
            Get
                Return intSequencialLoteNFe
            End Get
            Set(ByVal value As Integer)
                intSequencialLoteNFe = value
            End Set
        End Property

        Private intUsuarioAcessoProvedor As String
        Public Property usuarioAcessoProvedor() As String
            Get
                Return intUsuarioAcessoProvedor
            End Get
            Set(ByVal value As String)
                intUsuarioAcessoProvedor = value
            End Set
        End Property

        Private intSenhaAcessoProvedor As String
        Public Property senhaAcessoProvedor() As String
            Get
                Return intSenhaAcessoProvedor
            End Get
            Set(ByVal value As String)
                intSenhaAcessoProvedor = value
            End Set
        End Property

        Private intTokenAcessoProvedor As String
        Public Property tokenAcessoProvedor() As String
            Get
                Return intTokenAcessoProvedor
            End Get
            Set(ByVal value As String)
                intTokenAcessoProvedor = value
            End Set
        End Property
    End Class


    Public Class clsEmitirNota
        Private strambienteEmissao As String
        Public Property ambienteEmissao() As String
            Get
                Return strambienteEmissao
            End Get
            Set(ByVal value As String)
                strambienteEmissao = value
            End Set
        End Property

        Private strtipo As String
        Public Property tipo() As String
            Get
                Return strtipo
            End Get
            Set(ByVal value As String)
                strtipo = value
            End Set
        End Property

        Private strIdExterno As String
        Public Property idExterno() As String
            Get
                Return strIdExterno
            End Get
            Set(ByVal value As String)
                strIdExterno = value
            End Set
        End Property

        Private bolenviarPorEmail As Boolean
        Public Property enviarPorEmail() As Boolean
            Get
                Return bolenviarPorEmail
            End Get
            Set(ByVal value As Boolean)
                bolenviarPorEmail = value
            End Set
        End Property

        Private clscliente As New ClassesJson.clsEmitirNotaCliente
        Public Property cliente() As ClassesJson.clsEmitirNotaCliente
            Get
                Return clscliente
            End Get
            Set(ByVal value As ClassesJson.clsEmitirNotaCliente)
                clscliente = value
            End Set
        End Property

        Private clsservico As New ClassesJson.clsEmitirNotaServico
        Public Property servico() As ClassesJson.clsEmitirNotaServico
            Get
                Return clsservico
            End Get
            Set(ByVal value As ClassesJson.clsEmitirNotaServico)
                clsservico = value
            End Set
        End Property

        Private strdeducoes As Double
        Public Property deducoes() As Double
            Get
                Return strdeducoes
            End Get
            Set(ByVal value As Double)
                strdeducoes = value
            End Set
        End Property

        Private strdescontos As Double
        Public Property descontos() As Double
            Get
                Return strdescontos
            End Get
            Set(ByVal value As Double)
                strdescontos = value
            End Set
        End Property

        Private strvalorTotal As Double
        Public Property valorTotal() As Double
            Get
                Return strvalorTotal
            End Get
            Set(ByVal value As Double)
                strvalorTotal = value
            End Set
        End Property

        Private strobservacoes As String
        Public Property observacoes() As String
            Get
                Return strobservacoes
            End Get
            Set(ByVal value As String)
                strobservacoes = value
            End Set
        End Property

    End Class

    Public Class clsEmitirNotaCliente

        Private clsendereco As New ClassesJson.clsEnderecoCliente
        Public Property endereco() As ClassesJson.clsEnderecoCliente
            Get
                Return clsendereco
            End Get
            Set(ByVal value As ClassesJson.clsEnderecoCliente)
                clsendereco = value
            End Set
        End Property

        Private strtipoPessoa As String
        Public Property tipoPessoa() As String
            Get
                Return strtipoPessoa
            End Get
            Set(ByVal value As String)
                strtipoPessoa = value
            End Set
        End Property

        Private strnome As String
        Public Property nome() As String
            Get
                Return strnome
            End Get
            Set(ByVal value As String)
                strnome = value
            End Set
        End Property

        Private stremail As String
        Public Property email() As String
            Get
                Return stremail
            End Get
            Set(ByVal value As String)
                stremail = value
            End Set
        End Property

        Private strcpfCnpj As String
        Public Property cpfCnpj() As String
            Get
                Return strcpfCnpj
            End Get
            Set(ByVal value As String)
                strcpfCnpj = value
            End Set
        End Property

        Private strinscricaoMunicipal As String
        Public Property inscricaoMunicipal() As String
            Get
                Return strinscricaoMunicipal
            End Get
            Set(ByVal value As String)
                strinscricaoMunicipal = value
            End Set
        End Property

        Private strinscricaoEstadual As String
        Public Property inscricaoEstadual() As String
            Get
                Return strinscricaoEstadual
            End Get
            Set(ByVal value As String)
                strinscricaoEstadual = value
            End Set
        End Property

        Private strtelefone As String
        Public Property telefone() As String
            Get
                Return strtelefone
            End Get
            Set(ByVal value As String)
                strtelefone = value
            End Set
        End Property
    End Class

    Public Class clsEnderecoCliente

        'Private strPais As String
        'Public Property pais() As String
        '    Get
        '        Return strPais
        '    End Get
        '    Set(ByVal value As String)
        '        strPais = value
        '    End Set
        'End Property

        Private strUf As String
        Public Property uf() As String
            Get
                Return strUf
            End Get
            Set(ByVal value As String)
                strUf = value
            End Set
        End Property

        Private strCidade As String
        Public Property cidade() As String
            Get
                Return strCidade
            End Get
            Set(ByVal value As String)
                strCidade = value
            End Set
        End Property

        Private strLogradouro As String
        Public Property logradouro() As String
            Get
                Return strLogradouro
            End Get
            Set(ByVal value As String)
                strLogradouro = value
            End Set
        End Property

        Private strNumero As String
        Public Property numero() As String
            Get
                Return strNumero
            End Get
            Set(ByVal value As String)
                strNumero = value
            End Set
        End Property

        Private strComplemento As String
        Public Property complemento() As String
            Get
                Return strComplemento
            End Get
            Set(ByVal value As String)
                strComplemento = value
            End Set
        End Property

        Private strBairro As String
        Public Property bairro() As String
            Get
                Return strBairro
            End Get
            Set(ByVal value As String)
                strBairro = value
            End Set
        End Property

        Private strCep As String
        Public Property cep() As String
            Get
                Return strCep
            End Get
            Set(ByVal value As String)
                strCep = value
            End Set
        End Property
    End Class

    Public Class clsEmitirNotaServico

        Private strufPrestacaServico As String
        Public Property ufPrestacaServico() As String
            Get
                Return strufPrestacaServico
            End Get
            Set(ByVal value As String)
                strufPrestacaServico = value
            End Set
        End Property

        Private strmunicipioPrestacaServico As String
        Public Property municipioPrestacaServico() As String
            Get
                Return strmunicipioPrestacaServico
            End Get
            Set(ByVal value As String)
                strmunicipioPrestacaServico = value
            End Set
        End Property

        Private strdescricao As String
        Public Property descricao() As String
            Get
                Return strdescricao
            End Get
            Set(ByVal value As String)
                strdescricao = value
            End Set
        End Property

        Private straliquotaIss As Double
        Public Property aliquotaIss() As Double
            Get
                Return straliquotaIss
            End Get
            Set(ByVal value As Double)
                straliquotaIss = value
            End Set
        End Property

        Private strissRetidoFonte As Boolean
        Public Property issRetidoFonte() As Boolean
            Get
                Return strissRetidoFonte
            End Get
            Set(ByVal value As Boolean)
                strissRetidoFonte = value
            End Set
        End Property

        Private strcodigoServicoMunicipio As String
        Public Property codigoServicoMunicipio() As String
            Get
                Return strcodigoServicoMunicipio
            End Get
            Set(ByVal value As String)
                strcodigoServicoMunicipio = value
            End Set
        End Property

        Private strdescricaoServicoMunicipio As String
        Public Property descricaoServicoMunicipio() As String
            Get
                Return strdescricaoServicoMunicipio
            End Get
            Set(ByVal value As String)
                strdescricaoServicoMunicipio = value
            End Set
        End Property

        Private stritemListaServicoC116 As String
        Public Property itemListaServicoC116() As String
            Get
                Return stritemListaServicoC116
            End Get
            Set(ByVal value As String)
                stritemListaServicoC116 = value
            End Set
        End Property

        Private strcnae As String
        Public Property cnae() As String
            Get
                Return strcnae
            End Get
            Set(ByVal value As String)
                strcnae = value
            End Set
        End Property

        Private strvalorCofins As Double
        Public Property valorCofins() As Double
            Get
                Return strvalorCofins
            End Get
            Set(ByVal value As Double)
                strvalorCofins = value
            End Set
        End Property

        Private strvalorCsll As Double
        Public Property valorCsll() As Double
            Get
                Return strvalorCsll
            End Get
            Set(ByVal value As Double)
                strvalorCsll = value
            End Set
        End Property

        Private strvalorInss As Double
        Public Property valorInss() As Double
            Get
                Return strvalorInss
            End Get
            Set(ByVal value As Double)
                strvalorInss = value
            End Set
        End Property

        Private strvalorIr As Double
        Public Property valorIr() As Double
            Get
                Return strvalorIr
            End Get
            Set(ByVal value As Double)
                strvalorIr = value
            End Set
        End Property

        Private strvalorPis As Double
        Public Property valorPis() As Double
            Get
                Return strvalorPis
            End Get
            Set(ByVal value As Double)
                strvalorPis = value
            End Set
        End Property
    End Class


    Public Class clsWebhook

        Private strtipo As String
        Public Property tipo() As String
            Get
                Return strtipo
            End Get
            Set(ByVal value As String)
                strtipo = value
            End Set
        End Property

        Private strempresaId As String
        Public Property empresaId() As String
            Get
                Return strempresaId
            End Get
            Set(ByVal value As String)
                strempresaId = value
            End Set
        End Property

        Private strnfeId As String
        Public Property nfeId() As String
            Get
                Return strnfeId
            End Get
            Set(ByVal value As String)
                strnfeId = value
            End Set
        End Property

        Private strnfeIdExterno As String
        Public Property nfeIdExterno() As String
            Get
                Return strnfeIdExterno
            End Get
            Set(ByVal value As String)
                strnfeIdExterno = value
            End Set
        End Property

        Private strnfeStatus As String
        Public Property nfeStatus() As String
            Get
                Return strnfeStatus
            End Get
            Set(ByVal value As String)
                strnfeStatus = value
            End Set
        End Property

        Private strnfeMotivoStatus As String
        Public Property nfeMotivoStatus() As String
            Get
                Return strnfeMotivoStatus
            End Get
            Set(ByVal value As String)
                strnfeMotivoStatus = value
            End Set
        End Property

        Private strnfeLinkPdf As String
        Public Property nfeLinkPdf() As String
            Get
                Return strnfeLinkPdf
            End Get
            Set(ByVal value As String)
                strnfeLinkPdf = value
            End Set
        End Property

        Private strnfeLinkXml As String
        Public Property nfeLinkXml() As String
            Get
                Return strnfeLinkXml
            End Get
            Set(ByVal value As String)
                strnfeLinkXml = value
            End Set
        End Property

        Private strnfeNumero As String
        Public Property nfeNumero() As String
            Get
                Return strnfeNumero
            End Get
            Set(ByVal value As String)
                strnfeNumero = value
            End Set
        End Property

        Private strnfeCodigoVerificacao As String
        Public Property nfeCodigoVerificacao() As String
            Get
                Return strnfeCodigoVerificacao
            End Get
            Set(ByVal value As String)
                strnfeCodigoVerificacao = value
            End Set
        End Property

        Private strnfeChaveAcesso As String
        Public Property nfeChaveAcesso() As String
            Get
                Return strnfeChaveAcesso
            End Get
            Set(ByVal value As String)
                strnfeChaveAcesso = value
            End Set
        End Property

        Private strnfeNumeroRps As String
        Public Property nfeNumeroRps() As String
            Get
                Return strnfeNumeroRps
            End Get
            Set(ByVal value As String)
                strnfeNumeroRps = value
            End Set
        End Property

        Private strnfeSerieRp As String
        Public Property nfeSerieRp() As String
            Get
                Return strnfeSerieRp
            End Get
            Set(ByVal value As String)
                strnfeSerieRp = value
            End Set
        End Property

        Private strnfeDataCompetencia As String
        Public Property nfeDataCompetencia() As String
            Get
                Return strnfeDataCompetencia
            End Get
            Set(ByVal value As String)
                strnfeDataCompetencia = value
            End Set
        End Property

        Private strnfeDataAutorizacao As String
        Public Property nfeDataAutorizacao() As String
            Get
                Return strnfeDataAutorizacao
            End Get
            Set(ByVal value As String)
                strnfeDataAutorizacao = value
            End Set
        End Property
    End Class
End Namespace
