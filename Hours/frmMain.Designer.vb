<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtTimeTotal = New System.Windows.Forms.Label()
        Me.lblTimeTotal = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.txtTimeToday = New System.Windows.Forms.Label()
        Me.lblActiveProject = New System.Windows.Forms.Label()
        Me.btnAddProject = New System.Windows.Forms.Button()
        Me.btnCommentView = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lstSessions = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UseGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picRecording = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoadData = New System.Windows.Forms.Button()
        Me.picSaveError = New System.Windows.Forms.PictureBox()
        Me.btnRetrySave = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCSVExport = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CategorizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupByCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCategoryView = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.progressDayMeter = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.picDayMeter = New System.Windows.Forms.PictureBox()
        Me.lstAttachments = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picAttach = New System.Windows.Forms.PictureBox()
        Me.picTimer = New System.Windows.Forms.PictureBox()
        Me.picTask = New System.Windows.Forms.PictureBox()
        Me.splitAttachments = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNighttime = New System.Windows.Forms.Label()
        Me.activeQuest = New System.Windows.Forms.Label()
        Me.progressSprint = New System.Windows.Forms.ProgressBar()
        Me.time1 = New System.Windows.Forms.DateTimePicker()
        Me.time2 = New System.Windows.Forms.DateTimePicker()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.lstProjects = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.splitMain = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblBattingAverage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn5Min = New System.Windows.Forms.Button()
        Me.btn10Min = New System.Windows.Forms.Button()
        Me.btn50Min = New System.Windows.Forms.Button()
        Me.btn25Min = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picRecording, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDayMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        CType(Me.picAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAttachments.Panel1.SuspendLayout()
        Me.splitAttachments.Panel2.SuspendLayout()
        Me.splitAttachments.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitProjects.Panel1.SuspendLayout()
        Me.splitProjects.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Width = 150
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'btnPause
        '
        Me.btnPause.Enabled = False
        Me.btnPause.Location = New System.Drawing.Point(3, 55)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(3, 26)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtTimeTotal
        '
        Me.txtTimeTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTimeTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTimeTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTimeTotal.Location = New System.Drawing.Point(582, 324)
        Me.txtTimeTotal.Name = "txtTimeTotal"
        Me.txtTimeTotal.Size = New System.Drawing.Size(128, 30)
        Me.txtTimeTotal.TabIndex = 3
        Me.txtTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeTotal
        '
        Me.lblTimeTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeTotal.AutoSize = True
        Me.lblTimeTotal.Location = New System.Drawing.Point(579, 311)
        Me.lblTimeTotal.Name = "lblTimeTotal"
        Me.lblTimeTotal.Size = New System.Drawing.Size(98, 13)
        Me.lblTimeTotal.TabIndex = 4
        Me.lblTimeTotal.Text = "Total time recorded"
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeToday.AutoSize = True
        Me.lblTimeToday.Location = New System.Drawing.Point(421, 311)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(59, 13)
        Me.lblTimeToday.TabIndex = 6
        Me.lblTimeToday.Text = "Time today"
        '
        'txtTimeToday
        '
        Me.txtTimeToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTimeToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTimeToday.Location = New System.Drawing.Point(424, 324)
        Me.txtTimeToday.Name = "txtTimeToday"
        Me.txtTimeToday.Size = New System.Drawing.Size(151, 30)
        Me.txtTimeToday.TabIndex = 5
        Me.txtTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActiveProject
        '
        Me.lblActiveProject.AutoEllipsis = True
        Me.lblActiveProject.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblActiveProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveProject.Location = New System.Drawing.Point(1, 2)
        Me.lblActiveProject.Name = "lblActiveProject"
        Me.lblActiveProject.Size = New System.Drawing.Size(243, 20)
        Me.lblActiveProject.TabIndex = 7
        Me.lblActiveProject.Text = "Welcome to Hours!"
        '
        'btnAddProject
        '
        Me.btnAddProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddProject.Image = CType(resources.GetObject("btnAddProject.Image"), System.Drawing.Image)
        Me.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProject.Location = New System.Drawing.Point(13, 362)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnAddProject.Size = New System.Drawing.Size(90, 26)
        Me.btnAddProject.TabIndex = 8
        Me.btnAddProject.Text = "Add project"
        Me.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProject.UseVisualStyleBackColor = True
        '
        'btnCommentView
        '
        Me.btnCommentView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommentView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommentView.ImageIndex = 2
        Me.btnCommentView.ImageList = Me.ImageList1
        Me.btnCommentView.Location = New System.Drawing.Point(379, 0)
        Me.btnCommentView.Name = "btnCommentView"
        Me.btnCommentView.Size = New System.Drawing.Size(107, 27)
        Me.btnCommentView.TabIndex = 25
        Me.btnCommentView.Text = "Comment view"
        Me.btnCommentView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnCommentView, "Comment view")
        Me.btnCommentView.UseVisualStyleBackColor = True
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
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSessions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        Me.lstSessions.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstSessions.LargeImageList = Me.ImageList1
        Me.lstSessions.Location = New System.Drawing.Point(292, 33)
        Me.lstSessions.Name = "lstSessions"
        Me.lstSessions.ShowItemToolTips = True
        Me.lstSessions.Size = New System.Drawing.Size(194, 257)
        Me.lstSessions.SmallImageList = Me.ImageList1
        Me.lstSessions.TabIndex = 10
        Me.lstSessions.TileSize = New System.Drawing.Size(150, 30)
        Me.lstSessions.UseCompatibleStateImageBehavior = False
        Me.lstSessions.View = System.Windows.Forms.View.Tile
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseGroupsToolStripMenuItem, Me.ShowCommentsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 48)
        '
        'UseGroupsToolStripMenuItem
        '
        Me.UseGroupsToolStripMenuItem.CheckOnClick = True
        Me.UseGroupsToolStripMenuItem.Image = CType(resources.GetObject("UseGroupsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UseGroupsToolStripMenuItem.Name = "UseGroupsToolStripMenuItem"
        Me.UseGroupsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UseGroupsToolStripMenuItem.Text = "Group by date"
        '
        'ShowCommentsToolStripMenuItem
        '
        Me.ShowCommentsToolStripMenuItem.CheckOnClick = True
        Me.ShowCommentsToolStripMenuItem.Image = CType(resources.GetObject("ShowCommentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowCommentsToolStripMenuItem.Name = "ShowCommentsToolStripMenuItem"
        Me.ShowCommentsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ShowCommentsToolStripMenuItem.Text = "Comment view"
        '
        'picRecording
        '
        Me.picRecording.Image = CType(resources.GetObject("picRecording.Image"), System.Drawing.Image)
        Me.picRecording.Location = New System.Drawing.Point(3, 85)
        Me.picRecording.Name = "picRecording"
        Me.picRecording.Size = New System.Drawing.Size(16, 16)
        Me.picRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRecording.TabIndex = 11
        Me.picRecording.TabStop = False
        Me.picRecording.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(109, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnSave.Size = New System.Drawing.Size(61, 26)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoadData
        '
        Me.btnLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadData.Image = CType(resources.GetObject("btnLoadData.Image"), System.Drawing.Image)
        Me.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadData.Location = New System.Drawing.Point(205, 362)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnLoadData.Size = New System.Drawing.Size(90, 26)
        Me.btnLoadData.TabIndex = 14
        Me.btnLoadData.Text = "Load data"
        Me.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'picSaveError
        '
        Me.picSaveError.Image = CType(resources.GetObject("picSaveError.Image"), System.Drawing.Image)
        Me.picSaveError.Location = New System.Drawing.Point(3, 1)
        Me.picSaveError.Name = "picSaveError"
        Me.picSaveError.Size = New System.Drawing.Size(16, 16)
        Me.picSaveError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSaveError.TabIndex = 15
        Me.picSaveError.TabStop = False
        '
        'btnRetrySave
        '
        Me.btnRetrySave.AutoSize = True
        Me.btnRetrySave.Location = New System.Drawing.Point(22, 3)
        Me.btnRetrySave.Name = "btnRetrySave"
        Me.btnRetrySave.Size = New System.Drawing.Size(64, 13)
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
        Me.Panel2.Location = New System.Drawing.Point(618, 369)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(89, 20)
        Me.Panel2.TabIndex = 17
        Me.Panel2.Visible = False
        '
        'btnCSVExport
        '
        Me.btnCSVExport.AccessibleName = "Export to CSV"
        Me.btnCSVExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCSVExport.Image = CType(resources.GetObject("btnCSVExport.Image"), System.Drawing.Image)
        Me.btnCSVExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCSVExport.Location = New System.Drawing.Point(171, 362)
        Me.btnCSVExport.Name = "btnCSVExport"
        Me.btnCSVExport.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnCSVExport.Size = New System.Drawing.Size(28, 26)
        Me.btnCSVExport.TabIndex = 23
        Me.btnCSVExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCSVExport.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorizeToolStripMenuItem, Me.ToolStripSeparator1, Me.GroupByCategoryToolStripMenuItem, Me.HighlightTodayToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(192, 76)
        '
        'CategorizeToolStripMenuItem
        '
        Me.CategorizeToolStripMenuItem.Image = CType(resources.GetObject("CategorizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategorizeToolStripMenuItem.Name = "CategorizeToolStripMenuItem"
        Me.CategorizeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CategorizeToolStripMenuItem.Text = "Set category..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'GroupByCategoryToolStripMenuItem
        '
        Me.GroupByCategoryToolStripMenuItem.CheckOnClick = True
        Me.GroupByCategoryToolStripMenuItem.Image = CType(resources.GetObject("GroupByCategoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GroupByCategoryToolStripMenuItem.Name = "GroupByCategoryToolStripMenuItem"
        Me.GroupByCategoryToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GroupByCategoryToolStripMenuItem.Text = "Use categories"
        '
        'HighlightTodayToolStripMenuItem
        '
        Me.HighlightTodayToolStripMenuItem.CheckOnClick = True
        Me.HighlightTodayToolStripMenuItem.Image = CType(resources.GetObject("HighlightTodayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HighlightTodayToolStripMenuItem.Name = "HighlightTodayToolStripMenuItem"
        Me.HighlightTodayToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HighlightTodayToolStripMenuItem.Text = "Mark today's activities"
        '
        'btnCategoryView
        '
        Me.btnCategoryView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCategoryView.Enabled = False
        Me.btnCategoryView.Image = CType(resources.GetObject("btnCategoryView.Image"), System.Drawing.Image)
        Me.btnCategoryView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoryView.Location = New System.Drawing.Point(13, 304)
        Me.btnCategoryView.Name = "btnCategoryView"
        Me.btnCategoryView.Size = New System.Drawing.Size(102, 27)
        Me.btnCategoryView.TabIndex = 28
        Me.btnCategoryView.Text = "Category view"
        Me.btnCategoryView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnCategoryView, "Category view")
        Me.btnCategoryView.UseVisualStyleBackColor = True
        Me.btnCategoryView.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(301, 362)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnAbout.Size = New System.Drawing.Size(72, 26)
        Me.btnAbout.TabIndex = 29
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'progressDayMeter
        '
        Me.progressDayMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.progressDayMeter.Location = New System.Drawing.Point(13, 334)
        Me.progressDayMeter.Name = "progressDayMeter"
        Me.progressDayMeter.Size = New System.Drawing.Size(132, 20)
        Me.progressDayMeter.TabIndex = 30
        Me.progressDayMeter.Visible = False
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
        'picDayMeter
        '
        Me.picDayMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picDayMeter.Image = CType(resources.GetObject("picDayMeter.Image"), System.Drawing.Image)
        Me.picDayMeter.Location = New System.Drawing.Point(13, 315)
        Me.picDayMeter.Name = "picDayMeter"
        Me.picDayMeter.Size = New System.Drawing.Size(16, 16)
        Me.picDayMeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDayMeter.TabIndex = 31
        Me.picDayMeter.TabStop = False
        Me.picDayMeter.Visible = False
        '
        'lstAttachments
        '
        Me.lstAttachments.AllowDrop = True
        Me.lstAttachments.ContextMenuStrip = Me.ContextMenuStrip3
        Me.lstAttachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAttachments.LabelEdit = True
        Me.lstAttachments.LargeImageList = Me.ImageList1
        Me.lstAttachments.Location = New System.Drawing.Point(0, 0)
        Me.lstAttachments.Name = "lstAttachments"
        Me.lstAttachments.ShowItemToolTips = True
        Me.lstAttachments.Size = New System.Drawing.Size(284, 129)
        Me.lstAttachments.SmallImageList = Me.ImageList1
        Me.lstAttachments.TabIndex = 20
        Me.lstAttachments.UseCompatibleStateImageBehavior = False
        Me.lstAttachments.View = System.Windows.Forms.View.Tile
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(159, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditToolStripMenuItem.Text = "Edit attachment"
        '
        'picAttach
        '
        Me.picAttach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picAttach.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picAttach.Image = CType(resources.GetObject("picAttach.Image"), System.Drawing.Image)
        Me.picAttach.Location = New System.Drawing.Point(0, 11)
        Me.picAttach.Name = "picAttach"
        Me.picAttach.Size = New System.Drawing.Size(16, 16)
        Me.picAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAttach.TabIndex = 22
        Me.picAttach.TabStop = False
        '
        'picTimer
        '
        Me.picTimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTimer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picTimer.Image = CType(resources.GetObject("picTimer.Image"), System.Drawing.Image)
        Me.picTimer.Location = New System.Drawing.Point(22, 11)
        Me.picTimer.Name = "picTimer"
        Me.picTimer.Size = New System.Drawing.Size(16, 16)
        Me.picTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTimer.TabIndex = 25
        Me.picTimer.TabStop = False
        Me.picTimer.Visible = False
        '
        'picTask
        '
        Me.picTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTask.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picTask.Image = CType(resources.GetObject("picTask.Image"), System.Drawing.Image)
        Me.picTask.Location = New System.Drawing.Point(44, 11)
        Me.picTask.Name = "picTask"
        Me.picTask.Size = New System.Drawing.Size(16, 16)
        Me.picTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTask.TabIndex = 26
        Me.picTask.TabStop = False
        Me.picTask.Visible = False
        '
        'splitAttachments
        '
        Me.splitAttachments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitAttachments.Location = New System.Drawing.Point(2, 130)
        Me.splitAttachments.Name = "splitAttachments"
        Me.splitAttachments.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitAttachments.Panel1
        '
        Me.splitAttachments.Panel1.Controls.Add(Me.PictureBox1)
        Me.splitAttachments.Panel1.Controls.Add(Me.picTask)
        Me.splitAttachments.Panel1.Controls.Add(Me.picTimer)
        Me.splitAttachments.Panel1.Controls.Add(Me.picAttach)
        Me.splitAttachments.Panel1MinSize = 24
        '
        'splitAttachments.Panel2
        '
        Me.splitAttachments.Panel2.Controls.Add(Me.lstAttachments)
        Me.splitAttachments.Panel2MinSize = 0
        Me.splitAttachments.Size = New System.Drawing.Size(284, 160)
        Me.splitAttachments.SplitterDistance = 27
        Me.splitAttachments.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblNighttime
        '
        Me.lblNighttime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNighttime.Location = New System.Drawing.Point(46, 315)
        Me.lblNighttime.Name = "lblNighttime"
        Me.lblNighttime.Size = New System.Drawing.Size(100, 16)
        Me.lblNighttime.TabIndex = 32
        Me.lblNighttime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNighttime.Visible = False
        '
        'activeQuest
        '
        Me.activeQuest.AutoSize = True
        Me.activeQuest.Location = New System.Drawing.Point(1, 20)
        Me.activeQuest.Name = "activeQuest"
        Me.activeQuest.Size = New System.Drawing.Size(66, 13)
        Me.activeQuest.TabIndex = 36
        Me.activeQuest.Text = "Active intent"
        Me.activeQuest.Visible = False
        '
        'progressSprint
        '
        Me.progressSprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.progressSprint.Location = New System.Drawing.Point(36, 334)
        Me.progressSprint.Name = "progressSprint"
        Me.progressSprint.Size = New System.Drawing.Size(143, 20)
        Me.progressSprint.TabIndex = 37
        '
        'time1
        '
        Me.time1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.time1.CustomFormat = "h:mm tt"
        Me.time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time1.Location = New System.Drawing.Point(35, 311)
        Me.time1.Name = "time1"
        Me.time1.ShowUpDown = True
        Me.time1.Size = New System.Drawing.Size(68, 20)
        Me.time1.TabIndex = 38
        Me.time1.Value = New Date(2024, 9, 17, 18, 0, 0, 0)
        '
        'time2
        '
        Me.time2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.time2.CustomFormat = "h:mm tt"
        Me.time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time2.Location = New System.Drawing.Point(109, 311)
        Me.time2.Name = "time2"
        Me.time2.ShowUpDown = True
        Me.time2.Size = New System.Drawing.Size(70, 20)
        Me.time2.TabIndex = 39
        Me.time2.Value = New Date(2024, 9, 17, 20, 0, 0, 0)
        '
        'splitProjects
        '
        Me.splitProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitProjects.Location = New System.Drawing.Point(0, 0)
        Me.splitProjects.Name = "splitProjects"
        Me.splitProjects.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitProjects.Panel1
        '
        Me.splitProjects.Panel1.Controls.Add(Me.lstProjects)
        Me.splitProjects.Panel2Collapsed = True
        Me.splitProjects.Size = New System.Drawing.Size(204, 293)
        Me.splitProjects.SplitterDistance = 213
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
        Me.lstProjects.LabelEdit = True
        Me.lstProjects.Location = New System.Drawing.Point(0, 0)
        Me.lstProjects.MultiSelect = False
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(204, 293)
        Me.lstProjects.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstProjects.TabIndex = 2
        Me.lstProjects.TileSize = New System.Drawing.Size(268, 20)
        Me.lstProjects.UseCompatibleStateImageBehavior = False
        Me.lstProjects.View = System.Windows.Forms.View.SmallIcon
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 313)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(185, 313)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'splitMain
        '
        Me.splitMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitMain.Location = New System.Drawing.Point(16, 12)
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
        Me.splitMain.Size = New System.Drawing.Size(694, 293)
        Me.splitMain.SplitterDistance = 204
        Me.splitMain.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.lblBattingAverage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblActiveProject)
        Me.Panel1.Controls.Add(Me.lstSessions)
        Me.Panel1.Controls.Add(Me.btnPause)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.picRecording)
        Me.Panel1.Controls.Add(Me.splitAttachments)
        Me.Panel1.Controls.Add(Me.btnCommentView)
        Me.Panel1.Controls.Add(Me.activeQuest)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 293)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(317, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 46
        Me.PictureBox5.TabStop = False
        '
        'lblBattingAverage
        '
        Me.lblBattingAverage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBattingAverage.AutoSize = True
        Me.lblBattingAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBattingAverage.Location = New System.Drawing.Point(335, 8)
        Me.lblBattingAverage.Name = "lblBattingAverage"
        Me.lblBattingAverage.Size = New System.Drawing.Size(25, 13)
        Me.lblBattingAverage.TabIndex = 45
        Me.lblBattingAverage.Text = "5.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(21, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Currently timed activity"
        Me.Label2.Visible = False
        '
        'btn5Min
        '
        Me.btn5Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn5Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5Min.Image = CType(resources.GetObject("btn5Min.Image"), System.Drawing.Image)
        Me.btn5Min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5Min.Location = New System.Drawing.Point(184, 311)
        Me.btn5Min.Name = "btn5Min"
        Me.btn5Min.Size = New System.Drawing.Size(65, 23)
        Me.btn5Min.TabIndex = 44
        Me.btn5Min.Tag = "5"
        Me.btn5Min.Text = "5 min."
        Me.btn5Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn5Min.UseVisualStyleBackColor = True
        Me.btn5Min.Visible = False
        '
        'btn10Min
        '
        Me.btn10Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn10Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10Min.Image = CType(resources.GetObject("btn10Min.Image"), System.Drawing.Image)
        Me.btn10Min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10Min.Location = New System.Drawing.Point(184, 334)
        Me.btn10Min.Name = "btn10Min"
        Me.btn10Min.Size = New System.Drawing.Size(65, 23)
        Me.btn10Min.TabIndex = 45
        Me.btn10Min.Tag = "10"
        Me.btn10Min.Text = "10 min."
        Me.btn10Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn10Min.UseVisualStyleBackColor = True
        Me.btn10Min.Visible = False
        '
        'btn50Min
        '
        Me.btn50Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn50Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50Min.Image = CType(resources.GetObject("btn50Min.Image"), System.Drawing.Image)
        Me.btn50Min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn50Min.Location = New System.Drawing.Point(250, 334)
        Me.btn50Min.Name = "btn50Min"
        Me.btn50Min.Size = New System.Drawing.Size(65, 23)
        Me.btn50Min.TabIndex = 47
        Me.btn50Min.Tag = "50"
        Me.btn50Min.Text = "50 min."
        Me.btn50Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn50Min.UseVisualStyleBackColor = True
        Me.btn50Min.Visible = False
        '
        'btn25Min
        '
        Me.btn25Min.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn25Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25Min.Image = CType(resources.GetObject("btn25Min.Image"), System.Drawing.Image)
        Me.btn25Min.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn25Min.Location = New System.Drawing.Point(250, 311)
        Me.btn25Min.Name = "btn25Min"
        Me.btn25Min.Size = New System.Drawing.Size(65, 23)
        Me.btn25Min.TabIndex = 46
        Me.btn25Min.Tag = "25"
        Me.btn25Min.Text = "25 min."
        Me.btn25Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn25Min.UseVisualStyleBackColor = True
        Me.btn25Min.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 400)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.time2)
        Me.Controls.Add(Me.time1)
        Me.Controls.Add(Me.progressSprint)
        Me.Controls.Add(Me.lblNighttime)
        Me.Controls.Add(Me.picDayMeter)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.progressDayMeter)
        Me.Controls.Add(Me.btnCSVExport)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnCategoryView)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.txtTimeToday)
        Me.Controls.Add(Me.lblTimeTotal)
        Me.Controls.Add(Me.btnAddProject)
        Me.Controls.Add(Me.txtTimeTotal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn50Min)
        Me.Controls.Add(Me.btn25Min)
        Me.Controls.Add(Me.btn10Min)
        Me.Controls.Add(Me.btn5Min)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(435, 280)
        Me.Name = "frmMain"
        Me.Text = "Hours"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picRecording, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaveError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDayMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        CType(Me.picAttach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAttachments.Panel1.ResumeLayout(False)
        Me.splitAttachments.Panel1.PerformLayout()
        Me.splitAttachments.Panel2.ResumeLayout(False)
        CType(Me.splitAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAttachments.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProjects.Panel1.ResumeLayout(False)
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProjects.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtTimeTotal As System.Windows.Forms.Label
    Friend WithEvents lblTimeTotal As System.Windows.Forms.Label
    Friend WithEvents lblTimeToday As System.Windows.Forms.Label
    Friend WithEvents txtTimeToday As System.Windows.Forms.Label
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
    Friend WithEvents ShowCommentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCSVExport As System.Windows.Forms.Button
    Friend WithEvents btnCommentView As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CategorizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCategoryView As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents progressDayMeter As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HighlightTodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupByCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents picDayMeter As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents splitAttachments As System.Windows.Forms.SplitContainer
    Friend WithEvents picTask As System.Windows.Forms.PictureBox
    Friend WithEvents picTimer As System.Windows.Forms.PictureBox
    Friend WithEvents picAttach As System.Windows.Forms.PictureBox
    Friend WithEvents lstAttachments As System.Windows.Forms.ListView
    Friend WithEvents lblNighttime As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents activeQuest As System.Windows.Forms.Label
    Friend WithEvents progressSprint As System.Windows.Forms.ProgressBar
    Friend WithEvents time2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents lstProjects As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents splitMain As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn5Min As System.Windows.Forms.Button
    Friend WithEvents btn10Min As System.Windows.Forms.Button
    Friend WithEvents btn50Min As System.Windows.Forms.Button
    Friend WithEvents btn25Min As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBattingAverage As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
