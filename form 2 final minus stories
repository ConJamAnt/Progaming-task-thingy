Public Class Tasksolver
    Dim exp As Integer
    Dim levelUp As Integer
    Dim level As Integer
    Dim difficulty As Integer
    Dim Adifficulty() As Integer = {0, 1, 2, 3, 4}
    Dim Task As String
    Dim ProgressInput As String
    Dim StoryText As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDifficulty.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click

        'validates if a task is present
        If txtTask.Text = "" Then
            MsgBox("Please give your task a name.")
        ElseIf txtDifficulty.Text = "" Then
            MsgBox("Please select as difficulty for your task.")
        Else
            MsgBox("Task Set.")

            'Assigns variables with a value
            If txtDifficulty.SelectedItem = "Easy" Then
                difficulty = 1

            ElseIf txtDifficulty.SelectedItem = "Medium" Then
                difficulty = 2

            ElseIf txtDifficulty.SelectedItem = "Hard" Then
                difficulty = 3

            ElseIf txtDifficulty.SelectedItem = "Deathly" Then
                difficulty = 4
            Else
                difficulty = 0

            End If

            Task = txtTask.Text
        End If






        'saves progress
        My.Computer.FileSystem.WriteAllText("H:\Computing 11-12\Programing\Tasksolver\Progress Save.txt", (exp + 1000).ToString + " " + (level + 1000).ToString + " " + difficulty.ToString + " " + Task, False)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTask.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles LvlBox.TextChanged

    End Sub

    Private Sub Tasksolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'reads document

        ProgressInput = My.Computer.FileSystem.ReadAllText("H:\Computing 11-12\Programing\Tasksolver\Progress Save.txt")

        'decifers values from document
        exp = (Convert.ToInt32(ProgressInput.Substring(0, 4))) - 1000

        level = (Convert.ToInt32(ProgressInput.Substring(5, 4))) - 1000

        difficulty = Convert.ToInt32(ProgressInput.Substring(10, 1))

        Task = ProgressInput.Substring(12)


        'calculates levelUp variable
        levelUp = ((level - 1) * 10) + 50


        'writes values into respective boxes
        txtTask.Text = Task
        ExpBox.Text = exp
        LvlBox.Text = level
        ExpReqBox.Text = levelUp - exp


        'decides which story parts are unlocked

        If level >= 2 Then
            SyP1btn.Enabled = True
        End If

        If level >= 4 Then
            SyP2btn.Enabled = True
        End If

        If level >= 6 Then
            SyP3btn.Enabled = True
        End If

        If level >= 8 Then
            SyP4btn.Enabled = True
        End If

        If level >= 10 Then
            SyP5btn.Enabled = True
        End If


        'Saves Progress
        My.Computer.FileSystem.WriteAllText("H:\Computing 11-12\Programing\Tasksolver\Progress Save.txt", (exp + 1000).ToString + " " + (level + 1000).ToString + " " + difficulty.ToString + " " + Task, False)





    End Sub

    Private Sub btnTaskComplete_Click(sender As Object, e As EventArgs) Handles btnTaskComplete.Click

        'checks for a set task
        If Task = "" Then
            MsgBox("No task is currently set.")

        Else
            MsgBox("Task Complete.")


            'Checks for the difficulty of the task
            Dim counter As Integer
            For counter = 0 To 4
                If Adifficulty(counter) = difficulty Then
                    exp = (counter * 10) + exp
                End If
            Next

            difficulty = 0

            'resets input values
            txtDifficulty.Text = ""
            txtTask.Text = ""
            Task = ""

            'updates exp/level displays
            ExpBox.Text = (exp)
            LvlBox.Text = (level)
            ExpReqBox.Text = levelUp - exp


            'saves progress
            My.Computer.FileSystem.WriteAllText("H:\Computing 11-12\Programing\Tasksolver\Progress Save.txt", (exp + 1000).ToString + " " + (level + 1000).ToString + " " + difficulty.ToString + " " + Task, False)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles lvlUpBtn.Click

        'determines whether the player has enough exp to level up.
        If exp >= levelUp Then
            exp = exp - levelUp
            levelUp = levelUp + 10
            level = level + 1
            MsgBox("Well Done Traveller!" + vbNewLine + "You've successfully reached Level " + level.ToString + "!")

            'resets input values
            txtDifficulty.Text = ""
            txtTask.Text = ""

            'updates exp/level displays
            ExpBox.Text = (exp)
            LvlBox.Text = (level)
            ExpReqBox.Text = levelUp - exp

            'decieds which story parts are unlocked

            If level >= 2 Then
                SyP1btn.Enabled = True
            End If

            If level >= 4 Then
                SyP2btn.Enabled = True
            End If

            If level >= 6 Then
                SyP3btn.Enabled = True
            End If

            If level >= 8 Then
                SyP4btn.Enabled = True
            End If

            If level >= 10 Then
                SyP5btn.Enabled = True
            End If

            'saves progress
            My.Computer.FileSystem.WriteAllText("H:\Computing 11-12\Programing\Tasksolver\Progress Save.txt", (exp + 1000).ToString + " " + (level + 1000).ToString + " " + difficulty.ToString + " " + Task, False)

        Else
            MsgBox("You do not have enough exp to level up. Sorry.")
        End If


    End Sub

    Private Sub SyP1btn_Click(sender As Object, e As EventArgs) Handles SyP1btn.Click
        '  StoryText = My.Computer.FileSystem.ReadAllText("H:\Computing 11-12\Programing\Tasksolver\Chapter 1.txt")
        '  MsgBox(StoryText)
    End Sub

    Private Sub SyP2btn_Click(sender As Object, e As EventArgs) Handles SyP2btn.Click

    End Sub

    Private Sub SyP3btn_Click(sender As Object, e As EventArgs) Handles SyP3btn.Click

    End Sub

    Private Sub SyP4btn_Click(sender As Object, e As EventArgs) Handles SyP4btn.Click

    End Sub

    Private Sub SyP5btn_Click(sender As Object, e As EventArgs) Handles SyP5btn.Click

    End Sub
End Class
