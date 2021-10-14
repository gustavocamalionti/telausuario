Imports DevExpress.XtraReports.UI
Imports telausuario.modFuncoes
Imports telausuario.clsFuncao
Public Class frmEtiquetas

    Private Sub btnArdoxGarantia_Click(sender As Object, e As EventArgs) Handles btnArdoxGarantia.Click
        Dim rel As New relEtiquetaArdoxGarantia

        rel.tbProd.Rows.Add()
        rel.tbProd.Rows.Item(0).Item("Produto") = "Nome do Produto 1"
        rel.tbProd.Rows.Item(0).Item("Data") = "24/09/2021"
        rel.tbProd.Rows.Item(0).Item("CodInterno") = "00001"
        rel.tbProd.Rows.Item(0).Item("CodOrdem") = "214"
        rel.tbProd.Rows.Item(0).Item("Func") = "V: Alberto"

        rel.tbProd.Rows.Add()
        rel.tbProd.Rows.Item(1).Item("Produto") = "Nome do Produto 2"
        rel.tbProd.Rows.Item(1).Item("Data") = "22/07/2021"
        rel.tbProd.Rows.Item(1).Item("CodInterno") = "00002"
        rel.tbProd.Rows.Item(1).Item("CodOrdem") = "432"
        rel.tbProd.Rows.Item(1).Item("Func") = "V: Juliana"
        rel.ShowPreview()

    End Sub
    
    Private Sub btnEtiqueta_Click(sender As Object, e As EventArgs) Handles btnEtiqueta.Click

        'Dim ParametroBusca As DataTable = CarregarDataTable("select P.CodOrdem, case when F.Nome is null then '' else F.Nome " & _
        '"end as 'Funcionário', P.CodProdInterno, P.ValorUnitario() " & _
        '"from pedido as P left join funcionario as F on F.Codigo = P.CodFunc " & _
        '"where F.CodConfig = '' and CodOrdem = '';")

        Dim infoProduto As DataTable = CarregarDataTable("select * from produto;")

        Dim imgImagem As New PictureBox
        Dim strCodigoProduto As String = "A0002"
        Dim strTam As String = ""

        imgImagem.Size = New System.Drawing.Size(300, 30)
        Dim intQtd As Integer
        Dim intLens As Integer = strCodigoProduto.Length
        If intLens > 7 Then
            intQtd = 160
        ElseIf intLens >= 6 And intLens <= 7 Then
            intQtd = 140
        Else
            intQtd = 120
        End If

        Dim EstoqueSomadoLote As Boolean = False
        Dim imagem As Byte() = Nothing
        If EstoqueSomadoLote = True Then
            Dim Barcode As New BarcodeLib.Barcode(strCodigoProduto & strTam, BarcodeLib.TYPE.CODE128)
            Try
                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, strCodigoProduto & strTam, 380, 19)
                imagem = converteimagem(imgImagem.Image)

            Catch ex As Exception
                intQtd = 360
                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, strCodigoProduto & strTam, intQtd, 19)
                imagem = converteimagem(imgImagem.Image)
            End Try
        Else
            Dim Barcode As New BarcodeLib.Barcode(strCodigoProduto & strTam, BarcodeLib.TYPE.CODE128)
            Try
                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, strCodigoProduto & strTam, intQtd, 19)
                imagem = converteimagem(imgImagem.Image)
            Catch ex As Exception
                intQtd = 160
                imgImagem.Image = Barcode.Encode(BarcodeLib.TYPE.CODE128, strCodigoProduto & strTam, intQtd, 19)
                imagem = converteimagem(imgImagem.Image)
            End Try
        End If


        Dim rel As New relEtiqueta
        rel.tbProd.Rows.Add()
        rel.tbProd.Rows.Item(0).Item("Produto") = "TESTE TESTE TESTE TESTE TESTE TESTE 01 COM O NOME DO PRODUTO"
        rel.tbProd.Rows.Item(0).Item("CodInterno") = strCodigoProduto
        rel.tbProd.Rows.Item(0).Item("Empresa") = "ELIANE MELO PRATA FINA"
        rel.tbProd.Rows.Item(0).Item("ValorUnitario") = "32,99"
        rel.tbProd.Rows.Item(0).Item("CodBarra") = imagem
        rel.ShowPreview()
    End Sub

End Class