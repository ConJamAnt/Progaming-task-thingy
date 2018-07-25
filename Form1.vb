Public Class Form1
    Dim exp As Integer
    Dim level As Integer = 50
    Dim levelUp As Integer
    Dim reward As String
    Dim difficulty As Integer
    Dim Task As String

    Private Sub btntask_Click(sender As Object, e As EventArgs) Handles btnTaskComplete.Click

        difficulty = ComboBox1.SelectedItem
        Task = txtTask.Text

        If Task = "" Then
            MsgBox("Please enter a task name")
        Else
            If difficulty = "Easy" Then
                exp = exp + 10

            ElseIf difficulty = "Medium" Then
                exp = exp + 20

            ElseIf difficulty = "Hard" Then
                exp = exp + 30

            ElseIf difficulty = "Deathly" Then
                exp = exp + 40
            End If

            If exp = level Then
                level = level + 10
                levelUp = levelUp + 1
            End If
        End If



    End Sub
End Class
