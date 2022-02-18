Namespace clsJsonDropBox
    Public Class clsCriarPasta
        Public Property path As String
        Public Property autorename As Boolean
    End Class

    Public Class clsDownload
        Public Property path As String
    End Class

    Public Class clsRemoverLink
        Public Property file As String
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

    Public Class clsUploadSessionStart
        Public Property close As Boolean
    End Class

    Public Class clsUploadSessionAppend
        Public Property cursor As New Cursor
        Public Property close As Boolean
    End Class

    Public Class Cursor
        Public Property session_id As String
        Public Property offset As Integer
    End Class

End Namespace


