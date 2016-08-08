Public Class ResourceItem
    Public Property ResourceId As String = ""
    Public Property Depth As Integer = 1
    Public Property Owner As String = ""
    Public Property CreatedDate As String = ""
    Public Property ModifiedDate As String = ""
    Public Property NumberOfFolders As Integer = 0
    Public Property NumberOfDocuments As Integer = 0
    Public Property ResourceDocumentIconName As String = ""
    Public Property Security As New ResourceFolderSecurity
End Class