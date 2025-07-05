Public Class frmMain

    Public dm As New Meter
    Public activities As New ActivityCollection(Of Activity)
    Private groups As New Dictionary(Of String, ListViewGroup)
    Private activityGroups As New Dictionary(Of String, ListViewGroup)
    Private attachmentGroups As New Dictionary(Of String, ListViewGroup)
    Private act As Activity
    Private highlightToday As Boolean = False

    Private timingActivity As Activity


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loadHabitTracker()
        loadList()

        'If activities.Count = 0 Then
        If act Is Nothing Then
            'Panel1.BringToFront()
            'Panel1.Show()
            lblActiveProject.Text = "Welcome to " & Application.ProductName & "!"
        Else
            'Panel1.Hide()
            lstProjects.SelectedIndices.Clear()
            lstProjects.SelectedIndices.Add(0)
        End If

        If My.Computer.FileSystem.FileExists("hours_data.xml") Then
            'Try
            LoadData()
            'Catch ex As Exception
            '    msgb()
            'End Try
        End If
        'SplitContainer1.SplitterDistance = 999

        ShowCommentsToolStripMenuItem_Click()
    End Sub

    Private Sub UpdateActivityHighlight(ByVal act As Activity)
        Dim doneToday As Boolean = False
        Dim inactive As Boolean = True
        For Each item As ListViewItem In lstProjects.Items
            Dim a As Activity = CType(item.Tag, Activity)
            If a.Name = act.Name Then
                item.ForeColor = Color.Black
                'If highlightInactive Then

                For Each e As Session In a.Events
                    If e.EndTime > Today.Subtract(New TimeSpan(7, 0, 0, 0)) Then
                        inactive = False
                        Exit For
                    End If
                Next
                If inactive Then
                    'item.ForeColor = SystemColors.GrayText
                    ' End if
                ElseIf highlightToday Then
                    doneToday = False
                    For Each e As Session In a.Events
                        If (e.StartTime.Date = Today) Then
                            doneToday = True
                            Exit For
                        End If
                        If (e.StartTime.Date = Today.AddDays(-1) Or e.StartTime.Date = Today.AddDays(-2)) Then
                            item.ForeColor = Color.Blue
                        End If
                    Next
                    If doneToday Then
                        item.ForeColor = Color.Teal
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        timingActivity.stopTiming()

        btnPause.Enabled = False
        btnStart.Enabled = True
        'lstProjects.Enabled = True
        picRecording.Visible = False
        'ProgressBar1.Visible = False

        'Label1.Text = act.

        'Label4.Text = act.getTotalOnDay(Date.Today).ToString

        UpdateActivityHighlight(timingActivity)

        'loadList()
        'For Each item As ListViewItem In viewProjects.Items
        '    If item.Tag.Equals(act) Then
        '        item.ForeColor = 
        '    End If
        'Next

        act = timingActivity
        loadActivityUX()

        Me.Text = Application.ProductName
        Me.Icon = My.Resources.brick

        SaveData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        timingActivity = act
        timingActivity.startTiming()
        btnStart.Enabled = False
        btnPause.Enabled = True
        'ListBox1.Enabled = False
        'lstProjects.Enabled = False

        picRecording.Visible = True
        'ProgressBar1.Visible = True

        Me.Text = act.Name & " - " & Application.ProductName

        'Dim Hicon As IntPtr = My.Resources.hourglass.GetHicon()
        'Dim myNewIcon As Icon = Icon.FromHandle(Hicon)
        'Me.Icon = myNewIcon
    End Sub

    Private Sub addProject(ByVal name As String)
        If name.Count > 0 Then
            Dim item As ListViewItem = lstProjects.Items.Add(name)
            '            ListBox1.Items.Add(name)

            Dim n As New Activity
            n.Name = name
            activities.Add(n)

            item.Tag = n

            'Panel1.Hide()

            If btnStart.Enabled Then
                act = n
                lstProjects.SelectedItems.Clear()
                item.Selected = True
                'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            End If

            'Dim s As New Session(Now, Now)
            's.Comment = "Created the new project"
            's.Rating = 3
            'act.Events.Add(s)

            loadActivityUX()

            SaveData()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProject.Click
        Dim name As String = InputBox("Enter a name for this project.", "Add Project")
        addProject(name)
    End Sub

    Private Sub loadActivityUX()
        If act Is Nothing Then
            Exit Sub
        End If
        If activities.Count > 0 Then
            'txtTimeToday.Text = act.getTotalOnDay(Date.Today).ToString
            txtTimeTotal.Text = "Total time: " & act.getTotalTime().ToString("hh\:mm")
            lblActiveProject.Text = act.Name

            groups.Clear()

            lstSessions.BeginUpdate()

            lstSessions.Items.Clear()

            Dim ratingSum As Int32 = 0
            Dim ratedSessionScales As Int32 = 0
            Dim avgRating As Double

            Dim recentSessionsExist As Boolean = False

            For Each s As Session In act.Events
                If s.Rating > 0 Then
                    ratingSum += s.Rating
                    ratedSessionScales += frmSession.barRating.Maximum
                End If
                If Not recentSessionsExist Then
                    If Today.Subtract(New TimeSpan(7, 0, 0, 0)) < s.EndTime Then
                        recentSessionsExist = True
                    End If
                End If

                Dim n As New ListViewItem
                'n.Text = s.StartTime.ToString
                n.Text = s.StartTime.ToString("t") & ": " & Math.Round(s.TimeSpan.TotalMinutes) & " minutes"
                n.Tag = s
                n.ImageIndex = 0

                n.ToolTipText = CStr(chunk(s.Comment, 40))
                'If s.Rating > 0 Then
                '    If s.Comment.Count > 0 Then
                '        n.ToolTipText &= Environment.NewLine & Environment.NewLine
                '    End If
                '    n.ToolTipText &= "Rating: " & s.Rating
                'End If

                If Not groups.ContainsKey(s.StartTime.ToShortDateString) Then
                    Dim g As New ListViewGroup(s.StartTime.ToShortDateString)
                    groups.Add(s.StartTime.ToShortDateString, g)
                    g.HeaderAlignment = HorizontalAlignment.Center
                    lstSessions.Groups.Insert(0, g)
                End If
                n.Group = groups.Item(s.StartTime.ToShortDateString)

                If s.Comment.Count > 0 Or s.Rating > 0 Then
                    n.ImageIndex = 1
                End If

                If s.Comment.Count > 0 And Not DurationViewToolStripMenuItem.Checked Then
                    n.Text = n.ToolTipText
                    n.ToolTipText = s.StartTime.ToShortTimeString & " - " & s.EndTime.ToShortTimeString
                    n.ImageIndex = 2
                End If

                If n.ImageIndex = 0 Then
                    n.ToolTipText = "Rate or comment on this session"
                End If
                n.ToolTipText &= vbNewLine & s.EndTime.Subtract(s.StartTime).ToString("hh\:mm\:ss")
                lstSessions.Items.Add(n)
            Next

            avgRating = Math.Round(ratingSum / ratedSessionScales, 2) * frmSession.barRating.Maximum

            lstSessions.EndUpdate()
        End If
    End Sub


    Private Sub viewProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProjects.ItemSelectionChanged
        lstProjects.BeginUpdate()

        If sender.Equals(lstProjects) Then
            If lstProjects.SelectedItems.Count > 0 Then
                act = CType(lstProjects.SelectedItems(0).Tag, Activity)
            End If
        End If

        loadActivityUX()
        lstProjects.EndUpdate()
    End Sub

    Private Sub loadList()
        lstProjects.BeginUpdate()
        Dim index As Integer = -1
        Try
            index = lstProjects.SelectedIndices(0)
        Catch ex As Exception

        End Try

        lstProjects.Items.Clear()
        lstProjects.Groups.Clear()
        activityGroups.Clear()

        For Each a As Activity In activities
            Dim activityItem As New ListViewItem
            activityItem.Text = a.Name
            activityItem.Tag = a

            If a.Category Is Nothing Or a.Category = "" Then
                'viewProjects.Items.Add(activityItem)
            ElseIf activityGroups.ContainsKey(a.Category) Then
                'activityItem.Group = activityGroups(a.Category)
                activityItem.Group = activityGroups(a.Category)

            Else
                Dim group As New ListViewGroup(a.Category)
                activityGroups.Add(a.Category, group)
                activityItem.Group = group
                lstProjects.Groups.Add(group)

                'viewProjects.Items.Add(activityItem)
            End If

            lstProjects.Items.Add(activityItem)

            UpdateActivityHighlight(a)

            lstProjects.Columns(0).Width = -2
        Next
        If lstProjects.Items.Count > 0 Then
            lstProjects.EnsureVisible(0)
        End If
        Try
            lstProjects.SelectedIndices.Clear()
            lstProjects.SelectedIndices.Add(index)
        Catch ex As Exception

        End Try
        'Panel1.Visible = Not activities.Count > 0
        lstProjects.EndUpdate()
    End Sub

    Private Sub LabellblActiveProject_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        If lstProjects.SelectedItems.Count > 0 Then

            Dim newName As String = InputBox("Enter the name for the activity.", "Set Activity Name", lblActiveProject.Text)
            If newName.Count > 0 Then
                act.Name = newName
                loadList()
            End If

        End If

    End Sub

    Private Sub lstSessions_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSessions.ItemActivate
        If lstSessions.SelectedItems.Count > 0 Then
            Dim frm As New frmSession
            frm.loadSessionData(CType(lstSessions.SelectedItems(0).Tag, Session))
            frm.ShowDialog()
            If CBool(frm.saved) Then
                UpdateActivityHighlight(act)
                loadActivityUX()
                SaveData()
            End If
        End If
    End Sub

    Private Sub LoadData() Handles btnLoadData.Click
        'TODO: sync activities so that it persists current session
        Dim sl As New Filesystem
        'Try
        If Not act Is Nothing Then
            If act.beingTimed = True Then
                Dim activeName As String = act.Name
                Dim activeStart As Date = act.TimerBegin
                activities = sl.LoadFromXML("hours_data.xml")
                Dim aFound As Boolean = False
                For Each newAct As Activity In activities

                    If newAct.Name = activeName Then
                        aFound = True
                        act = newAct
                        timingActivity = newAct

                        timingActivity.startTiming()
                        timingActivity.TimerBegin = activeStart
                        loadActivityUX()
                        MsgBox("The currently timed activity has been reloaded.", MsgBoxStyle.Information, "Notice")
                        Exit For
                    End If
                Next
                If Not aFound Then
                    MsgBox("The activity you are currently timing does not exist in the target file. We'll add it to the file, but keep a watch out for unintended behavior.", MsgBoxStyle.Exclamation, "yipe")
                    activities.Add(act)
                End If
            End If
        Else
            activities = sl.LoadFromXML("hours_data.xml")
        End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
        loadList()
        loadActivityUX()
    End Sub

    Private Sub SaveData() Handles btnSave.Click, btnRetrySave.LinkClicked
        FileSystemWatcher1.EnableRaisingEvents = False
        Try
            Dim sl As New Filesystem
            sl.SaveToXML(activities, "hours_data.xml")
            'Process.Start("notepad", "hours_data.xml")
            Panel2.Hide()
        Catch ex As Exception
            Panel2.Show()
        End Try
        FileSystemWatcher1.EnableRaisingEvents = True
    End Sub

    Private Function chunk(ByVal text As String, ByVal maxint As Integer) As String
        Dim t As String = ""

        If text = "" Then
            Return text
        End If

        Dim counter As Int32 = 1
        ' make sure this works!
        Dim previousChar As Char = CChar("")
        For Each c As Char In text
            If c = " " And counter > maxint Then
                t &= Environment.NewLine
                counter = 1
            ElseIf c = Environment.NewLine Then
                counter = 1
            End If
            counter += 1

            t &= c
            previousChar = c
        Next

        Return t.Replace(vbNewLine & " ", vbNewLine)
    End Function

    Private Sub UseGroupsToolStripMenuItem_Click() Handles UseGroupsToolStripMenuItem.Click
        lstSessions.ShowGroups = UseGroupsToolStripMenuItem.Checked
        loadActivityUX()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        UseGroupsToolStripMenuItem.Checked = lstSessions.ShowGroups
    End Sub

    Private Sub ShowCommentsToolStripMenuItem_Click() Handles DurationViewToolStripMenuItem.Click
        loadActivityUX()
    End Sub

    Private Sub frmMain_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        lstSessions.Refresh()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If act Is Nothing Then
            Exit Sub
        End If
        If act.beingTimed Then
            act.stopTiming()
        End If
        If Not timingActivity Is Nothing Then
            If timingActivity.beingTimed Then
                timingActivity.stopTiming()
            End If
        End If
        SaveData()
    End Sub

    Private Sub lstSessions_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lstSessions.ItemSelectionChanged, lstSessions.LostFocus
        If lstSessions.SelectedItems.Count > 0 Then
            Dim d As New TimeSpan
            Dim s As Session
            For Each i As ListViewItem In lstSessions.SelectedItems
                s = CType(i.Tag, Session)
                d = d.Add(s.TimeSpan)
            Next
            'txtTimeToday.Text = d.ToString("hh\:mm\:ss")
        Else
            'txtTimeToday.Text = act.getTotalOnDay(Date.Today).ToString
        End If
    End Sub

    Private Sub btnCSVExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim savey As New SaveFileDialog
        savey.Title = "Export as CSV"
        savey.FileName = ""
        savey.RestoreDirectory = True
        savey.Filter = "CSV file|*.csv|All files|*.*"
        If savey.ShowDialog = DialogResult.OK Then
            Dim u As New Filesystem
            u.SaveToCSV(activities, savey.FileName)
        End If
    End Sub

    Private Sub btnCommentView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DurationViewToolStripMenuItem.Checked = Not DurationViewToolStripMenuItem.Checked
        ShowCommentsToolStripMenuItem_Click()
    End Sub

    Private Sub lstProjects_ItemMouseHover(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemMouseHoverEventArgs)
        If MouseButtons = Windows.Forms.MouseButtons.Left Then
            e.Item.Selected = True
        End If
    End Sub

    Private Sub lstProjects_AfterLabelEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LabelEditEventArgs)
        If e.Label Is Nothing Then
            Exit Sub
        End If
        If e.CancelEdit = True Or e.Label.Count < 1 Then
            e.CancelEdit = True
            Exit Sub
        End If
        Dim p As Activity = CType(lstProjects.Items(e.Item).Tag, Activity)
        p.Name = e.Label
        If p.Equals(act) Then
            lblActiveProject.Text = e.Label
        End If

        SaveData()
    End Sub

    Private Sub CategorizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategorizeToolStripMenuItem.Click
        
    End Sub

    Private Sub btnCategoryView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstProjects.ShowGroups = Not lstProjects.ShowGroups
    End Sub

    Private newinput As Boolean = True

    Private Sub HighlightTodayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        For Each itm As ListViewItem In lstProjects.Items
            UpdateActivityHighlight(CType(itm.Tag, Activity))
        Next
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As System.Object, e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If MsgBox("The Hours data was updated outside this program. Do you want to reload data? (This will not interrupt your session.)" & vbNewLine & "If the file was modified by mistake, select Cancel and click on the Save button to prevent loss.", CType(MsgBoxStyle.OkCancel + MsgBoxStyle.Information, MsgBoxStyle), "Reload data") = MsgBoxResult.Ok Then
            LoadData()
        End If
    End Sub

    Private Sub ListViewRefresh(ref As ListView)
        ref.BeginUpdate()

        Dim lst As New List(Of ListViewItem)

        For Each item As ListViewItem In ref.Items
            lst.Add(item)
            item.Remove()
        Next

        For Each item As ListViewItem In lst
            ref.Items.Add(item)
        Next

        ref.EndUpdate()
        'ref.Refresh()
    End Sub

    Private Sub btnPause_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnPause.MouseEnter
        If Not timingActivity Is Nothing Then
            If timingActivity.beingTimed Then
                hoveringBtn = True
                Timer2.Enabled = True
                Timer2_Tick()
            End If
        End If
    End Sub

    Private hoveringBtn As Boolean = False
    Private hoveringHourglass As Boolean = False

    Private Sub btnPause_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnPause.MouseLeave
        hoveringBtn = False
        btnPause.Text = "Pause"
    End Sub

    Private Function getTimingDuration() As String
        Dim dur As TimeSpan = Now.Subtract(timingActivity.TimerBegin)
        Dim z As String = ""
        If dur.Minutes < 10 Then
            z = "0"
        End If
        'Dim zz As String = ""
        'If dur.Seconds < 10 Then
        '    zz = "0"
        'End If
        Return Math.Floor(dur.TotalHours) & ":" & z & dur.Minutes '& ":" & zz & dur.Seconds
    End Function

    Private Sub Timer2_Tick() Handles Timer2.Tick
        If hoveringBtn Then
            btnPause.Text = getTimingDuration()
        End If
        If hoveringHourglass Then
            If Not ToolTip1.GetToolTip(picRecording) = getTimingDuration() Then
                ToolTip1.SetToolTip(picRecording, getTimingDuration())
            End If
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles picRecording.Click
        If Not ReferenceEquals(act, timingActivity) Then
            act = timingActivity
            loadActivityUX()
        End If
    End Sub

    Private Sub time1_ValueChanged(sender As System.Object, e As System.EventArgs)
        Timer1.Enabled = True
    End Sub

    Private Sub picRecording_MouseEnter(sender As System.Object, e As System.EventArgs) Handles picRecording.MouseEnter
        If Not timingActivity Is Nothing Then
            If timingActivity.beingTimed Then
                hoveringHourglass = True
                Timer2.Enabled = True
                Timer2_Tick()
            End If
        End If
    End Sub

    Private Sub picRecording_MouseLeave(sender As System.Object, e As System.EventArgs) Handles picRecording.MouseLeave
        hoveringHourglass = False
        ToolTip1.SetToolTip(picRecording, "")
    End Sub

    Private Sub picRecording_DoubleClick(sender As System.Object, e As System.EventArgs) Handles picRecording.DoubleClick
        If Not InputBox("Enter the number of minutes to offset the start time.", "Start earlier?") = "" Then

        End If
    End Sub

    Private Sub AddProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProjectToolStripMenuItem.Click
        addProject("New Project")
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = SystemColors.ControlDark
    End Sub

    Private Sub lstProjects_AfterLabelEdit_1(sender As Object, e As LabelEditEventArgs) Handles lstProjects.AfterLabelEdit
        Dim obj As Activity = CType(lstProjects.SelectedItems(0).Tag, Activity)
        obj.Name = e.Label
        If obj.Equals(act) Then
            lblActiveProject.Text = act.Name
        End If
    End Sub

    Private Sub DeleteProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProjectToolStripMenuItem.Click
        Dim proj As Activity = CType(lstProjects.SelectedItems(0).Tag, Activity)
        'todo
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'If lstProjects.SelectedItems.Count > 0 Then
        '    Dim activ As Activity = CType(lstProjects.SelectedItems(0).Tag, Activity)
        Dim activ As Activity = act
        Dim s As String = InputBox("What category (this is case sensitive)?", "Set category for " & activ.Name, activ.Category)
        If s <> "" Then
                activ.Category = s
                lstSessions.ShowGroups = True
                loadList()
            End If
            SaveData()
        'End If
    End Sub

    Private Sub SaveData(sender As Object, e As EventArgs) Handles btnSave.Click, btnRetrySave.LinkClicked

    End Sub

    Private Sub btnTarget_Click(sender As Object, e As EventArgs) Handles btnTarget.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
