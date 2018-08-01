<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasksolver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tasksolver))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDifficulty = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.btnTaskComplete = New System.Windows.Forms.Button()
        Me.ExpReqBox = New System.Windows.Forms.TextBox()
        Me.ExpBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LvlBox = New System.Windows.Forms.TextBox()
        Me.lvlUpBtn = New System.Windows.Forms.Button()
        Me.SyP1btn = New System.Windows.Forms.Button()
        Me.SyP3btn = New System.Windows.Forms.Button()
        Me.SyP2btn = New System.Windows.Forms.Button()
        Me.SyP5btn = New System.Windows.Forms.Button()
        Me.SyP4btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TASKSOLVER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Task:"
        '
        'txtDifficulty
        '
        Me.txtDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDifficulty.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifficulty.FormattingEnabled = True
        Me.txtDifficulty.Items.AddRange(New Object() {"", "Easy", "Medium", "Hard", "Deathly"})
        Me.txtDifficulty.Location = New System.Drawing.Point(379, 257)
        Me.txtDifficulty.Name = "txtDifficulty"
        Me.txtDifficulty.Size = New System.Drawing.Size(97, 26)
        Me.txtDifficulty.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(88, 76)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(389, 162)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(87, 257)
        Me.txtTask.Multiline = True
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(280, 26)
        Me.txtTask.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Difficulty:"
        '
        'btnNewTask
        '
        Me.btnNewTask.Location = New System.Drawing.Point(87, 305)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(75, 23)
        Me.btnNewTask.TabIndex = 6
        Me.btnNewTask.Text = "Set Task"
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'btnTaskComplete
        '
        Me.btnTaskComplete.Location = New System.Drawing.Point(379, 305)
        Me.btnTaskComplete.Name = "btnTaskComplete"
        Me.btnTaskComplete.Size = New System.Drawing.Size(97, 23)
        Me.btnTaskComplete.TabIndex = 7
        Me.btnTaskComplete.Text = "Task Complete"
        Me.btnTaskComplete.UseVisualStyleBackColor = True
        '
        'ExpReqBox
        '
        Me.ExpReqBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExpReqBox.Location = New System.Drawing.Point(87, 377)
        Me.ExpReqBox.Name = "ExpReqBox"
        Me.ExpReqBox.ReadOnly = True
        Me.ExpReqBox.Size = New System.Drawing.Size(180, 13)
        Me.ExpReqBox.TabIndex = 8
        '
        'ExpBox
        '
        Me.ExpBox.Location = New System.Drawing.Point(123, 351)
        Me.ExpBox.Name = "ExpBox"
        Me.ExpBox.ReadOnly = True
        Me.ExpBox.Size = New System.Drawing.Size(39, 20)
        Me.ExpBox.TabIndex = 9
        Me.ExpBox.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Exp:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Level:"
        '
        'LvlBox
        '
        Me.LvlBox.Location = New System.Drawing.Point(437, 351)
        Me.LvlBox.Name = "LvlBox"
        Me.LvlBox.ReadOnly = True
        Me.LvlBox.Size = New System.Drawing.Size(39, 20)
        Me.LvlBox.TabIndex = 12
        Me.LvlBox.Text = "0"
        '
        'lvlUpBtn
        '
        Me.lvlUpBtn.BackColor = System.Drawing.Color.DarkRed
        Me.lvlUpBtn.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlUpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lvlUpBtn.Location = New System.Drawing.Point(230, 426)
        Me.lvlUpBtn.Name = "lvlUpBtn"
        Me.lvlUpBtn.Size = New System.Drawing.Size(93, 58)
        Me.lvlUpBtn.TabIndex = 13
        Me.lvlUpBtn.Text = "LEVEL UP!"
        Me.lvlUpBtn.UseVisualStyleBackColor = False
        '
        'SyP1btn
        '
        Me.SyP1btn.Enabled = False
        Me.SyP1btn.Location = New System.Drawing.Point(47, 560)
        Me.SyP1btn.Name = "SyP1btn"
        Me.SyP1btn.Size = New System.Drawing.Size(75, 23)
        Me.SyP1btn.TabIndex = 14
        Me.SyP1btn.Text = "Part 1"
        Me.SyP1btn.UseVisualStyleBackColor = True
        '
        'SyP3btn
        '
        Me.SyP3btn.Enabled = False
        Me.SyP3btn.Location = New System.Drawing.Point(239, 560)
        Me.SyP3btn.Name = "SyP3btn"
        Me.SyP3btn.Size = New System.Drawing.Size(75, 23)
        Me.SyP3btn.TabIndex = 15
        Me.SyP3btn.Text = "Part 3"
        Me.SyP3btn.UseVisualStyleBackColor = True
        '
        'SyP2btn
        '
        Me.SyP2btn.Enabled = False
        Me.SyP2btn.Location = New System.Drawing.Point(142, 560)
        Me.SyP2btn.Name = "SyP2btn"
        Me.SyP2btn.Size = New System.Drawing.Size(75, 23)
        Me.SyP2btn.TabIndex = 16
        Me.SyP2btn.Text = "Part 2"
        Me.SyP2btn.UseVisualStyleBackColor = True
        '
        'SyP5btn
        '
        Me.SyP5btn.Enabled = False
        Me.SyP5btn.Location = New System.Drawing.Point(434, 560)
        Me.SyP5btn.Name = "SyP5btn"
        Me.SyP5btn.Size = New System.Drawing.Size(75, 23)
        Me.SyP5btn.TabIndex = 17
        Me.SyP5btn.Text = "Part 5"
        Me.SyP5btn.UseVisualStyleBackColor = True
        '
        'SyP4btn
        '
        Me.SyP4btn.Enabled = False
        Me.SyP4btn.Location = New System.Drawing.Point(337, 560)
        Me.SyP4btn.Name = "SyP4btn"
        Me.SyP4btn.Size = New System.Drawing.Size(75, 23)
        Me.SyP4btn.TabIndex = 18
        Me.SyP4btn.Text = "Part 4"
        Me.SyP4btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Story Parts:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(105, 377)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(180, 13)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Exp required until next level."
        '
        'Tasksolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 636)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SyP4btn)
        Me.Controls.Add(Me.SyP5btn)
        Me.Controls.Add(Me.SyP2btn)
        Me.Controls.Add(Me.SyP3btn)
        Me.Controls.Add(Me.SyP1btn)
        Me.Controls.Add(Me.lvlUpBtn)
        Me.Controls.Add(Me.LvlBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExpBox)
        Me.Controls.Add(Me.ExpReqBox)
        Me.Controls.Add(Me.btnTaskComplete)
        Me.Controls.Add(Me.btnNewTask)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtDifficulty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tasksolver"
        Me.Text = "TaskSovler - The Quest for Completeness"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDifficulty As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTask As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNewTask As Button
    Friend WithEvents btnTaskComplete As Button
    Friend WithEvents ExpReqBox As TextBox
    Friend WithEvents ExpBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LvlBox As TextBox
    Friend WithEvents lvlUpBtn As Button
    Friend WithEvents SyP1btn As Button
    Friend WithEvents SyP3btn As Button
    Friend WithEvents SyP2btn As Button
    Friend WithEvents SyP5btn As Button
    Friend WithEvents SyP4btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
