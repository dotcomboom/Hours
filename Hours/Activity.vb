Public Class Activity

    Public Property Name As String
    Public Property Category As String = ""
    Public Property Attachments As New List(Of Attachment)
    Public Property Index As Integer
    Public Property Events As New List(Of Session)
    Protected Friend beingTimed As Boolean = False
    Public TimerBegin As New DateTime
    Public TimerEnd As New DateTime

    Public Function getTotalTime() As TimeSpan
        Dim total As New TimeSpan(0)

        For Each e As Session In Events
            total = total.Add(e.TimeSpan)
        Next

        Return total
    End Function

    Public Function getTotalOnDay(ByVal dated As DateTime) As TimeSpan
        Dim total As New TimeSpan(0)

        For Each e As Session In Events
            ' check if day thing started after day 
            If e.StartTime.Subtract(dated).Ticks > 0 Then
                total = total.Add(e.TimeSpan)
            End If
        Next

        Return total
    End Function

    Public Sub startTiming()
        If beingTimed Then
            Throw New Exception
        End If

        TimerBegin = Now
        beingTimed = True
    End Sub

    Public Sub stopTiming()
        If Not beingTimed Then
            Throw New Exception
        End If

        TimerEnd = Now
        beingTimed = False

        createEvent(TimerBegin, TimerEnd)
    End Sub

    Private Sub createEvent(ByVal beginTime As Date, ByVal endTime As Date)
        Dim s As New Session(beginTime, endTime)
        s.Parent = Me.Events
        Events.Add(s)
    End Sub

    Public Function getFriendlyTotalTime() As String
        Dim total As TimeSpan = getTotalTime()

        Return total.ToString()
    End Function
End Class
