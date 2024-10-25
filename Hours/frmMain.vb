Public Class frmMain

    Public dm As New Meter
    Public activities As New ActivityCollection(Of Activity)
    Private groups As New Dictionary(Of String, ListViewGroup)
    Private activityGroups As New Dictionary(Of String, ListViewGroup)
    Private attachmentGroups As New Dictionary(Of String, ListViewGroup)
    Private act As Activity
    Private highlightToday As Boolean = True

    Private timingActivity As Activity


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadHabitTracker()
        loadList()

        'If activities.Count = 0 Then
        If act Is Nothing Then
            'Panel1.BringToFront()
            'Panel1.Show()
            lblActiveProject.Text = "Welcome to Hours!"
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

        ShowCommentsToolStripMenuItem.Checked = True
        ShowCommentsToolStripMenuItem_Click()

        Dim time As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
        time1.Value = time
        time2.Value = time
        Timer1_Tick()
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
                    item.ForeColor = SystemColors.GrayText
                    ' End if
                ElseIf highlightToday Then
                    doneToday = False
                    For Each e As Session In a.Events
                        If (e.StartTime.Date = Today) Then
                            doneToday = True
                            Exit For
                        End If
                        If (e.StartTime.Date = Today.AddDays(-1)) Then
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

        Me.Text = "Hours"
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

        Me.Text = act.Name & " - Hours"

        Dim Hicon As IntPtr = My.Resources.hourglass.GetHicon()
        Dim myNewIcon As Icon = Icon.FromHandle(Hicon)
        Me.Icon = myNewIcon


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProject.Click
        Dim name As String = InputBox("Enter a name for this activity.", "Add Activity")
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

            SaveData()
        End If
    End Sub

    Private lblTracker1 As New Label
    Private lblTracker2 As New Label
    Private lblTracker3 As New Label
    Private lblTracker4 As New Label
    Private lblTracker5 As New Label
    Private lblTracker6 As New Label
    Private lblTracker7 As New Label
    Private trackerFont As Font

    Private Sub loadHabitTracker()

        trackerFont = lblTracker1.Font

        lblTracker1.Size = New Size(28, 24)
        lblTracker2.Size = New Size(28, 24)
        lblTracker3.Size = New Size(28, 24)
        lblTracker4.Size = New Size(28, 24)
        lblTracker5.Size = New Size(28, 24)
        lblTracker6.Size = New Size(28, 24)
        lblTracker7.Size = New Size(28, 24)

        Dim w As Int32 = lblTracker1.Size.Width

        lblTracker1.AutoSize = False
        lblTracker2.AutoSize = False
        lblTracker3.AutoSize = False
        lblTracker4.AutoSize = False
        lblTracker5.AutoSize = False
        lblTracker6.AutoSize = False
        lblTracker7.AutoSize = False

        lblTracker1.Location = New Point(picRecording.Location.X, picRecording.Location.Y + picRecording.Size.Height + 4)
        lblTracker2.Location = New Point(lblTracker1.Location.X + w, lblTracker1.Location.Y)
        lblTracker3.Location = New Point(lblTracker2.Location.X + w, lblTracker1.Location.Y)
        lblTracker4.Location = New Point(lblTracker3.Location.X + w, lblTracker1.Location.Y)
        lblTracker5.Location = New Point(lblTracker4.Location.X + w, lblTracker1.Location.Y)
        lblTracker6.Location = New Point(lblTracker5.Location.X + w, lblTracker1.Location.Y)
        lblTracker7.Location = New Point(lblTracker6.Location.X + w, lblTracker1.Location.Y)

        lblTracker1.BorderStyle = BorderStyle.Fixed3D
        lblTracker2.BorderStyle = BorderStyle.Fixed3D
        lblTracker3.BorderStyle = BorderStyle.Fixed3D
        lblTracker4.BorderStyle = BorderStyle.Fixed3D
        lblTracker5.BorderStyle = BorderStyle.Fixed3D
        lblTracker6.BorderStyle = BorderStyle.Fixed3D
        lblTracker7.BorderStyle = BorderStyle.Fixed3D

        '  lblTracker7.Font = New Font(lblTracker7.Font, FontStyle.Bold)

        lblTracker1.Parent = Panel1
        lblTracker2.Parent = Panel1
        lblTracker3.Parent = Panel1
        lblTracker4.Parent = Panel1
        lblTracker5.Parent = Panel1
        lblTracker6.Parent = Panel1
        lblTracker7.Parent = Panel1

        lblTracker1.TextAlign = ContentAlignment.MiddleCenter
        lblTracker2.TextAlign = ContentAlignment.MiddleCenter
        lblTracker3.TextAlign = ContentAlignment.MiddleCenter
        lblTracker4.TextAlign = ContentAlignment.MiddleCenter
        lblTracker5.TextAlign = ContentAlignment.MiddleCenter
        lblTracker6.TextAlign = ContentAlignment.MiddleCenter
        lblTracker7.TextAlign = ContentAlignment.MiddleCenter


    End Sub

    Private Sub loadActivityUX()
        If act Is Nothing Then
            Exit Sub
        End If
        If activities.Count > 0 Then
            txtTimeToday.Text = act.getTotalOnDay(Date.Today).ToString
            txtTimeTotal.Text = act.getTotalTime().ToString
            lblActiveProject.Text = act.Name

            groups.Clear()

            lstSessions.BeginUpdate()
            lstAttachments.BeginUpdate()
            lstSessions.Items.Clear()
            lstAttachments.Items.Clear()
            For Each a As Attachment In act.Attachments
                Dim n As New ListViewItem
                n.Text = a.Label
                n.Tag = a
                n.ImageIndex = a.ImageIndex
                n.ToolTipText = a.Path
                If Not a.Path.Contains("://") And Not My.Computer.FileSystem.FileExists(a.Path) Then
                    n.ForeColor = Color.Gray
                End If
                lstAttachments.Items.Add(n)
            Next
            lstAttachments.EndUpdate()

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
                n.Text = s.StartTime.ToString
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

                If ShowCommentsToolStripMenuItem.Checked And s.Comment.Count > 0 Then
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
            lblBattingAverage.Text = CStr(avgRating)
            If avgRating < 3.0 Then
                PictureBox5.Image = frmSession.PictureBox1.Image '
            ElseIf avgRating < 4.0 Then
                PictureBox5.Image = frmSession.PictureBox3.Image
            Else
                PictureBox5.Image = frmSession.PictureBox5.Image
            End If
            If recentSessionsExist Then
                lblBattingAverage.ForeColor = SystemColors.ControlText
                ToolTip1.SetToolTip(lblBattingAverage, "Average rating (max " & frmSession.barRating.Maximum & ")")
            Else
                lblBattingAverage.ForeColor = SystemColors.GrayText
                ToolTip1.SetToolTip(lblBattingAverage, "Not recorded in the last 7 days")
            End If

            loadHabitTracker()

            lblTracker1.BackColor = Color.White
            lblTracker2.BackColor = Color.White
            lblTracker3.BackColor = Color.White
            lblTracker4.BackColor = Color.White
            lblTracker5.BackColor = Color.White
            lblTracker6.BackColor = Color.White
            lblTracker7.BackColor = Color.White
            lblTracker7.BackColor = Color.White


            'lblTracker1.BringToFront()
            'lblTracker2.BringToFront()
            'lblTracker3.BringToFront()
            'lblTracker4.BringToFront()
            'lblTracker5.BringToFront()
            'lblTracker6.BringToFront()
            'lblTracker7.BringToFront()

            Dim lastMonday As Date = Today.AddDays(-6)

            lblTracker1.Text = lastMonday.DayOfWeek.ToString().Substring(0, 2)
            lblTracker2.Text = lastMonday.AddDays(1).DayOfWeek.ToString().Substring(0, 2)
            lblTracker3.Text = lastMonday.AddDays(2).DayOfWeek.ToString().Substring(0, 2)
            lblTracker4.Text = lastMonday.AddDays(3).DayOfWeek.ToString().Substring(0, 2)
            lblTracker5.Text = lastMonday.AddDays(4).DayOfWeek.ToString().Substring(0, 2)
            lblTracker6.Text = lastMonday.AddDays(5).DayOfWeek.ToString().Substring(0, 2)
            lblTracker7.Text = lastMonday.AddDays(6).DayOfWeek.ToString().Substring(0, 2)

            lblTracker1.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker2.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker3.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker4.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker5.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker6.Font = New Font(trackerFont, FontStyle.Regular)
            lblTracker7.Font = New Font(trackerFont, FontStyle.Bold)

            For Each session As Session In act.Events
                If session.StartTime.Date = lastMonday.Date Then
                    lblTracker1.BackColor = Color.LightGreen
                    'lblTracker1.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(1).Date Then
                    lblTracker2.BackColor = Color.LightGreen
                    'lblTracker2.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(2).Date Then
                    lblTracker3.BackColor = Color.LightGreen
                    'lblTracker3.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(3).Date Then
                    lblTracker4.BackColor = Color.LightGreen
                    'lblTracker4.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(4).Date Then
                    lblTracker5.BackColor = Color.LightGreen
                    'lblTracker5.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(5).Date Then
                    lblTracker6.BackColor = Color.LightGreen
                    'lblTracker6.Font = New Font(trackerFont, FontStyle.Strikeout)
                End If
                If session.StartTime.Date = lastMonday.AddDays(6).Date Then
                    lblTracker7.BackColor = Color.LightGreen
                    'lblTracker7.Font = New Font(trackerFont, FontStyle.Strikeout Or FontStyle.Bold)
                    'lblTracker7.Font = New Font(lblTracker7.Font, FontStyle.Bold)
                End If
                'If session.StartTime.Date < lastMonday Then
                '    Exit For
                'End If
            Next



            lstSessions.EndUpdate()
        End If
        If Not timingActivity Is Nothing Then
            If timingActivity.beingTimed And Not ReferenceEquals(timingActivity, act) Then
                Label2.Text = timingActivity.Name
                'PictureBox5.Visible = True
                picRecording.Image = My.Resources.hourglass_go
                Label2.Visible = True
            Else
                Label2.Visible = False
                picRecording.Image = My.Resources.hourglass
            End If
        Else
            Label2.Visible = False
            picRecording.Image = My.Resources.hourglass
        End If
    End Sub

    'Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If act.beingTimed Then
    '            'MsgBox("Another activity is being timed.", MsgBoxStyle.Information, "Session in progress")

    '            Exit Sub
    '        End If
    '    Catch ex As NullReferenceException
    '        'MsgBox("error")
    '    End Try

    '    act = activities.Item(ListBox1.SelectedIndex)

    '    loadActivityUX()
    'End Sub


    Private Sub viewProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProjects.ItemSelectionChanged ', lstQueue.ItemSelectionChanged, lstQueue.GotFocus
        'Try
        '    If act.beingTimed Then
        '        ' MsgBox("Another activity is being timed.", MsgBoxStyle.Information, "Session in progress")

        '        Exit Sub
        '    End If
        'Catch ex As NullReferenceException
        '    'MsgBox("some error idk")
        'End Try
        lstProjects.BeginUpdate()
        'lstQueue.BeginUpdate()
        If sender.Equals(lstProjects) Then
            If lstProjects.SelectedItems.Count > 0 Then
                act = CType(lstProjects.SelectedItems(0).Tag, Activity)
            End If
            'ElseIf sender.Equals(lstQueue) Then
            '    If lstQueue.SelectedItems.Count > 0 Then
            '        act = CType(lstQueue.SelectedItems(0).Tag, Activity)
            '        activePlannedItem.Text = lstQueue.SelectedItems(0).Text
            '   End If
        End If

        'activePlannedItem.Hide()
        'If sender.Equals(lstQueue) And lstQueue.SelectedItems.Count > 0 Then
        '    If Not lstQueue.SelectedItems.Item(0).Text = act.Name Then
        '        activePlannedItem.Show()
        '    End If
        'End If

        loadActivityUX()
        lstProjects.EndUpdate()
        'lstQueue.EndUpdate()
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
            'Dim activityItem As ListViewItem = lstProjects.Items.Add(a.Name)
            Dim activityItem As New ListViewItem
            activityItem.Text = a.Name
            activityItem.Tag = a

            ' See UpdateActivityHighlight()
            'For Each e As Session In a.Events
            '    If e.StartTime.Date = Today And highlightToday Then
            '        activityItem.ForeColor = Color.Teal
            '    End If
            'Next

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

    Private Sub LabellblActiveProject_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblActiveProject.DoubleClick
        If lstProjects.SelectedItems.Count > 0 Then

            Dim newName As String = InputBox("Enter the name for the activity.", "Set Activity Name", lblActiveProject.Text)
            If newName.Count > 0 Then
                act.Name = newName
                loadList()
            End If

        End If

    End Sub

    Private Sub lstSessions_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSessions.ItemActivate
        Dim frm As New frmSession
        frm.loadSessionData(CType(lstSessions.SelectedItems(0).Tag, Session))
        frm.ShowDialog()
        If CBool(frm.saved) Then
            UpdateActivityHighlight(act)
            loadActivityUX()
            SaveData()
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

    Private Sub ShowCommentsToolStripMenuItem_Click() Handles ShowCommentsToolStripMenuItem.Click
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

    Private Sub viewAttach_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstAttachments.DragEnter
        e.Effect = DragDropEffects.Link
    End Sub

    Private Sub viewAttach_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstAttachments.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' we're dropping files
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop, True), String())

            For Each file As String In files

                Dim attach As New Attachment
                attach.Parent = act.Attachments
                attach.Path = file
                attach.Label = file.Split(IO.Path.DirectorySeparatorChar).Last()
                attach.ImageIndex = 9
                act.Attachments.Add(attach)

                Dim itm As ListViewItem
                itm = lstAttachments.Items.Add(attach.Label)
                itm.ToolTipText = attach.Path
                itm.Tag = attach
                itm.ImageIndex = 9

                'itm.BeginEdit()
                SaveData()

            Next

        ElseIf e.Data.GetDataPresent(DataFormats.Text) Then
            Dim attach As New Attachment
            attach.Parent = act.Attachments
            attach.Path = CStr(e.Data.GetData(DataFormats.Text))
            attach.Label = CStr(e.Data.GetData(DataFormats.Text))
            attach.ImageIndex = 6
            act.Attachments.Add(attach)

            Dim itm As ListViewItem
            itm = lstAttachments.Items.Add(attach.Label)
            itm.ToolTipText = attach.Path
            itm.Tag = attach
            itm.ImageIndex = 6

            ''itm.BeginEdit()
            SaveData()
        End If

        'itm.Text = path(1)
        'itm.ToolTipText = path(1)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles splitAttachments.SplitterMoved
        lstAttachments.Refresh()
    End Sub

    Private Sub picAttach_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAttach.Click
        If splitAttachments.SplitterDistance < 25 Then
            splitAttachments.SplitterDistance = 999
        Else
            splitAttachments.SplitterDistance = 0
        End If

    End Sub

    Private Sub lstSessions_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lstSessions.ItemSelectionChanged, lstSessions.LostFocus
        If lstSessions.SelectedItems.Count > 0 Then
            Dim d As New TimeSpan
            Dim s As Session
            For Each i As ListViewItem In lstSessions.SelectedItems
                s = CType(i.Tag, Session)
                d = d.Add(s.TimeSpan)
            Next
            lblTimeToday.Text = "Total selected time"
            txtTimeToday.Text = d.ToString("hh\:mm\:ss")
        Else
            lblTimeToday.Text = "Time today"
            txtTimeToday.Text = act.getTotalOnDay(Date.Today).ToString
        End If
    End Sub

    Private Sub btnCSVExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSVExport.Click
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

    Private Sub btnCommentView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommentView.Click
        ShowCommentsToolStripMenuItem.Checked = Not ShowCommentsToolStripMenuItem.Checked
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

        'For Each queueItem As ListViewItem In lstQueue.Items
        '    If queueItem.Tag.Equals(lstProjects.Items(e.Item).Tag) Then
        '        queueItem.Text = e.Label
        '    End If
        'Next

        'loadActivityUX()
    End Sub

    Private Sub CategorizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategorizeToolStripMenuItem.Click
        If lstProjects.SelectedItems.Count > 0 Then
            Dim activ As Activity = CType(lstProjects.SelectedItems(0).Tag, Activity)
            Dim s As String = InputBox("What category (this is case sensitive)?", "Set category for " & activ.Name, activ.Category)
            If s <> "" Then
                activ.Category = s
                lstSessions.ShowGroups = True
                loadList()
            End If
            SaveData()
        End If
    End Sub

    Private Sub btnCategoryView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoryView.Click
        lstProjects.ShowGroups = Not lstProjects.ShowGroups
    End Sub

    Private Sub progressDayMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progressDayMeter.Click
        Dim dmSet As New frmWipDayMeter
        dmSet.ShowDialog()
    End Sub

    Private newinput As Boolean = True

    Private Sub Timer1_Tick() Handles Timer1.Tick
        progressDayMeter.Value = CInt(dm.GetProgress(100))
        lblNighttime.Text = dm.Finish.ToShortTimeString
        Try
            Dim nt1 As DateTime = Today.AddHours(time1.Value.TimeOfDay.Hours).AddMinutes(time1.Value.TimeOfDay.Minutes)
            Dim nt2 As DateTime = Today.AddHours(time2.Value.TimeOfDay.Hours).AddMinutes(time2.Value.TimeOfDay.Minutes)
            If nt2 < Now And newinput Then
                newinput = False
                nt2 = nt2.AddDays(1)
                time2.CalendarForeColor = Color.Blue
                Exit Sub
            End If

            ' todo: refactor
            Dim totalDuration As TimeSpan = nt2.Subtract(nt1)
            Dim elapsedTime As TimeSpan = Now.Subtract(nt1)

            ' Make sure elapsed time is not greater than total duration
            If elapsedTime > totalDuration Then
                elapsedTime = totalDuration
            End If

            ' Calculate progress out of 100
            Dim progressPercentage As Integer = CInt((elapsedTime.TotalMinutes / totalDuration.TotalMinutes) * 100)

            progressSprint.Value = progressPercentage
            'CInt(New Meter(nt1, nt2).GetProgress(100))
            'Me.Text = nt1.ToString & " " & nt2.ToString
        Catch ex As Exception
            'Me.Text = Now.Second & " err"
        End Try
        'lblCurrentTime.Text = Now.TimeOfDay.ToString
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        HighlightTodayToolStripMenuItem.Checked = highlightToday

        GroupByCategoryToolStripMenuItem.Checked = lstProjects.ShowGroups
    End Sub

    Private Sub HighlightTodayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HighlightTodayToolStripMenuItem.Click
        highlightToday = HighlightTodayToolStripMenuItem.Checked

        For Each itm As ListViewItem In lstProjects.Items
            UpdateActivityHighlight(CType(itm.Tag, Activity))
        Next
    End Sub

    Private Sub GroupByCategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GroupByCategoryToolStripMenuItem.Click
        lstProjects.ShowGroups = GroupByCategoryToolStripMenuItem.Checked
        lstProjects.Refresh()
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As System.Object, e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If MsgBox("The Hours data was updated outside this program. Do you want to reload data? (This will not interrupt your session.)" & vbNewLine & "If the file was modified by mistake, select Cancel and click on the Save button to prevent loss.", CType(MsgBoxStyle.OkCancel + MsgBoxStyle.Information, MsgBoxStyle), "Reload data") = MsgBoxResult.Ok Then
            LoadData()
        End If
    End Sub

    Private Sub viewAttach_ItemActivate(sender As System.Object, e As System.EventArgs) Handles lstAttachments.ItemActivate
        Dim attach As Attachment = CType(lstAttachments.SelectedItems(0).Tag, Attachment)
        Try
            Process.Start(attach.Path)
        Catch ex As System.ComponentModel.Win32Exception
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        frmAttachment.ShowDialog()
    End Sub

    Private Sub lstProjects_ItemDrag(sender As System.Object, e As System.Windows.Forms.ItemDragEventArgs) Handles lstProjects.ItemDrag

        Dim items As List(Of ListViewItem) = New List(Of ListViewItem)()
        items.Add(CType(e.Item, ListViewItem))

        For Each lvi As ListViewItem In lstProjects.SelectedItems

            If Not items.Contains(lvi) Then
                items.Add(lvi)
            End If
        Next

        lstProjects.DoDragDrop(items, DragDropEffects.Copy)


        'DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    'Private Sub addProjectItemToQueue(itm As ListViewItem
    '                                 )
    '    Dim lvii As New ListViewItem
    '    lvii.Tag = itm.Tag
    '    lvii.Text = itm.Text
    '    lvii.ImageIndex = 14
    '    lstQueue.Items.Add(lvii)
    '    lvii.BeginEdit()
    'End Sub

    'Private Sub lstQueue_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs)

    '    If e.Data.GetDataPresent(GetType(List(Of ListViewItem))) Then
    '        Dim items As List(Of ListViewItem) = CType(e.Data.GetData(GetType(List(Of ListViewItem))), List(Of ListViewItem))

    '        For Each lvi As ListViewItem In items
    '            addProjectItemToQueue(lvi)
    '        Next
    '    End If

    'End Sub

    'Private Sub lstQueue_DragOver(sender As System.Object, e As System.Windows.Forms.DragEventArgs)

    '    If e.Data.GetDataPresent(GetType(List(Of ListViewItem))) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If

    'End Sub

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

    'Private Sub lstQueue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
    '        If lstQueue.SelectedItems.Count > 0 Then
    '            lstQueue.SelectedItems(0).Remove()
    '            If lstQueue.Items.Count > 0 Then

    '                lstQueue.Items(0).Selected = True
    '            End If

    '            ListViewRefresh(lstQueue)
    '        End If
    '    End If
    'End Sub

    'Private Sub lstProjects_ItemActivate(sender As System.Object, e As System.EventArgs)
    '    addProjectItemToQueue(lstProjects.SelectedItems(0))
    'End Sub

    'Private Sub lstQueue_AfterLabelEdit(sender As System.Object, e As System.Windows.Forms.LabelEditEventArgs)
    '    activePlannedItem.Text = e.Label
    '    lstQueue.Items(e.Item).Selected = True
    'End Sub

    'Private Sub lstQueue_ItemActivate(sender As System.Object, e As System.EventArgs)
    '    If Not act.beingTimed Then
    '        btnStart.PerformClick()
    '    End If
    'End Sub

    'Private Sub lstQueue_BeforeLabelEdit(sender As System.Object, e As System.Windows.Forms.LabelEditEventArgs)
    '    Try
    '        If e.Label.Count < 1 Then
    '            e.CancelEdit = True
    '        End If
    '    Catch ex As ArgumentNullException
    '        ' new item
    '    End Try
    'End Sub

    Private Sub lstAttachments_AfterLabelEdit(sender As System.Object, e As System.Windows.Forms.LabelEditEventArgs) Handles lstAttachments.AfterLabelEdit
        If e.Label = "" Then
            e.CancelEdit = True
        Else
            Dim attach As Attachment = CType(lstAttachments.Items(e.Item).Tag, Attachment)
            attach.Label = e.Label
            SaveData()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btn5Min.Click, btn10Min.Click, btn50Min.Click, btn25Min.Click
        Dim time As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, 0)
        If progressSprint.Value = 0 Or progressSprint.Value = 100 Then
            time1.Value = time
        End If
        If ReferenceEquals(sender, btn5Min) Then
            time2.Value = time1.Value.AddMinutes(CDbl(btn5Min.Tag))
        End If
        If ReferenceEquals(sender, btn10Min) Then
            time2.Value = time1.Value.AddMinutes(CDbl(btn10Min.Tag))
        End If
        If ReferenceEquals(sender, btn50Min) Then
            time2.Value = time1.Value.AddMinutes(CDbl(btn50Min.Tag))
        End If
        If ReferenceEquals(sender, btn25Min) Then
            time2.Value = time1.Value.AddMinutes(CDbl(btn25Min.Tag))
        End If
        Timer1_Tick()
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
            'btnPause.Text = getTimingDuration()
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

    Private Sub time1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles time2.ValueChanged, time1.ValueChanged
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
End Class
