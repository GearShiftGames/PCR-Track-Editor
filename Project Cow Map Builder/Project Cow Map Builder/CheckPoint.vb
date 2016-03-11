Public Class CheckPoint

    Public p As New PictureBox
    Public id, nId, pId, rot As Integer

    Sub New()
        p.Location = New Point(0, 20)
        p.Visible = True
        p.SizeMode = PictureBoxSizeMode.AutoSize
        p.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & "checkpoint.png")
        AddHandler p.MouseUp, AddressOf chkPointMouseUp
        AddHandler p.MouseMove, AddressOf chkPointMouseMove
        AddHandler p.MouseLeave, AddressOf chkPointMouseLeave
        AddHandler p.MouseClick, AddressOf chkPointClick
        Form1.Controls.Add(p)
    End Sub

    Private Sub chkPointClick(sender As Object, e As MouseEventArgs)
        If (Form1.chkPoint.Tag = "") Then
            Form1.chkPoint.Tag = "1"
        Else
            id = Val(Form1.txtId.Text)
            nId = Val(Form1.txtNId.Text)
            pId = Val(Form1.txtPId.Text)
            rot = Val(Form1.txtRot.Text)
            Form1.chkPoint.Tag = ""
        End If
    End Sub

    Private Sub chkPointMouseUp(sender As Object, e As MouseEventArgs)
        p.Location = New Point(p.Location.X + e.X - 8, p.Location.Y + e.Y - 8)
    End Sub

    Private Sub chkPointMouseMove(sender As Object, e As MouseEventArgs)
        With Form1
            .chkPoint.Visible = True
            .txtId.Text = id.ToString()
            .txtNId.Text = nId.ToString()
            .txtPId.Text = pId.ToString()
            .txtRot.Text = rot.ToString()
        End With
    End Sub

    Private Sub chkPointMouseLeave(sender As Object, e As EventArgs)
        If (Form1.chkPoint.Tag = "") Then
            Form1.chkPoint.Visible = False
        End If
    End Sub
End Class
