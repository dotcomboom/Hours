Public Class frmWipDayMeter
    Private dm As New Meter(frmMain.dm.Start, frmMain.dm.Finish)

    Private Sub frmDayMeter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timeStart.Value = frmMain.dm.Start
        timeFinish.Value = frmMain.dm.Finish
        progressMeter.Value = CInt(dm.GetProgress(100))

        lblStart.Text = CStr(dm.StartMinsFrom0)
        lblNow.Text = CStr(dm.NowMins)
        lblEnd.Text = CStr(dm.EndMinsFrom0)
    End Sub

    Private Sub DateTimePickers_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeStart.ValueChanged, timeFinish.ValueChanged
        dm.Start = timeStart.Value
        dm.Finish = timeFinish.Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        progressMeter.Value = CInt(dm.GetProgress(100))

        lblStart.Text = CStr(dm.StartMinsFrom0)
        lblNow.Text = CStr(dm.NowMins)
        lblEnd.Text = CStr(dm.EndMinsFrom0)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        frmMain.dm.Start = dm.Start
        frmMain.dm.Finish = dm.Finish
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class