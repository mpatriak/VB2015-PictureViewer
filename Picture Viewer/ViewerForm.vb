Public Class ViewerForm
    Private Sub btnSelectPicture_Click(sender As Object, e As EventArgs) Handles btnSelectPicture.Click
        ' Show the open file dialog box
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer (" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Close the window and exit the application.
        Me.Close()
    End Sub

    Private Sub btnEnlarge_Click(sender As Object, e As EventArgs) Handles btnEnlarge.Click
        ' Increases the size of the form frame.
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20
    End Sub

    Private Sub btnShrink_Click(sender As Object, e As EventArgs) Handles btnShrink.Click
        ' Decreases the size of the form frame.
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20
    End Sub

    Private Sub btnDrawBorder_Click(sender As Object, e As EventArgs) Handles btnDrawBorder.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics
        ' Clears the graphic surface with a user-chosen system color.
        objGraphics.Clear(SystemColors.Control)
        ' Draws a blue border around the picture box.
        objGraphics.DrawRectangle(Pens.Blue, picShowPicture.Left - 1, picShowPicture.Top - 1, picShowPicture.Width + 1, picShowPicture.Height + 1)
        objGraphics.Dispose()
    End Sub

    Private Sub picShowPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles picShowPicture.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y
    End Sub

    Private Sub picShowPicture_MouseLeave(sender As Object, e As EventArgs) Handles picShowPicture.MouseLeave
        lblX.Text = ""
        lblY.Text = ""
    End Sub

    Private Sub ViewerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblX.Text = ""
        lblY.Text = ""
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        OptionForm.ShowDialog()
    End Sub
End Class
