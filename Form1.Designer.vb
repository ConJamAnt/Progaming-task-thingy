<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnTaskComplete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTask1 = New System.Windows.Forms.TextBox()
        Me.txtTask2 = New System.Windows.Forms.TextBox()
        Me.txtTask3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDifficulty1 = New System.Windows.Forms.TextBox()
        Me.txtDifficulty2 = New System.Windows.Forms.TextBox()
        Me.txtDifficulty3 = New System.Windows.Forms.TextBox()
        Me.btnTaskComplete2 = New System.Windows.Forms.Button()
        Me.btnComplete3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Deathly"})
        Me.ComboBox1.Location = New System.Drawing.Point(260, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'btnTaskComplete
        '
        Me.btnTaskComplete.Location = New System.Drawing.Point(12, 301)
        Me.btnTaskComplete.Name = "btnTaskComplete"
        Me.btnTaskComplete.Size = New System.Drawing.Size(133, 57)
        Me.btnTaskComplete.TabIndex = 1
        Me.btnTaskComplete.Text = "Complete Task 1"
        Me.btnTaskComplete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Difficulty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Task"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(23, 40)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(182, 20)
        Me.txtTask.TabIndex = 4
        '
        'btnNewTask
        '
        Me.btnNewTask.Location = New System.Drawing.Point(23, 66)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(182, 57)
        Me.btnNewTask.TabIndex = 5
        Me.btnNewTask.Text = "Add Task"
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ongoing Tasks"
        '
        'txtTask1
        '
        Me.txtTask1.Location = New System.Drawing.Point(13, 176)
        Me.txtTask1.Name = "txtTask1"
        Me.txtTask1.ReadOnly = True
        Me.txtTask1.Size = New System.Drawing.Size(132, 20)
        Me.txtTask1.TabIndex = 7
        '
        'txtTask2
        '
        Me.txtTask2.Location = New System.Drawing.Point(151, 176)
        Me.txtTask2.Name = "txtTask2"
        Me.txtTask2.ReadOnly = True
        Me.txtTask2.Size = New System.Drawing.Size(132, 20)
        Me.txtTask2.TabIndex = 8
        '
        'txtTask3
        '
        Me.txtTask3.Location = New System.Drawing.Point(289, 176)
        Me.txtTask3.Name = "txtTask3"
        Me.txtTask3.ReadOnly = True
        Me.txtTask3.Size = New System.Drawing.Size(132, 20)
        Me.txtTask3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tasks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Difficulty"
        '
        'txtDifficulty1
        '
        Me.txtDifficulty1.Location = New System.Drawing.Point(13, 238)
        Me.txtDifficulty1.Name = "txtDifficulty1"
        Me.txtDifficulty1.ReadOnly = True
        Me.txtDifficulty1.Size = New System.Drawing.Size(132, 20)
        Me.txtDifficulty1.TabIndex = 12
        '
        'txtDifficulty2
        '
        Me.txtDifficulty2.Location = New System.Drawing.Point(151, 238)
        Me.txtDifficulty2.Name = "txtDifficulty2"
        Me.txtDifficulty2.ReadOnly = True
        Me.txtDifficulty2.Size = New System.Drawing.Size(132, 20)
        Me.txtDifficulty2.TabIndex = 13
        '
        'txtDifficulty3
        '
        Me.txtDifficulty3.Location = New System.Drawing.Point(289, 238)
        Me.txtDifficulty3.Name = "txtDifficulty3"
        Me.txtDifficulty3.ReadOnly = True
        Me.txtDifficulty3.Size = New System.Drawing.Size(132, 20)
        Me.txtDifficulty3.TabIndex = 14
        '
        'btnTaskComplete2
        '
        Me.btnTaskComplete2.Location = New System.Drawing.Point(151, 301)
        Me.btnTaskComplete2.Name = "btnTaskComplete2"
        Me.btnTaskComplete2.Size = New System.Drawing.Size(133, 57)
        Me.btnTaskComplete2.TabIndex = 15
        Me.btnTaskComplete2.Text = "Complete Task 2 "
        Me.btnTaskComplete2.UseVisualStyleBackColor = True
        '
        'btnComplete3
        '
        Me.btnComplete3.Location = New System.Drawing.Point(288, 301)
        Me.btnComplete3.Name = "btnComplete3"
        Me.btnComplete3.Size = New System.Drawing.Size(133, 57)
        Me.btnComplete3.TabIndex = 16
        Me.btnComplete3.Text = "Complete Task 3 "
        Me.btnComplete3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 370)
        Me.Controls.Add(Me.btnComplete3)
        Me.Controls.Add(Me.btnTaskComplete2)
        Me.Controls.Add(Me.txtDifficulty3)
        Me.Controls.Add(Me.txtDifficulty2)
        Me.Controls.Add(Me.txtDifficulty1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTask3)
        Me.Controls.Add(Me.txtTask2)
        Me.Controls.Add(Me.txtTask1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNewTask)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTaskComplete)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnTaskComplete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnNewTask As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTask1 As TextBox
    Friend WithEvents txtTask2 As TextBox
    Friend WithEvents txtTask3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDifficulty1 As TextBox
    Friend WithEvents txtDifficulty2 As TextBox
    Friend WithEvents txtDifficulty3 As TextBox
    Friend WithEvents btnTaskComplete2 As Button
    Friend WithEvents btnComplete3 As Button
End Class
