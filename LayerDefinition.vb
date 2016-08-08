Public Class LayerDefinition
    Public Property ResourceId As String = ""
    Public Property FeatureName As String = ""
    Public Property FeatureNameType As String = ""
    Public Property PropertyMapping As New List(Of PropertyMapping)
    Public Property Geometry As String = ""
    Public Property ToolTip As String = ""
    Public Property VectorScaleRange As New List(Of VectorScaleRange)
End Class