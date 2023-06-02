Imports System.Windows

Public Class Home
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim formToShow As New About()

        ' Call the form's Show method to display it
        formToShow.Show()
    End Sub
End Class