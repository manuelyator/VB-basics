<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomingform
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
        loadObj = New Button()
        extbtn = New Button()
        SuspendLayout()
        ' 
        ' loadObj
        ' 
        loadObj.Location = New Point(163, 209)
        loadObj.Name = "loadObj"
        loadObj.Size = New Size(164, 34)
        loadObj.TabIndex = 0
        loadObj.Text = "&Load Object Demo"
        loadObj.UseVisualStyleBackColor = True
        ' 
        ' extbtn
        ' 
        extbtn.Location = New Point(466, 215)
        extbtn.Name = "extbtn"
        extbtn.Size = New Size(120, 23)
        extbtn.TabIndex = 1
        extbtn.Text = "E&XIT"
        extbtn.UseVisualStyleBackColor = True
        ' 
        ' welcomingform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(extbtn)
        Controls.Add(loadObj)
        Name = "welcomingform"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadObj As Button
    Friend WithEvents extbtn As Button

End Class
