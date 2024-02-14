Public Class welcomingform



    Private Sub welcomingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub loadObj_Click(sender As Object, e As EventArgs) Handles loadObj.Click

        Dim demoForm As New objectdemoForm
        demoForm.Show()
    End Sub


    Private Sub extbtn_Click(sender As Object, e As EventArgs) Handles extbtn.Click
        Me.Close()
    End Sub
End Class
