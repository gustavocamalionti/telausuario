Imports telausuario.clsFuncao
Imports telausuario.clsBanco
Imports telausuario.modFuncoes
Imports telausuario.clsWebHook
Imports Microsoft.Win32
Imports System.Threading
Imports System.IO

Public Class frmWebHookTeste

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        WHPost(True)
        WHGetListEvents()
        WHGetEspecificEvent("evt_h9ktBsvqL9GKXI2VnZExUdPF")
    End Sub

    Private Sub frmWebHookTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class