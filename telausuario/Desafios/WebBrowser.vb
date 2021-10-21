Public Class WebBrowser 

    Private Sub btnTransformarHTML_Click(sender As Object, e As EventArgs) Handles btnTransformarHTML.Click
        WebBrowser1.DocumentText = rchConteudoHTML.Text
    End Sub

End Class