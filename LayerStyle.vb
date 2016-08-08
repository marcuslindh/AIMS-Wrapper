Public Class LayerStyle
    Public Enum LayerStyleType
        Area = 1
        Line = 2
        Point = 3
    End Enum

    Public Property Type As LayerStyleType
    Public Property Rules As New List(Of LayerStyleRule)
End Class