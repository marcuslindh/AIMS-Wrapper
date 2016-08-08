Public Class ServerInfo
    Public Property DisplayName As String = ""
    Public Property Status As String = ""
    Public Property Version As String = ""
    Public Property AvailablePhysicalMemory As Long = 0
    Public Property TotalPhysicalMemory As Long = 0
    Public Property AvailableVirtualMemory As Long = 0
    Public Property TotalVirtualMemory As Long = 0
    Public Property OperatingSystemVersion As String = ""
    Public Property AdminOperationsQueueCount As Long = 0
    Public Property ClientOperationsQueueCount As Long = 0
    Public Property SiteOperationsQueueCount As Long = 0
    Public Property AverageOperationTime As Long = 0
    Public Property CpuUtilization As Long = 0
    Public Property TotalOperationTime As Long = 0
    Public Property ActiveConnections As Long = 0
    Public Property TotalConnections As Long = 0
    Public Property TotalOperationsProcessed As Long = 0
    Public Property TotalOperationsReceived As Long = 0
    Public Property Uptime As Long = 0

End Class