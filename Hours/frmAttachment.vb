Public Class frmAttachment

    Private Sub frmAttachment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If lstIcon.Items.Count = 0 Then
            lstIcon.LargeImageList = frmMain.ImageList1
            Dim index As Int32 = 0
            For Each Image As Image In frmMain.ImageList1.Images
                lstIcon.Items.Add("", index)
                index += 1
            Next
        End If
    End Sub
End Class