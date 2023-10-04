<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnClose = New Button()
        btnCheckLen = New Button()
        lblEnterAPhrase = New Label()
        txtEnterAPhrase = New TextBox()
        lblHeading = New Label()
        lblPhraseLength = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(322, 371)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(141, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCheckLen
        ' 
        btnCheckLen.Location = New Point(322, 279)
        btnCheckLen.Name = "btnCheckLen"
        btnCheckLen.Size = New Size(141, 29)
        btnCheckLen.TabIndex = 0
        btnCheckLen.Text = "Check Length"
        btnCheckLen.UseVisualStyleBackColor = True
        ' 
        ' lblEnterAPhrase
        ' 
        lblEnterAPhrase.AutoSize = True
        lblEnterAPhrase.Location = New Point(126, 192)
        lblEnterAPhrase.Name = "lblEnterAPhrase"
        lblEnterAPhrase.Size = New Size(103, 20)
        lblEnterAPhrase.TabIndex = 1
        lblEnterAPhrase.Text = "Enter a phrase"
        ' 
        ' txtEnterAPhrase
        ' 
        txtEnterAPhrase.Location = New Point(311, 192)
        txtEnterAPhrase.Name = "txtEnterAPhrase"
        txtEnterAPhrase.Size = New Size(373, 27)
        txtEnterAPhrase.TabIndex = 2
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = SystemColors.HotTrack
        lblHeading.Location = New Point(82, 55)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(602, 29)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Count the number of characters in a Phrase"
        ' 
        ' lblPhraseLength
        ' 
        lblPhraseLength.AutoSize = True
        lblPhraseLength.Location = New Point(322, 330)
        lblPhraseLength.Name = "lblPhraseLength"
        lblPhraseLength.Size = New Size(0, 20)
        lblPhraseLength.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtEnterAPhrase)
        Controls.Add(lblHeading)
        Controls.Add(lblPhraseLength)
        Controls.Add(lblEnterAPhrase)
        Controls.Add(btnCheckLen)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Calculate the characters in a phrase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCheckLen As Button
    Friend WithEvents lblEnterAPhrase As Label
    Friend WithEvents txtEnterAPhrase As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPhraseLength As Label
End Class
