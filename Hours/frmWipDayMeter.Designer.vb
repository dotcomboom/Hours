<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWipDayMeter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWipDayMeter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeStart = New System.Windows.Forms.DateTimePicker()
        Me.timeFinish = New System.Windows.Forms.DateTimePicker()
        Me.progressMeter = New System.Windows.Forms.ProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start the day meter at:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End the day meter at:"
        '
        'timeStart
        '
        Me.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeStart.Location = New System.Drawing.Point(129, 9)
        Me.timeStart.Name = "timeStart"
        Me.timeStart.ShowUpDown = True
        Me.timeStart.Size = New System.Drawing.Size(151, 20)
        Me.timeStart.TabIndex = 1
        Me.timeStart.Value = New Date(2024, 8, 6, 10, 0, 0, 0)
        '
        'timeFinish
        '
        Me.timeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeFinish.Location = New System.Drawing.Point(129, 40)
        Me.timeFinish.Name = "timeFinish"
        Me.timeFinish.ShowUpDown = True
        Me.timeFinish.Size = New System.Drawing.Size(151, 20)
        Me.timeFinish.TabIndex = 3
        Me.timeFinish.Value = New Date(2024, 8, 6, 22, 0, 0, 0)
        '
        'progressMeter
        '
        Me.progressMeter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressMeter.Location = New System.Drawing.Point(15, 72)
        Me.progressMeter.Name = "progressMeter"
        Me.progressMeter.Size = New System.Drawing.Size(265, 23)
        Me.progressMeter.Step = 1
        Me.progressMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressMeter.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(111, 107)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnCancel.Size = New System.Drawing.Size(71, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(188, 107)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.btnOK.Size = New System.Drawing.Size(92, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "Looks good"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.Location = New System.Drawing.Point(12, 102)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(68, 27)
        Me.lblStart.TabIndex = 5
        Me.lblStart.Text = "Label3"
        Me.lblStart.Visible = False
        '
        'lblNow
        '
        Me.lblNow.Location = New System.Drawing.Point(86, 102)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(116, 27)
        Me.lblNow.TabIndex = 6
        Me.lblNow.Text = "Label4"
        Me.lblNow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNow.Visible = False
        '
        'lblEnd
        '
        Me.lblEnd.Location = New System.Drawing.Point(208, 102)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(72, 27)
        Me.lblEnd.TabIndex = 7
        Me.lblEnd.Text = "Label5"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblEnd.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'frmDayMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 143)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.progressMeter)
        Me.Controls.Add(Me.timeFinish)
        Me.Controls.Add(Me.timeStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblEnd)
        Me.Name = "frmDayMeter"
        Me.Text = "frmDayMeter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeFinish As System.Windows.Forms.DateTimePicker
    Friend WithEvents progressMeter As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblNow As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
