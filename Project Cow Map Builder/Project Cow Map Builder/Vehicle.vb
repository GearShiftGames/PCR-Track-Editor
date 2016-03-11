Public Class Vehicle

    Public p As New PictureBox
    Public rotation As Integer

    Sub New()
        p.Location = New Point(0, 20)
        p.Visible = True
        p.SizeMode = PictureBoxSizeMode.AutoSize
        p.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "vehicle.png")
        AddHandler p.MouseUp, AddressOf vehicleMouseUp
        AddHandler p.MouseClick, AddressOf vehicleMouseClick
        Form1.Controls.Add(p)
    End Sub

    Private Sub vehicleMouseClick(sender As Object, e As MouseEventArgs)
        Dim inImg As Image
        inImg = p.Image
        inImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
        p.Image = inImg
        If rotation < 270 Then
            rotation += 90
        Else
            rotation = 0
        End If
    End Sub

    Private Sub vehicleMouseUp(sender As Object, e As MouseEventArgs)
        'TODO: Add rotation support
        p.Location = New Point(p.Location.X + e.X - 16, p.Location.Y + e.Y - 8)
    End Sub

End Class
