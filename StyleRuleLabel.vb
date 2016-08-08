Public Class StyleRuleLabel
    Public Property Unit As String = ""
    Public Property SizeContext As String = ""
    Public Property SizeX As String = ""
    Public Property SizeY As String = ""
    Public Property Rotation As String = ""
    Public Property Text As String = ""
    Public Property FontName As String = ""
    Public Property ForegroundColor As String = ""
    Public Property BackgroundColor As String = ""
    Public Property BackgroundStyle As String = ""
    Public Property HorizontalAlignment As String = ""
    Public Property Italic As Boolean = False
    Public Property Bold As Boolean = False
    Public Property Underlined As Boolean = False
    Public Property AdvancedPlacement As New StyleRuleLabelAdvancedPlacement
End Class

Public Class StyleRuleLabelAdvancedPlacement
    Public Property ScaleLimit As String = ""
End Class