Imports System.Net
Imports System.Threading

Module MyHttpListenerModule
    Private listener As HttpListener
    Private listenerThread As Thread
    Public Event RequestReceived(ByVal requestData As String)

    Public Sub StartListener()
        If listener IsNot Nothing AndAlso listener.IsListening Then
            Return
        End If

        listener = New HttpListener()
        listener.Prefixes.Add("http://localhost:8080/")
        listenerThread = New Thread(AddressOf ListenForRequests)
        listenerThread.IsBackground = True
        listenerThread.Start()
    End Sub

    Public Sub StopListener()
        If listener IsNot Nothing AndAlso listener.IsListening Then
            listener.Stop()
            listenerThread.Join()
            listenerThread = Nothing
        End If
    End Sub

    Private Function analyzeRequest(request As HttpListenerRequest) As String
        ' Get the requested URL
        Dim requestData As String = "Request URL: " & request.Url.ToString() & Environment.NewLine

        ' Get and format the request headers
        requestData = requestData & "Request Headers: " & Environment.NewLine
        For Each headerKey As String In request.Headers.AllKeys
            requestData &= $"{headerKey}: {request.Headers(headerKey)}" & Environment.NewLine
        Next

        requestData = requestData & Environment.NewLine & "Request Content: " & Environment.NewLine
        Using reader = New IO.StreamReader(request.InputStream, request.ContentEncoding)
            For i As Integer = 0 To 2
                If reader.EndOfStream Then Exit For
                requestData &= reader.ReadLine() & Environment.NewLine
            Next
        End Using

        requestData = requestData & Environment.NewLine & "---------------------" & Environment.NewLine

        Return requestData
    End Function
    Private Sub ListenForRequests()
        listener.Start()
        Try
            While listener.IsListening
                Dim context As HttpListenerContext = listener.GetContext()
                Dim request As HttpListenerRequest = context.Request


                Dim stringTodisplay As String = analyzeRequest(request)
                RaiseEvent RequestReceived(stringTodisplay)

                Dim response As HttpListenerResponse = context.Response
                Dim responseString As String = "Request received  >" & Environment.NewLine & stringTodisplay & Environment.NewLine & "<"
                Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(responseString)
                response.ContentLength64 = buffer.Length
                response.OutputStream.Write(buffer, 0, buffer.Length)
                response.OutputStream.Close()
            End While
        Catch ex As HttpListenerException
            ' Handle exception
        End Try
    End Sub
End Module
