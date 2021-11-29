Namespace clsJsonDropBox
    Public Class clsCriarPasta
        Public Property path As String
        Public Property autorename As Boolean
    End Class

    Public Class clsDownload
        Public Property path As String
    End Class


    Public Class clsUpload
        Public Property path As String
        Public Property mode As String
        Public Property autorename As Boolean
        Public Property mute As Boolean
        Public Property strict_conflict As Boolean
    End Class

    Public Class clsCriarLink
        Public Property path As String
    End Class

    Public Class clsDeletarArquivo
        Public Property path As String
    End Class

    Public Class clsListarArquivos
        Public Property path As String
    End Class

    Public Class clsRecuperarLink
        Public Property path As String
    End Class

End Namespace


