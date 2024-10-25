Public Class Meter
    Public Property Start As DateTime
    Public Property Finish As DateTime
    Public Property Description As String


    Public Sub New()
        Start = Today.AddHours(10)
        Finish = Today.AddHours(22)
    End Sub

    Public Sub New(s As DateTime, f As DateTime)
        Start = s
        Finish = f
    End Sub

    Public Function StartMinsFrom0() As Integer
        Return CInt(Start.TimeOfDay.TotalMinutes)
    End Function

    Public Function EndMinsFrom0() As Integer
        Return CInt(Finish.TimeOfDay.TotalMinutes)
    End Function

    Public Function NowMins() As Integer
        Return CInt(Now.TimeOfDay.TotalMinutes)
    End Function

    Public Function GetPercent() As Double
        If NowMins() < StartMinsFrom0() Then
            Return 0
        ElseIf NowMins() > EndMinsFrom0() Then
            Return 1
        End If


        Dim percent As Double = (NowMins() - StartMinsFrom0()) / (EndMinsFrom0() - StartMinsFrom0())

        Return percent
    End Function

    Public Function GetProgress(max As Integer) As Double
        Return Me.GetPercent * max
    End Function
End Class
