Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Imports telausuario.modFuncoes
Imports Microsoft.Win32
Imports System.Threading
Imports System.IO

Public Class frmWhatsappDrive
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        clsGoogleDriveApi.CriarPastaGoogleDrive("TestePasta")
    End Sub

    Private Sub frmWhatsappDrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class