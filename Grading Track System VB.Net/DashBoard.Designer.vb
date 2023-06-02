<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tasks = New System.Windows.Forms.Button()
        Me.btnSchedules = New System.Windows.Forms.Button()
        Me.btnGtracker = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlFill = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlFill.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.ForeColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(268, 185)
        Me.Panel6.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(82, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 95)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade Wise"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Tasks)
        Me.Panel2.Controls.Add(Me.btnSchedules)
        Me.Panel2.Controls.Add(Me.btnGtracker)
        Me.Panel2.Controls.Add(Me.btnhome)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 886)
        Me.Panel2.TabIndex = 5
        '
        'Tasks
        '
        Me.Tasks.BackColor = System.Drawing.Color.Black
        Me.Tasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Tasks.ForeColor = System.Drawing.Color.White
        Me.Tasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tasks.Location = New System.Drawing.Point(0, 485)
        Me.Tasks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tasks.Name = "Tasks"
        Me.Tasks.Size = New System.Drawing.Size(268, 100)
        Me.Tasks.TabIndex = 9
        Me.Tasks.Text = "Tasks"
        Me.Tasks.UseVisualStyleBackColor = False
        '
        'btnSchedules
        '
        Me.btnSchedules.BackColor = System.Drawing.Color.Black
        Me.btnSchedules.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchedules.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnSchedules.ForeColor = System.Drawing.Color.White
        Me.btnSchedules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedules.Location = New System.Drawing.Point(0, 385)
        Me.btnSchedules.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSchedules.Name = "btnSchedules"
        Me.btnSchedules.Size = New System.Drawing.Size(268, 100)
        Me.btnSchedules.TabIndex = 8
        Me.btnSchedules.Text = "Schedules"
        Me.btnSchedules.UseVisualStyleBackColor = False
        '
        'btnGtracker
        '
        Me.btnGtracker.BackColor = System.Drawing.Color.Black
        Me.btnGtracker.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGtracker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnGtracker.ForeColor = System.Drawing.Color.White
        Me.btnGtracker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGtracker.Location = New System.Drawing.Point(0, 285)
        Me.btnGtracker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGtracker.Name = "btnGtracker"
        Me.btnGtracker.Size = New System.Drawing.Size(268, 100)
        Me.btnGtracker.TabIndex = 7
        Me.btnGtracker.Text = "GTracker"
        Me.btnGtracker.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Black
        Me.btnhome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(0, 185)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(268, 100)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 786)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(268, 100)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(268, 185)
        Me.Panel5.TabIndex = 0
        '
        'pnlFill
        '
        Me.pnlFill.BackColor = System.Drawing.Color.LightBlue
        Me.pnlFill.Controls.Add(Me.LinkLabel1)
        Me.pnlFill.Controls.Add(Me.PictureBox2)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(0, 0)
        Me.pnlFill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(1427, 886)
        Me.pnlFill.TabIndex = 6
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1214, 30)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(397, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(778, 627)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 886)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlFill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoard"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tasks As Button
    Friend WithEvents btnSchedules As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlFill As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGtracker As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
