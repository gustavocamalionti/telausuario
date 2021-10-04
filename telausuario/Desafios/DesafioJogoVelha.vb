Public Class DesafioJogoVelha
    Dim contador_clicks As Integer = 0
    Dim strBolinhaOuCruz As String = ""

    Dim strTopLeft As String
    Dim strTop As String
    Dim strTopRight As String
    Dim strleft As String
    Dim strCenter As String
    Dim strRight As String
    Dim strbottomLeft As String
    Dim strBottom As String
    Dim strBottomRight As String
    Private Sub SituacaoJogo()
        'Vitória do Círculo - Linhas
        If strTopLeft = "O" And strTop = "O" And strTopRight = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strleft = "O" And strCenter = "O" And strRight = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub


        ElseIf strbottomLeft = "O" And strBottom = "O" And strBottomRight = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

            'Vitória do Círculo - Colunas
        ElseIf strTopLeft = "O" And strleft = "O" And strbottomLeft = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTop = "O" And strCenter = "O" And strBottom = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTopRight = "O" And strRight = "O" And strBottomRight = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

            'Vitória do Círculo - Diagonal
        ElseIf strTopLeft = "O" And strCenter = "O" And strBottomRight = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTopLeft = "O" And strCenter = "O" And strbottomLeft = "O" Then

            MsgBox("Vitória do Circulo!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

            'Vitória da Cruz - Linhas
        ElseIf strTopLeft = "X" And strTop = "X" And strTopRight = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strleft = "X" And strCenter = "X" And strRight = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub


        ElseIf strbottomLeft = "X" And strBottom = "X" And strBottomRight = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

            'Vitória da Cruz - Colunas
        ElseIf strTopLeft = "X" And strleft = "X" And strbottomLeft = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTop = "X" And strCenter = "X" And strBottom = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTopRight = "X" And strRight = "X" And strBottomRight = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

            'Vitória da Cruz - Diagonal
        ElseIf strTopLeft = "X" And strCenter = "X" And strBottomRight = "X" Then

            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        ElseIf strTopRight = "X" And strCenter = "X" And strbottomLeft = "X" Then
            MsgBox("Vitória da Cruz!", MsgBoxStyle.Information)
            Me.btnStart.Text = "Start"
            LimparVelha()
            Exit Sub

        End If

        'Empate
        If contador_clicks = 9 Then
            Me.btnStart.Text = "Start"
            contador_clicks = 0
            MsgBox("Empate", MsgBoxStyle.Information)
            LimparVelha()
        End If
    End Sub

    Private Sub DesenharJogada(bloco As DevExpress.XtraEditors.PictureEdit, PreenchimentoJogada As String)
        If Me.btnStart.Text = "Start" Then
            Exit Sub
        Else
            If PreenchimentoJogada = "" Then
                contador_clicks = contador_clicks + 1
                If contador_clicks Mod 2 = 0 Then
                    bloco.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\circulo.png")
                    strBolinhaOuCruz = "O"
                Else
                    bloco.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\x.png")
                    strBolinhaOuCruz = "X"
                End If
            End If
        End If
    End Sub

    Private Sub LimparVelha()
        Me.imgTopLeft.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgTop.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgTopRight.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgLeft.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgCenter.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgRight.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgBottomLeft.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgBottom.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")
        Me.imgBottomRight.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\branca.png")

        contador_clicks = 0
        strBolinhaOuCruz = ""
        strTopLeft = ""
        strTop = ""
        strTopRight = ""
        strleft = ""
        strCenter = ""
        strRight = ""
        strbottomLeft = ""
        strBottom = ""
        strBottomRight = ""

    End Sub
    Private Sub imgTopLeft_Click(sender As Object, e As EventArgs) Handles imgTopLeft.Click
        DesenharJogada(imgTopLeft, strTopLeft)
        strTopLeft = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgTop_Click(sender As Object, e As EventArgs) Handles imgTop.Click
        DesenharJogada(imgTop, strTop)
        strTop = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgTopRight_Click(sender As Object, e As EventArgs) Handles imgTopRight.Click
        DesenharJogada(imgTopRight, strTopRight)
        strTopRight = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgLeft_Click(sender As Object, e As EventArgs) Handles imgLeft.Click
        DesenharJogada(imgLeft, strleft)
        strleft = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgCenter_Click(sender As Object, e As EventArgs) Handles imgCenter.Click
        DesenharJogada(imgCenter, strCenter)
        strCenter = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgRight_Click(sender As Object, e As EventArgs) Handles imgRight.Click
        DesenharJogada(imgRight, strRight)
        strRight = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgBottomLeft_Click(sender As Object, e As EventArgs) Handles imgBottomLeft.Click
        DesenharJogada(imgBottomLeft, strbottomLeft)
        strbottomLeft = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgBottom_Click(sender As Object, e As EventArgs) Handles imgBottom.Click
        DesenharJogada(imgBottom, strBottom)
        strBottom = strBolinhaOuCruz
        SituacaoJogo()
    End Sub

    Private Sub imgBottomRight_Click(sender As Object, e As EventArgs) Handles imgBottomRight.Click
        DesenharJogada(imgBottomRight, strBottomRight)
        strBottomRight = strBolinhaOuCruz
        SituacaoJogo()
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Me.btnStart.Text = "Start" Then
            Me.btnStart.Text = "Stop"
        Else
            Me.btnStart.Text = "Start"
            contador_clicks = 0

        End If
        LimparVelha()
    End Sub
End Class