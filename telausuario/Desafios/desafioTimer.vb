

Public Class desafioTimer
    Public random_x As New Random
    Public random_y As New Random
    Public intRandom_x As Integer
    Public intRandom_y As Integer

    Private Sub positionRandom()
        intRandom_x = CInt(Int((1024 * Rnd()) + 1)) 'random_x.Next(0, 1024)
        intRandom_y = CInt(Int((620 * Rnd()) + 1)) 'random_y.Next(0, 620)
        imgRato.Location = New Point(intRandom_x, intRandom_y)

        If imgGato.Location.X > imgRato.Location.X Then
            imgGato.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\gatoleft.png")
            Me.Cursor = New Cursor(DirectCast(Me.imgGato.Image, Bitmap).GetHicon())
        ElseIf imgGato.Location.X < imgRato.Location.X Then
            imgGato.Image = Image.FromFile("C:\Arquivos\Gustavo Arquivos\Resources Próprios\gatoright.png")
            Me.Cursor = New Cursor(DirectCast(Me.imgGato.Image, Bitmap).GetHicon())
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        If rdgVelocidade.SelectedIndex = 0 Then
            timer1.Interval = 900
            positionRandom()

        ElseIf rdgVelocidade.SelectedIndex = 1 Then
            timer1.Interval = 500
            positionRandom()

        ElseIf rdgVelocidade.SelectedIndex = 2 Then
            timer1.Interval = 300
            positionRandom()

        ElseIf rdgVelocidade.SelectedIndex = 3 Then
            timer1.Interval = 150
            positionRandom()
        Else
            timer1.Interval = 50
            positionRandom()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If btnStart.Text = "Start" Then
            timer1.Start()
            btnStart.Text = "Stop"
        Else
            timer1.Stop()
            btnStart.Text = "Start"
        End If


    End Sub

    Private Sub imgRato_MouseEnter(sender As Object, e As EventArgs) Handles imgRato.MouseEnter
        If btnStart.Text = "Stop" Then
            timer1.Stop()
            btnStart.Text = "Start"
            MsgBox("parabéns, você ganhou!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub PanelControl1_MouseEnter(sender As Object, e As EventArgs) Handles PanelControl1.MouseEnter
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub desafioTimer_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    Dim x As Integer = (e.X) - 17
    '    Dim y As Integer = (e.Y) - 17
    '    Me.PictureEdit1.Location = New System.Drawing.Point(x, y)
    'End Sub

    'Private Sub PanelControl2_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelControl2.MouseMove
    '    Dim x As Integer = (e.X) - 17
    '    Dim y As Integer = (e.Y) - 17
    '    Me.PictureEdit1.Location = New System.Drawing.Point(x, y)
    'End Sub

    Private Sub PanelControl2_MouseEnter(sender As Object, e As EventArgs) Handles PanelControl2.MouseEnter
        Me.Cursor = New Cursor(DirectCast(Me.imgGato.Image, Bitmap).GetHicon())
    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub
End Class