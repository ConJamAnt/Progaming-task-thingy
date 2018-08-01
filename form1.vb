2Public Class Form1
    'Creates variables
    Dim exp As Integer
    Dim levelUp As Integer = 50
    Dim level As Integer = 1
    Dim difficulty() As String = {"" ,"Easy", "Medium", "Hard", "Deathly"}
    Dim Task As String
    Dim difficultyselected As String
    Dim Task1 As Boolean = False
    Dim Task2 As Boolean = False
    Dim Task3 As Boolean = False


    Private Sub btntask_Click(sender As Object, e As EventArgs) Handles btnTaskComplete.Click
          'Creates a variable
        Dim difficulty1 As String
        'Assigns the variable with a value
        difficulty1 = txtDifficulty1.Text

        'Checks for the difficulty of the task
        ''If difficulty1 = "Easy" Then
        ''    exp = exp + 10

        ''ElseIf difficulty1 = "Medium" Then
        ''    exp = exp + 20

        ''ElseIf difficulty1 = "Hard" Then
        ''    exp = exp + 30

        ''ElseIf difficulty1 = "Deathly" Then
        ''    exp = exp + 40
        ''End If



        If difficulty(1) = difficulty1 Then
            exp += 10
        ElseIf difficulty(2) = difficulty1 Then
            exp += 20
        ElseIf difficulty(3) = difficulty1 Then
            exp += 30
        ElseIf difficulty(4) = difficulty1 Then
            exp += 40

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
        difficultyselected = ComboBox1.SelectedItem
        Task = txtTask.Text


        'Checks to see if there are any available task spots and fills them with a task.
        If Task1 = False Then
            txtTask1.Text = Task
            txtDifficulty1.Text = difficultyselected
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
