Public Class Session
    Public Property StartTime As New DateTime
    Public Property EndTime As New DateTime
    Public Property Comment As String = ""
    Public Property Rating As Integer = 0
    Public Property Parent As List(Of Session)

    Public Sub New(ByVal start As DateTime, ByVal endtime As DateTime)
        Me.StartTime = start
        Me.EndTime = endtime
    End Sub

    Public Function TimeSpan() As TimeSpan
        Return EndTime - StartTime
    End Function

    Public Overrides Function ToString() As String
        Return TimeSpan.ToString
    End Function

    Public Sub Destroy()
        'Me.EndTime = Me.StartTime
        Parent.Remove(Me)
    End Sub

End Class
