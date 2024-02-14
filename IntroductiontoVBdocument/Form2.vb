Public Class objectdemoForm
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub FontRadioButtons_CheckedChanged(sender As Object, e As EventArgs) _
    Handles garamondButton.CheckedChanged, magnetoButton.CheckedChanged

        If garamondButton.Checked Then
            sampleBox.Font = New Font("Garamond", sampleBox.Font.Size)
        ElseIf magnetoButton.Checked Then
            sampleBox.Font = New Font("Magneto", sampleBox.Font.Size)
        ElseIf tahomaButton.Checked Then
            sampleBox.Font = New Font("Tahoma", sampleBox.Font.Size)
        End If
    End Sub

    Private Sub tahomaButton_CheckedChanged(sender As Object, e As EventArgs) Handles tahomaButton.CheckedChanged

    End Sub

    Private Sub styleBox_Enter(sender As Object, e As EventArgs) Handles italicBox.CheckedChanged,
        boldBox.CheckedChanged, bolditalicBox.CheckedChanged

        Dim style As FontStyle = FontStyle.Regular
        If italicBox.Checked Then style = style Or FontStyle.Italic
        If boldBox.Checked Then style = style Or FontStyle.Bold
        If bolditalicBox.Checked Then style = style Or FontStyle.Bold Or FontStyle.Italic

        sampleBox.Font = New Font(sampleBox.Font, style)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles greenButton.CheckedChanged,
        blueButton.CheckedChanged, redButton.CheckedChanged

        If greenButton.Checked Then
            sampleBox.ForeColor = Color.Green
        ElseIf blueButton.Checked Then
            sampleBox.ForeColor = Color.Blue
        ElseIf redButton.Checked Then
            sampleBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub pictureButton_Click(sender As Object, e As EventArgs) Handles pictureButton.Click

        Using ofd As New OpenFileDialog
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub exitButton2_Click(sender As Object, e As EventArgs) Handles exitButton2.Click

        Me.Close()
    End Sub


End Class