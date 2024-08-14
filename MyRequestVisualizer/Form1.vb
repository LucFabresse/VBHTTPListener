Public Class Form1
    Private isListenerRunning As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyHttpListenerModule.RequestReceived, AddressOf UpdateTextBox
        startStopHttpServer()
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        startStopHttpServer()
    End Sub

    Private Sub startStopHttpServer()
        If isListenerRunning Then
            MyHttpListenerModule.StopListener()
            btnStartStop.Text = "Start"
            btnStartStop.BackColor = Color.Green
        Else
            MyHttpListenerModule.StartListener()
            btnStartStop.Text = "Stop"
            btnStartStop.BackColor = Color.Red
        End If
        isListenerRunning = Not isListenerRunning
    End Sub

    Private Sub UpdateTextBox(requestData As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String)(AddressOf UpdateTextBox), requestData)
        Else
            txtRequests.AppendText(requestData & Environment.NewLine)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRequests.Clear()
    End Sub
End Class
