Imports System.Threading

Public Class Dashboard
    Private Sub Tasks_Click(sender As Object, e As EventArgs) Handles Tasks.Click
        pnlFill.Controls.Clear()
        Dim formToShow As New Tasks
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        pnlFill.Controls.Add(formToShow)
        formToShow.Show()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        pnlFill.Controls.Clear()
        Dim formToShow As New Home
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        pnlFill.Controls.Add(formToShow)
        formToShow.Show()
    End Sub

    Private Sub btnGtracker_Click(sender As Object, e As EventArgs) Handles btnGtracker.Click
        pnlFill.Controls.Clear()
        Dim formToShow As New GTracker
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        pnlFill.Controls.Add(formToShow)
        formToShow.Show()
    End Sub

    Private Sub btnSchedules_Click(sender As Object, e As EventArgs) Handles btnSchedules.Click
        pnlFill.Controls.Clear()
        Dim formToShow As New Schedules
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        pnlFill.Controls.Add(formToShow)
        formToShow.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub pnlFill_Paint(sender As Object, e As PaintEventArgs) Handles pnlFill.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
