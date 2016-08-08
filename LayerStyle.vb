Public Class LayerStyle
    Public Enum LayerStyleType
        Area = 0
        Line = 1
        Point = 2
    End Enum

    Public Property Type As LayerStyleType
    Public Property Rules As New List(Of LayerStyleRule)
End Class