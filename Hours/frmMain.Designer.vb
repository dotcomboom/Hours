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
		Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("First Section", 13)
		Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Second Section", 13)
		Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Third Section", 13)
		Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Conclusion", 13)
		Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Intro", 13)
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.btnPause = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.txtTimeTotal = New System.Windows.Forms.Label()
		Me.lblActiveProject = New System.Windows.Forms.Label()
		Me.btnAddProject = New System.Windows.Forms.Button()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.lstSessions = New System.Windows.Forms.ListView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.DurationViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UseGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.DiscardSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.picRecording = New System.Windows.Forms.PictureBox()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnLoadData = New System.Windows.Forms.Button()
		Me.picSaveError = New System.Windows.Forms.PictureBox()
		Me.btnRetrySave = New System.Windows.Forms.LinkLabel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.CategorizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.DeleteProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
		Me.splitProjects = New System.Windows.Forms.SplitContainer()
		Me.lstProjects = New System.Windows.Forms.ListView()
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.splitMain = New System.Windows.Forms.SplitContainer()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnRename = New System.Windows.Forms.Button()
		Me.btnTarget = New System.Windows.Forms.Button()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ContextMenuStrip1.SuspendLayout()
		CType(Me.picRecording, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.ContextMenuStrip2.SuspendLayout()
		CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.splitProjects.Panel1.SuspendLayout()
		Me.splitProjects.SuspendLayout()
		CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.splitMain.Panel1.SuspendLayout()
		Me.splitMain.Panel2.SuspendLayout()
		Me.splitMain.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.NotifyIcon1.Text = "NotifyIcon1"
		Me.NotifyIcon1.Visible = True
		'
		'btnPause
		'
		Me.btnPause.Enabled = False
		Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
		Me.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPause.Location = New System.Drawing.Point(79, 117)
		Me.btnPause.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnPause.Name = "btnPause"
		Me.btnPause.Size = New System.Drawing.Size(67, 27)
		Me.btnPause.TabIndex = 1
		Me.btnPause.Text = "Pause"
		Me.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnPause.UseVisualStyleBackColor = True
		'
		'btnStart
		'
		Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
		Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnStart.Location = New System.Drawing.Point(4, 117)
		Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(67, 27)
		Me.btnStart.TabIndex = 2
		Me.btnStart.Text = "Start"
		Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnStart.UseVisualStyleBackColor = True
		'
		'txtTimeTotal
		'
		Me.txtTimeTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtTimeTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.txtTimeTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTimeTotal.Location = New System.Drawing.Point(4, 438)
		Me.txtTimeTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.txtTimeTotal.Name = "txtTimeTotal"
		Me.txtTimeTotal.Size = New System.Drawing.Size(204, 20)
		Me.txtTimeTotal.TabIndex = 3
		Me.txtTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblActiveProject
		'
		Me.lblActiveProject.AutoEllipsis = True
		Me.lblActiveProject.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.lblActiveProject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblActiveProject.Location = New System.Drawing.Point(1, 2)
		Me.lblActiveProject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblActiveProject.Name = "lblActiveProject"
		Me.lblActiveProject.Size = New System.Drawing.Size(231, 23)
		Me.lblActiveProject.TabIndex = 7
		Me.lblActiveProject.Text = "Welcome to Blocks!"
		'
		'btnAddProject
		'
		Me.btnAddProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnAddProject.Image = CType(resources.GetObject("btnAddProject.Image"), System.Drawing.Image)
		Me.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAddProject.Location = New System.Drawing.Point(13, 474)
		Me.btnAddProject.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnAddProject.Name = "btnAddProject"
		Me.btnAddProject.Padding = New System.Windows.Forms.Padding(1, 0, 4, 0)
		Me.btnAddProject.Size = New System.Drawing.Size(105, 30)
		Me.btnAddProject.TabIndex = 8
		Me.btnAddProject.Text = "Add project"
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
		Me.lstSessions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
		Me.lstSessions.ContextMenuStrip = Me.ContextMenuStrip1
		Me.lstSessions.HideSelection = False
		Me.lstSessions.LargeImageList = Me.ImageList1
		Me.lstSessions.Location = New System.Drawing.Point(4, 150)
		Me.lstSessions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.lstSessions.Name = "lstSessions"
		Me.lstSessions.ShowItemToolTips = True
		Me.lstSessions.Size = New System.Drawing.Size(204, 285)
		Me.lstSessions.SmallImageList = Me.ImageList1
		Me.lstSessions.TabIndex = 10
		Me.lstSessions.TileSize = New System.Drawing.Size(150, 30)
		Me.lstSessions.UseCompatibleStateImageBehavior = False
		Me.lstSessions.View = System.Windows.Forms.View.Tile
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DurationViewToolStripMenuItem, Me.UseGroupsToolStripMenuItem, Me.ToolStripSeparator2, Me.DiscardSessionToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 76)
		'
		'DurationViewToolStripMenuItem
		'
		Me.DurationViewToolStripMenuItem.CheckOnClick = True
		Me.DurationViewToolStripMenuItem.Image = CType(resources.GetObject("DurationViewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DurationViewToolStripMenuItem.Name = "DurationViewToolStripMenuItem"
		Me.DurationViewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.DurationViewToolStripMenuItem.Text = "Duration view"
		'
		'UseGroupsToolStripMenuItem
		'
		Me.UseGroupsToolStripMenuItem.CheckOnClick = True
		Me.UseGroupsToolStripMenuItem.Image = CType(resources.GetObject("UseGroupsToolStripMenuItem.Image"), System.Drawing.Image)
		Me.UseGroupsToolStripMenuItem.Name = "UseGroupsToolStripMenuItem"
		Me.UseGroupsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.UseGroupsToolStripMenuItem.Text = "Group by date"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(146, 6)
		Me.ToolStripSeparator2.Visible = False
		'
		'DiscardSessionToolStripMenuItem
		'
		Me.DiscardSessionToolStripMenuItem.Image = CType(resources.GetObject("DiscardSessionToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DiscardSessionToolStripMenuItem.Name = "DiscardSessionToolStripMenuItem"
		Me.DiscardSessionToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.DiscardSessionToolStripMenuItem.Text = "Delete session"
		Me.DiscardSessionToolStripMenuItem.Visible = False
		'
		'picRecording
		'
		Me.picRecording.Image = CType(resources.GetObject("picRecording.Image"), System.Drawing.Image)
		Me.picRecording.Location = New System.Drawing.Point(154, 122)
		Me.picRecording.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.picRecording.Name = "picRecording"
		Me.picRecording.Size = New System.Drawing.Size(16, 16)
		Me.picRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picRecording.TabIndex = 11
		Me.picRecording.TabStop = False
		Me.picRecording.Visible = False
		'
		'btnSave
		'
		Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
		Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSave.Location = New System.Drawing.Point(453, 474)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Padding = New System.Windows.Forms.Padding(1, 0, 4, 0)
		Me.btnSave.Size = New System.Drawing.Size(71, 30)
		Me.btnSave.TabIndex = 12
		Me.btnSave.Text = "Save"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnLoadData
		'
		Me.btnLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnLoadData.Image = CType(resources.GetObject("btnLoadData.Image"), System.Drawing.Image)
		Me.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLoadData.Location = New System.Drawing.Point(531, 474)
		Me.btnLoadData.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnLoadData.Name = "btnLoadData"
		Me.btnLoadData.Padding = New System.Windows.Forms.Padding(1, 0, 4, 0)
		Me.btnLoadData.Size = New System.Drawing.Size(76, 30)
		Me.btnLoadData.TabIndex = 14
		Me.btnLoadData.Text = "Reload"
		Me.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnLoadData.UseVisualStyleBackColor = True
		'
		'picSaveError
		'
		Me.picSaveError.Image = CType(resources.GetObject("picSaveError.Image"), System.Drawing.Image)
		Me.picSaveError.Location = New System.Drawing.Point(4, 1)
		Me.picSaveError.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.picSaveError.Name = "picSaveError"
		Me.picSaveError.Size = New System.Drawing.Size(16, 16)
		Me.picSaveError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picSaveError.TabIndex = 15
		Me.picSaveError.TabStop = False
		'
		'btnRetrySave
		'
		Me.btnRetrySave.AutoSize = True
		Me.btnRetrySave.Location = New System.Drawing.Point(26, 3)
		Me.btnRetrySave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.btnRetrySave.Name = "btnRetrySave"
		Me.btnRetrySave.Size = New System.Drawing.Size(65, 15)
		Me.btnRetrySave.TabIndex = 16
		Me.btnRetrySave.TabStop = True
		Me.btnRetrySave.Text = "Retry save?"
		Me.btnRetrySave.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Panel2
		'
		Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel2.AutoSize = True
		Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Panel2.Controls.Add(Me.btnRetrySave)
		Me.Panel2.Controls.Add(Me.picSaveError)
		Me.Panel2.Location = New System.Drawing.Point(352, 479)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(95, 20)
		Me.Panel2.TabIndex = 17
		Me.Panel2.Visible = False
		'
		'ContextMenuStrip2
		'
		Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorizeToolStripMenuItem, Me.AddProjectToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteProjectToolStripMenuItem})
		Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
		Me.ContextMenuStrip2.Size = New System.Drawing.Size(148, 76)
		'
		'CategorizeToolStripMenuItem
		'
		Me.CategorizeToolStripMenuItem.Image = CType(resources.GetObject("CategorizeToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CategorizeToolStripMenuItem.Name = "CategorizeToolStripMenuItem"
		Me.CategorizeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
		Me.CategorizeToolStripMenuItem.Text = "Set group..."
		'
		'AddProjectToolStripMenuItem
		'
		Me.AddProjectToolStripMenuItem.Image = CType(resources.GetObject("AddProjectToolStripMenuItem.Image"), System.Drawing.Image)
		Me.AddProjectToolStripMenuItem.Name = "AddProjectToolStripMenuItem"
		Me.AddProjectToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
		Me.AddProjectToolStripMenuItem.Text = "Add project"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(144, 6)
		'
		'DeleteProjectToolStripMenuItem
		'
		Me.DeleteProjectToolStripMenuItem.Enabled = False
		Me.DeleteProjectToolStripMenuItem.Image = CType(resources.GetObject("DeleteProjectToolStripMenuItem.Image"), System.Drawing.Image)
		Me.DeleteProjectToolStripMenuItem.Name = "DeleteProjectToolStripMenuItem"
		Me.DeleteProjectToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
		Me.DeleteProjectToolStripMenuItem.Text = "Delete project"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar1.Location = New System.Drawing.Point(237, 58)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(142, 23)
		Me.ProgressBar1.TabIndex = 53
		Me.ToolTip1.SetToolTip(Me.ProgressBar1, "Total progress")
		'
		'ProgressBar2
		'
		Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar2.Location = New System.Drawing.Point(237, 87)
		Me.ProgressBar2.Name = "ProgressBar2"
		Me.ProgressBar2.Size = New System.Drawing.Size(142, 23)
		Me.ProgressBar2.TabIndex = 54
		Me.ToolTip1.SetToolTip(Me.ProgressBar2, "Component progress")
		'
		'ProgressBar3
		'
		Me.ProgressBar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar3.Location = New System.Drawing.Point(237, 29)
		Me.ProgressBar3.Name = "ProgressBar3"
		Me.ProgressBar3.Size = New System.Drawing.Size(89, 23)
		Me.ProgressBar3.TabIndex = 55
		Me.ToolTip1.SetToolTip(Me.ProgressBar3, "Target progress")
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 1000
		'
		'FileSystemWatcher1
		'
		Me.FileSystemWatcher1.EnableRaisingEvents = True
		Me.FileSystemWatcher1.Filter = "hours_data.xml"
		Me.FileSystemWatcher1.Path = "."
		Me.FileSystemWatcher1.SynchronizingObject = Me
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
		Me.splitProjects.Panel1.Controls.Add(Me.lstProjects)
		Me.splitProjects.Panel2Collapsed = True
		Me.splitProjects.Size = New System.Drawing.Size(204, 461)
		Me.splitProjects.SplitterDistance = 213
		Me.splitProjects.SplitterWidth = 5
		Me.splitProjects.TabIndex = 43
		'
		'lstProjects
		'
		Me.lstProjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
		Me.lstProjects.ContextMenuStrip = Me.ContextMenuStrip2
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
		Me.lstProjects.Size = New System.Drawing.Size(204, 461)
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
		Me.splitMain.Panel2.Controls.Add(Me.Panel1)
		Me.splitMain.Size = New System.Drawing.Size(594, 461)
		Me.splitMain.SplitterDistance = 204
		Me.splitMain.SplitterWidth = 5
		Me.splitMain.TabIndex = 44
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.PictureBox5)
		Me.Panel1.Controls.Add(Me.PictureBox4)
		Me.Panel1.Controls.Add(Me.PictureBox3)
		Me.Panel1.Controls.Add(Me.ProgressBar3)
		Me.Panel1.Controls.Add(Me.txtTimeTotal)
		Me.Panel1.Controls.Add(Me.ProgressBar2)
		Me.Panel1.Controls.Add(Me.ProgressBar1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Controls.Add(Me.ListView1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.btnRename)
		Me.Panel1.Controls.Add(Me.btnTarget)
		Me.Panel1.Controls.Add(Me.btnPause)
		Me.Panel1.Controls.Add(Me.btnStart)
		Me.Panel1.Controls.Add(Me.lblActiveProject)
		Me.Panel1.Controls.Add(Me.lstSessions)
		Me.Panel1.Controls.Add(Me.picRecording)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(385, 461)
		Me.Panel1.TabIndex = 0
		'
		'Button2
		'
		Me.Button2.Enabled = False
		Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button2.Location = New System.Drawing.Point(104, 54)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 27)
		Me.Button2.TabIndex = 61
		Me.Button2.Text = "Recent"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.Location = New System.Drawing.Point(3, 25)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 27)
		Me.Button1.TabIndex = 60
		Me.Button1.Text = "Group"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(332, 33)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(47, 15)
		Me.Label4.TabIndex = 59
		Me.Label4.Text = "Day 1/4"
		'
		'PictureBox5
		'
		Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
		Me.PictureBox5.Location = New System.Drawing.Point(215, 92)
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
		Me.PictureBox4.Location = New System.Drawing.Point(215, 61)
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
		Me.PictureBox3.Location = New System.Drawing.Point(215, 31)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox3.TabIndex = 56
		Me.PictureBox3.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(26, 95)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 15)
		Me.Label2.TabIndex = 49
		Me.Label2.Text = "Timeline"
		'
		'Label3
		'
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.Label3.Location = New System.Drawing.Point(79, 91)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 22)
		Me.Label3.TabIndex = 52
		Me.Label3.Text = "0 minutes"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label3.Visible = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(4, 94)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PictureBox2.TabIndex = 51
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(215, 8)
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
		Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.ListView1.HideSelection = False
		Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
		Me.ListView1.LargeImageList = Me.ImageList1
		Me.ListView1.Location = New System.Drawing.Point(213, 122)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.ShowItemToolTips = True
		Me.ListView1.Size = New System.Drawing.Size(166, 339)
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
		Me.Label1.Location = New System.Drawing.Point(234, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(37, 15)
		Me.Label1.TabIndex = 47
		Me.Label1.Text = "Goals"
		'
		'btnRename
		'
		Me.btnRename.Image = CType(resources.GetObject("btnRename.Image"), System.Drawing.Image)
		Me.btnRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRename.Location = New System.Drawing.Point(104, 25)
		Me.btnRename.Name = "btnRename"
		Me.btnRename.Size = New System.Drawing.Size(95, 27)
		Me.btnRename.TabIndex = 46
		Me.btnRename.Text = "Rename"
		Me.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnRename.UseVisualStyleBackColor = True
		'
		'btnTarget
		'
		Me.btnTarget.Image = CType(resources.GetObject("btnTarget.Image"), System.Drawing.Image)
		Me.btnTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnTarget.Location = New System.Drawing.Point(4, 54)
		Me.btnTarget.Name = "btnTarget"
		Me.btnTarget.Size = New System.Drawing.Size(94, 27)
		Me.btnTarget.TabIndex = 45
		Me.btnTarget.Text = "Target"
		Me.btnTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnTarget.UseVisualStyleBackColor = True
		'
		'Timer2
		'
		Me.Timer2.Interval = 1000
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(617, 516)
		Me.Controls.Add(Me.splitMain)
		Me.Controls.Add(Me.btnLoadData)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnAddProject)
		Me.Controls.Add(Me.Panel2)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MinimumSize = New System.Drawing.Size(505, 317)
		Me.Name = "frmMain"
		Me.Text = "Blocks"
		Me.ContextMenuStrip1.ResumeLayout(False)
		CType(Me.picRecording, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ContextMenuStrip2.ResumeLayout(False)
		CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitProjects.Panel1.ResumeLayout(False)
		CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitProjects.ResumeLayout(False)
		Me.splitMain.Panel1.ResumeLayout(False)
		Me.splitMain.Panel2.ResumeLayout(False)
		CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitMain.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnLoadData As System.Windows.Forms.Button
	Friend WithEvents picSaveError As System.Windows.Forms.PictureBox
	Friend WithEvents btnRetrySave As System.Windows.Forms.LinkLabel
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents UseGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents DurationViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents CategorizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
	Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
	Friend WithEvents lstProjects As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents splitMain As System.Windows.Forms.SplitContainer
	Friend WithEvents Timer2 As System.Windows.Forms.Timer
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnRename As Button
	Friend WithEvents btnTarget As Button
	Friend WithEvents AddProjectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ListView1 As ListView
	Friend WithEvents ColumnHeader4 As ColumnHeader
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents DiscardSessionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Timer3 As Timer
	Friend WithEvents DeleteProjectToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProgressBar3 As ProgressBar
	Friend WithEvents ProgressBar2 As ProgressBar
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
