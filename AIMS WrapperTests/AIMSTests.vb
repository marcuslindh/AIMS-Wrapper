Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports AIMS

Namespace AIMS.Tests
    <TestClass()> Public Class AIMSTests

        Private Property _Login As New LoginSettings
        Public ReadOnly Property Login As LoginSettings
            Get
                If _Login.Username = "" Then
                    If IO.File.Exists("c:\temp\AIMS_Wrapper_Login.txt") Then
                        Dim text As String = My.Computer.FileSystem.ReadAllText("c:\temp\AIMS_Wrapper_Login.txt")
                        Dim lines() As String = text.Split(vbCrLf)
                        _Login.Username = lines(0).Trim()
                        _Login.Password = lines(1).Trim()
                        _Login.Site = lines(2).Trim()
                    End If
                End If
                Return _Login
            End Get
        End Property

        <TestMethod()> Public Sub GetServerVersionTest()
            Dim AIMSServer As New Server
            AIMSServer.Login(Login.Username, Login.Password, Login.Site)

            Assert.AreEqual(AIMSServer.GetServerVersion.Substring(0, 2), "2.")
        End Sub

        <TestMethod()> Public Sub GetServerInfo()
            Dim AIMSServer As New Server
            AIMSServer.Login(Login.Username, Login.Password, Login.Site)

            Dim info = AIMSServer.GetServerInfo

            Assert.AreEqual(info.Status, "Online")
        End Sub
    End Class


End Namespace

Public Class LoginSettings
    Public Property Username As String = ""
    Public Property Password As String = ""
    Public Property Site As String = ""
End Class
