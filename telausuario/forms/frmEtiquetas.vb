Imports DevExpress.XtraReports.UI
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
        Dim rel As New relEtiqueta

        rel.tbProd.Rows.Add()
        rel.tbProd.Rows.Item(0).Item("Produto") = "NOME DO PRODUTO 1"
        rel.tbProd.Rows.Item(0).Item("CodInterno") = "00001"
        rel.tbProd.Rows.Item(0).Item("Empresa") = "ELIANE MELO PRATA FINA"
        rel.tbProd.Rows.Item(0).Item("ValorUnitario") = "32,99"

        rel.tbProd.Rows.Add()
        rel.tbProd.Rows.Item(1).Item("Produto") = "NOME DO PRODUTO 2"
        rel.tbProd.Rows.Item(1).Item("CodInterno") = "41131"
        rel.tbProd.Rows.Item(1).Item("Empresa") = "ELIANE MELO PRATA FINA"
        rel.tbProd.Rows.Item(1).Item("ValorUnitario") = "24,99"
        rel.ShowPreview()
    End Sub
End Class