<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class objectdemoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        displayBox = New GroupBox()
        sampleBox = New TextBox()
        fontBox = New GroupBox()
        garamondButton = New RadioButton()
        magnetoButton = New RadioButton()
        tahomaButton = New RadioButton()
        PictureBox1 = New PictureBox()
        styleBox = New GroupBox()
        bolditalicBox = New CheckBox()
        boldBox = New CheckBox()
        italicBox = New CheckBox()
        GroupBox1 = New GroupBox()
        greenButton = New RadioButton()
        blueButton = New RadioButton()
        redButton = New RadioButton()
        pictureButton = New Button()
        exitButton2 = New Button()
        displayBox.SuspendLayout()
        fontBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        styleBox.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' displayBox
        ' 
        displayBox.Controls.Add(sampleBox)
        displayBox.Location = New Point(12, 12)
        displayBox.Name = "displayBox"
        displayBox.Size = New Size(200, 100)
        displayBox.TabIndex = 0
        displayBox.TabStop = False
        displayBox.Text = "Display Test"
        ' 
        ' sampleBox
        ' 
        sampleBox.Location = New Point(28, 47)
        sampleBox.Name = "sampleBox"
        sampleBox.Size = New Size(100, 23)
        sampleBox.TabIndex = 1
        sampleBox.Text = "Sample Test"
        ' 
        ' fontBox
        ' 
        fontBox.Controls.Add(garamondButton)
        fontBox.Controls.Add(magnetoButton)
        fontBox.Controls.Add(tahomaButton)
        fontBox.Location = New Point(344, 25)
        fontBox.Name = "fontBox"
        fontBox.Size = New Size(420, 100)
        fontBox.TabIndex = 1
        fontBox.TabStop = False
        fontBox.Text = "Font"
        ' 
        ' garamondButton
        ' 
        garamondButton.AutoSize = True
        garamondButton.Location = New Point(26, 34)
        garamondButton.Name = "garamondButton"
        garamondButton.Size = New Size(81, 19)
        garamondButton.TabIndex = 2
        garamondButton.TabStop = True
        garamondButton.Text = "Garamond"
        garamondButton.UseVisualStyleBackColor = True
        ' 
        ' magnetoButton
        ' 
        magnetoButton.AutoSize = True
        magnetoButton.Location = New Point(163, 35)
        magnetoButton.Name = "magnetoButton"
        magnetoButton.Size = New Size(73, 19)
        magnetoButton.TabIndex = 3
        magnetoButton.TabStop = True
        magnetoButton.Text = "Magneto"
        magnetoButton.UseVisualStyleBackColor = True
        ' 
        ' tahomaButton
        ' 
        tahomaButton.AutoSize = True
        tahomaButton.Location = New Point(317, 35)
        tahomaButton.Name = "tahomaButton"
        tahomaButton.Size = New Size(67, 19)
        tahomaButton.TabIndex = 4
        tahomaButton.TabStop = True
        tahomaButton.Text = "Tahoma"
        tahomaButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 170)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 158)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' styleBox
        ' 
        styleBox.Controls.Add(bolditalicBox)
        styleBox.Controls.Add(boldBox)
        styleBox.Controls.Add(italicBox)
        styleBox.Location = New Point(344, 170)
        styleBox.Name = "styleBox"
        styleBox.Size = New Size(132, 186)
        styleBox.TabIndex = 3
        styleBox.TabStop = False
        styleBox.Text = "Font Style"
        ' 
        ' bolditalicBox
        ' 
        bolditalicBox.AutoSize = True
        bolditalicBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        bolditalicBox.Location = New Point(11, 127)
        bolditalicBox.Name = "bolditalicBox"
        bolditalicBox.Size = New Size(89, 21)
        bolditalicBox.TabIndex = 2
        bolditalicBox.Text = "Bold Italic"
        bolditalicBox.UseVisualStyleBackColor = True
        ' 
        ' boldBox
        ' 
        boldBox.AutoSize = True
        boldBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        boldBox.Location = New Point(11, 74)
        boldBox.Name = "boldBox"
        boldBox.Size = New Size(55, 21)
        boldBox.TabIndex = 1
        boldBox.Text = "Bold"
        boldBox.UseVisualStyleBackColor = True
        ' 
        ' italicBox
        ' 
        italicBox.AutoSize = True
        italicBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        italicBox.Location = New Point(11, 33)
        italicBox.Name = "italicBox"
        italicBox.Size = New Size(53, 21)
        italicBox.TabIndex = 0
        italicBox.Text = "Italic"
        italicBox.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(greenButton)
        GroupBox1.Controls.Add(blueButton)
        GroupBox1.Controls.Add(redButton)
        GroupBox1.Location = New Point(528, 170)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(165, 173)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' greenButton
        ' 
        greenButton.AutoSize = True
        greenButton.Location = New Point(15, 33)
        greenButton.Name = "greenButton"
        greenButton.Size = New Size(56, 19)
        greenButton.TabIndex = 5
        greenButton.TabStop = True
        greenButton.Text = "&Green"
        greenButton.UseVisualStyleBackColor = True
        ' 
        ' blueButton
        ' 
        blueButton.AutoSize = True
        blueButton.Location = New Point(15, 76)
        blueButton.Name = "blueButton"
        blueButton.Size = New Size(48, 19)
        blueButton.TabIndex = 6
        blueButton.TabStop = True
        blueButton.Text = "&Blue"
        blueButton.UseVisualStyleBackColor = True
        ' 
        ' redButton
        ' 
        redButton.AutoSize = True
        redButton.Location = New Point(15, 127)
        redButton.Name = "redButton"
        redButton.Size = New Size(45, 19)
        redButton.TabIndex = 7
        redButton.TabStop = True
        redButton.Text = "&Red"
        redButton.UseVisualStyleBackColor = True
        ' 
        ' pictureButton
        ' 
        pictureButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pictureButton.Location = New Point(40, 344)
        pictureButton.Name = "pictureButton"
        pictureButton.Size = New Size(100, 43)
        pictureButton.TabIndex = 5
        pictureButton.Text = "&Load Picture"
        pictureButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton2
        ' 
        exitButton2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exitButton2.Location = New Point(585, 349)
        exitButton2.Name = "exitButton2"
        exitButton2.Size = New Size(91, 38)
        exitButton2.TabIndex = 6
        exitButton2.Text = "E&XIT"
        exitButton2.UseVisualStyleBackColor = True
        ' 
        ' objectdemoForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitButton2)
        Controls.Add(pictureButton)
        Controls.Add(GroupBox1)
        Controls.Add(styleBox)
        Controls.Add(PictureBox1)
        Controls.Add(fontBox)
        Controls.Add(displayBox)
        Name = "objectdemoForm"
        Text = "Object Demonstrations"
        displayBox.ResumeLayout(False)
        displayBox.PerformLayout()
        fontBox.ResumeLayout(False)
        fontBox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        styleBox.ResumeLayout(False)
        styleBox.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents displayBox As GroupBox
    Friend WithEvents sampleBox As TextBox
    Friend WithEvents fontBox As GroupBox
    Friend WithEvents garamondButton As RadioButton
    Friend WithEvents magnetoButton As RadioButton
    Friend WithEvents tahomaButton As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents styleBox As GroupBox
    Friend WithEvents bolditalicBox As CheckBox
    Friend WithEvents boldBox As CheckBox
    Friend WithEvents italicBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents greenButton As RadioButton
    Friend WithEvents blueButton As RadioButton
    Friend WithEvents redButton As RadioButton
    Friend WithEvents pictureButton As Button
    Friend WithEvents exitButton2 As Button
End Class
