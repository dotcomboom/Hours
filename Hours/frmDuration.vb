Public Class frmDuration

    Public startTime As DateTime
    Public endTime As New DateTime

    Public Sub loadTimes()
        Dim range As TimeSpan = endTime - startTime
        NumericUpDown1.Value = range.Hours
        NumericUpDown2.Value = range.Minutes
        NumericUpDown3.Value = range.Seconds
        updateEndTime()
    End Sub

    Private Sub updateEndTime() Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged
        endTime = startTime.AddHours(NumericUpDown1.Value).AddMinutes(NumericUpDown2.Value).AddSeconds(NumericUpDown3.Value)
        Label5.Text = endTime.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class