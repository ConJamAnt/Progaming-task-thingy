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
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Deathly"})
        Me.ComboBox1.Location = New System.Drawing.Point(260, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Easy"
        '
        'btnTaskComplete
        '
        Me.btnTaskComplete.Location = New System.Drawing.Point(260, 91)
        Me.btnTaskComplete.Name = "btnTaskComplete"
        Me.btnTaskComplete.Size = New System.Drawing.Size(182, 57)
        Me.btnTaskComplete.TabIndex = 1
        Me.btnTaskComplete.Text = "Complete Task"
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
        Me.btnNewTask.Location = New System.Drawing.Point(23, 91)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(182, 57)
        Me.btnNewTask.TabIndex = 5
        Me.btnNewTask.Text = "Add Task"
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 317)
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
End Class
