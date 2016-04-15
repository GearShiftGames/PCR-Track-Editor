Public Class Form1

    Public subFolder As String
    Public s As Integer
    Public barriers As New List(Of Barrier)
    Public checks As New List(Of CheckPoint)
    Public vehicles As New List(Of Vehicle)

    Private Sub btnCheckPoint_Click_1(sender As Object, e As EventArgs) Handles btnCheckPoint.Click
        checks.Add(New CheckPoint())
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "q"
                rotateImage(5)
            Case "b"
                barriers.Add(New Barrier())
                s = barriers.Count - 1
                barriers(s).id = s
            Case "a"
                barriers(s).p.Location = New Point(barriers(s).p.Location.X - 1, barriers(s).p.Location.Y)
            Case "s"
                barriers(s).p.Location = New Point(barriers(s).p.Location.X, barriers(s).p.Location.Y + 1)
            Case "d"
                barriers(s).p.Location = New Point(barriers(s).p.Location.X + 1, barriers(s).p.Location.Y)
            Case "w"
                barriers(s).p.Location = New Point(barriers(s).p.Location.X, barriers(s).p.Location.Y - 1)
        End Select
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If (e.Y > 50 Or e.X > 100) Then
            menuStrip.Visible = False
        Else
            menuStrip.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SaveToolStripMenuItem_Click(sender, e)
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'save
        If (subFolder = "") Then
            subFolder = InputBox("Enter a name or number for the level:")
        End If

        If (Dir(System.AppDomain.CurrentDomain.BaseDirectory() + subFolder) = "") Then
            My.Computer.FileSystem.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() + subFolder)
        End If

        'Barriers
        FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\barriers.ini", OpenMode.Output)
        For i = 0 To barriers.Count - 1
            Print(1, "[" + i.ToString() + "]" & vbCrLf)
            Print(1, "positionX=" & (barriers(i).p.Location.X * 2).ToString() & vbCrLf)
            Print(1, "positionY=" & (barriers(i).p.Location.Y * 2).ToString() & vbCrLf)
            Print(1, "rotation=0" & vbCrLf)
            Print(1, vbCrLf)
        Next
        FileClose(1)

        'Check Points
        FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\checkpoints.ini", OpenMode.Output)
        For i = 0 To checks.Count - 1
            Print(1, "[" + i.ToString() + "]" & vbCrLf)
            Print(1, "ID=" + checks(i).id.ToString() & vbCrLf)
            Print(1, "nextID=" + checks(i).nId.ToString() & vbCrLf)
            Print(1, "pathID=" + checks(i).pId.ToString() & vbCrLf)
            Print(1, "positionX=" & (checks(i).p.Location.X * 2).ToString() & vbCrLf)
            Print(1, "positionY=" & (checks(i).p.Location.Y * 2).ToString() & vbCrLf)
            Print(1, vbCrLf)
        Next
        FileClose(1)

        'Vehicles
        FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\vehicles.ini", OpenMode.Output)
        For i = 0 To vehicles.Count - 1
            Print(1, "[" + i.ToString() + "]" & vbCrLf)
            Print(1, "positionX=" & (vehicles(i).p.Location.X * 2).ToString() & vbCrLf)
            Print(1, "positionY=" & (vehicles(i).p.Location.Y * 2).ToString() & vbCrLf)
            Print(1, "rotation=" & (vehicles(i).rotation).ToString() & vbCrLf)
            Print(1, vbCrLf)
        Next
        FileClose(1)

        MsgBox("Successfully saved as level " + subFolder + "!")

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'open
        subFolder = InputBox("Which level would you like to load?")

        If (Dir(System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\barriers.ini") = "") Then
            MsgBox("That level doesn't exist!")
            MsgBox(System.AppDomain.CurrentDomain.BaseDirectory() + subFolder)
            Exit Sub
        End If

        For i = 0 To barriers.Count - 1
            barriers(i).p.Dispose()
        Next
        For i = 0 To checks.Count - 1
            checks(i).p.Dispose()
        Next
        For i = 0 To vehicles.Count - 1
            vehicles(i).p.Dispose()
        Next
        barriers.Clear()
        checks.Clear()
        vehicles.Clear()

        Dim readLine As String
        Dim subLine() As String
        Dim tempX, tempY As Integer

        'Barriers
        FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\barriers.ini", OpenMode.Input)
        Do
            readLine = LineInput(1)
            If (Mid(readLine, 1, 1) = "[") Then
                barriers.Add(New Barrier())
                subLine = Split(LineInput(1), "=")
                tempX = Val(subLine(1)) / 2
                subLine = Split(LineInput(1), "=")
                tempY = Val(subLine(1)) / 2
                barriers(barriers.Count - 1).p.Location = New Point(tempX, tempY)
                barriers(barriers.Count - 1).x = tempX
                barriers(barriers.Count - 1).y = tempY
                LineInput(1) 'rotation not implemented
            End If
        Loop Until EOF(1)
        FileClose(1)

        'Check Points
        FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\checkpoints.ini", OpenMode.Input)
        Do
            readLine = LineInput(1)
            If (Mid(readLine, 1, 1) = "[") Then
                checks.Add(New CheckPoint())
                With checks(checks.Count - 1)
                    subLine = Split(LineInput(1), "=")
                    .id = Val(subLine(1))
                    subLine = Split(LineInput(1), "=")
                    .nId = Val(subLine(1))
                    subLine = Split(LineInput(1), "=")
                    .pId = Val(subLine(1))
                    subLine = Split(LineInput(1), "=")
                    tempX = Val(subLine(1)) / 2
                    subLine = Split(LineInput(1), "=")
                    tempY = Val(subLine(1)) / 2
                    checks(checks.Count - 1).p.Location = New Point(tempX, tempY)
                    LineInput(1) 'rotation not implemented
                End With
            End If
        Loop Until EOF(1)
        FileClose(1)

        'Vehicles
        'FileOpen(1, System.AppDomain.CurrentDomain.BaseDirectory() + subFolder + "\vehicles.ini", OpenMode.Input)
        'Do
        '    readLine = LineInput(1)
        '    If (Mid(readLine, 1, 1) = "[") Then
        '        vehicles.Add(New Vehicle())
        '        subLine = Split(LineInput(1), "=")
        '        tempX = Val(subLine(1)) / 2
        '        subLine = Split(LineInput(1), "=")
        '        tempY = Val(subLine(1)) / 2
        '        subLine = Split(LineInput(1), "=")
        '        vehicles(vehicles.Count - 1).rotation = Val(subLine(1))
        '        vehicles(vehicles.Count - 1).p.Location = New Point(tempX, tempY)
        '    End If
        'Loop Until EOF(1)
        'FileClose(1)

    End Sub

    Private Sub btnSmallRock_Click(sender As Object, e As EventArgs) Handles btnSmallRock.Click
        barriers.Add(New Barrier())
        s = barriers.Count - 1
        barriers(s).id = s
    End Sub

    Private Sub VehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleToolStripMenuItem.Click
        vehicles.Add(New Vehicle())
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        subFolder = InputBox("Enter a name or number for the level:")
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Dim fileName As String
        fileName = InputBox("Enter file name for background:")
        MsgBox(System.AppDomain.CurrentDomain.BaseDirectory() + fileName)
        Me.BackgroundImage = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() + fileName + ".png")
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If chkPoint.Visible Then
            chkPoint.Visible = False
        Else
            chkPoint.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    Private Sub rotateImage(degrees_ As Integer)
        Dim wid As Integer
        Dim hgt As Integer
        Dim radians As Double
        Dim tempX, tempY As Single

        radians = degrees_ * Math.PI / 180

        ' Make a Bitmap representing the input image.
        Dim bm_in As New Bitmap(picIn.Image)
        wid = bm_in.Width
        hgt = bm_in.Height

        ' Make the output bitmap.
        Dim bm_out As New Bitmap(hgt * 2, wid * 2)

        ' Copy the pixel values.
        For X = 0 To wid - 1
            For Y = 0 To hgt - 1
                tempX = X * Math.Cos(radians) - Y * Math.Sin(radians)
                tempY = X * Math.Sin(radians) + Y * Math.Cos(radians)
                bm_out.SetPixel(tempX, tempY, bm_in.GetPixel(X, Y))
            Next Y
        Next X

        ' Display the result.
        picOut.Image = bm_out
    End Sub
End Class
