<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasks
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
        Me.TxtInputBox = New System.Windows.Forms.TextBox()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ChkListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescriptionBox = New System.Windows.Forms.TextBox()
        Me.TxtSearchBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtInputBox
        '
        Me.TxtInputBox.Location = New System.Drawing.Point(501, 129)
        Me.TxtInputBox.Name = "TxtInputBox"
        Me.TxtInputBox.Size = New System.Drawing.Size(339, 26)
        Me.TxtInputBox.TabIndex = 1
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.Black
        Me.BtnInsert.ForeColor = System.Drawing.Color.White
        Me.BtnInsert.Location = New System.Drawing.Point(501, 161)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(108, 42)
        Me.BtnInsert.TabIndex = 2
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.Black
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Location = New System.Drawing.Point(618, 161)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(108, 42)
        Me.BtnRemove.TabIndex = 3
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Black
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(732, 161)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(108, 42)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'ChkListBox
        '
        Me.ChkListBox.FormattingEnabled = True
        Me.ChkListBox.Location = New System.Drawing.Point(501, 209)
        Me.ChkListBox.Name = "ChkListBox"
        Me.ChkListBox.Size = New System.Drawing.Size(339, 441)
        Me.ChkListBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(916, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Add Description"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Black
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(868, 396)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(108, 42)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Black
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(982, 396)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(930, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Search Item"
        '
        'TxtDescriptionBox
        '
        Me.TxtDescriptionBox.Location = New System.Drawing.Point(868, 246)
        Me.TxtDescriptionBox.Multiline = True
        Me.TxtDescriptionBox.Name = "TxtDescriptionBox"
        Me.TxtDescriptionBox.Size = New System.Drawing.Size(221, 144)
        Me.TxtDescriptionBox.TabIndex = 12
        '
        'TxtSearchBox
        '
        Me.TxtSearchBox.Location = New System.Drawing.Point(868, 474)
        Me.TxtSearchBox.Multiline = True
        Me.TxtSearchBox.Name = "TxtSearchBox"
        Me.TxtSearchBox.Size = New System.Drawing.Size(221, 153)
        Me.TxtSearchBox.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(690, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 43)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "My Task List"
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1316, 886)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSearchBox)
        Me.Controls.Add(Me.TxtDescriptionBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkListBox)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.TxtInputBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tasks"
        Me.Text = "Tasks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtInputBox As TextBox
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ChkListBox As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnClear As Button
    Public WithEvents Label3 As Label
    Friend WithEvents TxtDescriptionBox As TextBox
    Friend WithEvents TxtSearchBox As TextBox
    Friend WithEvents Label4 As Label
End Class
