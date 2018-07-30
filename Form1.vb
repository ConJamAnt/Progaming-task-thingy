Public Class Form1
    'Creates variables
    Dim exp As Integer
    Dim levelUp As Integer = 50
    Dim level As Integer = 1
    Dim difficulty As String
    Dim Task As String
    Dim Task1 As Boolean = False
    Dim Task2 As Boolean = False
    Dim Task3 As Boolean = False


    Private Sub btntask_Click(sender As Object, e As EventArgs) Handles btnTaskComplete.Click
        'Creates a variable
        Dim difficulty1 As String
        'Assigns the variable with a value
        difficulty1 = txtDifficulty1.Text

        'Checks for the difficulty of the task
        If difficulty1 = "Easy" Then
            exp = exp + 10

        ElseIf difficulty1 = "Medium" Then
            exp = exp + 20

        ElseIf difficulty1 = "Hard" Then
            exp = exp + 30

        ElseIf difficulty1 = "Deathly" Then
            exp = exp + 40
        End If

        'Assigns experience depending on difficulty of task and determines whether the player levels up.
        If exp >= levelUp Then
            levelUp = levelUp + 10
            level = level + 1
            exp = 0
        End If

        txtDifficulty1.Text = ""
        txtTask1.Text = ""
        Task1 = False

        lblEXP.Text = ("EXP: " & exp)
        lblLVL.Text = ("LVL: " & level)
    End Sub

    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click
        'Assigns variables with a value
        difficulty = ComboBox1.SelectedItem
        Task = txtTask.Text


        'Checks to see if there are any available task spots and fills them with a task.
        If Task1 = False Then
            txtTask1.Text = Task
            txtDifficulty1.Text = difficulty
            Task1 = True
            'ElseIf Task2 = False Then
            '    txtTask2.Text = Task
            '    txtDifficulty2.Text = difficulty
            '    Task2 = True
            'ElseIf Task3 = False Then
            '    txtTask3.Text = Task
            '    txtDifficulty3.Text = difficulty
            '    Task3 = True
            'Else
            '    MsgBox("You already have 3 ongoing tasks finish one before beginning another")
        Else
            MsgBox("You must complete your current task before you start another.")
        End If
    End Sub

    'Private Sub btnTaskComplete2_Click(sender As Object, e As EventArgs) Handles btnTaskComplete2.Click
    '    'Creates a variable
    '    Dim difficulty2 As String
    '    'Assigns the variable with a value
    '    difficulty2 = txtDifficulty2.Text

    '    'Checks for the difficulty of the task
    '    If difficulty2 = "Easy" Then
    '        exp = exp + 10

    '    ElseIf difficulty2 = "Medium" Then
    '        exp = exp + 20

    '    ElseIf difficulty2 = "Hard" Then
    '        exp = exp + 30

    '    ElseIf difficulty2 = "Deathly" Then
    '        exp = exp + 40
    '    End If

    '    'Assigns experience depending on difficulty of task and determines whether the player levels up.
    '    If exp >= levelUp Then
    '        levelUp = levelUp + 10
    '        level = level + 1
    '        exp = 0
    '    End If

    '    txtDifficulty2.Text = ""
    '    txtTask2.Text = ""
    '    Task2 = False


    '    lblEXP.Text = ("EXP: " & exp)
    '    lblLVL.Text = ("LVL: " & level)

    'End Sub

    'Private Sub btnComplete3_Click(sender As Object, e As EventArgs) Handles btnComplete3.Click
    '    'Creates a variable
    '    Dim difficulty3 As String
    '    'Assigns the variable with a value
    '    difficulty3 = txtDifficulty3.Text

    '    'Checks for the difficulty of the task
    '    If difficulty3 = "Easy" Then
    '        exp = exp + 10

    '    ElseIf difficulty3 = "Medium" Then
    '        exp = exp + 20

    '    ElseIf difficulty3 = "Hard" Then
    '        exp = exp + 30

    '    ElseIf difficulty3 = "Deathly" Then
    '        exp = exp + 40
    '    End If

    '    'Assigns experience depending on difficulty of task and determines whether the player levels up.
    '    If exp >= levelUp Then
    '        levelUp = levelUp + 10
    '        level = level + 1
    '        exp = 0
    '    End If

    '    txtDifficulty3.Text = ""
    '    txtTask3.Text = ""
    '    Task3 = False


    '    lblEXP.Text = ("EXP: " & exp)
    '    lblLVL.Text = ("LVL: " & level)
    'End Sub
End Class
