Imports Tulpep.NotificationWindow
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As String
        Dim speak = CreateObject("sapi.spvoice")
        If RichTextBox1.Text = "hi" Then
            result = "Hello
"
        ElseIf RichTextBox1.Text = "name" Then
            result = "My name is vcon
"
        ElseIf RichTextBox1.Text = "time" Then
            result = TimeOfDay + "
"
        ElseIf RichTextBox1.Text = "name" Then
            result = "My name is vcon
"
        End If
        TextBox1.AppendText(result)
        If CheckBox1.Checked = True Then
            speak.speak(result)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Dim notify As New PopupNotifier
        notify.BodyColor = Color.Red
        notify.ContentColor = Color.White
        notify.TitleText = "information"
        notify.ContentText = "Check the voice to Add voice"
        notify.Popup()
    End Sub
End Class
