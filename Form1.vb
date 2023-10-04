Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCheckLen_Click(sender As Object, e As EventArgs) Handles btnCheckLen.Click
        Dim phrase As String
        phrase = txtEnterAPhrase.Text
        lblPhraseLength.Text = "The length of the phrase you entered is " & Len(phrase)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub
End Class
