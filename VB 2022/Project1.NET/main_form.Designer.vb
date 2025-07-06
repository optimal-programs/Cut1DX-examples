<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class main_form
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents lbCuttingOrder As System.Windows.Forms.ListBox
	Public WithEvents lbUnusedPieces As System.Windows.Forms.ListBox
	Public WithEvents lbUsedPieces As System.Windows.Forms.ListBox
    Public WithEvents tbWaste As System.Windows.Forms.TextBox
	Public WithEvents b_Start As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbCuttingOrder = New System.Windows.Forms.ListBox()
        Me.lbUnusedPieces = New System.Windows.Forms.ListBox()
        Me.lbUsedPieces = New System.Windows.Forms.ListBox()
        Me.tbWaste = New System.Windows.Forms.TextBox()
        Me.b_Start = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCuttingOrder
        '
        Me.lbCuttingOrder.BackColor = System.Drawing.SystemColors.Window
        Me.lbCuttingOrder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbCuttingOrder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCuttingOrder.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbCuttingOrder.ItemHeight = 22
        Me.lbCuttingOrder.Location = New System.Drawing.Point(0, 247)
        Me.lbCuttingOrder.Name = "lbCuttingOrder"
        Me.lbCuttingOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbCuttingOrder.Size = New System.Drawing.Size(744, 202)
        Me.lbCuttingOrder.TabIndex = 15
        '
        'lbUnusedPieces
        '
        Me.lbUnusedPieces.BackColor = System.Drawing.SystemColors.Window
        Me.lbUnusedPieces.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnusedPieces.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbUnusedPieces.ItemHeight = 22
        Me.lbUnusedPieces.Location = New System.Drawing.Point(476, 66)
        Me.lbUnusedPieces.Name = "lbUnusedPieces"
        Me.lbUnusedPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbUnusedPieces.Size = New System.Drawing.Size(110, 114)
        Me.lbUnusedPieces.TabIndex = 11
        '
        'lbUsedPieces
        '
        Me.lbUsedPieces.BackColor = System.Drawing.SystemColors.Window
        Me.lbUsedPieces.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsedPieces.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbUsedPieces.ItemHeight = 22
        Me.lbUsedPieces.Location = New System.Drawing.Point(231, 64)
        Me.lbUsedPieces.Name = "lbUsedPieces"
        Me.lbUsedPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbUsedPieces.Size = New System.Drawing.Size(131, 114)
        Me.lbUsedPieces.TabIndex = 10
        '
        'tbWaste
        '
        Me.tbWaste.AcceptsReturn = True
        Me.tbWaste.BackColor = System.Drawing.SystemColors.Window
        Me.tbWaste.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbWaste.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWaste.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbWaste.Location = New System.Drawing.Point(13, 173)
        Me.tbWaste.MaxLength = 0
        Me.tbWaste.Name = "tbWaste"
        Me.tbWaste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbWaste.Size = New System.Drawing.Size(97, 29)
        Me.tbWaste.TabIndex = 1
        '
        'b_Start
        '
        Me.b_Start.BackColor = System.Drawing.SystemColors.Control
        Me.b_Start.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_Start.Location = New System.Drawing.Point(16, 41)
        Me.b_Start.Name = "b_Start"
        Me.b_Start.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.b_Start.Size = New System.Drawing.Size(120, 68)
        Me.b_Start.TabIndex = 0
        Me.b_Start.Text = "Start"
        Me.b_Start.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(0, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(430, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cutting Order (Length, Angle1, Angle2) ..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(476, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(212, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Unused pieces (Length)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(231, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(194, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Used Pieces (Length)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(150, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Waste"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 38)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 34)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(119, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 34)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 34)
        Me.ToolStripMenuItem1.Text = "Register ..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(744, 449)
        Me.Controls.Add(Me.lbCuttingOrder)
        Me.Controls.Add(Me.lbUnusedPieces)
        Me.Controls.Add(Me.lbUsedPieces)
        Me.Controls.Add(Me.tbWaste)
        Me.Controls.Add(Me.b_Start)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Cut 1D X example"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region 
End Class