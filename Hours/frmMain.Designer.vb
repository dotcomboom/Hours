<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
		Dim ColumnHeader3 As System.Windows.Forms.ColumnHeader
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("First Section", 13)
		Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Second Section", 13)
		Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Third Section", 13)
		Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Conclusion", 13)
		Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Intro", 13)
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.NotifyCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.LatestSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ActiveActivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenHoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnPause = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.txtTimeTotal = New System.Windows.Forms.Label()
		Me.lblActiveProject = New System.Windows.Forms.Label()
		Me.btnAddProject = New System.Windows.Forms.Button()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.lstSessions = New System.Windows.Forms.ListView()
		Me.SessionsCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.DurationViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UseGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EarliestFirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.DiscardSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.picRecording = New System.Windows.Forms.PictureBox()
		Me.picSaveError = New System.Windows.Forms.PictureBox()
		Me.btnRetrySave = New System.Windows.Forms.LinkLabel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.ActivitiesCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.CategorizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.DeleteProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
		Me.SessionTimer = New System.Windows.Forms.Timer(Me.components)
		Me.DataXMLChangeWatcher = New System.IO.FileSystemWatcher()
		Me.splitProjects = New System.Windows.Forms.SplitContainer()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lblTimingActivity = New System.Windows.Forms.Label()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.splitMain = New System.Windows.Forms.SplitContainer()
		Me.lstProjects = New System.Windows.Forms.ListView()
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.lblTimeTotal = New System.Windows.Forms.Label()
		Me.lblTimeToday = New System.Windows.Forms.Label()
		Me.txtTimeToday = New System.Windows.Forms.Label()
		Me.DurationTimer = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.NotifyCMS.SuspendLayout()
		Me.SessionsCMS.SuspendLayout()
		CType(Me.picRecording, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ActivitiesCMS.SuspendLayout()
		CType(Me.DataXMLChangeWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.splitProjects.Panel1.SuspendLayout()
		Me.splitProjects.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.splitMain.Panel1.SuspendLayout()
		Me.splitMain.Panel2.SuspendLayout()
		Me.splitMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'ColumnHeader1
		'
		ColumnHeader1.Width = 200
		'
		'ColumnHeader3
		'
		ColumnHeader3.Text = "Skill"
		ColumnHeader3.Width = 150
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.ContextMenuStrip = Me.NotifyCMS
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "Hours"
		Me.NotifyIcon1.Visible = True
		'
		'NotifyCMS
		'
		Me.NotifyCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.NotifyCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.LatestSessionToolStripMenuItem, Me.ActiveActivityToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ExitToolStripMenuItem, Me.OpenHoursToolStripMenuItem})
		Me.NotifyCMS.Name = "NotifyCMS"
		Me.NotifyCMS.Size = New System.Drawing.Size(215, 168)
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(211, 6)
		'
		'LatestSessionToolStripMenuItem
		'
		Me.LatestSessionToolStripMenuItem.Image = Global.Hours.My.Resources.Resources.report
		Me.LatestSessionToolStripMenuItem.Name = "LatestSessionToolStripMenuItem"
		Me.LatestSessionToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
		Me.LatestSessionToolStripMenuItem.Text = "Most recent session"
		Me.LatestSessionToolStripMenuItem.Visible = False
		'
		'ActiveActivityToolStripMenuItem
		'
		Me.ActiveActivityToolStripMenuItem.Enabled = False
		Me.ActiveActivityToolStripMenuItem.Image = Global.Hours.My.Resources.Resources.hourglass
		Me.ActiveActivityToolStripMenuItem.Name = "ActiveActivityToolStripMenuItem"
		Me.ActiveActivityToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
		Me.ActiveActivityToolStripMenuItem.Text = "No timer active"
		'
		'PauseToolStripMenuItem
		'
		Me.PauseToolStripMenuItem.Image = Global.Hours.My.Resources.Resources.control_pause
		Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
		Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
		Me.PauseToolStripMenuItem.Text = "Pause"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'OpenHoursToolStripMenuItem
		'
		Me.OpenHoursToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OpenHoursToolStripMenuItem.Name = "OpenHoursToolStripMenuItem"
		Me.OpenHoursToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
		Me.OpenHoursToolStripMenuItem.Text = "Open Hours"
		'
		'btnPause
		'
		Me.btnPause.Enabled = False
		Me.btnPause.Image = Global.Hours.My.Resources.Resources.control_pause
		Me.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPause.Location = New System.Drawing.Point(95, 46)
		Me.btnPause.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnPause.Name = "btnPause"
		Me.btnPause.Size = New System.Drawing.Size(92, 27)
		Me.btnPause.TabIndex = 1
		Me.btnPause.Text = "Pause"
		Me.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnPause.UseVisualStyleBackColor = True
		'
		'btnStart
		'
		Me.btnStart.Image = Global.Hours.My.Resources.Resources.control_play_blue
		Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnStart.Location = New System.Drawing.Point(-1, 46)
		Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(92, 27)
		Me.btnStart.TabIndex = 2
		Me.btnStart.Text = "Start"
		Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnStart.UseVisualStyleBackColor = True
		'
		'txtTimeTotal
		'
		Me.txtTimeTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.txtTimeTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTimeTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTimeTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtTimeTotal.Location = New System.Drawing.Point(117, 406)
		Me.txtTimeTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.txtTimeTotal.Name = "txtTimeTotal"
		Me.txtTimeTotal.Size = New System.Drawing.Size(92, 20)
		Me.txtTimeTotal.TabIndex = 3
		Me.txtTimeTotal.Text = "00:00:00"
		Me.txtTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblActiveProject
		'
		Me.lblActiveProject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblActiveProject.AutoEllipsis = True
		Me.lblActiveProject.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.lblActiveProject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblActiveProject.Location = New System.Drawing.Point(0, 22)
		Me.lblActiveProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblActiveProject.Name = "lblActiveProject"
		Me.lblActiveProject.Size = New System.Drawing.Size(224, 26)
		Me.lblActiveProject.TabIndex = 7
		'
		'btnAddProject
		'
		Me.btnAddProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAddProject.Image = CType(resources.GetObject("btnAddProject.Image"), System.Drawing.Image)
		Me.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAddProject.Location = New System.Drawing.Point(286, 390)
		Me.btnAddProject.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnAddProject.Name = "btnAddProject"
		Me.btnAddProject.Padding = New System.Windows.Forms.Padding(1, 0, 4, 0)
		Me.btnAddProject.Size = New System.Drawing.Size(118, 30)
		Me.btnAddProject.TabIndex = 8
		Me.btnAddProject.Text = "Add activity"
		Me.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAddProject.UseVisualStyleBackColor = True
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList1.Images.SetKeyName(0, "comment_add.png")
		Me.ImageList1.Images.SetKeyName(1, "comment.png")
		Me.ImageList1.Images.SetKeyName(2, "report.png")
		Me.ImageList1.Images.SetKeyName(3, "link.png")
		Me.ImageList1.Images.SetKeyName(4, "film.png")
		Me.ImageList1.Images.SetKeyName(5, "pencil.png")
		Me.ImageList1.Images.SetKeyName(6, "world.png")
		Me.ImageList1.Images.SetKeyName(7, "palette.png")
		Me.ImageList1.Images.SetKeyName(8, "note.png")
		Me.ImageList1.Images.SetKeyName(9, "page.png")
		Me.ImageList1.Images.SetKeyName(10, "time.png")
		Me.ImageList1.Images.SetKeyName(11, "book.png")
		Me.ImageList1.Images.SetKeyName(12, "basket.png")
		Me.ImageList1.Images.SetKeyName(13, "asterisk_yellow.png")
		Me.ImageList1.Images.SetKeyName(14, "lightbulb.png")
		'
		'lstSessions
		'
		Me.lstSessions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lstSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
		Me.lstSessions.ContextMenuStrip = Me.SessionsCMS
		Me.lstSessions.HideSelection = False
		Me.lstSessions.LargeImageList = Me.ImageList1
		Me.lstSessions.Location = New System.Drawing.Point(0, 79)
		Me.lstSessions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.lstSessions.Name = "lstSessions"
		Me.lstSessions.ShowItemToolTips = True
		Me.lstSessions.Size = New System.Drawing.Size(231, 298)
		Me.lstSessions.SmallImageList = Me.ImageList1
		Me.lstSessions.TabIndex = 10
		Me.lstSessions.TileSize = New System.Drawing.Size(200, 30)
		Me.lstSessions.UseCompatibleStateImageBehavior = False
		Me.lstSessions.View = System.Windows.Forms.View.Tile
		'
		'SessionsCMS
		'
		Me.SessionsCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.SessionsCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DurationViewToolStripMenuItem, Me.UseGroupsToolStripMenuItem, Me.EarliestFirstToolStripMenuItem, Me.ToolStripSeparator2, Me.DiscardSessionToolStripMenuItem})
		Me.SessionsCMS.Name = "ContextMenuStrip1"
		Me.SessionsCMS.Size = New System.Drawing.Size(211, 114)
		'
		'DurationViewToolStripMenuItem
		'
		Me.DurationViewToolStripMenuItem.CheckOnClick = True
		Me.DurationViewToolStripMenuItem.Image = CType(resources.GetObject("DurationViewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DurationViewToolStripMenuItem.Name = "DurationViewToolStripMenuItem"
		Me.DurationViewToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
		Me.DurationViewToolStripMenuItem.Text = "Duration only"
		'
		'UseGroupsToolStripMenuItem
		'
		Me.UseGroupsToolStripMenuItem.CheckOnClick = True
		Me.UseGroupsToolStripMenuItem.Image = CType(resources.GetObject("UseGroupsToolStripMenuItem.Image"), System.Drawing.Image)
		Me.UseGroupsToolStripMenuItem.Name = "UseGroupsToolStripMenuItem"
		Me.UseGroupsToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
		Me.UseGroupsToolStripMenuItem.Text = "Group by date"
		'
		'EarliestFirstToolStripMenuItem
		'
		Me.EarliestFirstToolStripMenuItem.CheckOnClick = True
		Me.EarliestFirstToolStripMenuItem.Image = CType(resources.GetObject("EarliestFirstToolStripMenuItem.Image"), System.Drawing.Image)
		Me.EarliestFirstToolStripMenuItem.Name = "EarliestFirstToolStripMenuItem"
		Me.EarliestFirstToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
		Me.EarliestFirstToolStripMenuItem.Text = "Earlier sessions first"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
		Me.ToolStripSeparator2.Visible = False
		'
		'DiscardSessionToolStripMenuItem
		'
		Me.DiscardSessionToolStripMenuItem.Image = CType(resources.GetObject("DiscardSessionToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DiscardSessionToolStripMenuItem.Name = "DiscardSessionToolStripMenuItem"
		Me.DiscardSessionToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
		Me.DiscardSessionToolStripMenuItem.Text = "Delete session"
		Me.DiscardSessionToolStripMenuItem.Visible = False
		'
		'picRecording
		'
		Me.picRecording.Image = CType(resources.GetObject("picRecording.Image"), System.Drawing.Image)
		Me.picRecording.Location = New System.Drawing.Point(192, 51)
		Me.picRecording.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.picRecording.Name = "picRecording"
		Me.picRecording.Size = New System.Drawing.Size(16, 16)
		Me.picRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picRecording.TabIndex = 11
		Me.picRecording.TabStop = False
		Me.picRecording.Visible = False
		'
		'picSaveError
		'
		Me.picSaveError.Image = CType(resources.GetObject("picSaveError.Image"), System.Drawing.Image)
		Me.picSaveError.Location = New System.Drawing.Point(216, 404)
		Me.picSaveError.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.picSaveError.Name = "picSaveError"
		Me.picSaveError.Size = New System.Drawing.Size(16, 16)
		Me.picSaveError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picSaveError.TabIndex = 15
		Me.picSaveError.TabStop = False
		Me.picSaveError.Visible = False
		'
		'btnRetrySave
		'
		Me.btnRetrySave.AutoSize = True
		Me.btnRetrySave.Location = New System.Drawing.Point(234, 405)
		Me.btnRetrySave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.btnRetrySave.Name = "btnRetrySave"
		Me.btnRetrySave.Size = New System.Drawing.Size(83, 20)
		Me.btnRetrySave.TabIndex = 16
		Me.btnRetrySave.TabStop = True
		Me.btnRetrySave.Text = "Retry save?"
		Me.btnRetrySave.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnRetrySave.Visible = False
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Panel2.AutoSize = True
		Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Panel2.Location = New System.Drawing.Point(13, 384)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(0, 0)
		Me.Panel2.TabIndex = 17
		Me.Panel2.Visible = False
		'
		'ActivitiesCMS
		'
		Me.ActivitiesCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ActivitiesCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorizeToolStripMenuItem, Me.AddProjectToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteProjectToolStripMenuItem})
		Me.ActivitiesCMS.Name = "ContextMenuStrip2"
		Me.ActivitiesCMS.Size = New System.Drawing.Size(178, 88)
		'
		'CategorizeToolStripMenuItem
		'
		Me.CategorizeToolStripMenuItem.Image = CType(resources.GetObject("CategorizeToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CategorizeToolStripMenuItem.Name = "CategorizeToolStripMenuItem"
		Me.CategorizeToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
		Me.CategorizeToolStripMenuItem.Text = "Set category..."
		'
		'AddProjectToolStripMenuItem
		'
		Me.AddProjectToolStripMenuItem.Image = CType(resources.GetObject("AddProjectToolStripMenuItem.Image"), System.Drawing.Image)
		Me.AddProjectToolStripMenuItem.Name = "AddProjectToolStripMenuItem"
		Me.AddProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
		Me.AddProjectToolStripMenuItem.Text = "Add activity"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
		'
		'DeleteProjectToolStripMenuItem
		'
		Me.DeleteProjectToolStripMenuItem.Image = CType(resources.GetObject("DeleteProjectToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DeleteProjectToolStripMenuItem.Name = "DeleteProjectToolStripMenuItem"
		Me.DeleteProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
		Me.DeleteProjectToolStripMenuItem.Text = "Delete activity"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar1.Location = New System.Drawing.Point(25, 55)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(142, 23)
		Me.ProgressBar1.TabIndex = 53
		Me.ToolTip1.SetToolTip(Me.ProgressBar1, "Total progress")
		'
		'ProgressBar2
		'
		Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar2.Location = New System.Drawing.Point(25, 84)
		Me.ProgressBar2.Name = "ProgressBar2"
		Me.ProgressBar2.Size = New System.Drawing.Size(142, 23)
		Me.ProgressBar2.TabIndex = 54
		Me.ToolTip1.SetToolTip(Me.ProgressBar2, "Component progress")
		'
		'ProgressBar3
		'
		Me.ProgressBar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar3.Location = New System.Drawing.Point(25, 26)
		Me.ProgressBar3.Name = "ProgressBar3"
		Me.ProgressBar3.Size = New System.Drawing.Size(89, 23)
		Me.ProgressBar3.TabIndex = 55
		Me.ToolTip1.SetToolTip(Me.ProgressBar3, "Target progress")
		'
		'SessionTimer
		'
		Me.SessionTimer.Enabled = True
		Me.SessionTimer.Interval = 1000
		'
		'DataXMLChangeWatcher
		'
		Me.DataXMLChangeWatcher.EnableRaisingEvents = True
		Me.DataXMLChangeWatcher.Filter = "hours_data.xml"
		Me.DataXMLChangeWatcher.Path = "."
		Me.DataXMLChangeWatcher.SynchronizingObject = Me
		'
		'splitProjects
		'
		Me.splitProjects.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitProjects.Location = New System.Drawing.Point(0, 0)
		Me.splitProjects.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.splitProjects.Name = "splitProjects"
		Me.splitProjects.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'splitProjects.Panel1
		'
		Me.splitProjects.Panel1.Controls.Add(Me.Panel1)
		Me.splitProjects.Panel2Collapsed = True
		Me.splitProjects.Size = New System.Drawing.Size(235, 377)
		Me.splitProjects.SplitterDistance = 213
		Me.splitProjects.SplitterWidth = 5
		Me.splitProjects.TabIndex = 43
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Panel4)
		Me.Panel1.Controls.Add(Me.lstSessions)
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(235, 377)
		Me.Panel1.TabIndex = 0
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.PictureBox1)
		Me.Panel4.Controls.Add(Me.ListView1)
		Me.Panel4.Controls.Add(Me.Label1)
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.ProgressBar1)
		Me.Panel4.Controls.Add(Me.PictureBox5)
		Me.Panel4.Controls.Add(Me.ProgressBar2)
		Me.Panel4.Controls.Add(Me.PictureBox4)
		Me.Panel4.Controls.Add(Me.ProgressBar3)
		Me.Panel4.Controls.Add(Me.PictureBox3)
		Me.Panel4.Location = New System.Drawing.Point(339, 12)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(216, 446)
		Me.Panel4.TabIndex = 68
		Me.Panel4.Visible = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox1.TabIndex = 50
		Me.PictureBox1.TabStop = False
		'
		'ListView1
		'
		Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader3, Me.ColumnHeader4})
		Me.ListView1.ContextMenuStrip = Me.SessionsCMS
		Me.ListView1.HideSelection = False
		Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
		Me.ListView1.LargeImageList = Me.ImageList1
		Me.ListView1.Location = New System.Drawing.Point(1, 119)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.ShowItemToolTips = True
		Me.ListView1.Size = New System.Drawing.Size(166, 324)
		Me.ListView1.SmallImageList = Me.ImageList1
		Me.ListView1.TabIndex = 48
		Me.ListView1.TileSize = New System.Drawing.Size(150, 30)
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.Tile
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Progress"
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(22, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 20)
		Me.Label1.TabIndex = 47
		Me.Label1.Text = "Goals"
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(116, 28)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(61, 20)
		Me.Label4.TabIndex = 59
		Me.Label4.Text = "Day 1/4"
		'
		'PictureBox5
		'
		Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
		Me.PictureBox5.Location = New System.Drawing.Point(3, 89)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox5.TabIndex = 58
		Me.PictureBox5.TabStop = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
		Me.PictureBox4.Location = New System.Drawing.Point(3, 58)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox4.TabIndex = 57
		Me.PictureBox4.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
		Me.PictureBox3.Location = New System.Drawing.Point(3, 28)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox3.TabIndex = 56
		Me.PictureBox3.TabStop = False
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.lblTimingActivity)
		Me.Panel3.Controls.Add(Me.picRecording)
		Me.Panel3.Controls.Add(Me.btnStart)
		Me.Panel3.Controls.Add(Me.btnPause)
		Me.Panel3.Controls.Add(Me.lblGroup)
		Me.Panel3.Controls.Add(Me.lblActiveProject)
		Me.Panel3.Location = New System.Drawing.Point(2, 0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(229, 73)
		Me.Panel3.TabIndex = 63
		'
		'lblTimingActivity
		'
		Me.lblTimingActivity.AutoSize = True
		Me.lblTimingActivity.Location = New System.Drawing.Point(149, 23)
		Me.lblTimingActivity.Name = "lblTimingActivity"
		Me.lblTimingActivity.Size = New System.Drawing.Size(0, 20)
		Me.lblTimingActivity.TabIndex = 63
		Me.lblTimingActivity.Visible = False
		'
		'lblGroup
		'
		Me.lblGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblGroup.AutoEllipsis = True
		Me.lblGroup.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.lblGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGroup.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblGroup.Location = New System.Drawing.Point(0, 2)
		Me.lblGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(226, 21)
		Me.lblGroup.TabIndex = 62
		'
		'splitMain
		'
		Me.splitMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.splitMain.Location = New System.Drawing.Point(13, 7)
		Me.splitMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.splitMain.Name = "splitMain"
		'
		'splitMain.Panel1
		'
		Me.splitMain.Panel1.Controls.Add(Me.splitProjects)
		Me.splitMain.Panel1MinSize = 152
		'
		'splitMain.Panel2
		'
		Me.splitMain.Panel2.Controls.Add(Me.lstProjects)
		Me.splitMain.Size = New System.Drawing.Size(391, 377)
		Me.splitMain.SplitterDistance = 235
		Me.splitMain.SplitterWidth = 5
		Me.splitMain.TabIndex = 44
		'
		'lstProjects
		'
		Me.lstProjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
		Me.lstProjects.ContextMenuStrip = Me.ActivitiesCMS
		Me.lstProjects.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstProjects.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstProjects.FullRowSelect = True
		Me.lstProjects.GridLines = True
		Me.lstProjects.HideSelection = False
		Me.lstProjects.LabelEdit = True
		Me.lstProjects.Location = New System.Drawing.Point(0, 0)
		Me.lstProjects.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.lstProjects.MultiSelect = False
		Me.lstProjects.Name = "lstProjects"
		Me.lstProjects.Size = New System.Drawing.Size(151, 377)
		Me.lstProjects.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.lstProjects.TabIndex = 2
		Me.lstProjects.TileSize = New System.Drawing.Size(268, 20)
		Me.lstProjects.UseCompatibleStateImageBehavior = False
		Me.lstProjects.View = System.Windows.Forms.View.SmallIcon
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "uuu"
		Me.ColumnHeader2.Width = 0
		'
		'lblTimeTotal
		'
		Me.lblTimeTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblTimeTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblTimeTotal.Location = New System.Drawing.Point(114, 386)
		Me.lblTimeTotal.Name = "lblTimeTotal"
		Me.lblTimeTotal.Size = New System.Drawing.Size(95, 19)
		Me.lblTimeTotal.TabIndex = 66
		Me.lblTimeTotal.Text = "Time tracked"
		Me.lblTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblTimeToday
		'
		Me.lblTimeToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblTimeToday.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.lblTimeToday.Location = New System.Drawing.Point(10, 384)
		Me.lblTimeToday.Name = "lblTimeToday"
		Me.lblTimeToday.Size = New System.Drawing.Size(98, 22)
		Me.lblTimeToday.TabIndex = 65
		Me.lblTimeToday.Text = "Time today"
		Me.lblTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtTimeToday
		'
		Me.txtTimeToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.txtTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTimeToday.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTimeToday.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.txtTimeToday.Location = New System.Drawing.Point(13, 406)
		Me.txtTimeToday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.txtTimeToday.Name = "txtTimeToday"
		Me.txtTimeToday.Size = New System.Drawing.Size(92, 20)
		Me.txtTimeToday.TabIndex = 64
		Me.txtTimeToday.Text = "00:00:00"
		Me.txtTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DurationTimer
		'
		Me.DurationTimer.Interval = 1000
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(414, 432)
		Me.Controls.Add(Me.picSaveError)
		Me.Controls.Add(Me.btnRetrySave)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.txtTimeTotal)
		Me.Controls.Add(Me.splitMain)
		Me.Controls.Add(Me.lblTimeTotal)
		Me.Controls.Add(Me.btnAddProject)
		Me.Controls.Add(Me.lblTimeToday)
		Me.Controls.Add(Me.txtTimeToday)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MinimumSize = New System.Drawing.Size(430, 315)
		Me.Name = "frmMain"
		Me.Text = "Hours"
		Me.NotifyCMS.ResumeLayout(False)
		Me.SessionsCMS.ResumeLayout(False)
		CType(Me.picRecording, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ActivitiesCMS.ResumeLayout(False)
		CType(Me.DataXMLChangeWatcher, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitProjects.Panel1.ResumeLayout(False)
		CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitProjects.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.splitMain.Panel1.ResumeLayout(False)
		Me.splitMain.Panel2.ResumeLayout(False)
		CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitMain.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
	Friend WithEvents btnPause As System.Windows.Forms.Button
	Friend WithEvents btnStart As System.Windows.Forms.Button
	Friend WithEvents txtTimeTotal As System.Windows.Forms.Label
	Friend WithEvents lblActiveProject As System.Windows.Forms.Label
	Friend WithEvents btnAddProject As System.Windows.Forms.Button
	Friend WithEvents lstSessions As System.Windows.Forms.ListView
	Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
	Friend WithEvents picRecording As System.Windows.Forms.PictureBox
	Friend WithEvents picSaveError As System.Windows.Forms.PictureBox
	Friend WithEvents btnRetrySave As System.Windows.Forms.LinkLabel
	Friend WithEvents SessionsCMS As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents UseGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents DurationViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents ActivitiesCMS As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents CategorizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SessionTimer As System.Windows.Forms.Timer
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents DataXMLChangeWatcher As System.IO.FileSystemWatcher
	Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
	Friend WithEvents splitMain As System.Windows.Forms.SplitContainer
	Friend WithEvents DurationTimer As System.Windows.Forms.Timer
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents AddProjectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListView1 As ListView
	Friend WithEvents ColumnHeader4 As ColumnHeader
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents DiscardSessionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Timer3 As Timer
	Friend WithEvents DeleteProjectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProgressBar3 As ProgressBar
	Friend WithEvents ProgressBar2 As ProgressBar
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents lblGroup As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents EarliestFirstToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblTimingActivity As Label
	Friend WithEvents txtTimeToday As Label
	Friend WithEvents lblTimeTotal As Label
	Friend WithEvents lblTimeToday As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents lstProjects As ListView
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents NotifyCMS As ContextMenuStrip
	Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents OpenHoursToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ActiveActivityToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LatestSessionToolStripMenuItem As ToolStripMenuItem
End Class
