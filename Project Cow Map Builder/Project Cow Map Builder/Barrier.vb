Public Class Barrier

    Public p As New PictureBox
    Public x, y As Integer
    Public id As Integer

    Sub New()
        p.Location = New Point(Cursor.Position.X - Form1.Location.X, Cursor.Position.Y - Form1.Location.Y)
        p.Visible = True
        p.SizeMode = PictureBoxSizeMode.AutoSize
        p.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "barrier.png")
        AddHandler p.MouseUp, AddressOf barrierMouseUp
        AddHandler p.MouseClick, AddressOf barrierClick
        AddHandler p.DoubleClick, AddressOf barrierDblClick
        Form1.Controls.Add(p)
    End Sub

    Private Sub barrierMouseUp(sender As Object, e As MouseEventArgs)
        p.Location = New Point(p.Location.X + e.X - 8, p.Location.Y + e.Y - 5.5)
        x = p.Left
        y = p.Top
    End Sub

    Private Sub barrierClick(sender As Object, e As MouseEventArgs)
        Form1.s = id
    End Sub

    Private Sub barrierDblClick(sender As Object, e As MouseEventArgs)
        Form1.barriers.Remove(Me)
    End Sub

End Class
