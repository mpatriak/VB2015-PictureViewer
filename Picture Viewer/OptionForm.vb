Public Class OptionForm
    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ViewerForm.Icon
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class