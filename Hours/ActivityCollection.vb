Public Class ActivityCollection(Of Activity)
    Implements IEnumerable(Of Activity)

    Dim Activities As New List(Of Activity)

    Public Function GetEnumerator() As IEnumerator(Of Activity) Implements IEnumerable(Of Activity).GetEnumerator
        Return Activities.GetEnumerator()
    End Function

    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return Me.GetEnumerator()
    End Function

    Public Function Item(ByVal index As Integer) As Activity
        Return Activities.Item(index)
    End Function

    Sub Add(ByVal n As Activity)
        Activities.Add(n)
    End Sub


End Class
