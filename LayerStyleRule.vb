Public Class LayerStyleRule
    Public Property LegendLabel As String = ""
    Public Property Filter As String = ""
    Public Property Fill As New StyleRuleFill
    Public Property Stroke As New List(Of StyleRuleStroke)
    Public Property Label As New StyleRuleLabel
End Class