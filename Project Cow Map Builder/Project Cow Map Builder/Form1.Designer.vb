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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBarrier = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSmallRock = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCheckPoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnView = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkPoint = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNId = New System.Windows.Forms.TextBox()
        Me.txtPId = New System.Windows.Forms.TextBox()
        Me.txtRot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRotate = New System.Windows.Forms.Button()
        Me.picIn = New System.Windows.Forms.PictureBox()
        Me.picOut = New System.Windows.Forms.PictureBox()
        Me.menuStrip.SuspendLayout()
        Me.chkPoint.SuspendLayout()
        CType(Me.picIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.Color.Transparent
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(960, 24)
        Me.menuStrip.Stretch = False
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem, Me.btnBarrier, Me.btnCheckPoint, Me.VehicleToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.AddToolStripMenuItem.Text = "Edit"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'btnBarrier
        '
        Me.btnBarrier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSmallRock})
        Me.btnBarrier.Name = "btnBarrier"
        Me.btnBarrier.Size = New System.Drawing.Size(138, 22)
        Me.btnBarrier.Text = "Barrier"
        '
        'btnSmallRock
        '
        Me.btnSmallRock.Name = "btnSmallRock"
        Me.btnSmallRock.Size = New System.Drawing.Size(132, 22)
        Me.btnSmallRock.Text = "Small Rock"
        '
        'btnCheckPoint
        '
        Me.btnCheckPoint.Name = "btnCheckPoint"
        Me.btnCheckPoint.Size = New System.Drawing.Size(138, 22)
        Me.btnCheckPoint.Text = "Check Point"
        '
        'VehicleToolStripMenuItem
        '
        Me.VehicleToolStripMenuItem.Name = "VehicleToolStripMenuItem"
        Me.VehicleToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.VehicleToolStripMenuItem.Text = "Vehicle"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnView})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'btnView
        '
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 22)
        Me.btnView.Text = "Check Point"
        '
        'chkPoint
        '
        Me.chkPoint.Controls.Add(Me.txtId)
        Me.chkPoint.Controls.Add(Me.txtNId)
        Me.chkPoint.Controls.Add(Me.txtPId)
        Me.chkPoint.Controls.Add(Me.txtRot)
        Me.chkPoint.Controls.Add(Me.Label4)
        Me.chkPoint.Controls.Add(Me.Label3)
        Me.chkPoint.Controls.Add(Me.Label2)
        Me.chkPoint.Controls.Add(Me.Label1)
        Me.chkPoint.Location = New System.Drawing.Point(0, 62)
        Me.chkPoint.Name = "chkPoint"
        Me.chkPoint.Size = New System.Drawing.Size(88, 76)
        Me.chkPoint.TabIndex = 4
        Me.chkPoint.TabStop = False
        Me.chkPoint.Text = "Check Point"
        Me.chkPoint.Visible = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.SystemColors.Control
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Location = New System.Drawing.Point(61, 16)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(27, 13)
        Me.txtId.TabIndex = 10
        Me.txtId.Text = "0"
        '
        'txtNId
        '
        Me.txtNId.BackColor = System.Drawing.SystemColors.Control
        Me.txtNId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNId.Location = New System.Drawing.Point(61, 29)
        Me.txtNId.Name = "txtNId"
        Me.txtNId.Size = New System.Drawing.Size(27, 13)
        Me.txtNId.TabIndex = 9
        Me.txtNId.Text = "0"
        '
        'txtPId
        '
        Me.txtPId.BackColor = System.Drawing.SystemColors.Control
        Me.txtPId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPId.Location = New System.Drawing.Point(61, 42)
        Me.txtPId.Name = "txtPId"
        Me.txtPId.Size = New System.Drawing.Size(27, 13)
        Me.txtPId.TabIndex = 8
        Me.txtPId.Text = "0"
        '
        'txtRot
        '
        Me.txtRot.BackColor = System.Drawing.SystemColors.Control
        Me.txtRot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRot.Location = New System.Drawing.Point(61, 55)
        Me.txtRot.Name = "txtRot"
        Me.txtRot.Size = New System.Drawing.Size(27, 13)
        Me.txtRot.TabIndex = 7
        Me.txtRot.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rotation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Path ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Next ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'btnRotate
        '
        Me.btnRotate.Location = New System.Drawing.Point(441, 272)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.Size = New System.Drawing.Size(75, 23)
        Me.btnRotate.TabIndex = 5
        Me.btnRotate.Text = "Button1"
        Me.btnRotate.UseVisualStyleBackColor = True
        '
        'picIn
        '
        Me.picIn.Image = Global.Project_Cow_Map_Builder.My.Resources.Resources.wheelBlue
        Me.picIn.Location = New System.Drawing.Point(61, 204)
        Me.picIn.Name = "picIn"
        Me.picIn.Size = New System.Drawing.Size(86, 76)
        Me.picIn.TabIndex = 6
        Me.picIn.TabStop = False
        '
        'picOut
        '
        Me.picOut.Location = New System.Drawing.Point(153, 204)
        Me.picOut.Name = "picOut"
        Me.picOut.Size = New System.Drawing.Size(252, 211)
        Me.picOut.TabIndex = 7
        Me.picOut.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Project_Cow_Map_Builder.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(960, 540)
        Me.Controls.Add(Me.picOut)
        Me.Controls.Add(Me.picIn)
        Me.Controls.Add(Me.btnRotate)
        Me.Controls.Add(Me.chkPoint)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Cows Map Builder"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.chkPoint.ResumeLayout(False)
        Me.chkPoint.PerformLayout()
        CType(Me.picIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBarrier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCheckPoint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSmallRock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkPoint As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNId As System.Windows.Forms.TextBox
    Friend WithEvents txtPId As System.Windows.Forms.TextBox
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRotate As System.Windows.Forms.Button
    Friend WithEvents picIn As System.Windows.Forms.PictureBox
    Friend WithEvents picOut As System.Windows.Forms.PictureBox

End Class
