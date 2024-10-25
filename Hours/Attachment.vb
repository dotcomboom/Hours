Public Class Attachment
    Public Property Label As String = ""

    Public Property Index As Integer ' order: not necessarily unique
    Public Property Parent As List(Of Attachment)
    Public Property Group As String = ""

    Public Property Path As String ' can be URL, or local
    Public Property ImageIndex As Integer
End Class
