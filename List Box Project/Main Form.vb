Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmMain
    Private Sub lstTeach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeach.SelectedIndexChanged
        If lstTeach.SelectedIndex = 0 Then
            lblTeach.Text = lstTeach.SelectedItem.ToString
            picTeach.Image = My.Resources.Mrs_Arens
        ElseIf lstTeach.SelectedIndex = 1 Then
            lblTeach.Text = lstTeach.SelectedItem.ToString
            picTeach.Image = My.Resources.maxresdefault
        ElseIf lstTeach.SelectedIndex = 2 Then
            lblTeach.Text = lstTeach.SelectedItem.ToString
            picTeach.Image = My.Resources.images
        ElseIf lstTeach.SelectedIndex = 3 Then
            lblTeach.Text = lstTeach.SelectedItem.ToString
            picTeach.Image = My.Resources.download
        ElseIf lstTeach.SelectedIndex = 4 Then
            lblTeach.Text = lstTeach.SelectedItem.ToString
            picTeach.Image = My.Resources.download__1_
        End If
    End Sub
End Class
