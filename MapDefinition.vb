Public Class MapDefinition
    Public Property Name As String = ""
    Public Property CoordinateSystem As String = ""
    Public Property Extents As New MapDefinitionExtents
    Public Property BackgroundColor As String = ""
    Public Property Metadata As String = ""
    Public Property MapLayers As New List(Of MapLayer)
End Class