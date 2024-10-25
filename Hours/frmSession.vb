Public Class frmSession

    Private session As Session
    Public saved As Boolean = False
    'Private toSaveNewEndTime As Boolean = False
    'Private newEndTime As DateTime

    Public Sub loadSessionData(ByVal s As Session)
        Me.Text = "Session on " & s.StartTime.ToShortDateString
        lblStart.Text = s.StartTime.ToShortTimeString
        lblEnd.Text = s.EndTime.ToShortTimeString
        lblDuration.Text = s.TimeSpan.ToString
        barRating.Value = s.Rating
        txtComment.Text = s.Comment

        session = s
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (My.Computer.Keyboard.ShiftKeyDown And txtComment.Focused) Then
            ' Allows newlines if SHIFT is held
            txtComment.SelectedText = Environment.NewLine
        Else
            saveSessionData()
            saved = True
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub saveSessionData()
        session.Rating = barRating.Value
        session.Comment = txtComment.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dialog As MsgBoxResult = MsgBox("Forget this " & lblDuration.Text & " session?", CType(MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, MsgBoxStyle), "Delete session")
        If dialog = MsgBoxResult.Ok Then
            session.Destroy()
            saved = True
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dialog As New frmDuration
        dialog.startTime = session.StartTime
        dialog.endTime = session.EndTime
        dialog.loadTimes()
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'toSaveNewEndTime = True
            'newEndTime = dialog.endTime
            session.EndTime = dialog.endTime

            lblEnd.Text = session.EndTime.ToShortTimeString
            lblDuration.Text = session.TimeSpan.ToString
        End If
    End Sub
End Class