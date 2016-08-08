Public Class ResourceFolderSecurity
    Public Property Inherited As Boolean = False
    Public Property Groups As New List(Of ResourceFolderSecurityGroup)
End Class

Public Class ResourceFolderSecurityGroup
    Public Property Name As String = ""
    Public Property Permissions As String = ""
End Class