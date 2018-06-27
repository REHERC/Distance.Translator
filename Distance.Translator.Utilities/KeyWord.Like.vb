Imports System.Runtime.CompilerServices

Public Module LikeKeyword
    <Extension()>
    Public Function IsLike(Source As String, Pattern As String) As Boolean
        Return Source Like Pattern
    End Function
End Module